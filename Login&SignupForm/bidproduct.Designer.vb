<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class bidproduct
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
        Me.topbar = New System.Windows.Forms.Panel()
        Me.backtoproduct = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.confirmbid = New System.Windows.Forms.Button()
        Me.bidtxtbox = New System.Windows.Forms.TextBox()
        Me.lblCountdown = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel()
        Me.productnamelbl = New System.Windows.Forms.Label()
        Me.productidlbl = New System.Windows.Forms.Label()
        Me.label2 = New System.Windows.Forms.Label()
        Me.productimg = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.startingprice = New System.Windows.Forms.Label()
        Me.statuslbl = New System.Windows.Forms.Label()
        Me.descriptiontxtbox = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Astartingtimelbl = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Aendingtimelbl = New System.Windows.Forms.Label()
        Me.livebidshow = New System.Windows.Forms.Panel()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.pdbidlbl = New System.Windows.Forms.Label()
        Me.timerCountdown = New System.Windows.Forms.Timer(Me.components)
        Me.ListView1 = New System.Windows.Forms.ListView()
        Me.topbar.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.TableLayoutPanel2.SuspendLayout()
        CType(Me.productimg, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.livebidshow.SuspendLayout()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'topbar
        '
        Me.topbar.BackColor = System.Drawing.Color.FromArgb(CType(CType(93, Byte), Integer), CType(CType(140, Byte), Integer), CType(CType(116, Byte), Integer))
        Me.topbar.Controls.Add(Me.backtoproduct)
        Me.topbar.Dock = System.Windows.Forms.DockStyle.Top
        Me.topbar.Location = New System.Drawing.Point(0, 0)
        Me.topbar.Name = "topbar"
        Me.topbar.Size = New System.Drawing.Size(1014, 50)
        Me.topbar.TabIndex = 49
        '
        'backtoproduct
        '
        Me.backtoproduct.BackColor = System.Drawing.Color.Black
        Me.backtoproduct.Cursor = System.Windows.Forms.Cursors.Hand
        Me.backtoproduct.FlatAppearance.BorderSize = 0
        Me.backtoproduct.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.backtoproduct.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.backtoproduct.ForeColor = System.Drawing.Color.White
        Me.backtoproduct.Location = New System.Drawing.Point(791, 8)
        Me.backtoproduct.Name = "backtoproduct"
        Me.backtoproduct.Size = New System.Drawing.Size(136, 34)
        Me.backtoproduct.TabIndex = 105
        Me.backtoproduct.Text = "Back"
        Me.backtoproduct.UseVisualStyleBackColor = False
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Gainsboro
        Me.Panel1.Controls.Add(Me.confirmbid)
        Me.Panel1.Controls.Add(Me.bidtxtbox)
        Me.Panel1.Controls.Add(Me.lblCountdown)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.TableLayoutPanel2)
        Me.Panel1.Controls.Add(Me.productidlbl)
        Me.Panel1.Controls.Add(Me.label2)
        Me.Panel1.Controls.Add(Me.productimg)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.startingprice)
        Me.Panel1.Controls.Add(Me.statuslbl)
        Me.Panel1.Controls.Add(Me.descriptiontxtbox)
        Me.Panel1.Controls.Add(Me.Label8)
        Me.Panel1.Controls.Add(Me.Label7)
        Me.Panel1.Location = New System.Drawing.Point(36, 56)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(649, 571)
        Me.Panel1.TabIndex = 104
        '
        'confirmbid
        '
        Me.confirmbid.BackColor = System.Drawing.Color.FromArgb(CType(CType(93, Byte), Integer), CType(CType(140, Byte), Integer), CType(CType(116, Byte), Integer))
        Me.confirmbid.FlatAppearance.BorderSize = 0
        Me.confirmbid.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.confirmbid.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.confirmbid.ForeColor = System.Drawing.Color.White
        Me.confirmbid.Location = New System.Drawing.Point(188, 520)
        Me.confirmbid.Name = "confirmbid"
        Me.confirmbid.Size = New System.Drawing.Size(250, 35)
        Me.confirmbid.TabIndex = 121
        Me.confirmbid.Text = "Bid"
        Me.confirmbid.UseVisualStyleBackColor = False
        Me.confirmbid.Visible = False
        '
        'bidtxtbox
        '
        Me.bidtxtbox.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bidtxtbox.Location = New System.Drawing.Point(188, 483)
        Me.bidtxtbox.Multiline = True
        Me.bidtxtbox.Name = "bidtxtbox"
        Me.bidtxtbox.Size = New System.Drawing.Size(250, 31)
        Me.bidtxtbox.TabIndex = 120
        Me.bidtxtbox.Visible = False
        '
        'lblCountdown
        '
        Me.lblCountdown.AutoSize = True
        Me.lblCountdown.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCountdown.Location = New System.Drawing.Point(492, 13)
        Me.lblCountdown.Name = "lblCountdown"
        Me.lblCountdown.Size = New System.Drawing.Size(81, 18)
        Me.lblCountdown.TabIndex = 117
        Me.lblCountdown.Text = "countdown"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(55, 332)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(132, 25)
        Me.Label3.TabIndex = 116
        Me.Label3.Text = "Description :"
        '
        'TableLayoutPanel2
        '
        Me.TableLayoutPanel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(93, Byte), Integer), CType(CType(140, Byte), Integer), CType(CType(116, Byte), Integer))
        Me.TableLayoutPanel2.ColumnCount = 1
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel2.Controls.Add(Me.productnamelbl, 0, 0)
        Me.TableLayoutPanel2.Location = New System.Drawing.Point(0, 274)
        Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
        Me.TableLayoutPanel2.RowCount = 1
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel2.Size = New System.Drawing.Size(649, 50)
        Me.TableLayoutPanel2.TabIndex = 115
        '
        'productnamelbl
        '
        Me.productnamelbl.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.productnamelbl.AutoSize = True
        Me.productnamelbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.productnamelbl.ForeColor = System.Drawing.Color.White
        Me.productnamelbl.Location = New System.Drawing.Point(235, 10)
        Me.productnamelbl.Name = "productnamelbl"
        Me.productnamelbl.Size = New System.Drawing.Size(179, 29)
        Me.productnamelbl.TabIndex = 116
        Me.productnamelbl.Text = "Product Name"
        Me.productnamelbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'productidlbl
        '
        Me.productidlbl.AutoSize = True
        Me.productidlbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.productidlbl.Location = New System.Drawing.Point(25, 235)
        Me.productidlbl.Name = "productidlbl"
        Me.productidlbl.Size = New System.Drawing.Size(108, 25)
        Me.productidlbl.TabIndex = 112
        Me.productidlbl.Text = "00p12345"
        Me.productidlbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'label2
        '
        Me.label2.AutoSize = True
        Me.label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label2.Location = New System.Drawing.Point(25, 206)
        Me.label2.Name = "label2"
        Me.label2.Size = New System.Drawing.Size(124, 25)
        Me.label2.TabIndex = 111
        Me.label2.Text = "Product ID :"
        Me.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'productimg
        '
        Me.productimg.BackColor = System.Drawing.Color.White
        Me.productimg.Image = Global.Login_SignupForm.My.Resources.Resources.add_image
        Me.productimg.Location = New System.Drawing.Point(188, 13)
        Me.productimg.Name = "productimg"
        Me.productimg.Size = New System.Drawing.Size(250, 250)
        Me.productimg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.productimg.TabIndex = 110
        Me.productimg.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(494, 233)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(18, 20)
        Me.Label1.TabIndex = 109
        Me.Label1.Text = "₹"
        '
        'startingprice
        '
        Me.startingprice.AutoSize = True
        Me.startingprice.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.startingprice.Location = New System.Drawing.Point(506, 231)
        Me.startingprice.Name = "startingprice"
        Me.startingprice.Size = New System.Drawing.Size(91, 29)
        Me.startingprice.TabIndex = 107
        Me.startingprice.Text = "999999"
        '
        'statuslbl
        '
        Me.statuslbl.AutoSize = True
        Me.statuslbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.statuslbl.Location = New System.Drawing.Point(17, 39)
        Me.statuslbl.Name = "statuslbl"
        Me.statuslbl.Size = New System.Drawing.Size(89, 25)
        Me.statuslbl.TabIndex = 106
        Me.statuslbl.Text = "pending"
        Me.statuslbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'descriptiontxtbox
        '
        Me.descriptiontxtbox.BackColor = System.Drawing.Color.White
        Me.descriptiontxtbox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.descriptiontxtbox.Cursor = System.Windows.Forms.Cursors.Default
        Me.descriptiontxtbox.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.descriptiontxtbox.Location = New System.Drawing.Point(60, 360)
        Me.descriptiontxtbox.Multiline = True
        Me.descriptiontxtbox.Name = "descriptiontxtbox"
        Me.descriptiontxtbox.ReadOnly = True
        Me.descriptiontxtbox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.descriptiontxtbox.Size = New System.Drawing.Size(530, 100)
        Me.descriptiontxtbox.TabIndex = 105
        Me.descriptiontxtbox.Text = "No Description"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(465, 202)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(165, 29)
        Me.Label8.TabIndex = 104
        Me.Label8.Text = "Asking Price : "
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(17, 16)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(85, 25)
        Me.Label7.TabIndex = 103
        Me.Label7.Text = "Status :"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(798, 445)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(103, 18)
        Me.Label9.TabIndex = 85
        Me.Label9.Text = "Starting Time :"
        '
        'Astartingtimelbl
        '
        Me.Astartingtimelbl.AutoSize = True
        Me.Astartingtimelbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Astartingtimelbl.Location = New System.Drawing.Point(755, 469)
        Me.Astartingtimelbl.Name = "Astartingtimelbl"
        Me.Astartingtimelbl.Size = New System.Drawing.Size(199, 24)
        Me.Astartingtimelbl.TabIndex = 87
        Me.Astartingtimelbl.Text = "2001/9/11 12:00:00 AM"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(813, 509)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(79, 18)
        Me.Label10.TabIndex = 86
        Me.Label10.Text = "End Time :"
        '
        'Aendingtimelbl
        '
        Me.Aendingtimelbl.AutoSize = True
        Me.Aendingtimelbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Aendingtimelbl.Location = New System.Drawing.Point(755, 534)
        Me.Aendingtimelbl.Name = "Aendingtimelbl"
        Me.Aendingtimelbl.Size = New System.Drawing.Size(199, 24)
        Me.Aendingtimelbl.TabIndex = 88
        Me.Aendingtimelbl.Text = "2001/9/11 12:00:00 AM"
        '
        'livebidshow
        '
        Me.livebidshow.BackColor = System.Drawing.Color.LightGray
        Me.livebidshow.Controls.Add(Me.ListView1)
        Me.livebidshow.Controls.Add(Me.TableLayoutPanel1)
        Me.livebidshow.Location = New System.Drawing.Point(706, 73)
        Me.livebidshow.Name = "livebidshow"
        Me.livebidshow.Size = New System.Drawing.Size(288, 352)
        Me.livebidshow.TabIndex = 97
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(93, Byte), Integer), CType(CType(140, Byte), Integer), CType(CType(116, Byte), Integer))
        Me.TableLayoutPanel1.ColumnCount = 1
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.pdbidlbl, 0, 0)
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 1
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(288, 57)
        Me.TableLayoutPanel1.TabIndex = 101
        '
        'pdbidlbl
        '
        Me.pdbidlbl.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.pdbidlbl.AutoSize = True
        Me.pdbidlbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.pdbidlbl.ForeColor = System.Drawing.Color.White
        Me.pdbidlbl.Location = New System.Drawing.Point(77, 16)
        Me.pdbidlbl.Name = "pdbidlbl"
        Me.pdbidlbl.Size = New System.Drawing.Size(134, 25)
        Me.pdbidlbl.TabIndex = 99
        Me.pdbidlbl.Text = "Product Bids"
        Me.pdbidlbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'timerCountdown
        '
        '
        'ListView1
        '
        Me.ListView1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ListView1.HideSelection = False
        Me.ListView1.Location = New System.Drawing.Point(0, 55)
        Me.ListView1.MultiSelect = False
        Me.ListView1.Name = "ListView1"
        Me.ListView1.Size = New System.Drawing.Size(288, 297)
        Me.ListView1.TabIndex = 102
        Me.ListView1.UseCompatibleStateImageBehavior = False
        '
        'bidproduct
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1014, 630)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.livebidshow)
        Me.Controls.Add(Me.Aendingtimelbl)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Astartingtimelbl)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.topbar)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "bidproduct"
        Me.Text = "showproductdetail"
        Me.topbar.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.TableLayoutPanel2.ResumeLayout(False)
        Me.TableLayoutPanel2.PerformLayout()
        CType(Me.productimg, System.ComponentModel.ISupportInitialize).EndInit()
        Me.livebidshow.ResumeLayout(False)
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents topbar As Panel
    Friend WithEvents Panel1 As Panel
    Friend WithEvents productidlbl As Label
    Friend WithEvents label2 As Label
    Friend WithEvents productimg As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents startingprice As Label
    Friend WithEvents statuslbl As Label
    Friend WithEvents descriptiontxtbox As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Astartingtimelbl As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Aendingtimelbl As Label
    Friend WithEvents livebidshow As Panel
    Friend WithEvents TableLayoutPanel2 As TableLayoutPanel
    Friend WithEvents productnamelbl As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents backtoproduct As Button
    Friend WithEvents lblCountdown As Label
    Friend WithEvents timerCountdown As Timer
    Friend WithEvents confirmbid As Button
    Friend WithEvents bidtxtbox As TextBox
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents pdbidlbl As Label
    Friend WithEvents ListView1 As ListView
End Class
