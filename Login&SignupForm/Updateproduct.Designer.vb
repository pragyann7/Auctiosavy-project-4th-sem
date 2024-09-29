<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Updateproduct
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
        Me.cancelbtn = New System.Windows.Forms.Button()
        Me.clearimage = New System.Windows.Forms.Button()
        Me.pathname = New System.Windows.Forms.Label()
        Me.pathlbl = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.endtimepicker = New System.Windows.Forms.DateTimePicker()
        Me.starttimepicker = New System.Windows.Forms.DateTimePicker()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Ppricetxtbox = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.categorycombobx = New System.Windows.Forms.ComboBox()
        Me.updatepdbtn = New System.Windows.Forms.Button()
        Me.photoselectbtn = New System.Windows.Forms.Button()
        Me.productimage = New System.Windows.Forms.PictureBox()
        Me.Pidtxtbox = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.descriptiontxtbox = New System.Windows.Forms.TextBox()
        Me.Pnametxtbox = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.topbar = New System.Windows.Forms.Panel()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.productimage, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cancelbtn
        '
        Me.cancelbtn.BackColor = System.Drawing.Color.Firebrick
        Me.cancelbtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cancelbtn.FlatAppearance.BorderSize = 0
        Me.cancelbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cancelbtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cancelbtn.ForeColor = System.Drawing.Color.White
        Me.cancelbtn.Location = New System.Drawing.Point(445, 588)
        Me.cancelbtn.Name = "cancelbtn"
        Me.cancelbtn.Size = New System.Drawing.Size(200, 51)
        Me.cancelbtn.TabIndex = 103
        Me.cancelbtn.Text = "Cancel"
        Me.cancelbtn.UseVisualStyleBackColor = False
        '
        'clearimage
        '
        Me.clearimage.BackColor = System.Drawing.Color.FromArgb(CType(CType(196, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.clearimage.Cursor = System.Windows.Forms.Cursors.Hand
        Me.clearimage.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.clearimage.ForeColor = System.Drawing.Color.White
        Me.clearimage.Location = New System.Drawing.Point(654, 482)
        Me.clearimage.Name = "clearimage"
        Me.clearimage.Size = New System.Drawing.Size(200, 35)
        Me.clearimage.TabIndex = 102
        Me.clearimage.Text = "Clear Image"
        Me.clearimage.UseVisualStyleBackColor = False
        Me.clearimage.Visible = False
        '
        'pathname
        '
        Me.pathname.AutoSize = True
        Me.pathname.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.pathname.ForeColor = System.Drawing.Color.Black
        Me.pathname.Location = New System.Drawing.Point(676, 422)
        Me.pathname.Name = "pathname"
        Me.pathname.Size = New System.Drawing.Size(0, 16)
        Me.pathname.TabIndex = 101
        '
        'pathlbl
        '
        Me.pathlbl.AutoSize = True
        Me.pathlbl.BackColor = System.Drawing.Color.White
        Me.pathlbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.pathlbl.ForeColor = System.Drawing.Color.Black
        Me.pathlbl.Location = New System.Drawing.Point(639, 422)
        Me.pathlbl.Name = "pathlbl"
        Me.pathlbl.Size = New System.Drawing.Size(40, 16)
        Me.pathlbl.TabIndex = 100
        Me.pathlbl.Text = "Path :"
        Me.pathlbl.Visible = False
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.Image = Global.Login_SignupForm.My.Resources.Resources.rupee
        Me.PictureBox1.Location = New System.Drawing.Point(71, 406)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(25, 25)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 99
        Me.PictureBox1.TabStop = False
        '
        'endtimepicker
        '
        Me.endtimepicker.Cursor = System.Windows.Forms.Cursors.Hand
        Me.endtimepicker.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.endtimepicker.Location = New System.Drawing.Point(425, 510)
        Me.endtimepicker.Name = "endtimepicker"
        Me.endtimepicker.Size = New System.Drawing.Size(209, 21)
        Me.endtimepicker.TabIndex = 98
        '
        'starttimepicker
        '
        Me.starttimepicker.Cursor = System.Windows.Forms.Cursors.Hand
        Me.starttimepicker.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.starttimepicker.Location = New System.Drawing.Point(102, 510)
        Me.starttimepicker.Name = "starttimepicker"
        Me.starttimepicker.Size = New System.Drawing.Size(209, 21)
        Me.starttimepicker.TabIndex = 97
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.FromArgb(CType(CType(93, Byte), Integer), CType(CType(140, Byte), Integer), CType(CType(116, Byte), Integer))
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.White
        Me.Label8.Location = New System.Drawing.Point(425, 473)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(181, 25)
        Me.Label8.TabIndex = 96
        Me.Label8.Text = "Auction End Time"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.FromArgb(CType(CType(93, Byte), Integer), CType(CType(140, Byte), Integer), CType(CType(116, Byte), Integer))
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.White
        Me.Label7.Location = New System.Drawing.Point(103, 473)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(188, 25)
        Me.Label7.TabIndex = 95
        Me.Label7.Text = "Auction Start Time"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.FromArgb(CType(CType(93, Byte), Integer), CType(CType(140, Byte), Integer), CType(CType(116, Byte), Integer))
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(103, 370)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(141, 25)
        Me.Label6.TabIndex = 94
        Me.Label6.Text = "Product Price"
        '
        'Ppricetxtbox
        '
        Me.Ppricetxtbox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Ppricetxtbox.Location = New System.Drawing.Point(102, 400)
        Me.Ppricetxtbox.Multiline = True
        Me.Ppricetxtbox.Name = "Ppricetxtbox"
        Me.Ppricetxtbox.Size = New System.Drawing.Size(209, 38)
        Me.Ppricetxtbox.TabIndex = 93
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.FromArgb(CType(CType(93, Byte), Integer), CType(CType(140, Byte), Integer), CType(CType(116, Byte), Integer))
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(426, 367)
        Me.Label4.Name = "Label4"
        Me.Label4.Padding = New System.Windows.Forms.Padding(0, 0, 0, 3)
        Me.Label4.Size = New System.Drawing.Size(99, 28)
        Me.Label4.TabIndex = 92
        Me.Label4.Text = "Category"
        '
        'categorycombobx
        '
        Me.categorycombobx.Cursor = System.Windows.Forms.Cursors.Hand
        Me.categorycombobx.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.categorycombobx.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.categorycombobx.ForeColor = System.Drawing.Color.Gray
        Me.categorycombobx.FormattingEnabled = True
        Me.categorycombobx.Items.AddRange(New Object() {"Art", "Electronics", "Furniture", "Collectibles", "Fashion", "Sports Equipment", "Home Appliances", "Toys", "Books", "Vehicles"})
        Me.categorycombobx.Location = New System.Drawing.Point(425, 400)
        Me.categorycombobx.Name = "categorycombobx"
        Me.categorycombobx.Size = New System.Drawing.Size(159, 28)
        Me.categorycombobx.TabIndex = 91
        '
        'updatepdbtn
        '
        Me.updatepdbtn.BackColor = System.Drawing.Color.FromArgb(CType(CType(93, Byte), Integer), CType(CType(140, Byte), Integer), CType(CType(116, Byte), Integer))
        Me.updatepdbtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.updatepdbtn.FlatAppearance.BorderSize = 0
        Me.updatepdbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.updatepdbtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.updatepdbtn.ForeColor = System.Drawing.Color.White
        Me.updatepdbtn.Location = New System.Drawing.Point(207, 588)
        Me.updatepdbtn.Name = "updatepdbtn"
        Me.updatepdbtn.Size = New System.Drawing.Size(200, 51)
        Me.updatepdbtn.TabIndex = 90
        Me.updatepdbtn.Text = "Update"
        Me.updatepdbtn.UseVisualStyleBackColor = False
        '
        'photoselectbtn
        '
        Me.photoselectbtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.photoselectbtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.photoselectbtn.ForeColor = System.Drawing.Color.FromArgb(CType(CType(25, Byte), Integer), CType(CType(29, Byte), Integer), CType(CType(54, Byte), Integer))
        Me.photoselectbtn.Location = New System.Drawing.Point(654, 441)
        Me.photoselectbtn.Name = "photoselectbtn"
        Me.photoselectbtn.Size = New System.Drawing.Size(200, 35)
        Me.photoselectbtn.TabIndex = 89
        Me.photoselectbtn.Text = "Select Photo"
        Me.photoselectbtn.UseVisualStyleBackColor = True
        '
        'productimage
        '
        Me.productimage.BackColor = System.Drawing.Color.Transparent
        Me.productimage.Image = Global.Login_SignupForm.My.Resources.Resources.add_image
        Me.productimage.Location = New System.Drawing.Point(654, 217)
        Me.productimage.Name = "productimage"
        Me.productimage.Size = New System.Drawing.Size(200, 200)
        Me.productimage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.productimage.TabIndex = 88
        Me.productimage.TabStop = False
        '
        'Pidtxtbox
        '
        Me.Pidtxtbox.Cursor = System.Windows.Forms.Cursors.No
        Me.Pidtxtbox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Pidtxtbox.Location = New System.Drawing.Point(391, 130)
        Me.Pidtxtbox.Multiline = True
        Me.Pidtxtbox.Name = "Pidtxtbox"
        Me.Pidtxtbox.ReadOnly = True
        Me.Pidtxtbox.Size = New System.Drawing.Size(209, 38)
        Me.Pidtxtbox.TabIndex = 86
        Me.Pidtxtbox.TabStop = False
        Me.Pidtxtbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.FromArgb(CType(CType(93, Byte), Integer), CType(CType(140, Byte), Integer), CType(CType(116, Byte), Integer))
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(391, 102)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(112, 25)
        Me.Label5.TabIndex = 85
        Me.Label5.Text = "Product ID"
        '
        'descriptiontxtbox
        '
        Me.descriptiontxtbox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.descriptiontxtbox.Location = New System.Drawing.Point(102, 240)
        Me.descriptiontxtbox.Multiline = True
        Me.descriptiontxtbox.Name = "descriptiontxtbox"
        Me.descriptiontxtbox.Size = New System.Drawing.Size(498, 102)
        Me.descriptiontxtbox.TabIndex = 84
        '
        'Pnametxtbox
        '
        Me.Pnametxtbox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Pnametxtbox.Location = New System.Drawing.Point(102, 130)
        Me.Pnametxtbox.Multiline = True
        Me.Pnametxtbox.Name = "Pnametxtbox"
        Me.Pnametxtbox.Size = New System.Drawing.Size(209, 38)
        Me.Pnametxtbox.TabIndex = 83
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.FromArgb(CType(CType(93, Byte), Integer), CType(CType(140, Byte), Integer), CType(CType(116, Byte), Integer))
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(103, 212)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(120, 25)
        Me.Label3.TabIndex = 82
        Me.Label3.Text = "Description"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.FromArgb(CType(CType(93, Byte), Integer), CType(CType(140, Byte), Integer), CType(CType(116, Byte), Integer))
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(103, 100)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(148, 25)
        Me.Label2.TabIndex = 81
        Me.Label2.Text = "Product Name"
        '
        'topbar
        '
        Me.topbar.BackColor = System.Drawing.Color.FromArgb(CType(CType(93, Byte), Integer), CType(CType(140, Byte), Integer), CType(CType(116, Byte), Integer))
        Me.topbar.Dock = System.Windows.Forms.DockStyle.Top
        Me.topbar.Location = New System.Drawing.Point(0, 0)
        Me.topbar.Name = "topbar"
        Me.topbar.Size = New System.Drawing.Size(962, 54)
        Me.topbar.TabIndex = 104
        '
        'Updateproduct
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(962, 691)
        Me.Controls.Add(Me.cancelbtn)
        Me.Controls.Add(Me.topbar)
        Me.Controls.Add(Me.clearimage)
        Me.Controls.Add(Me.pathname)
        Me.Controls.Add(Me.pathlbl)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.endtimepicker)
        Me.Controls.Add(Me.starttimepicker)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Ppricetxtbox)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.categorycombobx)
        Me.Controls.Add(Me.updatepdbtn)
        Me.Controls.Add(Me.photoselectbtn)
        Me.Controls.Add(Me.productimage)
        Me.Controls.Add(Me.Pidtxtbox)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.descriptiontxtbox)
        Me.Controls.Add(Me.Pnametxtbox)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Updateproduct"
        Me.Text = "Updateproduct"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.productimage, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents cancelbtn As Button
    Friend WithEvents clearimage As Button
    Friend WithEvents pathname As Label
    Friend WithEvents pathlbl As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents endtimepicker As DateTimePicker
    Friend WithEvents starttimepicker As DateTimePicker
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Ppricetxtbox As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents categorycombobx As ComboBox
    Friend WithEvents updatepdbtn As Button
    Friend WithEvents photoselectbtn As Button
    Friend WithEvents productimage As PictureBox
    Friend WithEvents Pidtxtbox As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents descriptiontxtbox As TextBox
    Friend WithEvents Pnametxtbox As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents topbar As Panel
End Class
