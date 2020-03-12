Public Class FAQ
    Private Sub cmbQuestion_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbQuestion.SelectedIndexChanged

        'Display the appropriate answer to the selected question
        If cmbQuestion.Text = "How much do tickets cost?" Then
            txtAnswer.Text = "Tickets are on sale until 24 January 2021 and are currently priced at £15, £20, £42.50, £57.50, £67.50, £75 or £80 if bought separately; £30, £40, £85, £115, £135, £150 or £160 for a seat for both Part One and Part Two of the play."
        ElseIf cmbQuestion.Text = "What happens if I need to return or cancel my tickets?" Then
            txtAnswer.Text = "All tickets purchased on or after 1 August 2018 are non-refundable. However, please do contact us if circumstances mean you are unable to attend and they will endeavour to assist you where possible."
        ElseIf cmbQuestion.Text = "Are there discounts available for groups and schools?" Then
            txtAnswer.Text = "Discounts for groups and schools are not currently available."
        ElseIf cmbQuestion.Text = "Why is it in two parts?" Then
            txtAnswer.Text = "This new play presents the eighth story in the Harry Potter series. Because of the epic nature of the story it could not fit into the performance time of a traditional single play and consequently will be told in two Parts."
        ElseIf cmbQuestion.Text = "What is the running time for the play?" Then
            txtAnswer.Text = "Part One, 2 hours and 40 minutes (incl 20 min interval) Part Two, 2 hours and 35 minutes (incl 20 min interval)"
        Else
            txtAnswer.Text = "Due to annual leave requirements in the UK, some cast members may differ between parts if you have not booked consecutive performances of Part One and Part Two within the same week. Please also note that the appearance of any particular cast member cannot be guaranteed in the unforeseen event of illness or other circumstances beyond our control."
        End If

    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        'Return to the Main Menu
        MainMenu.Show()
        Me.Hide()
    End Sub

    Private Sub FAQ_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        MainMenu.Close()
    End Sub
End Class