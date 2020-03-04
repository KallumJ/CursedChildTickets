Public Class SelectSeat
    Dim seatsFile As String = Application.StartupPath & "/seats.dat"
    Public area As String
    Public seat As String
    Public price As String

    Private Sub btnViewSeatPlan_Click(sender As Object, e As EventArgs)
        'Open seating plan
        SeatPlan.Show()
        Me.Hide()
    End Sub

    Private Sub btnContinue_Click(sender As Object, e As EventArgs)

        'Read in the entered seat details
        'seat = cmbRow.Text & cmbSeat.Text
        'area = cmbArea.Text

        'Determine seat price
        If area = "Stalls" Or area = "Dress Circle" Then
            price = 65
        ElseIf area = "Grand Circle" Then
            price = 50
        Else
            price = 30
        End If

        'Open the basket overview form
        BasketOverview.Show()
        Me.Hide()
    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        'Return to select showtime
        SelectShowTime.Show()
        Me.Close()
    End Sub

    Private Sub cmbArea_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbArea.SelectedIndexChanged
        'Declare variables
        Dim numOfRecords As Integer

        'Clear the panel
        panSeats.Controls.Clear()

        FileOpen(1, seatsFile, OpenMode.Random,,, Len(seatsRecord))

        'Determine number of records
        numOfRecords = LOF(1) / Len(seatsRecord)

        For recordPos = 1 To numOfRecords
            'Read in new seat
            FileGet(1, seatsRecord, recordPos)

            'If seat is in the selected area
            If Trim(cmbArea.Text) = Trim(seatsRecord.block) Then

                'Create label
                Dim seatLabel As New Label

                'Set label properties
                seatLabel.Name = seatsRecord.seat
                seatLabel.Text = seatsRecord.seat
                seatLabel.AutoSize = False
                seatLabel.ForeColor = Color.White
                seatLabel.Size = New System.Drawing.Size(35, 20)
                seatLabel.TextAlign = ContentAlignment.MiddleCenter


                'Determine label colour
                With seatsRecord
                    If .priceBand = "A" Then
                        seatLabel.BackColor = Color.LightPink
                    ElseIf .priceBand = "B" Then
                        seatLabel.BackColor = Color.Yellow
                    ElseIf .priceBand = "C" Then
                        seatLabel.BackColor = Color.Turquoise
                    ElseIf .priceBand = "D" Then
                        seatLabel.BackColor = Color.Orange
                    ElseIf .priceBand = "E" Then
                        seatLabel.BackColor = Color.DarkBlue
                    ElseIf .priceBand = "F" Then
                        seatLabel.BackColor = Color.MediumPurple
                    End If
                End With

                'Draw to panel
                seatLabel.Location = New System.Drawing.Point(seatsRecord.xCoOrd, seatsRecord.yCoOrd)
                panSeats.Controls.Add(seatLabel)
                AddHandler seatLabel.MouseDown, AddressOf ctl_MouseDown

                'Hide seats that were set to black when creating the seating plan
                If seatsRecord.priceBand = "U" Then
                    seatLabel.Visible = False
                End If

            End If
        Next

        MsgBox(seatsRecord.xCoOrd)
        MsgBox(seatsRecord.yCoOrd)

        'Close the file
        FileClose(1)
    End Sub

    Public Sub ctl_MouseDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs)
        Dim ctl As Control = sender

        'If left click, select seat
        If e.Button = Windows.Forms.MouseButtons.Left Then
            ctl.BackColor = Color.LimeGreen
        End If

    End Sub
End Class