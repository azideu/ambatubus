Imports System
Imports System.Drawing
Imports System.Text.RegularExpressions
Imports System.Windows.Forms

Public Class frmRegister

    Private Sub frmRegister_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtFullName.Focus()
    End Sub

    Private Sub cmdRegister_Click(sender As Object, e As EventArgs) Handles cmdRegister.Click
        Dim fullName As String = txtFullName.Text.Trim()
        Dim phone As String = txtPhone.Text.Trim()
        Dim email As String = txtEmail.Text.Trim()
        Dim ic As String = txtIC.Text.Trim()
        Dim username As String = txtUsername.Text.Trim()
        Dim password As String = txtPassword.Text
        Dim confirm As String = txtConfirmPassword.Text

        ' --- Validation ---
        If String.IsNullOrWhiteSpace(fullName) Then
            ShowError("Please enter your full name.") : Return
        End If
        If Not Regex.IsMatch(fullName, "^[a-zA-Z\s\.\-']+$") Then
            ShowError("Full name can only contain letters, spaces, hyphens, and apostrophes.") : Return
        End If
        If String.IsNullOrWhiteSpace(phone) Then
            ShowError("Please enter your phone number.") : Return
        End If
        If Not Regex.IsMatch(phone, "^(\+?60|0)\d{8,10}$") Then
            ShowError("Please enter a valid Malaysian phone number (e.g. 0123456789).") : Return
        End If
        If Not String.IsNullOrWhiteSpace(email) AndAlso Not Regex.IsMatch(email, "^[^@\s]+@[^@\s]+\.[^@\s]+$") Then
            ShowError("Please enter a valid email address.") : Return
        End If
        If String.IsNullOrWhiteSpace(username) Then
            ShowError("Please choose a username.") : Return
        End If
        If username.Length < 3 Then
            ShowError("Username must be at least 3 characters long.") : Return
        End If
        If Not Regex.IsMatch(username, "^[a-zA-Z0-9_\.]+$") Then
            ShowError("Username can only contain letters, numbers, underscores, and dots.") : Return
        End If
        If String.IsNullOrWhiteSpace(password) Then
            ShowError("Please enter a password.") : Return
        End If
        If password.Length < 6 Then
            ShowError("Password must be at least 6 characters long.") : Return
        End If
        If password <> confirm Then
            ShowError("Passwords do not match. Please try again.")
            txtConfirmPassword.Clear()
            txtConfirmPassword.Focus()
            Return
        End If

        ' --- Database registration ---
        Dim errorMsg As String = DatabaseHelper.RegisterUser(fullName, phone, username, password, email, ic)

        If String.IsNullOrEmpty(errorMsg) Then
            ' Auto-login after registration
            Dim newId As Integer = DatabaseHelper.LoginUser(username, password)
            If newId > 0 Then
                SessionManager.Login(newId, fullName, phone)
            End If
            MessageBox.Show($"Welcome, {fullName}! Your account has been created successfully.",
                            "Registration Successful", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Me.DialogResult = DialogResult.OK
            Me.Close()
        Else
            ShowError(errorMsg)
        End If
    End Sub

    Private Sub cmdCancel_Click(sender As Object, e As EventArgs) Handles cmdCancel.Click
        Me.DialogResult = DialogResult.Cancel
        Me.Close()
    End Sub

    Private Sub lnkLogin_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles lnkLogin.LinkClicked
        Me.DialogResult = DialogResult.Cancel
        Me.Close()
    End Sub

    Private Sub ShowError(message As String)
        MessageBox.Show(message, "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
    End Sub

    ' Hover effects
    Private Sub cmdRegister_MouseEnter(sender As Object, e As EventArgs) Handles cmdRegister.MouseEnter
        cmdRegister.BackColor = Color.FromArgb(50, 150, 210)
    End Sub
    Private Sub cmdRegister_MouseLeave(sender As Object, e As EventArgs) Handles cmdRegister.MouseLeave
        cmdRegister.BackColor = Color.FromArgb(30, 130, 190)
    End Sub
    Private Sub cmdCancel_MouseEnter(sender As Object, e As EventArgs) Handles cmdCancel.MouseEnter
        cmdCancel.BackColor = Color.FromArgb(85, 95, 90)
    End Sub
    Private Sub cmdCancel_MouseLeave(sender As Object, e As EventArgs) Handles cmdCancel.MouseLeave
        cmdCancel.BackColor = Color.FromArgb(65, 75, 70)
    End Sub

End Class
