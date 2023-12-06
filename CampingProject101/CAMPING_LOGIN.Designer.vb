<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Camping_Login
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        btnLogin = New Button()
        txtuser = New TextBox()
        Label1 = New Label()
        Label2 = New Label()
        txtpass = New TextBox()
        btnRegisterScreen = New Button()
        Label3 = New Label()
        Label4 = New Label()
        checkhide = New CheckBox()
        PictureBox1 = New PictureBox()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' btnLogin
        ' 
        btnLogin.BackColor = Color.LightGray
        btnLogin.Font = New Font("Berlin Sans FB Demi", 9F, FontStyle.Bold, GraphicsUnit.Point)
        btnLogin.ForeColor = Color.RoyalBlue
        btnLogin.Location = New Point(51, 361)
        btnLogin.Name = "btnLogin"
        btnLogin.Size = New Size(176, 37)
        btnLogin.TabIndex = 0
        btnLogin.Text = "LOGIN"
        btnLogin.UseVisualStyleBackColor = False
        ' 
        ' txtuser
        ' 
        txtuser.Location = New Point(168, 178)
        txtuser.Name = "txtuser"
        txtuser.Size = New Size(268, 27)
        txtuser.TabIndex = 1
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Berlin Sans FB", 13.8F, FontStyle.Regular, GraphicsUnit.Point)
        Label1.Location = New Point(32, 176)
        Label1.Name = "Label1"
        Label1.Size = New Size(130, 26)
        Label1.TabIndex = 2
        Label1.Text = "USERNAME:"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Berlin Sans FB", 13.8F, FontStyle.Regular, GraphicsUnit.Point)
        Label2.Location = New Point(26, 225)
        Label2.Name = "Label2"
        Label2.Size = New Size(136, 26)
        Label2.TabIndex = 4
        Label2.Text = "PASSWORD:"
        ' 
        ' txtpass
        ' 
        txtpass.Location = New Point(168, 224)
        txtpass.Name = "txtpass"
        txtpass.Size = New Size(268, 27)
        txtpass.TabIndex = 3
        txtpass.UseSystemPasswordChar = True
        ' 
        ' btnRegisterScreen
        ' 
        btnRegisterScreen.AutoSizeMode = AutoSizeMode.GrowAndShrink
        btnRegisterScreen.BackColor = Color.LightGray
        btnRegisterScreen.Font = New Font("Berlin Sans FB Demi", 9F, FontStyle.Bold, GraphicsUnit.Point)
        btnRegisterScreen.ForeColor = Color.RoyalBlue
        btnRegisterScreen.Location = New Point(260, 361)
        btnRegisterScreen.Name = "btnRegisterScreen"
        btnRegisterScreen.Size = New Size(176, 37)
        btnRegisterScreen.TabIndex = 5
        btnRegisterScreen.Text = "REGISTER"
        btnRegisterScreen.UseVisualStyleBackColor = False
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point)
        Label3.Location = New Point(237, 409)
        Label3.Name = "Label3"
        Label3.Size = New Size(0, 32)
        Label3.TabIndex = 6
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Stencil", 13.8F, FontStyle.Underline, GraphicsUnit.Point)
        Label4.Location = New Point(147, 114)
        Label4.Name = "Label4"
        Label4.Size = New Size(181, 27)
        Label4.TabIndex = 7
        Label4.Text = "CAMPING LOGIN"
        ' 
        ' checkhide
        ' 
        checkhide.AutoSize = True
        checkhide.Location = New Point(193, 273)
        checkhide.Margin = New Padding(3, 4, 3, 4)
        checkhide.Name = "checkhide"
        checkhide.Size = New Size(105, 24)
        checkhide.TabIndex = 8
        checkhide.Text = " View/Hide"
        checkhide.UseVisualStyleBackColor = True
        ' 
        ' PictureBox1
        ' 
        PictureBox1.BackgroundImageLayout = ImageLayout.None
        PictureBox1.Image = My.Resources.Resources._24750_1_member_login_button_photos
        PictureBox1.Location = New Point(51, 22)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(370, 59)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.TabIndex = 9
        PictureBox1.TabStop = False
        ' 
        ' Camping_Login
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.PaleTurquoise
        ClientSize = New Size(470, 451)
        Controls.Add(PictureBox1)
        Controls.Add(checkhide)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(btnRegisterScreen)
        Controls.Add(Label2)
        Controls.Add(txtpass)
        Controls.Add(Label1)
        Controls.Add(txtuser)
        Controls.Add(btnLogin)
        Name = "Camping_Login"
        StartPosition = FormStartPosition.CenterScreen
        Text = "CAMPING LOGIN"
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents btnLogin As Button
    Friend WithEvents txtuser As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtpass As TextBox
    Friend WithEvents btnRegisterScreen As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents checkhide As CheckBox
    Friend WithEvents PictureBox1 As PictureBox
End Class
