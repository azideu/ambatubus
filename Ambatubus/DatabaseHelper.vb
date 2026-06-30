Imports Microsoft.Data.SqlClient
Imports System.Windows.Forms
Imports System.Security.Cryptography
Imports System.Text

Public Class DatabaseHelper
    Private Const MasterConnString As String = "Server=(localdb)\MSSQLLocalDB;Integrated Security=True;TrustServerCertificate=True;"
    Private Const DbName As String = "ambatubus"
    Public Const ConnString As String = "Server=(localdb)\MSSQLLocalDB;Database=ambatubus;Integrated Security=True;TrustServerCertificate=True;"

    Public Shared Function HashPassword(password As String) As String
        Using sha As SHA256 = SHA256.Create()
            Dim bytes As Byte() = sha.ComputeHash(Encoding.UTF8.GetBytes(password))
            Dim builder As New StringBuilder()
            For i As Integer = 0 To bytes.Length - 1
                builder.Append(bytes(i).ToString("x2"))
            Next
            Return builder.ToString()
        End Using
    End Function

    Public Shared Sub InitializeDatabase()
        Try
            ' 1. Check if database exists, create if missing
            Using conn As New SqlConnection(MasterConnString)
                conn.Open()
                Dim checkDbCmd As New SqlCommand($"SELECT db_id('{DbName}')", conn)
                Dim dbId = checkDbCmd.ExecuteScalar()

                If dbId Is DBNull.Value OrElse dbId Is Nothing Then
                    Dim createDbCmd As New SqlCommand($"CREATE DATABASE [{DbName}]", conn)
                    createDbCmd.ExecuteNonQuery()
                End If
            End Using

            ' 2. Check and create tables
            Using conn As New SqlConnection(ConnString)
                conn.Open()

                ' Auto-migration: If Passengers table is missing, drop old Bookings table first
                Dim checkMigrationSql As String = "
                    IF OBJECT_ID(N'[dbo].[Passengers]', N'U') IS NULL
                    BEGIN
                        IF OBJECT_ID(N'[dbo].[Bookings]', N'U') IS NOT NULL
                        BEGIN
                            DROP TABLE [dbo].[Bookings]
                        END
                    END"
                Using cmd As New SqlCommand(checkMigrationSql, conn)
                    cmd.ExecuteNonQuery()
                End Using

                ' Auto-migration: Bus Fleet Management
                Dim checkBusMigrateSql As String = "
                    IF OBJECT_ID(N'[dbo].[Buses]', N'U') IS NULL
                    BEGIN
                        CREATE TABLE [dbo].[Buses] (
                            [BusId] INT IDENTITY(1,1) PRIMARY KEY,
                            [BusName] NVARCHAR(100) NOT NULL,
                            [LayoutType] NVARCHAR(20) NOT NULL,
                            [SeatCapacity] INT NOT NULL
                        );
                        
                        -- Insert default buses
                        INSERT INTO [dbo].[Buses] (BusName, LayoutType, SeatCapacity) VALUES 
                        ('Standard Bus', '2-2', 40),
                        ('VIP Express', '1-1-1', 30),
                        ('Spacious Cruiser', '2-1-2', 45);
                    END
                    
                    IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Schedules]') AND type in (N'U'))
                    BEGIN
                        CREATE TABLE [dbo].[Schedules] (
                            [TripId] INT IDENTITY(1,1) PRIMARY KEY,
                            [RouteName] NVARCHAR(100) NOT NULL,
                            [DepartureTime] DATETIME NOT NULL,
                            [Price] DECIMAL(10,2) NOT NULL,
                            [BusId] INT NOT NULL FOREIGN KEY REFERENCES [dbo].[Buses]([BusId]) ON DELETE CASCADE
                        )
                    END
                    
                    IF COL_LENGTH('dbo.Schedules', 'BusId') IS NULL
                    BEGIN
                        ALTER TABLE [dbo].[Schedules] ADD [BusId] INT;
                        EXEC('UPDATE [dbo].[Schedules] SET [BusId] = (SELECT TOP 1 BusId FROM [dbo].[Buses] WHERE SeatCapacity >= [dbo].[Schedules].[SeatCapacity])');
                        
                        IF COL_LENGTH('dbo.Schedules', 'SeatCapacity') IS NOT NULL
                        BEGIN
                            ALTER TABLE [dbo].[Schedules] DROP COLUMN [SeatCapacity];
                        END
                        ALTER TABLE [dbo].[Schedules] ADD CONSTRAINT FK_Schedules_Buses FOREIGN KEY ([BusId]) REFERENCES [dbo].[Buses]([BusId]) ON DELETE CASCADE;
                    END"
                Using cmd As New SqlCommand(checkBusMigrateSql, conn)
                    cmd.ExecuteNonQuery()
                End Using

                ' Create Passengers Table
                Dim createPassengersSql As String = "
                    IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Passengers]') AND type in (N'U'))
                    BEGIN
                        CREATE TABLE [dbo].[Passengers] (
                            [PassengerId] INT IDENTITY(1,1) PRIMARY KEY,
                            [FullName] NVARCHAR(100) NOT NULL,
                            [Phone] NVARCHAR(20) NOT NULL UNIQUE
                        )
                    END"
                Using cmd As New SqlCommand(createPassengersSql, conn)
                    cmd.ExecuteNonQuery()
                End Using

                ' Auto-migration: Add IsBlocked column if missing
                Dim addIsBlockedSql As String = "
                    IF COL_LENGTH('dbo.Passengers', 'IsBlocked') IS NULL
                    BEGIN
                        ALTER TABLE [dbo].[Passengers] ADD [IsBlocked] BIT NOT NULL DEFAULT 0
                    END"
                Using cmd As New SqlCommand(addIsBlockedSql, conn)
                    cmd.ExecuteNonQuery()
                End Using

                ' Auto-migration: Add user account columns to Passengers if missing
                Dim addUserAccountColsSql As String = "
                    IF COL_LENGTH('dbo.Passengers', 'Username') IS NULL
                    BEGIN
                        ALTER TABLE [dbo].[Passengers] ADD [Username] NVARCHAR(50) NULL
                    END
                    IF COL_LENGTH('dbo.Passengers', 'PasswordHash') IS NULL
                    BEGIN
                        ALTER TABLE [dbo].[Passengers] ADD [PasswordHash] NVARCHAR(255) NULL
                    END
                    IF COL_LENGTH('dbo.Passengers', 'Email') IS NULL
                    BEGIN
                        ALTER TABLE [dbo].[Passengers] ADD [Email] NVARCHAR(150) NULL
                    END
                    IF COL_LENGTH('dbo.Passengers', 'ICNumber') IS NULL
                    BEGIN
                        ALTER TABLE [dbo].[Passengers] ADD [ICNumber] NVARCHAR(20) NULL
                    END"
                Using cmd As New SqlCommand(addUserAccountColsSql, conn)
                    cmd.ExecuteNonQuery()
                End Using

                ' Create Bookings Table with UNIQUE constraint
                Dim createBookingsSql As String = "
                    IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Bookings]') AND type in (N'U'))
                    BEGIN
                        CREATE TABLE [dbo].[Bookings] (
                            [TicketId] INT IDENTITY(1,1) PRIMARY KEY,
                            [TripId] INT NOT NULL FOREIGN KEY REFERENCES [dbo].[Schedules]([TripId]) ON DELETE CASCADE,
                            [PassengerId] INT NOT NULL FOREIGN KEY REFERENCES [dbo].[Passengers]([PassengerId]) ON DELETE CASCADE,
                            [SeatNumber] INT NOT NULL,
                            [BookingDate] DATETIME NOT NULL DEFAULT GETDATE(),
                            [TotalPrice] DECIMAL(10,2) NOT NULL,
                            CONSTRAINT [UQ_Trip_Seat] UNIQUE ([TripId], [SeatNumber])
                        )
                    END"
                Using cmd As New SqlCommand(createBookingsSql, conn)
                    cmd.ExecuteNonQuery()
                End Using

                ' Create Admins Table
                Dim createAdminsSql As String = "
                    IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Admins]') AND type in (N'U'))
                    BEGIN
                        CREATE TABLE [dbo].[Admins] (
                            [AdminId] INT IDENTITY(1,1) PRIMARY KEY,
                            [Username] NVARCHAR(50) NOT NULL UNIQUE,
                            [PasswordHash] NVARCHAR(255) NOT NULL
                        )
                    END"
                Using cmd As New SqlCommand(createAdminsSql, conn)
                    cmd.ExecuteNonQuery()
                End Using

                ' Seed initial schedules if table is empty
                Dim countSchedulesCmd As New SqlCommand("SELECT COUNT(*) FROM [dbo].[Schedules]", conn)
                Dim scheduleCount As Integer = Convert.ToInt32(countSchedulesCmd.ExecuteScalar())
                If scheduleCount = 0 Then
                    Dim seedSql As String = "
                        DECLARE @Bus22 INT = (SELECT TOP 1 BusId FROM [dbo].[Buses] WHERE LayoutType = '2-2');
                        DECLARE @Bus111 INT = (SELECT TOP 1 BusId FROM [dbo].[Buses] WHERE LayoutType = '1-1-1');
                        
                        INSERT INTO [dbo].[Schedules] (RouteName, DepartureTime, Price, BusId) VALUES
                        ('Kuala Lumpur to Kuala Terengganu', DATEADD(day, 1, GETDATE()), 45.00, @Bus111),
                        ('Penang to Johor Bahru', DATEADD(day, 2, GETDATE()), 65.50, @Bus22),
                        ('Ipoh to Malacca', DATEADD(day, 3, GETDATE()), 38.00, @Bus111),
                        ('Kuala Lumpur to Penang', DATEADD(day, 4, GETDATE()), 35.00, @Bus22)"
                    Using seedCmd As New SqlCommand(seedSql, conn)
                        seedCmd.ExecuteNonQuery()
                    End Using
                End If

                ' Seed default admin if table is empty
                Dim countAdminsCmd As New SqlCommand("SELECT COUNT(*) FROM [dbo].[Admins]", conn)
                Dim adminCount As Integer = Convert.ToInt32(countAdminsCmd.ExecuteScalar())
                If adminCount = 0 Then
                    Dim seedAdminSql As String = "INSERT INTO [dbo].[Admins] (Username, PasswordHash) VALUES (@Username, @Hash)"
                    Using seedAdminCmd As New SqlCommand(seedAdminSql, conn)
                        seedAdminCmd.Parameters.AddWithValue("@Username", "admin")
                        seedAdminCmd.Parameters.AddWithValue("@Hash", HashPassword("admin123"))
                        seedAdminCmd.ExecuteNonQuery()
                    End Using
                End If
            End Using
        Catch ex As Exception
            MessageBox.Show("Database initialization failed: " & ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    ''' <summary>
    ''' Registers a new passenger user. Returns empty string on success, or an error message.
    ''' </summary>
    Public Shared Function RegisterUser(fullName As String, phone As String, username As String,
                                        password As String, email As String, icNumber As String) As String
        Try
            Using conn As New SqlConnection(ConnString)
                conn.Open()

                Dim checkUserSql As String = "SELECT COUNT(*) FROM [dbo].[Passengers] WHERE Username = @Username"
                Using cmd As New SqlCommand(checkUserSql, conn)
                    cmd.Parameters.AddWithValue("@Username", username)
                    If Convert.ToInt32(cmd.ExecuteScalar()) > 0 Then
                        Return "That username is already taken. Please choose another."
                    End If
                End Using

                Dim checkPhoneSql As String = "SELECT COUNT(*) FROM [dbo].[Passengers] WHERE Phone = @Phone"
                Using cmd As New SqlCommand(checkPhoneSql, conn)
                    cmd.Parameters.AddWithValue("@Phone", phone)
                    If Convert.ToInt32(cmd.ExecuteScalar()) > 0 Then
                        Return "A passenger with that phone number already exists."
                    End If
                End Using

                If Not String.IsNullOrWhiteSpace(email) Then
                    Dim checkEmailSql As String = "SELECT COUNT(*) FROM [dbo].[Passengers] WHERE Email = @Email"
                    Using cmd As New SqlCommand(checkEmailSql, conn)
                        cmd.Parameters.AddWithValue("@Email", email)
                        If Convert.ToInt32(cmd.ExecuteScalar()) > 0 Then
                            Return "That email address is already registered."
                        End If
                    End Using
                End If

                Dim insertSql As String = "
                    INSERT INTO [dbo].[Passengers] (FullName, Phone, Username, PasswordHash, Email, ICNumber)
                    VALUES (@FullName, @Phone, @Username, @Hash, @Email, @IC)"
                Using cmd As New SqlCommand(insertSql, conn)
                    cmd.Parameters.AddWithValue("@FullName", fullName)
                    cmd.Parameters.AddWithValue("@Phone", phone)
                    cmd.Parameters.AddWithValue("@Username", username)
                    cmd.Parameters.AddWithValue("@Hash", HashPassword(password))
                    cmd.Parameters.AddWithValue("@Email", If(String.IsNullOrWhiteSpace(email), CType(DBNull.Value, Object), email))
                    cmd.Parameters.AddWithValue("@IC", If(String.IsNullOrWhiteSpace(icNumber), CType(DBNull.Value, Object), icNumber))
                    cmd.ExecuteNonQuery()
                End Using

                Return String.Empty ' Success
            End Using
        Catch ex As Exception
            Return "Registration failed: " & ex.Message
        End Try
    End Function

    ''' <summary>
    ''' Validates passenger login. Returns PassengerId on success, -1 on bad credentials, -2 if blocked.
    ''' </summary>
    Public Shared Function LoginUser(username As String, password As String) As Integer
        Try
            Using conn As New SqlConnection(ConnString)
                conn.Open()
                Dim sql As String = "
                    SELECT PassengerId, PasswordHash, IsBlocked
                    FROM [dbo].[Passengers]
                    WHERE Username = @Username"
                Using cmd As New SqlCommand(sql, conn)
                    cmd.Parameters.AddWithValue("@Username", username)
                    Using reader As SqlDataReader = cmd.ExecuteReader()
                        If reader.Read() Then
                            If Convert.ToBoolean(reader("IsBlocked")) Then Return -2
                            Dim storedHash As String = reader("PasswordHash").ToString()
                            If storedHash.Equals(HashPassword(password), StringComparison.OrdinalIgnoreCase) Then
                                Return Convert.ToInt32(reader("PassengerId"))
                            End If
                        End If
                    End Using
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Login error: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        Return -1
    End Function

    ''' <summary>Gets a passenger's full name by ID.</summary>
    Public Shared Function GetPassengerName(passengerId As Integer) As String
        Try
            Using conn As New SqlConnection(ConnString)
                conn.Open()
                Using cmd As New SqlCommand("SELECT FullName FROM [dbo].[Passengers] WHERE PassengerId = @Id", conn)
                    cmd.Parameters.AddWithValue("@Id", passengerId)
                    Dim result As Object = cmd.ExecuteScalar()
                    If result IsNot Nothing AndAlso result IsNot DBNull.Value Then Return result.ToString()
                End Using
            End Using
        Catch
        End Try
        Return String.Empty
    End Function

    ''' <summary>Gets a passenger's phone number by ID.</summary>
    Public Shared Function GetPassengerPhone(passengerId As Integer) As String
        Try
            Using conn As New SqlConnection(ConnString)
                conn.Open()
                Using cmd As New SqlCommand("SELECT Phone FROM [dbo].[Passengers] WHERE PassengerId = @Id", conn)
                    cmd.Parameters.AddWithValue("@Id", passengerId)
                    Dim result As Object = cmd.ExecuteScalar()
                    If result IsNot Nothing AndAlso result IsNot DBNull.Value Then Return result.ToString()
                End Using
            End Using
        Catch
        End Try
        Return String.Empty
    End Function
End Class