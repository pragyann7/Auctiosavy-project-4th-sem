Imports System.Data.SqlClient
Imports Microsoft.Win32

Public Class Login
    'hotspot
    'Dim connectionstring As String = "Data Source=192.168.140.20;Initial Catalog=UsersDB;User ID=SA;Password=MyStrongPass123;"
    Dim connectionstring As String = "Data Source=192.168.1.69;Initial Catalog=UsersDB;User ID=SA;Password=MyStrongPass123;"
    Private eemail As String
    Public Sub RememberLogin(username As String, role As String)
        ' Store the login state in the registry
        Dim key As RegistryKey = Registry.CurrentUser.CreateSubKey("Software\MyApp")
        key.SetValue("IsLoggedIn", True)          ' Remember that the user is logged in
        key.SetValue("Role", role)                ' Store the role (admin or user)
        key.SetValue("Username", username)        ' Optionally, store the username for reference
        key.Close()
    End Sub


    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        InitializePlaceholder()
        recqueinitializer()
        resetpassinitializer()
        'forgotpasswordpanel.Hide()
        'securityquestionpanel.Hide()
        'Resetpasswordpanel.Hide()
        Timer1.Interval = 1000
        Timer1.Start()
    End Sub
    Private Sub InitializePlaceholder()
        usernametextbox.Text = "Enter username"
        passwordtextbox.Text = "Enter password"
        passwordtextbox.PasswordChar = ""
        usernametextbox.ForeColor = Color.Gray
        passwordtextbox.ForeColor = Color.Gray
        hideit.Visible = True
        Me.ActiveControl = wallpaper
        forgetpassemailtxt.Text = "Enter email"
        forgetpassemailtxt.ForeColor = Color.Gray
        Me.Location = New Point((Screen.PrimaryScreen.WorkingArea.Width - Me.Width) / 2,
                            (Screen.PrimaryScreen.WorkingArea.Height - Me.Height) / 2)
    End Sub
    Private Sub recqueinitializer()
        Q1.Text = "Your answer"
        Q2.Text = "Your answer"
        Q3.Text = "Your answer"
        Q1.ForeColor = Color.Gray
        Q2.ForeColor = Color.Gray
        Q3.ForeColor = Color.Gray
    End Sub

    Private Sub resetpassinitializer()
        newpassword.Text = "New Password"
        renewpassword.Text = "Confirm Password"
        newpassword.ForeColor = Color.Gray
        renewpassword.ForeColor = Color.Gray
        newpassword.PasswordChar = ""
        renewpassword.PasswordChar = ""
    End Sub
    Private Sub usernametextbox_Enter(sender As Object, e As EventArgs) Handles usernametextbox.Enter
        If usernametextbox.Text = "Enter username" Then
            usernametextbox.Text = ""
            usernametextbox.ForeColor = Color.Black
        End If
    End Sub

    Private Sub usernametextbox_Leave(sender As Object, e As EventArgs) Handles usernametextbox.Leave
        If usernametextbox.Text = String.Empty Then
            usernametextbox.Text = "Enter username"
            usernametextbox.ForeColor = Color.Gray
        End If
    End Sub

    Private Sub passwordtextbox_Enter(sender As Object, e As EventArgs) Handles passwordtextbox.Enter
        If passwordtextbox.Text = "Enter password" Then
            passwordtextbox.Text = ""
            passwordtextbox.PasswordChar = "*"
            passwordtextbox.ForeColor = Color.Black
            showpasslogo.Visible = True
        End If
        If passwordtextbox.PasswordChar = "" Then
            showpasslogo.Visible = False
            hidepasslogo.Visible = True
        End If
        hideit.Visible = False
    End Sub

    Private Sub passwordtextbox_Leave(sender As Object, e As EventArgs) Handles passwordtextbox.Leave
        If passwordtextbox.Text = String.Empty Then
            passwordtextbox.Text = "Enter password"
            passwordtextbox.PasswordChar = ""
            passwordtextbox.ForeColor = Color.Gray
        End If
        If passwordtextbox.Text = "Enter password" Then
            hideit.Visible = True
        End If
    End Sub
    Private Sub Q1_Enter(sender As Object, e As EventArgs) Handles Q1.Enter
        If Q1.Text = "Your answer" Then
            Q1.Text = ""
            Q1.ForeColor = Color.Black
        End If
    End Sub

    Private Sub Q1_Leave(sender As Object, e As EventArgs) Handles Q1.Leave
        If Q1.Text = String.Empty Then
            Q1.Text = "Your answer"
            Q1.ForeColor = Color.Gray
        End If
    End Sub
    Private Sub Q2_Enter(sender As Object, e As EventArgs) Handles Q2.Enter
        If Q2.Text = "Your answer" Then
            Q2.Text = ""
            Q2.ForeColor = Color.Black
        End If
    End Sub

    Private Sub Q2_Leave(sender As Object, e As EventArgs) Handles Q2.Leave
        If Q2.Text = String.Empty Then
            Q2.Text = "Your answer"
            Q2.ForeColor = Color.Gray
        End If
    End Sub
    Private Sub Q3_Enter(sender As Object, e As EventArgs) Handles Q3.Enter
        If Q3.Text = "Your answer" Then
            Q3.Text = ""
            Q3.ForeColor = Color.Black
        End If
    End Sub

    Private Sub Q3_Leave(sender As Object, e As EventArgs) Handles Q3.Leave
        If Q3.Text = String.Empty Then
            Q3.Text = "Your answer"
            Q3.ForeColor = Color.Gray
        End If
    End Sub

    Private Sub Form1_Click(sender As Object, e As EventArgs) Handles MyBase.Click
        Me.ActiveControl = Nothing
    End Sub

    Private Sub wallpaper_Click(sender As Object, e As EventArgs) Handles wallpaper.Click
        Me.ActiveControl = Nothing
    End Sub

    Private Sub showpasslogo_Click(sender As Object, e As EventArgs) Handles showpasslogo.Click
        showpasslogo.Visible = False
        hidepasslogo.Visible = True
        passwordtextbox.PasswordChar = ""
    End Sub

    Private Sub hidepasslogo_Click(sender As Object, e As EventArgs) Handles hidepasslogo.Click
        showpasslogo.Visible = True
        hidepasslogo.Visible = False
        passwordtextbox.PasswordChar = "*"
    End Sub

    Private Sub showpasslogo_MouseHover(sender As Object, e As EventArgs) Handles showpasslogo.MouseHover
        showpasslogo.Size = New Size(22, 23)
    End Sub

    Private Sub showpasslogo_MouseLeave(sender As Object, e As EventArgs) Handles showpasslogo.MouseLeave
        showpasslogo.Size = New Size(20, 21)
    End Sub

    Private Sub hidepasslogo_MouseHover(sender As Object, e As EventArgs) Handles hidepasslogo.MouseHover
        hidepasslogo.Size = New Size(22, 23)
    End Sub

    Private Sub hidepasslogo_MouseLeave(sender As Object, e As EventArgs) Handles hidepasslogo.MouseLeave
        hidepasslogo.Size = New Size(20, 21)
    End Sub

    Private Sub loginbtn_Click(sender As Object, e As EventArgs) Handles loginbtn.Click
        Me.ActiveControl = Nothing
        Dim username As String = usernametextbox.Text
        Dim password As String = passwordtextbox.Text
        If usernametextbox.Text = "Enter username" OrElse
             passwordtextbox.Text = "Enter password" Then
            MessageBox.Show("Please fill in all the fields.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        ElseIf AuthenticateUser(username, password) Then
            Dim role As String = GetUserRole(username)

            RememberLogin(username, role)

            If role = "admin" Then
                adminpanel.Show()
            ElseIf role = "user" Then
                userpanel.Show()
            End If

            Me.Hide()
        Else
            MessageBox.Show("Invalid username or password!")
        End If
    End Sub

    Private Function AuthenticateUser(username As String, password As String) As Boolean
        Using conn As New SqlConnection(connectionstring)
            conn.Open()

            Dim query As String = "SELECT COUNT(1) FROM userdetails WHERE username = @username AND password = @password"
            Dim cmd As New SqlCommand(query, conn)
            cmd.Parameters.AddWithValue("@username", username)
            cmd.Parameters.AddWithValue("@password", password)

            Dim count As Integer = Convert.ToInt32(cmd.ExecuteScalar())

            If count > 0 Then
                Return True
            Else
                Return False
            End If
        End Using
    End Function

    Private Function GetUserRole(username As String) As String
        'Dim connectionstring As String = "Data Source=192.168.1.69;Initial Catalog=UsersDB;User ID=SA;Password=MyStrongPass123;"
        Using conn As New SqlConnection(connectionstring)
            conn.Open()

            Dim query As String = "SELECT role FROM userdetails WHERE username = @username"
            Dim cmd As New SqlCommand(query, conn)
            cmd.Parameters.AddWithValue("@username", username)

            Return Convert.ToString(cmd.ExecuteScalar())
        End Using
    End Function


    Private Sub forgetpasslabel_MouseHover(sender As Object, e As EventArgs) Handles forgetpasslabel.MouseHover
        forgetpasslabel.ForeColor = Color.FromArgb(16, 40, 161)
    End Sub

    Private Sub forgetpasslabel_MouseLeave(sender As Object, e As EventArgs) Handles forgetpasslabel.MouseLeave
        forgetpasslabel.ForeColor = Color.FromArgb(69, 128, 230)
    End Sub

    Private Sub signuplabel_MouseHover(sender As Object, e As EventArgs) Handles signuplabel.MouseHover
        signuplabel.ForeColor = Color.FromArgb(16, 40, 161)
    End Sub

    Private Sub signuplabel_MouseLeave(sender As Object, e As EventArgs) Handles signuplabel.MouseLeave
        signuplabel.ForeColor = Color.FromArgb(69, 128, 230)
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Label1.Text = DateTime.Now.ToString("hh:mm:ss tt")
    End Sub

    Private Sub signuplabel_Click(sender As Object, e As EventArgs) Handles signuplabel.Click
        ' Set the form location explicitly to center it (if required)
        Me.Location = New Point((Screen.PrimaryScreen.WorkingArea.Width - Me.Width) / 2,
                            (Screen.PrimaryScreen.WorkingArea.Height - Me.Height) / 2)
        Me.Hide()
        SignUp.Show()
        InitializePlaceholder()
    End Sub

    Private Sub forgetpasslabel_Click(sender As Object, e As EventArgs) Handles forgetpasslabel.Click
        forgotpasswordpanel.Visible = True

    End Sub

    Private Sub backloginbtn_Click(sender As Object, e As EventArgs) Handles backloginbtn.Click
        forgotpasswordpanel.Visible = False
        InitializePlaceholder()
    End Sub

    Private Sub forgetpassemailtxt_Enter(sender As Object, e As EventArgs) Handles forgetpassemailtxt.Enter
        If forgetpassemailtxt.Text = "Enter email" Then
            forgetpassemailtxt.Text = ""
            forgetpassemailtxt.ForeColor = Color.Black
        End If
    End Sub

    Private Sub forgetpassemailtxt_Leave(sender As Object, e As EventArgs) Handles forgetpassemailtxt.Leave
        If forgetpassemailtxt.Text = String.Empty Then
            forgetpassemailtxt.Text = "Enter email"
            forgetpassemailtxt.ForeColor = Color.Gray
        End If
    End Sub

    Private Sub securityquestionpanel_Click(sender As Object, e As EventArgs) Handles securityquestionpanel.Click
        Me.ActiveControl = Nothing
    End Sub

    Private Sub securityQbackbtn_Click(sender As Object, e As EventArgs) Handles securityQbackbtn.Click
        securityquestionpanel.Hide()
        recqueinitializer()
    End Sub

    Public Sub forgotpassbtn_Click(sender As Object, e As EventArgs) Handles forgotpassbtn.Click
        eemail = forgetpassemailtxt.Text
        If forgetpassemailtxt.Text = "Enter email" Then
            MessageBox.Show("Please enter your email before submitting.", "Email Required", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        Else
            Try
                Using connection As New SqlConnection(connectionstring)
                    connection.Open()
                    Dim query As String = "SELECT COUNT(*) FROM userdetails WHERE email = @email"
                    Using command As New SqlCommand(query, connection)
                        command.Parameters.AddWithValue("@email", eemail)
                        Dim count As Integer = CInt(command.ExecuteScalar())
                        If count > 0 Then
                            securityquestionpanel.Show()
                        Else
                            MessageBox.Show("The provided email was not found. Please try again.", "Email Not Found", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                        End If
                    End Using
                End Using
            Catch ex As Exception
                MessageBox.Show("An error occurred: " & ex.Message)
            End Try
        End If
    End Sub

    Private Sub securityQsubmitbtn_Click(sender As Object, e As EventArgs) Handles securityQsubmitbtn.Click
        Dim answer1 As String = Q1.Text
        Dim answer2 As String = Q2.Text
        Dim answer3 As String = Q3.Text

        If Q1.Text = "Your answer" OrElse
            Q2.Text = "Your answer" OrElse
            Q3.Text = "Your answer" Then
            MessageBox.Show("Please fill in all the fields.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            Try
                Using connection As New SqlConnection(connectionstring)
                    connection.Open()
                    Dim query As String = "SELECT COUNT(*) FROM userdetails WHERE email = @email AND security1 = @Answer1 AND security2 = @Answer2 AND security3 = @Answer3"
                    Using command As New SqlCommand(query, connection)
                        command.Parameters.AddWithValue("@email", eemail)
                        command.Parameters.AddWithValue("@Answer1", answer1)
                        command.Parameters.AddWithValue("@Answer2", answer2)
                        command.Parameters.AddWithValue("@Answer3", answer3)
                        Dim count As Integer = CInt(command.ExecuteScalar())
                        If count > 0 Then
                            'MessageBox.Show("Answers are correct. You may proceed to reset your password.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                            Resetpasswordpanel.Show()
                        Else
                            MessageBox.Show("The answers you provided are incorrect. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        End If
                    End Using
                End Using
            Catch ex As Exception
                MessageBox.Show("An error occurred: " & ex.Message)
            End Try
        End If
    End Sub

    Private Sub resetbackbtn_Click(sender As Object, e As EventArgs) Handles resetbackbtn.Click
        Resetpasswordpanel.Hide()
        resetpassinitializer()
    End Sub

    Private Sub Resetpasswordpanel_Click(sender As Object, e As EventArgs) Handles Resetpasswordpanel.Click
        Me.ActiveControl = Nothing
    End Sub

    Private Sub newpassword_Enter(sender As Object, e As EventArgs) Handles newpassword.Enter
        If newpassword.Text = "New Password" Then
            newpassword.Text = ""
            newpassword.PasswordChar = "*"
            newpassword.ForeColor = Color.Black
        End If
    End Sub

    Private Sub newpassword_Leave(sender As Object, e As EventArgs) Handles newpassword.Leave
        If newpassword.Text = String.Empty Then
            newpassword.Text = "New Password"
            newpassword.ForeColor = Color.Gray
            newpassword.PasswordChar = ""
        End If
    End Sub

    Private Sub renewpassword_Enter(sender As Object, e As EventArgs) Handles renewpassword.Enter
        If renewpassword.Text = "Confirm Password" Then
            renewpassword.Text = ""
            renewpassword.PasswordChar = "*"
            renewpassword.ForeColor = Color.Black
        End If
    End Sub

    Private Sub renewpassword_Leave(sender As Object, e As EventArgs) Handles renewpassword.Leave
        If renewpassword.Text = String.Empty Then
            renewpassword.Text = "Confirm Password"
            renewpassword.PasswordChar = ""
            renewpassword.ForeColor = Color.Gray
        End If
    End Sub

    Private Sub resetpasssubmitbtn_Click(sender As Object, e As EventArgs) Handles resetpasssubmitbtn.Click
        Dim newpass As String = newpassword.Text
        Dim confirmpass As String = renewpassword.Text
        If newpassword.Text = "New Password" OrElse
            renewpassword.Text = "Confirm Password" Then
            MessageBox.Show("Please enter and confirm your new password.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        ElseIf newpassword.Text <> renewpassword.Text Then
            MessageBox.Show("Passwords do not match. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            Try
                Using connection As New SqlConnection(connectionstring)
                    connection.Open()
                    Dim query As String = "UPDATE userdetails SET password = @newpassword, last_password_reset = @resetdate WHERE email = @email"
                    Using command As New SqlCommand(query, connection)
                        command.Parameters.AddWithValue("@newpassword", newpass)
                        command.Parameters.AddWithValue("@resetdate", DateTime.Now)
                        command.Parameters.AddWithValue("@email", eemail)
                        Dim datatable As Integer = command.ExecuteNonQuery()
                        If datatable = 1 Then
                            MessageBox.Show("Your password has been reset successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                            forgotpasswordpanel.Hide()
                            securityquestionpanel.Hide()
                            Resetpasswordpanel.Hide()
                            allinitializer()
                        Else
                            MessageBox.Show("Failed to reset the password. Please try again.", "Update Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                        End If
                    End Using
                End Using
            Catch ex As Exception
                MessageBox.Show("An error occurred: " & ex.Message)
            End Try
        End If
    End Sub
    Private Sub ReloadForm()
        Dim newForm As New Login()
        Me.Hide()
        newForm.Show()
    End Sub

    Private Sub allinitializer()
        InitializePlaceholder()
        recqueinitializer()
        resetpassinitializer()
    End Sub

    Private Sub forgotpasspicture_Click(sender As Object, e As EventArgs) Handles forgotpasspicture.Click
        Me.ActiveControl = Nothing
    End Sub

    Private Sub forgotpasswordpanel_Click(sender As Object, e As EventArgs) Handles forgotpasswordpanel.Click
        Me.ActiveControl = Nothing
    End Sub

    Private Sub Login_VisibleChanged(sender As Object, e As EventArgs) Handles MyBase.VisibleChanged
        If Not Me.Visible Then
            allinitializer()
        End If
    End Sub

    Private Sub Login_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = Keys.Enter Then
            loginbtn.PerformClick()
        End If
    End Sub

    Private Sub passwordtextbox_KeyDown(sender As Object, e As KeyEventArgs) Handles passwordtextbox.KeyDown
        If e.KeyCode = Keys.Enter Then
            e.SuppressKeyPress = True
            'submitclick()
        End If
    End Sub
    Private Sub TextBox_KeyDown(sender As Object, e As KeyEventArgs) Handles usernametextbox.KeyDown, passwordtextbox.KeyDown
        If e.KeyCode = Keys.Enter Then
            e.SuppressKeyPress = True  ' Prevent default Enter key behavior (no new line)
            Me.SelectNextControl(CType(sender, Control), True, True, True, True) ' Move focus to the next control
        End If
    End Sub
    Private Sub submitclick()
        loginbtn.PerformClick()
    End Sub

    Private Sub Login_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        Application.Exit()
    End Sub

    Private mouseX As Integer
    Private mouseY As Integer
    Private isDragging As Boolean = False

    ' Mouse Down Event on the docked panel - Start dragging
    Private Sub dragpanel_MouseDown(sender As Object, e As MouseEventArgs) Handles dragpanel.MouseDown
        If e.Button = MouseButtons.Left Then
            isDragging = True
            mouseX = e.X
            mouseY = e.Y
        End If
    End Sub

    ' Mouse Move Event on the docked panel - Continue dragging
    Private Sub dragpanel_MouseMove(sender As Object, e As MouseEventArgs) Handles dragpanel.MouseMove
        If isDragging Then
            ' New position for the form
            Dim newX As Integer = Me.Left + (e.X - mouseX)
            Dim newY As Integer = Me.Top + (e.Y - mouseY)

            ' Get the screen bounds
            Dim screenBounds As Rectangle = Screen.PrimaryScreen.WorkingArea

            ' Allow half of the form to go off-screen on the sides, except the top
            Dim halfWidth As Integer = Me.Width / 2
            Dim halfHeight As Integer = Me.Height / 2

            ' Prevent the form from going above the top boundary (no half off-screen at the top)
            If newY < screenBounds.Top Then newY = screenBounds.Top

            ' Check if the form is going beyond the left or right boundaries, allowing half off-screen
            If newX < screenBounds.Left - halfWidth Then newX = screenBounds.Left - halfWidth
            If newX + Me.Width > screenBounds.Right + halfWidth Then newX = screenBounds.Right + halfWidth - Me.Width

            ' Check if the form's bottom goes beyond the screen, allowing half off-screen at the bottom
            If newY + Me.Height > screenBounds.Bottom + halfHeight Then newY = screenBounds.Bottom + halfHeight - Me.Height

            ' Set the new location of the form
            Me.Left = newX
            Me.Top = newY
        End If
    End Sub

    ' Mouse Up Event on the docked panel - Stop dragging
    Private Sub dragpanel_MouseUp(sender As Object, e As MouseEventArgs) Handles dragpanel.MouseUp
        isDragging = False
    End Sub



    Private Sub closebtn_Click(sender As Object, e As EventArgs) Handles closebtn.Click
        Me.Close()
    End Sub

    Private Sub closebtn_MouseHover(sender As Object, e As EventArgs) Handles minimizebtn.MouseHover, maximizebtn.MouseHover, closebtn.MouseHover
        closebtn.BackgroundImage = My.Resources.close
        minimizebtn.BackgroundImage = My.Resources.minimize
    End Sub

    Private Sub closebtn_MouseLeave(sender As Object, e As EventArgs) Handles minimizebtn.MouseLeave, maximizebtn.MouseLeave, closebtn.MouseLeave
        closebtn.BackgroundImage = My.Resources.closeplain
        minimizebtn.BackgroundImage = My.Resources.minimizeplain
    End Sub

    Private Sub minimizebtn_Click(sender As Object, e As EventArgs) Handles minimizebtn.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub
End Class
