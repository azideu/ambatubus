Imports System
Imports System.Collections.Generic
Imports System.Data
Imports Microsoft.Data.SqlClient
Imports System.Windows.Forms

Public Class frmBooking
    Private Sub frmBooking_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadSchedules()
        LoadBookings()
        ClearInputs()
    End Sub

    Private Sub LoadSchedules()
        Try
            Using conn As New SqlConnection(DatabaseHelper.ConnString)
                conn.Open()
                Dim query As String = "SELECT TripId, RouteName, DepartureTime, Price FROM Schedules ORDER BY DepartureTime"
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
                    SELECT b.TicketId As [Ticket ID], b.PassengerName As [Name], b.Phone, 
                           s.RouteName As [Route], b.SeatNumber As [Seat No], 
                           b.TotalPrice As [Total (RM)], b.BookingDate As [Booking Date],
                           b.TripId
                    FROM Bookings b
                    INNER JOIN Schedules s ON b.TripId = s.TripId
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
            cboSeat.DataSource = Nothing
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

                ' Filter seats
                Dim availableSeats As New List(Of Integer)()
                For i As Integer = 1 To capacity
                    If Not bookedSeats.Contains(i) Then
                        availableSeats.Add(i)
                    End If
                Next

                cboSeat.DataSource = availableSeats
                cboSeat.SelectedIndex = -1
            End Using
        Catch ex As Exception
            MessageBox.Show("Error loading seats: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
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

            LoadAvailableSeats(tripId)
            Dim seatNum As Integer = Convert.ToInt32(row.Cells("Seat No").Value)
            cboSeat.SelectedItem = seatNum

            UpdatePriceDisplay()
        End If
    End Sub

    Private Sub ClearInputs()
        txtTicketId.Clear()
        txtPassengerName.Clear()
        txtPhone.Clear()
        cboRoute.SelectedIndex = -1
        cboSeat.DataSource = Nothing
        lblPrice.Text = "RM 0.00"
    End Sub

    Private Sub cmdBook_Click(sender As Object, e As EventArgs) Handles cmdBook.Click
        If String.IsNullOrWhiteSpace(txtPassengerName.Text) Then
            MessageBox.Show("Please enter passenger name.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If
        If String.IsNullOrWhiteSpace(txtPhone.Text) Then
            MessageBox.Show("Please enter phone number.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If
        If cboRoute.SelectedValue Is Nothing Then
            MessageBox.Show("Please select a route.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If
        If cboSeat.SelectedItem Is Nothing Then
            MessageBox.Show("Please select an available seat.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        Try
            Dim tripId As Integer = Convert.ToInt32(cboRoute.SelectedValue)
            Dim seatNum As Integer = Convert.ToInt32(cboSeat.SelectedItem)
            Dim rowView As DataRowView = CType(cboRoute.SelectedItem, DataRowView)
            Dim price As Decimal = Convert.ToDecimal(rowView("Price"))

            Using conn As New SqlConnection(DatabaseHelper.ConnString)
                conn.Open()

                ' Verify double booking
                Dim checkCmd As New SqlCommand("SELECT COUNT(*) FROM Bookings WHERE TripId = @TripId AND SeatNumber = @Seat", conn)
                checkCmd.Parameters.AddWithValue("@TripId", tripId)
                checkCmd.Parameters.AddWithValue("@Seat", seatNum)
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
                    MessageBox.Show("This trip is fully booked! (Over-capacity prevented)", "Booking Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Return
                End If

                ' Insert booking
                Dim insertSql As String = "
                    INSERT INTO Bookings (TripId, PassengerName, Phone, SeatNumber, TotalPrice, BookingDate) 
                    VALUES (@TripId, @Name, @Phone, @Seat, @Price, GETDATE())"
                Using cmd As New SqlCommand(insertSql, conn)
                    cmd.Parameters.AddWithValue("@TripId", tripId)
                    cmd.Parameters.AddWithValue("@Name", txtPassengerName.Text.Trim())
                    cmd.Parameters.AddWithValue("@Phone", txtPhone.Text.Trim())
                    cmd.Parameters.AddWithValue("@Seat", seatNum)
                    cmd.Parameters.AddWithValue("@Price", price)
                    cmd.ExecuteNonQuery()
                End Using
            End Using

            MessageBox.Show("Booking successfully registered!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
            LoadBookings()
            ClearInputs()
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

        If String.IsNullOrWhiteSpace(txtPassengerName.Text) Then
            MessageBox.Show("Please enter passenger name.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If
        If String.IsNullOrWhiteSpace(txtPhone.Text) Then
            MessageBox.Show("Please enter phone number.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If
        If cboRoute.SelectedValue Is Nothing Then
            MessageBox.Show("Please select a route.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If
        If cboSeat.SelectedItem Is Nothing Then
            MessageBox.Show("Please select an available seat.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        Try
            Dim tripId As Integer = Convert.ToInt32(cboRoute.SelectedValue)
            Dim seatNum As Integer = Convert.ToInt32(cboSeat.SelectedItem)
            Dim rowView As DataRowView = CType(cboRoute.SelectedItem, DataRowView)
            Dim price As Decimal = Convert.ToDecimal(rowView("Price"))

            Using conn As New SqlConnection(DatabaseHelper.ConnString)
                conn.Open()

                ' Double booking check
                Dim checkCmd As New SqlCommand("SELECT COUNT(*) FROM Bookings WHERE TripId = @TripId AND SeatNumber = @Seat AND TicketId <> @TicketId", conn)
                checkCmd.Parameters.AddWithValue("@TripId", tripId)
                checkCmd.Parameters.AddWithValue("@Seat", seatNum)
                checkCmd.Parameters.AddWithValue("@TicketId", ticketIdVal)
                Dim isBooked As Integer = Convert.ToInt32(checkCmd.ExecuteScalar())
                If isBooked > 0 Then
                    MessageBox.Show("This seat is already booked for another passenger.", "Update Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Return
                End If

                ' Update booking details
                Dim updateSql As String = "
                    UPDATE Bookings 
                    SET TripId = @TripId, PassengerName = @Name, Phone = @Phone, SeatNumber = @Seat, TotalPrice = @Price 
                    WHERE TicketId = @TicketId"
                Using cmd As New SqlCommand(updateSql, conn)
                    cmd.Parameters.AddWithValue("@TripId", tripId)
                    cmd.Parameters.AddWithValue("@Name", txtPassengerName.Text.Trim())
                    cmd.Parameters.AddWithValue("@Phone", txtPhone.Text.Trim())
                    cmd.Parameters.AddWithValue("@Seat", seatNum)
                    cmd.Parameters.AddWithValue("@Price", price)
                    cmd.Parameters.AddWithValue("@TicketId", ticketIdVal)
                    cmd.ExecuteNonQuery()
                End Using
            End Using

            MessageBox.Show("Booking details successfully updated!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
            LoadBookings()
            ClearInputs()
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

    Private Sub cmdClose_Click(sender As Object, e As EventArgs) Handles cmdClose.Click
        Me.Close()
    End Sub
End Class