<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class addproduct
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
        Me.clearimage = New System.Windows.Forms.Button()
        Me.pathname = New System.Windows.Forms.Label()
        Me.pathlbl = New System.Windows.Forms.Label()
        Me.endtimepicker = New System.Windows.Forms.DateTimePicker()
        Me.starttimepicker = New System.Windows.Forms.DateTimePicker()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Ppricetxtbox = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.categorycombobx = New System.Windows.Forms.ComboBox()
        Me.addproductbtn = New System.Windows.Forms.Button()
        Me.photoselectbtn = New System.Windows.Forms.Button()
        Me.Pidgeneratebtn = New System.Windows.Forms.Button()
        Me.Pidtxtbox = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.descriptiontxtbox = New System.Windows.Forms.TextBox()
        Me.Pnametxtbox = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.productimage = New System.Windows.Forms.PictureBox()
        Me.backviewproduct = New System.Windows.Forms.Button()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.productimage, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'clearimage
        '
        Me.clearimage.BackColor = System.Drawing.Color.FromArgb(CType(CType(196, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.clearimage.Cursor = System.Windows.Forms.Cursors.Hand
        Me.clearimage.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.clearimage.ForeColor = System.Drawing.Color.White
        Me.clearimage.Location = New System.Drawing.Point(668, 482)
        Me.clearimage.Name = "clearimage"
        Me.clearimage.Size = New System.Drawing.Size(200, 35)
        Me.clearimage.TabIndex = 79
        Me.clearimage.Text = "Clear Image"
        Me.clearimage.UseVisualStyleBackColor = False
        Me.clearimage.Visible = False
        '
        'pathname
        '
        Me.pathname.AutoSize = True
        Me.pathname.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.pathname.ForeColor = System.Drawing.Color.Black
        Me.pathname.Location = New System.Drawing.Point(690, 422)
        Me.pathname.Name = "pathname"
        Me.pathname.Size = New System.Drawing.Size(0, 16)
        Me.pathname.TabIndex = 78
        '
        'pathlbl
        '
        Me.pathlbl.AutoSize = True
        Me.pathlbl.BackColor = System.Drawing.Color.White
        Me.pathlbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.pathlbl.ForeColor = System.Drawing.Color.Black
        Me.pathlbl.Location = New System.Drawing.Point(653, 422)
        Me.pathlbl.Name = "pathlbl"
        Me.pathlbl.Size = New System.Drawing.Size(40, 16)
        Me.pathlbl.TabIndex = 77
        Me.pathlbl.Text = "Path :"
        Me.pathlbl.Visible = False
        '
        'endtimepicker
        '
        Me.endtimepicker.Cursor = System.Windows.Forms.Cursors.Hand
        Me.endtimepicker.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.endtimepicker.Location = New System.Drawing.Point(439, 510)
        Me.endtimepicker.Name = "endtimepicker"
        Me.endtimepicker.Size = New System.Drawing.Size(209, 21)
        Me.endtimepicker.TabIndex = 75
        '
        'starttimepicker
        '
        Me.starttimepicker.Cursor = System.Windows.Forms.Cursors.Hand
        Me.starttimepicker.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.starttimepicker.Location = New System.Drawing.Point(116, 510)
        Me.starttimepicker.Name = "starttimepicker"
        Me.starttimepicker.Size = New System.Drawing.Size(209, 21)
        Me.starttimepicker.TabIndex = 74
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.FromArgb(CType(CType(93, Byte), Integer), CType(CType(140, Byte), Integer), CType(CType(116, Byte), Integer))
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.White
        Me.Label8.Location = New System.Drawing.Point(439, 473)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(181, 25)
        Me.Label8.TabIndex = 73
        Me.Label8.Text = "Auction End Time"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.FromArgb(CType(CType(93, Byte), Integer), CType(CType(140, Byte), Integer), CType(CType(116, Byte), Integer))
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.White
        Me.Label7.Location = New System.Drawing.Point(117, 473)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(188, 25)
        Me.Label7.TabIndex = 72
        Me.Label7.Text = "Auction Start Time"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.FromArgb(CType(CType(93, Byte), Integer), CType(CType(140, Byte), Integer), CType(CType(116, Byte), Integer))
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(117, 370)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(141, 25)
        Me.Label6.TabIndex = 71
        Me.Label6.Text = "Product Price"
        '
        'Ppricetxtbox
        '
        Me.Ppricetxtbox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Ppricetxtbox.Location = New System.Drawing.Point(116, 400)
        Me.Ppricetxtbox.Multiline = True
        Me.Ppricetxtbox.Name = "Ppricetxtbox"
        Me.Ppricetxtbox.Size = New System.Drawing.Size(209, 38)
        Me.Ppricetxtbox.TabIndex = 70
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.FromArgb(CType(CType(93, Byte), Integer), CType(CType(140, Byte), Integer), CType(CType(116, Byte), Integer))
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(440, 367)
        Me.Label4.Name = "Label4"
        Me.Label4.Padding = New System.Windows.Forms.Padding(0, 0, 0, 3)
        Me.Label4.Size = New System.Drawing.Size(99, 28)
        Me.Label4.TabIndex = 69
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
        Me.categorycombobx.Location = New System.Drawing.Point(439, 400)
        Me.categorycombobx.Name = "categorycombobx"
        Me.categorycombobx.Size = New System.Drawing.Size(159, 28)
        Me.categorycombobx.TabIndex = 68
        '
        'addproductbtn
        '
        Me.addproductbtn.BackColor = System.Drawing.Color.FromArgb(CType(CType(93, Byte), Integer), CType(CType(140, Byte), Integer), CType(CType(116, Byte), Integer))
        Me.addproductbtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.addproductbtn.FlatAppearance.BorderSize = 0
        Me.addproductbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.addproductbtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.addproductbtn.ForeColor = System.Drawing.Color.White
        Me.addproductbtn.Location = New System.Drawing.Point(290, 588)
        Me.addproductbtn.Name = "addproductbtn"
        Me.addproductbtn.Size = New System.Drawing.Size(200, 51)
        Me.addproductbtn.TabIndex = 67
        Me.addproductbtn.Text = "Add Product"
        Me.addproductbtn.UseVisualStyleBackColor = False
        '
        'photoselectbtn
        '
        Me.photoselectbtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.photoselectbtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.photoselectbtn.ForeColor = System.Drawing.Color.FromArgb(CType(CType(25, Byte), Integer), CType(CType(29, Byte), Integer), CType(CType(54, Byte), Integer))
        Me.photoselectbtn.Location = New System.Drawing.Point(668, 441)
        Me.photoselectbtn.Name = "photoselectbtn"
        Me.photoselectbtn.Size = New System.Drawing.Size(200, 35)
        Me.photoselectbtn.TabIndex = 66
        Me.photoselectbtn.Text = "Select Photo"
        Me.photoselectbtn.UseVisualStyleBackColor = True
        '
        'Pidgeneratebtn
        '
        Me.Pidgeneratebtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Pidgeneratebtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Pidgeneratebtn.ForeColor = System.Drawing.Color.FromArgb(CType(CType(25, Byte), Integer), CType(CType(29, Byte), Integer), CType(CType(54, Byte), Integer))
        Me.Pidgeneratebtn.Location = New System.Drawing.Point(620, 135)
        Me.Pidgeneratebtn.Name = "Pidgeneratebtn"
        Me.Pidgeneratebtn.Size = New System.Drawing.Size(98, 29)
        Me.Pidgeneratebtn.TabIndex = 64
        Me.Pidgeneratebtn.Text = "Generate"
        Me.Pidgeneratebtn.UseVisualStyleBackColor = True
        '
        'Pidtxtbox
        '
        Me.Pidtxtbox.Cursor = System.Windows.Forms.Cursors.No
        Me.Pidtxtbox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Pidtxtbox.Location = New System.Drawing.Point(405, 130)
        Me.Pidtxtbox.Multiline = True
        Me.Pidtxtbox.Name = "Pidtxtbox"
        Me.Pidtxtbox.ReadOnly = True
        Me.Pidtxtbox.Size = New System.Drawing.Size(209, 38)
        Me.Pidtxtbox.TabIndex = 63
        Me.Pidtxtbox.TabStop = False
        Me.Pidtxtbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.FromArgb(CType(CType(93, Byte), Integer), CType(CType(140, Byte), Integer), CType(CType(116, Byte), Integer))
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(405, 102)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(112, 25)
        Me.Label5.TabIndex = 62
        Me.Label5.Text = "Product ID"
        '
        'descriptiontxtbox
        '
        Me.descriptiontxtbox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.descriptiontxtbox.Location = New System.Drawing.Point(116, 240)
        Me.descriptiontxtbox.Multiline = True
        Me.descriptiontxtbox.Name = "descriptiontxtbox"
        Me.descriptiontxtbox.Size = New System.Drawing.Size(498, 102)
        Me.descriptiontxtbox.TabIndex = 61
        '
        'Pnametxtbox
        '
        Me.Pnametxtbox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Pnametxtbox.Location = New System.Drawing.Point(116, 130)
        Me.Pnametxtbox.Multiline = True
        Me.Pnametxtbox.Name = "Pnametxtbox"
        Me.Pnametxtbox.Size = New System.Drawing.Size(209, 38)
        Me.Pnametxtbox.TabIndex = 60
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.FromArgb(CType(CType(93, Byte), Integer), CType(CType(140, Byte), Integer), CType(CType(116, Byte), Integer))
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(117, 212)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(120, 25)
        Me.Label3.TabIndex = 59
        Me.Label3.Text = "Description"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.FromArgb(CType(CType(93, Byte), Integer), CType(CType(140, Byte), Integer), CType(CType(116, Byte), Integer))
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(117, 100)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(148, 25)
        Me.Label2.TabIndex = 58
        Me.Label2.Text = "Product Name"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.FromArgb(CType(CType(93, Byte), Integer), CType(CType(140, Byte), Integer), CType(CType(116, Byte), Integer))
        Me.Label1.Font = New System.Drawing.Font("Segoe UI Light", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(-1, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Padding = New System.Windows.Forms.Padding(40, 0, 1700, 2)
        Me.Label1.Size = New System.Drawing.Size(2021, 67)
        Me.Label1.TabIndex = 57
        Me.Label1.Text = "Add Product"
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.Image = Global.Login_SignupForm.My.Resources.Resources.rupee
        Me.PictureBox1.Location = New System.Drawing.Point(85, 406)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(25, 25)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 76
        Me.PictureBox1.TabStop = False
        '
        'productimage
        '
        Me.productimage.BackColor = System.Drawing.Color.Transparent
        Me.productimage.Image = Global.Login_SignupForm.My.Resources.Resources.add_image
        Me.productimage.Location = New System.Drawing.Point(668, 217)
        Me.productimage.Name = "productimage"
        Me.productimage.Size = New System.Drawing.Size(200, 200)
        Me.productimage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.productimage.TabIndex = 65
        Me.productimage.TabStop = False
        '
        'backviewproduct
        '
        Me.backviewproduct.BackColor = System.Drawing.Color.Black
        Me.backviewproduct.Cursor = System.Windows.Forms.Cursors.Hand
        Me.backviewproduct.FlatAppearance.BorderSize = 0
        Me.backviewproduct.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.backviewproduct.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.backviewproduct.ForeColor = System.Drawing.Color.White
        Me.backviewproduct.Location = New System.Drawing.Point(769, 12)
        Me.backviewproduct.Name = "backviewproduct"
        Me.backviewproduct.Size = New System.Drawing.Size(136, 34)
        Me.backviewproduct.TabIndex = 80
        Me.backviewproduct.Text = "View Products"
        Me.backviewproduct.UseVisualStyleBackColor = False
        '
        'addproduct
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(962, 691)
        Me.Controls.Add(Me.backviewproduct)
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
        Me.Controls.Add(Me.addproductbtn)
        Me.Controls.Add(Me.photoselectbtn)
        Me.Controls.Add(Me.productimage)
        Me.Controls.Add(Me.Pidgeneratebtn)
        Me.Controls.Add(Me.Pidtxtbox)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.descriptiontxtbox)
        Me.Controls.Add(Me.Pnametxtbox)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "addproduct"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form1"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.productimage, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
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
    Friend WithEvents addproductbtn As Button
    Friend WithEvents photoselectbtn As Button
    Friend WithEvents productimage As PictureBox
    Friend WithEvents Pidgeneratebtn As Button
    Friend WithEvents Pidtxtbox As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents descriptiontxtbox As TextBox
    Friend WithEvents Pnametxtbox As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents backviewproduct As Button
End Class
