<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class userindex
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
        Me.forformdisplay = New System.Windows.Forms.Panel()
        Me.menupanel = New System.Windows.Forms.Panel()
        Me.midpanel = New System.Windows.Forms.Panel()
        Me.dashboardbtn = New System.Windows.Forms.Button()
        Me.mybidsbtn = New System.Windows.Forms.Button()
        Me.browsebtn = New System.Windows.Forms.Button()
        Me.homebtn = New System.Windows.Forms.Button()
        Me.toppanel = New System.Windows.Forms.Panel()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.profilename = New System.Windows.Forms.Label()
        Me.profilephoto = New System.Windows.Forms.PictureBox()
        Me.navslidebtn = New System.Windows.Forms.Button()
        Me.settingbtn = New System.Windows.Forms.Button()
        Me.logoutbtn = New System.Windows.Forms.Button()
        Me.menupanel.SuspendLayout()
        Me.midpanel.SuspendLayout()
        Me.toppanel.SuspendLayout()
        Me.TableLayoutPanel1.SuspendLayout()
        CType(Me.profilephoto, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'forformdisplay
        '
        Me.forformdisplay.Location = New System.Drawing.Point(78, 1)
        Me.forformdisplay.Name = "forformdisplay"
        Me.forformdisplay.Size = New System.Drawing.Size(998, 719)
        Me.forformdisplay.TabIndex = 7
        '
        'menupanel
        '
        Me.menupanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(93, Byte), Integer), CType(CType(140, Byte), Integer), CType(CType(116, Byte), Integer))
        Me.menupanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.menupanel.Controls.Add(Me.midpanel)
        Me.menupanel.Controls.Add(Me.toppanel)
        Me.menupanel.Controls.Add(Me.settingbtn)
        Me.menupanel.Controls.Add(Me.logoutbtn)
        Me.menupanel.Dock = System.Windows.Forms.DockStyle.Left
        Me.menupanel.Location = New System.Drawing.Point(0, 0)
        Me.menupanel.Name = "menupanel"
        Me.menupanel.Size = New System.Drawing.Size(77, 681)
        Me.menupanel.TabIndex = 6
        '
        'midpanel
        '
        Me.midpanel.Controls.Add(Me.dashboardbtn)
        Me.midpanel.Controls.Add(Me.mybidsbtn)
        Me.midpanel.Controls.Add(Me.browsebtn)
        Me.midpanel.Controls.Add(Me.homebtn)
        Me.midpanel.Dock = System.Windows.Forms.DockStyle.Top
        Me.midpanel.Location = New System.Drawing.Point(0, 205)
        Me.midpanel.Name = "midpanel"
        Me.midpanel.Size = New System.Drawing.Size(75, 335)
        Me.midpanel.TabIndex = 21
        '
        'dashboardbtn
        '
        Me.dashboardbtn.BackColor = System.Drawing.Color.FromArgb(CType(CType(93, Byte), Integer), CType(CType(140, Byte), Integer), CType(CType(116, Byte), Integer))
        Me.dashboardbtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.dashboardbtn.Dock = System.Windows.Forms.DockStyle.Top
        Me.dashboardbtn.FlatAppearance.BorderSize = 0
        Me.dashboardbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.dashboardbtn.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Bold)
        Me.dashboardbtn.Image = Global.Login_SignupForm.My.Resources.Resources.dash_board
        Me.dashboardbtn.Location = New System.Drawing.Point(0, 240)
        Me.dashboardbtn.Name = "dashboardbtn"
        Me.dashboardbtn.Size = New System.Drawing.Size(75, 80)
        Me.dashboardbtn.TabIndex = 22
        Me.dashboardbtn.UseVisualStyleBackColor = False
        '
        'mybidsbtn
        '
        Me.mybidsbtn.BackColor = System.Drawing.Color.FromArgb(CType(CType(93, Byte), Integer), CType(CType(140, Byte), Integer), CType(CType(116, Byte), Integer))
        Me.mybidsbtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.mybidsbtn.Dock = System.Windows.Forms.DockStyle.Top
        Me.mybidsbtn.FlatAppearance.BorderSize = 0
        Me.mybidsbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.mybidsbtn.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Bold)
        Me.mybidsbtn.Image = Global.Login_SignupForm.My.Resources.Resources.usercontrol
        Me.mybidsbtn.Location = New System.Drawing.Point(0, 160)
        Me.mybidsbtn.Name = "mybidsbtn"
        Me.mybidsbtn.Size = New System.Drawing.Size(75, 80)
        Me.mybidsbtn.TabIndex = 21
        Me.mybidsbtn.UseVisualStyleBackColor = False
        '
        'browsebtn
        '
        Me.browsebtn.BackColor = System.Drawing.Color.FromArgb(CType(CType(93, Byte), Integer), CType(CType(140, Byte), Integer), CType(CType(116, Byte), Integer))
        Me.browsebtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.browsebtn.Dock = System.Windows.Forms.DockStyle.Top
        Me.browsebtn.FlatAppearance.BorderSize = 0
        Me.browsebtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.browsebtn.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Bold)
        Me.browsebtn.Image = Global.Login_SignupForm.My.Resources.Resources.manageauc
        Me.browsebtn.Location = New System.Drawing.Point(0, 80)
        Me.browsebtn.Name = "browsebtn"
        Me.browsebtn.Size = New System.Drawing.Size(75, 80)
        Me.browsebtn.TabIndex = 20
        Me.browsebtn.UseVisualStyleBackColor = False
        '
        'homebtn
        '
        Me.homebtn.BackColor = System.Drawing.Color.FromArgb(CType(CType(93, Byte), Integer), CType(CType(140, Byte), Integer), CType(CType(116, Byte), Integer))
        Me.homebtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.homebtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.homebtn.Dock = System.Windows.Forms.DockStyle.Top
        Me.homebtn.FlatAppearance.BorderSize = 0
        Me.homebtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.homebtn.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.homebtn.Image = Global.Login_SignupForm.My.Resources.Resources.product1
        Me.homebtn.Location = New System.Drawing.Point(0, 0)
        Me.homebtn.Name = "homebtn"
        Me.homebtn.Size = New System.Drawing.Size(75, 80)
        Me.homebtn.TabIndex = 17
        Me.homebtn.UseVisualStyleBackColor = False
        '
        'toppanel
        '
        Me.toppanel.Controls.Add(Me.TableLayoutPanel1)
        Me.toppanel.Controls.Add(Me.profilephoto)
        Me.toppanel.Controls.Add(Me.navslidebtn)
        Me.toppanel.Dock = System.Windows.Forms.DockStyle.Top
        Me.toppanel.Location = New System.Drawing.Point(0, 0)
        Me.toppanel.Name = "toppanel"
        Me.toppanel.Size = New System.Drawing.Size(75, 205)
        Me.toppanel.TabIndex = 20
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 1
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.profilename, 0, 0)
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 141)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 1
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(284, 35)
        Me.TableLayoutPanel1.TabIndex = 4
        '
        'profilename
        '
        Me.profilename.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.profilename.AutoSize = True
        Me.profilename.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.profilename.Location = New System.Drawing.Point(111, 5)
        Me.profilename.Name = "profilename"
        Me.profilename.Size = New System.Drawing.Size(61, 24)
        Me.profilename.TabIndex = 4
        Me.profilename.Text = "Name"
        Me.profilename.Visible = False
        '
        'profilephoto
        '
        Me.profilephoto.BackColor = System.Drawing.Color.Gainsboro
        Me.profilephoto.Cursor = System.Windows.Forms.Cursors.Hand
        Me.profilephoto.Location = New System.Drawing.Point(92, 43)
        Me.profilephoto.Name = "profilephoto"
        Me.profilephoto.Size = New System.Drawing.Size(100, 100)
        Me.profilephoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.profilephoto.TabIndex = 3
        Me.profilephoto.TabStop = False
        Me.profilephoto.Visible = False
        '
        'navslidebtn
        '
        Me.navslidebtn.BackColor = System.Drawing.Color.FromArgb(CType(CType(93, Byte), Integer), CType(CType(140, Byte), Integer), CType(CType(116, Byte), Integer))
        Me.navslidebtn.BackgroundImage = Global.Login_SignupForm.My.Resources.Resources.menuu
        Me.navslidebtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.navslidebtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.navslidebtn.FlatAppearance.BorderSize = 0
        Me.navslidebtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(93, Byte), Integer), CType(CType(140, Byte), Integer), CType(CType(116, Byte), Integer))
        Me.navslidebtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(93, Byte), Integer), CType(CType(140, Byte), Integer), CType(CType(116, Byte), Integer))
        Me.navslidebtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.navslidebtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.navslidebtn.ForeColor = System.Drawing.Color.White
        Me.navslidebtn.Location = New System.Drawing.Point(13, 12)
        Me.navslidebtn.Name = "navslidebtn"
        Me.navslidebtn.Size = New System.Drawing.Size(36, 36)
        Me.navslidebtn.TabIndex = 2
        Me.navslidebtn.UseVisualStyleBackColor = False
        '
        'settingbtn
        '
        Me.settingbtn.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.settingbtn.BackColor = System.Drawing.Color.FromArgb(CType(CType(93, Byte), Integer), CType(CType(140, Byte), Integer), CType(CType(116, Byte), Integer))
        Me.settingbtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.settingbtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.settingbtn.FlatAppearance.BorderSize = 0
        Me.settingbtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(93, Byte), Integer), CType(CType(140, Byte), Integer), CType(CType(116, Byte), Integer))
        Me.settingbtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(93, Byte), Integer), CType(CType(140, Byte), Integer), CType(CType(116, Byte), Integer))
        Me.settingbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.settingbtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.settingbtn.ForeColor = System.Drawing.Color.White
        Me.settingbtn.Location = New System.Drawing.Point(13, 613)
        Me.settingbtn.Name = "settingbtn"
        Me.settingbtn.Size = New System.Drawing.Size(45, 44)
        Me.settingbtn.TabIndex = 5
        Me.settingbtn.UseVisualStyleBackColor = False
        Me.settingbtn.Visible = False
        '
        'logoutbtn
        '
        Me.logoutbtn.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.logoutbtn.BackColor = System.Drawing.Color.FromArgb(CType(CType(93, Byte), Integer), CType(CType(140, Byte), Integer), CType(CType(116, Byte), Integer))
        Me.logoutbtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.logoutbtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.logoutbtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(93, Byte), Integer), CType(CType(140, Byte), Integer), CType(CType(116, Byte), Integer))
        Me.logoutbtn.FlatAppearance.BorderSize = 0
        Me.logoutbtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(93, Byte), Integer), CType(CType(140, Byte), Integer), CType(CType(116, Byte), Integer))
        Me.logoutbtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(93, Byte), Integer), CType(CType(140, Byte), Integer), CType(CType(116, Byte), Integer))
        Me.logoutbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.logoutbtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.logoutbtn.ForeColor = System.Drawing.Color.FromArgb(CType(CType(93, Byte), Integer), CType(CType(140, Byte), Integer), CType(CType(116, Byte), Integer))
        Me.logoutbtn.Location = New System.Drawing.Point(12, 611)
        Me.logoutbtn.Name = "logoutbtn"
        Me.logoutbtn.Size = New System.Drawing.Size(50, 50)
        Me.logoutbtn.TabIndex = 4
        Me.logoutbtn.UseVisualStyleBackColor = False
        Me.logoutbtn.Visible = False
        '
        'userindex
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1075, 681)
        Me.Controls.Add(Me.forformdisplay)
        Me.Controls.Add(Me.menupanel)
        Me.Name = "userindex"
        Me.Text = "userindex"
        Me.menupanel.ResumeLayout(False)
        Me.midpanel.ResumeLayout(False)
        Me.toppanel.ResumeLayout(False)
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        CType(Me.profilephoto, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents forformdisplay As Panel
    Friend WithEvents menupanel As Panel
    Friend WithEvents midpanel As Panel
    Friend WithEvents dashboardbtn As Button
    Friend WithEvents mybidsbtn As Button
    Friend WithEvents browsebtn As Button
    Friend WithEvents homebtn As Button
    Friend WithEvents toppanel As Panel
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents profilename As Label
    Friend WithEvents profilephoto As PictureBox
    Friend WithEvents navslidebtn As Button
    Friend WithEvents settingbtn As Button
    Friend WithEvents logoutbtn As Button
End Class
