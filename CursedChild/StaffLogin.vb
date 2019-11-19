Public Class StaffLogin

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click

        'Declare variables
        Dim numOfRecords As Integer
        Dim usersFile As String = Application.StartupPath & "/users.dat"
        Dim userFound As Boolean = False
        Dim recordPos As Integer
        Dim username As String
        Dim password As String

        'Open the users file00
        FileOpen(1, usersFile, OpenMode.Random,,, Len(userRecord))

        'Calculate number of records
        numOfRecords = LOF(1) / Len(userRecord)


        For recordPos = 1 To numOfRecords
            'Read the record
            FileGet(1, userRecord, recordPos)

            'Read the username
            username = userRecord.username
            Do While Microsoft.VisualBasic.Right(username, 1) = " "
                username = Mid(username, 1, Len(username) - 1)
            Loop

            'Read the password
            password = userRecord.password
            Do While Microsoft.VisualBasic.Right(password, 1) = " "
                password = Mid(password, 1, Len(password) - 1)
            Loop

            'Check entered username and password match the record
            If txtUsername.Text = username And txtPassword.Text = password Then
                'If they do, login
                FileClose(1)
                userFound = True
                StaffArea.Show()
                Me.Close()
            End If


        Next recordPos

        'If no match is found then
        If userFound = False Then
            'Give error message
            MsgBox("Login failed, incorrect username or password, please try again!", MsgBoxStyle.Critical)
            'Clear the password entry
            txtPassword.Text = ""
        End If

        'Close the file
        FileClose(1)
    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        'Return to main menu
        MainMenu.Show()
        Me.Close()
    End Sub

End Class