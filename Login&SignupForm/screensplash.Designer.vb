<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class screensplash
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
        Me.modulelbl = New System.Windows.Forms.Label()
        Me.loadinglbl = New System.Windows.Forms.Label()
        Me.versionlbl = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.copyrightlbl = New System.Windows.Forms.Label()
        Me.ProgressBar1 = New System.Windows.Forms.ProgressBar()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Timer2 = New System.Windows.Forms.Timer(Me.components)
        Me.SuspendLayout()
        '
        'modulelbl
        '
        Me.modulelbl.AutoSize = True
        Me.modulelbl.Location = New System.Drawing.Point(92, 424)
        Me.modulelbl.Name = "modulelbl"
        Me.modulelbl.Size = New System.Drawing.Size(41, 13)
        Me.modulelbl.TabIndex = 11
        Me.modulelbl.Text = "module"
        '
        'loadinglbl
        '
        Me.loadinglbl.AutoSize = True
        Me.loadinglbl.Location = New System.Drawing.Point(688, 424)
        Me.loadinglbl.Name = "loadinglbl"
        Me.loadinglbl.Size = New System.Drawing.Size(41, 13)
        Me.loadinglbl.TabIndex = 10
        Me.loadinglbl.Text = "loading"
        '
        'versionlbl
        '
        Me.versionlbl.AutoSize = True
        Me.versionlbl.Font = New System.Drawing.Font("Microsoft PhagsPa", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.versionlbl.Location = New System.Drawing.Point(732, 525)
        Me.versionlbl.Name = "versionlbl"
        Me.versionlbl.Size = New System.Drawing.Size(77, 14)
        Me.versionlbl.TabIndex = 9
        Me.versionlbl.Text = "Version 1.0.0.0"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(17, 508)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(20, 20)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "©"
        '
        'copyrightlbl
        '
        Me.copyrightlbl.AutoSize = True
        Me.copyrightlbl.Font = New System.Drawing.Font("Microsoft PhagsPa", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.copyrightlbl.Location = New System.Drawing.Point(34, 510)
        Me.copyrightlbl.Name = "copyrightlbl"
        Me.copyrightlbl.Size = New System.Drawing.Size(227, 16)
        Me.copyrightlbl.TabIndex = 7
        Me.copyrightlbl.Text = "Copyright 2024, KPS Software Corporation"
        '
        'ProgressBar1
        '
        Me.ProgressBar1.Location = New System.Drawing.Point(95, 449)
        Me.ProgressBar1.Name = "ProgressBar1"
        Me.ProgressBar1.Size = New System.Drawing.Size(632, 10)
        Me.ProgressBar1.TabIndex = 6
        '
        'Timer1
        '
        '
        'Timer2
        '
        '
        'screensplash
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(821, 548)
        Me.ControlBox = False
        Me.Controls.Add(Me.modulelbl)
        Me.Controls.Add(Me.loadinglbl)
        Me.Controls.Add(Me.versionlbl)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.copyrightlbl)
        Me.Controls.Add(Me.ProgressBar1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "screensplash"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents modulelbl As Label
    Friend WithEvents loadinglbl As Label
    Friend WithEvents versionlbl As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents copyrightlbl As Label
    Friend WithEvents ProgressBar1 As ProgressBar
    Friend WithEvents Timer1 As Timer
    Friend WithEvents Timer2 As Timer
End Class
