Imports System
Imports System.Collections.Generic
Imports System.Data
Imports System.Drawing
Imports Microsoft.Data.SqlClient
Imports System.Windows.Forms
Imports LiveChartsCore
Imports LiveChartsCore.SkiaSharpView
Imports LiveChartsCore.SkiaSharpView.WinForms
Imports LiveChartsCore.SkiaSharpView.Painting
Imports SkiaSharp

Public Class frmAdminDashboard
    Private Sub frmAdminDashboard_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ThemeManager.ApplyTheme(Me)
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
                Dim capacityQuery As String = "SELECT COALESCE(SUM(b.SeatCapacity), 0) FROM Schedules s INNER JOIN Buses b ON s.BusId = b.BusId"
                Dim capacityCmd As New SqlCommand(capacityQuery, conn)
                Dim totalCapacity As Integer = Convert.ToInt32(capacityCmd.ExecuteScalar())
                
                Dim occupancyRate As Double = 0
                If totalCapacity > 0 Then
                    occupancyRate = (totalBookings / totalCapacity) * 100
                End If
                lblOccupancyVal.Text = String.Format("{0:F1}%", occupancyRate)

                ' 4. Most Popular Routes (Pie Chart)
                pnlRoutesChart.Controls.Clear()
                Dim popularRoutesQuery As String = "
                    SELECT TOP 5 s.RouteName As [Route Name], COUNT(b.TicketId) As [Total Bookings] 
                    FROM Schedules s 
                    LEFT JOIN Bookings b ON s.TripId = b.TripId 
                    GROUP BY s.RouteName 
                    ORDER BY [Total Bookings] DESC"
                Dim routesCmd As New SqlCommand(popularRoutesQuery, conn)
                Dim routesReader As SqlDataReader = routesCmd.ExecuteReader()
                Dim pieSeries As New List(Of ISeries)()
                While routesReader.Read()
                    Dim routeName As String = routesReader("Route Name").ToString()
                    Dim routeBookings As Integer = Convert.ToInt32(routesReader("Total Bookings"))
                    pieSeries.Add(New PieSeries(Of Integer) With {
                        .Values = New Integer() {routeBookings},
                        .Name = routeName,
                        .DataLabelsPaint = New SolidColorPaint(SKColors.White),
                        .DataLabelsPosition = LiveChartsCore.Measure.PolarLabelsPosition.Middle,
                        .DataLabelsFormatter = Function(point) point.Model.ToString()
                    })
                End While
                routesReader.Close()

                Dim tColor As System.Drawing.Color = ThemeManager.CurrentTheme.InputText
                Dim skTextColor As New SKColor(tColor.R, tColor.G, tColor.B)

                Dim pieChart As New PieChart() With {
                    .Series = pieSeries,
                    .Dock = DockStyle.Fill,
                    .LegendPosition = LiveChartsCore.Measure.LegendPosition.Right,
                    .LegendTextPaint = New SolidColorPaint(skTextColor),
                    .BackColor = ThemeManager.CurrentTheme.PanelBackground
                }
                pnlRoutesChart.Controls.Add(pieChart)

                ' 5. Weekly Revenue (Bar Chart)
                pnlRevenueChart.Controls.Clear()
                Dim weeklyRevenueQuery As String = "
                    SELECT CAST(BookingDate AS DATE) As [Date], COALESCE(SUM(TotalPrice), 0) As [Revenue]
                    FROM Bookings
                    WHERE BookingDate >= CAST(DATEADD(day, -7, GETDATE()) AS DATE)
                    GROUP BY CAST(BookingDate AS DATE)
                    ORDER BY [Date] ASC"
                Dim revCmd As New SqlCommand(weeklyRevenueQuery, conn)
                Dim revReader As SqlDataReader = revCmd.ExecuteReader()
                
                Dim revValues As New List(Of Decimal)()
                Dim dateLabels As New List(Of String)()
                While revReader.Read()
                    dateLabels.Add(Convert.ToDateTime(revReader("Date")).ToString("MMM dd"))
                    revValues.Add(Convert.ToDecimal(revReader("Revenue")))
                End While
                revReader.Close()

                Dim btnColor As System.Drawing.Color = ThemeManager.CurrentTheme.ButtonPrimary
                Dim skBtnColor As New SKColor(btnColor.R, btnColor.G, btnColor.B)

                Dim barSeries As New List(Of ISeries) From {
                    New ColumnSeries(Of Decimal) With {
                        .Values = revValues,
                        .Name = "Revenue (RM)",
                        .Fill = New SolidColorPaint(skBtnColor)
                    }
                }

                Dim barChart As New CartesianChart() With {
                    .Series = barSeries,
                    .XAxes = New List(Of Axis) From {
                        New Axis With {
                            .Labels = dateLabels,
                            .LabelsPaint = New SolidColorPaint(skTextColor)
                        }
                    },
                    .YAxes = New List(Of Axis) From {
                        New Axis With {
                            .LabelsPaint = New SolidColorPaint(skTextColor)
                        }
                    },
                    .Dock = DockStyle.Fill,
                    .TooltipTextPaint = New SolidColorPaint(SKColors.White),
                    .BackColor = ThemeManager.CurrentTheme.PanelBackground
                }
                pnlRevenueChart.Controls.Add(barChart)

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

    Private Sub cmdManageBuses_Click(sender As Object, e As EventArgs) Handles cmdManageBuses.Click
        Dim busesForm As New frmManageBuses()
        Me.Hide()
        busesForm.ShowDialog()
        Me.Show()
        LoadDashboardData() ' Refresh data when coming back
    End Sub

    Private Sub cmdExportData_Click(sender As Object, e As EventArgs) Handles cmdExportData.Click
        Dim choice As DialogResult = MessageBox.Show("Click 'Yes' to export Schedules." & vbCrLf & "Click 'No' to export All Bookings." & vbCrLf & "Click 'Cancel' to abort.", "Export Data", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question)
        
        If choice = DialogResult.Cancel Then Return

        Try
            Using conn As New SqlConnection(DatabaseHelper.ConnString)
                conn.Open()
                Dim dt As New DataTable()

                If choice = DialogResult.Yes Then
                    ' Export Schedules
                    Dim query As String = "SELECT s.TripId As [Trip ID], s.RouteName As [Route Name], s.DepartureTime As [Departure Time], s.Price As [Price (RM)], b.BusName As [Assigned Bus], b.SeatCapacity As [Capacity] FROM Schedules s INNER JOIN Buses b ON s.BusId = b.BusId ORDER BY s.DepartureTime DESC"
                    Dim cmd As New SqlCommand(query, conn)
                    Dim da As New SqlDataAdapter(cmd)
                    da.Fill(dt)

                    If dt.Rows.Count = 0 Then
                        MessageBox.Show("No schedules found to export.", "Empty", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        Return
                    End If

                    Dim sfd As New SaveFileDialog()
                    sfd.Filter = "CSV Files (*.csv)|*.csv|All Files (*.*)|*.*"
                    sfd.FileName = $"Schedules_Export_{DateTime.Now:yyyyMMdd}.csv"
                    If sfd.ShowDialog() = DialogResult.OK Then
                        ExportHelper.ExportDataTableToCsv(dt, sfd.FileName)
                    End If
                ElseIf choice = DialogResult.No Then
                    ' Export Bookings
                    Dim query As String = "SELECT b.TicketId As [Ticket ID], s.RouteName As [Route Name], b.SeatNumber As [Seat No], p.FullName As [Passenger Name], p.Phone As [Phone No], b.BookingDate As [Booking Date], b.TotalPrice As [Price Paid] FROM Bookings b INNER JOIN Schedules s ON b.TripId = s.TripId INNER JOIN Passengers p ON b.PassengerId = p.PassengerId ORDER BY b.BookingDate DESC"
                    Dim cmd As New SqlCommand(query, conn)
                    Dim da As New SqlDataAdapter(cmd)
                    da.Fill(dt)

                    If dt.Rows.Count = 0 Then
                        MessageBox.Show("No bookings found to export.", "Empty", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        Return
                    End If

                    Dim sfd As New SaveFileDialog()
                    sfd.Filter = "CSV Files (*.csv)|*.csv|All Files (*.*)|*.*"
                    sfd.FileName = $"Bookings_Export_{DateTime.Now:yyyyMMdd}.csv"
                    If sfd.ShowDialog() = DialogResult.OK Then
                        ExportHelper.ExportDataTableToCsv(dt, sfd.FileName)
                    End If
                End If
            End Using
        Catch ex As Exception
            MessageBox.Show("Failed to export data: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub cmdLogout_Click(sender As Object, e As EventArgs) Handles cmdLogout.Click
        Me.Close()
    End Sub

    ' Button Hover Effects
    Private Sub Button_MouseEnter(sender As Object, e As EventArgs) Handles cmdManageSchedules.MouseEnter, cmdManagePassengers.MouseEnter, cmdManageBuses.MouseEnter, cmdExportData.MouseEnter, cmdLogout.MouseEnter
        Dim btn As Button = CType(sender, Button)
        If btn Is cmdManageSchedules OrElse btn Is cmdManagePassengers OrElse btn Is cmdManageBuses OrElse btn Is cmdExportData Then
            btn.BackColor = ThemeManager.CurrentTheme.ButtonPrimaryHover
        ElseIf btn Is cmdLogout Then
            btn.BackColor = ThemeManager.CurrentTheme.ButtonDangerHover
        End If
    End Sub

    Private Sub Button_MouseLeave(sender As Object, e As EventArgs) Handles cmdManageSchedules.MouseLeave, cmdManagePassengers.MouseLeave, cmdManageBuses.MouseLeave, cmdExportData.MouseLeave, cmdLogout.MouseLeave
        Dim btn As Button = CType(sender, Button)
        If btn Is cmdManageSchedules OrElse btn Is cmdManagePassengers OrElse btn Is cmdManageBuses OrElse btn Is cmdExportData Then
            btn.BackColor = ThemeManager.CurrentTheme.ButtonPrimary
        ElseIf btn Is cmdLogout Then
            btn.BackColor = ThemeManager.CurrentTheme.ButtonDanger
        End If
    End Sub
End Class
