Public Class ViewCustomers

    'Declare variables
    Dim customerFile As String = Application.StartupPath & "/customers.dat"
    Dim recordPos As Integer

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        'Return to staff area
        StaffArea.Show()
        Me.Hide()
    End Sub

    Public Sub ViewCustomers_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Declare variables
        Dim numOfRecords As Integer
        Dim listString As String

        'Clear the listbox
        lstCustomers.Items.Clear()

        'Listbox title
        lstCustomers.Items.Add("CustomerID      First Name         Surname")

        'Open the file
        FileOpen(1, customerFile, OpenMode.Random,,, Len(customerRecord))

        'Find number of records
        numOfRecords = LOF(1) / Len(customerRecord)

        'Read in records
        For recordPos = 1 To numOfRecords

            FileGet(1, customerRecord, recordPos)

            With customerRecord
                'If customer is not deleted then
                If .customerID > 0 Then
                    'Add details to a string, and add it to a listbox
                    listString = .customerID
                    listString = listString & "                      " & .firstName
                    listString = listString & .Surname
                    lstCustomers.Items.Add(listString)
                End If
            End With

        Next

        'Close the file
        FileClose(1)

    End Sub

    Private Sub lstCustomers_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstCustomers.SelectedIndexChanged
        'Declare variables
        Dim numOfRecordsFound As Integer
        Dim customerString As String
        Dim searchID As Integer

        'Find the selected customer ID
        customerString = lstCustomers.Text
        searchID = Val(Microsoft.VisualBasic.Left(customerString, 10))

        'Open the file
        FileOpen(1, customerFile, OpenMode.Random,,, Len(customerRecord))

        'Read in records from file
        recordPos = 1

        Do While Not EOF(1)
            FileGet(1, customerRecord, recordPos)

            'IF the record matches selected customer
            If customerRecord.customerID = searchID Then
                'Log record found
                numOfRecordsFound = numOfRecordsFound + 1

                'Populate text box with details
                With customerRecord
                    txtCustID.Text = .customerID
                    cmbTitle.Text = .title
                    txtFirstName.Text = .firstName
                    txtSurname.Text = .Surname
                    txtPhone.Text = .phoneNumber
                    txtEmail.Text = .email
                    txtAddress.Text = .address
                    txtPostcode.Text = .Postcode
                End With
                'Leave the loop
                Exit Do
            End If

            'Increment record
            recordPos = recordPos + 1

        Loop

        'If no records are found, output an error
        If numOfRecordsFound = 0 And searchID <> 0 Then
            MsgBox("Customer with ID " & searchID & " could not be found, please contact your system adminstrator")
            FileClose(1)
        End If

        'If the user did not select a record, then clear the fields of the previously selected details
        If searchID = 0 Then
            txtCustID.Text = ""
            cmbTitle.Text = ""
            txtFirstName.Text = ""
            txtSurname.Text = ""
            txtPhone.Text = ""
            txtEmail.Text = ""
            txtAddress.Text = ""
            txtPostcode.Text = ""
        End If

        'Close the file
        FileClose(1)
    End Sub

    Private Sub btnCustAdd_Click(sender As Object, e As EventArgs) Handles btnCustAdd.Click
        'Open the add customer form
        Call AddCustomer.AddCustomer_Load(Me, e)
        AddCustomer.Show()
        Me.Hide()
    End Sub

    Private Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click
        'Read in fields in record
        With customerRecord
            .customerID = Val(txtCustID.Text)
            .title = cmbTitle.Text
            .firstName = txtFirstName.Text
            .Surname = txtSurname.Text
            .phoneNumber = txtPhone.Text
            .email = txtEmail.Text
            .address = txtAddress.Text
            .Postcode = txtPostcode.Text
        End With

        'Open the file
        FileOpen(1, customerFile, OpenMode.Random,,, Len(customerRecord))

        'Write the record to file
        FilePut(1, customerRecord, recordPos)

        'Close the file
        FileClose(1)

        'Clear the fields
        txtCustID.Text = ""
        cmbTitle.Text = ""
        txtFirstName.Text = ""
        txtSurname.Text = ""
        txtPhone.Text = ""
        txtEmail.Text = ""
        txtAddress.Text = ""
        txtPostcode.Text = ""

        'Reload the form
        Call ViewCustomers_Load(Me, e)

    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        'Read in fields in record and make id negative
        With customerRecord
            .customerID = -Val(txtCustID.Text)
            .title = cmbTitle.Text
            .firstName = txtFirstName.Text
            .Surname = txtSurname.Text
            .phoneNumber = txtPhone.Text
            .email = txtEmail.Text
            .address = txtAddress.Text
            .Postcode = txtPostcode.Text
        End With

        'Open the file
        FileOpen(1, customerFile, OpenMode.Random,,, Len(customerRecord))

        'Write the customer record to file
        FilePut(1, customerRecord, recordPos)

        'Close the file
        FileClose(1)

        'Reload the form
        Call ViewCustomers_Load(Me, e)

    End Sub

    Private Sub btnCustSearch_Click(sender As Object, e As EventArgs) Handles btnCustSearch.Click
        'Declare variables
        Dim searchString As String
        Dim listString As String
        Dim numOfRecords As Integer
        Dim numOfRecordsFound As Integer
        Dim firstName As String
        Dim surname As String
        Dim recordPosition As Integer

        'Read in the query
        searchString = txtCustSearch.Text

        'Add up to 20 spaces
        If Len(searchString) < 20 Then
            Do While Len(searchString) < 20
                searchString = searchString & " "
            Loop
        End If

        'Set the record position as 1
        recordPosition = 1

        'Open the file
        FileOpen(1, customerFile, OpenMode.Random,,, Len(customerRecord))

        'Calculate number of records in file
        numOfRecords = LOF(1) / Len(customerRecord)
        recordPos = 1

        'Clear list box
        lstCustomers.Items.Clear()

        'Add list box title
        lstCustomers.Items.Add("CustomerID      First Name         Surname")

        'Read in records
        Do While Not EOF(1)
            FileGet(1, customerRecord, recordPosition)

            'If surname matches the search query then
            If customerRecord.Surname = searchString Then

                'Log record found
                numOfRecordsFound = numOfRecords + 1

                'Shorten the fields
                firstName = customerRecord.firstName
                Do While Microsoft.VisualBasic.Right(firstName, 1) = " "
                    firstName = Mid(firstName, 1, Len(firstName) - 1)
                Loop

                surname = customerRecord.Surname
                Do While Microsoft.VisualBasic.Right(surname, 1) = " "
                    surname = Mid(surname, 1, Len(surname) - 1)
                Loop

                With customerRecord
                    'If customer is not deleted then
                    If .customerID > 0 Then
                        'Add the details to a string and add it to the list box
                        listString = .customerID
                        listString = listString & "                      " & .firstName
                        listString = listString & .Surname
                        lstCustomers.Items.Add(listString)
                    End If
                End With

            End If

            'Incrememnt record position
            recordPosition = recordPosition + 1
        Loop

        'Close the file
        FileClose(1)

        'Output error if customer is not found
        If numOfRecordsFound = 0 Then
            MsgBox("Customer with surname " & searchString & " was not found, please try again.")
        End If
    End Sub

    'Default search text
    Private Sub txtCustSearch_GotFocus(sender As Object, e As EventArgs) Handles txtCustSearch.GotFocus
        'If textbox gains focus, clear the textbox
        If txtCustSearch.Text = "Please enter a surname to search" Then
            txtCustSearch.Text = ""
        End If
    End Sub

    Private Sub txtCustSearch_LostFocus(sender As Object, e As EventArgs) Handles txtCustSearch.LostFocus
        'If the textbox loses focus, repopulate the textbox
        If txtCustSearch.Text = "" Then
            txtCustSearch.Text = "Please enter a surname to search"
        End If
    End Sub

    Private Sub ViewCustomers_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        'Close the application
        Application.Exit()
    End Sub

End Class