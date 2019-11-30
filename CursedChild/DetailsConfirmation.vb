Public Class DetailsConfirmation
    Private Sub btnReserve_Click(sender As Object, e As EventArgs) Handles btnReserve.Click
        'Show order confirmed form
        OrderConfirmed.Show()
        Me.Hide()
    End Sub
End Class