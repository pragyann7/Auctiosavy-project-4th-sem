Imports System.Data.SqlClient
Imports System.IO
Imports System.Reflection.Emit

Public Class Updateproduct
    Private productId As String
    Private resizee As resizehelper
    'hotspot
    'Dim connectionString As String = "Data Source=192.168.140.20;Initial Catalog=UsersDB;Persist Security Info=True;User ID=SA;Password=MyStrongPass123"
    Dim connectionString As String = "Data Source=192.168.1.69;Initial Catalog=UsersDB;Persist Security Info=True;User ID=SA;Password=MyStrongPass123"
    Public Sub New(id As String)
        ' Call the parameterless constructor to initialize the resizehelper
        Me.New()

        productId = id
        LoadProductDetails()
    End Sub
    Private Sub LoadProductDetails()
        Using connection As New SqlConnection(connectionString)
            Try
                connection.Open()
                Dim query As String = "SELECT item_name, item_photo_path, description, starting_price, category, start_time, end_time, status from AuctionItems where item_id = @productId"
                Using cmd As New SqlCommand(query, connection)
                    cmd.Parameters.AddWithValue("@productId", productId)
                    Using reader As SqlDataReader = cmd.ExecuteReader
                        If reader.Read() Then
                            Pnametxtbox.Text = reader("item_name").ToString
                            descriptiontxtbox.Text = reader("description").ToString
                            Ppricetxtbox.Text = reader("starting_price").ToString
                            Pidtxtbox.Text = productId
                            'for reading datetime
                            Dim startTime As DateTime = If(IsDBNull(reader("start_time")), DateTime.MinValue, DirectCast(reader("start_time"), DateTime))
                            Dim endTime As DateTime = If(IsDBNull(reader("end_time")), DateTime.MinValue, DirectCast(reader("end_time"), DateTime))
                            Dim photoData As Byte() = If(IsDBNull(reader("item_photo_path")), Nothing, DirectCast(reader("item_photo_path"), Byte()))
                            starttimepicker.Text = startTime.ToString("G")
                            endtimepicker.Text = endTime.ToString("G")

                            If photoData IsNot Nothing Then
                                Using ms As New MemoryStream(photoData)
                                    productimage.Image = Image.FromStream(ms) ' Assuming picProductPhoto is your PictureBox
                                    productimage.SizeMode = PictureBoxSizeMode.StretchImage
                                End Using
                            Else
                                productimage.Image = My.Resources.userphoto ' Set a placeholder image if no photo exists
                            End If
                        End If
                    End Using
                End Using
            Catch ex As Exception
                MessageBox.Show("An error occurred while updating the product: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End Using
    End Sub

    Public Sub New()
        InitializeComponent()
        resizee = New resizehelper(Me)
        resizee.AddControl(cancelbtn)
        resizee.AddControl(Label2)
        resizee.AddControl(Label3)
        resizee.AddControl(Label4)
        resizee.AddControl(Label5)
        resizee.AddControl(Label6)
        resizee.AddControl(Label7)
        resizee.AddControl(Label8)
        resizee.AddControl(productimage)
        resizee.AddControl(topbar)
        resizee.AddControl(categorycombobx)
        resizee.AddControl(descriptiontxtbox)
        resizee.AddControl(starttimepicker)
        resizee.AddControl(endtimepicker)
        resizee.AddControl(PictureBox1)
        resizee.AddControl(updatepdbtn)
        resizee.AddControl(pathname)
        resizee.AddControl(photoselectbtn)
        resizee.AddControl(pathlbl)
        resizee.AddControl(clearimage)
        resizee.AddControl(Pnametxtbox)
        resizee.AddControl(Pidtxtbox)
        resizee.AddControl(Ppricetxtbox)
        'resizee.AddControl(cancelbtn)
        'resizee.AddControl(cancelbtn)


        ' Event handler for resizing the form
        AddHandler Me.Resize, AddressOf Form1_Resize


        ' Set TextBox to multiline
        'textBox1.Multiline = True
    End Sub

    ' Event handler for resizing controls when the form is resized
    Private Sub Form1_Resize(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
        resizee.HandleResize(Me)
        Dim categories As String() = {"Electronics", "Furniture", "Clothing", "Toys"}

        ' Clear existing items and add new ones
        categorycombobx.Items.Clear()
        categorycombobx.Items.AddRange(categories)
    End Sub

    Private Sub photoselectbtn_Click(sender As Object, e As EventArgs) Handles photoselectbtn.Click
        Me.ActiveControl = Nothing
        Using openFileDialog As New OpenFileDialog()
            openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.gif"
            If openFileDialog.ShowDialog() = DialogResult.OK Then
                Dim photoPath As String = openFileDialog.FileName

                ' Load the selected image into the PictureBox
                productimage.Image = Image.FromFile(photoPath)
                productimage.SizeMode = PictureBoxSizeMode.StretchImage ' Adjust the image size

                ' Store the photo path for later use
                pathname.Text = photoPath ' Store the path in a TextBox (optional)
                pathlbl.Visible = True
                pathname.Visible = True
                clearimage.Visible = True
            Else
                clearimage.Visible = False
            End If
        End Using
    End Sub

    Private Sub clearimage_Click(sender As Object, e As EventArgs) Handles clearimage.Click
        productimage.Image = Nothing
        pathname.Text = String.Empty
        productimage.Image = My.Resources.add_image
        pathlbl.Visible = False
        clearimage.Visible = False
        Me.ActiveControl = Nothing
    End Sub

    Private Sub updatepdbtn_Click(sender As Object, e As EventArgs) Handles updatepdbtn.Click
        Try
            Me.ActiveControl = Nothing
            Dim itemId As String = Pidtxtbox.Text
            Dim itemName As String = Pnametxtbox.Text
            Dim description As String = descriptiontxtbox.Text
            Dim startingprice As String = Ppricetxtbox.Text
            Dim category As String = categorycombobx.SelectedItem
            Dim startTime As DateTime = starttimepicker.Value
            Dim endTime As DateTime = endtimepicker.Value
            Dim photopath As String = pathname.Text
            Dim photoData As Byte() = File.ReadAllBytes(photopath)
            Using connection As New SqlConnection(connectionString)
                connection.Open()
                Dim query As String = "UPDATE AuctionItems 
                                   SET item_name = @item_name, 
                                       description = @description, 
                                       starting_price = @price, 
                                       category = @category, 
                                       start_time = @start_time, 
                                       end_time = @end_time, 
                                       item_photo_path = @item_photo_path
                                   WHERE item_id = @productId"
                Using command As New SqlCommand(query, connection)

                    command.Parameters.AddWithValue("@productId", productId)
                    command.Parameters.AddWithValue("@item_name", itemName)
                    command.Parameters.AddWithValue("@item_photo_path", photoData) ' Use the byte array for the photo
                    command.Parameters.AddWithValue("@description", description)
                    command.Parameters.AddWithValue("@category", category)
                    command.Parameters.AddWithValue("@price", startingprice)
                    command.Parameters.AddWithValue("@start_time", startTime)
                    command.Parameters.AddWithValue("@end_time", endTime)

                    ' Execute the update query
                    Dim rowsAffected As Integer = command.ExecuteNonQuery()
                    If rowsAffected > 0 Then
                        MessageBox.Show("Product updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Else
                        MessageBox.Show("Product not found or couldn't be updated.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End If
                End Using
            End Using
            'addproduct_Load(Me, EventArgs.Empty)
        Catch ex As Exception
            MessageBox.Show("An error occurred: " & ex.Message)
        End Try
    End Sub

    Private Sub cancelbtn_Click(sender As Object, e As EventArgs) Handles cancelbtn.Click
        Dim cancel As adminpanel = CType(Application.OpenForms("adminpanel"), adminpanel)
        'cancel.manageauctionbtn.PerformClick()
        'Dim cancel As auctionmanage = CType(Application.OpenForms("auctionmanage"), auctionmanage)
        Dim back As New showproductdetail(productId)
        cancel.showform(back)
    End Sub
End Class