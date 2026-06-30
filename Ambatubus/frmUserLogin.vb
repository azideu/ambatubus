Imports System
Imports System.Drawing
Imports System.Windows.Forms

Public Class frmUserLogin

    Private Sub frmUserLogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtUsername.Focus()
    End Sub

    Private Sub cmdLogin_Click(sender As Object, e As EventArgs) Handles cmdLogin.Click
        Dim username As String = txtUsername.Text.Trim()
        Dim password As String = txtPassword.Text

        If String.IsNullOrWhiteSpace(username) OrElse String.IsNullOrWhiteSpace(password) Then
            MessageBox.Show("Please enter both username and password.", "Login Error",
                            MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        Dim result As Integer = DatabaseHelper.LoginUser(username, password)

        Select Case result
            Case -2
                MessageBox.Show("Your account has been blocked. Please contact support.", "Account Blocked",
                                MessageBoxButtons.OK, MessageBoxIcon.Error)
            Case -1
                MessageBox.Show("Incorrect username or password. Please try again.", "Login Failed",
                                MessageBoxButtons.OK, MessageBoxIcon.Error)
                txtPassword.Clear()
                txtPassword.Focus()
            Case Else
                ' Success — populate session
                Dim name As String = DatabaseHelper.GetPassengerName(result)
                Dim phone As String = DatabaseHelper.GetPassengerPhone(result)
                SessionManager.Login(result, name, phone)
                Me.DialogResult = DialogResult.OK
                Me.Close()
        End Select
    End Sub

    Private Sub cmdCancel_Click(sender As Object, e As EventArgs) Handles cmdCancel.Click
        Me.DialogResult = DialogResult.Cancel
        Me.Close()
    End Sub

    Private Sub lnkRegister_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles lnkRegister.LinkClicked
        Me.Hide()
        Dim regForm As New frmRegister()
        regForm.ShowDialog()
        ' If registration succeeded and auto-logged in, close this form too
        If SessionManager.IsLoggedIn Then
            Me.DialogResult = DialogResult.OK
            Me.Close()
        Else
            Me.Show()
            txtUsername.Focus()
        End If
    End Sub

    ' Hover effects
    Private Sub cmdLogin_MouseEnter(sender As Object, e As EventArgs) Handles cmdLogin.MouseEnter
        cmdLogin.BackColor = Color.FromArgb(35, 175, 105)
    End Sub
    Private Sub cmdLogin_MouseLeave(sender As Object, e As EventArgs) Handles cmdLogin.MouseLeave
        cmdLogin.BackColor = Color.FromArgb(20, 150, 85)
    End Sub
    Private Sub cmdCancel_MouseEnter(sender As Object, e As EventArgs) Handles cmdCancel.MouseEnter
        cmdCancel.BackColor = Color.FromArgb(85, 95, 90)
    End Sub
    Private Sub cmdCancel_MouseLeave(sender As Object, e As EventArgs) Handles cmdCancel.MouseLeave
        cmdCancel.BackColor = Color.FromArgb(65, 75, 70)
    End Sub

End Class
