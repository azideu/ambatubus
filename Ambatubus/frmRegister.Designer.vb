<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmRegister
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
        Me.pnlHeader = New System.Windows.Forms.Panel()
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.lblSubtitle = New System.Windows.Forms.Label()
        Me.pnlForm = New System.Windows.Forms.Panel()
        Me.lblFullName = New System.Windows.Forms.Label()
        Me.txtFullName = New System.Windows.Forms.TextBox()
        Me.lblPhone = New System.Windows.Forms.Label()
        Me.txtPhone = New System.Windows.Forms.TextBox()
        Me.lblEmail = New System.Windows.Forms.Label()
        Me.txtEmail = New System.Windows.Forms.TextBox()
        Me.lblIC = New System.Windows.Forms.Label()
        Me.txtIC = New System.Windows.Forms.TextBox()
        Me.lblUsername = New System.Windows.Forms.Label()
        Me.txtUsername = New System.Windows.Forms.TextBox()
        Me.lblPassword = New System.Windows.Forms.Label()
        Me.txtPassword = New System.Windows.Forms.TextBox()
        Me.lblConfirmPassword = New System.Windows.Forms.Label()
        Me.txtConfirmPassword = New System.Windows.Forms.TextBox()
        Me.cmdRegister = New System.Windows.Forms.Button()
        Me.cmdCancel = New System.Windows.Forms.Button()
        Me.lblHaveAccount = New System.Windows.Forms.Label()
        Me.lnkLogin = New System.Windows.Forms.LinkLabel()
        Me.pnlHeader.SuspendLayout()
        Me.pnlForm.SuspendLayout()
        Me.SuspendLayout()
        '
        'pnlHeader
        '
        Me.pnlHeader.BackColor = System.Drawing.Color.FromArgb(20, 110, 60)
        Me.pnlHeader.Controls.Add(Me.lblTitle)
        Me.pnlHeader.Controls.Add(Me.lblSubtitle)
        Me.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlHeader.Location = New System.Drawing.Point(0, 0)
        Me.pnlHeader.Name = "pnlHeader"
        Me.pnlHeader.Size = New System.Drawing.Size(480, 100)
        '
        'lblTitle
        '
        Me.lblTitle.AutoSize = True
        Me.lblTitle.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Bold)
        Me.lblTitle.ForeColor = System.Drawing.Color.White
        Me.lblTitle.Location = New System.Drawing.Point(20, 15)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Text = "Create an Account"
        '
        'lblSubtitle
        '
        Me.lblSubtitle.AutoSize = True
        Me.lblSubtitle.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.lblSubtitle.ForeColor = System.Drawing.Color.FromArgb(180, 235, 205)
        Me.lblSubtitle.Location = New System.Drawing.Point(22, 63)
        Me.lblSubtitle.Name = "lblSubtitle"
        Me.lblSubtitle.Text = "Register to start booking your bus tickets"
        '
        'pnlForm
        '
        Me.pnlForm.AutoScroll = True
        Me.pnlForm.BackColor = System.Drawing.Color.FromArgb(30, 37, 33)
        Me.pnlForm.Controls.Add(Me.lblFullName)
        Me.pnlForm.Controls.Add(Me.txtFullName)
        Me.pnlForm.Controls.Add(Me.lblPhone)
        Me.pnlForm.Controls.Add(Me.txtPhone)
        Me.pnlForm.Controls.Add(Me.lblEmail)
        Me.pnlForm.Controls.Add(Me.txtEmail)
        Me.pnlForm.Controls.Add(Me.lblIC)
        Me.pnlForm.Controls.Add(Me.txtIC)
        Me.pnlForm.Controls.Add(Me.lblUsername)
        Me.pnlForm.Controls.Add(Me.txtUsername)
        Me.pnlForm.Controls.Add(Me.lblPassword)
        Me.pnlForm.Controls.Add(Me.txtPassword)
        Me.pnlForm.Controls.Add(Me.lblConfirmPassword)
        Me.pnlForm.Controls.Add(Me.txtConfirmPassword)
        Me.pnlForm.Controls.Add(Me.cmdRegister)
        Me.pnlForm.Controls.Add(Me.cmdCancel)
        Me.pnlForm.Controls.Add(Me.lblHaveAccount)
        Me.pnlForm.Controls.Add(Me.lnkLogin)
        Me.pnlForm.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlForm.Location = New System.Drawing.Point(0, 100)
        Me.pnlForm.Name = "pnlForm"
        Me.pnlForm.Size = New System.Drawing.Size(480, 500)
        '
        ' --- Row helpers (X=25, width=200 for left col, X=250 for right col) ---
        '
        'lblFullName
        '
        Me.lblFullName.AutoSize = True
        Me.lblFullName.Font = New System.Drawing.Font("Segoe UI", 8.5!, System.Drawing.FontStyle.Bold)
        Me.lblFullName.ForeColor = System.Drawing.Color.FromArgb(140, 160, 150)
        Me.lblFullName.Location = New System.Drawing.Point(25, 22)
        Me.lblFullName.Name = "lblFullName"
        Me.lblFullName.Text = "FULL NAME *"
        '
        'txtFullName
        '
        Me.txtFullName.BackColor = System.Drawing.Color.FromArgb(42, 52, 46)
        Me.txtFullName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtFullName.Font = New System.Drawing.Font("Segoe UI", 10.5!)
        Me.txtFullName.ForeColor = System.Drawing.Color.FromArgb(220, 235, 225)
        Me.txtFullName.Location = New System.Drawing.Point(25, 42)
        Me.txtFullName.Name = "txtFullName"
        Me.txtFullName.Size = New System.Drawing.Size(200, 26)
        '
        'lblPhone
        '
        Me.lblPhone.AutoSize = True
        Me.lblPhone.Font = New System.Drawing.Font("Segoe UI", 8.5!, System.Drawing.FontStyle.Bold)
        Me.lblPhone.ForeColor = System.Drawing.Color.FromArgb(140, 160, 150)
        Me.lblPhone.Location = New System.Drawing.Point(250, 22)
        Me.lblPhone.Name = "lblPhone"
        Me.lblPhone.Text = "PHONE NUMBER *"
        '
        'txtPhone
        '
        Me.txtPhone.BackColor = System.Drawing.Color.FromArgb(42, 52, 46)
        Me.txtPhone.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtPhone.Font = New System.Drawing.Font("Segoe UI", 10.5!)
        Me.txtPhone.ForeColor = System.Drawing.Color.FromArgb(220, 235, 225)
        Me.txtPhone.Location = New System.Drawing.Point(250, 42)
        Me.txtPhone.Name = "txtPhone"
        Me.txtPhone.Size = New System.Drawing.Size(200, 26)
        '
        'lblEmail
        '
        Me.lblEmail.AutoSize = True
        Me.lblEmail.Font = New System.Drawing.Font("Segoe UI", 8.5!, System.Drawing.FontStyle.Bold)
        Me.lblEmail.ForeColor = System.Drawing.Color.FromArgb(140, 160, 150)
        Me.lblEmail.Location = New System.Drawing.Point(25, 85)
        Me.lblEmail.Name = "lblEmail"
        Me.lblEmail.Text = "EMAIL ADDRESS"
        '
        'txtEmail
        '
        Me.txtEmail.BackColor = System.Drawing.Color.FromArgb(42, 52, 46)
        Me.txtEmail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtEmail.Font = New System.Drawing.Font("Segoe UI", 10.5!)
        Me.txtEmail.ForeColor = System.Drawing.Color.FromArgb(220, 235, 225)
        Me.txtEmail.Location = New System.Drawing.Point(25, 105)
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.Size = New System.Drawing.Size(200, 26)
        '
        'lblIC
        '
        Me.lblIC.AutoSize = True
        Me.lblIC.Font = New System.Drawing.Font("Segoe UI", 8.5!, System.Drawing.FontStyle.Bold)
        Me.lblIC.ForeColor = System.Drawing.Color.FromArgb(140, 160, 150)
        Me.lblIC.Location = New System.Drawing.Point(250, 85)
        Me.lblIC.Name = "lblIC"
        Me.lblIC.Text = "IC / PASSPORT NO."
        '
        'txtIC
        '
        Me.txtIC.BackColor = System.Drawing.Color.FromArgb(42, 52, 46)
        Me.txtIC.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtIC.Font = New System.Drawing.Font("Segoe UI", 10.5!)
        Me.txtIC.ForeColor = System.Drawing.Color.FromArgb(220, 235, 225)
        Me.txtIC.Location = New System.Drawing.Point(250, 105)
        Me.txtIC.Name = "txtIC"
        Me.txtIC.Size = New System.Drawing.Size(200, 26)
        '
        'lblUsername
        '
        Me.lblUsername.AutoSize = True
        Me.lblUsername.Font = New System.Drawing.Font("Segoe UI", 8.5!, System.Drawing.FontStyle.Bold)
        Me.lblUsername.ForeColor = System.Drawing.Color.FromArgb(140, 160, 150)
        Me.lblUsername.Location = New System.Drawing.Point(25, 150)
        Me.lblUsername.Name = "lblUsername"
        Me.lblUsername.Text = "USERNAME *"
        '
        'txtUsername
        '
        Me.txtUsername.BackColor = System.Drawing.Color.FromArgb(42, 52, 46)
        Me.txtUsername.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtUsername.Font = New System.Drawing.Font("Segoe UI", 10.5!)
        Me.txtUsername.ForeColor = System.Drawing.Color.FromArgb(220, 235, 225)
        Me.txtUsername.Location = New System.Drawing.Point(25, 170)
        Me.txtUsername.Name = "txtUsername"
        Me.txtUsername.Size = New System.Drawing.Size(425, 26)
        '
        'lblPassword
        '
        Me.lblPassword.AutoSize = True
        Me.lblPassword.Font = New System.Drawing.Font("Segoe UI", 8.5!, System.Drawing.FontStyle.Bold)
        Me.lblPassword.ForeColor = System.Drawing.Color.FromArgb(140, 160, 150)
        Me.lblPassword.Location = New System.Drawing.Point(25, 215)
        Me.lblPassword.Name = "lblPassword"
        Me.lblPassword.Text = "PASSWORD *"
        '
        'txtPassword
        '
        Me.txtPassword.BackColor = System.Drawing.Color.FromArgb(42, 52, 46)
        Me.txtPassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtPassword.Font = New System.Drawing.Font("Segoe UI", 10.5!)
        Me.txtPassword.ForeColor = System.Drawing.Color.FromArgb(220, 235, 225)
        Me.txtPassword.Location = New System.Drawing.Point(25, 235)
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(8226)
        Me.txtPassword.Size = New System.Drawing.Size(200, 26)
        '
        'lblConfirmPassword
        '
        Me.lblConfirmPassword.AutoSize = True
        Me.lblConfirmPassword.Font = New System.Drawing.Font("Segoe UI", 8.5!, System.Drawing.FontStyle.Bold)
        Me.lblConfirmPassword.ForeColor = System.Drawing.Color.FromArgb(140, 160, 150)
        Me.lblConfirmPassword.Location = New System.Drawing.Point(250, 215)
        Me.lblConfirmPassword.Name = "lblConfirmPassword"
        Me.lblConfirmPassword.Text = "CONFIRM PASSWORD *"
        '
        'txtConfirmPassword
        '
        Me.txtConfirmPassword.BackColor = System.Drawing.Color.FromArgb(42, 52, 46)
        Me.txtConfirmPassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtConfirmPassword.Font = New System.Drawing.Font("Segoe UI", 10.5!)
        Me.txtConfirmPassword.ForeColor = System.Drawing.Color.FromArgb(220, 235, 225)
        Me.txtConfirmPassword.Location = New System.Drawing.Point(250, 235)
        Me.txtConfirmPassword.Name = "txtConfirmPassword"
        Me.txtConfirmPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(8226)
        Me.txtConfirmPassword.Size = New System.Drawing.Size(200, 26)
        '
        'cmdRegister
        '
        Me.cmdRegister.BackColor = System.Drawing.Color.FromArgb(20, 150, 85)
        Me.cmdRegister.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdRegister.FlatAppearance.BorderSize = 0
        Me.cmdRegister.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Bold)
        Me.cmdRegister.ForeColor = System.Drawing.Color.White
        Me.cmdRegister.Location = New System.Drawing.Point(25, 285)
        Me.cmdRegister.Name = "cmdRegister"
        Me.cmdRegister.Size = New System.Drawing.Size(200, 40)
        Me.cmdRegister.Text = "Create Account"
        Me.cmdRegister.UseVisualStyleBackColor = False
        '
        'cmdCancel
        '
        Me.cmdCancel.BackColor = System.Drawing.Color.FromArgb(65, 75, 70)
        Me.cmdCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdCancel.FlatAppearance.BorderSize = 0
        Me.cmdCancel.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Bold)
        Me.cmdCancel.ForeColor = System.Drawing.Color.White
        Me.cmdCancel.Location = New System.Drawing.Point(250, 285)
        Me.cmdCancel.Name = "cmdCancel"
        Me.cmdCancel.Size = New System.Drawing.Size(200, 40)
        Me.cmdCancel.Text = "Cancel"
        Me.cmdCancel.UseVisualStyleBackColor = False
        '
        'lblHaveAccount
        '
        Me.lblHaveAccount.AutoSize = True
        Me.lblHaveAccount.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.lblHaveAccount.ForeColor = System.Drawing.Color.FromArgb(100, 120, 110)
        Me.lblHaveAccount.Location = New System.Drawing.Point(25, 350)
        Me.lblHaveAccount.Name = "lblHaveAccount"
        Me.lblHaveAccount.Text = "Already have an account?"
        '
        'lnkLogin
        '
        Me.lnkLogin.ActiveLinkColor = System.Drawing.Color.FromArgb(100, 220, 150)
        Me.lnkLogin.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.lnkLogin.LinkColor = System.Drawing.Color.FromArgb(60, 185, 120)
        Me.lnkLogin.Location = New System.Drawing.Point(200, 350)
        Me.lnkLogin.Name = "lnkLogin"
        Me.lnkLogin.Size = New System.Drawing.Size(100, 18)
        Me.lnkLogin.TabStop = True
        Me.lnkLogin.Text = "Sign In →"
        Me.lnkLogin.VisitedLinkColor = System.Drawing.Color.FromArgb(60, 185, 120)
        '
        'frmRegister
        '
        Me.AcceptButton = Me.cmdRegister
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(30, 37, 33)
        Me.ClientSize = New System.Drawing.Size(480, 600)
        Me.Controls.Add(Me.pnlForm)
        Me.Controls.Add(Me.pnlHeader)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmRegister"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Ambatubus - Create Account"
        Me.pnlHeader.ResumeLayout(False)
        Me.pnlHeader.PerformLayout()
        Me.pnlForm.ResumeLayout(False)
        Me.pnlForm.PerformLayout()
        Me.ResumeLayout(False)
    End Sub

    Friend WithEvents pnlHeader As System.Windows.Forms.Panel
    Friend WithEvents lblTitle As System.Windows.Forms.Label
    Friend WithEvents lblSubtitle As System.Windows.Forms.Label
    Friend WithEvents pnlForm As System.Windows.Forms.Panel
    Friend WithEvents lblFullName As System.Windows.Forms.Label
    Friend WithEvents txtFullName As System.Windows.Forms.TextBox
    Friend WithEvents lblPhone As System.Windows.Forms.Label
    Friend WithEvents txtPhone As System.Windows.Forms.TextBox
    Friend WithEvents lblEmail As System.Windows.Forms.Label
    Friend WithEvents txtEmail As System.Windows.Forms.TextBox
    Friend WithEvents lblIC As System.Windows.Forms.Label
    Friend WithEvents txtIC As System.Windows.Forms.TextBox
    Friend WithEvents lblUsername As System.Windows.Forms.Label
    Friend WithEvents txtUsername As System.Windows.Forms.TextBox
    Friend WithEvents lblPassword As System.Windows.Forms.Label
    Friend WithEvents txtPassword As System.Windows.Forms.TextBox
    Friend WithEvents lblConfirmPassword As System.Windows.Forms.Label
    Friend WithEvents txtConfirmPassword As System.Windows.Forms.TextBox
    Friend WithEvents cmdRegister As System.Windows.Forms.Button
    Friend WithEvents cmdCancel As System.Windows.Forms.Button
    Friend WithEvents lblHaveAccount As System.Windows.Forms.Label
    Friend WithEvents lnkLogin As System.Windows.Forms.LinkLabel
End Class
