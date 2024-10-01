Imports System.Data.SqlClient
Imports System.IO
Imports System.Timers

Public Class AddproductWview
    Dim connectionString As String = "Data Source=192.168.1.69;Initial Catalog=UsersDB;User ID=SA;Password=MyStrongPass123;"
    Private WithEvents productTimer As New System.Timers.Timer(5000)
    Private products As New List(Of Product)()

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadProductsIntoFlowLayoutPanel()
        LoadCategories()
        LoadSortingOptions()
    End Sub

    Private Sub LoadCategories()
        Dim categories As String() = {"All", "Electronics", "Furniture", "Clothing", "Toys"}
        categorysearch.Items.AddRange(categories)
        categorysearch.SelectedIndex = 0 ' Default to "All"
    End Sub

    Private Sub LoadSortingOptions()
        sortsearch.Items.AddRange(New String() {"Name", "Price: Low to High", "Price: High to Low"})
        sortsearch.SelectedIndex = 0 ' Default sort by Name
    End Sub

    Private Sub LoadProductsIntoFlowLayoutPanel(Optional selectedCategory As String = "All", Optional searchTerm As String = "", Optional sortBy As String = "Name")
        Dim query As String = "SELECT item_id, item_name, starting_price, item_photo_path, category FROM AuctionItems"

        If selectedCategory <> "All" Then
            query &= " WHERE category = @selectedCategory"
        End If

        Using conn As New SqlConnection(connectionString)
            conn.Open()
            Using cmd As New SqlCommand(query, conn)
                If selectedCategory <> "All" Then
                    cmd.Parameters.AddWithValue("@selectedCategory", selectedCategory)
                End If

                Using reader As SqlDataReader = cmd.ExecuteReader()
                    flowLayoutPanelProducts.Controls.Clear()
                    products.Clear()

                    While reader.Read()
                        Dim productId As String = reader("item_id").ToString()
                        Dim productName As String = reader("item_name").ToString()
                        Dim price As Decimal = reader("starting_price")
                        Dim category As String = reader("category").ToString()
                        Dim productPhoto As String = If(IsDBNull(reader("item_photo_path")), Nothing, reader("item_photo_path").ToString())

                        products.Add(New Product(productId, productName, price, productPhoto, category))
                    End While
                End Using
            End Using
        End Using

        DisplayProducts(searchTerm, sortBy)
    End Sub

    Private Sub DisplayProducts(searchTerm As String, sortBy As String)
        Dim filteredProducts = products.Where(Function(p) p.Name.ToLower().Contains(searchTerm.ToLower()))

        Select Case sortBy
            Case "Price: Low to High"
                filteredProducts = filteredProducts.OrderBy(Function(p) p.Price)
            Case "Price: High to Low"
                filteredProducts = filteredProducts.OrderByDescending(Function(p) p.Price)
            Case Else
                filteredProducts = filteredProducts.OrderBy(Function(p) p.Name)
        End Select

        For Each product As Product In filteredProducts
            Dim productPanel As New Panel() With {
                .Size = New Size(300, 400),
                .BorderStyle = BorderStyle.FixedSingle,
                .Margin = New Padding(10)
            }

            ' Add hover effect to the panel
            AddHandler productPanel.MouseEnter, AddressOf SharedHoverEffect_MouseEnter
            AddHandler productPanel.MouseLeave, AddressOf SharedHoverEffect_MouseLeave

            Dim picProductPhoto As New PictureBox() With {
                .Size = New Size(300, 300),
                .SizeMode = PictureBoxSizeMode.StretchImage
            }
            AddHandler picProductPhoto.MouseEnter, AddressOf SharedHoverEffect_MouseEnter
            AddHandler picProductPhoto.MouseLeave, AddressOf SharedHoverEffect_MouseLeave

            ' Load image from the path
            If Not String.IsNullOrEmpty(product.Photo) Then
                picProductPhoto.Image = Image.FromFile(product.Photo) ' Assuming the photo path is valid
            Else
                picProductPhoto.Image = My.Resources.nophoto ' Placeholder image
            End If

            Dim lblProductName As New Label() With {
                .Text = product.Name,
                .Font = New Font("Arial", 12, FontStyle.Bold),
                .AutoSize = True,
                .Location = New Point(10, 310)
            }
            AddHandler lblProductName.MouseEnter, AddressOf SharedHoverEffect_MouseEnter
            AddHandler lblProductName.MouseLeave, AddressOf SharedHoverEffect_MouseLeave

            Dim lblProductPrice As New Label() With {
                .Text = "Price: $" & product.Price.ToString("F2"),
                .Font = New Font("Arial", 12, FontStyle.Bold),
                .AutoSize = True,
                .Location = New Point(10, 340)
            }
            AddHandler lblProductPrice.MouseEnter, AddressOf SharedHoverEffect_MouseEnter
            AddHandler lblProductPrice.MouseLeave, AddressOf SharedHoverEffect_MouseLeave

            productPanel.Controls.Add(picProductPhoto)
            productPanel.Controls.Add(lblProductName)
            productPanel.Controls.Add(lblProductPrice)
            flowLayoutPanelProducts.Controls.Add(productPanel)
        Next
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

    Private resizee As resizehelper

    Public Sub New()
        InitializeComponent()
        resizee = New resizehelper(Me)
        resizee.AddControl(magnifier)
        resizee.AddControl(flowLayoutPanelProducts)
        resizee.AddControl(searchbar)
        resizee.AddControl(categorysearch)
        resizee.AddControl(searchbox)
        resizee.AddControl(addproductbtn)
        resizee.AddControl(addproductpanel)
        resizee.AddControl(displayproductpanel)
        resizee.AddControl(sortsearch)

        AddHandler Me.Resize, AddressOf AddproductWview_Resize
    End Sub

    Private Sub AddproductWview_Resize(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
        resizee.HandleResize(Me)
    End Sub

    ' Timer elapsed event to check for new products
    Private Sub productTimer_Elapsed(sender As Object, e As ElapsedEventArgs) Handles productTimer.Elapsed
        ' Call the method to load only new products without clearing the panel
        If flowLayoutPanelProducts.InvokeRequired Then
            flowLayoutPanelProducts.Invoke(New Action(Sub() LoadProductsIntoFlowLayoutPanel(categorysearch.SelectedItem.ToString())))
        Else
            LoadProductsIntoFlowLayoutPanel(categorysearch.SelectedItem.ToString())
        End If
    End Sub

    Private Sub searchbox_TextChanged(sender As Object, e As EventArgs) Handles searchbox.TextChanged
        Dim selectedCategory As String = If(categorysearch.SelectedItem?.ToString(), "All") ' Use "All" if nothing is selected
        LoadProductsIntoFlowLayoutPanel(selectedCategory, searchbox.Text, sortsearch.SelectedItem?.ToString())
    End Sub

    Private Sub categorysearch_SelectedIndexChanged(sender As Object, e As EventArgs) Handles categorysearch.SelectedIndexChanged
        Dim selectedCategory As String = If(categorysearch.SelectedItem?.ToString(), "All")
        LoadProductsIntoFlowLayoutPanel(selectedCategory, searchbox.Text, sortsearch.SelectedItem?.ToString())
    End Sub

    Private Sub sortsearch_SelectedIndexChanged(sender As Object, e As EventArgs) Handles sortsearch.SelectedIndexChanged
        Dim selectedCategory As String = If(categorysearch.SelectedItem?.ToString(), "All")
        LoadProductsIntoFlowLayoutPanel(selectedCategory, searchbox.Text, sortsearch.SelectedItem?.ToString())
    End Sub

    Private Sub addproductbtn_Click(sender As Object, e As EventArgs) Handles addproductbtn.Click
        displayproductpanel.Visible = False
        showform(addproduct)
    End Sub
    ' Method to display forms in a panel
    Sub showform(ByVal panel As Form)
        addproductpanel.Controls.Clear()
        panel.TopLevel = False
        panel.Dock = DockStyle.Fill
        addproductpanel.Controls.Add(panel)
        panel.Show()
    End Sub
End Class

Public Class Product
    Public Property Id As String
    Public Property Name As String
    Public Property Price As Decimal
    Public Property Photo As String ' Change from Byte() to String
    Public Property Category As String

    Public Sub New(id As String, name As String, price As Decimal, photo As String, category As String)
        Me.Id = id
        Me.Name = name
        Me.Price = price
        Me.Photo = photo
        Me.Category = category
    End Sub
End Class
