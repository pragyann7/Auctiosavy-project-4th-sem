Imports System.Data.SqlClient
Imports System.IO

Public Class showproductdetail
    Private productId As String
    Dim CstartTime As DateTime
    Dim CendTime As DateTime
    'hotspot
    'Dim connectionString As String = "Data Source=192.168.140.20;Initial Catalog=UsersDB;Persist Security Info=True;User ID=SA;Password=MyStrongPass123"
    'Dim connectionString As String = "Data Source=192.168.1.69;Initial Catalog=UsersDB;Persist Security Info=True;User ID=SA;Password=MyStrongPass123"
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
            Dim query As String = "SELECT item_name, item_photo_path, description, starting_price, start_time, end_time, status FROM AuctionItems WHERE item_id = @productId"
            Using cmd As New SqlCommand(query, connection)
                cmd.Parameters.AddWithValue("@productId", productId)
                Using reader As SqlDataReader = cmd.ExecuteReader
                    If reader.Read() Then
                        ' Reading product details
                        productnamelbl.Text = reader("item_name").ToString()
                        descriptiontxtbox.Text = reader("description").ToString()
                        startingprice.Text = reader("starting_price").ToString()
                        productidlbl.Text = productId

                        ' Reading datetime fields
                        Dim startTime As DateTime = If(IsDBNull(reader("start_time")), DateTime.MinValue, DirectCast(reader("start_time"), DateTime))
                        Dim endTime As DateTime = If(IsDBNull(reader("end_time")), DateTime.MinValue, DirectCast(reader("end_time"), DateTime))
                        CstartTime = startTime
                        CendTime = endTime
                        Astartingtimelbl.Text = startTime.ToString("G")
                        Aendingtimelbl.Text = endTime.ToString("G")
                        statuslbl.Text = reader("status").ToString()

                        ' Reading the image path (VARCHAR)
                        Dim photoPath As String = If(IsDBNull(reader("item_photo_path")), Nothing, reader("item_photo_path").ToString())

                        If Not String.IsNullOrEmpty(photoPath) AndAlso File.Exists(photoPath) Then
                            productimg.Image = Image.FromFile(photoPath) ' Load image from file path
                            productimg.SizeMode = PictureBoxSizeMode.StretchImage
                        Else
                            productimg.Image = My.Resources.userphoto ' Set a placeholder image if no valid photo path exists
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
        resizee.AddControl(ListView1)
        resizee.AddControl(TableLayoutPanel1)
        'resizee.AddControl(user3)
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
        ' Initialize the live bids display when the form loads
        LoadLiveBids(productId) ' Replace with the actual item ID
        SetupTimer() ' Start the auto-refresh timer
        ListView1.View = View.Details
        ListView1.Columns.Add("Bidder", 100) ' Column for Anonymous name
        ListView1.Columns.Add("Bid Amount", 100) ' Column for Bid Amount
        ListView1.Columns.Add("Time", 150) ' Column for Bid Time
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

    Private Sub LoadLiveBids(productId As String)
        ' Define the connection string to your database
        'Dim connectionString As String = "your_connection_string_here"

        ' SQL query to fetch live bids for a specific auction item along with the username
        Dim query As String = "
        SELECT 
    u.name AS UserName, 
    b.bid_amount AS BidAmount, 
    b.bid_time AS BidTime 
FROM 
    Bids b
JOIN 
    UserDetails u ON b.user_id = u.user_id
WHERE 
    b.item_id = @item_id
ORDER BY 
    b.bid_time ASC;
    "

        ' Clear the ListView before loading new bids
        ListView1.Items.Clear()

        ' Using block to handle database connections
        Using connection As New SqlConnection(connectionString)
            connection.Open()

            ' Create a data adapter to fetch the results
            Using adapter As New SqlDataAdapter(query, connection)
                ' Add the item_id parameter to filter by auction item
                adapter.SelectCommand.Parameters.AddWithValue("@item_id", productId)

                ' Create a DataTable to hold the result
                Dim bidsTable As New DataTable()

                ' Fill the DataTable with the query result
                adapter.Fill(bidsTable)

                ' Populate the ListView with data
                For Each row As DataRow In bidsTable.Rows
                    ' Create a new ListViewItem with the actual username
                    Dim listViewItem As New ListViewItem(row("Username").ToString()) ' Set the username
                    listViewItem.SubItems.Add(Convert.ToDecimal(row("BidAmount")).ToString("C2")) ' Format as currency
                    listViewItem.SubItems.Add(Convert.ToDateTime(row("BidTime")).ToString()) ' Add bid time

                    ' Add the ListViewItem to the ListView
                    ListView1.Items.Add(listViewItem)
                Next
            End Using
        End Using
    End Sub


    Private Sub SetupTimer()
        Dim refreshTimer As New Timer()
        refreshTimer.Interval = 5000 ' Set interval to 5 seconds
        AddHandler refreshTimer.Tick, AddressOf RefreshLiveBids
        refreshTimer.Start()
    End Sub

    Private Sub RefreshLiveBids(sender As Object, e As EventArgs)
        LoadLiveBids(productId) ' Replace with your current item ID logic
    End Sub
End Class