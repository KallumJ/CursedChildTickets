Public Class MainMenu
    Private Sub btnStaffLogin_Click(sender As Object, e As EventArgs) Handles btnStaffLogin.Click
        'Open staff login form
        StaffLogin.Show()
        Me.Hide()

    End Sub

    Private Sub btnFAQ_Click(sender As Object, e As EventArgs) Handles btnFAQ.Click
        'Open FAQ Form
        FAQ.Show()
        Me.Hide()

    End Sub

    Private Sub btnShowInfo_Click(sender As Object, e As EventArgs) Handles btnShowInfo.Click
        'Open Show Info Form
        ShowInfo.Show()
        Me.Hide()

    End Sub

    Private Sub btnBook_Click(sender As Object, e As EventArgs) Handles btnBook.Click
        'Start ticket booking process
        TicketType.Show()
        Me.Hide()
    End Sub
End Class
