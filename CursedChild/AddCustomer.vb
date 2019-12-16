Public Class AddCustomer
    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        'Declare variables
        Dim customerFile As String = Application.StartupPath & "/customers.dat"
        Dim recordPos As Integer
        Dim numOfRecords As Integer

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

    Private Sub AddCustomer_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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
            recordPos = numOfRecords + 1

            'Display customer ID
            txtCustID.Text = recordPos

            'Close the file
            FileClose(1)
        Catch ex As Exception
            Dim x As String = ex.ToString

            MsgBox("An error occurred: " & x)
        End Try

    End Sub
End Class