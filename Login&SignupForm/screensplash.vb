Imports Microsoft.Win32

Public Class screensplash
    Private Sub screensplash_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Interval = 10
        Timer1.Enabled = True
        Timer2.Interval = 1000
        ProgressBar1.Visible = True
        ProgressBar1.Value = 0
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        ProgressBar1.Value += 2
        loadinglbl.Text = ProgressBar1.Value & "% loading..."

        Select Case ProgressBar1.Value
            Case 10
                modulelbl.Text = "Reading modules"
            Case 20
                modulelbl.Text = "Turning on modules"
            Case 40
                modulelbl.Text = "Starting modules"
            Case 60
                modulelbl.Text = "Loading modules"
            Case 80
                modulelbl.Text = "Modules loading completed"
            Case 100
                Timer1.Enabled = False
                modulelbl.Text = "Loading completed"

                Dim key As RegistryKey = Registry.CurrentUser.OpenSubKey("Software\MyApp")
                If key IsNot Nothing Then
                    Dim isLoggedIn As Boolean = Convert.ToBoolean(key.GetValue("IsLoggedIn", False))
                    Dim role As String = Convert.ToString(key.GetValue("Role", ""))

                    If isLoggedIn Then
                        If role = "admin" Then
                            Dim adminPanel As New adminpanel()
                            adminPanel.Show()
                        ElseIf role = "user" Then
                            Dim userPanel As New userpanel()
                            userPanel.Show()
                        End If
                    Else
                        Dim loginForm As New Login()
                        loginForm.Show()
                    End If

                    key.Close()
                Else
                    Dim loginForm As New Login()
                    loginForm.Show()
                End If

                Me.Hide()
        End Select
    End Sub
End Class
