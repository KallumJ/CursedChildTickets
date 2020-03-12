Public Class TicketType
    Private Sub btnConsecutive_Click(sender As Object, e As EventArgs) Handles btnConsecutive.Click
        MsgBox("NOT YET IMPLEMENTED, THIS IS A PROTOTYPE")
    End Sub

    Private Sub btnNonConsecutive_Click(sender As Object, e As EventArgs) Handles btnNonConsecutive.Click
        MsgBox("NOT YET IMPLEMENTED, THIS IS A PROTOTYPE")
    End Sub

    Private Sub btnSinglePart_Click(sender As Object, e As EventArgs) Handles btnSinglePart.Click
        'Open show time selection
        Call SelectShowTime.SelectShowTime_Load(Me, e)
        SelectShowTime.Show()
        Me.Hide()
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        'Return to Main Menu
        MainMenu.Show()
        Me.Hide()
    End Sub

    Private Sub TicketType_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        MainMenu.Close()
    End Sub
End Class