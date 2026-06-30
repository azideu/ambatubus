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
        Me.picDestCard = New System.Windows.Forms.PictureBox()
        Me.lblTicketId = New System.Windows.Forms.Label()
        Me.txtTicketId = New System.Windows.Forms.TextBox()
        Me.lblPassengerName = New System.Windows.Forms.Label()
        Me.txtPassengerName = New System.Windows.Forms.TextBox()
        Me.lblPhone = New System.Windows.Forms.Label()
        Me.txtPhone = New System.Windows.Forms.TextBox()
        Me.lblDestination = New System.Windows.Forms.Label()
        Me.cboRoute = New System.Windows.Forms.ComboBox()
        Me.lblSeat = New System.Windows.Forms.Label()
        Me.txtSeat = New System.Windows.Forms.TextBox()
        Me.lblPriceLabel = New System.Windows.Forms.Label()
        Me.lblPrice = New System.Windows.Forms.Label()
        Me.cmdBook = New System.Windows.Forms.Button()
        Me.cmdUpdate = New System.Windows.Forms.Button()
        Me.cmdDelete = New System.Windows.Forms.Button()
        Me.cmdClose = New System.Windows.Forms.Button()
        Me.grpSeatMap = New System.Windows.Forms.GroupBox()
        Me.pnlSeatGrid = New System.Windows.Forms.FlowLayoutPanel()
        Me.lblBusFront = New System.Windows.Forms.Label()
        Me.lblBusBack = New System.Windows.Forms.Label()
        Me.pnlLeftWall = New System.Windows.Forms.Panel()
        Me.pnlRightWall = New System.Windows.Forms.Panel()
        Me.grpBookingsGrid = New System.Windows.Forms.GroupBox()
        Me.dgvTickets = New System.Windows.Forms.DataGridView()
        Me.grpBookingInput.SuspendLayout()
        Me.grpBookingsGrid.SuspendLayout()
        CType(Me.dgvTickets, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picDestCard, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblTitle
        '
        '
        'lblTitle
        '
        Me.lblTitle.AutoSize = True
        Me.lblTitle.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Bold)
        Me.lblTitle.ForeColor = System.Drawing.Color.White
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
        Me.grpBookingInput.Controls.Add(Me.txtSeat)
        Me.grpBookingInput.Controls.Add(Me.lblPriceLabel)
        Me.grpBookingInput.Controls.Add(Me.lblPrice)
        Me.grpBookingInput.Font = New System.Drawing.Font("Segoe UI Semibold", 9.5!, System.Drawing.FontStyle.Bold)
        Me.grpBookingInput.ForeColor = System.Drawing.Color.FromArgb(100, 120, 110)
        Me.grpBookingInput.Location = New System.Drawing.Point(20, 65)
        Me.grpBookingInput.Size = New System.Drawing.Size(320, 395)
        Me.grpBookingInput.Text = "Booking Information"
        '
        'lblTicketId
        '
        Me.lblTicketId.AutoSize = True
        Me.lblTicketId.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.lblTicketId.ForeColor = System.Drawing.Color.FromArgb(140, 160, 150)
        Me.lblTicketId.Location = New System.Drawing.Point(15, 30)
        Me.lblTicketId.Text = "Ticket ID"
        '
        'txtTicketId
        '
        Me.txtTicketId.BackColor = System.Drawing.Color.FromArgb(35, 42, 38)
        Me.txtTicketId.ForeColor = System.Drawing.Color.FromArgb(220, 235, 225)
        Me.txtTicketId.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtTicketId.Enabled = False
        Me.txtTicketId.Location = New System.Drawing.Point(15, 50)
        Me.txtTicketId.ReadOnly = True
        Me.txtTicketId.Size = New System.Drawing.Size(290, 24)
        '
        'lblPassengerName
        '
        Me.lblPassengerName.AutoSize = True
        Me.lblPassengerName.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.lblPassengerName.ForeColor = System.Drawing.Color.FromArgb(140, 160, 150)
        Me.lblPassengerName.Location = New System.Drawing.Point(15, 85)
        Me.lblPassengerName.Text = "Passenger Name"
        '
        'txtPassengerName
        '
        Me.txtPassengerName.BackColor = System.Drawing.Color.FromArgb(35, 42, 38)
        Me.txtPassengerName.ForeColor = System.Drawing.Color.FromArgb(220, 235, 225)
        Me.txtPassengerName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtPassengerName.Location = New System.Drawing.Point(15, 105)
        Me.txtPassengerName.Size = New System.Drawing.Size(290, 24)
        '
        'lblPhone
        '
        Me.lblPhone.AutoSize = True
        Me.lblPhone.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.lblPhone.ForeColor = System.Drawing.Color.FromArgb(140, 160, 150)
        Me.lblPhone.Location = New System.Drawing.Point(15, 140)
        Me.lblPhone.Text = "Phone Number"
        '
        'txtPhone
        '
        Me.txtPhone.BackColor = System.Drawing.Color.FromArgb(35, 42, 38)
        Me.txtPhone.ForeColor = System.Drawing.Color.FromArgb(220, 235, 225)
        Me.txtPhone.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtPhone.Location = New System.Drawing.Point(15, 160)
        Me.txtPhone.Size = New System.Drawing.Size(290, 24)
        '
        'lblDestination
        '
        Me.lblDestination.AutoSize = True
        Me.lblDestination.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.lblDestination.ForeColor = System.Drawing.Color.FromArgb(140, 160, 150)
        Me.lblDestination.Location = New System.Drawing.Point(15, 195)
        Me.lblDestination.Text = "Select Trip & Schedule"
        '
        'cboRoute
        '
        Me.cboRoute.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboRoute.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cboRoute.BackColor = System.Drawing.Color.FromArgb(35, 42, 38)
        Me.cboRoute.ForeColor = System.Drawing.Color.FromArgb(220, 235, 225)
        Me.cboRoute.DropDownWidth = 450
        Me.cboRoute.Location = New System.Drawing.Point(15, 215)
        Me.cboRoute.Size = New System.Drawing.Size(350, 25)
        '
        'lblSeat
        '
        Me.lblSeat.AutoSize = True
        Me.lblSeat.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.lblSeat.ForeColor = System.Drawing.Color.FromArgb(140, 160, 150)
        Me.lblSeat.Location = New System.Drawing.Point(15, 250)
        Me.lblSeat.Text = "Select Seat No"
        '
        'txtSeat
        '
        Me.txtSeat.BackColor = System.Drawing.Color.FromArgb(35, 42, 38)
        Me.txtSeat.ForeColor = System.Drawing.Color.FromArgb(220, 235, 225)
        Me.txtSeat.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtSeat.Location = New System.Drawing.Point(15, 270)
        Me.txtSeat.Size = New System.Drawing.Size(290, 24)
        Me.txtSeat.ReadOnly = True
        '
        'lblPriceLabel
        '
        Me.lblPriceLabel.AutoSize = True
        Me.lblPriceLabel.Font = New System.Drawing.Font("Segoe UI Semibold", 10.0!, System.Drawing.FontStyle.Bold)
        Me.lblPriceLabel.ForeColor = System.Drawing.Color.FromArgb(140, 160, 150)
        Me.lblPriceLabel.Location = New System.Drawing.Point(15, 315)
        Me.lblPriceLabel.Text = "Ticket Price:"
        '
        'lblPrice
        '
        Me.lblPrice.AutoSize = True
        Me.lblPrice.Font = New System.Drawing.Font("Segoe UI", 20.0!, System.Drawing.FontStyle.Bold)
        Me.lblPrice.ForeColor = System.Drawing.Color.FromArgb(250, 180, 80)
        Me.lblPrice.Location = New System.Drawing.Point(15, 335)
        Me.lblPrice.Text = "RM 0.00"
        '
        'picDestCard
        '
        Me.picDestCard.Location = New System.Drawing.Point(20, 480)
        Me.picDestCard.Name = "picDestCard"
        Me.picDestCard.Size = New System.Drawing.Size(320, 160)
        Me.picDestCard.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picDestCard.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.picDestCard.TabStop = False
        '
        'cmdBook
        '
        Me.cmdBook.BackColor = System.Drawing.Color.FromArgb(20, 150, 85)
        Me.cmdBook.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdBook.FlatAppearance.BorderSize = 0
        Me.cmdBook.Font = New System.Drawing.Font("Segoe UI", 9.5!, System.Drawing.FontStyle.Bold)
        Me.cmdBook.ForeColor = System.Drawing.Color.White
        Me.cmdBook.Location = New System.Drawing.Point(20, 635)
        Me.cmdBook.Size = New System.Drawing.Size(145, 35)
        Me.cmdBook.Text = "🎟️ Book Ticket"
        Me.cmdBook.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.cmdBook.UseVisualStyleBackColor = False
        '
        'cmdUpdate
        '
        Me.cmdUpdate.BackColor = System.Drawing.Color.FromArgb(30, 130, 190)
        Me.cmdUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdUpdate.FlatAppearance.BorderSize = 0
        Me.cmdUpdate.Font = New System.Drawing.Font("Segoe UI", 9.5!, System.Drawing.FontStyle.Bold)
        Me.cmdUpdate.ForeColor = System.Drawing.Color.White
        Me.cmdUpdate.Location = New System.Drawing.Point(195, 635)
        Me.cmdUpdate.Size = New System.Drawing.Size(145, 35)
        Me.cmdUpdate.Text = "✏️ Update details"
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
        Me.cmdDelete.Location = New System.Drawing.Point(20, 680)
        Me.cmdDelete.Size = New System.Drawing.Size(145, 35)
        Me.cmdDelete.Text = "🗑️ Cancel Booking"
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
        Me.cmdClose.Location = New System.Drawing.Point(195, 680)
        Me.cmdClose.Size = New System.Drawing.Size(145, 35)
        Me.cmdClose.Text = "⬅️ Back to Menu"
        Me.cmdClose.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.cmdClose.UseVisualStyleBackColor = False
        '
        'grpSeatMap
        '
        Me.grpSeatMap.Controls.Add(Me.pnlLeftWall)
        Me.grpSeatMap.Controls.Add(Me.pnlRightWall)
        Me.grpSeatMap.Controls.Add(Me.lblBusFront)
        Me.grpSeatMap.Controls.Add(Me.lblBusBack)
        Me.grpSeatMap.Controls.Add(Me.pnlSeatGrid)
        Me.grpSeatMap.Font = New System.Drawing.Font("Segoe UI Semibold", 9.5!, System.Drawing.FontStyle.Bold)
        Me.grpSeatMap.ForeColor = System.Drawing.Color.FromArgb(100, 120, 110)
        Me.grpSeatMap.Location = New System.Drawing.Point(360, 65)
        Me.grpSeatMap.Size = New System.Drawing.Size(320, 650)
        Me.grpSeatMap.Text = "Bus Seating Chart"
        Me.grpSeatMap.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        '
        'lblBusFront
        '
        Me.lblBusFront.BackColor = System.Drawing.Color.FromArgb(35, 45, 40)
        Me.lblBusFront.Font = New System.Drawing.Font("Segoe UI", 9.5!, System.Drawing.FontStyle.Bold)
        Me.lblBusFront.ForeColor = System.Drawing.Color.FromArgb(100, 220, 150)
        Me.lblBusFront.Location = New System.Drawing.Point(16, 22)
        Me.lblBusFront.Size = New System.Drawing.Size(288, 30)
        Me.lblBusFront.Text = "🚌 DRIVER  |  [ FRONT ]  |  DOOR"
        Me.lblBusFront.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.lblBusFront.BorderStyle = System.Windows.Forms.BorderStyle.None
        '
        'lblBusBack
        '
        Me.lblBusBack.BackColor = System.Drawing.Color.FromArgb(35, 40, 38)
        Me.lblBusBack.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.lblBusBack.ForeColor = System.Drawing.Color.FromArgb(140, 150, 145)
        Me.lblBusBack.Location = New System.Drawing.Point(16, 600)
        Me.lblBusBack.Size = New System.Drawing.Size(288, 30)
        Me.lblBusBack.Text = "[ BACK / REAR ]"
        Me.lblBusBack.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.lblBusBack.BorderStyle = System.Windows.Forms.BorderStyle.None
        '
        'pnlLeftWall
        '
        Me.pnlLeftWall.BackColor = System.Drawing.Color.FromArgb(60, 70, 65)
        Me.pnlLeftWall.Location = New System.Drawing.Point(10, 60)
        Me.pnlLeftWall.Size = New System.Drawing.Size(4, 530)
        Me.pnlLeftWall.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        '
        'pnlRightWall
        '
        Me.pnlRightWall.BackColor = System.Drawing.Color.FromArgb(60, 70, 65)
        Me.pnlRightWall.Location = New System.Drawing.Point(306, 60)
        Me.pnlRightWall.Size = New System.Drawing.Size(4, 530)
        Me.pnlRightWall.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        '
        'pnlSeatGrid
        '
        Me.pnlSeatGrid.BackColor = System.Drawing.Color.FromArgb(30, 35, 33)
        Me.pnlSeatGrid.Location = New System.Drawing.Point(16, 60)
        Me.pnlSeatGrid.Size = New System.Drawing.Size(288, 530)
        Me.pnlSeatGrid.AutoScroll = True
        Me.pnlSeatGrid.Padding = New System.Windows.Forms.Padding(10, 5, 10, 5)
        Me.pnlSeatGrid.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) Or System.Windows.Forms.AnchorStyles.Left) Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        '
        'grpBookingsGrid
        '
        Me.grpBookingsGrid.Controls.Add(Me.dgvTickets)
        Me.grpBookingsGrid.Font = New System.Drawing.Font("Segoe UI Semibold", 9.5!, System.Drawing.FontStyle.Bold)
        Me.grpBookingsGrid.ForeColor = System.Drawing.Color.FromArgb(100, 120, 110)
        Me.grpBookingsGrid.Location = New System.Drawing.Point(700, 65)
        Me.grpBookingsGrid.Size = New System.Drawing.Size(570, 650)
        Me.grpBookingsGrid.Text = "Active Bookings"
        Me.grpBookingsGrid.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) Or System.Windows.Forms.AnchorStyles.Left) Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        '
        'dgvTickets
        '
        Me.dgvTickets.AllowUserToAddRows = False
        Me.dgvTickets.AllowUserToDeleteRows = False
        Me.dgvTickets.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvTickets.BackgroundColor = System.Drawing.Color.FromArgb(35, 42, 38)
        Me.dgvTickets.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgvTickets.GridColor = System.Drawing.Color.FromArgb(50, 60, 55)
        Me.dgvTickets.Location = New System.Drawing.Point(15, 25)
        Me.dgvTickets.MultiSelect = False
        Me.dgvTickets.ReadOnly = True
        Me.dgvTickets.RowHeadersVisible = False
        Me.dgvTickets.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvTickets.Size = New System.Drawing.Size(540, 610)
        Me.dgvTickets.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) Or System.Windows.Forms.AnchorStyles.Left) Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Dim dgvTixStyle1 As New System.Windows.Forms.DataGridViewCellStyle()
        dgvTixStyle1.BackColor = System.Drawing.Color.FromArgb(20, 110, 60)
        dgvTixStyle1.ForeColor = System.Drawing.Color.White
        dgvTixStyle1.Font = New System.Drawing.Font("Segoe UI Semibold", 9.5!, System.Drawing.FontStyle.Bold)
        dgvTixStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(20, 110, 60)
        dgvTixStyle1.SelectionForeColor = System.Drawing.Color.White
        Me.dgvTickets.ColumnHeadersDefaultCellStyle = dgvTixStyle1
        Me.dgvTickets.EnableHeadersVisualStyles = False
        Dim dgvTixStyle2 As New System.Windows.Forms.DataGridViewCellStyle()
        dgvTixStyle2.BackColor = System.Drawing.Color.FromArgb(35, 42, 38)
        dgvTixStyle2.ForeColor = System.Drawing.Color.FromArgb(220, 235, 225)
        dgvTixStyle2.Font = New System.Drawing.Font("Segoe UI", 9.5!)
        dgvTixStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(25, 130, 75)
        dgvTixStyle2.SelectionForeColor = System.Drawing.Color.White
        Me.dgvTickets.DefaultCellStyle = dgvTixStyle2
        Dim dgvTixStyle3 As New System.Windows.Forms.DataGridViewCellStyle()
        dgvTixStyle3.BackColor = System.Drawing.Color.FromArgb(30, 36, 33)
        dgvTixStyle3.ForeColor = System.Drawing.Color.FromArgb(220, 235, 225)
        dgvTixStyle3.Font = New System.Drawing.Font("Segoe UI", 9.5!)
        dgvTixStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(25, 130, 75)
        dgvTixStyle3.SelectionForeColor = System.Drawing.Color.White
        Me.dgvTickets.AlternatingRowsDefaultCellStyle = dgvTixStyle3
        '
        'frmBooking
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(25, 30, 28)
        Me.ClientSize = New System.Drawing.Size(1290, 730)
        Me.Controls.Add(Me.picDestCard)
        Me.Controls.Add(Me.grpBookingsGrid)
        Me.Controls.Add(Me.grpSeatMap)
        Me.Controls.Add(Me.cmdClose)
        Me.Controls.Add(Me.cmdDelete)
        Me.Controls.Add(Me.cmdUpdate)
        Me.Controls.Add(Me.cmdBook)
        Me.Controls.Add(Me.grpBookingInput)
        Me.Controls.Add(Me.lblTitle)
        Me.Name = "frmBooking"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ambatubus - Bookings Manager"
        Me.grpBookingInput.ResumeLayout(False)
        Me.grpBookingInput.PerformLayout()
        Me.grpSeatMap.ResumeLayout(False)
        Me.grpBookingsGrid.ResumeLayout(False)
        CType(Me.dgvTickets, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picDestCard, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents txtSeat As System.Windows.Forms.TextBox
    Friend WithEvents lblPriceLabel As System.Windows.Forms.Label
    Friend WithEvents lblPrice As System.Windows.Forms.Label
    Friend WithEvents cmdBook As System.Windows.Forms.Button
    Friend WithEvents cmdUpdate As System.Windows.Forms.Button
    Friend WithEvents cmdDelete As System.Windows.Forms.Button
    Friend WithEvents cmdClose As System.Windows.Forms.Button
    Friend WithEvents grpSeatMap As System.Windows.Forms.GroupBox
    Friend WithEvents pnlSeatGrid As System.Windows.Forms.FlowLayoutPanel
    Friend WithEvents lblBusFront As System.Windows.Forms.Label
    Friend WithEvents lblBusBack As System.Windows.Forms.Label
    Friend WithEvents pnlLeftWall As System.Windows.Forms.Panel
    Friend WithEvents pnlRightWall As System.Windows.Forms.Panel
    Friend WithEvents grpBookingsGrid As System.Windows.Forms.GroupBox
    Friend WithEvents dgvTickets As System.Windows.Forms.DataGridView
    Friend WithEvents picDestCard As System.Windows.Forms.PictureBox
End Class