Imports System
Imports System.Data
Imports System.Drawing
Imports Microsoft.Data.SqlClient
Imports System.Windows.Forms

Public Class frmManageBuses

    Private Sub frmManageBuses_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ThemeManager.ApplyTheme(Me)
        LoadBuses()
        ClearInputs()
    End Sub

    Private Sub LoadBuses()
        Try
            Using conn As New SqlConnection(DatabaseHelper.ConnString)
                conn.Open()
                Dim query As String = "SELECT BusId As [Bus ID], BusName As [Bus Name], LayoutType As [Layout Type], SeatCapacity As [Seat Capacity] FROM Buses ORDER BY BusId"
                Dim da As New SqlDataAdapter(query, conn)
                Dim dt As New DataTable()
                da.Fill(dt)
                dgvBuses.DataSource = dt
            End Using
        Catch ex As Exception
            MessageBox.Show("Error loading buses: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub dgvBuses_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvBuses.CellClick
        If e.RowIndex >= 0 Then
            Dim row As DataGridViewRow = dgvBuses.Rows(e.RowIndex)
            txtBusId.Text = row.Cells("Bus ID").Value.ToString()
            txtBusName.Text = row.Cells("Bus Name").Value.ToString()
            cboLayoutType.SelectedItem = row.Cells("Layout Type").Value.ToString()
            txtCapacity.Text = row.Cells("Seat Capacity").Value.ToString()
        End If
    End Sub

    Private Sub ClearInputs()
        txtBusId.Clear()
        txtBusName.Clear()
        cboLayoutType.SelectedIndex = -1
        txtCapacity.Clear()
    End Sub

    Private Sub cmdAdd_Click(sender As Object, e As EventArgs) Handles cmdAdd.Click
        Dim busName As String = txtBusName.Text.Trim()
        If String.IsNullOrWhiteSpace(busName) Then
            MessageBox.Show("Please enter a Bus Name.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        If cboLayoutType.SelectedIndex = -1 Then
            MessageBox.Show("Please select a Layout Type.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        Dim capacityVal As Integer
        If Not Integer.TryParse(txtCapacity.Text, capacityVal) OrElse capacityVal <= 0 Then
            MessageBox.Show("Please enter a valid seat capacity greater than 0.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        cmdAdd.Enabled = False
        Me.Cursor = Cursors.WaitCursor
        Application.DoEvents()

        Try
            Using conn As New SqlConnection(DatabaseHelper.ConnString)
                conn.Open()
                Dim insertSql As String = "INSERT INTO Buses (BusName, LayoutType, SeatCapacity) VALUES (@Name, @Layout, @Capacity)"
                Using cmd As New SqlCommand(insertSql, conn)
                    cmd.Parameters.AddWithValue("@Name", busName)
                    cmd.Parameters.AddWithValue("@Layout", cboLayoutType.SelectedItem.ToString())
                    cmd.Parameters.AddWithValue("@Capacity", capacityVal)
                    cmd.ExecuteNonQuery()
                End Using
            End Using

            MessageBox.Show("Bus successfully added!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
            LoadBuses()
            ClearInputs()
        Catch ex As Exception
            MessageBox.Show("Failed to add bus: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            cmdAdd.Enabled = True
            Me.Cursor = Cursors.Default
        End Try
    End Sub

    Private Sub cmdUpdate_Click(sender As Object, e As EventArgs) Handles cmdUpdate.Click
        Dim busIdVal As Integer
        If Not Integer.TryParse(txtBusId.Text, busIdVal) Then
            MessageBox.Show("Please select a bus from the list to update.", "Selection Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        Dim busName As String = txtBusName.Text.Trim()
        If String.IsNullOrWhiteSpace(busName) Then
            MessageBox.Show("Please enter a Bus Name.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        If cboLayoutType.SelectedIndex = -1 Then
            MessageBox.Show("Please select a Layout Type.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        Dim capacityVal As Integer
        If Not Integer.TryParse(txtCapacity.Text, capacityVal) OrElse capacityVal <= 0 Then
            MessageBox.Show("Please enter a valid seat capacity greater than 0.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        cmdUpdate.Enabled = False
        Me.Cursor = Cursors.WaitCursor
        Application.DoEvents()

        Try
            Using conn As New SqlConnection(DatabaseHelper.ConnString)
                conn.Open()
                Dim updateSql As String = "UPDATE Buses SET BusName = @Name, LayoutType = @Layout, SeatCapacity = @Capacity WHERE BusId = @Id"
                Using cmd As New SqlCommand(updateSql, conn)
                    cmd.Parameters.AddWithValue("@Name", busName)
                    cmd.Parameters.AddWithValue("@Layout", cboLayoutType.SelectedItem.ToString())
                    cmd.Parameters.AddWithValue("@Capacity", capacityVal)
                    cmd.Parameters.AddWithValue("@Id", busIdVal)
                    cmd.ExecuteNonQuery()
                End Using
            End Using

            MessageBox.Show("Bus successfully updated!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
            LoadBuses()
            ClearInputs()
        Catch ex As Exception
            MessageBox.Show("Failed to update bus: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            cmdUpdate.Enabled = True
            Me.Cursor = Cursors.Default
        End Try
    End Sub

    Private Sub cmdDelete_Click(sender As Object, e As EventArgs) Handles cmdDelete.Click
        Dim busIdVal As Integer
        If Not Integer.TryParse(txtBusId.Text, busIdVal) Then
            MessageBox.Show("Please select a bus from the list to delete.", "Selection Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        Dim confirmResult = MessageBox.Show("Deleting this bus will also delete all associated schedules and bookings. Do you want to proceed?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)
        If confirmResult = DialogResult.Yes Then
            Try
                Using conn As New SqlConnection(DatabaseHelper.ConnString)
                    conn.Open()
                    Dim deleteSql As String = "DELETE FROM Buses WHERE BusId = @Id"
                    Using cmd As New SqlCommand(deleteSql, conn)
                        cmd.Parameters.AddWithValue("@Id", busIdVal)
                        cmd.ExecuteNonQuery()
                    End Using
                End Using

                MessageBox.Show("Bus deleted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                LoadBuses()
                ClearInputs()
            Catch ex As Exception
                MessageBox.Show("Failed to delete bus: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
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
