Public Class CustomerDetails
    Private Sub btnContinue_Click(sender As Object, e As EventArgs) Handles btnContinue.Click
        'Open the details confirmation form
        DetailsConfirmation.Show()
        Me.Hide()
    End Sub
End Class