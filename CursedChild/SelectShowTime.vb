Public Class SelectShowTime

    Public showtimeDateString As String
    Public showtimePart As String
    Public showtimeID As Integer
    Public showtimeDate As String
    Dim showtimeFile As String = Application.StartupPath & "/showtimes.dat"

    Private Sub SelectShowTime_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Sets the minimum date to the current date
        calCalendar.MinDate = System.DateTime.Today()
        'Add avaliability for current day
        UpdateList()
    End Sub

    Private Sub calCalendar_DateChanged(sender As Object, e As DateRangeEventArgs) Handles calCalendar.DateChanged
        'Update the list
        UpdateList()
    End Sub

    Private Sub UpdateList()
        'Declare variables
        Dim numOfRecords As Integer
        Dim recordPos As Integer
        Dim selectedDate As String
        Dim timeHH As Integer
        Dim timeMM As String
        Dim time As String
        Dim part As Integer
        Dim listString As String


        'Clear the list box
        lstAvaliable.Items.Clear()

        'Get the selected date
        selectedDate = calCalendar.SelectionRange.Start.ToShortDateString()

        'Open the file
        FileOpen(1, showtimeFile, OpenMode.Random,,, Len(showtimeRecord))

        'Calculate the number of records
        numOfRecords = LOF(1) / Len(showtimeRecord)

        For recordPos = 1 To numOfRecords
            'Read the record
            FileGet(1, showtimeRecord, recordPos)

            'If showtime is avaliable and matches the selected date
            If showtimeRecord.avaliable = True And showtimeRecord.showtimeDate = selectedDate And showtimeRecord.showtimeID > 0 Then
                'Save the showtime details
                With showtimeRecord
                    showtimeDate = .showtimeDate
                    timeHH = .showTimeTimeHH
                    timeMM = .showTimeTimeMM
                    part = .part
                    showtimeID = .showtimeID
                End With

                If timeMM = "0" Then
                    timeMM = "00"
                End If

                'Construct time string
                time = timeHH & ":" & timeMM

                'Add details to the list box
                listString = time
                listString = listString & "     Part: " & part
                lstAvaliable.Items.Add(listString)
            End If

            'Check next record in the file
        Next recordPos

        'Close the file
        FileClose(1)

        showtimePart = part
        showtimeDateString = selectedDate & " " & time
    End Sub

    Private Sub btnContinue_Click(sender As Object, e As EventArgs) Handles btnContinue.Click
        'Validation
        If lstAvaliable.SelectedItem = "" Then
            MsgBox("Please select a showtime")
            Exit Sub
        End If

        'Open the seat selection form
        SelectSeat.Show()
        Me.Hide()
    End Sub

    Private Sub btnNext_Click(sender As Object, e As EventArgs) Handles btnNext.Click
        'Declare variables
        Dim difference As String
        Dim numOfrecords As Integer
        Dim recordPos As Integer
        Dim timeHH As Integer
        Dim timeMM As String
        Dim part As Integer
        Dim answer As Integer
        Dim time As String

        'Open the file
        FileOpen(1, showtimeFile, OpenMode.Random,,, Len(showtimeRecord))

        'Calculate the number of records
        numOfRecords = LOF(1) / Len(showtimeRecord)

        'Set difference to 0
        difference = 0

        For recordPos = 1 To numOfrecords
            'Read in a record
            FileGet(1, showtimeRecord, recordPos)

            'If the date is deleted, or before today then
            If Date.Compare(Convert.ToDateTime(showtimeRecord.showtimeDate), Today) < 0 Or showtimeRecord.showtimeID < 0 Then
                Continue For
            End If

            'If this is the first date being checked then, gather the difference
            If difference = 0 Then

                difference = DateDiff("s", Now, showtimeRecord.showtimeDate)

                With showtimeRecord
                    showtimeDate = .showtimeDate
                    timeHH = .showTimeTimeHH
                    timeMM = .showTimeTimeMM
                    part = .part
                    showtimeID = .showtimeID
                End With

                'If the difference is bigger than current difference then
            ElseIf difference > DateDiff("s", Now, showtimeRecord.showtimeDate) Then

                difference = DateDiff("s", Now, showtimeRecord.showtimeDate)

                With showtimeRecord
                    showtimeDate = .showtimeDate
                    timeHH = .showTimeTimeHH
                    timeMM = .showTimeTimeMM
                    part = .part
                    showtimeID = .showtimeID
                End With

            End If
        Next recordPos

        'Close the file
        FileClose(1)

        'Construct strings
        If timeMM = "0" Then
            timeMM = "00"
        End If

        time = timeHH & ":" & timeMM

        showtimePart = part
        showtimeDateString = showtimeDate & " " & time

        'Confirmation from user
        answer = MsgBox("The nearest showtime is: " & showtimeDate & " Time: " & time & " Part: " & part, vbYesNo, "Next available showtime")

        If answer = vbYes Then
            'Open the seat selection form
            SelectSeat.Show()
            Me.Hide()
        End If

    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        'Return to main menu
        MainMenu.Show()
        Me.Close()
    End Sub
End Class