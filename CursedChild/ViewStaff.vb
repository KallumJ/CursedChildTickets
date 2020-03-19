Public Class ViewStaff

    'Declare variables
    Dim userFile As String = Application.StartupPath & "/users.dat"

    Dim recordPos As Integer
    Dim editPass As String

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        'Show the staff area
        StaffArea.Show()
        Me.Hide()
    End Sub

    Private Sub ViewStaff_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Declare variabeles
        Dim numOfRecords As Integer
        Dim listString As String

        'Clear the listbox
        lstStaff.Items.Clear()

        'Listbox title
        lstStaff.Items.Add("StaffID     Username")

        'Open the file
        FileOpen(1, userFile, OpenMode.Random,,, Len(userRecord))

        'Find the number of Records
        numOfRecords = LOF(1) / Len(userRecord)

        'Read in the records
        For recordPos = 1 To numOfRecords

            FileGet(1, userRecord, recordPos)

            With userRecord
                'If user is not deleted then
                If .staffID > 0 Then
                    listString = .staffID
                    listString = listString & "               " & .username
                    lstStaff.Items.Add(listString)
                End If
            End With
        Next

        'Close the file
        FileClose(1)

    End Sub

    Private Sub btnShowAdd_Click(sender As Object, e As EventArgs) Handles btnShowAdd.Click
        'Open the add staff form
        AddStaff.Show()
        Me.Hide()
    End Sub

    Private Sub lstStaff_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstStaff.SelectedIndexChanged
        'Declare variables
        Dim numOfRecordsFound As Integer
        Dim staffString As String
        Dim searchID As Integer

        'Find the selected staff ID
        staffString = lstStaff.Text
        searchID = Val(Microsoft.VisualBasic.Left(staffString, 10))

        'Open the file
        FileOpen(1, userFile, OpenMode.Random,,, Len(userRecord))

        'Read in the record
        recordPos = 1

        Do While Not EOF(1)
            FileGet(1, userRecord, recordPos)

            'If the record matches selected user
            If userRecord.staffID = searchID Then
                numOfRecordsFound = numOfRecordsFound + 1

                With userRecord
                    txtStaffID.Text = userRecord.staffID
                    txtUsername.Text = userRecord.username
                    editPass = userRecord.password
                End With
                'Leave the loop
                Exit Do
            End If

            'Incremement record
            recordPos = recordPos + 1

        Loop

        'If no records are found, output an error
        If numOfRecordsFound = 0 And searchID <> 0 Then
            MsgBox("Customer with ID " & searchID & " could not be found, please contact your system adminstrator")
            FileClose(1)
        End If

        'Close the file
        FileClose(1)

        If searchID = 0 Then
            txtStaffID.Text = ""
            txtUsername.Text = ""
        End If
    End Sub

    Private Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click
        'Read in the record
        With userRecord
            .staffID = txtStaffID.Text
            .username = txtUsername.Text
            .password = editPass
        End With

        'Open the file
        FileOpen(1, userFile, OpenMode.Random,,, Len(userRecord))

        'Write the record to file
        FilePut(1, userRecord, recordPos)

        'Close the file
        FileClose(1)

        'Clear the fields
        txtStaffID.Text = ""
        txtUsername.Text = ""
        editPass = ""

        'Reload the form
        Call ViewStaff_Load(Me, e)
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        'Read in the record and make id negative
        With userRecord
            .staffID = -Val(txtStaffID.Text)
            .username = txtUsername.Text
            .password = editPass
        End With

        'Open the file
        FileOpen(1, userFile, OpenMode.Random,,, Len(userRecord))

        'Write the user record to file
        FilePut(1, userRecord, recordPos)

        'Close the file
        FileClose(1)

        'Clear the fields
        txtStaffID.Text = ""
        txtUsername.Text = ""
        editPass = ""

        'Reload the form
        Call ViewStaff_Load(Me, e)
    End Sub

    Private Sub btnCustSearch_Click(sender As Object, e As EventArgs) Handles btnCustSearch.Click
        'Declare variables
        Dim searchString As String
        Dim listString As String
        Dim numofRecords As Integer
        Dim numOfRecordsFound As Integer
        Dim recordPosition As Integer

        'Read in the query
        searchString = txtStaffSearch.Text

        'Add up to 25 spaces
        If Len(searchString) < 25 Then
            Do While Len(searchString) < 25
                searchString = searchString & " "
            Loop
        End If

        'Set the record position to 1
        recordPosition = 1

        'Open the file
        FileOpen(1, userFile, OpenMode.Random,,, Len(userRecord))

        'Calculate number of records in the file
        numofRecords = LOF(1) / Len(userRecord)
        recordPos = 1

        'Clear the listbox
        lstStaff.Items.Clear()

        'Listbox title
        lstStaff.Items.Add("StaffID     Username")

        'Read in the records
        Do While Not EOF(1)
            FileGet(1, userRecord, recordPosition)

            'If the username matches the search query then
            If userRecord.username = searchString Then

                'Log record found
                numOfRecordsFound = numOfRecordsFound + 1

                With userRecord
                    'If user is not deleted
                    If .staffID > 0 Then
                        listString = .staffID
                        listString = listString & "               " & .username
                        lstStaff.Items.Add(listString)
                    End If
                End With
            End If

            'Increment record position
            recordPosition = recordPosition + 1
        Loop

        'Close the file
        FileClose(1)

        'Output error if user is not found
        If numOfRecordsFound = 0 Then
            MsgBox("User with username " & searchString & " was not found, please try again.")
        End If

    End Sub

    'Default search text
    Private Sub txtStaffSearch_GotFocus(sender As Object, e As EventArgs) Handles txtStaffSearch.GotFocus
        If txtStaffSearch.Text = "Please enter a Username to search" Then
            txtStaffSearch.Text = ""
        End If

    End Sub

    Private Sub txtStaffSearch_LostFocus(sender As Object, e As EventArgs) Handles txtStaffSearch.LostFocus
        If txtStaffSearch.Text = "" Then
            txtStaffSearch.Text = "Please enter a Username to search"
        End If

    End Sub

    Private Sub ViewStaff_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        Application.Exit()
    End Sub
End Class