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
        Me.grpStats = New System.Windows.Forms.GroupBox()
        Me.lblTotalBookings = New System.Windows.Forms.Label()
        Me.lblTotalBookingsVal = New System.Windows.Forms.Label()
        Me.lblTotalRoutes = New System.Windows.Forms.Label()
        Me.lblTotalRoutesVal = New System.Windows.Forms.Label()
        Me.lblTotalRevenue = New System.Windows.Forms.Label()
        Me.lblTotalRevenueVal = New System.Windows.Forms.Label()
        Me.grpRoutes = New System.Windows.Forms.GroupBox()
        Me.dgvRoutes = New System.Windows.Forms.DataGridView()
        Me.cmdBook = New System.Windows.Forms.Button()
        Me.cmdAdmin = New System.Windows.Forms.Button()
        Me.cmdClose = New System.Windows.Forms.Button()
        Me.grpStats.SuspendLayout()
        Me.grpRoutes.SuspendLayout()
        CType(Me.dgvRoutes, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblTitle
        '
        Me.lblTitle.AutoSize = True
        Me.lblTitle.Font = New System.Drawing.Font("Segoe UI", 24.0!, System.Drawing.FontStyle.Bold)
        Me.lblTitle.ForeColor = System.Drawing.Color.FromArgb(20, 80, 40)
        Me.lblTitle.Location = New System.Drawing.Point(30, 25)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(430, 45)
        Me.lblTitle.Text = "ambatubus Transit System"
        '
        'grpStats
        '
        Me.grpStats.Controls.Add(Me.lblTotalBookings)
        Me.grpStats.Controls.Add(Me.lblTotalBookingsVal)
        Me.grpStats.Controls.Add(Me.lblTotalRoutes)
        Me.grpStats.Controls.Add(Me.lblTotalRoutesVal)
        Me.grpStats.Controls.Add(Me.lblTotalRevenue)
        Me.grpStats.Controls.Add(Me.lblTotalRevenueVal)
        Me.grpStats.Font = New System.Drawing.Font("Segoe UI Semibold", 10.0!, System.Drawing.FontStyle.Bold)
        Me.grpStats.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.grpStats.Location = New System.Drawing.Point(30, 90)
        Me.grpStats.Size = New System.Drawing.Size(740, 110)
        Me.grpStats.Text = "Dashboard Summary"
        '
        'lblTotalBookings
        '
        Me.lblTotalBookings.AutoSize = True
        Me.lblTotalBookings.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.lblTotalBookings.ForeColor = System.Drawing.Color.Gray
        Me.lblTotalBookings.Location = New System.Drawing.Point(30, 30)
        Me.lblTotalBookings.Text = "Total Bookings"
        '
        'lblTotalBookingsVal
        '
        Me.lblTotalBookingsVal.AutoSize = True
        Me.lblTotalBookingsVal.Font = New System.Drawing.Font("Segoe UI", 20.0!, System.Drawing.FontStyle.Bold)
        Me.lblTotalBookingsVal.ForeColor = System.Drawing.Color.FromArgb(0, 120, 200)
        Me.lblTotalBookingsVal.Location = New System.Drawing.Point(30, 50)
        Me.lblTotalBookingsVal.Text = "0"
        '
        'lblTotalRoutes
        '
        Me.lblTotalRoutes.AutoSize = True
        Me.lblTotalRoutes.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.lblTotalRoutes.ForeColor = System.Drawing.Color.Gray
        Me.lblTotalRoutes.Location = New System.Drawing.Point(280, 30)
        Me.lblTotalRoutes.Text = "Active Routes"
        '
        'lblTotalRoutesVal
        '
        Me.lblTotalRoutesVal.AutoSize = True
        Me.lblTotalRoutesVal.Font = New System.Drawing.Font("Segoe UI", 20.0!, System.Drawing.FontStyle.Bold)
        Me.lblTotalRoutesVal.ForeColor = System.Drawing.Color.FromArgb(20, 140, 80)
        Me.lblTotalRoutesVal.Location = New System.Drawing.Point(280, 50)
        Me.lblTotalRoutesVal.Text = "0"
        '
        'lblTotalRevenue
        '
        Me.lblTotalRevenue.AutoSize = True
        Me.lblTotalRevenue.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.lblTotalRevenue.ForeColor = System.Drawing.Color.Gray
        Me.lblTotalRevenue.Location = New System.Drawing.Point(530, 30)
        Me.lblTotalRevenue.Text = "Total Revenue"
        '
        'lblTotalRevenueVal
        '
        Me.lblTotalRevenueVal.AutoSize = True
        Me.lblTotalRevenueVal.Font = New System.Drawing.Font("Segoe UI", 20.0!, System.Drawing.FontStyle.Bold)
        Me.lblTotalRevenueVal.ForeColor = System.Drawing.Color.FromArgb(200, 80, 0)
        Me.lblTotalRevenueVal.Location = New System.Drawing.Point(530, 50)
        Me.lblTotalRevenueVal.Text = "RM 0.00"
        '
        'grpRoutes
        '
        Me.grpRoutes.Controls.Add(Me.dgvRoutes)
        Me.grpRoutes.Font = New System.Drawing.Font("Segoe UI Semibold", 10.0!, System.Drawing.FontStyle.Bold)
        Me.grpRoutes.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.grpRoutes.Location = New System.Drawing.Point(30, 220)
        Me.grpRoutes.Size = New System.Drawing.Size(740, 250)
        Me.grpRoutes.Text = "Available Malaysian Routes"
        '
        'dgvRoutes
        '
        Me.dgvRoutes.AllowUserToAddRows = False
        Me.dgvRoutes.AllowUserToDeleteRows = False
        Me.dgvRoutes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvRoutes.BackgroundColor = System.Drawing.Color.White
        Me.dgvRoutes.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgvRoutes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvRoutes.Location = New System.Drawing.Point(15, 25)
        Me.dgvRoutes.MultiSelect = False
        Me.dgvRoutes.ReadOnly = True
        Me.dgvRoutes.RowHeadersVisible = False
        Me.dgvRoutes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvRoutes.Size = New System.Drawing.Size(710, 210)
        '
        'cmdBook
        '
        Me.cmdBook.BackColor = System.Drawing.Color.FromArgb(20, 120, 60)
        Me.cmdBook.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdBook.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Bold)
        Me.cmdBook.ForeColor = System.Drawing.Color.White
        Me.cmdBook.Location = New System.Drawing.Point(30, 490)
        Me.cmdBook.Size = New System.Drawing.Size(180, 45)
        Me.cmdBook.Text = "🎫 Ticket Booking"
        Me.cmdBook.UseVisualStyleBackColor = False
        '
        'cmdAdmin
        '
        Me.cmdAdmin.BackColor = System.Drawing.Color.FromArgb(70, 80, 90)
        Me.cmdAdmin.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdAdmin.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Bold)
        Me.cmdAdmin.ForeColor = System.Drawing.Color.White
        Me.cmdAdmin.Location = New System.Drawing.Point(230, 490)
        Me.cmdAdmin.Size = New System.Drawing.Size(180, 45)
        Me.cmdAdmin.Text = "⚙️ Bus Admin Panel"
        Me.cmdAdmin.UseVisualStyleBackColor = False
        '
        'cmdClose
        '
        Me.cmdClose.BackColor = System.Drawing.Color.FromArgb(200, 50, 50)
        Me.cmdClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdClose.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Bold)
        Me.cmdClose.ForeColor = System.Drawing.Color.White
        Me.cmdClose.Location = New System.Drawing.Point(620, 490)
        Me.cmdClose.Size = New System.Drawing.Size(150, 45)
        Me.cmdClose.Text = "❌ Exit App"
        Me.cmdClose.UseVisualStyleBackColor = False
        '
        'frmMainMenu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(245, 248, 245)
        Me.ClientSize = New System.Drawing.Size(800, 560)
        Me.Controls.Add(Me.cmdClose)
        Me.Controls.Add(Me.cmdAdmin)
        Me.Controls.Add(Me.cmdBook)
        Me.Controls.Add(Me.grpRoutes)
        Me.Controls.Add(Me.grpStats)
        Me.Controls.Add(Me.lblTitle)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "frmMainMenu"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ambatubus - Dashboard"
        Me.grpStats.ResumeLayout(False)
        Me.grpStats.PerformLayout()
        Me.grpRoutes.ResumeLayout(False)
        CType(Me.dgvRoutes, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblTitle As System.Windows.Forms.Label
    Friend WithEvents grpStats As System.Windows.Forms.GroupBox
    Friend WithEvents lblTotalBookings As System.Windows.Forms.Label
    Friend WithEvents lblTotalBookingsVal As System.Windows.Forms.Label
    Friend WithEvents lblTotalRoutes As System.Windows.Forms.Label
    Friend WithEvents lblTotalRoutesVal As System.Windows.Forms.Label
    Friend WithEvents lblTotalRevenue As System.Windows.Forms.Label
    Friend WithEvents lblTotalRevenueVal As System.Windows.Forms.Label
    Friend WithEvents grpRoutes As System.Windows.Forms.GroupBox
    Friend WithEvents dgvRoutes As System.Windows.Forms.DataGridView
    Friend WithEvents cmdBook As System.Windows.Forms.Button
    Friend WithEvents cmdAdmin As System.Windows.Forms.Button
    Friend WithEvents cmdClose As System.Windows.Forms.Button
End Class