Public Class SelectShowTime
    Private Sub SelectShowTime_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Sets the minimum date to the current date
        calCalendar.MinDate = System.DateTime.Today()
    End Sub

    Private Sub calCalendar_DateChanged(sender As Object, e As DateRangeEventArgs) Handles calCalendar.DateChanged
        'Declare variables
        Dim showTimeFile As String = Application.StartupPath & "/showtimes.dat"
        Dim numOfRecords As Integer
        Dim recordPos As Integer
        Dim showtimeDate As Date
        Dim part As Integer
        Dim listString As String
        Dim showDate As String
        Dim time As String
        Dim selectedDate As String

        'Clear the listbox
        lstAvaliable.Items.Clear()

        'Open the file
        FileOpen(1, showTimeFile, OpenMode.Random,,, Len(showtimeRecord))

        'Calculate number of records
        numOfRecords = LOF(1) / Len(showtimeRecord)

        For recordPos = 1 To numOfRecords
            'Read the record
            FileGet(1, showtimeRecord, recordpos)

            'If the showtime is not sold out then
            If showtimeRecord.avaliable = True Then

                'Read the time and date
                showtimeDate = showtimeRecord.showtimeDate

                'Get date from date string
                showDate = showtimeDate.ToShortDateString()

                'Get time from date string
                time = showtimeDate.Now.ToString("hh:mm")

                'Read the part
                part = showtimeRecord.part


            End If

            'Get selected date
            selectedDate = calCalendar.SelectionRange.ToString()

            'Add details to listbox
            With showtimeRecord
                'if showtime is not deleted and it matches the selected date then
                If .showtimeID > 0 And selectedDate = showDate Then
                    'Add time and part details to list box
                    listString = time
                    listString = listString & "     Part: " & part
                    lstAvaliable.Items.Add(listString)
                End If
            End With

        Next

        'Close the file
        FileClose(1)
    End Sub

End Class