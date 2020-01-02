Public Class ViewShowTimes
    Private Sub btnShowAdd_Click(sender As Object, e As EventArgs) Handles btnShowAdd.Click
        AddShowTimes.Show()
        Me.Close()
    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        StaffArea.Show()
        Me.Close()
    End Sub
End Class