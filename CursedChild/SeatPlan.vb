Public Class SeatPlan

    Private Sub cmbArea_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbArea.SelectedIndexChanged
        'Change the image
        If cmbArea.Text = "Dress Circle" Then
            picArea.Image = My.Resources.DressCircle
        ElseIf cmbArea.Text = "Upper Circle" Then
            picArea.Image = My.Resources.UpperCircle
        ElseIf cmbArea.Text = "Balcony" Then
            picArea.Image = My.Resources.Balcony
        Else
            picArea.Image = My.Resources.Stalls

        End If
    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        'Return to select seat form
        SelectSeat.Show()
        Me.Hide()
    End Sub

    Private Sub SeatPlan_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cmbArea.Text = "Stalls"
    End Sub

End Class