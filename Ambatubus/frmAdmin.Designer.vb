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
        Me.lblFrom = New System.Windows.Forms.Label()
        Me.cboFrom = New System.Windows.Forms.ComboBox()
        Me.lblTo = New System.Windows.Forms.Label()
        Me.cboTo = New System.Windows.Forms.ComboBox()
        Me.lblDeparture = New System.Windows.Forms.Label()
        Me.dtpDeparture = New System.Windows.Forms.DateTimePicker()
        Me.lblPriceLabel = New System.Windows.Forms.Label()
        Me.txtPrice = New System.Windows.Forms.TextBox()
        Me.lblBus = New System.Windows.Forms.Label()
        Me.cboBus = New System.Windows.Forms.ComboBox()
        Me.cmdAdd = New System.Windows.Forms.Button()
        Me.cmdUpdate = New System.Windows.Forms.Button()
        Me.cmdDelete = New System.Windows.Forms.Button()
        Me.cmdClose = New System.Windows.Forms.Button()
        Me.grpAdminGrid = New System.Windows.Forms.GroupBox()
        Me.lblSearch = New System.Windows.Forms.Label()
        Me.txtSearchRoute = New System.Windows.Forms.TextBox()
        Me.dgvSchedules = New System.Windows.Forms.DataGridView()
        Me.grpAdminInput.SuspendLayout()
        Me.grpAdminGrid.SuspendLayout()
        CType(Me.dgvSchedules, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblTitle
        '
        'lblTitle
        '
        Me.lblTitle.AutoSize = True
        Me.lblTitle.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Bold)
        Me.lblTitle.ForeColor = System.Drawing.Color.White
        Me.lblTitle.Location = New System.Drawing.Point(20, 20)
        Me.lblTitle.Size = New System.Drawing.Size(326, 32)
        Me.lblTitle.Text = "Bus Schedule Management"
        '
        'grpAdminInput
        '
        Me.grpAdminInput.Controls.Add(Me.lblTripId)
        Me.grpAdminInput.Controls.Add(Me.txtTripId)
        Me.grpAdminInput.Controls.Add(Me.lblFrom)
        Me.grpAdminInput.Controls.Add(Me.cboFrom)
        Me.grpAdminInput.Controls.Add(Me.lblTo)
        Me.grpAdminInput.Controls.Add(Me.cboTo)
        Me.grpAdminInput.Controls.Add(Me.lblDeparture)
        Me.grpAdminInput.Controls.Add(Me.dtpDeparture)
        Me.grpAdminInput.Controls.Add(Me.lblPriceLabel)
        Me.grpAdminInput.Controls.Add(Me.txtPrice)
        Me.grpAdminInput.Controls.Add(Me.lblBus)
        Me.grpAdminInput.Controls.Add(Me.cboBus)
        Me.grpAdminInput.Font = New System.Drawing.Font("Segoe UI Semibold", 9.5!, System.Drawing.FontStyle.Bold)
        Me.grpAdminInput.ForeColor = System.Drawing.Color.FromArgb(100, 120, 110)
        Me.grpAdminInput.Location = New System.Drawing.Point(20, 65)
        Me.grpAdminInput.Size = New System.Drawing.Size(320, 395)
        Me.grpAdminInput.Text = "Schedule Details"
        '
        'lblTripId
        '
        Me.lblTripId.AutoSize = True
        Me.lblTripId.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.lblTripId.ForeColor = System.Drawing.Color.FromArgb(140, 160, 150)
        Me.lblTripId.Location = New System.Drawing.Point(15, 30)
        Me.lblTripId.Text = "Trip ID"
        '
        'txtTripId
        '
        Me.txtTripId.BackColor = System.Drawing.Color.FromArgb(35, 42, 38)
        Me.txtTripId.ForeColor = System.Drawing.Color.FromArgb(220, 235, 225)
        Me.txtTripId.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtTripId.Enabled = False
        Me.txtTripId.Location = New System.Drawing.Point(15, 50)
        Me.txtTripId.ReadOnly = True
        Me.txtTripId.Size = New System.Drawing.Size(290, 24)
        '
        'lblFrom
        '
        Me.lblFrom.AutoSize = True
        Me.lblFrom.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.lblFrom.ForeColor = System.Drawing.Color.FromArgb(140, 160, 150)
        Me.lblFrom.Location = New System.Drawing.Point(15, 85)
        Me.lblFrom.Text = "From (Origin)"
        '
        'cboFrom
        '
        Me.cboFrom.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboFrom.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cboFrom.BackColor = System.Drawing.Color.FromArgb(35, 42, 38)
        Me.cboFrom.ForeColor = System.Drawing.Color.FromArgb(220, 235, 225)
        Me.cboFrom.Location = New System.Drawing.Point(15, 105)
        Me.cboFrom.Size = New System.Drawing.Size(130, 24)
        '
        'lblTo
        '
        Me.lblTo.AutoSize = True
        Me.lblTo.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.lblTo.ForeColor = System.Drawing.Color.FromArgb(140, 160, 150)
        Me.lblTo.Location = New System.Drawing.Point(165, 85)
        Me.lblTo.Text = "To (Destination)"
        '
        'cboTo
        '
        Me.cboTo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboTo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cboTo.BackColor = System.Drawing.Color.FromArgb(35, 42, 38)
        Me.cboTo.ForeColor = System.Drawing.Color.FromArgb(220, 235, 225)
        Me.cboTo.Location = New System.Drawing.Point(165, 105)
        Me.cboTo.Size = New System.Drawing.Size(140, 24)
        '
        'lblDeparture
        '
        Me.lblDeparture.AutoSize = True
        Me.lblDeparture.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.lblDeparture.ForeColor = System.Drawing.Color.FromArgb(140, 160, 150)
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
        Me.lblPriceLabel.ForeColor = System.Drawing.Color.FromArgb(140, 160, 150)
        Me.lblPriceLabel.Location = New System.Drawing.Point(15, 195)
        Me.lblPriceLabel.Text = "Price (RM)"
        '
        'txtPrice
        '
        Me.txtPrice.BackColor = System.Drawing.Color.FromArgb(35, 42, 38)
        Me.txtPrice.ForeColor = System.Drawing.Color.FromArgb(220, 235, 225)
        Me.txtPrice.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtPrice.Location = New System.Drawing.Point(15, 215)
        Me.txtPrice.Size = New System.Drawing.Size(290, 24)
        '
        'lblBus
        '
        Me.lblBus.AutoSize = True
        Me.lblBus.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.lblBus.ForeColor = System.Drawing.Color.FromArgb(140, 160, 150)
        Me.lblBus.Location = New System.Drawing.Point(15, 250)
        Me.lblBus.Text = "Assigned Bus"
        '
        'cboBus
        '
        Me.cboBus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboBus.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cboBus.BackColor = System.Drawing.Color.FromArgb(35, 42, 38)
        Me.cboBus.ForeColor = System.Drawing.Color.FromArgb(220, 235, 225)
        Me.cboBus.Location = New System.Drawing.Point(15, 270)
        Me.cboBus.Size = New System.Drawing.Size(290, 24)
        '
        'cmdAdd
        '
        Me.cmdAdd.BackColor = System.Drawing.Color.FromArgb(20, 150, 85)
        Me.cmdAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdAdd.FlatAppearance.BorderSize = 0
        Me.cmdAdd.Font = New System.Drawing.Font("Segoe UI", 9.5!, System.Drawing.FontStyle.Bold)
        Me.cmdAdd.ForeColor = System.Drawing.Color.White
        Me.cmdAdd.Location = New System.Drawing.Point(20, 480)
        Me.cmdAdd.Size = New System.Drawing.Size(145, 35)
        Me.cmdAdd.Text = "➕ Add Trip"
        Me.cmdAdd.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.cmdAdd.UseVisualStyleBackColor = False
        '
        'cmdUpdate
        '
        Me.cmdUpdate.BackColor = System.Drawing.Color.FromArgb(30, 130, 190)
        Me.cmdUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdUpdate.FlatAppearance.BorderSize = 0
        Me.cmdUpdate.Font = New System.Drawing.Font("Segoe UI", 9.5!, System.Drawing.FontStyle.Bold)
        Me.cmdUpdate.ForeColor = System.Drawing.Color.White
        Me.cmdUpdate.Location = New System.Drawing.Point(195, 480)
        Me.cmdUpdate.Size = New System.Drawing.Size(145, 35)
        Me.cmdUpdate.Text = "✏️ Update Trip"
        Me.cmdUpdate.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.cmdUpdate.UseVisualStyleBackColor = False
        '
        'cmdDelete
        '
        Me.cmdDelete.BackColor = System.Drawing.Color.FromArgb(180, 50, 50)
        Me.cmdDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdDelete.FlatAppearance.BorderSize = 0
        Me.cmdDelete.Font = New System.Drawing.Font("Segoe UI", 9.5!, System.Drawing.FontStyle.Bold)
        Me.cmdDelete.ForeColor = System.Drawing.Color.White
        Me.cmdDelete.Location = New System.Drawing.Point(20, 525)
        Me.cmdDelete.Size = New System.Drawing.Size(145, 35)
        Me.cmdDelete.Text = "🗑️ Delete Trip"
        Me.cmdDelete.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.cmdDelete.UseVisualStyleBackColor = False
        '
        'cmdClose
        '
        Me.cmdClose.BackColor = System.Drawing.Color.FromArgb(65, 75, 70)
        Me.cmdClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdClose.FlatAppearance.BorderSize = 0
        Me.cmdClose.Font = New System.Drawing.Font("Segoe UI", 9.5!, System.Drawing.FontStyle.Bold)
        Me.cmdClose.ForeColor = System.Drawing.Color.White
        Me.cmdClose.Location = New System.Drawing.Point(195, 525)
        Me.cmdClose.Size = New System.Drawing.Size(145, 35)
        Me.cmdClose.Text = "⬅️ Back to Menu"
        Me.cmdClose.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.cmdClose.UseVisualStyleBackColor = False
        '
        'grpAdminGrid
        '
        Me.grpAdminGrid.Controls.Add(Me.lblSearch)
        Me.grpAdminGrid.Controls.Add(Me.txtSearchRoute)
        Me.grpAdminGrid.Controls.Add(Me.dgvSchedules)
        Me.grpAdminGrid.Font = New System.Drawing.Font("Segoe UI Semibold", 9.5!, System.Drawing.FontStyle.Bold)
        Me.grpAdminGrid.ForeColor = System.Drawing.Color.FromArgb(100, 120, 110)
        Me.grpAdminGrid.Location = New System.Drawing.Point(360, 65)
        Me.grpAdminGrid.Size = New System.Drawing.Size(610, 495)
        Me.grpAdminGrid.Text = "Current Bus Trips & Schedules"
        Me.grpAdminGrid.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) Or System.Windows.Forms.AnchorStyles.Left) Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        '
        'lblSearch
        '
        Me.lblSearch.AutoSize = True
        Me.lblSearch.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.lblSearch.ForeColor = System.Drawing.Color.FromArgb(220, 235, 225)
        Me.lblSearch.Location = New System.Drawing.Point(15, 25)
        Me.lblSearch.Text = "Search Route:"
        '
        'txtSearchRoute
        '
        Me.txtSearchRoute.BackColor = System.Drawing.Color.FromArgb(35, 42, 38)
        Me.txtSearchRoute.ForeColor = System.Drawing.Color.FromArgb(220, 235, 225)
        Me.txtSearchRoute.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtSearchRoute.Font = New System.Drawing.Font("Segoe UI", 9.5!)
        Me.txtSearchRoute.Location = New System.Drawing.Point(110, 22)
        Me.txtSearchRoute.Size = New System.Drawing.Size(250, 23)
        '
        'dgvSchedules
        '
        Me.dgvSchedules.AllowUserToAddRows = False
        Me.dgvSchedules.AllowUserToDeleteRows = False
        Me.dgvSchedules.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvSchedules.BackgroundColor = System.Drawing.Color.FromArgb(35, 42, 38)
        Me.dgvSchedules.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgvSchedules.GridColor = System.Drawing.Color.FromArgb(50, 60, 55)
        Me.dgvSchedules.Location = New System.Drawing.Point(15, 55)
        Me.dgvSchedules.MultiSelect = False
        Me.dgvSchedules.ReadOnly = True
        Me.dgvSchedules.RowHeadersVisible = False
        Me.dgvSchedules.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvSchedules.Size = New System.Drawing.Size(580, 425)
        Me.dgvSchedules.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) Or System.Windows.Forms.AnchorStyles.Left) Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Dim dgvSchedStyle1 As New System.Windows.Forms.DataGridViewCellStyle()
        dgvSchedStyle1.BackColor = System.Drawing.Color.FromArgb(20, 110, 60)
        dgvSchedStyle1.ForeColor = System.Drawing.Color.White
        dgvSchedStyle1.Font = New System.Drawing.Font("Segoe UI Semibold", 9.5!, System.Drawing.FontStyle.Bold)
        dgvSchedStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(20, 110, 60)
        dgvSchedStyle1.SelectionForeColor = System.Drawing.Color.White
        Me.dgvSchedules.ColumnHeadersDefaultCellStyle = dgvSchedStyle1
        Me.dgvSchedules.EnableHeadersVisualStyles = False
        Dim dgvSchedStyle2 As New System.Windows.Forms.DataGridViewCellStyle()
        dgvSchedStyle2.BackColor = System.Drawing.Color.FromArgb(35, 42, 38)
        dgvSchedStyle2.ForeColor = System.Drawing.Color.FromArgb(220, 235, 225)
        dgvSchedStyle2.Font = New System.Drawing.Font("Segoe UI", 9.5!)
        dgvSchedStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(25, 130, 75)
        dgvSchedStyle2.SelectionForeColor = System.Drawing.Color.White
        Me.dgvSchedules.DefaultCellStyle = dgvSchedStyle2
        Dim dgvSchedStyle3 As New System.Windows.Forms.DataGridViewCellStyle()
        dgvSchedStyle3.BackColor = System.Drawing.Color.FromArgb(30, 36, 33)
        dgvSchedStyle3.ForeColor = System.Drawing.Color.FromArgb(220, 235, 225)
        dgvSchedStyle3.Font = New System.Drawing.Font("Segoe UI", 9.5!)
        dgvSchedStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(25, 130, 75)
        dgvSchedStyle3.SelectionForeColor = System.Drawing.Color.White
        Me.dgvSchedules.AlternatingRowsDefaultCellStyle = dgvSchedStyle3
        '
        'frmAdmin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(25, 30, 28)
        Me.ClientSize = New System.Drawing.Size(990, 580)
        Me.Controls.Add(Me.grpAdminGrid)
        Me.Controls.Add(Me.cmdClose)
        Me.Controls.Add(Me.cmdDelete)
        Me.Controls.Add(Me.cmdUpdate)
        Me.Controls.Add(Me.cmdAdd)
        Me.Controls.Add(Me.grpAdminInput)
        Me.Controls.Add(Me.lblTitle)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Sizable
        Me.MaximizeBox = True
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
    Friend WithEvents lblFrom As System.Windows.Forms.Label
    Friend WithEvents cboFrom As System.Windows.Forms.ComboBox
    Friend WithEvents lblTo As System.Windows.Forms.Label
    Friend WithEvents cboTo As System.Windows.Forms.ComboBox
    Friend WithEvents lblDeparture As System.Windows.Forms.Label
    Friend WithEvents dtpDeparture As System.Windows.Forms.DateTimePicker
    Friend WithEvents lblPriceLabel As System.Windows.Forms.Label
    Friend WithEvents txtPrice As System.Windows.Forms.TextBox
    Friend WithEvents lblBus As System.Windows.Forms.Label
    Friend WithEvents cboBus As System.Windows.Forms.ComboBox
    Friend WithEvents cmdAdd As System.Windows.Forms.Button
    Friend WithEvents cmdUpdate As System.Windows.Forms.Button
    Friend WithEvents cmdDelete As System.Windows.Forms.Button
    Friend WithEvents cmdClose As System.Windows.Forms.Button
    Friend WithEvents lblSearch As System.Windows.Forms.Label
    Friend WithEvents txtSearchRoute As System.Windows.Forms.TextBox
    Friend WithEvents grpAdminGrid As System.Windows.Forms.GroupBox
    Friend WithEvents dgvSchedules As System.Windows.Forms.DataGridView
End Class