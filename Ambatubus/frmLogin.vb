Imports System
Imports System.Data
Imports System.Drawing
Imports Microsoft.Data.SqlClient
Imports System.Windows.Forms

Public Class frmLogin
    Private Sub frmLogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            Dim assetPath As String = System.IO.Path.Combine(Application.StartupPath, "Assets", "login_logo.png")
            If System.IO.File.Exists(assetPath) Then
                picLogo.Image = Image.FromFile(assetPath)
            End If
        Catch ex As Exception
            ' Silent fail
        End Try
    End Sub

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

    ' Button Hover Effects
    Private Sub Button_MouseEnter(sender As Object, e As EventArgs) Handles cmdLogin.MouseEnter, cmdCancel.MouseEnter
        Dim btn As Button = CType(sender, Button)
        If btn Is cmdLogin Then
            btn.BackColor = Color.FromArgb(35, 175, 105)
        ElseIf btn Is cmdCancel Then
            btn.BackColor = Color.FromArgb(85, 95, 90)
        End If
    End Sub

    Private Sub Button_MouseLeave(sender As Object, e As EventArgs) Handles cmdLogin.MouseLeave, cmdCancel.MouseLeave
        Dim btn As Button = CType(sender, Button)
        If btn Is cmdLogin Then
            btn.BackColor = Color.FromArgb(20, 150, 85)
        ElseIf btn Is cmdCancel Then
            btn.BackColor = Color.FromArgb(65, 75, 70)
        End If
    End Sub
End Class
