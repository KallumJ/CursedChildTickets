Public Class DetailsConfirmation
    Private Sub btnReserve_Click(sender As Object, e As EventArgs) Handles btnReserve.Click
        'Save entered customer details to file
        Try
            'Declare variables
            Dim customerFile As String = Application.StartupPath & "/customers.dat"
            Dim recordPos As Integer
            Dim numOfRecords As Integer

            'Open the file
            FileOpen(1, customerFile, OpenMode.Random,,, Len(customerRecord))

            'Determine record position
            numOfRecords = LOF(1) / Len(customerRecord)
            recordPos = numOfRecords + 1

            'Read in the entered data
            With customerRecord
                .customerID = recordPos
                .title = CustomerDetails.title
                .firstName = CustomerDetails.firstName
                .Surname = CustomerDetails.surname
                .phoneNumber = CustomerDetails.phone
                .email = CustomerDetails.email
                .address = CustomerDetails.address
                .Postcode = CustomerDetails.postcode
            End With

            'Write the record to file
            FilePut(1, customerRecord, recordPos)

            'Close the file
            FileClose(1)

            'Show order confirmed form
            OrderConfirmed.Show()
            Me.Hide()

        Catch ex As Exception
            'Make the exce
            Dim x As String

            x = ex.ToString()

            MsgBox("An error occured: " & x & ". Please contact a system administrator.")
        End Try

    End Sub

    Private Sub DetailsConfirmation_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Declare variables
        Dim txtString As String

        'Clear the text box
        txtCustomerDetails.Text = ""

        'Create text string to display details
        txtString = "Title: " & CustomerDetails.title & vbNewLine
        txtString = txtString & "First Name: " & CustomerDetails.firstName & vbNewLine
        txtString = txtString & "Surname: " & CustomerDetails.surname & vbNewLine
        txtString = txtString & "Phone Number: " & CustomerDetails.phone & vbNewLine
        txtString = txtString & "Email: " & CustomerDetails.email & vbNewLine
        txtString = txtString & "Address: " & CustomerDetails.address & vbNewLine
        txtString = txtString & "Postcode: " & CustomerDetails.postcode & vbNewLine

        'Add the file to text box
        txtCustomerDetails.Text = txtString

    End Sub
End Class