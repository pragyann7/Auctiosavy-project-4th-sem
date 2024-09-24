<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class SignUp
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
        Me.passwordtxt = New System.Windows.Forms.TextBox()
        Me.usernametxt = New System.Windows.Forms.TextBox()
        Me.emailtxt = New System.Windows.Forms.TextBox()
        Me.contacttxt = New System.Windows.Forms.TextBox()
        Me.nametxt = New System.Windows.Forms.TextBox()
        Me.termNconditionCheck = New System.Windows.Forms.CheckBox()
        Me.termsandconditions = New System.Windows.Forms.Label()
        Me.alreadyhacc = New System.Windows.Forms.Label()
        Me.loginlabel = New System.Windows.Forms.Label()
        Me.detailsubmit = New System.Windows.Forms.Button()
        Me.passasterick = New System.Windows.Forms.Label()
        Me.usernameerror = New System.Windows.Forms.Label()
        Me.passworderror = New System.Windows.Forms.Label()
        Me.emailerrorlbl = New System.Windows.Forms.Label()
        Me.namelbl = New System.Windows.Forms.Label()
        Me.contactlbl = New System.Windows.Forms.Label()
        Me.emaillbl = New System.Windows.Forms.Label()
        Me.usernamelbl = New System.Windows.Forms.Label()
        Me.passwordlbl = New System.Windows.Forms.Label()
        Me.countrycodeoption = New System.Windows.Forms.ComboBox()
        Me.emailasterick = New System.Windows.Forms.Label()
        Me.userasterick = New System.Windows.Forms.Label()
        Me.recoveryqueriespanel = New System.Windows.Forms.Panel()
        Me.Q1 = New System.Windows.Forms.TextBox()
        Me.recquesubmitbtn = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Q3 = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Q2 = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.backsignupbtn = New System.Windows.Forms.Button()
        Me.PictureBox5 = New System.Windows.Forms.PictureBox()
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.switch = New System.Windows.Forms.Button()
        Me.nolight = New System.Windows.Forms.PictureBox()
        Me.withlight = New System.Windows.Forms.PictureBox()
        Me.dragpanel = New System.Windows.Forms.Panel()
        Me.maximizebtn = New System.Windows.Forms.Button()
        Me.minimizebtn = New System.Windows.Forms.Button()
        Me.closebtn = New System.Windows.Forms.Button()
        Me.recoveryqueriespanel.SuspendLayout()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nolight, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.withlight, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.dragpanel.SuspendLayout()
        Me.SuspendLayout()
        '
        'passwordtxt
        '
        Me.passwordtxt.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.passwordtxt.Location = New System.Drawing.Point(55, 379)
        Me.passwordtxt.Margin = New System.Windows.Forms.Padding(2)
        Me.passwordtxt.Multiline = True
        Me.passwordtxt.Name = "passwordtxt"
        Me.passwordtxt.Size = New System.Drawing.Size(195, 28)
        Me.passwordtxt.TabIndex = 57
        Me.passwordtxt.WordWrap = False
        '
        'usernametxt
        '
        Me.usernametxt.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.usernametxt.Location = New System.Drawing.Point(55, 310)
        Me.usernametxt.Margin = New System.Windows.Forms.Padding(2)
        Me.usernametxt.Multiline = True
        Me.usernametxt.Name = "usernametxt"
        Me.usernametxt.Size = New System.Drawing.Size(195, 28)
        Me.usernametxt.TabIndex = 56
        Me.usernametxt.WordWrap = False
        '
        'emailtxt
        '
        Me.emailtxt.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.emailtxt.Location = New System.Drawing.Point(55, 234)
        Me.emailtxt.Margin = New System.Windows.Forms.Padding(2)
        Me.emailtxt.Multiline = True
        Me.emailtxt.Name = "emailtxt"
        Me.emailtxt.Size = New System.Drawing.Size(195, 28)
        Me.emailtxt.TabIndex = 55
        Me.emailtxt.WordWrap = False
        '
        'contacttxt
        '
        Me.contacttxt.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.contacttxt.Location = New System.Drawing.Point(55, 161)
        Me.contacttxt.Margin = New System.Windows.Forms.Padding(2)
        Me.contacttxt.Multiline = True
        Me.contacttxt.Name = "contacttxt"
        Me.contacttxt.Size = New System.Drawing.Size(195, 28)
        Me.contacttxt.TabIndex = 54
        Me.contacttxt.WordWrap = False
        '
        'nametxt
        '
        Me.nametxt.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nametxt.Location = New System.Drawing.Point(55, 91)
        Me.nametxt.Margin = New System.Windows.Forms.Padding(2)
        Me.nametxt.Multiline = True
        Me.nametxt.Name = "nametxt"
        Me.nametxt.Size = New System.Drawing.Size(195, 28)
        Me.nametxt.TabIndex = 52
        Me.nametxt.WordWrap = False
        '
        'termNconditionCheck
        '
        Me.termNconditionCheck.AutoSize = True
        Me.termNconditionCheck.BackColor = System.Drawing.Color.Transparent
        Me.termNconditionCheck.Cursor = System.Windows.Forms.Cursors.Hand
        Me.termNconditionCheck.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.termNconditionCheck.Location = New System.Drawing.Point(61, 436)
        Me.termNconditionCheck.Name = "termNconditionCheck"
        Me.termNconditionCheck.Size = New System.Drawing.Size(97, 19)
        Me.termNconditionCheck.TabIndex = 65
        Me.termNconditionCheck.Text = "I agree to the"
        Me.termNconditionCheck.UseVisualStyleBackColor = False
        '
        'termsandconditions
        '
        Me.termsandconditions.AutoSize = True
        Me.termsandconditions.BackColor = System.Drawing.Color.Transparent
        Me.termsandconditions.Cursor = System.Windows.Forms.Cursors.Hand
        Me.termsandconditions.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.termsandconditions.ForeColor = System.Drawing.Color.RoyalBlue
        Me.termsandconditions.Location = New System.Drawing.Point(151, 437)
        Me.termsandconditions.Name = "termsandconditions"
        Me.termsandconditions.Size = New System.Drawing.Size(121, 15)
        Me.termsandconditions.TabIndex = 66
        Me.termsandconditions.Text = "terms and conditions"
        '
        'alreadyhacc
        '
        Me.alreadyhacc.AutoSize = True
        Me.alreadyhacc.BackColor = System.Drawing.Color.Transparent
        Me.alreadyhacc.Cursor = System.Windows.Forms.Cursors.Default
        Me.alreadyhacc.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.alreadyhacc.ForeColor = System.Drawing.SystemColors.ControlText
        Me.alreadyhacc.Location = New System.Drawing.Point(74, 515)
        Me.alreadyhacc.Name = "alreadyhacc"
        Me.alreadyhacc.Size = New System.Drawing.Size(146, 15)
        Me.alreadyhacc.TabIndex = 67
        Me.alreadyhacc.Text = "Already have an account?"
        '
        'loginlabel
        '
        Me.loginlabel.AutoSize = True
        Me.loginlabel.BackColor = System.Drawing.Color.Transparent
        Me.loginlabel.Cursor = System.Windows.Forms.Cursors.Hand
        Me.loginlabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.loginlabel.ForeColor = System.Drawing.Color.RoyalBlue
        Me.loginlabel.Location = New System.Drawing.Point(217, 513)
        Me.loginlabel.Name = "loginlabel"
        Me.loginlabel.Size = New System.Drawing.Size(44, 18)
        Me.loginlabel.TabIndex = 68
        Me.loginlabel.Text = "Login"
        '
        'detailsubmit
        '
        Me.detailsubmit.BackColor = System.Drawing.Color.FromArgb(CType(CType(97, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(87, Byte), Integer))
        Me.detailsubmit.Cursor = System.Windows.Forms.Cursors.Hand
        Me.detailsubmit.FlatAppearance.BorderSize = 0
        Me.detailsubmit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.detailsubmit.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold)
        Me.detailsubmit.ForeColor = System.Drawing.Color.White
        Me.detailsubmit.Location = New System.Drawing.Point(94, 471)
        Me.detailsubmit.Margin = New System.Windows.Forms.Padding(2)
        Me.detailsubmit.Name = "detailsubmit"
        Me.detailsubmit.Size = New System.Drawing.Size(143, 30)
        Me.detailsubmit.TabIndex = 69
        Me.detailsubmit.Text = "Submit"
        Me.detailsubmit.UseVisualStyleBackColor = False
        '
        'passasterick
        '
        Me.passasterick.AutoSize = True
        Me.passasterick.BackColor = System.Drawing.Color.White
        Me.passasterick.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.passasterick.ForeColor = System.Drawing.Color.Red
        Me.passasterick.Location = New System.Drawing.Point(230, 380)
        Me.passasterick.Name = "passasterick"
        Me.passasterick.Size = New System.Drawing.Size(17, 24)
        Me.passasterick.TabIndex = 71
        Me.passasterick.Text = "*"
        Me.passasterick.Visible = False
        '
        'usernameerror
        '
        Me.usernameerror.AutoSize = True
        Me.usernameerror.ForeColor = System.Drawing.Color.Red
        Me.usernameerror.Location = New System.Drawing.Point(74, 342)
        Me.usernameerror.Name = "usernameerror"
        Me.usernameerror.Size = New System.Drawing.Size(122, 13)
        Me.usernameerror.TabIndex = 72
        Me.usernameerror.Text = "Username already taken"
        Me.usernameerror.Visible = False
        '
        'passworderror
        '
        Me.passworderror.AutoSize = True
        Me.passworderror.ForeColor = System.Drawing.Color.Red
        Me.passworderror.Location = New System.Drawing.Point(74, 411)
        Me.passworderror.Name = "passworderror"
        Me.passworderror.Size = New System.Drawing.Size(164, 13)
        Me.passworderror.TabIndex = 73
        Me.passworderror.Text = "Password cannot contain spaces"
        Me.passworderror.Visible = False
        '
        'emailerrorlbl
        '
        Me.emailerrorlbl.AutoSize = True
        Me.emailerrorlbl.ForeColor = System.Drawing.Color.Red
        Me.emailerrorlbl.Location = New System.Drawing.Point(74, 267)
        Me.emailerrorlbl.Name = "emailerrorlbl"
        Me.emailerrorlbl.Size = New System.Drawing.Size(146, 13)
        Me.emailerrorlbl.TabIndex = 80
        Me.emailerrorlbl.Text = "Email cannot contain spaces."
        Me.emailerrorlbl.Visible = False
        '
        'namelbl
        '
        Me.namelbl.AutoSize = True
        Me.namelbl.BackColor = System.Drawing.Color.Transparent
        Me.namelbl.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.namelbl.ForeColor = System.Drawing.Color.FromArgb(CType(CType(97, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(87, Byte), Integer))
        Me.namelbl.Location = New System.Drawing.Point(58, 61)
        Me.namelbl.Name = "namelbl"
        Me.namelbl.Padding = New System.Windows.Forms.Padding(5)
        Me.namelbl.Size = New System.Drawing.Size(58, 28)
        Me.namelbl.TabIndex = 81
        Me.namelbl.Text = "Name"
        Me.namelbl.Visible = False
        '
        'contactlbl
        '
        Me.contactlbl.AutoSize = True
        Me.contactlbl.BackColor = System.Drawing.Color.Transparent
        Me.contactlbl.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.contactlbl.ForeColor = System.Drawing.Color.FromArgb(CType(CType(97, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(87, Byte), Integer))
        Me.contactlbl.Location = New System.Drawing.Point(52, 131)
        Me.contactlbl.Name = "contactlbl"
        Me.contactlbl.Padding = New System.Windows.Forms.Padding(5)
        Me.contactlbl.Size = New System.Drawing.Size(73, 28)
        Me.contactlbl.TabIndex = 82
        Me.contactlbl.Text = "Contact"
        Me.contactlbl.Visible = False
        '
        'emaillbl
        '
        Me.emaillbl.AutoSize = True
        Me.emaillbl.BackColor = System.Drawing.Color.Transparent
        Me.emaillbl.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.emaillbl.ForeColor = System.Drawing.Color.FromArgb(CType(CType(97, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(87, Byte), Integer))
        Me.emaillbl.Location = New System.Drawing.Point(52, 204)
        Me.emaillbl.Name = "emaillbl"
        Me.emaillbl.Padding = New System.Windows.Forms.Padding(5)
        Me.emaillbl.Size = New System.Drawing.Size(56, 28)
        Me.emaillbl.TabIndex = 83
        Me.emaillbl.Text = "Email"
        Me.emaillbl.Visible = False
        '
        'usernamelbl
        '
        Me.usernamelbl.AutoSize = True
        Me.usernamelbl.BackColor = System.Drawing.Color.Transparent
        Me.usernamelbl.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.usernamelbl.ForeColor = System.Drawing.Color.FromArgb(CType(CType(97, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(87, Byte), Integer))
        Me.usernamelbl.Location = New System.Drawing.Point(52, 280)
        Me.usernamelbl.Name = "usernamelbl"
        Me.usernamelbl.Padding = New System.Windows.Forms.Padding(5)
        Me.usernamelbl.Size = New System.Drawing.Size(90, 28)
        Me.usernamelbl.TabIndex = 84
        Me.usernamelbl.Text = "Username"
        Me.usernamelbl.Visible = False
        '
        'passwordlbl
        '
        Me.passwordlbl.AutoSize = True
        Me.passwordlbl.BackColor = System.Drawing.Color.Transparent
        Me.passwordlbl.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.passwordlbl.ForeColor = System.Drawing.Color.FromArgb(CType(CType(97, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(87, Byte), Integer))
        Me.passwordlbl.Location = New System.Drawing.Point(58, 349)
        Me.passwordlbl.Name = "passwordlbl"
        Me.passwordlbl.Padding = New System.Windows.Forms.Padding(5)
        Me.passwordlbl.Size = New System.Drawing.Size(87, 28)
        Me.passwordlbl.TabIndex = 85
        Me.passwordlbl.Text = "Password"
        Me.passwordlbl.Visible = False
        '
        'countrycodeoption
        '
        Me.countrycodeoption.FormattingEnabled = True
        Me.countrycodeoption.ItemHeight = 13
        Me.countrycodeoption.Location = New System.Drawing.Point(165, 162)
        Me.countrycodeoption.Name = "countrycodeoption"
        Me.countrycodeoption.Size = New System.Drawing.Size(106, 21)
        Me.countrycodeoption.TabIndex = 91
        '
        'emailasterick
        '
        Me.emailasterick.AutoSize = True
        Me.emailasterick.BackColor = System.Drawing.Color.White
        Me.emailasterick.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.emailasterick.ForeColor = System.Drawing.Color.Red
        Me.emailasterick.Location = New System.Drawing.Point(230, 235)
        Me.emailasterick.Name = "emailasterick"
        Me.emailasterick.Size = New System.Drawing.Size(17, 24)
        Me.emailasterick.TabIndex = 79
        Me.emailasterick.Text = "*"
        Me.emailasterick.Visible = False
        '
        'userasterick
        '
        Me.userasterick.AutoSize = True
        Me.userasterick.BackColor = System.Drawing.Color.White
        Me.userasterick.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.userasterick.ForeColor = System.Drawing.Color.Red
        Me.userasterick.Location = New System.Drawing.Point(230, 312)
        Me.userasterick.Name = "userasterick"
        Me.userasterick.Size = New System.Drawing.Size(17, 24)
        Me.userasterick.TabIndex = 70
        Me.userasterick.Text = "*"
        Me.userasterick.Visible = False
        '
        'recoveryqueriespanel
        '
        Me.recoveryqueriespanel.BackColor = System.Drawing.Color.White
        Me.recoveryqueriespanel.BackgroundImage = Global.Login_SignupForm.My.Resources.Resources.LF3
        Me.recoveryqueriespanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.recoveryqueriespanel.Controls.Add(Me.Q1)
        Me.recoveryqueriespanel.Controls.Add(Me.recquesubmitbtn)
        Me.recoveryqueriespanel.Controls.Add(Me.Label5)
        Me.recoveryqueriespanel.Controls.Add(Me.Q3)
        Me.recoveryqueriespanel.Controls.Add(Me.Label4)
        Me.recoveryqueriespanel.Controls.Add(Me.Q2)
        Me.recoveryqueriespanel.Controls.Add(Me.Label3)
        Me.recoveryqueriespanel.Controls.Add(Me.Label2)
        Me.recoveryqueriespanel.Controls.Add(Me.Label1)
        Me.recoveryqueriespanel.Controls.Add(Me.backsignupbtn)
        Me.recoveryqueriespanel.Location = New System.Drawing.Point(0, 32)
        Me.recoveryqueriespanel.Name = "recoveryqueriespanel"
        Me.recoveryqueriespanel.Size = New System.Drawing.Size(837, 555)
        Me.recoveryqueriespanel.TabIndex = 74
        Me.recoveryqueriespanel.Visible = False
        '
        'Q1
        '
        Me.Q1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!)
        Me.Q1.Location = New System.Drawing.Point(251, 224)
        Me.Q1.Multiline = True
        Me.Q1.Name = "Q1"
        Me.Q1.Size = New System.Drawing.Size(307, 27)
        Me.Q1.TabIndex = 3
        '
        'recquesubmitbtn
        '
        Me.recquesubmitbtn.BackColor = System.Drawing.Color.FromArgb(CType(CType(97, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(87, Byte), Integer))
        Me.recquesubmitbtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.recquesubmitbtn.FlatAppearance.BorderSize = 0
        Me.recquesubmitbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.recquesubmitbtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.recquesubmitbtn.ForeColor = System.Drawing.Color.White
        Me.recquesubmitbtn.Location = New System.Drawing.Point(680, 476)
        Me.recquesubmitbtn.Name = "recquesubmitbtn"
        Me.recquesubmitbtn.Size = New System.Drawing.Size(93, 32)
        Me.recquesubmitbtn.TabIndex = 9
        Me.recquesubmitbtn.Text = "Submit"
        Me.recquesubmitbtn.UseVisualStyleBackColor = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!)
        Me.Label5.Location = New System.Drawing.Point(248, 385)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(255, 24)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "Who is your favourite athlete?"
        '
        'Q3
        '
        Me.Q3.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!)
        Me.Q3.Location = New System.Drawing.Point(252, 418)
        Me.Q3.Multiline = True
        Me.Q3.Name = "Q3"
        Me.Q3.Size = New System.Drawing.Size(307, 27)
        Me.Q3.TabIndex = 7
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!)
        Me.Label4.Location = New System.Drawing.Point(248, 285)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(319, 24)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "What was your childhood nickname?"
        '
        'Q2
        '
        Me.Q2.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!)
        Me.Q2.Location = New System.Drawing.Point(251, 321)
        Me.Q2.Multiline = True
        Me.Q2.Name = "Q2"
        Me.Q2.Size = New System.Drawing.Size(307, 27)
        Me.Q2.TabIndex = 5
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!)
        Me.Label3.Location = New System.Drawing.Point(248, 185)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(310, 24)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "What was the name of your first pet?"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Bold)
        Me.Label2.Location = New System.Drawing.Point(137, 50)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(302, 37)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Security Questions"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!)
        Me.Label1.Location = New System.Drawing.Point(207, 102)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(281, 24)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Incase you forget your password"
        '
        'backsignupbtn
        '
        Me.backsignupbtn.BackColor = System.Drawing.Color.Black
        Me.backsignupbtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.backsignupbtn.FlatAppearance.BorderSize = 0
        Me.backsignupbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.backsignupbtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.backsignupbtn.ForeColor = System.Drawing.Color.White
        Me.backsignupbtn.Location = New System.Drawing.Point(705, 25)
        Me.backsignupbtn.Name = "backsignupbtn"
        Me.backsignupbtn.Size = New System.Drawing.Size(68, 27)
        Me.backsignupbtn.TabIndex = 0
        Me.backsignupbtn.Text = "Back"
        Me.backsignupbtn.UseVisualStyleBackColor = False
        '
        'PictureBox5
        '
        Me.PictureBox5.Image = Global.Login_SignupForm.My.Resources.Resources.passlock
        Me.PictureBox5.Location = New System.Drawing.Point(22, 379)
        Me.PictureBox5.Name = "PictureBox5"
        Me.PictureBox5.Size = New System.Drawing.Size(22, 22)
        Me.PictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox5.TabIndex = 90
        Me.PictureBox5.TabStop = False
        '
        'PictureBox4
        '
        Me.PictureBox4.Image = Global.Login_SignupForm.My.Resources.Resources.user
        Me.PictureBox4.Location = New System.Drawing.Point(22, 313)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(22, 22)
        Me.PictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox4.TabIndex = 89
        Me.PictureBox4.TabStop = False
        '
        'PictureBox3
        '
        Me.PictureBox3.Image = Global.Login_SignupForm.My.Resources.Resources.mail
        Me.PictureBox3.Location = New System.Drawing.Point(22, 237)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(24, 27)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox3.TabIndex = 88
        Me.PictureBox3.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = Global.Login_SignupForm.My.Resources.Resources.phone
        Me.PictureBox2.Location = New System.Drawing.Point(22, 164)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(22, 22)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 87
        Me.PictureBox2.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.Login_SignupForm.My.Resources.Resources.person_13924070
        Me.PictureBox1.Location = New System.Drawing.Point(22, 94)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(22, 22)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 86
        Me.PictureBox1.TabStop = False
        '
        'switch
        '
        Me.switch.BackColor = System.Drawing.Color.Transparent
        Me.switch.BackgroundImage = Global.Login_SignupForm.My.Resources.Resources.switch_off
        Me.switch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.switch.Cursor = System.Windows.Forms.Cursors.Hand
        Me.switch.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.switch.FlatAppearance.BorderSize = 0
        Me.switch.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.switch.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.switch.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.switch.Location = New System.Drawing.Point(779, 37)
        Me.switch.Name = "switch"
        Me.switch.Size = New System.Drawing.Size(46, 36)
        Me.switch.TabIndex = 0
        Me.switch.TabStop = False
        Me.switch.UseVisualStyleBackColor = False
        '
        'nolight
        '
        Me.nolight.BackColor = System.Drawing.Color.Transparent
        Me.nolight.Image = Global.Login_SignupForm.My.Resources.Resources.nolight
        Me.nolight.Location = New System.Drawing.Point(261, 36)
        Me.nolight.Margin = New System.Windows.Forms.Padding(2)
        Me.nolight.Name = "nolight"
        Me.nolight.Size = New System.Drawing.Size(575, 526)
        Me.nolight.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.nolight.TabIndex = 49
        Me.nolight.TabStop = False
        '
        'withlight
        '
        Me.withlight.BackColor = System.Drawing.Color.Transparent
        Me.withlight.Image = Global.Login_SignupForm.My.Resources.Resources.withlight
        Me.withlight.Location = New System.Drawing.Point(261, 36)
        Me.withlight.Margin = New System.Windows.Forms.Padding(2)
        Me.withlight.Name = "withlight"
        Me.withlight.Size = New System.Drawing.Size(575, 526)
        Me.withlight.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.withlight.TabIndex = 51
        Me.withlight.TabStop = False
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
        Me.dragpanel.TabIndex = 92
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
        'SignUp
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(837, 587)
        Me.Controls.Add(Me.dragpanel)
        Me.Controls.Add(Me.recoveryqueriespanel)
        Me.Controls.Add(Me.contacttxt)
        Me.Controls.Add(Me.countrycodeoption)
        Me.Controls.Add(Me.PictureBox5)
        Me.Controls.Add(Me.PictureBox4)
        Me.Controls.Add(Me.PictureBox3)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.passwordlbl)
        Me.Controls.Add(Me.usernamelbl)
        Me.Controls.Add(Me.emaillbl)
        Me.Controls.Add(Me.contactlbl)
        Me.Controls.Add(Me.namelbl)
        Me.Controls.Add(Me.emailerrorlbl)
        Me.Controls.Add(Me.emailasterick)
        Me.Controls.Add(Me.passworderror)
        Me.Controls.Add(Me.usernameerror)
        Me.Controls.Add(Me.passasterick)
        Me.Controls.Add(Me.userasterick)
        Me.Controls.Add(Me.detailsubmit)
        Me.Controls.Add(Me.loginlabel)
        Me.Controls.Add(Me.alreadyhacc)
        Me.Controls.Add(Me.termsandconditions)
        Me.Controls.Add(Me.termNconditionCheck)
        Me.Controls.Add(Me.passwordtxt)
        Me.Controls.Add(Me.usernametxt)
        Me.Controls.Add(Me.emailtxt)
        Me.Controls.Add(Me.nametxt)
        Me.Controls.Add(Me.switch)
        Me.Controls.Add(Me.nolight)
        Me.Controls.Add(Me.withlight)
        Me.ForeColor = System.Drawing.SystemColors.ControlText
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MaximizeBox = False
        Me.Name = "SignUp"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "SignUp"
        Me.recoveryqueriespanel.ResumeLayout(False)
        Me.recoveryqueriespanel.PerformLayout()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nolight, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.withlight, System.ComponentModel.ISupportInitialize).EndInit()
        Me.dragpanel.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents nolight As PictureBox
    Friend WithEvents switch As Button
    Friend WithEvents withlight As PictureBox
    Friend WithEvents passwordtxt As TextBox
    Friend WithEvents usernametxt As TextBox
    Friend WithEvents emailtxt As TextBox
    Friend WithEvents contacttxt As TextBox
    Friend WithEvents nametxt As TextBox
    Friend WithEvents termNconditionCheck As CheckBox
    Friend WithEvents termsandconditions As Label
    Friend WithEvents alreadyhacc As Label
    Friend WithEvents loginlabel As Label
    Friend WithEvents detailsubmit As Button
    Friend WithEvents passasterick As Label
    Friend WithEvents usernameerror As Label
    Friend WithEvents passworderror As Label
    Friend WithEvents recoveryqueriespanel As Panel
    Friend WithEvents backsignupbtn As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Q3 As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Q2 As TextBox
    Friend WithEvents recquesubmitbtn As Button
    Friend WithEvents Q1 As TextBox
    Friend WithEvents emailerrorlbl As Label
    Friend WithEvents namelbl As Label
    Friend WithEvents contactlbl As Label
    Friend WithEvents emaillbl As Label
    Friend WithEvents usernamelbl As Label
    Friend WithEvents passwordlbl As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents PictureBox4 As PictureBox
    Friend WithEvents PictureBox5 As PictureBox
    Friend WithEvents countrycodeoption As ComboBox
    Friend WithEvents emailasterick As Label
    Friend WithEvents userasterick As Label
    Friend WithEvents dragpanel As Panel
    Friend WithEvents maximizebtn As Button
    Friend WithEvents minimizebtn As Button
    Friend WithEvents closebtn As Button
End Class
