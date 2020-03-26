Public Class BasketOverview

    Private Sub btnContinue_Click(sender As Object, e As EventArgs) Handles btnContinue.Click
        
        'Reset the reset timer
        SelectShowTime.reset = 300

        'Open customer entry form
        CustomerDetails.Show()
        Me.Hide()
    End Sub

    Public Sub BasketOverview_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Declare variables
        Dim ticketTxtString As String
        Dim str As String
        Dim seats As String

        'Create seats string
        For Each str In SelectSeat.seat
            seats = seats & ", " & str
        Next

        'Create ticket textboxes string
        ticketTxtString = "Date: " & SelectShowTime.showtimeDateString & vbNewLine
        If TicketType.consecutive <> True Then ticketTxtString = ticketTxtString & "Part: " & SelectShowTime.showtimePart & vbNewLine Else ticketTxtString = ticketTxtString & "Part: 1 & 2" & vbNewLine
        ticketTxtString = ticketTxtString & "Area: " & SelectSeat.area & vbNewLine
        ticketTxtString = ticketTxtString & "Seat(s): " & seats & vbNewLine
        ticketTxtString = ticketTxtString & "Price: " & FormatCurrency(SelectSeat.price) & vbNewLine

        'Add string to basket textbox
        txtBasket.Text = ticketTxtString
    End Sub

    Private Sub btnEditBasket_Click(sender As Object, e As EventArgs) Handles btnEditBasket.Click
        'Return to beginning of booking process
        SelectShowTime.Show()
        Me.Hide()
    End Sub

    Private Sub BasketOverview_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        'Close the application
        Application.Exit()
    End Sub
End Class