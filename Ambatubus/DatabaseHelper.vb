Imports Microsoft.Data.SqlClient
Imports System.Windows.Forms

Public Class DatabaseHelper
    Private Const MasterConnString As String = "Server=(localdb)\MSSQLLocalDB;Integrated Security=True;TrustServerCertificate=True;"
    Private Const DbName As String = "ambatubus"
    Public Const ConnString As String = "Server=(localdb)\MSSQLLocalDB;Database=ambatubus;Integrated Security=True;TrustServerCertificate=True;"

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

                ' Create Bookings Table
                Dim createBookingsSql As String = "
                    IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Bookings]') AND type in (N'U'))
                    BEGIN
                        CREATE TABLE [dbo].[Bookings] (
                            [TicketId] INT IDENTITY(1,1) PRIMARY KEY,
                            [TripId] INT NOT NULL FOREIGN KEY REFERENCES [dbo].[Schedules]([TripId]) ON DELETE CASCADE,
                            [PassengerName] NVARCHAR(100) NOT NULL,
                            [Phone] NVARCHAR(20) NOT NULL,
                            [SeatNumber] INT NOT NULL,
                            [BookingDate] DATETIME NOT NULL DEFAULT GETDATE(),
                            [TotalPrice] DECIMAL(10,2) NOT NULL
                        )
                    END"
                Using cmd As New SqlCommand(createBookingsSql, conn)
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
            End Using
        Catch ex As Exception
            MessageBox.Show("Database initialization failed: " & ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
End Class