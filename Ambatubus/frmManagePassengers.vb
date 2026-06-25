Imports System
Imports System.Data
Imports System.Drawing
Imports Microsoft.Data.SqlClient
Imports System.Windows.Forms

Public Class frmManagePassengers

    Private Sub frmManagePassengers_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadPassengers()
        ClearInputs()
    End Sub

    Private Sub LoadPassengers()
        Try
            Using conn As New SqlConnection(DatabaseHelper.ConnString)
                conn.Open()
                Dim query As String = "SELECT PassengerId As [ID], FullName As [Name], Phone As [Phone No], IsBlocked As [Blocked] FROM Passengers WHERE 1=1"
                Dim filter As String = txtSearchName.Text.Trim()
                If Not String.IsNullOrEmpty(filter) Then
                    query &= " AND (FullName LIKE @Filter OR Phone LIKE @Filter)"
                End If
                query &= " ORDER BY PassengerId DESC"

                Dim cmd As New SqlCommand(query, conn)
                If Not String.IsNullOrEmpty(filter) Then
                    cmd.Parameters.AddWithValue("@Filter", "%" & filter & "%")
                End If

                Dim da As New SqlDataAdapter(cmd)
                Dim dt As New DataTable()
                da.Fill(dt)
                dgvPassengers.DataSource = dt
            End Using
        Catch ex As Exception
            MessageBox.Show("Error loading passengers: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub txtSearchName_TextChanged(sender As Object, e As EventArgs) Handles txtSearchName.TextChanged
        LoadPassengers()
    End Sub

    Private Sub dgvPassengers_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvPassengers.CellClick
        If e.RowIndex >= 0 Then
            Dim row As DataGridViewRow = dgvPassengers.Rows(e.RowIndex)
            txtPassengerId.Text = row.Cells("ID").Value.ToString()
            txtFullName.Text = row.Cells("Name").Value.ToString()
            txtPhone.Text = row.Cells("Phone No").Value.ToString()
            
            Dim isBlockedVal As Object = row.Cells("Blocked").Value
            If isBlockedVal IsNot DBNull.Value AndAlso isBlockedVal IsNot Nothing Then
                chkIsBlocked.Checked = Convert.ToBoolean(isBlockedVal)
            Else
                chkIsBlocked.Checked = False
            End If
        End If
    End Sub

    Private Sub ClearInputs()
        txtPassengerId.Clear()
        txtFullName.Clear()
        txtPhone.Clear()
        chkIsBlocked.Checked = False
    End Sub

    Private Sub cmdUpdate_Click(sender As Object, e As EventArgs) Handles cmdUpdate.Click
        Dim passIdVal As Integer
        If Not Integer.TryParse(txtPassengerId.Text, passIdVal) Then
            MessageBox.Show("Please select a passenger from the list to update.", "Selection Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        Dim name As String = txtFullName.Text.Trim()
        Dim phone As String = txtPhone.Text.Trim()

        If String.IsNullOrWhiteSpace(name) Then
            MessageBox.Show("Please enter passenger name.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        If Not System.Text.RegularExpressions.Regex.IsMatch(name, "^[a-zA-Z\s]+$") Then
            MessageBox.Show("Passenger name can only contain letters and spaces.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        If String.IsNullOrWhiteSpace(phone) Then
            MessageBox.Show("Please enter phone number.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        If Not System.Text.RegularExpressions.Regex.IsMatch(phone, "^(01|\+601)[0-9]{7,9}$") Then
            MessageBox.Show("Please enter a valid Malaysian phone number.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        cmdUpdate.Enabled = False
        Me.Cursor = Cursors.WaitCursor
        Application.DoEvents()

        Try
            Using conn As New SqlConnection(DatabaseHelper.ConnString)
                conn.Open()
                
                ' Check if phone already exists for another passenger
                Dim checkCmd As New SqlCommand("SELECT COUNT(*) FROM Passengers WHERE Phone = @Phone AND PassengerId <> @PassId", conn)
                checkCmd.Parameters.AddWithValue("@Phone", phone)
                checkCmd.Parameters.AddWithValue("@PassId", passIdVal)
                Dim count As Integer = Convert.ToInt32(checkCmd.ExecuteScalar())
                If count > 0 Then
                    MessageBox.Show("This phone number is already registered to another passenger.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    Return
                End If

                Dim updateSql As String = "UPDATE Passengers SET FullName = @Name, Phone = @Phone, IsBlocked = @Blocked WHERE PassengerId = @PassId"
                Using cmd As New SqlCommand(updateSql, conn)
                    cmd.Parameters.AddWithValue("@Name", name)
                    cmd.Parameters.AddWithValue("@Phone", phone)
                    cmd.Parameters.AddWithValue("@Blocked", chkIsBlocked.Checked)
                    cmd.Parameters.AddWithValue("@PassId", passIdVal)
                    cmd.ExecuteNonQuery()
                End Using
            End Using

            MessageBox.Show("Passenger details updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
            LoadPassengers()
            ClearInputs()
        Catch ex As Exception
            MessageBox.Show("Failed to update passenger: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            cmdUpdate.Enabled = True
            Me.Cursor = Cursors.Default
        End Try
    End Sub

    Private Sub cmdClose_Click(sender As Object, e As EventArgs) Handles cmdClose.Click
        Me.Close()
    End Sub

    ' Button Hover Effects
    Private Sub Button_MouseEnter(sender As Object, e As EventArgs) Handles cmdUpdate.MouseEnter, cmdClose.MouseEnter
        Dim btn As Button = CType(sender, Button)
        If btn Is cmdUpdate Then
            btn.BackColor = Color.FromArgb(50, 150, 210)
        ElseIf btn Is cmdClose Then
            btn.BackColor = Color.FromArgb(85, 95, 90)
        End If
    End Sub

    Private Sub Button_MouseLeave(sender As Object, e As EventArgs) Handles cmdUpdate.MouseLeave, cmdClose.MouseLeave
        Dim btn As Button = CType(sender, Button)
        If btn Is cmdUpdate Then
            btn.BackColor = Color.FromArgb(30, 130, 190)
        ElseIf btn Is cmdClose Then
            btn.BackColor = Color.FromArgb(65, 75, 70)
        End If
    End Sub
End Class
