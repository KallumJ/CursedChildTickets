Public Class TicketType
    'Declare variables
    Public consecutive As Boolean
    Public nonConsecutive As Boolean


    Private Sub btnConsecutive_Click(sender As Object, e As EventArgs) Handles btnConsecutive.Click
        'Open show time selection
        consecutive = True
        Call SelectShowTime.SelectShowTime_Load(Me, e)
        SelectShowTime.Show()
        Me.Hide()
    End Sub

    Private Sub btnNonConsecutive_Click(sender As Object, e As EventArgs) Handles btnNonConsecutive.Click
        'Open show time selection
        nonConsecutive = True
        Call SelectShowTime.SelectShowTime_Load(Me, e)
        SelectShowTime.Show()
        Me.Hide()
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
        'Close the form
        Application.Exit()
    End Sub

    Private Sub TicketType_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Set the system to normal mode
        consecutive = False
        nonConsecutive = False
    End Sub
End Class