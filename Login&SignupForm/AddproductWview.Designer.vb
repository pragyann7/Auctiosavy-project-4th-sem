<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class AddproductWview
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
        Me.addproductpanel = New System.Windows.Forms.Panel()
        Me.displayproductpanel = New System.Windows.Forms.Panel()
        Me.flowLayoutPanelProducts = New System.Windows.Forms.FlowLayoutPanel()
        Me.searchbar = New System.Windows.Forms.Panel()
        Me.sortsearch = New System.Windows.Forms.ComboBox()
        Me.addproductbtn = New System.Windows.Forms.Button()
        Me.magnifier = New System.Windows.Forms.Button()
        Me.categorysearch = New System.Windows.Forms.ComboBox()
        Me.searchbox = New System.Windows.Forms.TextBox()
        Me.addproductpanel.SuspendLayout()
        Me.displayproductpanel.SuspendLayout()
        Me.searchbar.SuspendLayout()
        Me.SuspendLayout()
        '
        'addproductpanel
        '
        Me.addproductpanel.Controls.Add(Me.displayproductpanel)
        Me.addproductpanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.addproductpanel.Location = New System.Drawing.Point(0, 0)
        Me.addproductpanel.Name = "addproductpanel"
        Me.addproductpanel.Size = New System.Drawing.Size(1035, 681)
        Me.addproductpanel.TabIndex = 0
        '
        'displayproductpanel
        '
        Me.displayproductpanel.Controls.Add(Me.flowLayoutPanelProducts)
        Me.displayproductpanel.Controls.Add(Me.searchbar)
        Me.displayproductpanel.Location = New System.Drawing.Point(0, 0)
        Me.displayproductpanel.Name = "displayproductpanel"
        Me.displayproductpanel.Size = New System.Drawing.Size(1035, 681)
        Me.displayproductpanel.TabIndex = 0
        '
        'flowLayoutPanelProducts
        '
        Me.flowLayoutPanelProducts.AutoScroll = True
        Me.flowLayoutPanelProducts.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.flowLayoutPanelProducts.Location = New System.Drawing.Point(0, 54)
        Me.flowLayoutPanelProducts.Name = "flowLayoutPanelProducts"
        Me.flowLayoutPanelProducts.Size = New System.Drawing.Size(1035, 626)
        Me.flowLayoutPanelProducts.TabIndex = 9
        '
        'searchbar
        '
        Me.searchbar.BackColor = System.Drawing.Color.FromArgb(CType(CType(93, Byte), Integer), CType(CType(140, Byte), Integer), CType(CType(116, Byte), Integer))
        Me.searchbar.Controls.Add(Me.sortsearch)
        Me.searchbar.Controls.Add(Me.addproductbtn)
        Me.searchbar.Controls.Add(Me.magnifier)
        Me.searchbar.Controls.Add(Me.categorysearch)
        Me.searchbar.Controls.Add(Me.searchbox)
        Me.searchbar.Dock = System.Windows.Forms.DockStyle.Top
        Me.searchbar.Location = New System.Drawing.Point(0, 0)
        Me.searchbar.Name = "searchbar"
        Me.searchbar.Size = New System.Drawing.Size(1035, 54)
        Me.searchbar.TabIndex = 8
        '
        'sortsearch
        '
        Me.sortsearch.Cursor = System.Windows.Forms.Cursors.Hand
        Me.sortsearch.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.sortsearch.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.sortsearch.FormattingEnabled = True
        Me.sortsearch.Location = New System.Drawing.Point(376, 15)
        Me.sortsearch.Name = "sortsearch"
        Me.sortsearch.Size = New System.Drawing.Size(124, 26)
        Me.sortsearch.TabIndex = 5
        '
        'addproductbtn
        '
        Me.addproductbtn.BackColor = System.Drawing.Color.AliceBlue
        Me.addproductbtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.addproductbtn.FlatAppearance.BorderSize = 0
        Me.addproductbtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.addproductbtn.Image = Global.Login_SignupForm.My.Resources.Resources.addd
        Me.addproductbtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.addproductbtn.Location = New System.Drawing.Point(858, 10)
        Me.addproductbtn.Name = "addproductbtn"
        Me.addproductbtn.Size = New System.Drawing.Size(113, 38)
        Me.addproductbtn.TabIndex = 4
        Me.addproductbtn.Text = "Add Product"
        Me.addproductbtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.addproductbtn.UseVisualStyleBackColor = False
        '
        'magnifier
        '
        Me.magnifier.BackColor = System.Drawing.Color.White
        Me.magnifier.BackgroundImage = Global.Login_SignupForm.My.Resources.Resources.search
        Me.magnifier.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.magnifier.Cursor = System.Windows.Forms.Cursors.Hand
        Me.magnifier.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.magnifier.FlatAppearance.BorderSize = 0
        Me.magnifier.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.magnifier.Location = New System.Drawing.Point(190, 12)
        Me.magnifier.Name = "magnifier"
        Me.magnifier.Size = New System.Drawing.Size(34, 26)
        Me.magnifier.TabIndex = 3
        Me.magnifier.UseVisualStyleBackColor = False
        '
        'categorysearch
        '
        Me.categorysearch.Cursor = System.Windows.Forms.Cursors.Hand
        Me.categorysearch.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.categorysearch.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.categorysearch.FormattingEnabled = True
        Me.categorysearch.Location = New System.Drawing.Point(246, 15)
        Me.categorysearch.Name = "categorysearch"
        Me.categorysearch.Size = New System.Drawing.Size(124, 26)
        Me.categorysearch.TabIndex = 2
        '
        'searchbox
        '
        Me.searchbox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.searchbox.Location = New System.Drawing.Point(17, 12)
        Me.searchbox.Multiline = True
        Me.searchbox.Name = "searchbox"
        Me.searchbox.Size = New System.Drawing.Size(208, 29)
        Me.searchbox.TabIndex = 0
        '
        'AddproductWview
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1035, 681)
        Me.Controls.Add(Me.addproductpanel)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "AddproductWview"
        Me.Text = " "
        Me.addproductpanel.ResumeLayout(False)
        Me.displayproductpanel.ResumeLayout(False)
        Me.searchbar.ResumeLayout(False)
        Me.searchbar.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents addproductpanel As Panel
    Friend WithEvents displayproductpanel As Panel
    Friend WithEvents flowLayoutPanelProducts As FlowLayoutPanel
    Friend WithEvents searchbar As Panel
    Friend WithEvents addproductbtn As Button
    Friend WithEvents magnifier As Button
    Friend WithEvents categorysearch As ComboBox
    Friend WithEvents searchbox As TextBox
    Friend WithEvents sortsearch As ComboBox
End Class
