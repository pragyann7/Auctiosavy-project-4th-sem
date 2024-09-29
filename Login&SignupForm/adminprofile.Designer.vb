<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class adminprofile
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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.editphotobtn = New System.Windows.Forms.PictureBox()
        Me.photodisplay = New System.Windows.Forms.PictureBox()
        Me.editnamebtn = New System.Windows.Forms.PictureBox()
        Me.confirmbtn = New System.Windows.Forms.Button()
        Me.nametxtbox = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        CType(Me.editphotobtn, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.photodisplay, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.editnamebtn, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.DarkGray
        Me.Panel1.Controls.Add(Me.editphotobtn)
        Me.Panel1.Controls.Add(Me.photodisplay)
        Me.Panel1.Location = New System.Drawing.Point(0, 78)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1036, 341)
        Me.Panel1.TabIndex = 3
        '
        'editphotobtn
        '
        Me.editphotobtn.BackColor = System.Drawing.Color.White
        Me.editphotobtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.editphotobtn.Image = Global.Login_SignupForm.My.Resources.Resources.editprofile
        Me.editphotobtn.Location = New System.Drawing.Point(618, 270)
        Me.editphotobtn.Name = "editphotobtn"
        Me.editphotobtn.Size = New System.Drawing.Size(50, 50)
        Me.editphotobtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.editphotobtn.TabIndex = 1
        Me.editphotobtn.TabStop = False
        '
        'photodisplay
        '
        Me.photodisplay.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.photodisplay.Location = New System.Drawing.Point(368, 20)
        Me.photodisplay.Name = "photodisplay"
        Me.photodisplay.Size = New System.Drawing.Size(300, 300)
        Me.photodisplay.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.photodisplay.TabIndex = 4
        Me.photodisplay.TabStop = False
        '
        'editnamebtn
        '
        Me.editnamebtn.BackColor = System.Drawing.Color.White
        Me.editnamebtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.editnamebtn.Image = Global.Login_SignupForm.My.Resources.Resources.greaterthan
        Me.editnamebtn.Location = New System.Drawing.Point(692, 503)
        Me.editnamebtn.Name = "editnamebtn"
        Me.editnamebtn.Size = New System.Drawing.Size(35, 35)
        Me.editnamebtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.editnamebtn.TabIndex = 8
        Me.editnamebtn.TabStop = False
        '
        'confirmbtn
        '
        Me.confirmbtn.BackColor = System.Drawing.Color.FromArgb(CType(CType(93, Byte), Integer), CType(CType(140, Byte), Integer), CType(CType(116, Byte), Integer))
        Me.confirmbtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.confirmbtn.FlatAppearance.BorderSize = 0
        Me.confirmbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.confirmbtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.confirmbtn.ForeColor = System.Drawing.Color.White
        Me.confirmbtn.Location = New System.Drawing.Point(417, 583)
        Me.confirmbtn.Name = "confirmbtn"
        Me.confirmbtn.Size = New System.Drawing.Size(198, 47)
        Me.confirmbtn.TabIndex = 11
        Me.confirmbtn.Text = "Confirm"
        Me.confirmbtn.UseVisualStyleBackColor = False
        Me.confirmbtn.Visible = False
        '
        'nametxtbox
        '
        Me.nametxtbox.BackColor = System.Drawing.Color.White
        Me.nametxtbox.Cursor = System.Windows.Forms.Cursors.Default
        Me.nametxtbox.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nametxtbox.Location = New System.Drawing.Point(368, 497)
        Me.nametxtbox.Multiline = True
        Me.nametxtbox.Name = "nametxtbox"
        Me.nametxtbox.ReadOnly = True
        Me.nametxtbox.Size = New System.Drawing.Size(361, 47)
        Me.nametxtbox.TabIndex = 10
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.White
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(361, 457)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(88, 37)
        Me.Label1.TabIndex = 9
        Me.Label1.Text = "Name"
        '
        'adminprofile
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1035, 681)
        Me.Controls.Add(Me.editnamebtn)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.confirmbtn)
        Me.Controls.Add(Me.nametxtbox)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "adminprofile"
        Me.Text = "adminprofile"
        Me.Panel1.ResumeLayout(False)
        CType(Me.editphotobtn, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.photodisplay, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.editnamebtn, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Panel1 As Panel
    Friend WithEvents editphotobtn As PictureBox
    Friend WithEvents photodisplay As PictureBox
    Friend WithEvents editnamebtn As PictureBox
    Friend WithEvents confirmbtn As Button
    Friend WithEvents nametxtbox As TextBox
    Friend WithEvents Label1 As Label
End Class
