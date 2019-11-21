Public Class SelectShowTime
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
        Dim showtimeFile As String = Application.StartupPath & "/showtimes.dat"
        Dim numOfRecords As Integer
        Dim recordPos As Integer
        Dim selectedDate As String
        Dim showtimeDate As String
        Dim timeHH As Integer
        Dim timeMM As Integer
        Dim time As String
        Dim part As Integer
        Dim listString As String
        Dim id As Integer

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
            If showtimeRecord.avaliable = True And showtimeRecord.showtimeDate = selectedDate Then
                'Save the showtime details
                With showtimeRecord
                    showtimeDate = .showtimeDate
                    timeHH = .showTimeTimeHH
                    timeMM = .showTimeTimeMM
                    part = .part
                    id = .showtimeID
                End With

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
    End Sub

End Class