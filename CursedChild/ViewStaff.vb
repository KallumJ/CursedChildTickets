Imports System.IO
Imports System.Text

Public Class ViewStaff

    'Declare variables
    Dim userFile As String = Application.StartupPath & "/users.txt"
    Dim recordPos As Integer

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        'Show the staff area
        StaffArea.Show()
        Me.Close()
    End Sub

    Private Sub ViewStaff_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Declare variabeles
        Dim record As String
        Dim fields() As String
        Dim listString As String

        'Clear the listbox
        lstStaff.Items.Clear()

        'Listbox title
        lstStaff.Items.Add("StaffID     Username")

        'Open the file
        If Dir(userFile) <> "" Then
            FileOpen(1, userFile, OpenMode.Input)

            'Loop through all the records
            Do While Not EOF(1)
                'Read in a record
                record = LineInput(1)

                'Split the record
                fields = Split(record, "*")

                If Val(fields(0)) > 0 Then
                    listString = fields(0)
                    listString = listString & "               " & fields(1)
                    lstStaff.Items.Add(listString)
                End If

            Loop
        End If

        'Close the file
        FileClose(1)
    End Sub

    Private Sub btnShowAdd_Click(sender As Object, e As EventArgs) Handles btnShowAdd.Click
        'Open the add staff form
        AddStaff.Show()
        Me.Close()
    End Sub

    Private Sub lstStaff_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstStaff.SelectedIndexChanged
        'Declare variables
        Dim numOfRecordsFound As Integer
        Dim staffString As String
        Dim searchID As Integer
        Dim record As String
        Dim fields() As String

        'Find the selected staff ID
        staffString = lstStaff.Text
        searchID = Val(Microsoft.VisualBasic.Left(staffString, 10))

        'Open the file
        FileOpen(1, userFile, OpenMode.Input)

        'Read in the record
        Do While Not EOF(1)
            record = LineInput(1)

            fields = Split(record, "*")

            'If the record being selected is found then
            If fields(0) = searchID Then
                numOfRecordsFound = numOfRecordsFound + 1

                'Populate the textbox
                txtStaffID.Text = fields(0)
                txtUsername.Text = fields(1)
                'Leave the loop
                Exit Do
            End If
        Loop

        'If no records are found, output an error
        If numOfRecordsFound = 0 Then
            MsgBox("Customer with ID " & searchID & " could not be found, please contact your system adminstrator")
            FileClose(1)
        End If

        'Close the file
        FileClose(1)
    End Sub

    Private Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click

    End Sub
End Class