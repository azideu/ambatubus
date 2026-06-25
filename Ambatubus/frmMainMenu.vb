Imports System
Imports System.Data
Imports System.Drawing
Imports Microsoft.Data.SqlClient
Imports System.Windows.Forms

Public Class frmMainMenu
    Private Sub frmMainMenu_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            Dim bannerPath As String = System.IO.Path.Combine(Application.StartupPath, "Assets", "dashboard_banner.png")
            If System.IO.File.Exists(bannerPath) Then
                picBanner.Image = Image.FromFile(bannerPath)
            End If

            ' Overlay title over banner image programmatically
            lblTitle.Parent = picBanner
            lblTitle.BackColor = Color.Transparent
            lblTitle.Location = New Point(30, 30)
        Catch ex As Exception
            ' Silent fail
        End Try
        LoadDashboardData()
    End Sub

    Private Sub LoadDashboardData()
        Try
            Using conn As New SqlConnection(DatabaseHelper.ConnString)
                conn.Open()

                ' Load active bus schedules (with search filter)
                Dim routesQuery As String = "SELECT TripId As [Trip ID], RouteName As [Route], DepartureTime As [Departure Time], Price As [Price (RM)], SeatCapacity As [Seat Capacity] FROM Schedules WHERE 1=1"
                Dim filter As String = txtSearchRoute.Text.Trim()
                If Not String.IsNullOrEmpty(filter) Then
                    routesQuery &= " AND RouteName LIKE @Filter"
                End If

                Dim cmd As New SqlCommand(routesQuery, conn)
                If Not String.IsNullOrEmpty(filter) Then
                    cmd.Parameters.AddWithValue("@Filter", "%" & filter & "%")
                End If

                Dim da As New SqlDataAdapter(cmd)
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

    Private Sub txtSearchRoute_TextChanged(sender As Object, e As EventArgs) Handles txtSearchRoute.TextChanged
        LoadDashboardData()
    End Sub

    Private Sub cmdBook_Click(sender As Object, e As EventArgs) Handles cmdBook.Click
        Dim bookingForm As New frmBooking()
        bookingForm.ShowDialog()
        LoadDashboardData()
    End Sub

    Private Sub cmdAdmin_Click(sender As Object, e As EventArgs) Handles cmdAdmin.Click
        Dim loginForm As New frmLogin()
        If loginForm.ShowDialog() = DialogResult.OK Then
            Dim adminForm As New frmAdmin()
            adminForm.ShowDialog()
            LoadDashboardData()
        End If
    End Sub

    Private Sub cmdClose_Click(sender As Object, e As EventArgs) Handles cmdClose.Click
        Application.Exit()
    End Sub

    ' Button Hover Effects
    Private Sub Button_MouseEnter(sender As Object, e As EventArgs) Handles cmdBook.MouseEnter, cmdAdmin.MouseEnter, cmdClose.MouseEnter
        Dim btn As Button = CType(sender, Button)
        If btn Is cmdBook Then
            btn.BackColor = Color.FromArgb(35, 175, 105)
        ElseIf btn Is cmdAdmin Then
            btn.BackColor = Color.FromArgb(85, 95, 90)
        ElseIf btn Is cmdClose Then
            btn.BackColor = Color.FromArgb(210, 70, 70)
        End If
    End Sub

    Private Sub Button_MouseLeave(sender As Object, e As EventArgs) Handles cmdBook.MouseLeave, cmdAdmin.MouseLeave, cmdClose.MouseLeave
        Dim btn As Button = CType(sender, Button)
        If btn Is cmdBook Then
            btn.BackColor = Color.FromArgb(20, 150, 85)
        ElseIf btn Is cmdAdmin Then
            btn.BackColor = Color.FromArgb(65, 75, 70)
        ElseIf btn Is cmdClose Then
            btn.BackColor = Color.FromArgb(180, 50, 50)
        End If
    End Sub
End Class