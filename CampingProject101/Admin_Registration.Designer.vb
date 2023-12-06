<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Admin_Registration
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
        Dim resources As ComponentModel.ComponentResourceManager = New ComponentModel.ComponentResourceManager(GetType(Admin_Registration))
        Label1 = New Label()
        txtUSERNAME = New TextBox()
        ARegisterBack = New Button()
        AdminRegister = New Button()
        txtADDRESS = New TextBox()
        txtPHONENUM = New TextBox()
        txtBIRTHDAY = New TextBox()
        txtAGE = New TextBox()
        txtFULLNAME = New TextBox()
        txtCONFIRMPASS = New TextBox()
        txtPASS = New TextBox()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        Label5 = New Label()
        Label6 = New Label()
        Label7 = New Label()
        Label8 = New Label()
        Label9 = New Label()
        PictureBox1 = New PictureBox()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Berlin Sans FB", 10.2F, FontStyle.Regular, GraphicsUnit.Point)
        Label1.Location = New Point(167, 108)
        Label1.Name = "Label1"
        Label1.Size = New Size(97, 19)
        Label1.TabIndex = 0
        Label1.Text = "PASSWORD"
        ' 
        ' txtUSERNAME
        ' 
        txtUSERNAME.BackColor = Color.PowderBlue
        txtUSERNAME.Location = New Point(12, 54)
        txtUSERNAME.Name = "txtUSERNAME"
        txtUSERNAME.Size = New Size(252, 27)
        txtUSERNAME.TabIndex = 1
        ' 
        ' ARegisterBack
        ' 
        ARegisterBack.BackColor = Color.Gainsboro
        ARegisterBack.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point)
        ARegisterBack.ForeColor = Color.Black
        ARegisterBack.Location = New Point(12, 399)
        ARegisterBack.Name = "ARegisterBack"
        ARegisterBack.Size = New Size(127, 39)
        ARegisterBack.TabIndex = 2
        ARegisterBack.Text = "Return to Login"
        ARegisterBack.UseVisualStyleBackColor = False
        ' 
        ' AdminRegister
        ' 
        AdminRegister.BackColor = Color.Gainsboro
        AdminRegister.Font = New Font("Berlin Sans FB Demi", 10.2F, FontStyle.Bold, GraphicsUnit.Point)
        AdminRegister.ForeColor = Color.IndianRed
        AdminRegister.Location = New Point(305, 384)
        AdminRegister.Name = "AdminRegister"
        AdminRegister.Size = New Size(130, 50)
        AdminRegister.TabIndex = 3
        AdminRegister.Text = "REGISTER"
        AdminRegister.UseVisualStyleBackColor = False
        ' 
        ' txtADDRESS
        ' 
        txtADDRESS.BackColor = Color.PowderBlue
        txtADDRESS.Location = New Point(12, 351)
        txtADDRESS.Name = "txtADDRESS"
        txtADDRESS.Size = New Size(252, 27)
        txtADDRESS.TabIndex = 4
        ' 
        ' txtPHONENUM
        ' 
        txtPHONENUM.BackColor = Color.PowderBlue
        txtPHONENUM.Location = New Point(12, 303)
        txtPHONENUM.Name = "txtPHONENUM"
        txtPHONENUM.Size = New Size(252, 27)
        txtPHONENUM.TabIndex = 5
        ' 
        ' txtBIRTHDAY
        ' 
        txtBIRTHDAY.BackColor = Color.PowderBlue
        txtBIRTHDAY.Location = New Point(12, 258)
        txtBIRTHDAY.Name = "txtBIRTHDAY"
        txtBIRTHDAY.Size = New Size(252, 27)
        txtBIRTHDAY.TabIndex = 6
        ' 
        ' txtAGE
        ' 
        txtAGE.BackColor = Color.PowderBlue
        txtAGE.Location = New Point(12, 208)
        txtAGE.Name = "txtAGE"
        txtAGE.Size = New Size(252, 27)
        txtAGE.TabIndex = 7
        ' 
        ' txtFULLNAME
        ' 
        txtFULLNAME.BackColor = Color.PowderBlue
        txtFULLNAME.Location = New Point(12, 161)
        txtFULLNAME.Name = "txtFULLNAME"
        txtFULLNAME.Size = New Size(252, 27)
        txtFULLNAME.TabIndex = 8
        ' 
        ' txtCONFIRMPASS
        ' 
        txtCONFIRMPASS.BackColor = Color.PowderBlue
        txtCONFIRMPASS.Location = New Point(277, 105)
        txtCONFIRMPASS.Name = "txtCONFIRMPASS"
        txtCONFIRMPASS.Size = New Size(158, 27)
        txtCONFIRMPASS.TabIndex = 9
        ' 
        ' txtPASS
        ' 
        txtPASS.BackColor = Color.PowderBlue
        txtPASS.Location = New Point(12, 105)
        txtPASS.Name = "txtPASS"
        txtPASS.Size = New Size(145, 27)
        txtPASS.TabIndex = 10
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Berlin Sans FB", 10.2F, FontStyle.Regular, GraphicsUnit.Point)
        Label2.Location = New Point(277, 351)
        Label2.Name = "Label2"
        Label2.Size = New Size(79, 19)
        Label2.TabIndex = 11
        Label2.Text = "ADDRESS"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Berlin Sans FB", 10.2F, FontStyle.Regular, GraphicsUnit.Point)
        Label3.Location = New Point(277, 306)
        Label3.Name = "Label3"
        Label3.Size = New Size(134, 19)
        Label3.TabIndex = 12
        Label3.Text = "PHONE NUMBER"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Berlin Sans FB", 10.2F, FontStyle.Regular, GraphicsUnit.Point)
        Label4.Location = New Point(277, 261)
        Label4.Name = "Label4"
        Label4.Size = New Size(207, 19)
        Label4.TabIndex = 13
        Label4.Text = "BIRTHDAY (YYYY-MM-DD)"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Berlin Sans FB", 10.2F, FontStyle.Regular, GraphicsUnit.Point)
        Label5.Location = New Point(277, 211)
        Label5.Name = "Label5"
        Label5.Size = New Size(40, 19)
        Label5.TabIndex = 14
        Label5.Text = "AGE"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Berlin Sans FB", 10.2F, FontStyle.Regular, GraphicsUnit.Point)
        Label6.Location = New Point(277, 164)
        Label6.Name = "Label6"
        Label6.Size = New Size(96, 19)
        Label6.TabIndex = 15
        Label6.Text = "FULL NAME"
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Font = New Font("Berlin Sans FB", 10.2F, FontStyle.Regular, GraphicsUnit.Point)
        Label7.Location = New Point(277, 57)
        Label7.Name = "Label7"
        Label7.Size = New Size(92, 19)
        Label7.TabIndex = 16
        Label7.Text = "USERNAME"
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Font = New Font("Berlin Sans FB", 10.2F, FontStyle.Regular, GraphicsUnit.Point)
        Label8.Location = New Point(441, 108)
        Label8.Name = "Label8"
        Label8.Size = New Size(171, 19)
        Label8.TabIndex = 17
        Label8.Text = "CONFIRM PASSWORD"
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.BackColor = Color.Gainsboro
        Label9.Font = New Font("Stencil", 13.8F, FontStyle.Regular, GraphicsUnit.Point)
        Label9.ForeColor = Color.DodgerBlue
        Label9.Location = New Point(12, 12)
        Label9.Name = "Label9"
        Label9.Size = New Size(251, 27)
        Label9.TabIndex = 18
        Label9.Text = "ADMIN REGISTRATION"
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), Image)
        PictureBox1.Location = New Point(572, 12)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(216, 71)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.TabIndex = 19
        PictureBox1.TabStop = False
        ' 
        ' Admin_Registration
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.Beige
        ClientSize = New Size(800, 450)
        Controls.Add(PictureBox1)
        Controls.Add(Label9)
        Controls.Add(Label8)
        Controls.Add(Label7)
        Controls.Add(Label6)
        Controls.Add(Label5)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(txtPASS)
        Controls.Add(txtCONFIRMPASS)
        Controls.Add(txtFULLNAME)
        Controls.Add(txtAGE)
        Controls.Add(txtBIRTHDAY)
        Controls.Add(txtPHONENUM)
        Controls.Add(txtADDRESS)
        Controls.Add(AdminRegister)
        Controls.Add(ARegisterBack)
        Controls.Add(txtUSERNAME)
        Controls.Add(Label1)
        Name = "Admin_Registration"
        Text = "Admin_Registration"
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents txtUSERNAME As TextBox
    Friend WithEvents ARegisterBack As Button
    Friend WithEvents AdminRegister As Button
    Friend WithEvents txtADDRESS As TextBox
    Friend WithEvents txtPHONENUM As TextBox
    Friend WithEvents txtBIRTHDAY As TextBox
    Friend WithEvents txtAGE As TextBox
    Friend WithEvents txtFULLNAME As TextBox
    Friend WithEvents txtCONFIRMPASS As TextBox
    Friend WithEvents txtPASS As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents PictureBox1 As PictureBox
End Class
