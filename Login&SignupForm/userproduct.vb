Imports System.Data.SqlClient
Imports System.IO
Imports System.Timers
Imports System.Windows.Forms.VisualStyles.VisualStyleElement
Public Class userproduct
    Private loggedInUsername As String
    Private userId As String

    Public Sub New(username As String)
        InitializeComponent()
        loggedInUsername = username
    End Sub

    Private WithEvents productTimer As New System.Timers.Timer(5000) ' Check every 5 seconds
    Private existingProductIds As New HashSet(Of String)() ' Store existing product IDs

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Load products into the FlowLayoutPanel when the form loads
        LoadProductsIntoFlowLayoutPanel()
        productTimer.Start()
        'UpdateAuctionStatus()
        AuctionStatusTimer.Interval = 5000
        AuctionStatusTimer.Start()
    End Sub
    ' This event will be triggered every time the timer ticks
    Private Sub AuctionStatusTimer_Tick(sender As Object, e As EventArgs) Handles AuctionStatusTimer.Tick
        Console.WriteLine("Timer ticked at: " & DateTime.Now.ToString())
        UpdateAuctionStatus()
        InsertWinners()
    End Sub
    Sub InsertWinners()
        Using connection As New SqlConnection(connectionString)
            connection.Open()

            ' SQL command to insert winners, avoiding duplicates and handling no bids
            Dim sql As String = "
            INSERT INTO Winners (item_id, user_id, winning_bid, winning_time)
            SELECT 
                a.item_id,
                b.user_id,
                b.bid_amount,
                GETDATE()
            FROM 
                AuctionItems a
            JOIN 
                Bids b ON a.item_id = b.item_id
            WHERE 
                a.end_time <= GETDATE()  -- Auction has ended
            AND 
                b.bid_amount = (
                    SELECT MAX(bid_amount)
                    FROM Bids
                    WHERE item_id = a.item_id
                )
            AND 
                NOT EXISTS (  -- Prevent duplicates
                    SELECT 1 
                    FROM Winners w
                    WHERE w.item_id = a.item_id
                );"

            ' Create a SQL command
            Using command As New SqlCommand(sql, connection)
                Try
                    ' Execute the command
                    Dim rowsAffected As Integer = command.ExecuteNonQuery()
                    Console.WriteLine($"{rowsAffected} winner(s) inserted.")
                Catch ex As Exception
                    Console.WriteLine("An error occurred: " & ex.Message)
                End Try
            End Using
        End Using
    End Sub


    ' Optionally stop the timer when closing the form
    Private Sub MainForm_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        AuctionStatusTimer.Stop()
    End Sub

    Public Sub LoadProductsIntoFlowLayoutPanel()
        ' SQL query to retrieve product details
        Dim query As String = "SELECT item_id, item_name, starting_price, item_photo_path FROM AuctionItems"

        Using conn As New SqlConnection(connectionstring)
            conn.Open()

            Using cmd As New SqlCommand(query, conn)
                Using reader As SqlDataReader = cmd.ExecuteReader()
                    While reader.Read()
                        ' Read product details from the database
                        Dim productId As String = reader("item_id").ToString()
                        Dim productName As String = reader("item_name").ToString()
                        Dim price As Decimal = reader("starting_price")

                        ' Read product photo path (as string)
                        Dim productPhotoPath As String = If(IsDBNull(reader("item_photo_path")), Nothing, reader("item_photo_path").ToString())

                        ' Check if the product is already in the existing IDs
                        If Not existingProductIds.Contains(productId) Then
                            existingProductIds.Add(productId) ' Add to existing IDs

                            ' Create a panel for the product
                            Dim productPanel As New Panel()
                            productPanel.Size = New Size(300, 400) ' Standard size
                            productPanel.BorderStyle = BorderStyle.FixedSingle
                            productPanel.Margin = New Padding(10) ' Standard margin
                            productPanel.BackColor = Color.White

                            ' Add click event to the product panel
                            AddHandler productPanel.Click, AddressOf ProductPanel_Click

                            ' Add hover effect to the panel
                            AddHandler productPanel.MouseEnter, AddressOf SharedHoverEffect_MouseEnter
                            AddHandler productPanel.MouseLeave, AddressOf SharedHoverEffect_MouseLeave

                            ' Add a PictureBox for the product photo
                            Dim picProductPhoto As New PictureBox()
                            picProductPhoto.Location = New Point(0, 0) ' Position at the top
                            picProductPhoto.Size = New Size(300, 300) ' Standard size for the image
                            picProductPhoto.SizeMode = PictureBoxSizeMode.StretchImage

                            AddHandler picProductPhoto.Click, AddressOf ProductPanel_Click

                            ' Load the image from the path if it's not null
                            If Not String.IsNullOrEmpty(productPhotoPath) Then
                                If File.Exists(productPhotoPath) Then
                                    picProductPhoto.Image = Image.FromFile(productPhotoPath)
                                Else
                                    ' Set a placeholder image if the file does not exist
                                    picProductPhoto.Image = My.Resources.userphoto
                                End If
                            Else
                                ' Set a placeholder image if the product has no photo
                                picProductPhoto.Image = My.Resources.userphoto
                            End If

                            ' Add hover effect to the product photo (PictureBox)
                            AddHandler picProductPhoto.MouseEnter, AddressOf SharedHoverEffect_MouseEnter
                            AddHandler picProductPhoto.MouseLeave, AddressOf SharedHoverEffect_MouseLeave

                            ' Add a Label for the product ID
                            Dim lblProductId As New Label()
                            lblProductId.Text = "ID: " & productId
                            lblProductId.Location = New Point((productPanel.Width - lblProductId.Width) / 2 - 10, 310)
                            lblProductId.ForeColor = Color.Black
                            lblProductId.Font = New Font(lblProductId.Font.FontFamily, 12, lblProductId.Font.Style Or FontStyle.Bold)
                            lblProductId.AutoSize = True

                            AddHandler lblProductId.MouseEnter, AddressOf SharedHoverEffect_MouseEnter
                            AddHandler lblProductId.MouseLeave, AddressOf SharedHoverEffect_MouseLeave
                            AddHandler lblProductId.Click, AddressOf ProductPanel_Click

                            ' Add a Label for the product name
                            Dim lblProductName As New Label()
                            lblProductName.Text = "Name: " & productName
                            lblProductName.Location = New Point((productPanel.Width - lblProductName.Width) / 2 - 10, 340)
                            lblProductName.Font = New Font(lblProductName.Font.FontFamily, 12, lblProductName.Font.Style Or FontStyle.Bold)
                            lblProductName.ForeColor = Color.Black
                            lblProductName.AutoSize = True

                            AddHandler lblProductName.MouseEnter, AddressOf SharedHoverEffect_MouseEnter
                            AddHandler lblProductName.MouseLeave, AddressOf SharedHoverEffect_MouseLeave
                            AddHandler lblProductName.Click, AddressOf ProductPanel_Click

                            ' Add a Label for the product price
                            Dim lblProductPrice As New Label()
                            lblProductPrice.Text = "Price: $" & price.ToString("F2")
                            lblProductPrice.Location = New Point((productPanel.Width - lblProductPrice.Width) / 2 - 10, 370)
                            lblProductPrice.Font = New Font(lblProductPrice.Font.FontFamily, 12, lblProductPrice.Font.Style Or FontStyle.Bold)
                            lblProductPrice.ForeColor = Color.Black
                            lblProductPrice.AutoSize = True

                            AddHandler lblProductPrice.MouseEnter, AddressOf SharedHoverEffect_MouseEnter
                            AddHandler lblProductPrice.MouseLeave, AddressOf SharedHoverEffect_MouseLeave
                            AddHandler lblProductPrice.Click, AddressOf ProductPanel_Click

                            ' Add controls to the product panel
                            productPanel.Controls.Add(picProductPhoto)
                            productPanel.Controls.Add(lblProductId)
                            productPanel.Controls.Add(lblProductName)
                            productPanel.Controls.Add(lblProductPrice)

                            ' Add the product panel to the FlowLayoutPanel
                            flowLayoutPanelProducts.Controls.Add(productPanel)
                        End If
                    End While
                End Using
            End Using
        End Using
    End Sub


    Private Sub AuctionPanel_Resize(sender As Object, e As EventArgs) Handles MyBase.Resize
        ' Calculate the new margin based on the form's width
        Dim newMarginValue As Integer = Math.Max(5, (Me.Width - 400) / 50) ' Adjust 400 based on your layout
        flowLayoutPanelProducts.Margin = New Padding(newMarginValue) ' Set the new margin for the FlowLayoutPanel

        ' Adjust the size of each product panel if needed
        For Each control As Control In flowLayoutPanelProducts.Controls
            If TypeOf control Is Panel Then
                control.Margin = New Padding(newMarginValue) ' Set the new margin for each product panel
                control.Size = New Size(300, 400) ' Keep the standard size
            End If
        Next

        ' Force the FlowLayoutPanel to refresh its layout
        flowLayoutPanelProducts.PerformLayout()
    End Sub

    ' Click event handler for product panels
    Private Sub ProductPanel_Click(sender As Object, e As EventArgs)
        ' If the sender is a control inside the Panel (like Label or PictureBox), get the parent Panel
        Dim productPanel As Panel = If(TypeOf sender Is Panel, DirectCast(sender, Panel), DirectCast(DirectCast(sender, Control).Parent, Panel))

        ' Find the product ID label in the clicked product Panel
        Dim lblProductId As Label = productPanel.Controls.OfType(Of Label)().FirstOrDefault(Function(lbl) lbl.Text.StartsWith("ID: "))
        If lblProductId IsNot Nothing Then
            Dim productId As String = lblProductId.Text.Replace("ID: ", "").Trim()

            ' Open the AuctionPage for the clicked product
            Dim auctionPage As New bidproduct(productId)
            'Dim form2 As adminpanel = CType(Application.OpenForms("adminpanel"), adminpanel)
            'form2.foraddproduct.Controls.Clear()
            'form2.showform(auctionPage)
            'viewproduct.Hide()
            'showform(showproductdetail)
            showform(auctionPage)
        End If
    End Sub
    Sub help(productId As String)
        Dim auctionPage As New bidproduct(productId)
        showform(auctionPage)

    End Sub

    ' Method to display forms in a panel
    Sub showform(ByVal panel As Form)
        viewproduct.Controls.Clear()
        panel.TopLevel = False
        panel.Dock = DockStyle.Fill
        viewproduct.Controls.Add(panel)
        panel.Show()
    End Sub

    ' Shared MouseEnter event for both panel and picturebox
    Private Sub SharedHoverEffect_MouseEnter(sender As Object, e As EventArgs)
        Dim control As Control = DirectCast(sender, Control)
        Dim parentPanel As Panel

        If TypeOf control Is PictureBox OrElse TypeOf control Is Label Then
            parentPanel = DirectCast(control.Parent, Panel)
        Else
            parentPanel = DirectCast(control, Panel)
        End If

        ' Apply hover effect
        parentPanel.BackColor = Color.FromArgb(237, 237, 237)
        parentPanel.BorderStyle = BorderStyle.Fixed3D
        parentPanel.Cursor = Cursors.Hand

    End Sub

    ' Shared MouseLeave event for both panel and picturebox
    Private Sub SharedHoverEffect_MouseLeave(sender As Object, e As EventArgs)
        Dim control As Control = DirectCast(sender, Control)
        Dim parentPanel As Panel

        If TypeOf control Is PictureBox OrElse TypeOf control Is Label Then
            parentPanel = DirectCast(control.Parent, Panel)
        Else
            parentPanel = DirectCast(control, Panel)
        End If

        ' Remove hover effect
        parentPanel.BackColor = Color.White
        parentPanel.BorderStyle = BorderStyle.FixedSingle
        parentPanel.Cursor = Cursors.Default
    End Sub

    ' Timer elapsed event to check for new products
    Private Sub productTimer_Elapsed(sender As Object, e As ElapsedEventArgs) Handles productTimer.Elapsed
        ' Call the method to load products into the FlowLayoutPanel on the UI thread
        If flowLayoutPanelProducts.InvokeRequired Then
            flowLayoutPanelProducts.Invoke(New Action(AddressOf LoadProductsIntoFlowLayoutPanel))
        Else
            LoadProductsIntoFlowLayoutPanel()
        End If
    End Sub

    Private resizee As resizehelper

    Public Sub New()
        InitializeComponent()
        resizee = New resizehelper(Me)
        resizee.AddControl(flowLayoutPanelProducts)
        resizee.AddControl(topbar)
        resizee.AddControl(viewproduct)
        resizee.AddControl(updateproductpanel)
        resizee.AddControl(toplabel)
        'resizee.AddControl(addproductbtn)
        'resizee.AddControl(addproductpanel)
        'resizee.AddControl(displayproductpanel)
        'resizee.AddControl(sortsearch)

        AddHandler Me.Resize, AddressOf AddproductWview_Resize
    End Sub
    Private Sub AddproductWview_Resize(ByVal sender As Object, ByVal e As EventArgs)
        resizee.HandleResize(Me)
    End Sub
End Class

