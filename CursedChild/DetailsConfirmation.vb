Public Class DetailsConfirmation
    Private Sub btnReserve_Click(sender As Object, e As EventArgs) Handles btnReserve.Click
        'Declare variables
        Dim customerFile As String = Application.StartupPath & "/customers.dat"
        Dim custRecordPos As Integer
        Dim custNumOfRecords As Integer
        Dim reservationsFile As String = Application.StartupPath & "/reservations.dat"
        Dim resRecordPos As Integer
        Dim resNumOfRecords As Integer

        'Save entered customer details to file
        Try

            'Open the file
            FileOpen(1, customerFile, OpenMode.Random,,, Len(customerRecord))

            'Determine record position
            custNumOfRecords = LOF(1) / Len(customerRecord)
            custRecordPos = custNumOfRecords + 1

            'Read in the entered data
            With customerRecord
                .customerID = custRecordPos
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
            'Make the exce
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

            'Read in reservation data
            With reservationRecord
                .reservationID = resRecordPos
                .customerID = custRecordPos
                .showtimeID = SelectShowTime.showtimeID
                .reservationDate = SelectShowTime.showtimeDate
                .totalPrice = SelectSeat.price
            End With

            'Write the record to file
            FilePut(1, reservationRecord, resRecordPos)

            'Close the file
            FileClose(1)

            'Open order confirmation
            OrderConfirmed.Show()
            Me.Close()

        Catch ex As Exception
            Dim x As String

            x = ex.ToString

            MsgBox("An error occured: " & x & ". Please contact a system administrator.")
        End Try
    End Sub

    Private Sub DetailsConfirmation_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Declare variables
        Dim custTxtString As String
        Dim ticketTxtString As String

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

        'Clear the tickets text box
        ticketTxtString = "Date: " & SelectShowTime.showtimeDateString & vbNewLine
        ticketTxtString = ticketTxtString & "Part: " & SelectShowTime.showtimePart & vbNewLine
        ticketTxtString = ticketTxtString & "Area: " & SelectSeat.area & vbNewLine
        'ticketTxtString = ticketTxtString & "Seat: " & SelectSeat.seat & vbNewLine

        lblTotal.Text = "Total: £" & SelectSeat.price & ".00"

        'Add the details to the text box
        txtTicketDetails.Text = ticketTxtString


    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        'Return to selecting showtime
        SelectShowTime.Show()
        Me.Close()
    End Sub
End Class