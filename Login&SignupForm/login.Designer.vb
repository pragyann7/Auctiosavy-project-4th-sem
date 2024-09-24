<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Login
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Login))
        Me.loginbtn = New System.Windows.Forms.Button()
        Me.signuplabel = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.forgetpasslabel = New System.Windows.Forms.Label()
        Me.passwordtextbox = New System.Windows.Forms.TextBox()
        Me.usernametextbox = New System.Windows.Forms.TextBox()
        Me.hideit = New System.Windows.Forms.PictureBox()
        Me.showpasslogo = New System.Windows.Forms.PictureBox()
        Me.hidepasslogo = New System.Windows.Forms.PictureBox()
        Me.passwordlogo = New System.Windows.Forms.PictureBox()
        Me.usernamelogo = New System.Windows.Forms.PictureBox()
        Me.wallpaper = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.forgotpasswordpanel = New System.Windows.Forms.Panel()
        Me.securityquestionpanel = New System.Windows.Forms.Panel()
        Me.Resetpasswordpanel = New System.Windows.Forms.Panel()
        Me.resetbackbtn = New System.Windows.Forms.Button()
        Me.resetpasssubmitbtn = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.renewpassword = New System.Windows.Forms.TextBox()
        Me.newpassword = New System.Windows.Forms.TextBox()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.securityQsubmitbtn = New System.Windows.Forms.Button()
        Me.securityQbackbtn = New System.Windows.Forms.Button()
        Me.Q1 = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Q3 = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Q2 = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.backloginbtn = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.forgotpassbtn = New System.Windows.Forms.Button()
        Me.forgetpassemailtxt = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.forgotpasspicture = New System.Windows.Forms.PictureBox()
        Me.dragpanel = New System.Windows.Forms.Panel()
        Me.maximizebtn = New System.Windows.Forms.Button()
        Me.minimizebtn = New System.Windows.Forms.Button()
        Me.closebtn = New System.Windows.Forms.Button()
        CType(Me.hideit, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.showpasslogo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.hidepasslogo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.passwordlogo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.usernamelogo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.wallpaper, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.forgotpasswordpanel.SuspendLayout()
        Me.securityquestionpanel.SuspendLayout()
        Me.Resetpasswordpanel.SuspendLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.forgotpasspicture, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.dragpanel.SuspendLayout()
        Me.SuspendLayout()
        '
        'loginbtn
        '
        Me.loginbtn.BackColor = System.Drawing.Color.FromArgb(CType(CType(97, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(87, Byte), Integer))
        Me.loginbtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.loginbtn.FlatAppearance.BorderSize = 0
        Me.loginbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.loginbtn.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.loginbtn.ForeColor = System.Drawing.Color.White
        Me.loginbtn.Location = New System.Drawing.Point(637, 346)
        Me.loginbtn.Margin = New System.Windows.Forms.Padding(0)
        Me.loginbtn.Name = "loginbtn"
        Me.loginbtn.Size = New System.Drawing.Size(152, 32)
        Me.loginbtn.TabIndex = 56
        Me.loginbtn.TabStop = False
        Me.loginbtn.Text = "Login"
        Me.loginbtn.UseVisualStyleBackColor = False
        '
        'signuplabel
        '
        Me.signuplabel.AutoSize = True
        Me.signuplabel.BackColor = System.Drawing.Color.Transparent
        Me.signuplabel.Cursor = System.Windows.Forms.Cursors.Hand
        Me.signuplabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.signuplabel.ForeColor = System.Drawing.Color.RoyalBlue
        Me.signuplabel.Location = New System.Drawing.Point(719, 484)
        Me.signuplabel.Name = "signuplabel"
        Me.signuplabel.Size = New System.Drawing.Size(60, 18)
        Me.signuplabel.TabIndex = 55
        Me.signuplabel.Text = "Sign Up"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(574, 486)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(146, 16)
        Me.Label3.TabIndex = 54
        Me.Label3.Text = "Don’t have an account?"
        '
        'forgetpasslabel
        '
        Me.forgetpasslabel.AutoSize = True
        Me.forgetpasslabel.BackColor = System.Drawing.Color.Transparent
        Me.forgetpasslabel.Cursor = System.Windows.Forms.Cursors.Hand
        Me.forgetpasslabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.forgetpasslabel.ForeColor = System.Drawing.Color.RoyalBlue
        Me.forgetpasslabel.Location = New System.Drawing.Point(655, 395)
        Me.forgetpasslabel.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.forgetpasslabel.Name = "forgetpasslabel"
        Me.forgetpasslabel.Size = New System.Drawing.Size(116, 16)
        Me.forgetpasslabel.TabIndex = 53
        Me.forgetpasslabel.Text = "Forget Password?"
        '
        'passwordtextbox
        '
        Me.passwordtextbox.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.passwordtextbox.Location = New System.Drawing.Point(619, 259)
        Me.passwordtextbox.Multiline = True
        Me.passwordtextbox.Name = "passwordtextbox"
        Me.passwordtextbox.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.passwordtextbox.Size = New System.Drawing.Size(185, 28)
        Me.passwordtextbox.TabIndex = 52
        '
        'usernametextbox
        '
        Me.usernametextbox.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.usernametextbox.Location = New System.Drawing.Point(619, 176)
        Me.usernametextbox.Multiline = True
        Me.usernametextbox.Name = "usernametextbox"
        Me.usernametextbox.Size = New System.Drawing.Size(185, 28)
        Me.usernametextbox.TabIndex = 49
        '
        'hideit
        '
        Me.hideit.BackColor = System.Drawing.Color.White
        Me.hideit.Image = CType(resources.GetObject("hideit.Image"), System.Drawing.Image)
        Me.hideit.Location = New System.Drawing.Point(779, 262)
        Me.hideit.Margin = New System.Windows.Forms.Padding(2)
        Me.hideit.Name = "hideit"
        Me.hideit.Size = New System.Drawing.Size(20, 21)
        Me.hideit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.hideit.TabIndex = 59
        Me.hideit.TabStop = False
        '
        'showpasslogo
        '
        Me.showpasslogo.BackColor = System.Drawing.Color.White
        Me.showpasslogo.Cursor = System.Windows.Forms.Cursors.Hand
        Me.showpasslogo.Image = CType(resources.GetObject("showpasslogo.Image"), System.Drawing.Image)
        Me.showpasslogo.Location = New System.Drawing.Point(779, 262)
        Me.showpasslogo.Margin = New System.Windows.Forms.Padding(2)
        Me.showpasslogo.Name = "showpasslogo"
        Me.showpasslogo.Size = New System.Drawing.Size(20, 21)
        Me.showpasslogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.showpasslogo.TabIndex = 58
        Me.showpasslogo.TabStop = False
        Me.showpasslogo.Visible = False
        '
        'hidepasslogo
        '
        Me.hidepasslogo.BackColor = System.Drawing.Color.White
        Me.hidepasslogo.Cursor = System.Windows.Forms.Cursors.Hand
        Me.hidepasslogo.Image = CType(resources.GetObject("hidepasslogo.Image"), System.Drawing.Image)
        Me.hidepasslogo.Location = New System.Drawing.Point(779, 262)
        Me.hidepasslogo.Margin = New System.Windows.Forms.Padding(2)
        Me.hidepasslogo.Name = "hidepasslogo"
        Me.hidepasslogo.Size = New System.Drawing.Size(20, 21)
        Me.hidepasslogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.hidepasslogo.TabIndex = 57
        Me.hidepasslogo.TabStop = False
        Me.hidepasslogo.Visible = False
        '
        'passwordlogo
        '
        Me.passwordlogo.BackColor = System.Drawing.Color.Transparent
        Me.passwordlogo.Image = Global.Login_SignupForm.My.Resources.Resources.passlock
        Me.passwordlogo.Location = New System.Drawing.Point(563, 253)
        Me.passwordlogo.Margin = New System.Windows.Forms.Padding(2)
        Me.passwordlogo.Name = "passwordlogo"
        Me.passwordlogo.Size = New System.Drawing.Size(35, 36)
        Me.passwordlogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.passwordlogo.TabIndex = 51
        Me.passwordlogo.TabStop = False
        '
        'usernamelogo
        '
        Me.usernamelogo.BackColor = System.Drawing.Color.Transparent
        Me.usernamelogo.Image = CType(resources.GetObject("usernamelogo.Image"), System.Drawing.Image)
        Me.usernamelogo.Location = New System.Drawing.Point(563, 170)
        Me.usernamelogo.Margin = New System.Windows.Forms.Padding(2)
        Me.usernamelogo.Name = "usernamelogo"
        Me.usernamelogo.Size = New System.Drawing.Size(35, 36)
        Me.usernamelogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.usernamelogo.TabIndex = 50
        Me.usernamelogo.TabStop = False
        '
        'wallpaper
        '
        Me.wallpaper.BackColor = System.Drawing.Color.Transparent
        Me.wallpaper.Image = CType(resources.GetObject("wallpaper.Image"), System.Drawing.Image)
        Me.wallpaper.Location = New System.Drawing.Point(-9, 30)
        Me.wallpaper.Margin = New System.Windows.Forms.Padding(2)
        Me.wallpaper.Name = "wallpaper"
        Me.wallpaper.Size = New System.Drawing.Size(575, 526)
        Me.wallpaper.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.wallpaper.TabIndex = 48
        Me.wallpaper.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(27, 45)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(49, 13)
        Me.Label1.TabIndex = 60
        Me.Label1.Text = "00:00:00"
        '
        'Timer1
        '
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.Login_SignupForm.My.Resources.Resources.time
        Me.PictureBox1.Location = New System.Drawing.Point(11, 44)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(15, 15)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 61
        Me.PictureBox1.TabStop = False
        '
        'forgotpasswordpanel
        '
        Me.forgotpasswordpanel.BackColor = System.Drawing.Color.White
        Me.forgotpasswordpanel.Controls.Add(Me.securityquestionpanel)
        Me.forgotpasswordpanel.Controls.Add(Me.backloginbtn)
        Me.forgotpasswordpanel.Controls.Add(Me.Label5)
        Me.forgotpasswordpanel.Controls.Add(Me.forgotpassbtn)
        Me.forgotpasswordpanel.Controls.Add(Me.forgetpassemailtxt)
        Me.forgotpasswordpanel.Controls.Add(Me.Label4)
        Me.forgotpasswordpanel.Controls.Add(Me.Label2)
        Me.forgotpasswordpanel.Controls.Add(Me.forgotpasspicture)
        Me.forgotpasswordpanel.Location = New System.Drawing.Point(0, 32)
        Me.forgotpasswordpanel.Name = "forgotpasswordpanel"
        Me.forgotpasswordpanel.Size = New System.Drawing.Size(837, 557)
        Me.forgotpasswordpanel.TabIndex = 63
        Me.forgotpasswordpanel.Visible = False
        '
        'securityquestionpanel
        '
        Me.securityquestionpanel.Controls.Add(Me.Resetpasswordpanel)
        Me.securityquestionpanel.Controls.Add(Me.securityQsubmitbtn)
        Me.securityquestionpanel.Controls.Add(Me.securityQbackbtn)
        Me.securityquestionpanel.Controls.Add(Me.Q1)
        Me.securityquestionpanel.Controls.Add(Me.Label9)
        Me.securityquestionpanel.Controls.Add(Me.Q3)
        Me.securityquestionpanel.Controls.Add(Me.Label10)
        Me.securityquestionpanel.Controls.Add(Me.Q2)
        Me.securityquestionpanel.Controls.Add(Me.Label11)
        Me.securityquestionpanel.Controls.Add(Me.Label8)
        Me.securityquestionpanel.Controls.Add(Me.Label7)
        Me.securityquestionpanel.Location = New System.Drawing.Point(0, 0)
        Me.securityquestionpanel.Name = "securityquestionpanel"
        Me.securityquestionpanel.Size = New System.Drawing.Size(837, 557)
        Me.securityquestionpanel.TabIndex = 71
        Me.securityquestionpanel.Visible = False
        '
        'Resetpasswordpanel
        '
        Me.Resetpasswordpanel.Controls.Add(Me.resetbackbtn)
        Me.Resetpasswordpanel.Controls.Add(Me.resetpasssubmitbtn)
        Me.Resetpasswordpanel.Controls.Add(Me.Label6)
        Me.Resetpasswordpanel.Controls.Add(Me.renewpassword)
        Me.Resetpasswordpanel.Controls.Add(Me.newpassword)
        Me.Resetpasswordpanel.Controls.Add(Me.PictureBox3)
        Me.Resetpasswordpanel.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Resetpasswordpanel.Location = New System.Drawing.Point(0, 0)
        Me.Resetpasswordpanel.Name = "Resetpasswordpanel"
        Me.Resetpasswordpanel.Size = New System.Drawing.Size(837, 555)
        Me.Resetpasswordpanel.TabIndex = 81
        Me.Resetpasswordpanel.Visible = False
        '
        'resetbackbtn
        '
        Me.resetbackbtn.BackColor = System.Drawing.Color.Black
        Me.resetbackbtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.resetbackbtn.FlatAppearance.BorderSize = 0
        Me.resetbackbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.resetbackbtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.resetbackbtn.ForeColor = System.Drawing.Color.White
        Me.resetbackbtn.Location = New System.Drawing.Point(32, 500)
        Me.resetbackbtn.Name = "resetbackbtn"
        Me.resetbackbtn.Size = New System.Drawing.Size(68, 27)
        Me.resetbackbtn.TabIndex = 80
        Me.resetbackbtn.Text = "Back"
        Me.resetbackbtn.UseVisualStyleBackColor = False
        '
        'resetpasssubmitbtn
        '
        Me.resetpasssubmitbtn.BackColor = System.Drawing.Color.FromArgb(CType(CType(97, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(87, Byte), Integer))
        Me.resetpasssubmitbtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.resetpasssubmitbtn.FlatAppearance.BorderSize = 0
        Me.resetpasssubmitbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.resetpasssubmitbtn.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.resetpasssubmitbtn.ForeColor = System.Drawing.Color.White
        Me.resetpasssubmitbtn.Location = New System.Drawing.Point(283, 401)
        Me.resetpasssubmitbtn.Name = "resetpasssubmitbtn"
        Me.resetpasssubmitbtn.Size = New System.Drawing.Size(272, 36)
        Me.resetpasssubmitbtn.TabIndex = 70
        Me.resetpasssubmitbtn.Text = "Submit"
        Me.resetpasssubmitbtn.UseVisualStyleBackColor = False
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Segoe UI", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(293, 229)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(252, 45)
        Me.Label6.TabIndex = 69
        Me.Label6.Text = "Reset Password"
        '
        'renewpassword
        '
        Me.renewpassword.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.renewpassword.Location = New System.Drawing.Point(283, 350)
        Me.renewpassword.Multiline = True
        Me.renewpassword.Name = "renewpassword"
        Me.renewpassword.Size = New System.Drawing.Size(272, 36)
        Me.renewpassword.TabIndex = 68
        '
        'newpassword
        '
        Me.newpassword.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.newpassword.Location = New System.Drawing.Point(283, 291)
        Me.newpassword.Multiline = True
        Me.newpassword.Name = "newpassword"
        Me.newpassword.Size = New System.Drawing.Size(272, 36)
        Me.newpassword.TabIndex = 67
        '
        'PictureBox3
        '
        Me.PictureBox3.Image = Global.Login_SignupForm.My.Resources.Resources.resetpasswordimg
        Me.PictureBox3.Location = New System.Drawing.Point(322, 65)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(193, 161)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox3.TabIndex = 0
        Me.PictureBox3.TabStop = False
        '
        'securityQsubmitbtn
        '
        Me.securityQsubmitbtn.BackColor = System.Drawing.Color.FromArgb(CType(CType(97, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(87, Byte), Integer))
        Me.securityQsubmitbtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.securityQsubmitbtn.FlatAppearance.BorderSize = 0
        Me.securityQsubmitbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.securityQsubmitbtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.securityQsubmitbtn.ForeColor = System.Drawing.Color.White
        Me.securityQsubmitbtn.Location = New System.Drawing.Point(680, 476)
        Me.securityQsubmitbtn.Name = "securityQsubmitbtn"
        Me.securityQsubmitbtn.Size = New System.Drawing.Size(93, 32)
        Me.securityQsubmitbtn.TabIndex = 80
        Me.securityQsubmitbtn.Text = "Submit"
        Me.securityQsubmitbtn.UseVisualStyleBackColor = False
        '
        'securityQbackbtn
        '
        Me.securityQbackbtn.BackColor = System.Drawing.Color.Black
        Me.securityQbackbtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.securityQbackbtn.FlatAppearance.BorderSize = 0
        Me.securityQbackbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.securityQbackbtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.securityQbackbtn.ForeColor = System.Drawing.Color.White
        Me.securityQbackbtn.Location = New System.Drawing.Point(32, 500)
        Me.securityQbackbtn.Name = "securityQbackbtn"
        Me.securityQbackbtn.Size = New System.Drawing.Size(68, 27)
        Me.securityQbackbtn.TabIndex = 79
        Me.securityQbackbtn.Text = "Back"
        Me.securityQbackbtn.UseVisualStyleBackColor = False
        '
        'Q1
        '
        Me.Q1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Q1.Location = New System.Drawing.Point(251, 224)
        Me.Q1.Multiline = True
        Me.Q1.Name = "Q1"
        Me.Q1.Size = New System.Drawing.Size(307, 27)
        Me.Q1.TabIndex = 73
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(248, 385)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(255, 24)
        Me.Label9.TabIndex = 78
        Me.Label9.Text = "Who is your favourite athlete?"
        '
        'Q3
        '
        Me.Q3.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Q3.Location = New System.Drawing.Point(251, 418)
        Me.Q3.Multiline = True
        Me.Q3.Name = "Q3"
        Me.Q3.Size = New System.Drawing.Size(307, 27)
        Me.Q3.TabIndex = 77
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(248, 285)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(319, 24)
        Me.Label10.TabIndex = 76
        Me.Label10.Text = "What was your childhood nickname?"
        '
        'Q2
        '
        Me.Q2.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Q2.Location = New System.Drawing.Point(251, 321)
        Me.Q2.Multiline = True
        Me.Q2.Name = "Q2"
        Me.Q2.Size = New System.Drawing.Size(307, 27)
        Me.Q2.TabIndex = 75
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(248, 185)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(310, 24)
        Me.Label11.TabIndex = 74
        Me.Label11.Text = "What was the name of your first pet?"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(137, 50)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(302, 37)
        Me.Label8.TabIndex = 72
        Me.Label8.Text = "Security Questions"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!)
        Me.Label7.Location = New System.Drawing.Point(207, 102)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(459, 24)
        Me.Label7.TabIndex = 71
        Me.Label7.Text = "Answer the security questions to reset your password."
        '
        'backloginbtn
        '
        Me.backloginbtn.BackColor = System.Drawing.Color.Black
        Me.backloginbtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.backloginbtn.FlatAppearance.BorderSize = 0
        Me.backloginbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.backloginbtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.backloginbtn.ForeColor = System.Drawing.Color.White
        Me.backloginbtn.Location = New System.Drawing.Point(32, 500)
        Me.backloginbtn.Name = "backloginbtn"
        Me.backloginbtn.Size = New System.Drawing.Size(68, 27)
        Me.backloginbtn.TabIndex = 69
        Me.backloginbtn.Text = "Back"
        Me.backloginbtn.UseVisualStyleBackColor = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(82, Byte), Integer))
        Me.Label5.Location = New System.Drawing.Point(70, 290)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(51, 19)
        Me.Label5.TabIndex = 68
        Me.Label5.Text = "Email"
        '
        'forgotpassbtn
        '
        Me.forgotpassbtn.BackColor = System.Drawing.Color.FromArgb(CType(CType(97, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(87, Byte), Integer))
        Me.forgotpassbtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.forgotpassbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.forgotpassbtn.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.forgotpassbtn.ForeColor = System.Drawing.Color.White
        Me.forgotpassbtn.Location = New System.Drawing.Point(74, 359)
        Me.forgotpassbtn.Name = "forgotpassbtn"
        Me.forgotpassbtn.Size = New System.Drawing.Size(272, 36)
        Me.forgotpassbtn.TabIndex = 67
        Me.forgotpassbtn.Text = "Submit"
        Me.forgotpassbtn.UseVisualStyleBackColor = False
        '
        'forgetpassemailtxt
        '
        Me.forgetpassemailtxt.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.forgetpassemailtxt.Location = New System.Drawing.Point(74, 312)
        Me.forgetpassemailtxt.Multiline = True
        Me.forgetpassemailtxt.Name = "forgetpassemailtxt"
        Me.forgetpassemailtxt.Size = New System.Drawing.Size(272, 36)
        Me.forgetpassemailtxt.TabIndex = 66
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(71, 225)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(275, 36)
        Me.Label4.TabIndex = 65
        Me.Label4.Text = "To start the password recovery process," & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "please input your email address."
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI Black", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(82, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(66, 114)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(185, 90)
        Me.Label2.TabIndex = 64
        Me.Label2.Text = "Forgot" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Password?"
        '
        'forgotpasspicture
        '
        Me.forgotpasspicture.BackColor = System.Drawing.Color.Transparent
        Me.forgotpasspicture.Image = Global.Login_SignupForm.My.Resources.Resources.forgotpassword1
        Me.forgotpasspicture.Location = New System.Drawing.Point(308, 3)
        Me.forgotpasspicture.Margin = New System.Windows.Forms.Padding(2)
        Me.forgotpasspicture.Name = "forgotpasspicture"
        Me.forgotpasspicture.Size = New System.Drawing.Size(575, 526)
        Me.forgotpasspicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.forgotpasspicture.TabIndex = 63
        Me.forgotpasspicture.TabStop = False
        '
        'dragpanel
        '
        Me.dragpanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(61, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(59, Byte), Integer))
        Me.dragpanel.Controls.Add(Me.maximizebtn)
        Me.dragpanel.Controls.Add(Me.minimizebtn)
        Me.dragpanel.Controls.Add(Me.closebtn)
        Me.dragpanel.Dock = System.Windows.Forms.DockStyle.Top
        Me.dragpanel.Location = New System.Drawing.Point(0, 0)
        Me.dragpanel.Name = "dragpanel"
        Me.dragpanel.Size = New System.Drawing.Size(837, 32)
        Me.dragpanel.TabIndex = 82
        '
        'maximizebtn
        '
        Me.maximizebtn.BackgroundImage = Global.Login_SignupForm.My.Resources.Resources.nomax
        Me.maximizebtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.maximizebtn.FlatAppearance.BorderSize = 0
        Me.maximizebtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.maximizebtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.maximizebtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.maximizebtn.ForeColor = System.Drawing.SystemColors.ControlText
        Me.maximizebtn.Location = New System.Drawing.Point(74, 10)
        Me.maximizebtn.Name = "maximizebtn"
        Me.maximizebtn.Size = New System.Drawing.Size(15, 15)
        Me.maximizebtn.TabIndex = 83
        Me.maximizebtn.UseVisualStyleBackColor = True
        '
        'minimizebtn
        '
        Me.minimizebtn.BackgroundImage = Global.Login_SignupForm.My.Resources.Resources.minimizeplain
        Me.minimizebtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.minimizebtn.FlatAppearance.BorderSize = 0
        Me.minimizebtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.minimizebtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.minimizebtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.minimizebtn.ForeColor = System.Drawing.SystemColors.ControlText
        Me.minimizebtn.Location = New System.Drawing.Point(48, 10)
        Me.minimizebtn.Name = "minimizebtn"
        Me.minimizebtn.Size = New System.Drawing.Size(15, 15)
        Me.minimizebtn.TabIndex = 82
        Me.minimizebtn.UseVisualStyleBackColor = True
        '
        'closebtn
        '
        Me.closebtn.BackgroundImage = Global.Login_SignupForm.My.Resources.Resources.closeplain
        Me.closebtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.closebtn.FlatAppearance.BorderSize = 0
        Me.closebtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.closebtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.closebtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.closebtn.ForeColor = System.Drawing.SystemColors.ControlText
        Me.closebtn.Location = New System.Drawing.Point(22, 10)
        Me.closebtn.Name = "closebtn"
        Me.closebtn.Size = New System.Drawing.Size(15, 15)
        Me.closebtn.TabIndex = 81
        Me.closebtn.UseVisualStyleBackColor = True
        '
        'Login
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.WhiteSmoke
        Me.BackgroundImage = Global.Login_SignupForm.My.Resources.Resources.LF8
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(837, 587)
        Me.Controls.Add(Me.dragpanel)
        Me.Controls.Add(Me.forgotpasswordpanel)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.hideit)
        Me.Controls.Add(Me.showpasslogo)
        Me.Controls.Add(Me.hidepasslogo)
        Me.Controls.Add(Me.loginbtn)
        Me.Controls.Add(Me.signuplabel)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.forgetpasslabel)
        Me.Controls.Add(Me.passwordtextbox)
        Me.Controls.Add(Me.passwordlogo)
        Me.Controls.Add(Me.usernamelogo)
        Me.Controls.Add(Me.usernametextbox)
        Me.Controls.Add(Me.wallpaper)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.MaximizeBox = False
        Me.Name = "Login"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Login"
        CType(Me.hideit, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.showpasslogo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.hidepasslogo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.passwordlogo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.usernamelogo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.wallpaper, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.forgotpasswordpanel.ResumeLayout(False)
        Me.forgotpasswordpanel.PerformLayout()
        Me.securityquestionpanel.ResumeLayout(False)
        Me.securityquestionpanel.PerformLayout()
        Me.Resetpasswordpanel.ResumeLayout(False)
        Me.Resetpasswordpanel.PerformLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.forgotpasspicture, System.ComponentModel.ISupportInitialize).EndInit()
        Me.dragpanel.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents loginbtn As Button
    Friend WithEvents signuplabel As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents forgetpasslabel As Label
    Friend WithEvents passwordtextbox As TextBox
    Friend WithEvents passwordlogo As PictureBox
    Friend WithEvents usernamelogo As PictureBox
    Friend WithEvents usernametextbox As TextBox
    Friend WithEvents wallpaper As PictureBox
    Friend WithEvents hidepasslogo As PictureBox
    Friend WithEvents showpasslogo As PictureBox
    Friend WithEvents hideit As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Timer1 As Timer
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents forgotpasswordpanel As Panel
    Friend WithEvents backloginbtn As Button
    Friend WithEvents Label5 As Label
    Friend WithEvents forgotpassbtn As Button
    Friend WithEvents forgetpassemailtxt As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents forgotpasspicture As PictureBox
    Friend WithEvents securityquestionpanel As Panel
    Friend WithEvents securityQsubmitbtn As Button
    Friend WithEvents securityQbackbtn As Button
    Friend WithEvents Q1 As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents Q3 As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents Q2 As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Resetpasswordpanel As Panel
    Friend WithEvents resetpasssubmitbtn As Button
    Friend WithEvents Label6 As Label
    Friend WithEvents renewpassword As TextBox
    Friend WithEvents newpassword As TextBox
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents resetbackbtn As Button
    Friend WithEvents dragpanel As Panel
    Friend WithEvents maximizebtn As Button
    Friend WithEvents minimizebtn As Button
    Friend WithEvents closebtn As Button
End Class
