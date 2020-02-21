Public Class SelectSeat

    Public area As String
    Public seat As String
    Public price As String

    Private Sub btnViewSeatPlan_Click(sender As Object, e As EventArgs) Handles btnViewSeatPlan.Click
        'Open seating plan
        SeatPlan.Show()
        Me.Hide()
    End Sub

    Private Sub btnContinue_Click(sender As Object, e As EventArgs) Handles btnContinue.Click

        'Read in the entered seat details
        seat = cmbRow.Text & cmbSeat.Text
        area = cmbArea.Text

        'Determine seat price
        If area = "Stalls" Or area = "Dress Circle" Then
            price = 65
        ElseIf area = "Grand Circle" Then
            price = 50
        Else
            price = 30
        End If

        'Open the basket overview form
        BasketOverview.Show()
        Me.Hide()
    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        'Return to select showtime
        SelectShowTime.Show()
        Me.Close()
    End Sub
End Class