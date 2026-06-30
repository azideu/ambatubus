<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmUserLogin
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
        Me.lblUsername = New System.Windows.Forms.Label()
        Me.txtUsername = New System.Windows.Forms.TextBox()
        Me.lblPassword = New System.Windows.Forms.Label()
        Me.txtPassword = New System.Windows.Forms.TextBox()
        Me.cmdLogin = New System.Windows.Forms.Button()
        Me.cmdCancel = New System.Windows.Forms.Button()
        Me.lblOr = New System.Windows.Forms.Label()
        Me.lnkRegister = New System.Windows.Forms.LinkLabel()
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
        Me.pnlHeader.Size = New System.Drawing.Size(420, 100)
        '
        'lblTitle
        '
        Me.lblTitle.AutoSize = True
        Me.lblTitle.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Bold)
        Me.lblTitle.ForeColor = System.Drawing.Color.White
        Me.lblTitle.Location = New System.Drawing.Point(20, 15)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Text = "Passenger Login"
        '
        'lblSubtitle
        '
        Me.lblSubtitle.AutoSize = True
        Me.lblSubtitle.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.lblSubtitle.ForeColor = System.Drawing.Color.FromArgb(180, 235, 205)
        Me.lblSubtitle.Location = New System.Drawing.Point(22, 63)
        Me.lblSubtitle.Name = "lblSubtitle"
        Me.lblSubtitle.Text = "Sign in to access your bookings"
        '
        'pnlForm
        '
        Me.pnlForm.BackColor = System.Drawing.Color.FromArgb(30, 37, 33)
        Me.pnlForm.Controls.Add(Me.lblUsername)
        Me.pnlForm.Controls.Add(Me.txtUsername)
        Me.pnlForm.Controls.Add(Me.lblPassword)
        Me.pnlForm.Controls.Add(Me.txtPassword)
        Me.pnlForm.Controls.Add(Me.cmdLogin)
        Me.pnlForm.Controls.Add(Me.cmdCancel)
        Me.pnlForm.Controls.Add(Me.lblOr)
        Me.pnlForm.Controls.Add(Me.lnkRegister)
        Me.pnlForm.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlForm.Location = New System.Drawing.Point(0, 100)
        Me.pnlForm.Name = "pnlForm"
        Me.pnlForm.Size = New System.Drawing.Size(420, 270)
        '
        'lblUsername
        '
        Me.lblUsername.AutoSize = True
        Me.lblUsername.Font = New System.Drawing.Font("Segoe UI", 8.5!, System.Drawing.FontStyle.Bold)
        Me.lblUsername.ForeColor = System.Drawing.Color.FromArgb(140, 160, 150)
        Me.lblUsername.Location = New System.Drawing.Point(25, 22)
        Me.lblUsername.Name = "lblUsername"
        Me.lblUsername.Text = "USERNAME"
        '
        'txtUsername
        '
        Me.txtUsername.BackColor = System.Drawing.Color.FromArgb(42, 52, 46)
        Me.txtUsername.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtUsername.Font = New System.Drawing.Font("Segoe UI", 11.0!)
        Me.txtUsername.ForeColor = System.Drawing.Color.FromArgb(220, 235, 225)
        Me.txtUsername.Location = New System.Drawing.Point(25, 42)
        Me.txtUsername.Name = "txtUsername"
        Me.txtUsername.Size = New System.Drawing.Size(370, 27)
        '
        'lblPassword
        '
        Me.lblPassword.AutoSize = True
        Me.lblPassword.Font = New System.Drawing.Font("Segoe UI", 8.5!, System.Drawing.FontStyle.Bold)
        Me.lblPassword.ForeColor = System.Drawing.Color.FromArgb(140, 160, 150)
        Me.lblPassword.Location = New System.Drawing.Point(25, 87)
        Me.lblPassword.Name = "lblPassword"
        Me.lblPassword.Text = "PASSWORD"
        '
        'txtPassword
        '
        Me.txtPassword.BackColor = System.Drawing.Color.FromArgb(42, 52, 46)
        Me.txtPassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtPassword.Font = New System.Drawing.Font("Segoe UI", 11.0!)
        Me.txtPassword.ForeColor = System.Drawing.Color.FromArgb(220, 235, 225)
        Me.txtPassword.Location = New System.Drawing.Point(25, 107)
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(8226)
        Me.txtPassword.Size = New System.Drawing.Size(370, 27)
        '
        'cmdLogin
        '
        Me.cmdLogin.BackColor = System.Drawing.Color.FromArgb(20, 150, 85)
        Me.cmdLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdLogin.FlatAppearance.BorderSize = 0
        Me.cmdLogin.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Bold)
        Me.cmdLogin.ForeColor = System.Drawing.Color.White
        Me.cmdLogin.Location = New System.Drawing.Point(25, 152)
        Me.cmdLogin.Name = "cmdLogin"
        Me.cmdLogin.Size = New System.Drawing.Size(180, 40)
        Me.cmdLogin.Text = "Login"
        Me.cmdLogin.UseVisualStyleBackColor = False
        '
        'cmdCancel
        '
        Me.cmdCancel.BackColor = System.Drawing.Color.FromArgb(65, 75, 70)
        Me.cmdCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdCancel.FlatAppearance.BorderSize = 0
        Me.cmdCancel.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Bold)
        Me.cmdCancel.ForeColor = System.Drawing.Color.White
        Me.cmdCancel.Location = New System.Drawing.Point(215, 152)
        Me.cmdCancel.Name = "cmdCancel"
        Me.cmdCancel.Size = New System.Drawing.Size(180, 40)
        Me.cmdCancel.Text = "Cancel"
        Me.cmdCancel.UseVisualStyleBackColor = False
        '
        'lblOr
        '
        Me.lblOr.AutoSize = True
        Me.lblOr.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.lblOr.ForeColor = System.Drawing.Color.FromArgb(100, 120, 110)
        Me.lblOr.Location = New System.Drawing.Point(25, 215)
        Me.lblOr.Name = "lblOr"
        Me.lblOr.Text = "Don't have an account?"
        '
        'lnkRegister
        '
        Me.lnkRegister.ActiveLinkColor = System.Drawing.Color.FromArgb(100, 220, 150)
        Me.lnkRegister.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.lnkRegister.LinkColor = System.Drawing.Color.FromArgb(60, 185, 120)
        Me.lnkRegister.Location = New System.Drawing.Point(188, 215)
        Me.lnkRegister.Name = "lnkRegister"
        Me.lnkRegister.Size = New System.Drawing.Size(130, 18)
        Me.lnkRegister.TabStop = True
        Me.lnkRegister.Text = "Create an Account →"
        Me.lnkRegister.VisitedLinkColor = System.Drawing.Color.FromArgb(60, 185, 120)
        '
        'frmUserLogin
        '
        Me.AcceptButton = Me.cmdLogin
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(30, 37, 33)
        Me.ClientSize = New System.Drawing.Size(420, 370)
        Me.Controls.Add(Me.pnlForm)
        Me.Controls.Add(Me.pnlHeader)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmUserLogin"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Ambatubus - Passenger Login"
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
    Friend WithEvents lblUsername As System.Windows.Forms.Label
    Friend WithEvents txtUsername As System.Windows.Forms.TextBox
    Friend WithEvents lblPassword As System.Windows.Forms.Label
    Friend WithEvents txtPassword As System.Windows.Forms.TextBox
    Friend WithEvents cmdLogin As System.Windows.Forms.Button
    Friend WithEvents cmdCancel As System.Windows.Forms.Button
    Friend WithEvents lblOr As System.Windows.Forms.Label
    Friend WithEvents lnkRegister As System.Windows.Forms.LinkLabel
End Class
