Imports Microsoft.Win32

Public Class userindex
    Private Sub navslidebtn_Click(sender As Object, e As EventArgs) Handles navslidebtn.Click
        If menupanel.Width = 271 Then
            ' If expanded, shrink the panel
            menupanel.Width = 77
            homebtn.Text = ""
            browsebtn.Text = ""
            mybidsbtn.Text = ""
            dashboardbtn.Text = ""
            'reportsbtn.Text = ""
            profilename.Hide()
            profilephoto.Hide()
            navslidebtn.Location = New Point(20, navslidebtn.Location.Y)
            homebtn.ImageAlign = ContentAlignment.MiddleCenter
            browsebtn.ImageAlign = ContentAlignment.MiddleCenter
            mybidsbtn.ImageAlign = ContentAlignment.MiddleCenter
            dashboardbtn.ImageAlign = ContentAlignment.MiddleCenter
            navslidebtn.BackgroundImage = My.Resources.menuu
            logoutbtn.Hide()
            settingbtn.Hide()
            forformdisplay.Location = New Point(77, forformdisplay.Location.Y)
        Else
            ' If collapsed, expand the panel
            menupanel.Width = 271
            homebtn.Text = "Home"
            browsebtn.Text = "Browse"
            mybidsbtn.Text = "My Bids"
            dashboardbtn.Text = "Dashboard"
            'reportsbtn.Text = "Extra"
            profilephoto.Show()
            profilename.Show()
            navslidebtn.Location = New Point(220, navslidebtn.Location.Y)
            homebtn.ImageAlign = ContentAlignment.MiddleRight
            browsebtn.ImageAlign = ContentAlignment.MiddleRight
            mybidsbtn.ImageAlign = ContentAlignment.MiddleRight
            dashboardbtn.ImageAlign = ContentAlignment.MiddleRight
            navslidebtn.BackgroundImage = My.Resources.closenav
            logoutbtn.BackgroundImage = My.Resources.logout
            settingbtn.BackgroundImage = My.Resources.settingiso100
            logoutbtn.Show()
            settingbtn.Show()
            forformdisplay.Location = New Point(271, forformdisplay.Location.Y)
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
        Me.Hide() ' Hide the current form (admin panel or user dashboard)
        Me.Location = New Point((Screen.PrimaryScreen.WorkingArea.Width - Me.Width) / 2,
                            (Screen.PrimaryScreen.WorkingArea.Height - Me.Height) / 2)
    End Sub

    Private Sub logoutbtn_Click(sender As Object, e As EventArgs) Handles logoutbtn.Click
        Logout()
    End Sub

    Private Sub userindex_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class