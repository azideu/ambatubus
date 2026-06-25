<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmManagePassengers
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
        Me.grpPassengerInput = New System.Windows.Forms.GroupBox()
        Me.lblPassengerId = New System.Windows.Forms.Label()
        Me.txtPassengerId = New System.Windows.Forms.TextBox()
        Me.lblFullName = New System.Windows.Forms.Label()
        Me.txtFullName = New System.Windows.Forms.TextBox()
        Me.lblPhone = New System.Windows.Forms.Label()
        Me.txtPhone = New System.Windows.Forms.TextBox()
        Me.chkIsBlocked = New System.Windows.Forms.CheckBox()
        Me.cmdUpdate = New System.Windows.Forms.Button()
        Me.cmdClose = New System.Windows.Forms.Button()
        Me.grpPassengerGrid = New System.Windows.Forms.GroupBox()
        Me.lblSearch = New System.Windows.Forms.Label()
        Me.txtSearchName = New System.Windows.Forms.TextBox()
        Me.dgvPassengers = New System.Windows.Forms.DataGridView()
        Me.grpPassengerInput.SuspendLayout()
        Me.grpPassengerGrid.SuspendLayout()
        CType(Me.dgvPassengers, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblTitle
        '
        Me.lblTitle.AutoSize = True
        Me.lblTitle.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Bold)
        Me.lblTitle.ForeColor = System.Drawing.Color.White
        Me.lblTitle.Location = New System.Drawing.Point(20, 20)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(282, 32)
        Me.lblTitle.TabIndex = 0
        Me.lblTitle.Text = "Passenger Management"
        '
        'grpPassengerInput
        '
        Me.grpPassengerInput.Controls.Add(Me.lblPassengerId)
        Me.grpPassengerInput.Controls.Add(Me.txtPassengerId)
        Me.grpPassengerInput.Controls.Add(Me.lblFullName)
        Me.grpPassengerInput.Controls.Add(Me.txtFullName)
        Me.grpPassengerInput.Controls.Add(Me.lblPhone)
        Me.grpPassengerInput.Controls.Add(Me.txtPhone)
        Me.grpPassengerInput.Controls.Add(Me.chkIsBlocked)
        Me.grpPassengerInput.Font = New System.Drawing.Font("Segoe UI Semibold", 9.5!, System.Drawing.FontStyle.Bold)
        Me.grpPassengerInput.ForeColor = System.Drawing.Color.FromArgb(100, 120, 110)
        Me.grpPassengerInput.Location = New System.Drawing.Point(20, 65)
        Me.grpPassengerInput.Name = "grpPassengerInput"
        Me.grpPassengerInput.Size = New System.Drawing.Size(320, 395)
        Me.grpPassengerInput.TabIndex = 1
        Me.grpPassengerInput.TabStop = False
        Me.grpPassengerInput.Text = "Passenger Details"
        '
        'lblPassengerId
        '
        Me.lblPassengerId.AutoSize = True
        Me.lblPassengerId.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.lblPassengerId.ForeColor = System.Drawing.Color.FromArgb(140, 160, 150)
        Me.lblPassengerId.Location = New System.Drawing.Point(15, 30)
        Me.lblPassengerId.Name = "lblPassengerId"
        Me.lblPassengerId.Size = New System.Drawing.Size(74, 15)
        Me.lblPassengerId.TabIndex = 0
        Me.lblPassengerId.Text = "Passenger ID"
        '
        'txtPassengerId
        '
        Me.txtPassengerId.BackColor = System.Drawing.Color.FromArgb(35, 42, 38)
        Me.txtPassengerId.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtPassengerId.Enabled = False
        Me.txtPassengerId.ForeColor = System.Drawing.Color.FromArgb(220, 235, 225)
        Me.txtPassengerId.Location = New System.Drawing.Point(15, 50)
        Me.txtPassengerId.Name = "txtPassengerId"
        Me.txtPassengerId.ReadOnly = True
        Me.txtPassengerId.Size = New System.Drawing.Size(290, 24)
        Me.txtPassengerId.TabIndex = 1
        '
        'lblFullName
        '
        Me.lblFullName.AutoSize = True
        Me.lblFullName.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.lblFullName.ForeColor = System.Drawing.Color.FromArgb(140, 160, 150)
        Me.lblFullName.Location = New System.Drawing.Point(15, 90)
        Me.lblFullName.Name = "lblFullName"
        Me.lblFullName.Size = New System.Drawing.Size(61, 15)
        Me.lblFullName.TabIndex = 2
        Me.lblFullName.Text = "Full Name"
        '
        'txtFullName
        '
        Me.txtFullName.BackColor = System.Drawing.Color.FromArgb(35, 42, 38)
        Me.txtFullName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtFullName.ForeColor = System.Drawing.Color.FromArgb(220, 235, 225)
        Me.txtFullName.Location = New System.Drawing.Point(15, 110)
        Me.txtFullName.Name = "txtFullName"
        Me.txtFullName.Size = New System.Drawing.Size(290, 24)
        Me.txtFullName.TabIndex = 3
        '
        'lblPhone
        '
        Me.lblPhone.AutoSize = True
        Me.lblPhone.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.lblPhone.ForeColor = System.Drawing.Color.FromArgb(140, 160, 150)
        Me.lblPhone.Location = New System.Drawing.Point(15, 150)
        Me.lblPhone.Name = "lblPhone"
        Me.lblPhone.Size = New System.Drawing.Size(88, 15)
        Me.lblPhone.TabIndex = 4
        Me.lblPhone.Text = "Phone Number"
        '
        'txtPhone
        '
        Me.txtPhone.BackColor = System.Drawing.Color.FromArgb(35, 42, 38)
        Me.txtPhone.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtPhone.ForeColor = System.Drawing.Color.FromArgb(220, 235, 225)
        Me.txtPhone.Location = New System.Drawing.Point(15, 170)
        Me.txtPhone.Name = "txtPhone"
        Me.txtPhone.Size = New System.Drawing.Size(290, 24)
        Me.txtPhone.TabIndex = 5
        '
        'chkIsBlocked
        '
        Me.chkIsBlocked.AutoSize = True
        Me.chkIsBlocked.Font = New System.Drawing.Font("Segoe UI", 9.5!)
        Me.chkIsBlocked.ForeColor = System.Drawing.Color.FromArgb(220, 70, 70)
        Me.chkIsBlocked.Location = New System.Drawing.Point(15, 220)
        Me.chkIsBlocked.Name = "chkIsBlocked"
        Me.chkIsBlocked.Size = New System.Drawing.Size(185, 21)
        Me.chkIsBlocked.TabIndex = 6
        Me.chkIsBlocked.Text = "Block from making bookings"
        Me.chkIsBlocked.UseVisualStyleBackColor = True
        '
        'cmdUpdate
        '
        Me.cmdUpdate.BackColor = System.Drawing.Color.FromArgb(30, 130, 190)
        Me.cmdUpdate.FlatAppearance.BorderSize = 0
        Me.cmdUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdUpdate.Font = New System.Drawing.Font("Segoe UI", 9.5!, System.Drawing.FontStyle.Bold)
        Me.cmdUpdate.ForeColor = System.Drawing.Color.White
        Me.cmdUpdate.Location = New System.Drawing.Point(20, 480)
        Me.cmdUpdate.Name = "cmdUpdate"
        Me.cmdUpdate.Size = New System.Drawing.Size(145, 35)
        Me.cmdUpdate.TabIndex = 2
        Me.cmdUpdate.Text = "✏️ Update Passenger"
        Me.cmdUpdate.UseVisualStyleBackColor = False
        '
        'cmdClose
        '
        Me.cmdClose.BackColor = System.Drawing.Color.FromArgb(65, 75, 70)
        Me.cmdClose.FlatAppearance.BorderSize = 0
        Me.cmdClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdClose.Font = New System.Drawing.Font("Segoe UI", 9.5!, System.Drawing.FontStyle.Bold)
        Me.cmdClose.ForeColor = System.Drawing.Color.White
        Me.cmdClose.Location = New System.Drawing.Point(195, 480)
        Me.cmdClose.Name = "cmdClose"
        Me.cmdClose.Size = New System.Drawing.Size(145, 35)
        Me.cmdClose.TabIndex = 3
        Me.cmdClose.Text = "⬅️ Back"
        Me.cmdClose.UseVisualStyleBackColor = False
        '
        'grpPassengerGrid
        '
        Me.grpPassengerGrid.Controls.Add(Me.lblSearch)
        Me.grpPassengerGrid.Controls.Add(Me.txtSearchName)
        Me.grpPassengerGrid.Controls.Add(Me.dgvPassengers)
        Me.grpPassengerGrid.Font = New System.Drawing.Font("Segoe UI Semibold", 9.5!, System.Drawing.FontStyle.Bold)
        Me.grpPassengerGrid.ForeColor = System.Drawing.Color.FromArgb(100, 120, 110)
        Me.grpPassengerGrid.Location = New System.Drawing.Point(360, 65)
        Me.grpPassengerGrid.Name = "grpPassengerGrid"
        Me.grpPassengerGrid.Size = New System.Drawing.Size(610, 495)
        Me.grpPassengerGrid.TabIndex = 4
        Me.grpPassengerGrid.TabStop = False
        Me.grpPassengerGrid.Text = "Registered Passengers"
        '
        'lblSearch
        '
        Me.lblSearch.AutoSize = True
        Me.lblSearch.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.lblSearch.ForeColor = System.Drawing.Color.FromArgb(220, 235, 225)
        Me.lblSearch.Location = New System.Drawing.Point(15, 25)
        Me.lblSearch.Name = "lblSearch"
        Me.lblSearch.Size = New System.Drawing.Size(45, 15)
        Me.lblSearch.TabIndex = 0
        Me.lblSearch.Text = "Search:"
        '
        'txtSearchName
        '
        Me.txtSearchName.BackColor = System.Drawing.Color.FromArgb(35, 42, 38)
        Me.txtSearchName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtSearchName.Font = New System.Drawing.Font("Segoe UI", 9.5!)
        Me.txtSearchName.ForeColor = System.Drawing.Color.FromArgb(220, 235, 225)
        Me.txtSearchName.Location = New System.Drawing.Point(80, 22)
        Me.txtSearchName.Name = "txtSearchName"
        Me.txtSearchName.Size = New System.Drawing.Size(250, 24)
        Me.txtSearchName.TabIndex = 1
        '
        'dgvPassengers
        '
        Me.dgvPassengers.AllowUserToAddRows = False
        Me.dgvPassengers.AllowUserToDeleteRows = False
        Me.dgvPassengers.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvPassengers.BackgroundColor = System.Drawing.Color.FromArgb(35, 42, 38)
        Me.dgvPassengers.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgvPassengers.GridColor = System.Drawing.Color.FromArgb(50, 60, 55)
        Me.dgvPassengers.Location = New System.Drawing.Point(15, 55)
        Me.dgvPassengers.MultiSelect = False
        Me.dgvPassengers.Name = "dgvPassengers"
        Me.dgvPassengers.ReadOnly = True
        Me.dgvPassengers.RowHeadersVisible = False
        Me.dgvPassengers.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvPassengers.Size = New System.Drawing.Size(580, 425)
        Me.dgvPassengers.TabIndex = 2
        Dim dgvStyle1 As New System.Windows.Forms.DataGridViewCellStyle()
        dgvStyle1.BackColor = System.Drawing.Color.FromArgb(20, 110, 60)
        dgvStyle1.Font = New System.Drawing.Font("Segoe UI Semibold", 9.5!, System.Drawing.FontStyle.Bold)
        dgvStyle1.ForeColor = System.Drawing.Color.White
        dgvStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(20, 110, 60)
        dgvStyle1.SelectionForeColor = System.Drawing.Color.White
        Me.dgvPassengers.ColumnHeadersDefaultCellStyle = dgvStyle1
        Me.dgvPassengers.EnableHeadersVisualStyles = False
        Dim dgvStyle2 As New System.Windows.Forms.DataGridViewCellStyle()
        dgvStyle2.BackColor = System.Drawing.Color.FromArgb(35, 42, 38)
        dgvStyle2.Font = New System.Drawing.Font("Segoe UI", 9.5!)
        dgvStyle2.ForeColor = System.Drawing.Color.FromArgb(220, 235, 225)
        dgvStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(25, 130, 75)
        dgvStyle2.SelectionForeColor = System.Drawing.Color.White
        Me.dgvPassengers.DefaultCellStyle = dgvStyle2
        Dim dgvStyle3 As New System.Windows.Forms.DataGridViewCellStyle()
        dgvStyle3.BackColor = System.Drawing.Color.FromArgb(30, 36, 33)
        dgvStyle3.Font = New System.Drawing.Font("Segoe UI", 9.5!)
        dgvStyle3.ForeColor = System.Drawing.Color.FromArgb(220, 235, 225)
        dgvStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(25, 130, 75)
        dgvStyle3.SelectionForeColor = System.Drawing.Color.White
        Me.dgvPassengers.AlternatingRowsDefaultCellStyle = dgvStyle3
        '
        'frmManagePassengers
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(25, 30, 28)
        Me.ClientSize = New System.Drawing.Size(990, 580)
        Me.Controls.Add(Me.grpPassengerGrid)
        Me.Controls.Add(Me.cmdClose)
        Me.Controls.Add(Me.cmdUpdate)
        Me.Controls.Add(Me.grpPassengerInput)
        Me.Controls.Add(Me.lblTitle)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "frmManagePassengers"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ambatubus - Manage Passengers"
        Me.grpPassengerInput.ResumeLayout(False)
        Me.grpPassengerInput.PerformLayout()
        Me.grpPassengerGrid.ResumeLayout(False)
        Me.grpPassengerGrid.PerformLayout()
        CType(Me.dgvPassengers, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblTitle As System.Windows.Forms.Label
    Friend WithEvents grpPassengerInput As System.Windows.Forms.GroupBox
    Friend WithEvents lblPassengerId As System.Windows.Forms.Label
    Friend WithEvents txtPassengerId As System.Windows.Forms.TextBox
    Friend WithEvents lblFullName As System.Windows.Forms.Label
    Friend WithEvents txtFullName As System.Windows.Forms.TextBox
    Friend WithEvents lblPhone As System.Windows.Forms.Label
    Friend WithEvents txtPhone As System.Windows.Forms.TextBox
    Friend WithEvents chkIsBlocked As System.Windows.Forms.CheckBox
    Friend WithEvents cmdUpdate As System.Windows.Forms.Button
    Friend WithEvents cmdClose As System.Windows.Forms.Button
    Friend WithEvents grpPassengerGrid As System.Windows.Forms.GroupBox
    Friend WithEvents lblSearch As System.Windows.Forms.Label
    Friend WithEvents txtSearchName As System.Windows.Forms.TextBox
    Friend WithEvents dgvPassengers As System.Windows.Forms.DataGridView
End Class
