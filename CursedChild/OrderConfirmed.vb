Public Class OrderConfirmed

    'Declare variables
    Dim timer As Integer

    Private Sub timTimer_Tick(sender As Object, e As EventArgs) Handles timTimer.Tick
        'Decrease timer by 1
        timer = timer - 1

        'Display current timer value
        If Not timer < 0 Then
            lblTimer.Text = timer
        End If

        'If timer reaches 0 then
        If timer < 0 Then
            'Turn off the timer
            timTimer.Enabled = False

            'Return to main menu
            Application.Restart()
        End If
    End Sub

    Private Sub OrderConfirmed_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Set timer value  to 5
        timer = 5

        'Reenable the timer
        timTimer.Enabled = True
    End Sub

    Private Sub OrderConfirmed_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        MainMenu.Close()
    End Sub
End Class