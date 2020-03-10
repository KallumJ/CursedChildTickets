Public Class ViewReservations
    'Declare variables
    Dim reservationsFile As String = Application.StartupPath & "/reservations.dat"
    Dim customerFile As String = Application.StartupPath & "/customers.dat"
    Dim showtimeFile As String = Application.StartupPath & "/showtimes.dat"
    Dim reservedSeatsFile As String = Application.StartupPath & "/reservedseats.dat"
    Dim recordPos As Integer
    Dim customerID As Integer
    Dim firstName As String
    Dim surname As String
    Dim time As String

    Private Sub ViewReservations_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Declare variables
        Dim numofRecords As Integer
        Dim listString As String
        Dim custNumOfRecords As Integer
        Dim custRecordPos As Integer

        'Clear the list box
        lstReservations.Items.Clear()

        'Listbox title
        lstReservations.Items.Add("ReservationID      First Name         Surname")

        'Open the file
        FileOpen(1, reservationsFile, OpenMode.Random,,, Len(reservationRecord))

        'Open the customers file
        FileOpen(2, customerFile, OpenMode.Random,,, Len(customerRecord))

        'Find the number of records
        numofRecords = LOF(1) / Len(reservationRecord)

        'Determine number of records
        custNumOfRecords = LOF(2) / Len(customerRecord)

        'Read in records
        For recordPos = 1 To numofRecords

            FileGet(1, reservationRecord, recordPos)

            'Read in the customer ID
            customerID = reservationRecord.customerID

            'Look for customer with ID
            For custRecordPos = 1 To custNumOfRecords

                'Read in record
                FileGet(2, customerRecord, custRecordPos)

                If customerRecord.customerID = customerID Then
                    'Read in names
                    firstName = customerRecord.firstName
                    surname = customerRecord.Surname
                    Exit For
                End If

            Next

            With reservationRecord
                'If reservation is not deleted
                If .reservationID > 0 Then
                    listString = .reservationID
                    listString = listString & "                      " & customerRecord.firstName
                    listString = listString & customerRecord.Surname
                    lstReservations.Items.Add(listString)
                End If
            End With


        Next

        'Close the customer file
        FileClose(2)

        'Close the file
        FileClose(1)
    End Sub

    Private Sub lstReservations_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstReservations.SelectedIndexChanged
        'Declare variables
        Dim numOfRecordsFound As Integer
        Dim reservationString As String
        Dim searchID As Integer
        Dim custrecordPos As Integer
        Dim custNumOfRecords As Integer
        Dim showtimeRecordPos As Integer
        Dim showtimeNumOfRecords As Integer
        Dim reservedSeatsNumOfRecords As Integer
        Dim reservedSeatsRecordPos As Integer

        'Clear the seats listbox
        lstSeats.Items.Clear()

        'Find the selected reservation ID
        reservationString = lstReservations.Text
        searchID = Val(Microsoft.VisualBasic.Left(reservationString, 10))

        'Open the file
        FileOpen(1, reservationsFile, OpenMode.Random,,, Len(reservationRecord))

        'Read in records from file
        recordPos = 1

        Do While Not EOF(1)
            FileGet(1, reservationRecord, recordPos)

            'If the record matches selected reservation
            If reservationRecord.reservationID = searchID Then
                numOfRecordsFound = numOfRecordsFound + 1

                With reservationRecord
                    txtResID.Text = .reservationID
                    txtCustID.Text = .customerID
                    txtShowID.Text = .showtimeID
                    datDate.Value = .reservationDate
                    txtPrice.Text = FormatCurrency(.totalPrice)
                End With

                'Read customer details
                FileOpen(2, customerFile, OpenMode.Random,,, Len(customerRecord))

                'Determine number of records
                custNumOfRecords = LOF(2) / Len(customerRecord)

                For custrecordPos = 1 To custNumOfRecords

                    FileGet(2, customerRecord, custrecordPos)

                    If customerRecord.customerID = txtCustID.Text Then
                        'Add the details to form
                        txtFirstName.Text = customerRecord.firstName
                        txtSurname.Text = customerRecord.Surname
                        Exit For
                    End If
                Next

                'Close the file
                FileClose(2)

                'Read in time details
                FileOpen(3, showtimeFile, OpenMode.Random,,, Len(showtimeRecord))

                'Determine number of records
                showtimeNumOfRecords = LOF(3) / Len(showtimeRecord)

                For showtimeRecordPos = 1 To showtimeNumOfRecords

                    FileGet(3, showtimeRecord, showtimeRecordPos)

                    If reservationRecord.showtimeID = showtimeRecord.showtimeID Then
                        time = showtimeRecord.showTimeTimeHH & ":" & showtimeRecord.showTimeTimeMM
                        txtTime.Text = time
                        Exit For
                    End If

                Next

                'Close the file
                FileClose(3)

                'Read in the seats
                FileOpen(4, reservedSeatsFile, OpenMode.Random,,, Len(reservedSeatsRecord))

                'Determine number of records
                reservedSeatsNumOfRecords = LOF(4) / Len(reservedSeatsRecord)

                For reservedSeatsRecordPos = 1 To reservedSeatsNumOfRecords
                    FileGet(4, reservedSeatsRecord, reservedSeatsRecordPos)

                    If reservedSeatsRecord.reservationID = searchID Then
                        'Add area to the listbox
                        lstSeats.Items.Add(Trim(reservedSeatsRecord.block) & ":")

                        'Add the seats to the listbox
                        Dim record As String
                        Dim seats() As String

                        record = reservedSeatsRecord.seats
                        seats = Split(record, "*")


                        For i = 0 To seats.Length - 1
                            lstSeats.Items.Add(seats(i))
                        Next

                        'Exit for as seat was found
                        Exit For
                    End If
                Next

                'Close the file
                FileClose(4)

                'Exit the loop
                Exit Do

            End If

            'Increment record
            recordPos = recordPos + 1
        Loop

        'If no records are found, output an error
        If numOfRecordsFound = 0 And searchID <> 0 Then
            MsgBox("Reservation with ID" & searchID & " could not be found, please contact your system administrator")
        End If

        'Close the file
        FileClose(1)

        If searchID = 0 Then
            txtResID.Text = ""
            txtShowID.Text = ""
            txtCustID.Text = ""
            txtFirstName.Text = ""
            txtSurname.Text = ""
            datDate.Value = Today
            txtPrice.Text = ""
            lstSeats.Items.Clear()
        End If
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        'Declare variables
        Dim numOfRecords As Integer

        'Read in fields in record
        With reservationRecord
            .reservationID = -Val(txtResID.Text)
            .customerID = txtCustID.Text
            .showtimeID = txtShowID.Text
            .reservationDate = datDate.Value.ToShortDateString
            .totalPrice = txtPrice.Text
        End With

        'Open the file
        FileOpen(1, reservationsFile, OpenMode.Random,,, Len(reservationRecord))

        'Write the record to file
        FilePut(1, reservationRecord, recordPos)

        'Close the file
        FileClose(1)

        'Open the file
        FileOpen(1, reservedSeatsFile, OpenMode.Random,,, Len(reservedSeatsRecord))

        'Determine number of records
        numOfRecords = LOF(1) / Len(reservedSeatsRecord)

        'Read in the records
        For recordPos = 1 To numOfRecords
            FileGet(1, reservedSeatsRecord, recordPos)

            'If seats are for reservation being deleted then
            If Trim(reservedSeatsRecord.reservationID) = Trim(txtResID.Text) Then
                'Ammend record
                With reservedSeatsRecord
                    .reservationID = -Val(.reservationID)
                    .showtimeID = .showtimeID
                    .seats = .seats
                    .block = .block
                End With

                'Write the ammended record to file
                FilePut(1, reservedSeatsRecord, recordPos)
            End If
        Next

        'Close the file
        FileClose(1)

        'Reload form
        Call ViewReservations_Load(Me, e)

    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        StaffArea.Show()
        Me.Close()
    End Sub

    Private Sub btnResSearch_Click(sender As Object, e As EventArgs) Handles btnResSearch.Click
        'Declare variables
        Dim searchString As String
        Dim listString As String
        Dim numOfRecords As Integer
        Dim numOfRecordsFound As Integer
        Dim firstName As String
        Dim surname As String
        Dim recordPosition As Integer
        Dim custNumOfRecords As Integer
        Dim custRecordPos As Integer
        Dim custID As Integer

        'Read in the query
        searchString = txtResSearch.Text

        'Set record position to 1
        recordPosition = 1

        'Open the file
        FileOpen(1, reservationsFile, OpenMode.Random,,, Len(reservationRecord))

        'Calculate number of records in the file
        numOfRecords = LOF(1) / Len(reservationRecord)
        recordPos = 1

        'Clear the listbox
        lstReservations.Items.Clear()

        'Add listbox title
        lstReservations.Items.Add("ReservationID      First Name         Surname")

        'Read in the records

        Do While Not EOF(1)
            FileGet(1, reservationRecord, recordPosition)

            If reservationRecord.reservationID = searchString Then
                numOfRecordsFound = numOfRecordsFound + 1

                'Read in customer ID
                custID = reservationRecord.customerID

                'Read customer details
                FileOpen(2, customerFile, OpenMode.Random,,, Len(customerRecord))

                'Determine number of records
                custNumOfRecords = LOF(2) / Len(customerRecord)

                For custrecordPos = 1 To custNumOfRecords

                    FileGet(2, customerRecord, custrecordPos)

                    If customerRecord.customerID = custID Then
                        'Add the details to form
                        firstName = customerRecord.firstName
                        surname = customerRecord.Surname
                        Exit For
                    End If
                Next

                'Close the file
                FileClose(2)

                With reservationRecord
                    If .reservationID > 0 Then
                        listString = .reservationID
                        listString = listString & "                      " & firstName
                        listString = listString & surname
                        lstReservations.Items.Add(listString)
                    End If
                End With

            End If

            'Increment record position
            recordPosition = recordPosition + 1
        Loop

        FileClose(1)

        'Output error if no reservation is found
        If numOfRecordsFound = 0 Then
            MsgBox("Reservation with ID " & searchString & " was not found. Please try again.")
        End If

    End Sub

    Private Sub txtResSearch_GotFocus(sender As Object, e As EventArgs) Handles txtResSearch.GotFocus
        If txtResSearch.Text = "Please enter an ID to search" Then
            txtResSearch.Text = ""
        End If
    End Sub

    Private Sub txtResSearch_LostFocus(sender As Object, e As EventArgs) Handles txtResSearch.LostFocus
        If txtResSearch.Text = "" Then
            txtResSearch.Text = "Please enter an ID to search"
        End If
    End Sub

    Private Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click
        'Read in fields in record
        With reservationRecord
            .reservationID = Val(txtResID.Text)
            .customerID = Val(txtCustID.Text)
            .showtimeID = Val(txtShowID.Text)
            .reservationDate = datDate.Value.ToShortDateString
            .totalPrice = txtPrice.Text
        End With

        FileOpen(1, reservationsFile, OpenMode.Random,,, Len(reservationRecord))

        FilePut(1, reservationRecord, recordPos)

        FileClose(1)

        txtResID.Text = ""
        txtCustID.Text = ""
        txtShowID.Text = ""
        txtFirstName.Text = ""
        txtSurname.Text = ""
        datDate.Value = Today
        txtPrice.Text = ""
        lstSeats.Items.Clear()

        'Reload the form
        Call ViewReservations_Load(Me, e)
    End Sub
End Class