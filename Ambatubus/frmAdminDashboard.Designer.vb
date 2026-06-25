<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmAdminDashboard
    Inherits System.Windows.Forms.Form

    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    Private components As System.ComponentModel.IContainer

    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.pnlRevenue = New System.Windows.Forms.Panel()
        Me.lblTodayRevenue = New System.Windows.Forms.Label()
        Me.lblTodayRevenueVal = New System.Windows.Forms.Label()
        Me.pnlBookings = New System.Windows.Forms.Panel()
        Me.lblTotalBookings = New System.Windows.Forms.Label()
        Me.lblTotalBookingsVal = New System.Windows.Forms.Label()
        Me.pnlOccupancy = New System.Windows.Forms.Panel()
        Me.lblOccupancy = New System.Windows.Forms.Label()
        Me.lblOccupancyVal = New System.Windows.Forms.Label()
        Me.pnlRevenueChart = New System.Windows.Forms.Panel()
        Me.pnlRoutesChart = New System.Windows.Forms.Panel()
        Me.cmdManageSchedules = New System.Windows.Forms.Button()
        Me.cmdManagePassengers = New System.Windows.Forms.Button()
        Me.cmdLogout = New System.Windows.Forms.Button()
        Me.pnlRevenue.SuspendLayout()
        Me.pnlBookings.SuspendLayout()
        Me.pnlOccupancy.SuspendLayout()

        Me.SuspendLayout()
        '
        'lblTitle
        '
        Me.lblTitle.AutoSize = True
        Me.lblTitle.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Bold)
        Me.lblTitle.ForeColor = System.Drawing.Color.White
        Me.lblTitle.Location = New System.Drawing.Point(20, 20)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(215, 32)
        Me.lblTitle.TabIndex = 0
        Me.lblTitle.Text = "Admin Dashboard"
        '
        'pnlRevenue
        '
        Me.pnlRevenue.BackColor = System.Drawing.Color.FromArgb(35, 42, 38)
        Me.pnlRevenue.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnlRevenue.Controls.Add(Me.lblTodayRevenueVal)
        Me.pnlRevenue.Controls.Add(Me.lblTodayRevenue)
        Me.pnlRevenue.Location = New System.Drawing.Point(20, 70)
        Me.pnlRevenue.Name = "pnlRevenue"
        Me.pnlRevenue.Size = New System.Drawing.Size(200, 100)
        Me.pnlRevenue.TabIndex = 1
        '
        'lblTodayRevenue
        '
        Me.lblTodayRevenue.AutoSize = True
        Me.lblTodayRevenue.Font = New System.Drawing.Font("Segoe UI", 9.5!)
        Me.lblTodayRevenue.ForeColor = System.Drawing.Color.FromArgb(140, 160, 150)
        Me.lblTodayRevenue.Location = New System.Drawing.Point(10, 10)
        Me.lblTodayRevenue.Name = "lblTodayRevenue"
        Me.lblTodayRevenue.Size = New System.Drawing.Size(102, 17)
        Me.lblTodayRevenue.TabIndex = 0
        Me.lblTodayRevenue.Text = "Today's Revenue"
        '
        'lblTodayRevenueVal
        '
        Me.lblTodayRevenueVal.AutoSize = True
        Me.lblTodayRevenueVal.Font = New System.Drawing.Font("Segoe UI", 16.0!, System.Drawing.FontStyle.Bold)
        Me.lblTodayRevenueVal.ForeColor = System.Drawing.Color.FromArgb(20, 150, 85)
        Me.lblTodayRevenueVal.Location = New System.Drawing.Point(10, 45)
        Me.lblTodayRevenueVal.Name = "lblTodayRevenueVal"
        Me.lblTodayRevenueVal.Size = New System.Drawing.Size(95, 30)
        Me.lblTodayRevenueVal.TabIndex = 1
        Me.lblTodayRevenueVal.Text = "RM 0.00"
        '
        'pnlBookings
        '
        Me.pnlBookings.BackColor = System.Drawing.Color.FromArgb(35, 42, 38)
        Me.pnlBookings.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnlBookings.Controls.Add(Me.lblTotalBookingsVal)
        Me.pnlBookings.Controls.Add(Me.lblTotalBookings)
        Me.pnlBookings.Location = New System.Drawing.Point(240, 70)
        Me.pnlBookings.Name = "pnlBookings"
        Me.pnlBookings.Size = New System.Drawing.Size(200, 100)
        Me.pnlBookings.TabIndex = 2
        '
        'lblTotalBookings
        '
        Me.lblTotalBookings.AutoSize = True
        Me.lblTotalBookings.Font = New System.Drawing.Font("Segoe UI", 9.5!)
        Me.lblTotalBookings.ForeColor = System.Drawing.Color.FromArgb(140, 160, 150)
        Me.lblTotalBookings.Location = New System.Drawing.Point(10, 10)
        Me.lblTotalBookings.Name = "lblTotalBookings"
        Me.lblTotalBookings.Size = New System.Drawing.Size(94, 17)
        Me.lblTotalBookings.TabIndex = 0
        Me.lblTotalBookings.Text = "Total Bookings"
        '
        'lblTotalBookingsVal
        '
        Me.lblTotalBookingsVal.AutoSize = True
        Me.lblTotalBookingsVal.Font = New System.Drawing.Font("Segoe UI", 16.0!, System.Drawing.FontStyle.Bold)
        Me.lblTotalBookingsVal.ForeColor = System.Drawing.Color.FromArgb(20, 150, 85)
        Me.lblTotalBookingsVal.Location = New System.Drawing.Point(10, 45)
        Me.lblTotalBookingsVal.Name = "lblTotalBookingsVal"
        Me.lblTotalBookingsVal.Size = New System.Drawing.Size(26, 30)
        Me.lblTotalBookingsVal.TabIndex = 1
        Me.lblTotalBookingsVal.Text = "0"
        '
        'pnlOccupancy
        '
        Me.pnlOccupancy.BackColor = System.Drawing.Color.FromArgb(35, 42, 38)
        Me.pnlOccupancy.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnlOccupancy.Controls.Add(Me.lblOccupancyVal)
        Me.pnlOccupancy.Controls.Add(Me.lblOccupancy)
        Me.pnlOccupancy.Location = New System.Drawing.Point(460, 70)
        Me.pnlOccupancy.Name = "pnlOccupancy"
        Me.pnlOccupancy.Size = New System.Drawing.Size(200, 100)
        Me.pnlOccupancy.TabIndex = 3
        '
        'lblOccupancy
        '
        Me.lblOccupancy.AutoSize = True
        Me.lblOccupancy.Font = New System.Drawing.Font("Segoe UI", 9.5!)
        Me.lblOccupancy.ForeColor = System.Drawing.Color.FromArgb(140, 160, 150)
        Me.lblOccupancy.Location = New System.Drawing.Point(10, 10)
        Me.lblOccupancy.Name = "lblOccupancy"
        Me.lblOccupancy.Size = New System.Drawing.Size(126, 17)
        Me.lblOccupancy.TabIndex = 0
        Me.lblOccupancy.Text = "Avg Seat Occupancy"
        '
        'lblOccupancyVal
        '
        Me.lblOccupancyVal.AutoSize = True
        Me.lblOccupancyVal.Font = New System.Drawing.Font("Segoe UI", 16.0!, System.Drawing.FontStyle.Bold)
        Me.lblOccupancyVal.ForeColor = System.Drawing.Color.FromArgb(20, 150, 85)
        Me.lblOccupancyVal.Location = New System.Drawing.Point(10, 45)
        Me.lblOccupancyVal.Name = "lblOccupancyVal"
        Me.lblOccupancyVal.Size = New System.Drawing.Size(60, 30)
        Me.lblOccupancyVal.TabIndex = 1
        Me.lblOccupancyVal.Text = "0.0%"
        'pnlRevenueChart
        '
        Me.pnlRevenueChart.Location = New System.Drawing.Point(20, 180)
        Me.pnlRevenueChart.Name = "pnlRevenueChart"
        Me.pnlRevenueChart.Size = New System.Drawing.Size(550, 250)
        Me.pnlRevenueChart.TabIndex = 4
        Me.pnlRevenueChart.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) Or System.Windows.Forms.AnchorStyles.Left) Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        '
        'pnlRoutesChart
        '
        Me.pnlRoutesChart.Location = New System.Drawing.Point(590, 180)
        Me.pnlRoutesChart.Name = "pnlRoutesChart"
        Me.pnlRoutesChart.Size = New System.Drawing.Size(380, 250)
        Me.pnlRoutesChart.TabIndex = 5
        Me.pnlRoutesChart.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        '
        'cmdManageSchedules
        '
        Me.cmdManageSchedules.BackColor = System.Drawing.Color.FromArgb(20, 150, 85)
        Me.cmdManageSchedules.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdManageSchedules.FlatAppearance.BorderSize = 0
        Me.cmdManageSchedules.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold)
        Me.cmdManageSchedules.ForeColor = System.Drawing.Color.White
        Me.cmdManageSchedules.Location = New System.Drawing.Point(20, 460)
        Me.cmdManageSchedules.Name = "cmdManageSchedules"
        Me.cmdManageSchedules.Size = New System.Drawing.Size(180, 45)
        Me.cmdManageSchedules.TabIndex = 6
        Me.cmdManageSchedules.Text = "🚌 Manage Schedules"
        Me.cmdManageSchedules.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.cmdManageSchedules.UseVisualStyleBackColor = False
        '
        'cmdManagePassengers
        '
        Me.cmdManagePassengers.BackColor = System.Drawing.Color.FromArgb(20, 150, 85)
        Me.cmdManagePassengers.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdManagePassengers.FlatAppearance.BorderSize = 0
        Me.cmdManagePassengers.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold)
        Me.cmdManagePassengers.ForeColor = System.Drawing.Color.White
        Me.cmdManagePassengers.Location = New System.Drawing.Point(210, 460)
        Me.cmdManagePassengers.Name = "cmdManagePassengers"
        Me.cmdManagePassengers.Size = New System.Drawing.Size(190, 45)
        Me.cmdManagePassengers.TabIndex = 8
        Me.cmdManagePassengers.Text = "👥 Manage Passengers"
        Me.cmdManagePassengers.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.cmdManagePassengers.UseVisualStyleBackColor = False
        '
        'cmdLogout
        '
        Me.cmdLogout.BackColor = System.Drawing.Color.FromArgb(180, 50, 50)
        Me.cmdLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdLogout.FlatAppearance.BorderSize = 0
        Me.cmdLogout.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold)
        Me.cmdLogout.ForeColor = System.Drawing.Color.White
        Me.cmdLogout.Location = New System.Drawing.Point(410, 460)
        Me.cmdLogout.Name = "cmdLogout"
        Me.cmdLogout.Size = New System.Drawing.Size(150, 45)
        Me.cmdLogout.TabIndex = 7
        Me.cmdLogout.Text = "🚪 Logout"
        Me.cmdLogout.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.cmdLogout.UseVisualStyleBackColor = False
        '
        'frmAdminDashboard
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(25, 30, 28)
        Me.ClientSize = New System.Drawing.Size(1000, 520)
        Me.Controls.Add(Me.cmdLogout)
        Me.Controls.Add(Me.cmdManagePassengers)
        Me.Controls.Add(Me.cmdManageSchedules)
        Me.Controls.Add(Me.pnlRevenueChart)
        Me.Controls.Add(Me.pnlRoutesChart)
        Me.Controls.Add(Me.pnlOccupancy)
        Me.Controls.Add(Me.pnlBookings)
        Me.Controls.Add(Me.pnlRevenue)
        Me.Controls.Add(Me.lblTitle)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Sizable
        Me.MaximizeBox = True
        Me.Name = "frmAdminDashboard"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ambatubus - Admin Dashboard"
        Me.pnlRevenue.ResumeLayout(False)
        Me.pnlRevenue.PerformLayout()
        Me.pnlBookings.ResumeLayout(False)
        Me.pnlBookings.PerformLayout()
        Me.pnlOccupancy.ResumeLayout(False)
        Me.pnlOccupancy.PerformLayout()

        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblTitle As System.Windows.Forms.Label
    Friend WithEvents pnlRevenue As System.Windows.Forms.Panel
    Friend WithEvents lblTodayRevenue As System.Windows.Forms.Label
    Friend WithEvents lblTodayRevenueVal As System.Windows.Forms.Label
    Friend WithEvents pnlBookings As System.Windows.Forms.Panel
    Friend WithEvents lblTotalBookings As System.Windows.Forms.Label
    Friend WithEvents lblTotalBookingsVal As System.Windows.Forms.Label
    Friend WithEvents pnlOccupancy As System.Windows.Forms.Panel
    Friend WithEvents lblOccupancy As System.Windows.Forms.Label
    Friend WithEvents lblOccupancyVal As System.Windows.Forms.Label
    Friend WithEvents pnlRevenueChart As System.Windows.Forms.Panel
    Friend WithEvents pnlRoutesChart As System.Windows.Forms.Panel
    Friend WithEvents cmdManageSchedules As System.Windows.Forms.Button
    Friend WithEvents cmdManagePassengers As System.Windows.Forms.Button
    Friend WithEvents cmdLogout As System.Windows.Forms.Button
End Class
