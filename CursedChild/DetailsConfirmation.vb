Public Class DetailsConfirmation
    Private Sub btnReserve_Click(sender As Object, e As EventArgs) Handles btnReserve.Click
        'Show order confirmed form
        OrderConfirmed.Show()
        Me.Hide()
    End Sub

    Private Sub DetailsConfirmation_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Declare variables
        Dim customerFile As String = Application.StartupPath & "/customers.dat"
        Dim numOfRecords As Integer
        Dim txtString As String
        Dim address As String

        txtCustomerDetails.Text = ""

        'Open the file 
        FileOpen(1, customerFile, OpenMode.Random,,, Len(customerRecord))

        'Find the last record added
        numOfRecords = LOF(1) / Len(customerRecord)

        'Read record from file
        FileGet(1, customerRecord, numOfRecords)

        'Create text string to display details
        txtString = "Title: " & customerRecord.title & vbNewLine
        txtString = txtString & "First Name: " & customerRecord.firstName & vbNewLine
        txtString = txtString & "Surname: " & customerRecord.Surname & vbNewLine
        txtString = txtString & "Phone Number: " & customerRecord.phoneNumber & vbNewLine
        txtString = txtString & "Email: " & customerRecord.email & vbNewLine

        'Shorten address string of empty spaces
        address = customerRecord.address
        Do While Microsoft.VisualBasic.Right(address, 1) = " "
            address = Mid(address, 1, Len(address) - 1)
        Loop

        txtString = txtString & "Address: " & address & vbNewLine
        txtString = txtString & "Postcode: " & customerRecord.Postcode & vbNewLine

        'Close the file
        FileClose(1)

        'Add the file to text box
        txtCustomerDetails.Text = txtString

    End Sub
End Class