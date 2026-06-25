Imports System
Imports System.Collections.Generic
Imports System.Data
Imports Microsoft.Data.SqlClient
Imports System.Windows.Forms
Imports System.Drawing

Public Class frmBooking
    Private selectedSeatNum As Integer = 0

    Private Sub frmBooking_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadSchedules()
        LoadBookings()
        ClearInputs()
        Try
            Dim assetPath As String = System.IO.Path.Combine(Application.StartupPath, "Assets", "destination_card.png")
            If System.IO.File.Exists(assetPath) Then
                picDestCard.Image = Image.FromFile(assetPath)
            End If
        Catch ex As Exception
            ' Silent fail
        End Try
    End Sub

    Private Sub LoadSchedules()
        Try
            Using conn As New SqlConnection(DatabaseHelper.ConnString)
                conn.Open()
                Dim query As String = "SELECT TripId, RouteName, DepartureTime, Price FROM Schedules WHERE DepartureTime > GETDATE() ORDER BY DepartureTime"
                Dim cmd As New SqlCommand(query, conn)
                Dim dt As New DataTable()
                dt.Load(cmd.ExecuteReader())

                cboRoute.DisplayMember = "RouteDetails"
                cboRoute.ValueMember = "TripId"

                dt.Columns.Add("RouteDetails", GetType(String))
                For Each row As DataRow In dt.Rows
                    Dim depTime As DateTime = Convert.ToDateTime(row("DepartureTime"))
                    row("RouteDetails") = $"{row("RouteName")} - {depTime:dd/MM/yyyy HH:mm} (RM {row("Price"):F2})"
                Next

                cboRoute.DataSource = dt
                cboRoute.SelectedIndex = -1
            End Using
        Catch ex As Exception
            MessageBox.Show("Error loading schedules: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub LoadBookings()
        Try
            Using conn As New SqlConnection(DatabaseHelper.ConnString)
                conn.Open()
                Dim query As String = "
                    SELECT b.TicketId As [Ticket ID], p.FullName As [Name], p.Phone, 
                           s.RouteName As [Route], b.SeatNumber As [Seat No], 
                           b.TotalPrice As [Total (RM)], b.BookingDate As [Booking Date],
                           b.TripId
                    FROM Bookings b
                    INNER JOIN Schedules s ON b.TripId = s.TripId
                    INNER JOIN Passengers p ON b.PassengerId = p.PassengerId
                    ORDER BY b.TicketId DESC"
                Dim da As New SqlDataAdapter(query, conn)
                Dim dt As New DataTable()
                da.Fill(dt)
                dgvTickets.DataSource = dt

                If dgvTickets.Columns.Contains("TripId") Then
                    dgvTickets.Columns("TripId").Visible = False
                End If
            End Using
        Catch ex As Exception
            MessageBox.Show("Error loading bookings: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub cboRoute_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboRoute.SelectedIndexChanged
        If cboRoute.SelectedValue IsNot Nothing AndAlso TypeOf cboRoute.SelectedValue Is Integer Then
            Dim tripId As Integer = Convert.ToInt32(cboRoute.SelectedValue)
            LoadAvailableSeats(tripId)
            UpdatePriceDisplay()
        Else
            pnlSeatGrid.Controls.Clear()
            txtSeat.Clear()
            selectedSeatNum = 0
            lblPrice.Text = "RM 0.00"
        End If
    End Sub

    Private Sub LoadAvailableSeats(tripId As Integer)
        Try
            Using conn As New SqlConnection(DatabaseHelper.ConnString)
                conn.Open()

                ' Get capacity
                Dim capCmd As New SqlCommand("SELECT SeatCapacity FROM Schedules WHERE TripId = @TripId", conn)
                capCmd.Parameters.AddWithValue("@TripId", tripId)
                Dim capacity As Integer = Convert.ToInt32(capCmd.ExecuteScalar())

                ' Get booked seats
                Dim bookedQuery As String = "SELECT SeatNumber FROM Bookings WHERE TripId = @TripId"
                Dim ticketIdVal As Integer
                If Integer.TryParse(txtTicketId.Text, ticketIdVal) Then
                    bookedQuery &= " AND TicketId <> @TicketId"
                End If

                Dim bookedCmd As New SqlCommand(bookedQuery, conn)
                bookedCmd.Parameters.AddWithValue("@TripId", tripId)
                If Integer.TryParse(txtTicketId.Text, ticketIdVal) Then
                    bookedCmd.Parameters.AddWithValue("@TicketId", ticketIdVal)
                End If

                Dim bookedSeats As New List(Of Integer)()
                Using reader As SqlDataReader = bookedCmd.ExecuteReader()
                    While reader.Read()
                        bookedSeats.Add(reader.GetInt32(0))
                    End While
                End Using

                ' Draw seat grid dynamically (2-1-2 layout with walkway)
                pnlSeatGrid.Controls.Clear()
                
                Dim seatIndex As Integer = 1
                While seatIndex <= capacity
                    ' Column 1: Left window seat
                    If seatIndex <= capacity Then
                        AddSeatButton(seatIndex, bookedSeats)
                        seatIndex += 1
                    End If

                    ' Column 2: Left aisle seat
                    If seatIndex <= capacity Then
                        AddSeatButton(seatIndex, bookedSeats)
                        seatIndex += 1
                    End If

                    ' Column 3: Walkway gap
                    Dim walkwayLabel As New Label()
                    walkwayLabel.Text = ""
                    walkwayLabel.Size = New Size(30, 40)
                    walkwayLabel.Margin = New Padding(5, 3, 5, 3)
                    pnlSeatGrid.Controls.Add(walkwayLabel)

                    ' Column 4: Right aisle seat
                    If seatIndex <= capacity Then
                        AddSeatButton(seatIndex, bookedSeats)
                        seatIndex += 1
                    End If

                    ' Column 5: Right window seat
                    If seatIndex <= capacity Then
                        AddSeatButton(seatIndex, bookedSeats)
                        seatIndex += 1
                    End If
                End While
            End Using
        Catch ex As Exception
            MessageBox.Show("Error loading seats: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub AddSeatButton(seatNum As Integer, bookedSeats As List(Of Integer))
        Dim btn As New Button()
        btn.Text = seatNum.ToString()
        btn.Size = New Size(45, 40)
        btn.Font = New Font("Segoe UI", 9.0!, FontStyle.Bold)
        btn.Margin = New Padding(5, 3, 5, 3)

        If bookedSeats.Contains(seatNum) Then
            ' Booked (Muted Dark Grey)
            btn.BackColor = Color.FromArgb(55, 60, 58)
            btn.ForeColor = Color.FromArgb(110, 120, 115)
            btn.Enabled = False
            btn.FlatStyle = FlatStyle.Standard
        Else
            ' Available (Mint Emerald)
            btn.BackColor = Color.FromArgb(20, 140, 80)
            btn.ForeColor = Color.White
            btn.FlatStyle = FlatStyle.Flat
            btn.FlatAppearance.BorderSize = 0

            ' Keep yellow if currently selected
            If seatNum = selectedSeatNum Then
                btn.BackColor = Color.FromArgb(240, 190, 20)
                btn.ForeColor = Color.Black
            End If

            AddHandler btn.Click, AddressOf SeatButton_Click
            AddHandler btn.MouseEnter, AddressOf SeatButton_MouseEnter
            AddHandler btn.MouseLeave, AddressOf SeatButton_MouseLeave
        End If

        pnlSeatGrid.Controls.Add(btn)
    End Sub

    Private Sub SeatButton_MouseEnter(sender As Object, e As EventArgs)
        Dim btn As Button = CType(sender, Button)
        If btn.BackColor = Color.FromArgb(20, 140, 80) Then
            btn.BackColor = Color.FromArgb(35, 175, 105)
        ElseIf btn.BackColor = Color.FromArgb(240, 190, 20) Then
            btn.BackColor = Color.FromArgb(250, 210, 35)
        End If
    End Sub

    Private Sub SeatButton_MouseLeave(sender As Object, e As EventArgs)
        Dim btn As Button = CType(sender, Button)
        Dim seatNum As Integer = Convert.ToInt32(btn.Text)
        If seatNum = selectedSeatNum Then
            btn.BackColor = Color.FromArgb(240, 190, 20)
            btn.ForeColor = Color.Black
        Else
            btn.BackColor = Color.FromArgb(20, 140, 80)
            btn.ForeColor = Color.White
        End If
    End Sub

    Private Sub SeatButton_Click(sender As Object, e As EventArgs)
        Dim clickedButton As Button = CType(sender, Button)
        Dim seatNum As Integer = Convert.ToInt32(clickedButton.Text)

        ' Reset previously selected yellow button back to green
        For Each ctrl As Control In pnlSeatGrid.Controls
            If TypeOf ctrl Is Button AndAlso ctrl.Enabled AndAlso (ctrl.BackColor = Color.FromArgb(240, 190, 20) OrElse ctrl.BackColor = Color.FromArgb(250, 210, 35)) Then
                ctrl.BackColor = Color.FromArgb(20, 140, 80)
                ctrl.ForeColor = Color.White
            End If
        Next

        ' Highlight selected button
        clickedButton.BackColor = Color.FromArgb(240, 190, 20)
        clickedButton.ForeColor = Color.Black

        selectedSeatNum = seatNum
        txtSeat.Text = seatNum.ToString()
    End Sub

    Private Sub UpdatePriceDisplay()
        If cboRoute.SelectedItem IsNot Nothing Then
            Dim rowView As DataRowView = CType(cboRoute.SelectedItem, DataRowView)
            Dim price As Decimal = Convert.ToDecimal(rowView("Price"))
            lblPrice.Text = String.Format("RM {0:F2}", price)
        Else
            lblPrice.Text = "RM 0.00"
        End If
    End Sub

    Private Sub dgvTickets_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvTickets.CellClick
        If e.RowIndex >= 0 Then
            Dim row As DataGridViewRow = dgvTickets.Rows(e.RowIndex)
            txtTicketId.Text = row.Cells("Ticket ID").Value.ToString()
            txtPassengerName.Text = row.Cells("Name").Value.ToString()
            txtPhone.Text = row.Cells("Phone").Value.ToString()

            Dim tripId As Integer = Convert.ToInt32(row.Cells("TripId").Value)
            cboRoute.SelectedValue = tripId

            ' Set selected seat variables before loading seats
            Dim seatNum As Integer = Convert.ToInt32(row.Cells("Seat No").Value)
            selectedSeatNum = seatNum
            txtSeat.Text = seatNum.ToString()

            LoadAvailableSeats(tripId)
            UpdatePriceDisplay()
        End If
    End Sub

    Private Sub ClearInputs()
        txtTicketId.Clear()
        txtPassengerName.Clear()
        txtPhone.Clear()
        txtSeat.Clear()
        selectedSeatNum = 0
        cboRoute.SelectedIndex = -1
        pnlSeatGrid.Controls.Clear()
        lblPrice.Text = "RM 0.00"
    End Sub

    Private Function ValidateInput() As Boolean
        Dim name As String = txtPassengerName.Text.Trim()
        Dim phone As String = txtPhone.Text.Trim()

        If String.IsNullOrWhiteSpace(name) Then
            MessageBox.Show("Please enter passenger name.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return False
        End If

        ' Name validation: letters and spaces only
        If Not System.Text.RegularExpressions.Regex.IsMatch(name, "^[a-zA-Z\s]+$") Then
            MessageBox.Show("Passenger name can only contain letters and spaces.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return False
        End If

        If String.IsNullOrWhiteSpace(phone) Then
            MessageBox.Show("Please enter phone number.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return False
        End If

        ' Phone validation: Malaysian format
        If Not System.Text.RegularExpressions.Regex.IsMatch(phone, "^(01|\+601)[0-9]{7,9}$") Then
            MessageBox.Show("Please enter a valid Malaysian phone number (e.g. 0123456789 or +60123456789).", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return False
        End If

        If cboRoute.SelectedValue Is Nothing Then
            MessageBox.Show("Please select a route.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return False
        End If

        If selectedSeatNum <= 0 Then
            MessageBox.Show("Please select an available seat from the seating chart.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return False
        End If

        Return True
    End Function

    Private Function GetOrCreatePassengerId(name As String, phone As String, conn As SqlConnection) As Integer
        ' Check if passenger exists
        Dim lookupQuery As String = "SELECT PassengerId FROM Passengers WHERE Phone = @Phone"
        Using cmd As New SqlCommand(lookupQuery, conn)
            cmd.Parameters.AddWithValue("@Phone", phone)
            Dim id = cmd.ExecuteScalar()
            If id IsNot Nothing AndAlso id IsNot DBNull.Value Then
                Return Convert.ToInt32(id)
            End If
        End Using

        ' Create passenger if not found
        Dim insertQuery As String = "INSERT INTO Passengers (FullName, Phone) VALUES (@Name, @Phone); SELECT SCOPE_IDENTITY();"
        Using cmd As New SqlCommand(insertQuery, conn)
            cmd.Parameters.AddWithValue("@Name", name)
            cmd.Parameters.AddWithValue("@Phone", phone)
            Return Convert.ToInt32(cmd.ExecuteScalar())
        End Using
    End Function

    Private Sub cmdBook_Click(sender As Object, e As EventArgs) Handles cmdBook.Click
        If Not ValidateInput() Then Return

        Dim tripId As Integer = Convert.ToInt32(cboRoute.SelectedValue)
        Dim rowView As DataRowView = CType(cboRoute.SelectedItem, DataRowView)
        Dim price As Decimal = Convert.ToDecimal(rowView("Price"))

        Try
            Dim newTicketId As Integer = 0
            Using conn As New SqlConnection(DatabaseHelper.ConnString)
                conn.Open()

                Dim passengerId As Integer = GetOrCreatePassengerId(txtPassengerName.Text.Trim(), txtPhone.Text.Trim(), conn)

                ' Double booking check
                Dim checkCmd As New SqlCommand("SELECT COUNT(*) FROM Bookings WHERE TripId = @TripId AND SeatNumber = @Seat", conn)
                checkCmd.Parameters.AddWithValue("@TripId", tripId)
                checkCmd.Parameters.AddWithValue("@Seat", selectedSeatNum)
                Dim isBooked As Integer = Convert.ToInt32(checkCmd.ExecuteScalar())
                If isBooked > 0 Then
                    MessageBox.Show("This seat has already been booked. Please choose another seat.", "Booking Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    LoadAvailableSeats(tripId)
                    Return
                End If

                ' Prevent overcapacity
                Dim countCmd As New SqlCommand("SELECT COUNT(*) FROM Bookings WHERE TripId = @TripId", conn)
                countCmd.Parameters.AddWithValue("@TripId", tripId)
                Dim bookedCount As Integer = Convert.ToInt32(countCmd.ExecuteScalar())

                Dim capCmd As New SqlCommand("SELECT SeatCapacity FROM Schedules WHERE TripId = @TripId", conn)
                capCmd.Parameters.AddWithValue("@TripId", tripId)
                Dim capacity As Integer = Convert.ToInt32(capCmd.ExecuteScalar())

                If bookedCount >= capacity Then
                    MessageBox.Show("This trip is fully booked!", "Booking Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Return
                End If

                ' Insert booking
                Dim insertSql As String = "
                    INSERT INTO Bookings (TripId, PassengerId, SeatNumber, TotalPrice, BookingDate) 
                    VALUES (@TripId, @PassengerId, @Seat, @Price, GETDATE());
                    SELECT SCOPE_IDENTITY();"
                Using cmd As New SqlCommand(insertSql, conn)
                    cmd.Parameters.AddWithValue("@TripId", tripId)
                    cmd.Parameters.AddWithValue("@PassengerId", passengerId)
                    cmd.Parameters.AddWithValue("@Seat", selectedSeatNum)
                    cmd.Parameters.AddWithValue("@Price", price)
                    newTicketId = Convert.ToInt32(cmd.ExecuteScalar())
                End Using
            End Using

            MessageBox.Show("Booking successfully registered!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
            ExportReceipt(newTicketId)
            LoadBookings()
            ClearInputs()
        Catch ex As SqlException When ex.Number = 2627
            MessageBox.Show("Concurrency Alert: This seat was just booked by another user. Seating chart has been updated.", "Double Booking Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            LoadAvailableSeats(tripId)
        Catch ex As Exception
            MessageBox.Show("Booking failed: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub cmdUpdate_Click(sender As Object, e As EventArgs) Handles cmdUpdate.Click
        Dim ticketIdVal As Integer
        If Not Integer.TryParse(txtTicketId.Text, ticketIdVal) Then
            MessageBox.Show("Please select a booking record from the table to update.", "Selection Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        If Not ValidateInput() Then Return

        Dim tripId As Integer = Convert.ToInt32(cboRoute.SelectedValue)
        Dim rowView As DataRowView = CType(cboRoute.SelectedItem, DataRowView)
        Dim price As Decimal = Convert.ToDecimal(rowView("Price"))

        Try
            Using conn As New SqlConnection(DatabaseHelper.ConnString)
                conn.Open()

                Dim passengerId As Integer = GetOrCreatePassengerId(txtPassengerName.Text.Trim(), txtPhone.Text.Trim(), conn)

                ' Double booking check
                Dim checkCmd As New SqlCommand("SELECT COUNT(*) FROM Bookings WHERE TripId = @TripId AND SeatNumber = @Seat AND TicketId <> @TicketId", conn)
                checkCmd.Parameters.AddWithValue("@TripId", tripId)
                checkCmd.Parameters.AddWithValue("@Seat", selectedSeatNum)
                checkCmd.Parameters.AddWithValue("@TicketId", ticketIdVal)
                Dim isBooked As Integer = Convert.ToInt32(checkCmd.ExecuteScalar())
                If isBooked > 0 Then
                    MessageBox.Show("This seat is already booked for another passenger.", "Update Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Return
                End If

                ' Update booking details
                Dim updateSql As String = "
                    UPDATE Bookings 
                    SET TripId = @TripId, PassengerId = @PassengerId, SeatNumber = @Seat, TotalPrice = @Price 
                    WHERE TicketId = @TicketId"
                Using cmd As New SqlCommand(updateSql, conn)
                    cmd.Parameters.AddWithValue("@TripId", tripId)
                    cmd.Parameters.AddWithValue("@PassengerId", passengerId)
                    cmd.Parameters.AddWithValue("@Seat", selectedSeatNum)
                    cmd.Parameters.AddWithValue("@Price", price)
                    cmd.Parameters.AddWithValue("@TicketId", ticketIdVal)
                    cmd.ExecuteNonQuery()
                End Using
            End Using

            MessageBox.Show("Booking details successfully updated!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
            LoadBookings()
            ClearInputs()
        Catch ex As SqlException When ex.Number = 2627
            MessageBox.Show("Concurrency Alert: This seat was just booked by another user.", "Update Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            LoadAvailableSeats(tripId)
        Catch ex As Exception
            MessageBox.Show("Update failed: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub cmdDelete_Click(sender As Object, e As EventArgs) Handles cmdDelete.Click
        Dim ticketIdVal As Integer
        If Not Integer.TryParse(txtTicketId.Text, ticketIdVal) Then
            MessageBox.Show("Please select a booking record from the table to cancel.", "Selection Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        Dim confirmResult = MessageBox.Show("Are you sure you want to cancel this booking?", "Confirm Cancellation", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If confirmResult = DialogResult.Yes Then
            Try
                Using conn As New SqlConnection(DatabaseHelper.ConnString)
                    conn.Open()
                    Dim deleteSql As String = "DELETE FROM Bookings WHERE TicketId = @TicketId"
                    Using cmd As New SqlCommand(deleteSql, conn)
                        cmd.Parameters.AddWithValue("@TicketId", ticketIdVal)
                        cmd.ExecuteNonQuery()
                    End Using
                End Using

                MessageBox.Show("Booking successfully cancelled.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                LoadBookings()
                ClearInputs()
            Catch ex As Exception
                MessageBox.Show("Cancellation failed: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End If
    End Sub

    Private Sub ExportReceipt(ticketId As Integer)
        Try
            Using conn As New SqlConnection(DatabaseHelper.ConnString)
                conn.Open()
                Dim query As String = "
                    SELECT b.TicketId, p.FullName, p.Phone, s.RouteName, s.DepartureTime, b.SeatNumber, b.TotalPrice, b.BookingDate
                    FROM Bookings b
                    INNER JOIN Schedules s ON b.TripId = s.TripId
                    INNER JOIN Passengers p ON b.PassengerId = p.PassengerId
                    WHERE b.TicketId = @TicketId"
                Using cmd As New SqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@TicketId", ticketId)
                    Using reader As SqlDataReader = cmd.ExecuteReader()
                        If reader.Read() Then
                            Dim receiptText As New System.Text.StringBuilder()
                            receiptText.AppendLine("=========================================")
                            receiptText.AppendLine("           AMBATUBUS TICKET RECEIPT      ")
                            receiptText.AppendLine("=========================================")
                            receiptText.AppendLine($"Ticket ID    : {reader("TicketId")}")
                            receiptText.AppendLine($"Passenger    : {reader("FullName")}")
                            receiptText.AppendLine($"Phone        : {reader("Phone")}")
                            receiptText.AppendLine("-----------------------------------------")
                            receiptText.AppendLine($"Route        : {reader("RouteName")}")
                            receiptText.AppendLine($"Departure    : {Convert.ToDateTime(reader("DepartureTime")):dd/MM/yyyy HH:mm}")
                            receiptText.AppendLine($"Seat Number  : Seat {reader("SeatNumber")}")
                            receiptText.AppendLine($"Price        : RM {Convert.ToDecimal(reader("TotalPrice")):F2}")
                            receiptText.AppendLine("-----------------------------------------")
                            receiptText.AppendLine($"Booking Date : {Convert.ToDateTime(reader("BookingDate")):dd/MM/yyyy HH:mm:ss}")
                            receiptText.AppendLine("=========================================")
                            receiptText.AppendLine("   Thank you for travelling with us!    ")
                            receiptText.AppendLine("=========================================")

                            ' Write to My Documents folder
                            Dim docPath As String = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments)
                            Dim filePath As String = System.IO.Path.Combine(docPath, $"Ticket_Receipt_{ticketId}.txt")
                            System.IO.File.WriteAllText(filePath, receiptText.ToString())

                            ' Open file automatically
                            Dim psi As New System.Diagnostics.ProcessStartInfo(filePath) With {.UseShellExecute = True}
                            System.Diagnostics.Process.Start(psi)
                        End If
                    End Using
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Failed to export receipt: " & ex.Message, "Receipt Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End Try
    End Sub

    Private Sub cmdClose_Click(sender As Object, e As EventArgs) Handles cmdClose.Click
        Me.Close()
    End Sub

    ' Button Hover Effects
    Private Sub Button_MouseEnter(sender As Object, e As EventArgs) Handles cmdBook.MouseEnter, cmdUpdate.MouseEnter, cmdDelete.MouseEnter, cmdClose.MouseEnter
        Dim btn As Button = CType(sender, Button)
        If btn Is cmdBook Then
            btn.BackColor = Color.FromArgb(35, 175, 105)
        ElseIf btn Is cmdUpdate Then
            btn.BackColor = Color.FromArgb(50, 150, 210)
        ElseIf btn Is cmdDelete Then
            btn.BackColor = Color.FromArgb(210, 70, 70)
        ElseIf btn Is cmdClose Then
            btn.BackColor = Color.FromArgb(85, 95, 90)
        End If
    End Sub

    Private Sub Button_MouseLeave(sender As Object, e As EventArgs) Handles cmdBook.MouseLeave, cmdUpdate.MouseLeave, cmdDelete.MouseLeave, cmdClose.MouseLeave
        Dim btn As Button = CType(sender, Button)
        If btn Is cmdBook Then
            btn.BackColor = Color.FromArgb(20, 150, 85)
        ElseIf btn Is cmdUpdate Then
            btn.BackColor = Color.FromArgb(30, 130, 190)
        ElseIf btn Is cmdDelete Then
            btn.BackColor = Color.FromArgb(180, 50, 50)
        ElseIf btn Is cmdClose Then
            btn.BackColor = Color.FromArgb(65, 75, 70)
        End If
    End Sub
End Class