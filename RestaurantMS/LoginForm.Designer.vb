﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class LoginForm
    Inherits System.Windows.Forms.Form

    Private components As System.ComponentModel.IContainer

    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(LoginForm))
        Panel1 = New Panel()
        cbtn_connect = New CircularButton()
        cbtn_login = New CircularButton()
        Label1 = New Label()
        txt_Welcome = New Label()
        Label2 = New Label()
        txtbox_password = New TextBox()
        txtbox_username = New TextBox()
        Panel1.SuspendLayout()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.BackgroundImage = CType(resources.GetObject("Panel1.BackgroundImage"), Image)
        Panel1.BackgroundImageLayout = ImageLayout.Center
        Panel1.Controls.Add(cbtn_connect)
        Panel1.Controls.Add(cbtn_login)
        Panel1.Controls.Add(Label1)
        Panel1.Controls.Add(txt_Welcome)
        Panel1.Controls.Add(Label2)
        Panel1.Controls.Add(txtbox_password)
        Panel1.Controls.Add(txtbox_username)
        Panel1.Location = New Point(0, -2)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(1265, 680)
        Panel1.TabIndex = 8
        ' 
        ' cbtn_connect
        ' 
        cbtn_connect.BackColor = Color.FromArgb(CByte(226), CByte(226), CByte(226))
        cbtn_connect.BackgroundColor = Color.FromArgb(CByte(226), CByte(226), CByte(226))
        cbtn_connect.BorderColor = Color.PaleVioletRed
        cbtn_connect.BorderRadius = 40
        cbtn_connect.BorderSize = 0
        cbtn_connect.FlatAppearance.BorderSize = 0
        cbtn_connect.FlatAppearance.MouseDownBackColor = Color.FromArgb(CByte(94), CByte(90), CByte(90))
        cbtn_connect.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(205), CByte(203), CByte(203))
        cbtn_connect.FlatStyle = FlatStyle.Flat
        cbtn_connect.Font = New Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        cbtn_connect.ForeColor = Color.FromArgb(CByte(25), CByte(24), CByte(24))
        cbtn_connect.Location = New Point(445, 538)
        cbtn_connect.Name = "cbtn_connect"
        cbtn_connect.Size = New Size(365, 50)
        cbtn_connect.TabIndex = 8
        cbtn_connect.Text = "Connection"
        cbtn_connect.TextColor = Color.FromArgb(CByte(25), CByte(24), CByte(24))
        cbtn_connect.UseVisualStyleBackColor = False
        ' 
        ' cbtn_login
        ' 
        cbtn_login.BackColor = Color.FromArgb(CByte(25), CByte(24), CByte(24))
        cbtn_login.BackgroundColor = Color.FromArgb(CByte(25), CByte(24), CByte(24))
        cbtn_login.BorderColor = Color.PaleVioletRed
        cbtn_login.BorderRadius = 40
        cbtn_login.BorderSize = 0
        cbtn_login.FlatAppearance.BorderSize = 0
        cbtn_login.FlatAppearance.MouseDownBackColor = Color.FromArgb(CByte(62), CByte(60), CByte(60))
        cbtn_login.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(125), CByte(120), CByte(120))
        cbtn_login.FlatStyle = FlatStyle.Flat
        cbtn_login.Font = New Font("Lato", 16.1999989F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        cbtn_login.ForeColor = Color.White
        cbtn_login.Location = New Point(445, 460)
        cbtn_login.Name = "cbtn_login"
        cbtn_login.Size = New Size(365, 50)
        cbtn_login.TabIndex = 8
        cbtn_login.Text = "Login"
        cbtn_login.TextColor = Color.White
        cbtn_login.UseVisualStyleBackColor = False
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = Color.Transparent
        Label1.Font = New Font("Lato", 12.0F)
        Label1.ForeColor = Color.FromArgb(CByte(25), CByte(24), CByte(24))
        Label1.Location = New Point(443, 242)
        Label1.Name = "Label1"
        Label1.Size = New Size(99, 24)
        Label1.TabIndex = 1
        Label1.Text = "Username"
        ' 
        ' txt_Welcome
        ' 
        txt_Welcome.AutoSize = True
        txt_Welcome.BackColor = Color.Transparent
        txt_Welcome.Font = New Font("Lato", 28.1999989F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        txt_Welcome.ForeColor = Color.FromArgb(CByte(25), CByte(24), CByte(24))
        txt_Welcome.Location = New Point(445, 139)
        txt_Welcome.Name = "txt_Welcome"
        txt_Welcome.Size = New Size(219, 56)
        txt_Welcome.TabIndex = 7
        txt_Welcome.Text = "Welcome!"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.BackColor = Color.Transparent
        Label2.Font = New Font("Lato", 12.0F)
        Label2.ForeColor = Color.FromArgb(CByte(25), CByte(24), CByte(24))
        Label2.Location = New Point(443, 332)
        Label2.Name = "Label2"
        Label2.Size = New Size(95, 24)
        Label2.TabIndex = 2
        Label2.Text = "Password"
        ' 
        ' txtbox_password
        ' 
        txtbox_password.BackColor = Color.FromArgb(CByte(185), CByte(182), CByte(182))
        txtbox_password.BorderStyle = BorderStyle.FixedSingle
        txtbox_password.Font = New Font("Lato", 12.0F)
        txtbox_password.ForeColor = Color.White
        txtbox_password.Location = New Point(445, 365)
        txtbox_password.Name = "txtbox_password"
        txtbox_password.PasswordChar = "*"c
        txtbox_password.Size = New Size(365, 31)
        txtbox_password.TabIndex = 4
        ' 
        ' txtbox_username
        ' 
        txtbox_username.BackColor = Color.FromArgb(CByte(185), CByte(182), CByte(182))
        txtbox_username.BorderStyle = BorderStyle.FixedSingle
        txtbox_username.Font = New Font("Lato", 12.0F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txtbox_username.ForeColor = Color.White
        txtbox_username.Location = New Point(445, 275)
        txtbox_username.Name = "txtbox_username"
        txtbox_username.Size = New Size(365, 31)
        txtbox_username.TabIndex = 3
        ' 
        ' LoginForm
        ' 
        ClientSize = New Size(1262, 673)
        Controls.Add(Panel1)
        FormBorderStyle = FormBorderStyle.FixedDialog
        MaximizeBox = False
        Name = "LoginForm"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Login"
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtbox_username As TextBox
    Friend WithEvents txtbox_password As TextBox
    Friend WithEvents txt_Welcome As Label
    Friend WithEvents btn_connect As CircularButton
    Friend WithEvents btn_login As CircularButton
    Friend WithEvents cbtn_connect As CircularButton
    Friend WithEvents cbtn_login As CircularButton
End Class