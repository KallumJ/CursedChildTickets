Public Class MainMenu
    Private Sub btnStaffLogin_Click(sender As Object, e As EventArgs) Handles btnStaffLogin.Click
        'Open staff login form
        StaffLogin.Show()
        Me.Hide()

    End Sub

    Private Sub btnFAQ_Click(sender As Object, e As EventArgs) Handles btnFAQ.Click
        MsgBox("PROTOTYPE, NOT YET IMPLEMENTED")

        'Open FAQ Form
        'FAQ.Show()
        'Me.Hide()

    End Sub

    Private Sub btnShowInfo_Click(sender As Object, e As EventArgs) Handles btnShowInfo.Click
        MsgBox("PROTOTYPE, NOT YET IMPLEMENTED")

        'Open Show Info Form
        'ShowInfo.Show()
        'Me.Hide()

    End Sub

    Private Sub btnBook_Click(sender As Object, e As EventArgs) Handles btnBook.Click
        'Start ticket booking process
        TicketType.Show()
        Me.Hide()
    End Sub

    Private Sub MainMenu_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Autoplay video on form load
        AxWindowsMediaPlayer1.uiMode = "none"
        AxWindowsMediaPlayer1.URL = "D:\Subjects\Computer Science\A2 Computer Science\Unit 5\Implementation\CursedChildTickets\CursedChild\Resources\Trailer.mp4"
        AxWindowsMediaPlayer1.settings.setMode("loop", True)
        AxWindowsMediaPlayer1.settings.mute = True
    End Sub

End Class
