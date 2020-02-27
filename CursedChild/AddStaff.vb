Public Class AddStaff
    Dim userFile As String = Application.StartupPath & "/users.dat"
    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        'Declare variable
        Dim numOfRecords As Integer
        Dim recordPos As Integer


        'Validation

        'Double keying on password
        If txtPassword.Text <> txtConfirmPassword.Text Then
            MsgBox("The two passwords entered must match")
            Exit Sub
        End If

        'Open the file
        FileOpen(1, userFile, OpenMode.Random,,, Len(userRecord))

        'Determine poisition of the next record
        numOfRecords = LOF(1) / Len(userRecord)
        recordPos = numOfRecords + 1

        'Read in the entered data
        With userRecord
            .staffID = txtStaffID.Text
            .username = txtUsername.Text
            .password = txtPassword.Text
        End With

        'Write the record to file
        FilePut(1, userRecord, recordPos)

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
        Dim numOfrecords As Integer
        Dim recordPos As Integer

        'Open the file
        FileOpen(1, userFile, OpenMode.Random,,, Len(userRecord))

        'Determine record position
        numOfrecords = LOF(1) / Len(userRecord)
        recordPos = numOfrecords + 1

        'Display staff ID
        txtStaffID.Text = recordPos

        'Close the file
        FileClose(1)

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