Public Class AddShowTimes
    Dim showtimesFile As String = Application.StartupPath & "/showtimes.dat"

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        'Declare variables
        Dim recordPos As Integer
        Dim numOfRecords As Integer

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
        recordPos = numOfRecords + 1

        'Display ID
        txtShowID.Text = recordPos

        'Close the file
        FileClose(1)
    End Sub

    Private Sub AddShowTimes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Update ID
        updateShowID()
    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        ViewShowTimes.Show()
        Me.Close()
    End Sub
End Class