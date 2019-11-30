Public Class BasketOverview
    Private Sub btnContinue_Click(sender As Object, e As EventArgs) Handles btnContinue.Click
        'Open customer entry form
        CustomerDetails.Show()
        Me.Hide()
    End Sub
End Class