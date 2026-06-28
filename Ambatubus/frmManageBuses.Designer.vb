<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmManageBuses
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
        Me.dgvBuses = New System.Windows.Forms.DataGridView()
        Me.grpBusDetails = New System.Windows.Forms.GroupBox()
        Me.lblBusId = New System.Windows.Forms.Label()
        Me.txtBusId = New System.Windows.Forms.TextBox()
        Me.lblBusName = New System.Windows.Forms.Label()
        Me.txtBusName = New System.Windows.Forms.TextBox()
        Me.lblLayoutType = New System.Windows.Forms.Label()
        Me.cboLayoutType = New System.Windows.Forms.ComboBox()
        Me.lblCapacity = New System.Windows.Forms.Label()
        Me.txtCapacity = New System.Windows.Forms.TextBox()
        Me.cmdAdd = New System.Windows.Forms.Button()
        Me.cmdUpdate = New System.Windows.Forms.Button()
        Me.cmdDelete = New System.Windows.Forms.Button()
        Me.cmdClose = New System.Windows.Forms.Button()
        CType(Me.dgvBuses, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpBusDetails.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblTitle
        '
        Me.lblTitle.AutoSize = True
        Me.lblTitle.Font = New System.Drawing.Font("Segoe UI", 16.0!, System.Drawing.FontStyle.Bold)
        Me.lblTitle.ForeColor = System.Drawing.Color.White
        Me.lblTitle.Location = New System.Drawing.Point(20, 20)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(262, 30)
        Me.lblTitle.Text = "Manage Bus Fleet"
        '
        'dgvBuses
        '
        Me.dgvBuses.AllowUserToAddRows = False
        Me.dgvBuses.AllowUserToDeleteRows = False
        Me.dgvBuses.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvBuses.BackgroundColor = System.Drawing.Color.FromArgb(35, 42, 38)
        Me.dgvBuses.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvBuses.Location = New System.Drawing.Point(25, 65)
        Me.dgvBuses.Name = "dgvBuses"
        Me.dgvBuses.ReadOnly = True
        Me.dgvBuses.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvBuses.Size = New System.Drawing.Size(730, 200)
        '
        'grpBusDetails
        '
        Me.grpBusDetails.Controls.Add(Me.lblBusId)
        Me.grpBusDetails.Controls.Add(Me.txtBusId)
        Me.grpBusDetails.Controls.Add(Me.lblBusName)
        Me.grpBusDetails.Controls.Add(Me.txtBusName)
        Me.grpBusDetails.Controls.Add(Me.lblLayoutType)
        Me.grpBusDetails.Controls.Add(Me.cboLayoutType)
        Me.grpBusDetails.Controls.Add(Me.lblCapacity)
        Me.grpBusDetails.Controls.Add(Me.txtCapacity)
        Me.grpBusDetails.ForeColor = System.Drawing.Color.White
        Me.grpBusDetails.Location = New System.Drawing.Point(25, 280)
        Me.grpBusDetails.Name = "grpBusDetails"
        Me.grpBusDetails.Size = New System.Drawing.Size(730, 110)
        Me.grpBusDetails.Text = "Bus Details"
        '
        'lblBusId
        '
        Me.lblBusId.AutoSize = True
        Me.lblBusId.Location = New System.Drawing.Point(20, 30)
        Me.lblBusId.Name = "lblBusId"
        Me.lblBusId.Size = New System.Drawing.Size(41, 15)
        Me.lblBusId.Text = "Bus ID"
        '
        'txtBusId
        '
        Me.txtBusId.Location = New System.Drawing.Point(20, 50)
        Me.txtBusId.Name = "txtBusId"
        Me.txtBusId.ReadOnly = True
        Me.txtBusId.Size = New System.Drawing.Size(80, 23)
        '
        'lblBusName
        '
        Me.lblBusName.AutoSize = True
        Me.lblBusName.Location = New System.Drawing.Point(120, 30)
        Me.lblBusName.Name = "lblBusName"
        Me.lblBusName.Size = New System.Drawing.Size(62, 15)
        Me.lblBusName.Text = "Bus Name"
        '
        'txtBusName
        '
        Me.txtBusName.Location = New System.Drawing.Point(120, 50)
        Me.txtBusName.Name = "txtBusName"
        Me.txtBusName.Size = New System.Drawing.Size(250, 23)
        '
        'lblLayoutType
        '
        Me.lblLayoutType.AutoSize = True
        Me.lblLayoutType.Location = New System.Drawing.Point(390, 30)
        Me.lblLayoutType.Name = "lblLayoutType"
        Me.lblLayoutType.Size = New System.Drawing.Size(73, 15)
        Me.lblLayoutType.Text = "Layout Type"
        '
        'cboLayoutType
        '
        Me.cboLayoutType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboLayoutType.FormattingEnabled = True
        Me.cboLayoutType.Items.AddRange(New Object() {"2-2", "1-1-1", "2-1-2"})
        Me.cboLayoutType.Location = New System.Drawing.Point(390, 50)
        Me.cboLayoutType.Name = "cboLayoutType"
        Me.cboLayoutType.Size = New System.Drawing.Size(150, 23)
        '
        'lblCapacity
        '
        Me.lblCapacity.AutoSize = True
        Me.lblCapacity.Location = New System.Drawing.Point(560, 30)
        Me.lblCapacity.Name = "lblCapacity"
        Me.lblCapacity.Size = New System.Drawing.Size(53, 15)
        Me.lblCapacity.Text = "Capacity"
        '
        'txtCapacity
        '
        Me.txtCapacity.Location = New System.Drawing.Point(560, 50)
        Me.txtCapacity.Name = "txtCapacity"
        Me.txtCapacity.Size = New System.Drawing.Size(100, 23)
        '
        'cmdAdd
        '
        Me.cmdAdd.BackColor = System.Drawing.Color.FromArgb(20, 150, 85)
        Me.cmdAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdAdd.ForeColor = System.Drawing.Color.White
        Me.cmdAdd.Location = New System.Drawing.Point(25, 410)
        Me.cmdAdd.Name = "cmdAdd"
        Me.cmdAdd.Size = New System.Drawing.Size(100, 35)
        Me.cmdAdd.Text = "Add Bus"
        Me.cmdAdd.UseVisualStyleBackColor = False
        '
        'cmdUpdate
        '
        Me.cmdUpdate.BackColor = System.Drawing.Color.FromArgb(65, 105, 225)
        Me.cmdUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdUpdate.ForeColor = System.Drawing.Color.White
        Me.cmdUpdate.Location = New System.Drawing.Point(135, 410)
        Me.cmdUpdate.Name = "cmdUpdate"
        Me.cmdUpdate.Size = New System.Drawing.Size(100, 35)
        Me.cmdUpdate.Text = "Update Bus"
        Me.cmdUpdate.UseVisualStyleBackColor = False
        '
        'cmdDelete
        '
        Me.cmdDelete.BackColor = System.Drawing.Color.FromArgb(220, 53, 69)
        Me.cmdDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdDelete.ForeColor = System.Drawing.Color.White
        Me.cmdDelete.Location = New System.Drawing.Point(245, 410)
        Me.cmdDelete.Name = "cmdDelete"
        Me.cmdDelete.Size = New System.Drawing.Size(100, 35)
        Me.cmdDelete.Text = "Delete Bus"
        Me.cmdDelete.UseVisualStyleBackColor = False
        '
        'cmdClose
        '
        Me.cmdClose.BackColor = System.Drawing.Color.FromArgb(65, 75, 70)
        Me.cmdClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdClose.ForeColor = System.Drawing.Color.White
        Me.cmdClose.Location = New System.Drawing.Point(655, 410)
        Me.cmdClose.Name = "cmdClose"
        Me.cmdClose.Size = New System.Drawing.Size(100, 35)
        Me.cmdClose.Text = "Close"
        Me.cmdClose.UseVisualStyleBackColor = False
        '
        'frmManageBuses
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(25, 30, 28)
        Me.ClientSize = New System.Drawing.Size(780, 470)
        Me.Controls.Add(Me.cmdClose)
        Me.Controls.Add(Me.cmdDelete)
        Me.Controls.Add(Me.cmdUpdate)
        Me.Controls.Add(Me.cmdAdd)
        Me.Controls.Add(Me.grpBusDetails)
        Me.Controls.Add(Me.dgvBuses)
        Me.Controls.Add(Me.lblTitle)
        Me.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Name = "frmManageBuses"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Ambatubus - Manage Bus Fleet"
        CType(Me.dgvBuses, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpBusDetails.ResumeLayout(False)
        Me.grpBusDetails.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblTitle As System.Windows.Forms.Label
    Friend WithEvents dgvBuses As System.Windows.Forms.DataGridView
    Friend WithEvents grpBusDetails As System.Windows.Forms.GroupBox
    Friend WithEvents lblBusId As System.Windows.Forms.Label
    Friend WithEvents txtBusId As System.Windows.Forms.TextBox
    Friend WithEvents lblBusName As System.Windows.Forms.Label
    Friend WithEvents txtBusName As System.Windows.Forms.TextBox
    Friend WithEvents lblLayoutType As System.Windows.Forms.Label
    Friend WithEvents cboLayoutType As System.Windows.Forms.ComboBox
    Friend WithEvents lblCapacity As System.Windows.Forms.Label
    Friend WithEvents txtCapacity As System.Windows.Forms.TextBox
    Friend WithEvents cmdAdd As System.Windows.Forms.Button
    Friend WithEvents cmdUpdate As System.Windows.Forms.Button
    Friend WithEvents cmdDelete As System.Windows.Forms.Button
    Friend WithEvents cmdClose As System.Windows.Forms.Button
End Class
