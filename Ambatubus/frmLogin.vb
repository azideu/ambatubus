Imports System
Imports System.Data
Imports Microsoft.Data.SqlClient
Imports System.Windows.Forms

Public Class frmLogin
    Private Sub cmdLogin_Click(sender As Object, e As EventArgs) Handles cmdLogin.Click
        Dim username As String = txtUsername.Text.Trim()
        Dim password As String = txtPassword.Text

        If String.IsNullOrWhiteSpace(username) OrElse String.IsNullOrWhiteSpace(password) Then
            MessageBox.Show("Please enter both username and password.", "Login Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        Try
            Using conn As New SqlConnection(DatabaseHelper.ConnString)
                conn.Open()
                Dim query As String = "SELECT PasswordHash FROM Admins WHERE Username = @Username"
                Using cmd As New SqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@Username", username)
                    Dim dbHash As Object = cmd.ExecuteScalar()

                    If dbHash IsNot Nothing AndAlso dbHash IsNot DBNull.Value Then
                        Dim inputHash As String = DatabaseHelper.HashPassword(password)
                        If dbHash.ToString().Equals(inputHash, StringComparison.OrdinalIgnoreCase) Then
                            Me.DialogResult = DialogResult.OK
                            Me.Close()
                            Return
                        End If
                    End If
                End Using
            End Using

            MessageBox.Show("Invalid username or password.", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtPassword.Clear()
            txtPassword.Focus()
        Catch ex As Exception
            MessageBox.Show("Login database query failed: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub cmdCancel_Click(sender As Object, e As EventArgs) Handles cmdCancel.Click
        Me.DialogResult = DialogResult.Cancel
        Me.Close()
    End Sub
End Class
