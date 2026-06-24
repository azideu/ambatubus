<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmAdmin
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
        Me.grpAdminInput = New System.Windows.Forms.GroupBox()
        Me.lblTripId = New System.Windows.Forms.Label()
        Me.txtTripId = New System.Windows.Forms.TextBox()
        Me.lblRoute = New System.Windows.Forms.Label()
        Me.txtRoute = New System.Windows.Forms.TextBox()
        Me.lblDeparture = New System.Windows.Forms.Label()
        Me.dtpDeparture = New System.Windows.Forms.DateTimePicker()
        Me.lblPriceLabel = New System.Windows.Forms.Label()
        Me.txtPrice = New System.Windows.Forms.TextBox()
        Me.lblSeatCapacity = New System.Windows.Forms.Label()
        Me.txtSeatCapacity = New System.Windows.Forms.TextBox()
        Me.cmdAdd = New System.Windows.Forms.Button()
        Me.cmdUpdate = New System.Windows.Forms.Button()
        Me.cmdDelete = New System.Windows.Forms.Button()
        Me.cmdClose = New System.Windows.Forms.Button()
        Me.grpAdminGrid = New System.Windows.Forms.GroupBox()
        Me.dgvSchedules = New System.Windows.Forms.DataGridView()
        Me.grpAdminInput.SuspendLayout()
        Me.grpAdminGrid.SuspendLayout()
        CType(Me.dgvSchedules, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblTitle
        '
        Me.lblTitle.AutoSize = True
        Me.lblTitle.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Bold)
        Me.lblTitle.ForeColor = System.Drawing.Color.FromArgb(20, 80, 40)
        Me.lblTitle.Location = New System.Drawing.Point(20, 20)
        Me.lblTitle.Size = New System.Drawing.Size(326, 32)
        Me.lblTitle.Text = "Bus Schedule Management"
        '
        'grpAdminInput
        '
        Me.grpAdminInput.Controls.Add(Me.lblTripId)
        Me.grpAdminInput.Controls.Add(Me.txtTripId)
        Me.grpAdminInput.Controls.Add(Me.lblRoute)
        Me.grpAdminInput.Controls.Add(Me.txtRoute)
        Me.grpAdminInput.Controls.Add(Me.lblDeparture)
        Me.grpAdminInput.Controls.Add(Me.dtpDeparture)
        Me.grpAdminInput.Controls.Add(Me.lblPriceLabel)
        Me.grpAdminInput.Controls.Add(Me.txtPrice)
        Me.grpAdminInput.Controls.Add(Me.lblSeatCapacity)
        Me.grpAdminInput.Controls.Add(Me.txtSeatCapacity)
        Me.grpAdminInput.Font = New System.Drawing.Font("Segoe UI Semibold", 9.5!, System.Drawing.FontStyle.Bold)
        Me.grpAdminInput.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.grpAdminInput.Location = New System.Drawing.Point(20, 65)
        Me.grpAdminInput.Size = New System.Drawing.Size(320, 395)
        Me.grpAdminInput.Text = "Schedule Details"
        '
        'lblTripId
        '
        Me.lblTripId.AutoSize = True
        Me.lblTripId.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.lblTripId.Location = New System.Drawing.Point(15, 30)
        Me.lblTripId.Text = "Trip ID"
        '
        'txtTripId
        '
        Me.txtTripId.BackColor = System.Drawing.Color.LightGray
        Me.txtTripId.Enabled = False
        Me.txtTripId.Location = New System.Drawing.Point(15, 50)
        Me.txtTripId.ReadOnly = True
        Me.txtTripId.Size = New System.Drawing.Size(290, 24)
        '
        'lblRoute
        '
        Me.lblRoute.AutoSize = True
        Me.lblRoute.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.lblRoute.Location = New System.Drawing.Point(15, 85)
        Me.lblRoute.Text = "Route Description"
        '
        'txtRoute
        '
        Me.txtRoute.Location = New System.Drawing.Point(15, 105)
        Me.txtRoute.Size = New System.Drawing.Size(290, 24)
        '
        'lblDeparture
        '
        Me.lblDeparture.AutoSize = True
        Me.lblDeparture.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.lblDeparture.Location = New System.Drawing.Point(15, 140)
        Me.lblDeparture.Text = "Departure Date & Time"
        '
        'dtpDeparture
        '
        Me.dtpDeparture.CustomFormat = "dd/MM/yyyy HH:mm"
        Me.dtpDeparture.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpDeparture.Location = New System.Drawing.Point(15, 160)
        Me.dtpDeparture.Size = New System.Drawing.Size(290, 24)
        '
        'lblPriceLabel
        '
        Me.lblPriceLabel.AutoSize = True
        Me.lblPriceLabel.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.lblPriceLabel.Location = New System.Drawing.Point(15, 195)
        Me.lblPriceLabel.Text = "Price (RM)"
        '
        'txtPrice
        '
        Me.txtPrice.Location = New System.Drawing.Point(15, 215)
        Me.txtPrice.Size = New System.Drawing.Size(290, 24)
        '
        'lblSeatCapacity
        '
        Me.lblSeatCapacity.AutoSize = True
        Me.lblSeatCapacity.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.lblSeatCapacity.Location = New System.Drawing.Point(15, 250)
        Me.lblSeatCapacity.Text = "Seat Capacity"
        '
        'txtSeatCapacity
        '
        Me.txtSeatCapacity.Location = New System.Drawing.Point(15, 270)
        Me.txtSeatCapacity.Size = New System.Drawing.Size(290, 24)
        '
        'cmdAdd
        '
        Me.cmdAdd.BackColor = System.Drawing.Color.FromArgb(20, 120, 60)
        Me.cmdAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdAdd.Font = New System.Drawing.Font("Segoe UI", 9.5!, System.Drawing.FontStyle.Bold)
        Me.cmdAdd.ForeColor = System.Drawing.Color.White
        Me.cmdAdd.Location = New System.Drawing.Point(20, 480)
        Me.cmdAdd.Size = New System.Drawing.Size(145, 35)
        Me.cmdAdd.Text = "➕ Add Trip"
        Me.cmdAdd.UseVisualStyleBackColor = False
        '
        'cmdUpdate
        '
        Me.cmdUpdate.BackColor = System.Drawing.Color.FromArgb(0, 120, 200)
        Me.cmdUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdUpdate.Font = New System.Drawing.Font("Segoe UI", 9.5!, System.Drawing.FontStyle.Bold)
        Me.cmdUpdate.ForeColor = System.Drawing.Color.White
        Me.cmdUpdate.Location = New System.Drawing.Point(195, 480)
        Me.cmdUpdate.Size = New System.Drawing.Size(145, 35)
        Me.cmdUpdate.Text = "✏️ Update Trip"
        Me.cmdUpdate.UseVisualStyleBackColor = False
        '
        'cmdDelete
        '
        Me.cmdDelete.BackColor = System.Drawing.Color.FromArgb(200, 50, 50)
        Me.cmdDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdDelete.Font = New System.Drawing.Font("Segoe UI", 9.5!, System.Drawing.FontStyle.Bold)
        Me.cmdDelete.ForeColor = System.Drawing.Color.White
        Me.cmdDelete.Location = New System.Drawing.Point(20, 525)
        Me.cmdDelete.Size = New System.Drawing.Size(145, 35)
        Me.cmdDelete.Text = "🗑️ Delete Trip"
        Me.cmdDelete.UseVisualStyleBackColor = False
        '
        'cmdClose
        '
        Me.cmdClose.BackColor = System.Drawing.Color.FromArgb(120, 120, 120)
        Me.cmdClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdClose.Font = New System.Drawing.Font("Segoe UI", 9.5!, System.Drawing.FontStyle.Bold)
        Me.cmdClose.ForeColor = System.Drawing.Color.White
        Me.cmdClose.Location = New System.Drawing.Point(195, 525)
        Me.cmdClose.Size = New System.Drawing.Size(145, 35)
        Me.cmdClose.Text = "⬅️ Back to Menu"
        Me.cmdClose.UseVisualStyleBackColor = False
        '
        'grpAdminGrid
        '
        Me.grpAdminGrid.Controls.Add(Me.dgvSchedules)
        Me.grpAdminGrid.Font = New System.Drawing.Font("Segoe UI Semibold", 9.5!, System.Drawing.FontStyle.Bold)
        Me.grpAdminGrid.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.grpAdminGrid.Location = New System.Drawing.Point(360, 65)
        Me.grpAdminGrid.Size = New System.Drawing.Size(610, 495)
        Me.grpAdminGrid.Text = "Current Bus Trips & Schedules"
        '
        'dgvSchedules
        '
        Me.dgvSchedules.AllowUserToAddRows = False
        Me.dgvSchedules.AllowUserToDeleteRows = False
        Me.dgvSchedules.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvSchedules.BackgroundColor = System.Drawing.Color.White
        Me.dgvSchedules.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgvSchedules.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvSchedules.Location = New System.Drawing.Point(15, 25)
        Me.dgvSchedules.MultiSelect = False
        Me.dgvSchedules.ReadOnly = True
        Me.dgvSchedules.RowHeadersVisible = False
        Me.dgvSchedules.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvSchedules.Size = New System.Drawing.Size(580, 455)
        '
        'frmAdmin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(245, 248, 245)
        Me.ClientSize = New System.Drawing.Size(990, 580)
        Me.Controls.Add(Me.grpAdminGrid)
        Me.Controls.Add(Me.cmdClose)
        Me.Controls.Add(Me.cmdDelete)
        Me.Controls.Add(Me.cmdUpdate)
        Me.Controls.Add(Me.cmdAdd)
        Me.Controls.Add(Me.grpAdminInput)
        Me.Controls.Add(Me.lblTitle)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "frmAdmin"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ambatubus - Bus Administrator"
        Me.grpAdminInput.ResumeLayout(False)
        Me.grpAdminInput.PerformLayout()
        Me.grpAdminGrid.ResumeLayout(False)
        CType(Me.dgvSchedules, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblTitle As System.Windows.Forms.Label
    Friend WithEvents grpAdminInput As System.Windows.Forms.GroupBox
    Friend WithEvents lblTripId As System.Windows.Forms.Label
    Friend WithEvents txtTripId As System.Windows.Forms.TextBox
    Friend WithEvents lblRoute As System.Windows.Forms.Label
    Friend WithEvents txtRoute As System.Windows.Forms.TextBox
    Friend WithEvents lblDeparture As System.Windows.Forms.Label
    Friend WithEvents dtpDeparture As System.Windows.Forms.DateTimePicker
    Friend WithEvents lblPriceLabel As System.Windows.Forms.Label
    Friend WithEvents txtPrice As System.Windows.Forms.TextBox
    Friend WithEvents lblSeatCapacity As System.Windows.Forms.Label
    Friend WithEvents txtSeatCapacity As System.Windows.Forms.TextBox
    Friend WithEvents cmdAdd As System.Windows.Forms.Button
    Friend WithEvents cmdUpdate As System.Windows.Forms.Button
    Friend WithEvents cmdDelete As System.Windows.Forms.Button
    Friend WithEvents cmdClose As System.Windows.Forms.Button
    Friend WithEvents grpAdminGrid As System.Windows.Forms.GroupBox
    Friend WithEvents dgvSchedules As System.Windows.Forms.DataGridView
End Class