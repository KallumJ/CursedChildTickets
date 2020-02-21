Public Class TicketType
    Private Sub btnConsecutive_Click(sender As Object, e As EventArgs) Handles btnConsecutive.Click
        MsgBox("NOT YET IMPLEMENTED, THIS IS A PROTOTYPE")
    End Sub

    Private Sub btnNonConsecutive_Click(sender As Object, e As EventArgs) Handles btnNonConsecutive.Click
        MsgBox("NOT YET IMPLEMENTED, THIS IS A PROTOTYPE")
    End Sub

    Private Sub btnSinglePart_Click(sender As Object, e As EventArgs) Handles btnSinglePart.Click
        'Open show time selection
        SelectShowTime.Show()
        Me.Close()
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        'Return to Main Menu
        MainMenu.Show()
        Me.Close()
    End Sub
End Class