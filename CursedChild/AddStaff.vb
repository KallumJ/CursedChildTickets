Public Class AddStaff

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        'Declare variables
        Dim userFile As String = Application.StartupPath & "/users.txt"

        'Validation

        'Double keying on password
        If txtPassword.Text <> txtConfirmPassword.Text Then
            MsgBox("The two passwords entered must match")
            Exit Sub
        End If

        'Open the file
        FileOpen(1, userFile, OpenMode.Append)

        'Write the record to the file as a variable length record
        PrintLine(1, txtStaffID.Text & "*" & txtUsername.Text & "*" & txtPassword.Text & "*")

        'Close the file
        FileClose(1)

        'Output success message
        MsgBox("User successfully added")

        'Update the staff ID
        updateStaffID()

        'Clear the text boxes
        txtUsername.Text = ""
        txtPassword.Text = ""
        txtConfirmPassword.Text = ""
    End Sub

    Private Sub updateStaffID()
        'Declare variables
        Dim userFile As String = Application.StartupPath & "/users.txt"
        Dim record As String
        Dim fields() As String
        Dim id As String
        Dim staffID As Integer

        'Check the file exists
        If Dir(userFile) <> "" Then
            'Open the file
            FileOpen(1, userFile, OpenMode.Input)

            'Loop through all the records
            Do While Not EOF(1)
                'Read in a record
                record = LineInput(1)

                fields = Split(record, "*")

                id = fields(0)

            Loop

            'Close the file
            FileClose(1)

        End If

        'Evaluate ID
        staffID = Val(id) + 1

        'Display staffID
        txtStaffID.Text = staffID

    End Sub

    Private Sub AddStaff_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        updateStaffID()
    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        'Return to View Staff form
        ViewStaff.Show()
        Me.Close()
    End Sub
End Class