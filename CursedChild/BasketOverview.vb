Public Class BasketOverview

    Private Sub btnContinue_Click(sender As Object, e As EventArgs) Handles btnContinue.Click
        'Open customer entry form
        SelectShowTime.reset = 300
        CustomerDetails.Show()
        Me.Hide()
    End Sub

    Private Sub BasketOverview_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim ticketTxtString As String
        Dim str As String
        Dim seats As String

        For Each str In SelectSeat.seat
            seats = seats & ", " & str
        Next

        'Clear the tickets text box
        ticketTxtString = "Date: " & SelectShowTime.showtimeDateString & vbNewLine
        ticketTxtString = ticketTxtString & "Part: " & SelectShowTime.showtimePart & vbNewLine
        ticketTxtString = ticketTxtString & "Area: " & SelectSeat.area & vbNewLine
        ticketTxtString = ticketTxtString & "Seat(s): " & seats & vbNewLine
        ticketTxtString = ticketTxtString & "Price: " & FormatCurrency(SelectSeat.price) & vbNewLine

        'Add string to basket textbox
        txtBasket.Text = ticketTxtString
    End Sub

    Private Sub btnEditBasket_Click(sender As Object, e As EventArgs) Handles btnEditBasket.Click
        'Return to beginning of booking process
        SelectShowTime.Show()
        Me.Close()
    End Sub

End Class