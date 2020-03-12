Imports System.Text.RegularExpressions

Public Class AddCustomer

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        'Declare variables
        Dim customerFile As String = Application.StartupPath & "/customers.dat"
        Dim recordPos As Integer
        Dim numOfRecords As Integer

        'Validation

        'Length check on phone number
        If Len(txtPhone.Text) <> 11 Then
            MsgBox("Please enter a phone number that has 11 numbers")
            Exit Sub
        End If

        'Lookup check on title
        If cmbTitle.Text <> "Mr." And cmbTitle.Text <> "Mrs." And cmbTitle.Text <> "Miss." And cmbTitle.Text <> "Dr." Then
            MsgBox("Please enter a valid title from the dropdown")
            Exit Sub
        End If

        'Regular expressions check on postcode
        Dim regex As Regex = New Regex("([A-Z]{2})([0-9]{1,2})([0-9]{1})([A-Z]{2})")
        Dim post As String = txtPostcode.Text.ToUpper
        Dim match As Match = regex.Match(post)

        If match.Success Then
        Else
            MsgBox("Please enter a valid postcode")
            Exit Sub
        End If

        Try
            'Open file
            FileOpen(1, customerFile, OpenMode.Random,,, Len(customerRecord))

            'Determine position of next record
            numOfRecords = LOF(1) / Len(customerRecord)
            recordPos = numOfRecords + 1



            'Read in the entered data
            With customerRecord
                .customerID = txtCustID.Text
                .title = cmbTitle.Text
                .firstName = txtFirstName.Text
                .Surname = txtSurname.Text
                .phoneNumber = txtPhone.Text
                .email = txtEmail.Text
                .address = txtAddress.Text
                .Postcode = txtPostcode.Text
            End With

            'Write the record to file
            FilePut(1, customerRecord, recordPos)

            'Close the file
            FileClose(1)

            'Output success message
            MsgBox("Customer successfully added")

            'Update the customerID
            updateCustID()

            'Clear the text boxes
            cmbTitle.Text = ""
            txtFirstName.Text = ""
            txtSurname.Text = ""
            txtPhone.Text = ""
            txtEmail.Text = ""
            txtAddress.Text = ""
            txtPostcode.Text = ""
        Catch ex As Exception
            Dim x As String = ex.ToString
            MsgBox("An error occurred: " & x)
        End Try
    End Sub

    Public Sub AddCustomer_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        updateCustID()
    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        'Open the view customers form
        ViewCustomers.Show()
        Me.Hide()
    End Sub

    Private Sub updateCustID()
        Try
            'Declare variables
            Dim customerFile As String = Application.StartupPath & "/customers.dat"
            Dim recordPos As Integer
            Dim numOfRecords As Integer

            'Open the file
            FileOpen(1, customerFile, OpenMode.Random,,, Len(customerRecord))

            'Determine record position
            numOfRecords = LOF(1) / Len(customerRecord)
            FileGet(1, customerRecord, numOfRecords)
            recordPos = customerRecord.customerID + 1

            If recordPos < 0 Then
                recordPos = Math.Abs(recordPos) + 1
            End If

            'Display customer ID
            txtCustID.Text = recordPos

            'Close the file
            FileClose(1)
        Catch ex As Exception
            Dim x As String = ex.ToString

            MsgBox("An error occurred: " & x)
        End Try

    End Sub

    Private Sub AddCustomer_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        MainMenu.Close()
    End Sub
End Class