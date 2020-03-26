Imports EASendMail
Imports QRCoder

Public Class DetailsConfirmation

    'Declare variable
    Dim resRecordPos As Integer

    Private Sub btnReserve_Click(sender As Object, e As EventArgs) Handles btnReserve.Click
        'Declare variables
        Dim customerFile As String = Application.StartupPath & "/customers.dat"
        Dim custRecordPos As Integer
        Dim custNumOfRecords As Integer
        Dim reservationsFile As String = Application.StartupPath & "/reservations.dat"
        Dim resNumOfRecords As Integer
        Dim reservedSeatsFile As String = Application.StartupPath & "/reservedseats.dat"
        Dim resSeatsRecordPos As Integer
        Dim resSeatsNumOfRecords As Integer
        Dim custid As Integer
        Dim resid As Integer
        Dim showtimeFile As String = Application.StartupPath & "/showtimes.dat"
        Dim showNumOfRecords As Integer
        Dim part2Date As Date

        'Save entered customer details to file
        Try

            'Open the file
            FileOpen(1, customerFile, OpenMode.Random,,, Len(customerRecord))

            'Determine record position
            custNumOfRecords = LOF(1) / Len(customerRecord)
            custRecordPos = custNumOfRecords + 1

            'Determine ID
            FileGet(1, customerRecord, custNumOfRecords)
            custid = customerRecord.customerID + 1

            'Prevent duplication of data
            For checkPos = 1 To custNumOfRecords
                'Get the record from file
                FileGet(1, customerRecord, checkPos)

                'If customer is already recorded, exit try
                If Trim(customerRecord.firstName) = Trim(CustomerDetails.firstName) And Trim(customerRecord.Surname) = Trim(CustomerDetails.surname) Then
                    custRecordPos = customerRecord.customerID
                    custid = customerRecord.customerID
                    'Close the file
                    FileClose(1)
                    Exit Try
                End If
            Next

            'Read in the entered data
            With customerRecord
                .customerID = custid
                .title = CustomerDetails.title
                .firstName = CustomerDetails.firstName
                .Surname = CustomerDetails.surname
                .phoneNumber = CustomerDetails.phone
                .email = CustomerDetails.email
                .address = CustomerDetails.address
                .Postcode = CustomerDetails.postcode
            End With

            'Write the record to file
            FilePut(1, customerRecord, custRecordPos)

            'Close the file
            FileClose(1)
        Catch ex As Exception
            'Output exception as error
            Dim x As String

            x = ex.ToString()

            MsgBox("An error occured: " & x & ". Please contact a system administrator.")
        End Try

        'Write reservation to file
        Try
            'Open the file
            FileOpen(1, reservationsFile, OpenMode.Random,,, Len(reservationRecord))

            'Determine record position
            resNumOfRecords = LOF(1) / Len(reservationRecord)
            resRecordPos = resNumOfRecords + 1

            'Determine ID
            FileGet(1, reservationRecord, resNumOfRecords)
            resid = reservationRecord.reservationID + 1

            'Read in reservation data
            With reservationRecord
                .reservationID = resid
                .customerID = custid
                .showtimeID = SelectShowTime.showtimeID
                .reservationDate = SelectShowTime.showtimeDate
                .totalPrice = SelectSeat.price
            End With

            'Write the record to file
            FilePut(1, reservationRecord, resRecordPos)

            'Close the file
            FileClose(1)

        Catch ex As Exception
            'Output the error to user
            Dim x As String

            x = ex.ToString

            MsgBox("An error occured: " & x & ". Please contact a system administrator.")

        End Try

        'Write reserved seats to file
        Try
            'Open the file
            FileOpen(1, reservedSeatsFile, OpenMode.Random,,, Len(reservedSeatsRecord))

            'Determine number of records
            resSeatsNumOfRecords = LOF(1) / Len(reservedSeatsRecord)
            resSeatsRecordPos = resSeatsNumOfRecords + 1

            'Create seats string
            Dim seats As String
            Dim str As String
            For Each str In SelectSeat.seat
                If seats = "" Then
                    seats = Trim(str)
                Else
                    seats = seats & "*" & Trim(str)
                End If
            Next
            seats = seats & "*"

            'Read in the details
            With reservedSeatsRecord
                .reservationID = resid
                .showtimeID = SelectShowTime.showtimeID
                .seats = seats
                .block = SelectSeat.area
            End With

            'Write the record to file
            FilePut(1, reservedSeatsRecord, resSeatsRecordPos)

            'Close the file
            FileClose(1)

        Catch ex As Exception
            'Output the error to user
            Dim x As String

            x = ex.ToString

            MsgBox("An error occured: " & x & ". Please contact a system administrator.")

        End Try

        'If ticket type is consecutive
        Try

            'If reservation is consecutive
            If TicketType.consecutive = True Then
                resid = resid + 1

                'Open the file
                FileOpen(1, reservationsFile, OpenMode.Random,,, Len(reservationRecord))

                'Determine record position
                resNumOfRecords = LOF(1) / Len(reservationRecord)
                resRecordPos = resNumOfRecords + 1

                'Determine ID
                FileGet(1, reservationRecord, resNumOfRecords)
                resid = reservationRecord.reservationID + 1

                'Open the file
                FileOpen(2, showtimeFile, OpenMode.Random,,, Len(showtimeRecord))

                'Determine the number of records
                showNumOfRecords = LOF(2) / Len(showtimeRecord)

                For showRecordPos = 1 To showNumOfRecords
                    'Get the record from file
                    FileGet(2, showtimeRecord, showRecordPos)

                    'If the showtime matches the required showtime
                    If showtimeRecord.showtimeID = Trim(SelectShowTime.part2ID) Then
                        'Read in the data
                        part2Date = showtimeRecord.showtimeDate
                        'Close the file
                        FileClose(2)
                        'Exit loop
                        Exit For
                    End If

                Next
                FileClose(2)

                'Read in reservation data
                With reservationRecord
                    .reservationID = resid
                    .customerID = custid
                    .showtimeID = Trim(SelectShowTime.part2ID)
                    .reservationDate = part2Date
                    .totalPrice = SelectSeat.price
                End With

                'Write the record to file
                FilePut(1, reservationRecord, resRecordPos)

                'Close the file
                FileClose(1)

                'Reset ticket type
                TicketType.consecutive = False

                'Open the file
                FileOpen(1, reservedSeatsFile, OpenMode.Random,,, Len(reservedSeatsRecord))

                'Create seats string
                Dim seats As String
                Dim str As String
                For Each str In SelectSeat.seat
                    If seats = "" Then
                        seats = Trim(str)
                    Else
                        seats = seats & "*" & Trim(str)
                    End If
                Next
                seats = seats & "*"

                'Read in the details
                With reservedSeatsRecord
                    .reservationID = resid
                    .showtimeID = Trim(SelectShowTime.part2ID)
                    .seats = seats
                    .block = SelectSeat.area

                    'Write the record to file
                    FilePut(1, reservedSeatsRecord, resSeatsRecordPos + 1)

                    'Close the file
                    FileClose(1)
                End With
            End If
        Catch ex As Exception
            'Display error to the user
            MsgBox(ex.ToString)
        End Try

        'If ticket is non consecutive, redirect user to remake another reservation
        If TicketType.nonConsecutive = True Then
            'Reset ticket mode
            TicketType.nonConsecutive = False
            
            'Open the showtime form
            SelectShowTime.Show()
            Me.Hide()
            
            'Exit routine
            Exit Sub
        End If

        Try

            'Declare variables
            Dim oMail As New SmtpMail("TryIt")

            'Set sender email address
            oMail.From = "cursedchildpalacetheatre@gmail.com"

            'Set recipient email address
            oMail.To = CustomerDetails.txtEmail.Text

            'Set email subject
            oMail.Subject = "Cursed Child Tickets Confirmation. Reservation Number: " & resRecordPos

            'Create seats string
            Dim str2 As String
            Dim seats2 As String
            For Each str2 In SelectSeat.seat
                seats2 = seats2 & " " & str2
            Next

            'Set email body
            oMail.TextBody = "Thank you for your reservation to see Harry Potter and the Cursed Child at the Palace Theatre. Your reservation details are as follows:" & vbNewLine & "Reservation Number: " & resRecordPos & vbNewLine & "First Name: " & CustomerDetails.txtFirstName.Text & vbNewLine & "Surname: " & CustomerDetails.txtSurname.Text & vbNewLine & "Address: " & CustomerDetails.txtAddress.Text & vbNewLine & "Area: " & SelectSeat.cmbArea.Text & vbNewLine & "Seats: " & seats2 & vbNewLine & lblTotal.Text & vbNewLine & "Please check the above details and call us if there is anything wrong at 020 7434 0088."

            'Setup smtp server
            Dim oServer As New SmtpServer("smtp.gmail.com")
            oServer.User = "cursedchildpalacetheatre@gmail.com"
            oServer.Password = "cursedchild111"
            oServer.Port = 587
            oServer.ConnectType = SmtpConnectType.ConnectTryTLS

            'Declare client
            Dim oSmtp As New SmtpClient()
            
            'Send the email
            oSmtp.SendMail(oServer, oMail)
        Catch ex As Exception
            'Display the error message to the user
            MsgBox(ex.ToString)
        End Try

        'Set the document to preview
        PrintPreviewDialog1.Document = PrintDocument1

        'Open the print preview dialog
        PrintPreviewDialog1.ShowDialog()

        'Turn off timer
        SelectShowTime.timer.Enabled = False
        SelectShowTime.active = False
        SelectShowTime.reset = 300

        'Open order confirmation
        OrderConfirmed.Show()
        Me.Hide()
    End Sub

    Public Sub DetailsConfirmation_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Declare variables
        Dim custTxtString As String
        Dim ticketTxtString As String
        Dim str As String
        Dim seats As String

        'If ticket type is non consecutive, display notice that user will be redirected
        If TicketType.nonConsecutive = True Then
            lblNotice.Text = "Notice: As you are booking non consecutive tickets, click reserve in order to be redirected to make your additional booking"
        Else
            lblNotice.Text = ""
        End If

        'Create seats string
        For Each str In SelectSeat.seat
            seats = seats & ", " & str
        Next

        'Clear the customer text box
        txtCustomerDetails.Text = ""

        'Create customer text string to display details
        custTxtString = "Title: " & CustomerDetails.title & vbNewLine
        custTxtString = custTxtString & "First Name: " & CustomerDetails.firstName & vbNewLine
        custTxtString = custTxtString & "Surname: " & CustomerDetails.surname & vbNewLine
        custTxtString = custTxtString & "Phone Number: " & CustomerDetails.phone & vbNewLine
        custTxtString = custTxtString & "Email: " & CustomerDetails.email & vbNewLine
        custTxtString = custTxtString & "Address: " & CustomerDetails.address & vbNewLine
        custTxtString = custTxtString & "Postcode: " & CustomerDetails.postcode & vbNewLine

        'Add the file to text box
        txtCustomerDetails.Text = custTxtString

        'Create the tickets text box
        ticketTxtString = "Date: " & SelectShowTime.showtimeDateString & vbNewLine
        If TicketType.consecutive <> True Then ticketTxtString = ticketTxtString & "Part: " & SelectShowTime.showtimePart & vbNewLine Else ticketTxtString = ticketTxtString & "Part: 1 & 2 " & vbNewLine
        ticketTxtString = ticketTxtString & "Area: " & SelectSeat.area & vbNewLine
        ticketTxtString = ticketTxtString & "Seat(s): " & seats & vbNewLine
        lblTotal.Text = "Total: " & FormatCurrency(SelectSeat.price) & vbNewLine


        'Add the details to the text box
        txtTicketDetails.Text = ticketTxtString

    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        'Return to selecting showtime
        SelectShowTime.Show()
        Me.Hide()
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
        e.Graphics.DrawString("     Reservation Number: " & resRecordPos, BodyFont, Brushes.Black, x, y)
        'Move to next line
        y = y + fontHeight

        'Print the customer name
        e.Graphics.DrawString("     Name:" & CustomerDetails.firstName & " " & CustomerDetails.surname, BodyFont, Brushes.Black, x, y)
        'Move to next line
        y = y + fontHeight

        'Print the address
        e.Graphics.DrawString("     Address: " & CustomerDetails.address & " " & CustomerDetails.postcode, BodyFont, Brushes.Black, x, y)
        'Move to the next line
        y = y + fontHeight

        'Print the telephone number
        e.Graphics.DrawString("     Telephone: " & CustomerDetails.phone, BodyFont, Brushes.Black, x, y)
        y = y + fontHeight

        'Print the seat area
        e.Graphics.DrawString("     Area: " & SelectSeat.cmbArea.Text, BodyFont, Brushes.Black, x, y)
        y = y + fontHeight

        'Print the seats
        Dim str As String
        Dim seats As String

        'Create seats string
        For Each str In SelectSeat.seat
            seats = seats & " " & str
        Next

        'Write seat string to the ticket
        e.Graphics.DrawString("     Seats: " & seats, BodyFont, Brushes.Black, x, y)
        y = y + fontHeight

        'Generate QR code
        Dim qrGenerator As New QRCodeGenerator
        Dim codeData As QRCodeData = qrGenerator.CreateQrCode(resRecordPos, QRCodeGenerator.ECCLevel.Q)
        Dim QRCode As New QRCode(codeData)
        Dim QRImage As Bitmap = QRCode.GetGraphic(20)
        e.Graphics.DrawImage(QRImage, 200, 300, 400, 400)

        'Move below QR code
        y = y + fontHeight + 500

        'Print message
        x = x + 30
        e.Graphics.DrawString("Please show this to the box office on arrival for payment and entry", BodyFont, Brushes.Black, x, y)

    End Sub

    Private Sub DetailsConfirmation_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        'Close the application
        Application.Exit()
    End Sub
End Class