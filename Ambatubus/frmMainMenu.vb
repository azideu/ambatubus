Imports System
Imports System.Data
Imports Microsoft.Data.SqlClient
Imports System.Windows.Forms

Public Class frmMainMenu
    Private Sub frmMainMenu_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadDashboardData()
    End Sub

    Private Sub LoadDashboardData()
        Try
            Using conn As New SqlConnection(DatabaseHelper.ConnString)
                conn.Open()

                ' Load active bus schedules
                Dim routesQuery As String = "SELECT TripId As [Trip ID], RouteName As [Route], DepartureTime As [Departure Time], Price As [Price (RM)], SeatCapacity As [Seat Capacity] FROM Schedules"
                Dim da As New SqlDataAdapter(routesQuery, conn)
                Dim dt As New DataTable()
                da.Fill(dt)
                dgvRoutes.DataSource = dt

                ' Load total bookings count
                Dim bookingsQuery As String = "SELECT COUNT(*) FROM Bookings"
                Dim bookingsCmd As New SqlCommand(bookingsQuery, conn)
                Dim totalBookings As Integer = Convert.ToInt32(bookingsCmd.ExecuteScalar())
                lblTotalBookingsVal.Text = totalBookings.ToString()

                ' Load total routes count
                Dim routesCountQuery As String = "SELECT COUNT(*) FROM Schedules"
                Dim routesCountCmd As New SqlCommand(routesCountQuery, conn)
                Dim totalRoutes As Integer = Convert.ToInt32(routesCountCmd.ExecuteScalar())
                lblTotalRoutesVal.Text = totalRoutes.ToString()

                ' Load total revenue count
                Dim revenueQuery As String = "SELECT COALESCE(SUM(TotalPrice), 0) FROM Bookings"
                Dim revenueCmd As New SqlCommand(revenueQuery, conn)
                Dim totalRevenue As Decimal = Convert.ToDecimal(revenueCmd.ExecuteScalar())
                lblTotalRevenueVal.Text = String.Format("RM {0:F2}", totalRevenue)
            End Using
        Catch ex As Exception
            MessageBox.Show("Failed to load dashboard data: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub cmdBook_Click(sender As Object, e As EventArgs) Handles cmdBook.Click
        Dim bookingForm As New frmBooking()
        bookingForm.ShowDialog()
        LoadDashboardData()
    End Sub

    Private Sub cmdAdmin_Click(sender As Object, e As EventArgs) Handles cmdAdmin.Click
        Dim adminForm As New frmAdmin()
        adminForm.ShowDialog()
        LoadDashboardData()
    End Sub

    Private Sub cmdClose_Click(sender As Object, e As EventArgs) Handles cmdClose.Click
        Application.Exit()
    End Sub
End Class