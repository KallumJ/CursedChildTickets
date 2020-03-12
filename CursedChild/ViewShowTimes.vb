Public Class ViewShowTimes

    'Declare variables
    Dim showtimesFile As String = Application.StartupPath & "/showtimes.dat"

    Dim recordPos As Integer

    Private Sub btnShowAdd_Click(sender As Object, e As EventArgs) Handles btnShowAdd.Click
        AddShowTimes.Show()
        Me.Hide()
    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        StaffArea.Show()
        Me.Hide()
    End Sub

    Private Sub ViewShowTimes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Declare variables
        Dim numOfRecords As Integer
        Dim listString As String
        Dim MM As String

        'Clear the listbox
        lstShowtimes.Items.Clear()

        'Listbox title
        lstShowtimes.Items.Add("ShowtimeID      Date                  Time")

        'Open the file
        FileOpen(1, showtimesFile, OpenMode.Random,,, Len(showtimeRecord))

        'Find number of records
        numOfRecords = LOF(1) / Len(showtimeRecord)

        'Read in the records
        For recordPos = 1 To numOfRecords

            FileGet(1, showtimeRecord, recordPos)

            With showtimeRecord
                If .showTimeTimeMM = "0" Then
                    MM = .showTimeTimeMM & "0"
                Else
                    MM = .showTimeTimeMM
                End If

                'If showtime is not deleted then
                If .showtimeID > 0 Then
                    listString = .showtimeID
                    listString = listString & "                       " & .showtimeDate
                    listString = listString & "      " & .showTimeTimeHH & ":" & MM
                    lstShowtimes.Items.Add(listString)
                End If
            End With
        Next

        'Close the file
        FileClose(1)
    End Sub

    Private Sub lstShowtimes_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstShowtimes.SelectedIndexChanged
        'Declare variables
        Dim NumOfRecordsFound As Integer
        Dim showtimeString As String
        Dim searchID As Integer

        'Find the selected Showtime ID
        showtimeString = lstShowtimes.Text
        searchID = Val(Microsoft.VisualBasic.Left(showtimeString, 10))

        'Open the file
        FileOpen(1, showtimesFile, OpenMode.Random,,, Len(showtimeRecord))

        'Read in the records from file
        recordPos = 1

        Do While Not EOF(1)
            FileGet(1, showtimeRecord, recordPos)

            'If the record matches the selected customer
            If showtimeRecord.showtimeID = searchID Then
                NumOfRecordsFound = NumOfRecordsFound + 1

                With showtimeRecord
                    txtShowtimeID.Text = .showtimeID
                    datDate.Value = .showtimeDate
                    cmbTimeHH.Text = .showTimeTimeHH
                    cmbTimeMM.Text = .showTimeTimeMM
                    cmbPart.Text = .part
                    chkAvailable.Checked = .avaliable
                End With
                'Leave the loop
                Exit Do
            End If

            'Increment Record
            recordPos = recordPos + 1
        Loop

        'If no records are found, output an error message
        If NumOfRecordsFound = 0 And searchID <> 0 Then
            MsgBox("Showtime with ID " & searchID & " could not be found, please contact your system adminstrator")
            FileClose(1)
        End If

        'Close the file
        FileClose(1)

        If searchID = 0 Then
            txtShowtimeID.Text = ""
            datDate.Value = Today
            cmbTimeHH.Text = ""
            cmbTimeMM.Text = ""
            cmbPart.Text = ""
            chkAvailable.Checked = True
        End If
    End Sub

    Private Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click
        'Read in fields in record
        With showtimeRecord
            .showtimeID = Val(txtShowtimeID.Text)
            .showtimeDate = datDate.Value
            .showTimeTimeHH = cmbTimeHH.Text
            .showTimeTimeMM = cmbTimeMM.Text
            .part = cmbPart.Text
            .avaliable = chkAvailable.Checked
        End With

        'Open the file
        FileOpen(1, showtimesFile, OpenMode.Random,,, Len(showtimeRecord))

        'Write the record back to the file
        FilePut(1, showtimeRecord, recordPos)

        'Close the file
        FileClose(1)

        'Clear the elements
        txtShowtimeID.Text = ""
        datDate.Value = Today
        cmbTimeHH.Text = ""
        cmbTimeMM.Text = ""
        cmbPart.Text = ""
        chkAvailable.Checked = False

        'Reload the form
        Call ViewShowTimes_Load(Me, e)

    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        'Read in the fileds in the record but make the id negative
        With showtimeRecord
            .showtimeID = -Val(txtShowtimeID.Text)
            .showtimeDate = datDate.Value
            .showTimeTimeHH = cmbTimeHH.Text
            .showTimeTimeMM = cmbTimeMM.Text
            .part = cmbPart.Text
            .avaliable = chkAvailable.Checked
        End With

        'Open the file
        FileOpen(1, showtimesFile, OpenMode.Random,,, Len(showtimeRecord))

        'Write the record back to the file
        FilePut(1, showtimeRecord, recordPos)

        'Close the file
        FileClose(1)

        'Clear the elements
        txtShowtimeID.Text = ""
        datDate.Value = Today
        cmbTimeHH.Text = ""
        cmbTimeMM.Text = ""
        cmbPart.Text = ""
        chkAvailable.Checked = False

        'Reload the form
        Call ViewShowTimes_Load(Me, e)
    End Sub

    Private Sub btnCustSearch_Click(sender As Object, e As EventArgs) Handles btnCustSearch.Click
        'Declare variables
        Dim searchString As String
        Dim listString As String
        Dim numOfRecords As Integer
        Dim numOfRecordsFound As Integer
        Dim showtimeDate As String
        Dim time As String
        Dim recordPosition As Integer
        Dim mm As String

        'Read in the query
        searchString = txtShowSearch.Text
        'Set record position to 1
        recordPosition = 1

        'Open the file
        FileOpen(1, showtimesFile, OpenMode.Random,,, Len(showtimeRecord))

        'Calculate number of records in the file
        numOfRecords = LOF(1) / Len(showtimeRecord)
        recordPos = 1

        'Clear the listbox
        lstShowtimes.Items.Clear()

        'Listbox title
        lstShowtimes.Items.Add("ShowtimeID      Date                  Time")

        'Read in the records

        Do While Not EOF(1)
            FileGet(1, showtimeRecord, recordPosition)

            If showtimeRecord.showtimeID = searchString Then
                numOfRecordsFound = numOfRecordsFound + 1

                With showtimeRecord

                    If .showTimeTimeMM = "0" Then
                        mm = .showTimeTimeMM & "0"
                    Else
                        mm = .showTimeTimeMM
                    End If

                    'If showtime is not deleted then
                    If .showtimeID > 0 Then
                        listString = .showtimeID
                        listString = listString & "                       " & .showtimeDate
                        listString = listString & "      " & .showTimeTimeHH & ":" & mm
                        lstShowtimes.Items.Add(listString)
                    End If
                End With

            End If

            recordPosition = recordPosition + 1
        Loop

        'Close the file
        FileClose(1)

        'Output error if customer is not found
        If numOfRecordsFound = 0 Then
            MsgBox("Showtime with ID " & searchString & " was not found, please try again.")
        End If
    End Sub

    'Default search text
    Private Sub txtShowSearch_GotFocus(sender As Object, e As EventArgs) Handles txtShowSearch.GotFocus
        If txtShowSearch.Text = "Please enter an ID to search" Then
            txtShowSearch.Text = ""
        End If
    End Sub

    Private Sub txtShowSearch_LostFocus(sender As Object, e As EventArgs) Handles txtShowSearch.LostFocus
        If txtShowSearch.Text = "" Then
            txtShowSearch.Text = "Please enter an ID to search"
        End If
    End Sub

    Private Sub ViewShowTimes_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        MainMenu.Close()
    End Sub
End Class