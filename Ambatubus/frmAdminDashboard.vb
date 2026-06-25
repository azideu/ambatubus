Imports System
Imports System.Data
Imports System.Drawing
Imports Microsoft.Data.SqlClient
Imports System.Windows.Forms

Public Class frmAdminDashboard
    Private Sub frmAdminDashboard_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadDashboardData()
    End Sub

    Private Sub LoadDashboardData()
        Try
            Using conn As New SqlConnection(DatabaseHelper.ConnString)
                conn.Open()

                ' 1. Today's Revenue
                Dim revenueQuery As String = "SELECT COALESCE(SUM(TotalPrice), 0) FROM Bookings WHERE CAST(BookingDate AS DATE) = CAST(GETDATE() AS DATE)"
                Dim revenueCmd As New SqlCommand(revenueQuery, conn)
                Dim todayRevenue As Decimal = Convert.ToDecimal(revenueCmd.ExecuteScalar())
                lblTodayRevenueVal.Text = String.Format("RM {0:F2}", todayRevenue)

                ' 2. Total Bookings
                Dim bookingsQuery As String = "SELECT COUNT(*) FROM Bookings"
                Dim bookingsCmd As New SqlCommand(bookingsQuery, conn)
                Dim totalBookings As Integer = Convert.ToInt32(bookingsCmd.ExecuteScalar())
                lblTotalBookingsVal.Text = totalBookings.ToString()

                ' 3. Seat Occupancy Rate
                Dim capacityQuery As String = "SELECT COALESCE(SUM(SeatCapacity), 0) FROM Schedules"
                Dim capacityCmd As New SqlCommand(capacityQuery, conn)
                Dim totalCapacity As Integer = Convert.ToInt32(capacityCmd.ExecuteScalar())
                
                Dim occupancyRate As Double = 0
                If totalCapacity > 0 Then
                    occupancyRate = (totalBookings / totalCapacity) * 100
                End If
                lblOccupancyVal.Text = String.Format("{0:F1}%", occupancyRate)

                ' 4. Most Popular Routes
                Dim popularRoutesQuery As String = "
                    SELECT TOP 5 s.RouteName As [Route Name], COUNT(b.TicketId) As [Total Bookings] 
                    FROM Schedules s 
                    LEFT JOIN Bookings b ON s.TripId = b.TripId 
                    GROUP BY s.RouteName 
                    ORDER BY [Total Bookings] DESC"
                Dim da As New SqlDataAdapter(popularRoutesQuery, conn)
                Dim dt As New DataTable()
                da.Fill(dt)
                dgvPopularRoutes.DataSource = dt
            End Using
        Catch ex As Exception
            MessageBox.Show("Failed to load dashboard data: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub cmdManageSchedules_Click(sender As Object, e As EventArgs) Handles cmdManageSchedules.Click
        Dim adminForm As New frmAdmin()
        Me.Hide()
        adminForm.ShowDialog()
        Me.Show()
        LoadDashboardData() ' Refresh data when coming back
    End Sub

    Private Sub cmdManagePassengers_Click(sender As Object, e As EventArgs) Handles cmdManagePassengers.Click
        Dim passengersForm As New frmManagePassengers()
        Me.Hide()
        passengersForm.ShowDialog()
        Me.Show()
        LoadDashboardData() ' Refresh data when coming back
    End Sub

    Private Sub cmdLogout_Click(sender As Object, e As EventArgs) Handles cmdLogout.Click
        Me.Close()
    End Sub

    ' Button Hover Effects
    Private Sub Button_MouseEnter(sender As Object, e As EventArgs) Handles cmdManageSchedules.MouseEnter, cmdManagePassengers.MouseEnter, cmdLogout.MouseEnter
        Dim btn As Button = CType(sender, Button)
        If btn Is cmdManageSchedules OrElse btn Is cmdManagePassengers Then
            btn.BackColor = Color.FromArgb(35, 175, 105)
        ElseIf btn Is cmdLogout Then
            btn.BackColor = Color.FromArgb(210, 70, 70)
        End If
    End Sub

    Private Sub Button_MouseLeave(sender As Object, e As EventArgs) Handles cmdManageSchedules.MouseLeave, cmdManagePassengers.MouseLeave, cmdLogout.MouseLeave
        Dim btn As Button = CType(sender, Button)
        If btn Is cmdManageSchedules OrElse btn Is cmdManagePassengers Then
            btn.BackColor = Color.FromArgb(20, 150, 85)
        ElseIf btn Is cmdLogout Then
            btn.BackColor = Color.FromArgb(180, 50, 50)
        End If
    End Sub
End Class
