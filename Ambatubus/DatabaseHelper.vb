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

                ' Create Schedules Table
                Dim createSchedulesSql As String = "
                    IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Schedules]') AND type in (N'U'))
                    BEGIN
                        CREATE TABLE [dbo].[Schedules] (
                            [TripId] INT IDENTITY(1,1) PRIMARY KEY,
                            [RouteName] NVARCHAR(100) NOT NULL,
                            [DepartureTime] DATETIME NOT NULL,
                            [Price] DECIMAL(10,2) NOT NULL,
                            [SeatCapacity] INT NOT NULL
                        )
                    END"
                Using cmd As New SqlCommand(createSchedulesSql, conn)
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
                        INSERT INTO [dbo].[Schedules] (RouteName, DepartureTime, Price, SeatCapacity) VALUES
                        ('Kuala Lumpur to Kuala Terengganu', DATEADD(day, 1, GETDATE()), 45.00, 30),
                        ('Penang to Johor Bahru', DATEADD(day, 2, GETDATE()), 65.50, 40),
                        ('Ipoh to Malacca', DATEADD(day, 3, GETDATE()), 38.00, 30),
                        ('Kuala Lumpur to Penang', DATEADD(day, 4, GETDATE()), 35.00, 40)"
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
End Class