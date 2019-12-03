Public Class CustomerDetails

    Public title As String
    Public firstName As String
    Public surname As String
    Public phone As String
    Public email As String
    Public address As String
    Public postcode As String

    Private Sub btnContinue_Click(sender As Object, e As EventArgs) Handles btnContinue.Click

        'Save customer details
        title = cmbTitle.Text
        firstName = txtFirstName.Text
        surname = txtSurname.Text
        phone = txtPhone.Text
        email = txtEmail.Text
        address = txtAddress.Text
        postcode = txtPostcode.Text

    End Sub

End Class