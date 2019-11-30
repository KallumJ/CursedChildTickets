Public Class SelectSeat
    Private Sub btnViewSeatPlan_Click(sender As Object, e As EventArgs) Handles btnViewSeatPlan.Click
        'Open seating plan
        SeatPlan.Show()
        Me.Hide()
    End Sub

    Private Sub btnContinue_Click(sender As Object, e As EventArgs) Handles btnContinue.Click
        'Open the basket overview form
        BasketOverview.Show()
        Me.Hide()
    End Sub
End Class