<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Camper_Registration
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As ComponentModel.ComponentResourceManager = New ComponentModel.ComponentResourceManager(GetType(Camper_Registration))
        txtUsername = New TextBox()
        CamperRegister = New Button()
        txtFullName = New TextBox()
        txtPhoneNum = New TextBox()
        txtBirthday = New TextBox()
        txtAge = New TextBox()
        txtAddress = New TextBox()
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        Label5 = New Label()
        Label6 = New Label()
        txtPassword = New TextBox()
        txtconfirmPassword = New TextBox()
        Label7 = New Label()
        Label8 = New Label()
        CRegisterBack = New Button()
        Label9 = New Label()
        PictureBox1 = New PictureBox()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' txtUsername
        ' 
        txtUsername.BackColor = Color.Silver
        txtUsername.Location = New Point(41, 64)
        txtUsername.Name = "txtUsername"
        txtUsername.Size = New Size(269, 27)
        txtUsername.TabIndex = 0
        ' 
        ' CamperRegister
        ' 
        CamperRegister.BackColor = Color.Silver
        CamperRegister.Font = New Font("Berlin Sans FB Demi", 9F, FontStyle.Bold, GraphicsUnit.Point)
        CamperRegister.Location = New Point(312, 387)
        CamperRegister.Name = "CamperRegister"
        CamperRegister.Size = New Size(134, 52)
        CamperRegister.TabIndex = 1
        CamperRegister.Text = "REGISTER"
        CamperRegister.UseVisualStyleBackColor = False
        ' 
        ' txtFullName
        ' 
        txtFullName.BackColor = Color.Silver
        txtFullName.Location = New Point(41, 149)
        txtFullName.Name = "txtFullName"
        txtFullName.Size = New Size(269, 27)
        txtFullName.TabIndex = 2
        ' 
        ' txtPhoneNum
        ' 
        txtPhoneNum.BackColor = Color.Silver
        txtPhoneNum.Location = New Point(41, 289)
        txtPhoneNum.Name = "txtPhoneNum"
        txtPhoneNum.Size = New Size(269, 27)
        txtPhoneNum.TabIndex = 3
        ' 
        ' txtBirthday
        ' 
        txtBirthday.BackColor = Color.Silver
        txtBirthday.Location = New Point(41, 243)
        txtBirthday.Name = "txtBirthday"
        txtBirthday.Size = New Size(269, 27)
        txtBirthday.TabIndex = 4
        ' 
        ' txtAge
        ' 
        txtAge.BackColor = Color.Silver
        txtAge.Location = New Point(41, 196)
        txtAge.Name = "txtAge"
        txtAge.Size = New Size(269, 27)
        txtAge.TabIndex = 5
        ' 
        ' txtAddress
        ' 
        txtAddress.BackColor = Color.Silver
        txtAddress.Location = New Point(41, 333)
        txtAddress.Name = "txtAddress"
        txtAddress.Size = New Size(269, 27)
        txtAddress.TabIndex = 6
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Berlin Sans FB", 12F, FontStyle.Regular, GraphicsUnit.Point)
        Label1.Location = New Point(315, 64)
        Label1.Name = "Label1"
        Label1.Size = New Size(93, 23)
        Label1.TabIndex = 7
        Label1.Text = "Username"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Berlin Sans FB", 12F, FontStyle.Regular, GraphicsUnit.Point)
        Label2.Location = New Point(315, 149)
        Label2.Name = "Label2"
        Label2.Size = New Size(96, 23)
        Label2.TabIndex = 8
        Label2.Text = "Full Name"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Berlin Sans FB", 12F, FontStyle.Regular, GraphicsUnit.Point)
        Label3.Location = New Point(315, 196)
        Label3.Name = "Label3"
        Label3.Size = New Size(43, 23)
        Label3.TabIndex = 9
        Label3.Text = "Age"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Berlin Sans FB", 12F, FontStyle.Regular, GraphicsUnit.Point)
        Label4.Location = New Point(315, 243)
        Label4.Name = "Label4"
        Label4.Size = New Size(223, 23)
        Label4.TabIndex = 10
        Label4.Text = "Birthday (YYYY-MM-DD)"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Berlin Sans FB", 12F, FontStyle.Regular, GraphicsUnit.Point)
        Label5.Location = New Point(315, 289)
        Label5.Name = "Label5"
        Label5.Size = New Size(136, 23)
        Label5.TabIndex = 11
        Label5.Text = "Phone Number"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Berlin Sans FB", 12F, FontStyle.Regular, GraphicsUnit.Point)
        Label6.Location = New Point(315, 333)
        Label6.Name = "Label6"
        Label6.Size = New Size(74, 23)
        Label6.TabIndex = 12
        Label6.Text = "Address"
        ' 
        ' txtPassword
        ' 
        txtPassword.BackColor = Color.Silver
        txtPassword.Location = New Point(41, 107)
        txtPassword.Name = "txtPassword"
        txtPassword.PasswordChar = "*"c
        txtPassword.Size = New Size(130, 27)
        txtPassword.TabIndex = 13
        ' 
        ' txtconfirmPassword
        ' 
        txtconfirmPassword.BackColor = Color.Silver
        txtconfirmPassword.Location = New Point(315, 107)
        txtconfirmPassword.Name = "txtconfirmPassword"
        txtconfirmPassword.PasswordChar = "*"c
        txtconfirmPassword.Size = New Size(130, 27)
        txtconfirmPassword.TabIndex = 14
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Font = New Font("Berlin Sans FB", 12F, FontStyle.Regular, GraphicsUnit.Point)
        Label7.Location = New Point(186, 111)
        Label7.Name = "Label7"
        Label7.Size = New Size(88, 23)
        Label7.TabIndex = 15
        Label7.Text = "Password"
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Font = New Font("Berlin Sans FB", 12F, FontStyle.Regular, GraphicsUnit.Point)
        Label8.Location = New Point(463, 111)
        Label8.Name = "Label8"
        Label8.Size = New Size(158, 23)
        Label8.TabIndex = 16
        Label8.Text = "Confirm Password"
        ' 
        ' CRegisterBack
        ' 
        CRegisterBack.BackColor = Color.Silver
        CRegisterBack.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point)
        CRegisterBack.Location = New Point(41, 409)
        CRegisterBack.Name = "CRegisterBack"
        CRegisterBack.Size = New Size(145, 29)
        CRegisterBack.TabIndex = 17
        CRegisterBack.Text = "Return to Login"
        CRegisterBack.UseVisualStyleBackColor = False
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.Font = New Font("Stencil", 13.8F, FontStyle.Regular, GraphicsUnit.Point)
        Label9.Location = New Point(41, 12)
        Label9.Name = "Label9"
        Label9.Size = New Size(215, 27)
        Label9.TabIndex = 18
        Label9.Text = "CAMPER REGISTER"
        ' 
        ' PictureBox1
        ' 
        PictureBox1.BackColor = SystemColors.ButtonHighlight
        PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), Image)
        PictureBox1.Location = New Point(606, 12)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(182, 92)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.TabIndex = 19
        PictureBox1.TabStop = False
        ' 
        ' Camper_Registration
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.GhostWhite
        ClientSize = New Size(800, 451)
        Controls.Add(PictureBox1)
        Controls.Add(Label9)
        Controls.Add(CRegisterBack)
        Controls.Add(Label8)
        Controls.Add(Label7)
        Controls.Add(txtconfirmPassword)
        Controls.Add(txtPassword)
        Controls.Add(Label6)
        Controls.Add(Label5)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(txtAddress)
        Controls.Add(txtAge)
        Controls.Add(txtBirthday)
        Controls.Add(txtPhoneNum)
        Controls.Add(txtFullName)
        Controls.Add(CamperRegister)
        Controls.Add(txtUsername)
        Name = "Camper_Registration"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Camper_Registration"
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents txtUsername As TextBox
    Friend WithEvents CamperRegister As Button
    Friend WithEvents txtFullName As TextBox
    Friend WithEvents txtPhoneNum As TextBox
    Friend WithEvents txtBirthday As TextBox
    Friend WithEvents txtAge As TextBox
    Friend WithEvents txtAddress As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents txtPassword As TextBox
    Friend WithEvents txtconfirmPassword As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents CRegisterBack As Button
    Friend WithEvents Label9 As Label
    Friend WithEvents PictureBox1 As PictureBox
End Class
