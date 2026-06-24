<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmBooking
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
        Me.grpBookingInput = New System.Windows.Forms.GroupBox()
        Me.lblTicketId = New System.Windows.Forms.Label()
        Me.txtTicketId = New System.Windows.Forms.TextBox()
        Me.lblPassengerName = New System.Windows.Forms.Label()
        Me.txtPassengerName = New System.Windows.Forms.TextBox()
        Me.lblPhone = New System.Windows.Forms.Label()
        Me.txtPhone = New System.Windows.Forms.TextBox()
        Me.lblDestination = New System.Windows.Forms.Label()
        Me.cboRoute = New System.Windows.Forms.ComboBox()
        Me.lblSeat = New System.Windows.Forms.Label()
        Me.cboSeat = New System.Windows.Forms.ComboBox()
        Me.lblPriceLabel = New System.Windows.Forms.Label()
        Me.lblPrice = New System.Windows.Forms.Label()
        Me.cmdBook = New System.Windows.Forms.Button()
        Me.cmdUpdate = New System.Windows.Forms.Button()
        Me.cmdDelete = New System.Windows.Forms.Button()
        Me.cmdClose = New System.Windows.Forms.Button()
        Me.grpBookingsGrid = New System.Windows.Forms.GroupBox()
        Me.dgvTickets = New System.Windows.Forms.DataGridView()
        Me.grpBookingInput.SuspendLayout()
        Me.grpBookingsGrid.SuspendLayout()
        CType(Me.dgvTickets, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblTitle
        '
        Me.lblTitle.AutoSize = True
        Me.lblTitle.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Bold)
        Me.lblTitle.ForeColor = System.Drawing.Color.FromArgb(20, 80, 40)
        Me.lblTitle.Location = New System.Drawing.Point(20, 20)
        Me.lblTitle.Size = New System.Drawing.Size(325, 32)
        Me.lblTitle.Text = "Ticket Booking & Operations"
        '
        'grpBookingInput
        '
        Me.grpBookingInput.Controls.Add(Me.lblTicketId)
        Me.grpBookingInput.Controls.Add(Me.txtTicketId)
        Me.grpBookingInput.Controls.Add(Me.lblPassengerName)
        Me.grpBookingInput.Controls.Add(Me.txtPassengerName)
        Me.grpBookingInput.Controls.Add(Me.lblPhone)
        Me.grpBookingInput.Controls.Add(Me.txtPhone)
        Me.grpBookingInput.Controls.Add(Me.lblDestination)
        Me.grpBookingInput.Controls.Add(Me.cboRoute)
        Me.grpBookingInput.Controls.Add(Me.lblSeat)
        Me.grpBookingInput.Controls.Add(Me.cboSeat)
        Me.grpBookingInput.Controls.Add(Me.lblPriceLabel)
        Me.grpBookingInput.Controls.Add(Me.lblPrice)
        Me.grpBookingInput.Font = New System.Drawing.Font("Segoe UI Semibold", 9.5!, System.Drawing.FontStyle.Bold)
        Me.grpBookingInput.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.grpBookingInput.Location = New System.Drawing.Point(20, 65)
        Me.grpBookingInput.Size = New System.Drawing.Size(320, 395)
        Me.grpBookingInput.Text = "Booking Information"
        '
        'lblTicketId
        '
        Me.lblTicketId.AutoSize = True
        Me.lblTicketId.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.lblTicketId.Location = New System.Drawing.Point(15, 30)
        Me.lblTicketId.Text = "Ticket ID"
        '
        'txtTicketId
        '
        Me.txtTicketId.BackColor = System.Drawing.Color.LightGray
        Me.txtTicketId.Enabled = False
        Me.txtTicketId.Location = New System.Drawing.Point(15, 50)
        Me.txtTicketId.ReadOnly = True
        Me.txtTicketId.Size = New System.Drawing.Size(290, 24)
        '
        'lblPassengerName
        '
        Me.lblPassengerName.AutoSize = True
        Me.lblPassengerName.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.lblPassengerName.Location = New System.Drawing.Point(15, 85)
        Me.lblPassengerName.Text = "Passenger Name"
        '
        'txtPassengerName
        '
        Me.txtPassengerName.Location = New System.Drawing.Point(15, 105)
        Me.txtPassengerName.Size = New System.Drawing.Size(290, 24)
        '
        'lblPhone
        '
        Me.lblPhone.AutoSize = True
        Me.lblPhone.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.lblPhone.Location = New System.Drawing.Point(15, 140)
        Me.lblPhone.Text = "Phone Number"
        '
        'txtPhone
        '
        Me.txtPhone.Location = New System.Drawing.Point(15, 160)
        Me.txtPhone.Size = New System.Drawing.Size(290, 24)
        '
        'lblDestination
        '
        Me.lblDestination.AutoSize = True
        Me.lblDestination.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.lblDestination.Location = New System.Drawing.Point(15, 195)
        Me.lblDestination.Text = "Select Trip & Schedule"
        '
        'cboRoute
        '
        Me.cboRoute.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboRoute.Location = New System.Drawing.Point(15, 215)
        Me.cboRoute.Size = New System.Drawing.Size(290, 25)
        '
        'lblSeat
        '
        Me.lblSeat.AutoSize = True
        Me.lblSeat.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.lblSeat.Location = New System.Drawing.Point(15, 250)
        Me.lblSeat.Text = "Select Seat No"
        '
        'cboSeat
        '
        Me.cboSeat.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboSeat.Location = New System.Drawing.Point(15, 270)
        Me.cboSeat.Size = New System.Drawing.Size(290, 25)
        '
        'lblPriceLabel
        '
        Me.lblPriceLabel.AutoSize = True
        Me.lblPriceLabel.Font = New System.Drawing.Font("Segoe UI Semibold", 10.0!, System.Drawing.FontStyle.Bold)
        Me.lblPriceLabel.Location = New System.Drawing.Point(15, 315)
        Me.lblPriceLabel.Text = "Ticket Price:"
        '
        'lblPrice
        '
        Me.lblPrice.AutoSize = True
        Me.lblPrice.Font = New System.Drawing.Font("Segoe UI", 20.0!, System.Drawing.FontStyle.Bold)
        Me.lblPrice.ForeColor = System.Drawing.Color.FromArgb(200, 80, 0)
        Me.lblPrice.Location = New System.Drawing.Point(15, 335)
        Me.lblPrice.Text = "RM 0.00"
        '
        'cmdBook
        '
        Me.cmdBook.BackColor = System.Drawing.Color.FromArgb(20, 120, 60)
        Me.cmdBook.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdBook.Font = New System.Drawing.Font("Segoe UI", 9.5!, System.Drawing.FontStyle.Bold)
        Me.cmdBook.ForeColor = System.Drawing.Color.White
        Me.cmdBook.Location = New System.Drawing.Point(20, 480)
        Me.cmdBook.Size = New System.Drawing.Size(145, 35)
        Me.cmdBook.Text = "➕ Book Seat"
        Me.cmdBook.UseVisualStyleBackColor = False
        '
        'cmdUpdate
        '
        Me.cmdUpdate.BackColor = System.Drawing.Color.FromArgb(0, 120, 200)
        Me.cmdUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdUpdate.Font = New System.Drawing.Font("Segoe UI", 9.5!, System.Drawing.FontStyle.Bold)
        Me.cmdUpdate.ForeColor = System.Drawing.Color.White
        Me.cmdUpdate.Location = New System.Drawing.Point(195, 480)
        Me.cmdUpdate.Size = New System.Drawing.Size(145, 35)
        Me.cmdUpdate.Text = "✏️ Update details"
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
        Me.cmdDelete.Text = "🗑️ Cancel Booking"
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
        'grpBookingsGrid
        '
        Me.grpBookingsGrid.Controls.Add(Me.dgvTickets)
        Me.grpBookingsGrid.Font = New System.Drawing.Font("Segoe UI Semibold", 9.5!, System.Drawing.FontStyle.Bold)
        Me.grpBookingsGrid.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.grpBookingsGrid.Location = New System.Drawing.Point(360, 65)
        Me.grpBookingsGrid.Size = New System.Drawing.Size(610, 495)
        Me.grpBookingsGrid.Text = "Active Bookings"
        '
        'dgvTickets
        '
        Me.dgvTickets.AllowUserToAddRows = False
        Me.dgvTickets.AllowUserToDeleteRows = False
        Me.dgvTickets.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvTickets.BackgroundColor = System.Drawing.Color.White
        Me.dgvTickets.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgvTickets.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvTickets.Location = New System.Drawing.Point(15, 25)
        Me.dgvTickets.MultiSelect = False
        Me.dgvTickets.ReadOnly = True
        Me.dgvTickets.RowHeadersVisible = False
        Me.dgvTickets.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvTickets.Size = New System.Drawing.Size(580, 455)
        '
        'frmBooking
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(245, 248, 245)
        Me.ClientSize = New System.Drawing.Size(990, 580)
        Me.Controls.Add(Me.grpBookingsGrid)
        Me.Controls.Add(Me.cmdClose)
        Me.Controls.Add(Me.cmdDelete)
        Me.Controls.Add(Me.cmdUpdate)
        Me.Controls.Add(Me.cmdBook)
        Me.Controls.Add(Me.grpBookingInput)
        Me.Controls.Add(Me.lblTitle)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "frmBooking"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ambatubus - Bookings Manager"
        Me.grpBookingInput.ResumeLayout(False)
        Me.grpBookingInput.PerformLayout()
        Me.grpBookingsGrid.ResumeLayout(False)
        CType(Me.dgvTickets, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblTitle As System.Windows.Forms.Label
    Friend WithEvents grpBookingInput As System.Windows.Forms.GroupBox
    Friend WithEvents lblTicketId As System.Windows.Forms.Label
    Friend WithEvents txtTicketId As System.Windows.Forms.TextBox
    Friend WithEvents lblPassengerName As System.Windows.Forms.Label
    Friend WithEvents txtPassengerName As System.Windows.Forms.TextBox
    Friend WithEvents lblPhone As System.Windows.Forms.Label
    Friend WithEvents txtPhone As System.Windows.Forms.TextBox
    Friend WithEvents lblDestination As System.Windows.Forms.Label
    Friend WithEvents cboRoute As System.Windows.Forms.ComboBox
    Friend WithEvents lblSeat As System.Windows.Forms.Label
    Friend WithEvents cboSeat As System.Windows.Forms.ComboBox
    Friend WithEvents lblPriceLabel As System.Windows.Forms.Label
    Friend WithEvents lblPrice As System.Windows.Forms.Label
    Friend WithEvents cmdBook As System.Windows.Forms.Button
    Friend WithEvents cmdUpdate As System.Windows.Forms.Button
    Friend WithEvents cmdDelete As System.Windows.Forms.Button
    Friend WithEvents cmdClose As System.Windows.Forms.Button
    Friend WithEvents grpBookingsGrid As System.Windows.Forms.GroupBox
    Friend WithEvents dgvTickets As System.Windows.Forms.DataGridView
End Class