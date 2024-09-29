Imports System.Data.SqlClient
Imports System.IO

Public Class showproductdetail
    Private productId As String
    Dim CstartTime As DateTime
    Dim CendTime As DateTime
    'hotspot
    'Dim connectionString As String = "Data Source=192.168.140.20;Initial Catalog=UsersDB;Persist Security Info=True;User ID=SA;Password=MyStrongPass123"
    Dim connectionString As String = "Data Source=192.168.1.69;Initial Catalog=UsersDB;Persist Security Info=True;User ID=SA;Password=MyStrongPass123"


    '' Constructor that accepts productId
    'Public Sub New(id As String)
    '    InitializeComponent()
    '    productId = id
    '    'LoadProductDetails()
    'End Sub

    ' Constructor that accepts productId
    Public Sub New(id As String)
        ' Call the parameterless constructor to initialize the resizehelper
        Me.New()

        productId = id
        LoadProductDetails()
    End Sub

    '' Method to load product details based on productId
    Private Sub LoadProductDetails()
        Using connection As New SqlConnection(connectionString)
            connection.Open()
            Dim query As String = "SELECT item_name, item_photo_path, description, starting_price, start_time, end_time, status from AuctionItems where item_id = @productId"
            Using cmd As New SqlCommand(query, connection)
                cmd.Parameters.AddWithValue("@productId", productId)
                Using reader As SqlDataReader = cmd.ExecuteReader
                    If reader.Read() Then
                        productnamelbl.Text = reader("item_name").ToString
                        descriptiontxtbox.Text = reader("description").ToString
                        startingprice.Text = reader("starting_price").ToString
                        productidlbl.Text = productId
                        'for reading datetime
                        Dim startTime As DateTime = If(IsDBNull(reader("start_time")), DateTime.MinValue, DirectCast(reader("start_time"), DateTime))
                        Dim endTime As DateTime = If(IsDBNull(reader("end_time")), DateTime.MinValue, DirectCast(reader("end_time"), DateTime))
                        Dim photoData As Byte() = If(IsDBNull(reader("item_photo_path")), Nothing, DirectCast(reader("item_photo_path"), Byte()))
                        CstartTime = reader("start_time")
                        CendTime = reader("end_time")
                        Astartingtimelbl.Text = startTime.ToString("G")
                        Aendingtimelbl.Text = endTime.ToString("G")
                        statuslbl.Text = reader("status").ToString

                        If photoData IsNot Nothing Then
                            Using ms As New MemoryStream(photoData)
                                productimg.Image = Image.FromStream(ms) ' Assuming picProductPhoto is your PictureBox
                                productimg.SizeMode = PictureBoxSizeMode.StretchImage
                            End Using
                        Else
                            productimg.Image = My.Resources.userphoto ' Set a placeholder image if no photo exists
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
        resizee.AddControl(Label7)
        resizee.AddControl(topbar)
        resizee.AddControl(statuslbl)
        resizee.AddControl(label2)
        resizee.AddControl(productidlbl)
        resizee.AddControl(productimg)
        resizee.AddControl(TableLayoutPanel2)
        resizee.AddControl(productnamelbl)
        resizee.AddControl(descriptiontxtbox)
        resizee.AddControl(Button1)
        resizee.AddControl(Button2)
        resizee.AddControl(startingprice)
        resizee.AddControl(Label8)
        resizee.AddControl(Label9)
        resizee.AddControl(Label10)
        resizee.AddControl(Astartingtimelbl)
        resizee.AddControl(Aendingtimelbl)
        resizee.AddControl(Aendingtimelbl)
        resizee.AddControl(livebidshow)
        resizee.AddControl(pdbidlbl)
        resizee.AddControl(user1)
        resizee.AddControl(user2)
        resizee.AddControl(user3)
        resizee.AddControl(Panel1)
        resizee.AddControl(Label1)
        resizee.AddControl(Label3)
        resizee.AddControl(backtoproduct)
        resizee.AddControl(lblCountdown)
        AddHandler Me.Resize, AddressOf form1_Resize
    End Sub
    Private Sub form1_Resize(ByVal sender As Object, ByVal e As EventArgs)
        If resizee IsNot Nothing Then
            resizee.HandleResize(Me)
        End If
    End Sub

    Private Sub showproductdetail_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        AddHandler Me.Resize, AddressOf form1_Resize
        ' Start the timer to update the countdown every second
        timerCountdown.Interval = 1000 ' 1 second
        timerCountdown.Start()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        ' Display a confirmation message box
        Dim result As DialogResult = MessageBox.Show("Are you sure you want to delete this item?", "Confirm Deletion", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)

        ' Check if the user clicked "Yes"
        If result = DialogResult.Yes Then
            ' Perform the deletion operation
            DeleteItem(productId)
        End If
    End Sub
    Private Sub DeleteItem(productId As String)
        Using connection As New SqlConnection(connectionString)
            Try
                connection.Open()
                Dim query As String = "DELETE FROM AuctionItems WHERE item_id = @productId"
                Using command As New SqlCommand(query, connection)
                    command.Parameters.AddWithValue("@productId", productId)
                    Dim rowsAffected As Integer = command.ExecuteNonQuery()
                    If rowsAffected > 0 Then
                        MessageBox.Show("Product deleted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        Dim press As adminpanel = CType(Application.OpenForms("adminpanel"), adminpanel)
                        press.manageauctionbtn.PerformClick()
                    Else
                        MessageBox.Show("Product not found or couldn't be deleted.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End If
                End Using
            Catch ex As Exception
                MessageBox.Show("An error occurred while deleting the product: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End Using
    End Sub

    Private Sub backtoproduct_Click(sender As Object, e As EventArgs) Handles backtoproduct.Click
        Dim q As adminpanel = CType(Application.OpenForms("adminpanel"), adminpanel)
        q.manageauctionbtn.PerformClick()
    End Sub

    Private Sub updateproduct_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim updatepro As New Updateproduct(productId)
        Dim update As adminpanel = CType(Application.OpenForms("adminpanel"), adminpanel)
        update.showform(updatepro)
    End Sub

    Private Sub timerCountdown_Tick(sender As Object, e As EventArgs) Handles timerCountdown.Tick
        Dim now As DateTime = DateTime.Now

        If now < CstartTime Then
            ' Auction has not started yet, show countdown to the start
            Dim timeUntilStart As TimeSpan = CstartTime - now
            lblCountdown.Text = $"Auction starts in:
{timeUntilStart.Days}d {timeUntilStart.Hours}h {timeUntilStart.Minutes}m {timeUntilStart.Seconds}s"
        ElseIf now >= CstartTime And now < CendTime Then
            ' Auction has started, show countdown to the end
            Dim timeUntilEnd As TimeSpan = CendTime - now
            lblCountdown.Text = $"Auction ends in:
{timeUntilEnd.Days}d {timeUntilEnd.Hours}h {timeUntilEnd.Minutes}m {timeUntilEnd.Seconds}s"
        Else
            ' Auction has ended
            lblCountdown.Text = "Auction has ended"
            timerCountdown.Stop()
        End If
    End Sub

    Private Sub descriptiontxtbox_Click(sender As Object, e As EventArgs) Handles descriptiontxtbox.Click
        Me.ActiveControl = Nothing
    End Sub
End Class