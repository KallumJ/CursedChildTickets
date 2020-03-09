Public Class StaffLogin

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click

        'Declare variables
        Dim usersFile As String = Application.StartupPath & "/users.dat"
        Dim userFound As Boolean = False
        Dim numberOfRecords As Integer
        Dim recordPos As Integer
        Dim username As String
        Dim password As String

        'Open the file
        FileOpen(1, usersFile, OpenMode.Random,,, Len(userRecord))

        'Determine number of records
        numberOfRecords = LOF(1) / Len(userRecord)

        'Read in the records
        For recordPos = 1 To numberOfRecords
            FileGet(1, userRecord, recordPos)

            'Shorten the fields
            username = userRecord.username
            Do While Microsoft.VisualBasic.Right(username, 1) = " "
                username = Mid(username, 1, Len(username) - 1)
            Loop

            password = userRecord.password
            Do While Microsoft.VisualBasic.Right(password, 1) = " "
                password = Mid(password, 1, Len(password) - 1)
            Loop

            'Check entered username and password match the record
            If txtUsername.Text = username And txtPassword.Text = password And userRecord.staffID > 0 Then
                userFound = True
            End If
        Next

        'Close the file
        FileClose(1)

        'If no match is found then
        If userFound = False Then
            'Give error message
            MsgBox("Login failed, incorrect username or password, please try again!", MsgBoxStyle.Critical)
            'Clear the password entry
            txtPassword.Text = ""
        Else
            StaffArea.Show()
            Me.Close()
        End If


    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        'Return to main menu
        MainMenu.Show()
        Me.Close()
    End Sub

    'Login on enter key
    Private Sub txtPassword_KeyDown(sender As Object, e As KeyEventArgs) Handles txtPassword.KeyDown
        If e.KeyCode = Keys.Enter Then
            btnLogin_Click(Me, e)
        End If
    End Sub

End Class