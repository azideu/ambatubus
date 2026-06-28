Imports System
Imports System.Data
Imports System.Drawing
Imports Microsoft.Data.SqlClient
Imports System.Windows.Forms

Public Class frmAdmin
    Private ReadOnly FamousCities As String() = {
        "Kuala Lumpur", "Penang", "Johor Bahru", "Ipoh", "Malacca",
        "Kuala Terengganu", "Kuantan", "Alor Setar", "Kota Bharu", "Seremban"
    }

    Private Sub frmAdmin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ThemeManager.ApplyTheme(Me)
        ' Populate dropdowns
        cboFrom.Items.Clear()
        cboTo.Items.Clear()
        For Each city In FamousCities
            cboFrom.Items.Add(city)
            cboTo.Items.Add(city)
        Next

        LoadBuses()
        LoadSchedules()
        ClearInputs()
    End Sub

    Private Sub LoadBuses()
        Try
            Using conn As New SqlConnection(DatabaseHelper.ConnString)
                conn.Open()
                Dim query As String = "SELECT BusId, BusName + ' (' + LayoutType + ', ' + CAST(SeatCapacity AS NVARCHAR) + ' seats)' AS DisplayName FROM Buses ORDER BY BusName"
                Dim cmd As New SqlCommand(query, conn)
                Dim dt As New DataTable()
                dt.Load(cmd.ExecuteReader())
                
                cboBus.DisplayMember = "DisplayName"
                cboBus.ValueMember = "BusId"
                cboBus.DataSource = dt
                cboBus.SelectedIndex = -1
            End Using
        Catch ex As Exception
            MessageBox.Show("Error loading buses: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub LoadSchedules()
        Try
            Using conn As New SqlConnection(DatabaseHelper.ConnString)
                conn.Open()
                Dim query As String = "SELECT s.TripId As [Trip ID], s.RouteName As [Route Name], s.DepartureTime As [Departure Time], s.Price As [Price (RM)], b.BusName As [Bus], s.BusId FROM Schedules s INNER JOIN Buses b ON s.BusId = b.BusId WHERE 1=1"
                Dim filter As String = txtSearchRoute.Text.Trim()
                If Not String.IsNullOrEmpty(filter) Then
                    query &= " AND s.RouteName LIKE @Filter"
                End If
                query &= " ORDER BY s.DepartureTime"

                Dim cmd As New SqlCommand(query, conn)
                If Not String.IsNullOrEmpty(filter) Then
                    cmd.Parameters.AddWithValue("@Filter", "%" & filter & "%")
                End If

                Dim da As New SqlDataAdapter(cmd)
                Dim dt As New DataTable()
                da.Fill(dt)
                dgvSchedules.DataSource = dt
                
                If dgvSchedules.Columns.Contains("BusId") Then
                    dgvSchedules.Columns("BusId").Visible = False
                End If
            End Using
        Catch ex As Exception
            MessageBox.Show("Error loading schedules: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub txtSearchRoute_TextChanged(sender As Object, e As EventArgs) Handles txtSearchRoute.TextChanged
        LoadSchedules()
    End Sub

    Private Sub dgvSchedules_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvSchedules.CellClick
        If e.RowIndex >= 0 Then
            Dim row As DataGridViewRow = dgvSchedules.Rows(e.RowIndex)
            txtTripId.Text = row.Cells("Trip ID").Value.ToString()

            ' Parse route string "Origin to Destination"
            Dim routeName As String = row.Cells("Route Name").Value.ToString()
            Dim parts As String() = routeName.Split(New String() {" to "}, StringSplitOptions.None)
            If parts.Length = 2 Then
                cboFrom.SelectedItem = parts(0)
                cboTo.SelectedItem = parts(1)
            Else
                cboFrom.SelectedIndex = -1
                cboTo.SelectedIndex = -1
            End If

            dtpDeparture.Value = Convert.ToDateTime(row.Cells("Departure Time").Value)
            txtPrice.Text = Convert.ToDecimal(row.Cells("Price (RM)").Value).ToString("F2")
            If row.Cells("BusId").Value IsNot DBNull.Value Then
                cboBus.SelectedValue = Convert.ToInt32(row.Cells("BusId").Value)
            End If
        End If
    End Sub

    Private Sub ClearInputs()
        txtTripId.Clear()
        cboFrom.SelectedIndex = -1
        cboTo.SelectedIndex = -1
        dtpDeparture.Value = DateTime.Now.AddDays(1)
        txtPrice.Clear()
        cboBus.SelectedIndex = -1
    End Sub

    Private Sub cmdAdd_Click(sender As Object, e As EventArgs) Handles cmdAdd.Click
        If cboFrom.SelectedIndex = -1 OrElse cboTo.SelectedIndex = -1 Then
            MessageBox.Show("Please select both origin and destination cities.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        If cboFrom.SelectedItem.ToString() = cboTo.SelectedItem.ToString() Then
            MessageBox.Show("Origin and destination cities cannot be the same.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        Dim priceVal As Decimal
        If Not Decimal.TryParse(txtPrice.Text, priceVal) OrElse priceVal <= 0 Then
            MessageBox.Show("Please enter a valid price greater than 0.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        If cboBus.SelectedValue Is Nothing Then
            MessageBox.Show("Please select a bus.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If
        
        Dim busIdVal As Integer = Convert.ToInt32(cboBus.SelectedValue)

        If dtpDeparture.Value < DateTime.Now.AddHours(1) Then
            MessageBox.Show("Departure time must be at least 1 hour in the future.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        Dim routeName As String = $"{cboFrom.SelectedItem} to {cboTo.SelectedItem}"

        cmdAdd.Enabled = False
        Me.Cursor = Cursors.WaitCursor
        Application.DoEvents()

        Try
            Using conn As New SqlConnection(DatabaseHelper.ConnString)
                conn.Open()
                Dim insertSql As String = "
                    INSERT INTO Schedules (RouteName, DepartureTime, Price, BusId) 
                    VALUES (@Route, @DepTime, @Price, @BusId)"
                Using cmd As New SqlCommand(insertSql, conn)
                    cmd.Parameters.AddWithValue("@Route", routeName)
                    cmd.Parameters.AddWithValue("@DepTime", dtpDeparture.Value)
                    cmd.Parameters.AddWithValue("@Price", priceVal)
                    cmd.Parameters.AddWithValue("@BusId", busIdVal)
                    cmd.ExecuteNonQuery()
                End Using
            End Using

            MessageBox.Show("Bus schedule successfully created!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
            LoadSchedules()
            ClearInputs()
        Catch ex As Exception
            MessageBox.Show("Failed to create schedule: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            cmdAdd.Enabled = True
            Me.Cursor = Cursors.Default
        End Try
    End Sub

    Private Sub cmdUpdate_Click(sender As Object, e As EventArgs) Handles cmdUpdate.Click
        Dim tripIdVal As Integer
        If Not Integer.TryParse(txtTripId.Text, tripIdVal) Then
            MessageBox.Show("Please select a schedule from the list to update.", "Selection Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        If cboFrom.SelectedIndex = -1 OrElse cboTo.SelectedIndex = -1 Then
            MessageBox.Show("Please select both origin and destination cities.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        If cboFrom.SelectedItem.ToString() = cboTo.SelectedItem.ToString() Then
            MessageBox.Show("Origin and destination cities cannot be the same.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        Dim priceVal As Decimal
        If Not Decimal.TryParse(txtPrice.Text, priceVal) OrElse priceVal <= 0 Then
            MessageBox.Show("Please enter a valid price greater than 0.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        If cboBus.SelectedValue Is Nothing Then
            MessageBox.Show("Please select a bus.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If
        
        Dim busIdVal As Integer = Convert.ToInt32(cboBus.SelectedValue)

        If dtpDeparture.Value < DateTime.Now.AddHours(1) Then
            MessageBox.Show("Departure time must be at least 1 hour in the future.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        Dim routeName As String = $"{cboFrom.SelectedItem} to {cboTo.SelectedItem}"

        cmdUpdate.Enabled = False
        Me.Cursor = Cursors.WaitCursor
        Application.DoEvents()

        Try
            Using conn As New SqlConnection(DatabaseHelper.ConnString)
                conn.Open()

                ' Prevent updating capacity below current booked numbers
                Dim checkCmd As New SqlCommand("SELECT COUNT(*) FROM Bookings WHERE TripId = @TripId", conn)
                checkCmd.Parameters.AddWithValue("@TripId", tripIdVal)
                Dim bookedCount As Integer = Convert.ToInt32(checkCmd.ExecuteScalar())

                Dim busCapCmd As New SqlCommand("SELECT SeatCapacity FROM Buses WHERE BusId = @BusId", conn)
                busCapCmd.Parameters.AddWithValue("@BusId", busIdVal)
                Dim capacityVal As Integer = Convert.ToInt32(busCapCmd.ExecuteScalar())

                If capacityVal < bookedCount Then
                    MessageBox.Show($"Cannot decrease capacity below current bookings ({bookedCount} seats booked).", "Capacity Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    Return
                End If

                ' Prevent updating capacity below maximum booked seat number
                If bookedCount > 0 Then
                    Dim maxSeatCmd As New SqlCommand("SELECT MAX(SeatNumber) FROM Bookings WHERE TripId = @TripId", conn)
                    maxSeatCmd.Parameters.AddWithValue("@TripId", tripIdVal)
                    Dim maxSeat As Integer = Convert.ToInt32(maxSeatCmd.ExecuteScalar())
                    If capacityVal < maxSeat Then
                        MessageBox.Show($"Cannot decrease capacity to {capacityVal} because seat {maxSeat} is already booked.", "Capacity Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                        Return
                    End If
                End If

                Dim updateSql As String = "
                    UPDATE Schedules 
                    SET RouteName = @Route, DepartureTime = @DepTime, Price = @Price, BusId = @BusId 
                    WHERE TripId = @TripId"
                Using cmd As New SqlCommand(updateSql, conn)
                    cmd.Parameters.AddWithValue("@Route", routeName)
                    cmd.Parameters.AddWithValue("@DepTime", dtpDeparture.Value)
                    cmd.Parameters.AddWithValue("@Price", priceVal)
                    cmd.Parameters.AddWithValue("@BusId", busIdVal)
                    cmd.Parameters.AddWithValue("@TripId", tripIdVal)
                    cmd.ExecuteNonQuery()
                End Using
            End Using

            MessageBox.Show("Bus schedule successfully updated!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
            LoadSchedules()
            ClearInputs()
        Catch ex As Exception
            MessageBox.Show("Failed to update schedule: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            cmdUpdate.Enabled = True
            Me.Cursor = Cursors.Default
        End Try
    End Sub

    Private Sub cmdDelete_Click(sender As Object, e As EventArgs) Handles cmdDelete.Click
        Dim tripIdVal As Integer
        If Not Integer.TryParse(txtTripId.Text, tripIdVal) Then
            MessageBox.Show("Please select a schedule from the list to delete.", "Selection Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        Dim confirmResult = MessageBox.Show("Deleting this schedule will also cancel all associated bookings. Do you want to proceed?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)
        If confirmResult = DialogResult.Yes Then
            Try
                Using conn As New SqlConnection(DatabaseHelper.ConnString)
                    conn.Open()
                    Dim deleteSql As String = "DELETE FROM Schedules WHERE TripId = @TripId"
                    Using cmd As New SqlCommand(deleteSql, conn)
                        cmd.Parameters.AddWithValue("@TripId", tripIdVal)
                        cmd.ExecuteNonQuery()
                    End Using
                End Using

                MessageBox.Show("Schedule and all associated bookings deleted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                LoadSchedules()
                ClearInputs()
            Catch ex As Exception
                MessageBox.Show("Failed to delete schedule: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End If
    End Sub

    Private Sub cmdClose_Click(sender As Object, e As EventArgs) Handles cmdClose.Click
        Me.Close()
    End Sub

    ' Button Hover Effects
    Private Sub Button_MouseEnter(sender As Object, e As EventArgs) Handles cmdAdd.MouseEnter, cmdUpdate.MouseEnter, cmdDelete.MouseEnter, cmdClose.MouseEnter
        Dim btn As Button = CType(sender, Button)
        If btn Is cmdAdd Then
            btn.BackColor = ThemeManager.CurrentTheme.ButtonPrimaryHover
        ElseIf btn Is cmdUpdate Then
            btn.BackColor = ThemeManager.CurrentTheme.ButtonSecondaryHover
        ElseIf btn Is cmdDelete Then
            btn.BackColor = ThemeManager.CurrentTheme.ButtonDangerHover
        ElseIf btn Is cmdClose Then
            btn.BackColor = ThemeManager.CurrentTheme.ButtonNeutralHover
        End If
    End Sub

    Private Sub Button_MouseLeave(sender As Object, e As EventArgs) Handles cmdAdd.MouseLeave, cmdUpdate.MouseLeave, cmdDelete.MouseLeave, cmdClose.MouseLeave
        Dim btn As Button = CType(sender, Button)
        If btn Is cmdAdd Then
            btn.BackColor = ThemeManager.CurrentTheme.ButtonPrimary
        ElseIf btn Is cmdUpdate Then
            btn.BackColor = ThemeManager.CurrentTheme.ButtonSecondary
        ElseIf btn Is cmdDelete Then
            btn.BackColor = ThemeManager.CurrentTheme.ButtonDanger
        ElseIf btn Is cmdClose Then
            btn.BackColor = ThemeManager.CurrentTheme.ButtonNeutral
        End If
    End Sub
End Class