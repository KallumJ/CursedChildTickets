Public Class SelectShowTime

    'Declare variables
    Public showtimeDateString As String
    Public showtimePart As String
    Public showtimeID As Integer
    Public showtimeDate As String
    Public part2ID As Integer
    Dim showtimeFile As String = Application.StartupPath & "/showtimes.dat"
    Dim reservedSeatsFile As String = Application.StartupPath & "/reservedseats.dat"

    Public timer As New Timer
    Public reset As Double
    Public active As Boolean = False
    Public timeLeft As String

    'Function to check whether the string has letters or numbers
    Private Function IsAlphaNum(ByVal strInputText As String) As Boolean
        Dim IsAlpha As Boolean = False
        If System.Text.RegularExpressions.Regex.IsMatch(strInputText, "^[a-zA-Z0-9]+$") Then
            IsAlpha = True
        Else
            IsAlpha = False
        End If
        Return IsAlpha
    End Function

    Public Sub SelectShowTime_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Sets the minimum date to the current date
        calCalendar.MinDate = System.DateTime.Today()

        'Set sold out shows to unavailable
        Dim totalCapacity As Integer = 1728
        Dim seatList As New ArrayList
        Dim reservedSeatsNumOfRecords As Integer
        Dim showtimeNumOfRecords As Integer

        'Open the file
        FileOpen(1, showtimeFile, OpenMode.Random,,, Len(showtimeRecord))

        'Determine number of records
        showtimeNumOfRecords = LOF(1) / Len(showtimeRecord)

        'Read in the records
        For showtimeRecordPos = 1 To showtimeNumOfRecords
            FileGet(1, showtimeRecord, showtimeRecordPos)

            'Open the reserved seats file
            FileOpen(2, reservedSeatsFile, OpenMode.Random,,, Len(reservedSeatsRecord))

            'Determine number of records
            reservedSeatsNumOfRecords = LOF(2) / Len(reservedSeatsRecord)

            'Read in a reserved seats file record
            For reservedSeatsRecordPos = 1 To reservedSeatsNumOfRecords
                FileGet(2, reservedSeatsRecord, reservedSeatsRecordPos)

                'If reserved seats match showtime currently being checked then
                If showtimeRecord.showtimeID = reservedSeatsRecord.showtimeID Then
                    'Split reserved seat record
                    Dim record As String
                    Dim splitrecord() As String

                    record = reservedSeatsRecord.seats
                    splitrecord = Split(record, "*")

                    'Convert array to array list
                    For i = 0 To splitrecord.Length - 1
                        If IsAlphaNum(splitrecord(i)) = True Then
                            seatList.Add(splitrecord(i))
                        End If
                    Next

                    'If the seat count exceeds total capacity, then set it to unavaiable
                    If seatList.Count >= totalCapacity Then
                        showtimeRecord.avaliable = False
                        FilePut(1, showtimeRecord, showtimeRecordPos)
                    End If

                End If

            Next
            FileClose(2)
            'Clear the seat list
            seatList.Clear()
        Next
        FileClose(1)

        'Add avaliability for current day
        UpdateList()

        'Start the reset timer
        If active = False Then
            active = True
            reset = 300
            timer.Interval = 1000
            timer.Enabled = True
            AddHandler timer.Tick, AddressOf timerTick
        End If

    End Sub

    Public Sub timerTick()
        'Decrease timer
        reset = reset - 1

        Dim span As TimeSpan = TimeSpan.FromSeconds(reset)

        'Create strinng
        timeLeft = "Timer: " & span.Minutes.ToString.PadLeft(2, "0"c) & ":" & span.Seconds.ToString.PadLeft(2, "0"c)

        'Update labels
        lblTimer.Text = timeLeft
        SelectSeat.lblTimer.Text = timeLeft
        BasketOverview.lblTimer.Text = timeLeft
        CustomerDetails.lblTimer.Text = timeLeft
        DetailsConfirmation.lblTimer.Text = timeLeft

        'If timer reaches 0, reset form
        If reset = 0 Then
            Application.Restart()
        End If
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

                'If the user is searching for consecutive showtimes and showtime is for part 1
                If TicketType.consecutive = True And showtimeRecord.part = 1 Then

                    'Check the file for a showtime on the same day for part 2
                    For nestedRecordPos = 1 To numOfRecords
                        FileGet(1, searchShowtimeRecord, nestedRecordPos)

                        'If showtimes are on the same date and the showtime being read is for part 2
                        If showtimeRecord.showtimeDate = searchShowtimeRecord.showtimeDate And searchShowtimeRecord.part = 2 Then
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
                            listString = showtimeID
                            listString = listString & ": " & time
                            listString = listString & "     Part: " & part
                            lstAvaliable.Items.Add(listString)

                            'Save the showtime details
                            With searchShowtimeRecord
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
                            listString = showtimeID
                            listString = listString & ": " & time
                            listString = listString & "     Part: " & part
                            lstAvaliable.Items.Add(listString)
                            Exit For
                        End If
                    Next
                    Exit For
                    'If ticket type is not consecutive then
                Else

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
                    listString = showtimeID
                    listString = listString & ": " & time
                    listString = listString & "     Part: " & part
                    lstAvaliable.Items.Add(listString)

                End If
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
        SelectSeat.cmbArea.Text = ""
        SelectSeat.panSeats.Controls.Clear()
        reset = 300
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
        If TicketType.consecutive <> True Then

            For recordPos = 1 To numOfrecords
                'Read in a record
                FileGet(1, showtimeRecord, recordPos)

                'If the date is deleted, or before today then
                If Date.Compare(Convert.ToDateTime(showtimeRecord.showtimeDate), Today) < 0 Or showtimeRecord.showtimeID < 0 Or showtimeRecord.avaliable = False Then
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
        Else
            'If ticket type is consecutive then
            For recordPos = 1 To numOfrecords
                'Read in a record
                FileGet(1, showtimeRecord, recordPos)

                'If showtime is part 1 then
                If showtimeRecord.part = 1 Then

                    'Read in the records again
                    For nestedRecordPos = 1 To numOfrecords
                        FileGet(1, searchShowtimeRecord, nestedRecordPos)

                        'If record being read is the same date, and for part 2
                        If searchShowtimeRecord.showtimeDate = showtimeRecord.showtimeDate And searchShowtimeRecord.part = 2 Then

                            'If the date is deleted, or before today then move on
                            If Date.Compare(Convert.ToDateTime(showtimeRecord.showtimeDate), Today) < 0 Or showtimeRecord.showtimeID < 0 Or showtimeRecord.avaliable = False Then
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
                                    part2ID = .showtimeID + 1
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
                                    part2ID = .showtimeID + 1
                                End With

                            End If

                        End If

                    Next

                End If
            Next

            'Close the file
            FileClose(1)

            'Construct strings
            If timeMM = "0" Then
                timeMM = "00"
            End If

            time = timeHH & ":" & timeMM

            showtimePart = part
            showtimeDateString = showtimeDate & " " & time
        End If

        'Confirmation from user
        If TicketType.consecutive <> True Then
            answer = MsgBox("The nearest showtime is: " & showtimeDate & " Time: " & time & " Part: " & part, vbYesNo, "Next available showtime")
        Else
            answer = MsgBox("The nearest showtime is: " & showtimeDate & " Time: 14:00 and 19:30" & " Part: 1 & 2 ", vbYesNo, "Next available showtime")
        End If


        If answer = vbYes Then
            'Open the seat selection form
            reset = 300
            SelectSeat.Show()
            Me.Hide()
        End If

    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        'Return to main menu
        TicketType.consecutive = False
        TicketType.nonConsecutive = False
        MainMenu.Show()
        Me.Hide()
    End Sub

    Private Sub SelectShowTime_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        Application.Exit()
    End Sub

    Private Sub lstAvaliable_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstAvaliable.SelectedIndexChanged
        'Find the ID of the selected showtime
        Dim listArray() As String
        Dim searchID As Integer
        Dim numOfRecords As Integer

        'If the user doesnt click a showtime
        If lstAvaliable.SelectedItem = "" Then
            Exit Sub
        End If

        'Find the selected Showtime ID
        ReDim listArray(lstAvaliable.Items.Count - 1)
        lstAvaliable.Items.CopyTo(listArray, 0)
        If TicketType.consecutive <> True Then
            searchID = Val(Microsoft.VisualBasic.Left(listArray(lstAvaliable.SelectedIndex), 10))
        Else
            searchID = Val(Microsoft.VisualBasic.Left(listArray(0), 10))
        End If

        'Open the file and determine number of records
        FileOpen(1, showtimeFile, OpenMode.Random,,, Len(showtimeRecord))
        numOfRecords = LOF(1) / Len(showtimeRecord)

        'Read in the records
        For recordPos = 1 To numOfRecords
            FileGet(1, showtimeRecord, recordPos)

            'Read in the details of the showtime
            If showtimeRecord.showtimeID = searchID Then
                With showtimeRecord
                    showtimeDate = .showtimeDate
                    showtimeID = .showtimeID
                    showtimePart = .part
                    showtimeDateString = .showtimeDate & " " & .showTimeTimeHH & ":"
                    If .showTimeTimeMM = "0" Then
                        showtimeDateString = showtimeDateString & "00"
                    Else
                        showtimeDateString = showtimeDateString & .showTimeTimeMM
                    End If
                End With
                Exit For
            End If
        Next
        FileClose(1)

        'if ticket type is consecutive, get the showtime id for the next performance
        If TicketType.consecutive = True Then
            part2ID = Val(Microsoft.VisualBasic.Left(listArray(1), 10))
        End If


    End Sub
End Class