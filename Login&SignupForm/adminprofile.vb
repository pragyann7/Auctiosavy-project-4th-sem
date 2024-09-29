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

            ' Correct the query to fetch name and user_photo
            Dim query As String = "SELECT name, user_photo FROM userdetails WHERE user_id = 107"

            Using command As New SqlCommand(query, connection)
                Using reader As SqlDataReader = command.ExecuteReader
                    If reader.Read() Then ' Ensure there's data to read
                        ' Display the user's name
                        nametxtbox.Text = reader("name").ToString()

                        ' Fetch and display the user's photo
                        Dim photoPath As String = reader("user_photo").ToString()

                        If Not String.IsNullOrEmpty(photoPath) AndAlso File.Exists(photoPath) Then
                            ' Load the image from the file path
                            photodisplay.Image = Image.FromFile(photoPath)
                            photodisplay.SizeMode = PictureBoxSizeMode.StretchImage
                        Else
                            ' Set a placeholder image if no photo exists or path is invalid
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

    Private Sub editphotobtn_Click(sender As Object, e As EventArgs) Handles editphotobtn.Click
        Me.ActiveControl = Nothing
        Using openFileDialog As New OpenFileDialog()
            openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.gif"
            If openFileDialog.ShowDialog() = DialogResult.OK Then
                Dim photoPath As String = openFileDialog.FileName
                photodisplay.Image = Image.FromFile(photoPath)
                photodisplay.SizeMode = PictureBoxSizeMode.StretchImage ' Adjust the image size
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
        Dim Aname As String = nametxtbox.Text
        Dim AphotoPath As String = "" ' Initialize variable to hold image path

        ' Check if an image is selected and store the file path
        If photodisplay.Image IsNot Nothing Then
            ' Assuming you have the file path of the image saved somewhere, assign it to AphotoPath
            ' For example, if you're allowing users to browse and select images:
            AphotoPath = photodisplay.ImageLocation ' This assumes you're using ImageLocation to load images.
        End If

        Try
            Using connection As New SqlConnection(connectionstring)
                connection.Open()
                Dim query As String = "UPDATE userdetails SET name = @Aname, user_photo = @AphotoPath WHERE user_id = @userId"
                Using command As New SqlCommand(query, connection)
                    ' Parameters for name and photo path
                    command.Parameters.AddWithValue("@Aname", Aname)
                    command.Parameters.AddWithValue("@AphotoPath", AphotoPath) ' Store the file path, not the image binary
                    command.Parameters.AddWithValue("@userId", 105) ' Assuming you're updating user ID 105

                    ' Execute the update query
                    Dim rowsAffected As Integer = command.ExecuteNonQuery()
                    If rowsAffected > 0 Then
                        MessageBox.Show("Profile updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Else
                        MessageBox.Show("User not found or couldn't be updated.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End If
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("An error occurred: " & ex.Message)
        End Try
    End Sub
End Class