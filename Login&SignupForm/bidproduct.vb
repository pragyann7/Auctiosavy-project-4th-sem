Imports System.Data.SqlClient
Imports System.IO

Public Class bidproduct
    Private productId As String
    Dim CstartTime As DateTime
    Dim CendTime As DateTime
    'hotspot
    'Dim connectionString As String = "Data Source=192.168.140.20;Initial Catalog=UsersDB;Persist Security Info=True;User ID=SA;Password=MyStrongPass123"
    Dim connectionString As String = "Data Source=192.168.1.69;Initial Catalog=UsersDB;Persist Security Info=True;User ID=SA;Password=MyStrongPass123"
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



    Private Sub showproductdetail_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadLiveBids(productId)
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
        bidtxtbox.Text = " Amount"
        bidtxtbox.ForeColor = Color.Gray
    End Sub

    Private Sub timerCountdown_Tick(sender As Object, e As EventArgs) Handles timerCountdown.Tick
        Dim now As DateTime = DateTime.Now

        If now < CstartTime Then
            ' Auction has not started yet, show countdown to the start
            Dim timeUntilStart As TimeSpan = CstartTime - now
            lblCountdown.Text = $"Auction starts in:
{timeUntilStart.Days}d {timeUntilStart.Hours}h {timeUntilStart.Minutes}m {timeUntilStart.Seconds}s"
            'descriptiontxtbox.Size = New Size(530, 154)
            bidtxtbox.Hide()
            confirmbid.Hide()
        ElseIf now >= CstartTime And now < CendTime Then
            ' Auction has started, show countdown to the end
            Dim timeUntilEnd As TimeSpan = CendTime - now
            lblCountdown.Text = $"Auction ends in:
{timeUntilEnd.Days}d {timeUntilEnd.Hours}h {timeUntilEnd.Minutes}m {timeUntilEnd.Seconds}s"
            'descriptiontxtbox.Size = New Size(530, 100)
            bidtxtbox.Show()
            confirmbid.Show()
        Else
            ' Auction has ended 
            lblCountdown.Text = "Auction has ended"
            timerCountdown.Stop()
            'descriptiontxtbox.Size = New Size(530, 154)
            bidtxtbox.Hide()
            confirmbid.Hide()
        End If
    End Sub

    Private Sub descriptiontxtbox_Click(sender As Object, e As EventArgs) Handles descriptiontxtbox.Click
        Me.ActiveControl = Nothing
    End Sub

    Private Sub backtoproduct_Click(sender As Object, e As EventArgs) Handles backtoproduct.Click
        'Dim form2 As userproduct = CType(Application.OpenForms("userproduct"), userproduct)
        'form2.showform(LoadProductsIntoFlowLayoutPanel)

    End Sub

    Private Sub confirmbid_Click(sender As Object, e As EventArgs) Handles confirmbid.Click
        Dim userID As Integer = LoggedInUserID
        Dim bidAmount As Decimal

        ' Check if the TextBox is empty or has default text
        If String.IsNullOrWhiteSpace(bidtxtbox.Text) OrElse bidtxtbox.Text = " Amount" Then
            MessageBox.Show("Enter an amount before submitting.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        ' Remove any commas or formatting that might cause issues
        Dim input As String = bidtxtbox.Text.Replace(",", "").Trim()

        ' Try to parse the input into a Decimal
        If Decimal.TryParse(input, bidAmount) Then
            ' Check if the bidAmount exceeds the maximum value allowed by the database
            If bidAmount > 999999999.99D Then
                MessageBox.Show("Bid amount exceeds the maximum allowed value.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return
            End If

            ' Call your method to place the bid
            PlaceBid(userID, productId, bidAmount)
        Else
            MessageBox.Show("Please enter a valid bid amount.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub


    Sub PlaceBid(userID As Integer, item_id As String, bid_amount As Decimal)
        ' Step 1: Fetch the auction item details
        Dim query As String = "SELECT starting_price, current_bid FROM AuctionItems WHERE item_id = @item_id"

        Dim startingPrice As Decimal
        Dim currentBid As Decimal
        Try
            Using connection As New SqlConnection(connectionString)
                connection.Open()

                ' Fetch the starting price and current bid from the database
                Using command As New SqlCommand(query, connection)
                    command.Parameters.AddWithValue("@item_id", item_id)

                    Using reader As SqlDataReader = command.ExecuteReader()
                        If reader.Read() Then
                            startingPrice = reader("starting_price")
                            currentBid = If(IsDBNull(reader("current_bid")), 0, reader("current_bid"))
                        Else
                            ' Item not found
                            MessageBox.Show("Auction item not found.")
                            Exit Sub
                        End If
                    End Using
                End Using

                ' Step 2: Validate the bid amount
                If bid_amount <= startingPrice Then
                    MessageBox.Show("Your bid must be higher than the starting price.")
                    Exit Sub
                End If

                If bid_amount <= currentBid Then
                    MessageBox.Show("Your bid must be higher than the current highest bid.")
                    Exit Sub
                End If


                ' Step 3: Place the bid
                Dim insertBidQuery As String = "INSERT INTO Bids (item_id, user_id, bid_amount) VALUES (@item_id, @user_id, @bid_amount)"

                Using insertCommand As New SqlCommand(insertBidQuery, connection)
                    insertCommand.Parameters.AddWithValue("@item_id", item_id)
                    insertCommand.Parameters.AddWithValue("@user_id", userID)
                    insertCommand.Parameters.AddWithValue("@bid_amount", bid_amount)
                    insertCommand.ExecuteNonQuery()
                End Using

                ' Step 4: Update the current highest bid in the AuctionItems table
                Dim updateQuery As String = "UPDATE AuctionItems SET current_bid = @bid_amount WHERE item_id = @item_id"

                Using updateCommand As New SqlCommand(updateQuery, connection)
                    updateCommand.Parameters.AddWithValue("@bid_amount", bid_amount)
                    updateCommand.Parameters.AddWithValue("@item_id", item_id)
                    updateCommand.ExecuteNonQuery()
                End Using

                MessageBox.Show("Your bid has been placed successfully!")
                LoadLiveBids(productId)
            End Using
        Catch ex As Exception
            MessageBox.Show("An error occurred: " & ex.Message)
        End Try
    End Sub

    Private Sub LoadLiveBids(item_id As String)
        ' Define the connection string to your database
        'Dim connectionString As String = "your_connection_string_here"

        ' SQL query to fetch live bids for a specific auction item
        Dim query As String = "SELECT 
    b.bid_amount AS BidAmount, 
    b.bid_time AS BidTime 
FROM 
    Bids b 
WHERE 
    b.item_id = @item_id 
ORDER BY 
    b.bid_amount DESC, b.bid_time DESC 
OFFSET 0 ROWS 
FETCH NEXT 5 ROWS ONLY;
"

        ' Clear the ListView before loading new bids
        ListView1.Items.Clear()

        ' Using block to handle database connections
        Using connection As New SqlConnection(connectionString)
            connection.Open()

            ' Create a data adapter to fetch the results
            Using adapter As New SqlDataAdapter(query, connection)
                ' Add the item_id parameter to filter by auction item
                adapter.SelectCommand.Parameters.AddWithValue("@item_id", item_id)

                ' Create a DataTable to hold the result
                Dim bidsTable As New DataTable()

                ' Fill the DataTable with the query result
                adapter.Fill(bidsTable)

                ' Populate the ListView with data
                For Each row As DataRow In bidsTable.Rows
                    ' Create a new ListViewItem
                    Dim listViewItem As New ListViewItem("Anonymous") ' Set anonymous name
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
        resizee.AddControl(confirmbid)
        resizee.AddControl(startingprice)
        resizee.AddControl(Label8)
        resizee.AddControl(Label9)
        resizee.AddControl(Label10)
        resizee.AddControl(Astartingtimelbl)
        resizee.AddControl(Aendingtimelbl)
        resizee.AddControl(Aendingtimelbl)
        resizee.AddControl(livebidshow)
        resizee.AddControl(pdbidlbl)
        resizee.AddControl(Panel1)
        resizee.AddControl(Label1)
        resizee.AddControl(Label3)
        resizee.AddControl(backtoproduct)
        resizee.AddControl(lblCountdown)
        resizee.AddControl(ListView1)
        resizee.AddControl(bidtxtbox)
        resizee.AddControl(confirmbid)
        resizee.AddControl(descriptiontxtbox)
        resizee.AddControl(TableLayoutPanel1)
        AddHandler Me.Resize, AddressOf form1_Resize
    End Sub
    Private Sub form1_Resize(ByVal sender As Object, ByVal e As EventArgs)
        If resizee IsNot Nothing Then
            resizee.HandleResize(Me)
        End If
    End Sub

    Private Sub ListView1_Click(sender As Object, e As EventArgs) Handles ListView1.Click
        Me.ActiveControl = Nothing
    End Sub

    Private Sub bidtxtbox_Enter(sender As Object, e As EventArgs) Handles bidtxtbox.Enter
        If bidtxtbox.Text = " Amount" Then
            bidtxtbox.Text = ""
            bidtxtbox.ForeColor = Color.Black
        End If
    End Sub

    Private Sub bidtxtbox_Leave(sender As Object, e As EventArgs) Handles bidtxtbox.Leave
        If bidtxtbox.Text = String.Empty Then
            bidtxtbox.Text = " Amount"
            bidtxtbox.ForeColor = Color.Gray
        End If
    End Sub
End Class