Imports QRCoder

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
    Dim postcode As String
    Dim phone As String
    Dim block As String
    Dim address As String
    Dim seats() As String

    Public Sub ViewReservations_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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

            'Get record from file
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
                    'Add details to a string and add them to a listbox
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

        'While there are still records in the file
        Do While Not EOF(1)
            'Get record from file
            FileGet(1, reservationRecord, recordPos)

            'If the record matches selected reservation
            If reservationRecord.reservationID = searchID Then
                numOfRecordsFound = numOfRecordsFound + 1

                'Read in the details
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

                'For all the records in the file
                For custrecordPos = 1 To custNumOfRecords

                    'Get the record from the file       
                    FileGet(2, customerRecord, custrecordPos)

                    'If the record matches the customerID on the form then
                    If customerRecord.customerID = txtCustID.Text Then
                        'Add the details to form
                        txtFirstName.Text = customerRecord.firstName
                        txtSurname.Text = customerRecord.Surname
                        postcode = customerRecord.Postcode
                        phone = customerRecord.phoneNumber
                        address = customerRecord.address
                        Exit For
                    End If
                Next

                'Close the file
                FileClose(2)

                'Read in time details
                FileOpen(3, showtimeFile, OpenMode.Random,,, Len(showtimeRecord))

                'Determine number of records
                showtimeNumOfRecords = LOF(3) / Len(showtimeRecord)

                'For all the records in the file
                For showtimeRecordPos = 1 To showtimeNumOfRecords

                    'Get record from file
                    FileGet(3, showtimeRecord, showtimeRecordPos)

                    'If the record matches the showtime on the reservation
                    If reservationRecord.showtimeID = showtimeRecord.showtimeID Then
                        Dim mm As String

                        'Read in the time
                        If showtimeRecord.showTimeTimeMM = 0 Then mm = "00" Else mm = showtimeRecord.showTimeTimeMM
                        time = showtimeRecord.showTimeTimeHH & ":" & mm
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

                'For all the records in the file
                For reservedSeatsRecordPos = 1 To reservedSeatsNumOfRecords
                    'Get record from file
                    FileGet(4, reservedSeatsRecord, reservedSeatsRecordPos)

                    If reservedSeatsRecord.reservationID = searchID Then
                        'Add area to the listbox
                        lstSeats.Items.Add(Trim(reservedSeatsRecord.block) & ":")
                        block = Trim(reservedSeatsRecord.block)
                        'Add the seats to the listbox
                        Dim record As String


                        'Read in seats string
                        record = reservedSeatsRecord.seats

                        'Split seats to elements in an array
                        seats = Split(record, "*")

                        'Add these seats to an arraylist
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

        'If the user did not select a record, clear the textboxes of the previously selected customers details
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
            'Get record from file
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
        'Return to staff area
        StaffArea.Show()
        Me.Hide()
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

        'While there are still records in the file
        Do While Not EOF(1)
            'Get record from file
            FileGet(1, reservationRecord, recordPosition)

            'If record matches record being searched
            If reservationRecord.reservationID = searchString Then
                'Log number of records found
                numOfRecordsFound = numOfRecordsFound + 1

                'Read in customer ID
                custID = reservationRecord.customerID

                'Read customer details
                FileOpen(2, customerFile, OpenMode.Random,,, Len(customerRecord))

                'Determine number of records
                custNumOfRecords = LOF(2) / Len(customerRecord)

                'For all the records in the customer file
                For custRecordPos = 1 To custNumOfRecords

                    'Get record from file
                    FileGet(2, customerRecord, custRecordPos)

                    'If record matches the custID
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
                    'If the record is not deleted then
                    If .reservationID > 0 Then
                        'Add details to a string and add it to the list box
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

        'Close the file
        FileClose(1)

        'Output error if no reservation is found
        If numOfRecordsFound = 0 Then
            MsgBox("Reservation with ID " & searchString & " was not found. Please try again.")
        End If

    End Sub

    Private Sub txtResSearch_GotFocus(sender As Object, e As EventArgs) Handles txtResSearch.GotFocus
        'If textbox gains focus, clear the textbox
        If txtResSearch.Text = "Please enter an ID to search" Then
            txtResSearch.Text = ""
        End If
    End Sub

    Private Sub txtResSearch_LostFocus(sender As Object, e As EventArgs) Handles txtResSearch.LostFocus
        'If the textbox loses focus then, repopulate text box
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

        'Open the file
        FileOpen(1, reservationsFile, OpenMode.Random,,, Len(reservationRecord))

        'Write the ammended record to file
        FilePut(1, reservationRecord, recordPos)

        'Close the file
        FileClose(1)

        'Clear the textboxes
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

    Private Sub ViewReservations_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        'Close the application
        Application.Exit()
    End Sub

    Private Sub PrintDocument1_PrintPage(sender As Object, e As Printing.PrintPageEventArgs) Handles PrintDocument1.PrintPage
        'Declare variables
        Dim x As Integer
        Dim y As Integer
        Dim fontHeight As Integer

        'Set up the fonts
        Dim TitleFont As New Font("Arial", 30, FontStyle.Bold)
        Dim BodyFont As New Font("Arial", 16, FontStyle.Regular)

        'Set background colour
        e.Graphics.Clear(Color.Khaki)

        'Find the image from the form
        Dim logo As Image = My.Resources.Icon

        'Print the image
        e.Graphics.DrawImage(logo, 700, 20, 100, 100)

        'Setup the location to start printing
        fontHeight = BodyFont.GetHeight(e.Graphics)
        x = 50
        y = 50

        'Print the title on the page
        e.Graphics.DrawString("Cursed Child Ticket(s):", TitleFont, Brushes.Black, x, y)

        'Move down to print the body of the document
        y = 100

        'Print the reservation number
        e.Graphics.DrawString("     Reservation Number: " & Trim(txtResID.Text), BodyFont, Brushes.Black, x, y)
        'Move to next line
        y = y + fontHeight

        'Print the customer name
        e.Graphics.DrawString("     Name:" & Trim(txtFirstName.Text) & " " & Trim(txtSurname.Text), BodyFont, Brushes.Black, x, y)
        'Move to next line
        y = y + fontHeight

        'Print the address
        e.Graphics.DrawString("     Address: " & Trim(address) & " " & Trim(postcode), BodyFont, Brushes.Black, x, y)
        'Move to the next line
        y = y + fontHeight

        'Print the telephone number
        e.Graphics.DrawString("     Telephone: " & Trim(phone), BodyFont, Brushes.Black, x, y)
        y = y + fontHeight

        'Print the seat area
        e.Graphics.DrawString("     Area: " & Trim(block), BodyFont, Brushes.Black, x, y)
        y = y + fontHeight

        'Print the seats
        Dim str As String
        Dim seatString As String

        'Create seats string
        For z = 0 To seats.Length - 1
            seatString = seatString & " " & seats(z)
        Next

        'Write seat string to the ticket
        e.Graphics.DrawString("     Seats: " & Trim(seatString), BodyFont, Brushes.Black, x, y)
        y = y + fontHeight

        'Generate QR code
        Dim qrGenerator As New QRCodeGenerator
        Dim codeData As QRCodeData = qrGenerator.CreateQrCode(txtResID.Text, QRCodeGenerator.ECCLevel.Q)
        Dim QRCode As New QRCode(codeData)
        Dim QRImage As Bitmap = QRCode.GetGraphic(20)
        e.Graphics.DrawImage(QRImage, 200, 300, 400, 400)

        'Move below QR code
        y = y + fontHeight + 500

        'Print message
        x = x + 30
        e.Graphics.DrawString("Please show this to the box office on arrival for payment and entry", BodyFont, Brushes.Black, x, y)

    End Sub

    Private Sub btnCollect_Click(sender As Object, e As EventArgs) Handles btnCollect.Click
        'Set the document to preview
        PrintPreviewDialog1.Document = PrintDocument1

        'Open the print preview dialog
        PrintPreviewDialog1.ShowDialog()
    End Sub
End Class