Public Class BasketOverview

    Private Sub btnContinue_Click(sender As Object, e As EventArgs) Handles btnContinue.Click
        'Open customer entry form
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
        If Microsoft.VisualBasic.Right(SelectSeat.price, 1) = 5 Then
            ticketTxtString = ticketTxtString & "Price: £" & SelectSeat.price & "0" & vbNewLine
        Else
            ticketTxtString = ticketTxtString & "Price: £" & SelectSeat.price & ".00" & vbNewLine
        End If

        'Add string to basket textbox
        txtBasket.Text = ticketTxtString
    End Sub

    Private Sub btnEditBasket_Click(sender As Object, e As EventArgs) Handles btnEditBasket.Click
        'Return to beginning of booking process
        SelectShowTime.Show()
        Me.Close()
    End Sub

End Class