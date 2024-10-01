Imports System.Data.SqlClient
Imports System.IO

Public Class addproduct
    'hotspot
    'Dim connectionString As String = "Data Source=192.168.140.20;Initial Catalog=UsersDB;Persist Security Info=True;User ID=SA;Password=MyStrongPass123"

    'Dim connectionString As String = "Data Source=192.168.1.69;Initial Catalog=UsersDB;Persist Security Info=True;User ID=SA;Password=MyStrongPass123"
    Private random As New Random()

    Private Sub addproduct_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        initiliazerplaceholder()
        Me.ActiveControl = Label1
    End Sub

    Private Sub initiliazerplaceholder()
        Pnametxtbox.Text = "Product name"
        Pnametxtbox.ForeColor = Color.Gray
        descriptiontxtbox.Text = "Description"
        descriptiontxtbox.ForeColor = Color.Gray
        Ppricetxtbox.Text = "Price"
        Ppricetxtbox.ForeColor = Color.Gray
        categorycombobx.SelectedIndex = -1
        Pidtxtbox.Text = ""
        starttimepicker.Value = DateTime.Now
        endtimepicker.Value = DateTime.Now
        productimage.Image = My.Resources.add_image
        clearimage.Visible = False
        pathlbl.Visible = False
        pathname.Visible = False
    End Sub

    Private Sub Pnametxtbox_Enter(sender As Object, e As EventArgs) Handles Pnametxtbox.Enter
        If Pnametxtbox.Text = "Product name" Then
            Pnametxtbox.Text = ""
            Pnametxtbox.ForeColor = Color.Black
        End If
    End Sub

    Private Sub Pnametxtbox_Leave(sender As Object, e As EventArgs) Handles Pnametxtbox.Leave
        If Pnametxtbox.Text = String.Empty Then
            Pnametxtbox.Text = "Product name"
            Pnametxtbox.ForeColor = Color.Gray
        End If
    End Sub

    Private Sub descriptiontxtbox_Enter(sender As Object, e As EventArgs) Handles descriptiontxtbox.Enter
        If descriptiontxtbox.Text = "Description" Then
            descriptiontxtbox.Text = ""
            descriptiontxtbox.ForeColor = Color.Black
        End If
    End Sub

    Private Sub descriptiontxtbox_Leave(sender As Object, e As EventArgs) Handles descriptiontxtbox.Leave
        If descriptiontxtbox.Text = String.Empty Then
            descriptiontxtbox.Text = "Description"
            descriptiontxtbox.ForeColor = Color.Gray
        End If
    End Sub

    Private Sub Ppricetxtbox_Enter(sender As Object, e As EventArgs) Handles Ppricetxtbox.Enter
        If Ppricetxtbox.Text = "Price" Then
            Ppricetxtbox.Text = ""
            Ppricetxtbox.ForeColor = Color.Black
        End If
    End Sub

    Private Sub Ppricetxtbox_Leave(sender As Object, e As EventArgs) Handles Ppricetxtbox.Leave
        If Ppricetxtbox.Text = String.Empty Then
            Ppricetxtbox.Text = "Price"
            Ppricetxtbox.ForeColor = Color.Gray
        End If
    End Sub

    Private Sub categorycombobx_Enter(sender As Object, e As EventArgs) Handles categorycombobx.Enter
        If categorycombobx.Text = "Select" Then
            categorycombobx.Text = ""
            categorycombobx.ForeColor = Color.Black
        End If
    End Sub

    Private Sub categorycombobx_Leave(sender As Object, e As EventArgs) Handles categorycombobx.Leave
        If categorycombobx.Text = String.Empty Then
            categorycombobx.Text = "Select"
            categorycombobx.ForeColor = Color.Gray
        End If
    End Sub

    Private Sub starttimepicker_ValueChanged(sender As Object, e As EventArgs) Handles starttimepicker.ValueChanged
        Me.ActiveControl = Nothing
    End Sub

    Private Sub endtimepicker_ValueChanged(sender As Object, e As EventArgs) Handles starttimepicker.ValueChanged
        Me.ActiveControl = Nothing
    End Sub

    'Private Sub Pidtxtbox_Enter(sender As Object, e As EventArgs) Handles Pidtxtbox.Enter
    '    Me.ActiveControl = Nothing
    'End Sub

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

    Private Sub addproductbtn_Click(sender As Object, e As EventArgs) Handles addproductbtn.Click
        Dim currentDateTime As DateTime = DateTime.Now
        If Pnametxtbox.Text = "Product Name" OrElse
        Pidtxtbox.Text = "" OrElse
        Ppricetxtbox.Text = "Price" OrElse
        categorycombobx.SelectedIndex = -1 Then
            MessageBox.Show("Please fill in all the fields.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            Try
                Me.ActiveControl = Nothing
                Dim itemId As String = Pidtxtbox.Text
                Dim itemName As String = Pnametxtbox.Text
                Dim description As String = descriptiontxtbox.Text
                Dim startingprice As Decimal = Decimal.Parse(Ppricetxtbox.Text) ' Ensure it's a decimal
                Dim category As String = categorycombobx.SelectedItem.ToString() ' Ensure it's a string
                Dim startTime As DateTime = starttimepicker.Value
                Dim endTime As DateTime = endtimepicker.Value
                Dim photoPath As String = pathname.Text ' Get the photo path

                Using connection As New SqlConnection(connectionString)
                    Dim command As New SqlCommand("INSERT INTO AuctionItems (item_id, item_name, item_photo_path, description, category, starting_price, start_time, end_time, current_bid, status) VALUES (@item_id, @item_name, @item_photo_path, @description, @category, @starting_price, @start_time, @end_time, NULL, 'pending')", connection)

                    command.Parameters.AddWithValue("@item_id", itemId)
                    command.Parameters.AddWithValue("@item_name", itemName)
                    command.Parameters.AddWithValue("@item_photo_path", photoPath) ' Use the file path for the photo
                    command.Parameters.AddWithValue("@description", description)
                    command.Parameters.AddWithValue("@category", category)
                    command.Parameters.AddWithValue("@starting_price", startingprice) ' Make sure it's a decimal
                    command.Parameters.AddWithValue("@start_time", startTime)
                    command.Parameters.AddWithValue("@end_time", endTime)

                    connection.Open()
                    command.ExecuteNonQuery()
                End Using

                MessageBox.Show("Item inserted successfully!")
                addproduct_Load(Me, EventArgs.Empty)
            Catch ex As Exception
                MessageBox.Show("An error occurred: " & ex.Message)
            End Try
        End If
    End Sub

    Private Sub Pidgeneratebtn_Click(sender As Object, e As EventArgs) Handles Pidgeneratebtn.Click
        Me.ActiveControl = Nothing
        Dim uniqueID As String = GenerateUniqueItemID()
        Pidtxtbox.Text = uniqueID
    End Sub
    Private Function GenerateUniqueItemID() As String
        Dim itemID As String

        Do
            Dim randomNumber As Integer = random.Next(10000, 99999) ' Generate a random number
            itemID = "00p" & randomNumber.ToString() ' Concatenate with "00p"

            ' Loop until a unique itemID is found
        Loop While Not IsUniqueItemID(itemID)

        Return itemID ' Return the unique itemID
    End Function

    Private Function IsUniqueItemID(itemID As String) As Boolean
        Dim exists As Boolean = False

        Using connection As New SqlConnection(connectionString)
            Dim command As New SqlCommand("SELECT COUNT(*) FROM dbo.AuctionItems WHERE item_id = @item_id", connection)
            command.Parameters.AddWithValue("@item_id", itemID)

            connection.Open()
            Dim count As Integer = Convert.ToInt32(command.ExecuteScalar())
            exists = (count > 0) ' If count > 0, item_id exists
        End Using

        Return Not exists ' Return true if unique (does not exist in the database)
    End Function

    Private Sub clearimage_Click(sender As Object, e As EventArgs) Handles clearimage.Click
        productimage.Image = Nothing
        pathname.Text = String.Empty
        productimage.Image = My.Resources.add_image
        pathlbl.Visible = False
        clearimage.Visible = False
        Me.ActiveControl = Nothing
    End Sub

    Private Sub categorycombobx_SelectedIndexChanged(sender As Object, e As EventArgs) Handles categorycombobx.SelectedIndexChanged
        Me.ActiveControl = Nothing
    End Sub

    Private resizee As resizehelper

    Public Sub New()
        InitializeComponent()
        resizee = New resizehelper(Me)
        resizee.AddControl(Label1)
        resizee.AddControl(Label2)
        resizee.AddControl(Label3)
        resizee.AddControl(Label4)
        resizee.AddControl(Label5)
        resizee.AddControl(Label6)
        resizee.AddControl(Label7)
        resizee.AddControl(Label8)
        resizee.AddControl(productimage)
        resizee.AddControl(Pidgeneratebtn)
        resizee.AddControl(categorycombobx)
        resizee.AddControl(descriptiontxtbox)
        resizee.AddControl(starttimepicker)
        resizee.AddControl(endtimepicker)
        resizee.AddControl(PictureBox1)
        resizee.AddControl(addproductbtn)
        resizee.AddControl(pathname)
        resizee.AddControl(photoselectbtn)
        resizee.AddControl(pathlbl)
        resizee.AddControl(clearimage)
        resizee.AddControl(Pnametxtbox)
        resizee.AddControl(Pidtxtbox)
        resizee.AddControl(Ppricetxtbox)
        resizee.AddControl(backviewproduct)
        'resizee.AddControl(Panel1)



        ' Event handler for resizing the form
        AddHandler Me.Resize, AddressOf Form1_Resize


        ' Set TextBox to multiline
        'textBox1.Multiline = True
    End Sub

    ' Event handler for resizing controls when the form is resized
    Private Sub Form1_Resize(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
        resizee.HandleResize(Me)
    End Sub

    Private Sub addproduct_Click(sender As Object, e As EventArgs) Handles MyBase.Click
        Me.ActiveControl = Nothing
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles backviewproduct.Click
        Dim form2 As adminpanel = CType(Application.OpenForms("adminpanel"), adminpanel)
        If form2 IsNot Nothing Then
            form2.addproductbtn.PerformClick()
        End If
    End Sub
End Class
