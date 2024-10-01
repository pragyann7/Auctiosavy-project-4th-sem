<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class userproduct
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
        Me.components = New System.ComponentModel.Container()
        Me.updateproductpanel = New System.Windows.Forms.Panel()
        Me.viewproduct = New System.Windows.Forms.Panel()
        Me.topbar = New System.Windows.Forms.Panel()
        Me.toplabel = New System.Windows.Forms.Label()
        Me.flowLayoutPanelProducts = New System.Windows.Forms.FlowLayoutPanel()
        Me.AuctionStatusTimer = New System.Windows.Forms.Timer(Me.components)
        Me.updateproductpanel.SuspendLayout()
        Me.viewproduct.SuspendLayout()
        Me.topbar.SuspendLayout()
        Me.SuspendLayout()
        '
        'updateproductpanel
        '
        Me.updateproductpanel.Controls.Add(Me.viewproduct)
        Me.updateproductpanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.updateproductpanel.Location = New System.Drawing.Point(0, 0)
        Me.updateproductpanel.Name = "updateproductpanel"
        Me.updateproductpanel.Size = New System.Drawing.Size(1019, 642)
        Me.updateproductpanel.TabIndex = 0
        '
        'viewproduct
        '
        Me.viewproduct.Controls.Add(Me.topbar)
        Me.viewproduct.Controls.Add(Me.flowLayoutPanelProducts)
        Me.viewproduct.Location = New System.Drawing.Point(0, 0)
        Me.viewproduct.Name = "viewproduct"
        Me.viewproduct.Size = New System.Drawing.Size(1019, 642)
        Me.viewproduct.TabIndex = 0
        '
        'topbar
        '
        Me.topbar.BackColor = System.Drawing.Color.FromArgb(CType(CType(93, Byte), Integer), CType(CType(140, Byte), Integer), CType(CType(116, Byte), Integer))
        Me.topbar.Controls.Add(Me.toplabel)
        Me.topbar.Dock = System.Windows.Forms.DockStyle.Top
        Me.topbar.Location = New System.Drawing.Point(0, 0)
        Me.topbar.Name = "topbar"
        Me.topbar.Size = New System.Drawing.Size(1019, 56)
        Me.topbar.TabIndex = 11
        '
        'toplabel
        '
        Me.toplabel.AutoSize = True
        Me.toplabel.Font = New System.Drawing.Font("Segoe UI Light", 36.0!)
        Me.toplabel.ForeColor = System.Drawing.Color.White
        Me.toplabel.Location = New System.Drawing.Point(15, -9)
        Me.toplabel.Name = "toplabel"
        Me.toplabel.Size = New System.Drawing.Size(203, 65)
        Me.toplabel.TabIndex = 0
        Me.toplabel.Text = "Products"
        '
        'flowLayoutPanelProducts
        '
        Me.flowLayoutPanelProducts.AutoScroll = True
        Me.flowLayoutPanelProducts.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.flowLayoutPanelProducts.Location = New System.Drawing.Point(0, 51)
        Me.flowLayoutPanelProducts.Name = "flowLayoutPanelProducts"
        Me.flowLayoutPanelProducts.Size = New System.Drawing.Size(1035, 626)
        Me.flowLayoutPanelProducts.TabIndex = 10
        '
        'AuctionStatusTimer
        '
        '
        'userproduct
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1019, 642)
        Me.Controls.Add(Me.updateproductpanel)
        Me.Name = "userproduct"
        Me.Text = "Form1"
        Me.updateproductpanel.ResumeLayout(False)
        Me.viewproduct.ResumeLayout(False)
        Me.topbar.ResumeLayout(False)
        Me.topbar.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents updateproductpanel As Panel
    Friend WithEvents viewproduct As Panel
    Friend WithEvents topbar As Panel
    Friend WithEvents flowLayoutPanelProducts As FlowLayoutPanel
    Friend WithEvents toplabel As Label
    Friend WithEvents AuctionStatusTimer As Timer
End Class
