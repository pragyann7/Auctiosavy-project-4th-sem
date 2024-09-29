Imports Microsoft.VisualBasic.ApplicationServices
Imports System.Data.SqlClient
Imports System.Reflection.Emit
Imports System.Windows.Forms.VisualStyles.VisualStyleElement
Imports System.IO

Public Class adminprofile
    Dim connectionstring As String = "Data Source=192.168.1.69;Initial Catalog=UsersDB;User ID=SA;Password=MyStrongPass123;"

    Private Sub adminprofile_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        showprofile()
    End Sub

    Sub showprofile()
        Using connection As New SqlConnection(connectionstring)
            connection.Open()

            ' Query to fetch name and user_photo (stored as VARBINARY(MAX))
            Dim query As String = "SELECT name, user_photo FROM userdetails WHERE user_id = 108"

            Using command As New SqlCommand(query, connection)
                Using reader As SqlDataReader = command.ExecuteReader()
                    'If reader.Read() Then ' Ensure there's data to read
                    If reader.Read() Then ' Ensure there's data to read
                            ' Display the user's name
                            nametxtbox.Text = reader("name").ToString()
                            '' Display the user's name
                            'photodisplay.Text = reader("name").ToString()

                            ' Fetch and display the user's photo
                            If Not IsDBNull(reader("user_photo")) Then
                            Dim imageData As Byte() = DirectCast(reader("user_photo"), Byte())

                            If imageData.Length > 0 Then
                                ' Convert byte array to image and display it
                                Using ms As New MemoryStream(imageData)
                                    photodisplay.Image = Image.FromStream(ms)
                                    photodisplay.SizeMode = PictureBoxSizeMode.StretchImage
                                End Using
                            Else
                                ' Set a placeholder image if no valid image exists
                                photodisplay.Image = My.Resources.userphoto
                            End If
                        Else
                            ' Set a placeholder image if no photo is found in the database
                            photodisplay.Image = My.Resources.userphoto
                        End If
                    End If
                End Using
            End Using
        End Using
    End Sub



    Private resizee As resizehelper

    Public Sub New()
        InitializeComponent()
        resizee = New resizehelper(Me)
        resizee.AddControl(editphotobtn)
        resizee.AddControl(nametxtbox)
        resizee.AddControl(photodisplay)
        resizee.AddControl(Panel1)
        resizee.AddControl(Label1)
        resizee.AddControl(editnamebtn)
        resizee.AddControl(confirmbtn)
        AddHandler Me.Resize, AddressOf AddproductWview_Resize
    End Sub
    Private Sub AddproductWview_Resize(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
        resizee.HandleResize(Me)
    End Sub

    Private Sub editnamebtn_Click(sender As Object, e As EventArgs) Handles editnamebtn.Click
        editnamebtn.Hide()
        confirmbtn.Show()
        nametxtbox.ReadOnly = False
        nametxtbox.Focus()
        nametxtbox.Cursor = Cursors.IBeam
        nametxtbox.SelectionStart = nametxtbox.Text.Length
        nametxtbox.SelectionLength = 0
    End Sub


    Public path As String
    Private Sub editphotobtn_Click(sender As Object, e As EventArgs) Handles editphotobtn.Click
        Me.ActiveControl = Nothing
        Using openFileDialog As New OpenFileDialog()
            openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.gif"
            If openFileDialog.ShowDialog() = DialogResult.OK Then
                Dim photoPath As String = openFileDialog.FileName
                path = photoPath
                ' Load the selected image into the PictureBox
                photodisplay.Image = Image.FromFile(photoPath)
                photodisplay.SizeMode = PictureBoxSizeMode.StretchImage ' Adjust the image size
                confirmbtn.Show()
            End If
        End Using
    End Sub

    Private Sub adminprofile_Click(sender As Object, e As EventArgs) Handles MyBase.Click
        Me.ActiveControl = Nothing
    End Sub

    Private Sub nametxtbox_Leave(sender As Object, e As EventArgs) Handles nametxtbox.Leave
        editnamebtn.Show()
        nametxtbox.ReadOnly = True
        nametxtbox.Cursor = Cursors.Default
    End Sub

    Private Sub nametxtbox_Click(sender As Object, e As EventArgs) Handles nametxtbox.Click
        Me.ActiveControl = Nothing
    End Sub

    Private Sub confirmbtn_Click(sender As Object, e As EventArgs) Handles confirmbtn.Click
        Try
            Me.ActiveControl = Nothing
            Dim Aname As String = nametxtbox.Text
            Dim photopath As String = path
            Dim photoData As Byte() = File.ReadAllBytes(photopath)
            Using connection As New SqlConnection(connectionstring)
                connection.Open()
                Dim query As String = "UPDATE userdetails set name = @Aname, user_photo = @photoData where user_id = 108"
                Using command As New SqlCommand(query, connection)
                    command.Parameters.AddWithValue("@Aname", Aname)
                    command.Parameters.AddWithValue("@photoData", photoData) ' Use the byte array for the photo

                    ' Execute the update query
                    Dim rowsAffected As Integer = command.ExecuteNonQuery()
                    If rowsAffected > 0 Then
                        MessageBox.Show("Profile updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        confirmbtn.Hide()
                        Dim update As adminpanel = CType(Application.OpenForms("adminpanel"), adminpanel)
                        update.showprofile()
                    Else
                        MessageBox.Show("Profile couldn't be updated.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End If
                End Using
            End Using
            'addproduct_Load(Me, EventArgs.Empty)
        Catch ex As Exception
            MessageBox.Show("An error occurred: " & ex.Message)
        End Try
    End Sub
End Class