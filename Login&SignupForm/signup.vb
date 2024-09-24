Imports System.Data.SqlClient
Imports System.Windows.Forms.VisualStyles.VisualStyleElement
Imports System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel
Public Class SignUp
    Dim connectionstring As String = "Data Source=192.168.1.69;Initial Catalog=UsersDB;User ID=SA;Password=MyStrongPass123;"
    Dim switchstate As Boolean = False
    Dim evalid As Boolean = True
    Dim uvalid As Boolean = True
    Dim passvalid As Boolean = False
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Initializeplaceholder()
        recqueinitializer()
        detailsubmit.Enabled = False
        countrycodeoption.Items.AddRange(New String() {
            "+1 - United States",
            "+44 - United Kingdom",
            "+91 - India",
            "+61 - Australia",
            "+81 - Japan",
            "+49 - Germany",
            "+33 - France",
            "+977 - Nepal",
            "+86 - China",
            "+39 - Italy",
            "+7 - Russia",
            "+52 - Mexico",
            "+55 - Brazil",
            "+27 - South Africa",
            "+34 - Spain",
            "+64 - New Zealand",
            "+65 - Singapore",
            "+62 - Indonesia",
            "+60 - Malaysia",
            "+66 - Thailand",
            "+971 - United Arab Emirates",
            "+82 - South Korea",
            "+92 - Pakistan",
            "+94 - Sri Lanka",
            "+63 - Philippines",
            "+20 - Egypt",
            "+234 - Nigeria",
            "+54 - Argentina",
            "+56 - Chile",
            "+57 - Colombia",
            "+51 - Peru",
            "+58 - Venezuela",
            "+90 - Turkey",
            "+966 - Saudi Arabia",
            "+98 - Iran",
            "+880 - Bangladesh",
            "+84 - Vietnam",
            "+972 - Israel",
            "+212 - Morocco",
            "+254 - Kenya",
            "+233 - Ghana",
            "+256 - Uganda",
            "+255 - Tanzania"
        })
        countrycodeoption.DropDownStyle = ComboBoxStyle.DropDownList
    End Sub

    Public Sub Initializeplaceholder()
        nametxt.Text = "Enter name"
        contacttxt.Text = "Contact no"
        emailtxt.Text = "Enter email"
        usernametxt.Text = "Enter username"
        passwordtxt.Text = "Enter password"
        passwordtxt.PasswordChar = ""
        nametxt.ForeColor = Color.Gray
        contacttxt.ForeColor = Color.Gray
        emailtxt.ForeColor = Color.Gray
        usernametxt.ForeColor = Color.Gray
        passwordtxt.ForeColor = Color.Gray
        termNconditionCheck.Checked = False
        Me.ActiveControl = withlight
    End Sub

    Private Sub switch_Click(sender As Object, e As EventArgs) Handles switch.Click
        If switchstate = False Then
            switch.BackgroundImage = My.Resources.switch_on
            withlight.BringToFront()
            switch.BringToFront()
            switchstate = True
        ElseIf switchstate = True Then
            switch.BackgroundImage = My.Resources.switch_off
            nolight.BringToFront()
            switch.BringToFront()
            switchstate = False
        End If
        switch.BackgroundImageLayout = ImageLayout.Stretch
        countrycodeoption.BringToFront()
        contacttxt.BringToFront()
        termsandconditions.BringToFront()
        recoveryqueriespanel.BringToFront()
    End Sub

    Private Sub termsandconditions_MouseHover(sender As Object, e As EventArgs) Handles termsandconditions.MouseHover
        termsandconditions.ForeColor = Color.Blue
    End Sub

    Private Sub termsandconditions_MouseLeave(sender As Object, e As EventArgs) Handles termsandconditions.MouseLeave
        termsandconditions.ForeColor = Color.RoyalBlue
    End Sub

    Private Sub login_MouseHover(sender As Object, e As EventArgs) Handles loginlabel.MouseHover
        loginlabel.ForeColor = Color.Blue
    End Sub

    Private Sub login_MouseLeave(sender As Object, e As EventArgs) Handles loginlabel.MouseLeave
        loginlabel.ForeColor = Color.RoyalBlue
    End Sub

    Private Sub Form1_Click(sender As Object, e As EventArgs) Handles MyBase.Click
        Me.ActiveControl = Nothing
    End Sub

    Private Sub nametxt_Enter(sender As Object, e As EventArgs) Handles nametxt.Enter
        If nametxt.Text = "Enter name" Then
            nametxt.Text = ""
            nametxt.ForeColor = Color.Black
        End If
        namelbl.Show()

    End Sub

    Private Sub nametxt_Leave(sender As Object, e As EventArgs) Handles nametxt.Leave
        If nametxt.Text = String.Empty Then
            nametxt.Text = "Enter name"
            nametxt.ForeColor = Color.Gray
        End If
        namelbl.Hide()
    End Sub

    Private Sub contacttxt_Enter(sender As Object, e As EventArgs) Handles contacttxt.Enter
        If contacttxt.Text = "Contact no" Then
            contacttxt.Text = ""
            contacttxt.ForeColor = Color.Black
        End If
        contactlbl.Show()
    End Sub

    Private Sub contacttxt_Leave(sender As Object, e As EventArgs) Handles contacttxt.Leave
        If contacttxt.Text = String.Empty Then
            contacttxt.Text = "Contact no"
            contacttxt.ForeColor = Color.Gray
        End If
        contactlbl.Hide()
    End Sub

    Private Sub emailtxt_Enter(sender As Object, e As EventArgs) Handles emailtxt.Enter
        If emailtxt.Text = "Enter email" Then
            emailtxt.Text = ""
            emailtxt.ForeColor = Color.Black
        End If
        emaillbl.Show()
    End Sub

    Private Sub emailtxt_Leave(sender As Object, e As EventArgs) Handles emailtxt.Leave
        Dim email As String = emailtxt.Text
        If emailtxt.Text = String.Empty Then
            emailtxt.Text = "Enter email"
            emailasterick.Visible = False
            emailerrorlbl.Visible = False
            emailtxt.ForeColor = Color.Gray
        ElseIf emailtxt.Text.Contains(" ") Then
            emailasterick.Visible = True
            emailerrorlbl.Visible = True
            emailerrorlbl.Text = "Email cannot contain spaces."
        ElseIf IsEmailExists(email) Then
            emailasterick.Visible = True
            emailerrorlbl.Visible = True
            emailerrorlbl.Text = "This email is already in use."
            termNconditionCheck.Checked = False
        Else
            emailerrorlbl.Visible = False
            emailasterick.Visible = False
        End If
        emaillbl.Hide()
    End Sub
    Public Function IsEmailExists(email As String) As Boolean
        Using connection As New SqlConnection(connectionstring)
            Dim query As String = "SELECT COUNT(*) FROM userdetails WHERE email = @Email"
            Using command As New SqlCommand(query, connection)
                command.Parameters.AddWithValue("@Email", email)

                connection.Open()
                Dim count As Integer = Convert.ToInt32(command.ExecuteScalar())
                evalid = (count > 0) ' If count > 0, either the username or email exists
            End Using
        End Using

        Return evalid
    End Function

    Private Sub usernametxt_Enter(sender As Object, e As EventArgs) Handles usernametxt.Enter
        If usernametxt.Text = "Enter username" Then
            usernametxt.Text = ""
            usernametxt.ForeColor = Color.Black
        End If
        usernamelbl.Show()
    End Sub

    Private Sub usernametxt_Leave(sender As Object, e As EventArgs) Handles usernametxt.Leave
        Dim username As String = usernametxt.Text
        If usernametxt.Text = String.Empty Then
            usernametxt.Text = "Enter username"
            usernameerror.Visible = False
            userasterick.Visible = False
            usernametxt.ForeColor = Color.Gray
        ElseIf usernametxt.Text.Contains(" ") Then
            usernameerror.Visible = True
            userasterick.Visible = True
            usernameerror.Text = "Username cannot contain spaces"
        ElseIf IsUsernameExists(username) Then
            usernameerror.Visible = True
            userasterick.Visible = True
            usernameerror.Text = "This username is already taken."
            termNconditionCheck.Checked = False
        Else
            userasterick.Visible = False
            usernameerror.Visible = False
        End If
        usernamelbl.Hide()
    End Sub

    Public Function IsUsernameExists(username As String) As Boolean
        Using connection As New SqlConnection(connectionstring)
            Dim query As String = "SELECT COUNT(*) FROM userdetails WHERE username = @username"
            Using command As New SqlCommand(query, connection)
                command.Parameters.AddWithValue("@username", username)

                connection.Open()
                Dim count As Integer = Convert.ToInt32(command.ExecuteScalar())
                uvalid = (count > 0) ' If count > 0, either the username or email exists
            End Using
        End Using

        Return uvalid
    End Function

    Private Sub passwordtxt_Enter(sender As Object, e As EventArgs) Handles passwordtxt.Enter
        If passwordtxt.Text = "Enter password" Then
            passwordtxt.PasswordChar = "*"
            passwordtxt.Text = ""
            passwordtxt.ForeColor = Color.Black
        End If
        passwordlbl.Show()
    End Sub

    Private Sub passwordtxt_Leave(sender As Object, e As EventArgs) Handles passwordtxt.Leave
        If passwordtxt.Text = String.Empty Then
            passwordtxt.Text = "Enter password"
            passwordtxt.PasswordChar = ""
            passwordtxt.ForeColor = Color.Gray
        ElseIf passwordtxt.Text.Contains(" ") Then
            passworderror.Visible = True
            passasterick.Visible = True
            termNconditionCheck.Checked = False
            passvalid = False
        Else
            passworderror.Visible = False
            passasterick.Visible = False
            passvalid = True
        End If
        If passwordtxt.Text = "Enter password" Then
            passworderror.Visible = False
            passasterick.Visible = False
        End If
        passwordlbl.Hide()
    End Sub

    Private Sub detailsubmit_Click(sender As Object, e As EventArgs) Handles detailsubmit.Click
        Dim email As String = emailtxt.Text
        If nametxt.Text = "Enter name" OrElse
   contacttxt.Text = "Contact no" OrElse
   emailtxt.Text = "Enter email" OrElse
   usernametxt.Text = "Enter username" OrElse
   passwordtxt.Text = "Enter password" Then
            MessageBox.Show("Please fill in all the fields.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        ElseIf IsValidEmail(email) Then
            recoveryqueriespanel.Visible = True
        Else
            MessageBox.Show("Invalid Email")
            recoveryqueriespanel.Visible = False
        End If
    End Sub
    Private Function IsValidEmail(email As String) As Boolean
        Dim emailPattern As String = "^[^@\s]+@[^@\s]+\.[^@\s]+$"
        Dim regex As New System.Text.RegularExpressions.Regex(emailPattern)
        Return regex.IsMatch(email)
    End Function


    Private Sub recqueinitializer()
        Q1.Text = "Your answer"
        Q2.Text = "Your answer"
        Q3.Text = "Your answer"
        Q1.ForeColor = Color.Gray
        Q2.ForeColor = Color.Gray
        Q3.ForeColor = Color.Gray
    End Sub

    Private Sub backbtn_Click(sender As Object, e As EventArgs) Handles backsignupbtn.Click
        recoveryqueriespanel.Hide()
        recqueinitializer()
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

    Private Sub recoveryqueriespanel_Click(sender As Object, e As EventArgs) Handles recoveryqueriespanel.Click
        Me.ActiveControl = Nothing
    End Sub

    Private Sub loginlabel_Click(sender As Object, e As EventArgs) Handles loginlabel.Click
        ' Set the form location explicitly to center it (if required)
        Me.Location = New Point((Screen.PrimaryScreen.WorkingArea.Width - Me.Width) / 2,
                            (Screen.PrimaryScreen.WorkingArea.Height - Me.Height) / 2)
        Me.Hide()
        Login.Show()
        Initializeplaceholder()
        recqueinitializer()
    End Sub

    Private Sub recquesubmitbtn_Click(sender As Object, e As EventArgs) Handles recquesubmitbtn.Click
        If Q1.Text = "Your answer" OrElse
           Q2.Text = "Your answer" OrElse
            Q3.Text = "Your answer" Then
            MessageBox.Show("Please fill in all the fields.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            Try
                Using connection As New SqlConnection(connectionstring)
                    connection.Open()
                    Dim query As String = "INSERT INTO userdetails (name, contact, email, username, password, security1, security2, security3) values (@name, @contact, @email, @username, @password , @security1, @security2, @security3)"
                    Using command As New SqlCommand(query, connection)
                        command.Parameters.AddWithValue("@name", nametxt.Text)
                        command.Parameters.AddWithValue("@contact", contacttxt.Text)
                        command.Parameters.AddWithValue("@email", emailtxt.Text)
                        command.Parameters.AddWithValue("@username", usernametxt.Text)
                        command.Parameters.AddWithValue("@password", passwordtxt.Text)
                        command.Parameters.AddWithValue("@security1", Q1.Text)
                        command.Parameters.AddWithValue("@security2", Q2.Text)
                        command.Parameters.AddWithValue("security3", Q3.Text)
                        Dim rowsaffected As Integer = command.ExecuteNonQuery()
                        If rowsaffected > 0 Then
                            MessageBox.Show("User registered successfully!")
                            Initializeplaceholder()
                            recqueinitializer()
                            recoveryqueriespanel.Hide()
                            Me.Hide()
                            Login.Show()
                        Else
                            MessageBox.Show("Registration Failed. please try again.")
                            'Me.Hide()
                            'Me.Show()
                        End If
                    End Using
                End Using
            Catch ex As Exception
                MessageBox.Show("An error occured: " & ex.Message)
            End Try
        End If
    End Sub

    Private Sub termNconditionCheck_CheckedChanged(sender As Object, e As EventArgs) Handles termNconditionCheck.CheckedChanged
        If evalid = False And uvalid = False And passvalid = True Then
            detailsubmit.Enabled = True
            'termNconditionCheck.Checked = True
        Else
            detailsubmit.Enabled = False
            termNconditionCheck.Checked = False
        End If
        If termNconditionCheck.Checked = False Then
            detailsubmit.Enabled = False
        End If
    End Sub

    Private Sub nolight_Click(sender As Object, e As EventArgs) Handles nolight.Click
        Me.ActiveControl = Nothing
    End Sub

    Private Sub withlight_Click(sender As Object, e As EventArgs) Handles withlight.Click
        Me.ActiveControl = Nothing
    End Sub
    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles countrycodeoption.SelectedIndexChanged
        If countrycodeoption.SelectedIndex <> -1 Then
            Dim selectedItem As String = countrycodeoption.SelectedItem.ToString()
            Dim countryCode As String = selectedItem.Split(" "c)(0)
            contacttxt.Text = countryCode
            contacttxt.ForeColor = Color.Black
            contacttxt.SelectionStart = contacttxt.Text.Length
            contacttxt.SelectionLength = 0
            countrycodeoption.SelectedIndex = -1
            contacttxt.Focus()
        End If
    End Sub

    Private Sub SignUp_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        Application.Exit()
    End Sub

    Private Sub closebtn_Click(sender As Object, e As EventArgs) Handles closebtn.Click
        Me.Close()
    End Sub

    Private Sub minimizebtn_Click(sender As Object, e As EventArgs) Handles minimizebtn.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub
    Private Sub closebtn_MouseHover(sender As Object, e As EventArgs) Handles minimizebtn.MouseHover, maximizebtn.MouseHover, closebtn.MouseHover
        closebtn.BackgroundImage = My.Resources.close
        minimizebtn.BackgroundImage = My.Resources.minimize
    End Sub

    Private Sub closebtn_MouseLeave(sender As Object, e As EventArgs) Handles minimizebtn.MouseLeave, maximizebtn.MouseLeave, closebtn.MouseLeave
        closebtn.BackgroundImage = My.Resources.closeplain
        minimizebtn.BackgroundImage = My.Resources.minimizeplain
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
End Class
'panel location = 182, 142



