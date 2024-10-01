Imports System.Data.SqlClient
Imports System.IO
Imports Microsoft.Win32

Public Class adminpanel
    Dim isfullscreen As Boolean = False
    Private resizee As resizehelper

    Private Sub adminpanel_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        addproductbtn.PerformClick()
        showprofile()
    End Sub

    Sub showprofile()
        Using connection As New SqlConnection(connectionstring)
            connection.Open()

            Dim query As String = "SELECT name, user_photo FROM userdetails WHERE user_id = 108"

            Using command As New SqlCommand(query, connection)
                Using reader As SqlDataReader = command.ExecuteReader()
                    If reader.Read() Then
                        profilename.Text = reader("name").ToString()

                        ' Fetch and display the user's photo
                        If Not IsDBNull(reader("user_photo")) Then
                            Dim imageData As Byte() = DirectCast(reader("user_photo"), Byte())

                            If imageData.Length > 0 Then
                                ' Convert byte array to image and display it
                                Using ms As New MemoryStream(imageData)
                                    profilephoto.Image = Image.FromStream(ms)
                                    profilephoto.SizeMode = PictureBoxSizeMode.StretchImage
                                End Using
                            Else
                                ' Set a placeholder image if no valid image exists
                                profilephoto.Image = My.Resources.userphoto
                            End If
                        Else
                            ' Set a placeholder image if no photo is found in the database
                            profilephoto.Image = My.Resources.userphoto
                        End If
                    End If
                End Using
            End Using
        End Using
    End Sub



    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles navslidebtn.Click
        If menupanel.Width = 271 Then
            ' If expanded, shrink the panel
            menupanel.Width = 77
            addproductbtn.Text = ""
            manageauctionbtn.Text = ""
            usersbtn.Text = ""
            dashboardbtn.Text = ""
            reportsbtn.Text = ""
            profilename.Hide()
            profilephoto.Hide()
            navslidebtn.Location = New Point(20, navslidebtn.Location.Y)
            addproductbtn.ImageAlign = ContentAlignment.MiddleCenter
            manageauctionbtn.ImageAlign = ContentAlignment.MiddleCenter
            usersbtn.ImageAlign = ContentAlignment.MiddleCenter
            dashboardbtn.ImageAlign = ContentAlignment.MiddleCenter
            navslidebtn.BackgroundImage = My.Resources.menuu
            logoutbtn.Hide()
            settingbtn.Hide()
            foraddproduct.Location = New Point(77, foraddproduct.Location.Y)
        Else
            ' If collapsed, expand the panel
            menupanel.Width = 271
            addproductbtn.Text = "Add Product"
            manageauctionbtn.Text = "Manage Auction"
            usersbtn.Text = "Users"
            dashboardbtn.Text = "Dashboard"
            reportsbtn.Text = "Extra"
            profilephoto.Show()
            profilename.Show()
            navslidebtn.Location = New Point(220, navslidebtn.Location.Y)
            addproductbtn.ImageAlign = ContentAlignment.MiddleRight
            manageauctionbtn.ImageAlign = ContentAlignment.MiddleRight
            usersbtn.ImageAlign = ContentAlignment.MiddleRight
            dashboardbtn.ImageAlign = ContentAlignment.MiddleRight
            navslidebtn.BackgroundImage = My.Resources.closenav
            logoutbtn.BackgroundImage = My.Resources.logout
            settingbtn.BackgroundImage = My.Resources.settingiso100
            logoutbtn.Show()
            settingbtn.Show()
            foraddproduct.Location = New Point(271, foraddproduct.Location.Y)
        End If

    End Sub

    ' Method to display forms in a panel
    Sub showform(ByVal panel As Form)
        foraddproduct.Controls.Clear()
        panel.TopLevel = False
        panel.Dock = DockStyle.Fill
        foraddproduct.Controls.Add(panel)
        panel.Show()
    End Sub

    ' Constructor
    Public Sub New()
        InitializeComponent()
        resizee = New resizehelper(Me)
        resizee.AddControl(foraddproduct)
        resizee.AddControl(menupanel)
        'resizee.AddControl(profilename)
        'resizee.AddControl(profilephoto)
        AddHandler Me.Resize, AddressOf Form1_Resize
    End Sub

    Private Sub Form1_Resize(ByVal sender As Object, ByVal e As EventArgs)
        resizee.HandleResize(Me)
        If Me.WindowState = FormWindowState.Maximized AndAlso Not isfullscreen And menupanel.Width = 271 Then
            menupanel.Width = 271
            foraddproduct.Location = New Point(271, foraddproduct.Location.Y)
            isfullscreen = True
        ElseIf Me.WindowState <> FormWindowState.Maximized AndAlso isfullscreen And menupanel.Width = 71 Then
            menupanel.Width = 71
            isfullscreen = False
        End If
    End Sub

    ' Handles button clicks and sets the active button
    Private Sub manageauction_Click(sender As Object, e As EventArgs) Handles manageauctionbtn.Click
        SetActiveButton(DirectCast(sender, Button))
        'addproduct.Close()
        'Dim form2 As AddproductWview = CType(Application.OpenForms("AddproductWview"), AddproductWview)
        'foraddproduct.Controls.Clear()
        'AddproductWview.Hide()
        'auctionmanage.Close()
        Dim manageauction As New auctionmanage
        showform(manageauction)
    End Sub

    Private Sub usersbtn_Click(sender As Object, e As EventArgs) Handles usersbtn.Click
        SetActiveButton(DirectCast(sender, Button))
        showform(usersmanage)
    End Sub

    ' Set the active button's back color and reset others
    Private Sub SetActiveButton(activeButton As Button)
        ' Set the active button color
        activeButton.BackColor = Color.FromArgb(60, 110, 90)

        ' Reset other buttons' colors
        If activeButton IsNot addproductbtn Then addproductbtn.BackColor = Color.FromArgb(93, 140, 116)
        If activeButton IsNot usersbtn Then usersbtn.BackColor = Color.FromArgb(93, 140, 116)
        If activeButton IsNot reportsbtn Then reportsbtn.BackColor = Color.FromArgb(93, 140, 116)
        If activeButton IsNot manageauctionbtn Then manageauctionbtn.BackColor = Color.FromArgb(93, 140, 116)
        If activeButton IsNot dashboardbtn Then dashboardbtn.BackColor = Color.FromArgb(93, 140, 116)
    End Sub

    ' This method can be the event handler for the addproductbtn click event
    Private Sub addproductbtn_Click(sender As Object, e As EventArgs) Handles addproductbtn.Click
        SetActiveButton(DirectCast(sender, Button))
        ' Display the AddProduct form when addproductbtn is clicked
        Dim add As New AddproductWview
        showform(add) ' Assuming AddproductWview is the form to show
    End Sub

    Private Sub logoutbtn_Click(sender As Object, e As EventArgs) Handles logoutbtn.Click
        Dim result As DialogResult = MessageBox.Show("Are you sure you want to log out?", "LogOut", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)
        If result = DialogResult.Yes Then
            Logout()
        End If
    End Sub
    Public Sub Logout()
        ' Clear the login state from the registry
        Dim key As RegistryKey = Registry.CurrentUser.OpenSubKey("Software\MyApp", True)
        If key IsNot Nothing Then
            key.DeleteValue("IsLoggedIn", False)
            key.DeleteValue("Role", False)
            key.Close()
        End If
        ' Show the login form after logout
        Login.Show()
        Me.Hide()
    End Sub

    Private Sub adminpanel_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        Application.Exit()
    End Sub

    Private Sub profilephoto_Click(sender As Object, e As EventArgs) Handles profilephoto.Click
        Dim update As adminpanel = CType(Application.OpenForms("adminpanel"), adminpanel)
        update.showform(adminprofile)
        navslidebtn.PerformClick()
    End Sub



    Protected Overrides ReadOnly Property CreateParams() As CreateParams
        Get
            Dim cp As CreateParams = MyBase.CreateParams
            cp.ExStyle = cp.ExStyle Or &H2000000
            Return cp
        End Get
    End Property
End Class