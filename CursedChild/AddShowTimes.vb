Public Class AddShowTimes
    Dim showtimesFile As String = Application.StartupPath & "/showtimes.dat"

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        'Declare variables
        Dim recordPos As Integer
        Dim numOfRecords As Integer

        'Validation

        'Lookup check on HH value
        If cmbTimeHH.Text <> "19" And cmbTimeHH.Text <> "14" Then
            MsgBox("Please enter a valid HH time")
            Exit Sub
        End If

        'Lookup check on MM value
        If cmbTimeMM.Text <> "00" And cmbTimeMM.Text <> "30" Then
            MsgBox("Please enter a valid MM time")
            Exit Sub
        End If

        'Lookup check on part
        If cmbPart.Text <> "1" And cmbPart.Text <> "2" Then
            MsgBox("Please enter a valid part number")
            Exit Sub
        End If

        'Open the file
        FileOpen(1, showtimesFile, OpenMode.Random,,, Len(showtimeRecord))

        'Determine position of next record
        numOfRecords = LOF(1) / Len(showtimeRecord)
        recordPos = numOfRecords + 1

        'Read in entered data
        With showtimeRecord
            .showtimeID = txtShowID.Text
            .showtimeDate = datDate.Value.ToShortDateString
            .showTimeTimeHH = cmbTimeHH.Text
            .showTimeTimeMM = cmbTimeMM.Text
            .part = cmbPart.Text
            .avaliable = True
        End With

        'Write the record
        FilePut(1, showtimeRecord, recordPos)

        'Close the file
        FileClose(1)

        'Output success message
        MsgBox("Showtime successfully added")

        'Update the ID
        updateShowID()

        'Clear the fields
        datDate.Value = Today
        cmbTimeHH.Text = ""
        cmbTimeMM.Text = ""
        cmbPart.Text = ""
    End Sub

    Private Sub updateShowID()
        Dim recordPos As Integer
        Dim numOfRecords As Integer

        'Open the file
        FileOpen(1, showtimesFile, OpenMode.Random,,, Len(showtimeRecord))

        'Determine record position
        numOfRecords = LOF(1) / Len(showtimeRecord)
        FileGet(1, showtimeRecord, numOfRecords)
        recordPos = showtimeRecord.showtimeID + 1

        If recordPos < 0 Then
            recordPos = Math.Abs(recordPos) + 1
        End If

        'Display ID
        txtShowID.Text = recordPos

        'Close the file
        FileClose(1)
    End Sub

    Private Sub AddShowTimes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Update ID
        updateShowID()

        'Sets the minimum date to the current date
        datDate.MinDate = System.DateTime.Today
    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        ViewShowTimes.Show()
        Me.Hide()
    End Sub

    Private Sub AddShowTimes_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        Application.Exit()
    End Sub
End Class