Public Class CustomerDetails
    Private Sub btnContinue_Click(sender As Object, e As EventArgs) Handles btnContinue.Click
        'Declare variables
        Dim customerFile As String = Application.StartupPath & "/customers.dat"
        Dim recordPos As Integer
        Dim numOfRecords As Integer

        Try

            'Open the file
            FileOpen(1, customerFile, OpenMode.Random,,, Len(customerRecord))

            'Determine record position
            numOfRecords = LOF(1) / Len(customerRecord)
            recordPos = numOfRecords + 1

            'Read in the entered data
            With customerRecord
                .customerID = recordPos
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

            'Clear the file
            cmbTitle.Text = ""
            txtFirstName.Text = ""
            txtSurname.Text = ""
            txtPhone.Text = ""
            txtEmail.Text = ""
            txtAddress.Text = ""
            txtPostcode.Text = ""

            'Open the details confirmation form
            DetailsConfirmation.Show()
            Me.Hide()


        Catch ex As Exception
            'Make the exce
            Dim x As String

            x = ex.ToString()

            MsgBox("An error occured: " & x & ". Please contact a system administrator.")
        End Try
    End Sub

End Class