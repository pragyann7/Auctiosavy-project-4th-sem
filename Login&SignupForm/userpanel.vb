Imports Microsoft.Win32

Public Class userpanel
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Logout()
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

    Private Sub userpanel_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        Application.Exit()
    End Sub
End Class