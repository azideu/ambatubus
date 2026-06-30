<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmMainMenu
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
        Me.picBanner = New System.Windows.Forms.PictureBox()
        Me.pnlStatBookings = New System.Windows.Forms.Panel()
        Me.lblTotalBookings = New System.Windows.Forms.Label()
        Me.lblTotalBookingsVal = New System.Windows.Forms.Label()
        Me.pnlStatRoutes = New System.Windows.Forms.Panel()
        Me.lblTotalRoutes = New System.Windows.Forms.Label()
        Me.lblTotalRoutesVal = New System.Windows.Forms.Label()
        Me.pnlStatRevenue = New System.Windows.Forms.Panel()
        Me.lblTotalRevenue = New System.Windows.Forms.Label()
        Me.lblTotalRevenueVal = New System.Windows.Forms.Label()
        Me.grpRoutes = New System.Windows.Forms.GroupBox()
        Me.lblSearch = New System.Windows.Forms.Label()
        Me.txtSearchRoute = New System.Windows.Forms.TextBox()
        Me.dgvRoutes = New System.Windows.Forms.DataGridView()
        Me.cmdBook = New System.Windows.Forms.Button()
        Me.cmdAdmin = New System.Windows.Forms.Button()
        Me.cmdMyAccount = New System.Windows.Forms.Button()
        Me.cmdClose = New System.Windows.Forms.Button()
        Me.cmdToggleTheme = New System.Windows.Forms.Button()
        Me.lblUserStatus = New System.Windows.Forms.Label()
        CType(Me.picBanner, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlStatBookings.SuspendLayout()
        Me.pnlStatRoutes.SuspendLayout()
        Me.pnlStatRevenue.SuspendLayout()
        Me.grpRoutes.SuspendLayout()
        CType(Me.dgvRoutes, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SuspendLayout()
        '
        'lblTitle
        '
        Me.lblTitle.AutoSize = True
        Me.lblTitle.Font = New System.Drawing.Font("Segoe UI", 24.0!, System.Drawing.FontStyle.Bold)
        Me.lblTitle.ForeColor = System.Drawing.Color.White
        Me.lblTitle.Location = New System.Drawing.Point(30, 25)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(430, 45)
        Me.lblTitle.Text = "ambatubus Transit System"
        '
        'picBanner
        '
        Me.picBanner.Location = New System.Drawing.Point(30, 20)
        Me.picBanner.Name = "picBanner"
        Me.picBanner.Size = New System.Drawing.Size(800, 160)
        Me.picBanner.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picBanner.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        '
        'pnlStatBookings
        '
        Me.pnlStatBookings.BackColor = System.Drawing.Color.FromArgb(35, 42, 38)
        Me.pnlStatBookings.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnlStatBookings.Controls.Add(Me.lblTotalBookings)
        Me.pnlStatBookings.Controls.Add(Me.lblTotalBookingsVal)
        Me.pnlStatBookings.Location = New System.Drawing.Point(30, 200)
        Me.pnlStatBookings.Name = "pnlStatBookings"
        Me.pnlStatBookings.Size = New System.Drawing.Size(250, 110)
        '
        'lblTotalBookings
        '
        Me.lblTotalBookings.AutoSize = True
        Me.lblTotalBookings.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.lblTotalBookings.ForeColor = System.Drawing.Color.FromArgb(140, 160, 150)
        Me.lblTotalBookings.Location = New System.Drawing.Point(20, 20)
        Me.lblTotalBookings.Text = "Total Bookings"
        '
        'lblTotalBookingsVal
        '
        Me.lblTotalBookingsVal.AutoSize = True
        Me.lblTotalBookingsVal.Font = New System.Drawing.Font("Segoe UI", 20.0!, System.Drawing.FontStyle.Bold)
        Me.lblTotalBookingsVal.ForeColor = System.Drawing.Color.FromArgb(80, 180, 240)
        Me.lblTotalBookingsVal.Location = New System.Drawing.Point(20, 45)
        Me.lblTotalBookingsVal.Text = "0"
        '
        'pnlStatRoutes
        '
        Me.pnlStatRoutes.BackColor = System.Drawing.Color.FromArgb(35, 42, 38)
        Me.pnlStatRoutes.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnlStatRoutes.Controls.Add(Me.lblTotalRoutes)
        Me.pnlStatRoutes.Controls.Add(Me.lblTotalRoutesVal)
        Me.pnlStatRoutes.Location = New System.Drawing.Point(305, 200)
        Me.pnlStatRoutes.Name = "pnlStatRoutes"
        Me.pnlStatRoutes.Size = New System.Drawing.Size(250, 110)
        '
        'lblTotalRoutes
        '
        Me.lblTotalRoutes.AutoSize = True
        Me.lblTotalRoutes.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.lblTotalRoutes.ForeColor = System.Drawing.Color.FromArgb(140, 160, 150)
        Me.lblTotalRoutes.Location = New System.Drawing.Point(20, 20)
        Me.lblTotalRoutes.Text = "Active Routes"
        '
        'lblTotalRoutesVal
        '
        Me.lblTotalRoutesVal.AutoSize = True
        Me.lblTotalRoutesVal.Font = New System.Drawing.Font("Segoe UI", 20.0!, System.Drawing.FontStyle.Bold)
        Me.lblTotalRoutesVal.ForeColor = System.Drawing.Color.FromArgb(100, 220, 150)
        Me.lblTotalRoutesVal.Location = New System.Drawing.Point(20, 45)
        Me.lblTotalRoutesVal.Text = "0"
        '
        'pnlStatRevenue
        '
        Me.pnlStatRevenue.BackColor = System.Drawing.Color.FromArgb(35, 42, 38)
        Me.pnlStatRevenue.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnlStatRevenue.Controls.Add(Me.lblTotalRevenue)
        Me.pnlStatRevenue.Controls.Add(Me.lblTotalRevenueVal)
        Me.pnlStatRevenue.Location = New System.Drawing.Point(580, 200)
        Me.pnlStatRevenue.Name = "pnlStatRevenue"
        Me.pnlStatRevenue.Size = New System.Drawing.Size(250, 110)
        '
        'lblTotalRevenue
        '
        Me.lblTotalRevenue.AutoSize = True
        Me.lblTotalRevenue.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.lblTotalRevenue.ForeColor = System.Drawing.Color.FromArgb(140, 160, 150)
        Me.lblTotalRevenue.Location = New System.Drawing.Point(20, 20)
        Me.lblTotalRevenue.Text = "Total Revenue"
        '
        'lblTotalRevenueVal
        '
        Me.lblTotalRevenueVal.AutoSize = True
        Me.lblTotalRevenueVal.Font = New System.Drawing.Font("Segoe UI", 20.0!, System.Drawing.FontStyle.Bold)
        Me.lblTotalRevenueVal.ForeColor = System.Drawing.Color.FromArgb(250, 180, 80)
        Me.lblTotalRevenueVal.Location = New System.Drawing.Point(20, 45)
        Me.lblTotalRevenueVal.Text = "RM 0.00"
        '
        'grpRoutes
        '
        Me.grpRoutes.Controls.Add(Me.lblSearch)
        Me.grpRoutes.Controls.Add(Me.txtSearchRoute)
        Me.grpRoutes.Controls.Add(Me.dgvRoutes)
        Me.grpRoutes.Font = New System.Drawing.Font("Segoe UI Semibold", 10.0!, System.Drawing.FontStyle.Bold)
        Me.grpRoutes.ForeColor = System.Drawing.Color.FromArgb(100, 120, 110)
        Me.grpRoutes.Location = New System.Drawing.Point(30, 335)
        Me.grpRoutes.Size = New System.Drawing.Size(800, 270)
        Me.grpRoutes.Text = "Available Malaysian Routes"
        Me.grpRoutes.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) Or System.Windows.Forms.AnchorStyles.Left) Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        '
        'lblSearch
        '
        Me.lblSearch.AutoSize = True
        Me.lblSearch.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.lblSearch.ForeColor = System.Drawing.Color.FromArgb(220, 235, 225)
        Me.lblSearch.Location = New System.Drawing.Point(15, 25)
        Me.lblSearch.Text = "Search Route:"
        Me.lblSearch.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        '
        'txtSearchRoute
        '
        Me.txtSearchRoute.BackColor = System.Drawing.Color.FromArgb(35, 42, 38)
        Me.txtSearchRoute.ForeColor = System.Drawing.Color.FromArgb(220, 235, 225)
        Me.txtSearchRoute.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtSearchRoute.Font = New System.Drawing.Font("Segoe UI", 9.5!)
        Me.txtSearchRoute.Location = New System.Drawing.Point(110, 22)
        Me.txtSearchRoute.Size = New System.Drawing.Size(250, 23)
        Me.txtSearchRoute.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        '
        'dgvRoutes
        '
        Me.dgvRoutes.AllowUserToAddRows = False
        Me.dgvRoutes.AllowUserToDeleteRows = False
        Me.dgvRoutes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvRoutes.BackgroundColor = System.Drawing.Color.FromArgb(35, 42, 38)
        Me.dgvRoutes.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgvRoutes.GridColor = System.Drawing.Color.FromArgb(50, 60, 55)
        Me.dgvRoutes.Location = New System.Drawing.Point(15, 55)
        Me.dgvRoutes.MultiSelect = False
        Me.dgvRoutes.ReadOnly = True
        Me.dgvRoutes.RowHeadersVisible = False
        Me.dgvRoutes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvRoutes.Size = New System.Drawing.Size(770, 200)
        Me.dgvRoutes.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) Or System.Windows.Forms.AnchorStyles.Left) Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Dim dgvRoutesStyle1 As New System.Windows.Forms.DataGridViewCellStyle()
        dgvRoutesStyle1.BackColor = System.Drawing.Color.FromArgb(20, 110, 60)
        dgvRoutesStyle1.ForeColor = System.Drawing.Color.White
        dgvRoutesStyle1.Font = New System.Drawing.Font("Segoe UI Semibold", 9.5!, System.Drawing.FontStyle.Bold)
        dgvRoutesStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(20, 110, 60)
        dgvRoutesStyle1.SelectionForeColor = System.Drawing.Color.White
        Me.dgvRoutes.ColumnHeadersDefaultCellStyle = dgvRoutesStyle1
        Me.dgvRoutes.EnableHeadersVisualStyles = False
        Dim dgvRoutesStyle2 As New System.Windows.Forms.DataGridViewCellStyle()
        dgvRoutesStyle2.BackColor = System.Drawing.Color.FromArgb(35, 42, 38)
        dgvRoutesStyle2.ForeColor = System.Drawing.Color.FromArgb(220, 235, 225)
        dgvRoutesStyle2.Font = New System.Drawing.Font("Segoe UI", 9.5!)
        dgvRoutesStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(25, 130, 75)
        dgvRoutesStyle2.SelectionForeColor = System.Drawing.Color.White
        Me.dgvRoutes.DefaultCellStyle = dgvRoutesStyle2
        Dim dgvRoutesStyle3 As New System.Windows.Forms.DataGridViewCellStyle()
        dgvRoutesStyle3.BackColor = System.Drawing.Color.FromArgb(30, 36, 33)
        dgvRoutesStyle3.ForeColor = System.Drawing.Color.FromArgb(220, 235, 225)
        dgvRoutesStyle3.Font = New System.Drawing.Font("Segoe UI", 9.5!)
        dgvRoutesStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(25, 130, 75)
        dgvRoutesStyle3.SelectionForeColor = System.Drawing.Color.White
        Me.dgvRoutes.AlternatingRowsDefaultCellStyle = dgvRoutesStyle3
        '
        'cmdBook
        '
        Me.cmdBook.BackColor = System.Drawing.Color.FromArgb(20, 150, 85)
        Me.cmdBook.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdBook.FlatAppearance.BorderSize = 0
        Me.cmdBook.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Bold)
        Me.cmdBook.ForeColor = System.Drawing.Color.White
        Me.cmdBook.Location = New System.Drawing.Point(30, 625)
        Me.cmdBook.Size = New System.Drawing.Size(190, 45)
        Me.cmdBook.Text = "🎫 Ticket Booking"
        Me.cmdBook.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.cmdBook.UseVisualStyleBackColor = False
        '
        'cmdAdmin
        '
        Me.cmdAdmin.BackColor = System.Drawing.Color.FromArgb(65, 75, 70)
        Me.cmdAdmin.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdAdmin.FlatAppearance.BorderSize = 0
        Me.cmdAdmin.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Bold)
        Me.cmdAdmin.ForeColor = System.Drawing.Color.White
        Me.cmdAdmin.Location = New System.Drawing.Point(437, 625)
        Me.cmdAdmin.Size = New System.Drawing.Size(190, 45)
        Me.cmdAdmin.Text = "⚙️ Bus Admin Panel"
        Me.cmdAdmin.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.cmdAdmin.UseVisualStyleBackColor = False
        '
        'cmdClose
        '
        Me.cmdClose.BackColor = System.Drawing.Color.FromArgb(180, 50, 50)
        Me.cmdClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdClose.FlatAppearance.BorderSize = 0
        Me.cmdClose.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Bold)
        Me.cmdClose.ForeColor = System.Drawing.Color.White
        Me.cmdClose.Location = New System.Drawing.Point(640, 625)
        Me.cmdClose.Size = New System.Drawing.Size(190, 45)
        Me.cmdClose.TabIndex = 6
        Me.cmdClose.Text = "🚪 Exit System"
        Me.cmdClose.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmdClose.UseVisualStyleBackColor = False
        '
        'cmdMyAccount
        '
        Me.cmdMyAccount.BackColor = System.Drawing.Color.FromArgb(30, 130, 190)
        Me.cmdMyAccount.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdMyAccount.FlatAppearance.BorderSize = 0
        Me.cmdMyAccount.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Bold)
        Me.cmdMyAccount.ForeColor = System.Drawing.Color.White
        Me.cmdMyAccount.Location = New System.Drawing.Point(233, 625)
        Me.cmdMyAccount.Size = New System.Drawing.Size(190, 45)
        Me.cmdMyAccount.Text = "👤 My Account"
        Me.cmdMyAccount.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.cmdMyAccount.UseVisualStyleBackColor = False
        '
        'lblUserStatus
        '
        Me.lblUserStatus.AutoSize = True
        Me.lblUserStatus.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.lblUserStatus.ForeColor = System.Drawing.Color.FromArgb(100, 220, 150)
        Me.lblUserStatus.Location = New System.Drawing.Point(30, 185)
        Me.lblUserStatus.Name = "lblUserStatus"
        Me.lblUserStatus.Text = ""
        Me.lblUserStatus.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        '
        'cmdToggleTheme
        '
        Me.cmdToggleTheme.BackColor = System.Drawing.Color.FromArgb(65, 75, 70)
        Me.cmdToggleTheme.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdToggleTheme.FlatAppearance.BorderSize = 0
        Me.cmdToggleTheme.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.cmdToggleTheme.ForeColor = System.Drawing.Color.White
        Me.cmdToggleTheme.Location = New System.Drawing.Point(670, 25)
        Me.cmdToggleTheme.Name = "cmdToggleTheme"
        Me.cmdToggleTheme.Size = New System.Drawing.Size(160, 35)
        Me.cmdToggleTheme.TabIndex = 7
        Me.cmdToggleTheme.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmdToggleTheme.Text = "🌓 Toggle Theme"
        Me.cmdToggleTheme.UseVisualStyleBackColor = False
        '
        'frmMainMenu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(25, 30, 28)
        Me.ClientSize = New System.Drawing.Size(860, 695)
        Me.Controls.Add(Me.cmdClose)
        Me.Controls.Add(Me.cmdAdmin)
        Me.Controls.Add(Me.cmdMyAccount)
        Me.Controls.Add(Me.cmdBook)
        Me.Controls.Add(Me.cmdToggleTheme)
        Me.Controls.Add(Me.grpRoutes)
        Me.Controls.Add(Me.pnlStatRevenue)
        Me.Controls.Add(Me.pnlStatRoutes)
        Me.Controls.Add(Me.pnlStatBookings)
        Me.Controls.Add(Me.picBanner)
        Me.Controls.Add(Me.lblTitle)
        Me.Controls.Add(Me.lblUserStatus)
        Me.Name = "frmMainMenu"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ambatubus - Dashboard"
        CType(Me.picBanner, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlStatBookings.ResumeLayout(False)
        Me.pnlStatBookings.PerformLayout()
        Me.pnlStatRoutes.ResumeLayout(False)
        Me.pnlStatRoutes.PerformLayout()
        Me.pnlStatRevenue.ResumeLayout(False)
        Me.pnlStatRevenue.PerformLayout()
        Me.grpRoutes.ResumeLayout(False)
        Me.grpRoutes.PerformLayout()
        CType(Me.dgvRoutes, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()
    End Sub

    Friend WithEvents lblTitle As System.Windows.Forms.Label
    Friend WithEvents picBanner As System.Windows.Forms.PictureBox
    Friend WithEvents pnlStatBookings As System.Windows.Forms.Panel
    Friend WithEvents lblTotalBookings As System.Windows.Forms.Label
    Friend WithEvents lblTotalBookingsVal As System.Windows.Forms.Label
    Friend WithEvents pnlStatRoutes As System.Windows.Forms.Panel
    Friend WithEvents lblTotalRoutes As System.Windows.Forms.Label
    Friend WithEvents lblTotalRoutesVal As System.Windows.Forms.Label
    Friend WithEvents pnlStatRevenue As System.Windows.Forms.Panel
    Friend WithEvents lblTotalRevenue As System.Windows.Forms.Label
    Friend WithEvents lblTotalRevenueVal As System.Windows.Forms.Label
    Friend WithEvents grpRoutes As System.Windows.Forms.GroupBox
    Friend WithEvents lblSearch As System.Windows.Forms.Label
    Friend WithEvents txtSearchRoute As System.Windows.Forms.TextBox
    Friend WithEvents dgvRoutes As System.Windows.Forms.DataGridView
    Friend WithEvents cmdBook As System.Windows.Forms.Button
    Friend WithEvents cmdAdmin As System.Windows.Forms.Button
    Friend WithEvents cmdMyAccount As System.Windows.Forms.Button
    Friend WithEvents cmdClose As System.Windows.Forms.Button
    Friend WithEvents cmdToggleTheme As System.Windows.Forms.Button
    Friend WithEvents lblUserStatus As System.Windows.Forms.Label
End Class