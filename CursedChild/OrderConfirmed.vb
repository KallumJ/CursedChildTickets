Public Class OrderConfirmed
    'Declare variables
    Dim timer As Integer

    Private Sub timTimer_Tick(sender As Object, e As EventArgs) Handles timTimer.Tick
        timer = timer - 1

        lblTimer.Text = timer

        If timer < 0 Then
            timTimer.Enabled = False
            MainMenu.Show()
            Me.Hide()
        End If
    End Sub

    Private Sub OrderConfirmed_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        timer = 5
        timTimer.Enabled = True
    End Sub
End Class