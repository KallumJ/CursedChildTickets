Public Class StaffLogin

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click

        'Declare variables
        Dim usersFile As String = Application.StartupPath & "/users.txt"
        Dim userFound As Boolean = False
        Dim record As String
        Dim fields() as String

        'Open the users file
        If Dir(usersFile) <> "" Then

            FileOpen(1, usersFile, OpenMode.Input)

            Do While Not EOF(1)
                'Read the record
                record = LineInput(1)

                'Split the record
                fields = Split(record, "*")

                'Check entered username and password match the record
                If txtUsername.Text = fields(1) And txtPassword.Text = fields(2) Then
                    'If they do, login
                    userFound = True
                    StaffArea.Show()
                    Me.Close()
                End If

            Loop
        End If

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

    'Login on enter key
    Private Sub txtPassword_KeyDown(sender As Object, e As KeyEventArgs) Handles txtPassword.KeyDown
        If e.KeyCode = Keys.Enter Then
            btnLogin_Click(Me, e)
        End If
    End Sub

    Private Sub StaffLogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class