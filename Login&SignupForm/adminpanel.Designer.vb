<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class adminpanel
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
        Me.menupanel = New System.Windows.Forms.Panel()
        Me.midpanel = New System.Windows.Forms.Panel()
        Me.reportsbtn = New System.Windows.Forms.Button()
        Me.dashboardbtn = New System.Windows.Forms.Button()
        Me.usersbtn = New System.Windows.Forms.Button()
        Me.manageauctionbtn = New System.Windows.Forms.Button()
        Me.addproductbtn = New System.Windows.Forms.Button()
        Me.toppanel = New System.Windows.Forms.Panel()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.profilename = New System.Windows.Forms.Label()
        Me.profilephoto = New System.Windows.Forms.PictureBox()
        Me.navslidebtn = New System.Windows.Forms.Button()
        Me.settingbtn = New System.Windows.Forms.Button()
        Me.logoutbtn = New System.Windows.Forms.Button()
        Me.foraddproduct = New System.Windows.Forms.Panel()
        Me.menupanel.SuspendLayout()
        Me.midpanel.SuspendLayout()
        Me.toppanel.SuspendLayout()
        Me.TableLayoutPanel1.SuspendLayout()
        CType(Me.profilephoto, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
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
        Me.menupanel.TabIndex = 0
        '
        'midpanel
        '
        Me.midpanel.Controls.Add(Me.reportsbtn)
        Me.midpanel.Controls.Add(Me.dashboardbtn)
        Me.midpanel.Controls.Add(Me.usersbtn)
        Me.midpanel.Controls.Add(Me.manageauctionbtn)
        Me.midpanel.Controls.Add(Me.addproductbtn)
        Me.midpanel.Dock = System.Windows.Forms.DockStyle.Top
        Me.midpanel.Location = New System.Drawing.Point(0, 205)
        Me.midpanel.Name = "midpanel"
        Me.midpanel.Size = New System.Drawing.Size(75, 408)
        Me.midpanel.TabIndex = 21
        '
        'reportsbtn
        '
        Me.reportsbtn.BackColor = System.Drawing.Color.FromArgb(CType(CType(93, Byte), Integer), CType(CType(140, Byte), Integer), CType(CType(116, Byte), Integer))
        Me.reportsbtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.reportsbtn.Dock = System.Windows.Forms.DockStyle.Top
        Me.reportsbtn.FlatAppearance.BorderSize = 0
        Me.reportsbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.reportsbtn.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Bold)
        Me.reportsbtn.Location = New System.Drawing.Point(0, 320)
        Me.reportsbtn.Name = "reportsbtn"
        Me.reportsbtn.Size = New System.Drawing.Size(75, 80)
        Me.reportsbtn.TabIndex = 23
        Me.reportsbtn.Text = "Extra"
        Me.reportsbtn.UseVisualStyleBackColor = False
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
        'usersbtn
        '
        Me.usersbtn.BackColor = System.Drawing.Color.FromArgb(CType(CType(93, Byte), Integer), CType(CType(140, Byte), Integer), CType(CType(116, Byte), Integer))
        Me.usersbtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.usersbtn.Dock = System.Windows.Forms.DockStyle.Top
        Me.usersbtn.FlatAppearance.BorderSize = 0
        Me.usersbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.usersbtn.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Bold)
        Me.usersbtn.Image = Global.Login_SignupForm.My.Resources.Resources.usercontrol
        Me.usersbtn.Location = New System.Drawing.Point(0, 160)
        Me.usersbtn.Name = "usersbtn"
        Me.usersbtn.Size = New System.Drawing.Size(75, 80)
        Me.usersbtn.TabIndex = 21
        Me.usersbtn.UseVisualStyleBackColor = False
        '
        'manageauctionbtn
        '
        Me.manageauctionbtn.BackColor = System.Drawing.Color.FromArgb(CType(CType(93, Byte), Integer), CType(CType(140, Byte), Integer), CType(CType(116, Byte), Integer))
        Me.manageauctionbtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.manageauctionbtn.Dock = System.Windows.Forms.DockStyle.Top
        Me.manageauctionbtn.FlatAppearance.BorderSize = 0
        Me.manageauctionbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.manageauctionbtn.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Bold)
        Me.manageauctionbtn.Image = Global.Login_SignupForm.My.Resources.Resources.manageauc
        Me.manageauctionbtn.Location = New System.Drawing.Point(0, 80)
        Me.manageauctionbtn.Name = "manageauctionbtn"
        Me.manageauctionbtn.Size = New System.Drawing.Size(75, 80)
        Me.manageauctionbtn.TabIndex = 20
        Me.manageauctionbtn.UseVisualStyleBackColor = False
        '
        'addproductbtn
        '
        Me.addproductbtn.BackColor = System.Drawing.Color.FromArgb(CType(CType(93, Byte), Integer), CType(CType(140, Byte), Integer), CType(CType(116, Byte), Integer))
        Me.addproductbtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.addproductbtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.addproductbtn.Dock = System.Windows.Forms.DockStyle.Top
        Me.addproductbtn.FlatAppearance.BorderSize = 0
        Me.addproductbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.addproductbtn.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.addproductbtn.Image = Global.Login_SignupForm.My.Resources.Resources.product1
        Me.addproductbtn.Location = New System.Drawing.Point(0, 0)
        Me.addproductbtn.Name = "addproductbtn"
        Me.addproductbtn.Size = New System.Drawing.Size(75, 80)
        Me.addproductbtn.TabIndex = 17
        Me.addproductbtn.UseVisualStyleBackColor = False
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
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(271, 35)
        Me.TableLayoutPanel1.TabIndex = 4
        '
        'profilename
        '
        Me.profilename.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.profilename.AutoSize = True
        Me.profilename.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.profilename.Location = New System.Drawing.Point(105, 5)
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
        Me.profilephoto.Image = Global.Login_SignupForm.My.Resources.Resources.userphoto
        Me.profilephoto.Location = New System.Drawing.Point(86, 44)
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
        'foraddproduct
        '
        Me.foraddproduct.Location = New System.Drawing.Point(77, 1)
        Me.foraddproduct.Name = "foraddproduct"
        Me.foraddproduct.Size = New System.Drawing.Size(1035, 681)
        Me.foraddproduct.TabIndex = 3
        '
        'adminpanel
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1075, 681)
        Me.Controls.Add(Me.foraddproduct)
        Me.Controls.Add(Me.menupanel)
        Me.MinimumSize = New System.Drawing.Size(450, 39)
        Me.Name = "adminpanel"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form1"
        Me.menupanel.ResumeLayout(False)
        Me.midpanel.ResumeLayout(False)
        Me.toppanel.ResumeLayout(False)
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        CType(Me.profilephoto, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents menupanel As Panel
    Friend WithEvents settingbtn As Button
    Friend WithEvents logoutbtn As Button
    Friend WithEvents foraddproduct As Panel
    Friend WithEvents toppanel As Panel
    Friend WithEvents midpanel As Panel
    Friend WithEvents dashboardbtn As Button
    Friend WithEvents usersbtn As Button
    Friend WithEvents manageauctionbtn As Button
    Friend WithEvents addproductbtn As Button
    Friend WithEvents reportsbtn As Button
    Friend WithEvents navslidebtn As Button
    Friend WithEvents profilephoto As PictureBox
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents profilename As Label
End Class
