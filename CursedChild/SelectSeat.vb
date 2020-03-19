Public Class SelectSeat
    Dim seatsFile As String = Application.StartupPath & "/seats.dat"
    Dim reservedSeatsFile As String = Application.StartupPath & "/reservedseats.dat"
    Public area As String
    Public seat As New ArrayList
    Public price As String
    Dim priceTotal As Decimal
    Dim reserved As New ArrayList
    Dim count As Integer
    Public finalSeat As Boolean

    Private Sub btnContinue_Click(sender As Object, e As EventArgs) Handles btnContinue.Click

        'Validation
        'Presence Check
        If count = 0 Then
            MsgBox("Please select at least one seat")
            Exit Sub
        ElseIf count > 5 Then
            MsgBox("There may only be 5 seats in a reservation")
            Exit Sub
        End If

        'Read in the entered seat details
        area = cmbArea.Text
        price = Str(priceTotal)

        'Reset timer
        SelectShowTime.reset = 300

        'Open the basket overview form
        Call BasketOverview.BasketOverview_Load(Me, e)

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
        Dim reservedSeatsNumOfRecords As Integer

        'Clear the panel
        panSeats.Controls.Clear()

        'Clear saved variables
        seat.Clear()
        priceTotal = 0

        'Display the key
        Dim key As New PictureBox
        key.Image = My.Resources.Key
        key.SizeMode = PictureBoxSizeMode.AutoSize
        key.Location = New System.Drawing.Point(1652, 3)
        panSeats.Controls.Add(key)

        'Open the file
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
                        seatLabel.ForeColor = Color.White
                    ElseIf .priceBand = "B" Then
                        seatLabel.BackColor = Color.Yellow
                        seatLabel.ForeColor = Color.Black
                    ElseIf .priceBand = "C" Then
                        seatLabel.BackColor = Color.Turquoise
                        seatLabel.ForeColor = Color.White
                    ElseIf .priceBand = "D" Then
                        seatLabel.BackColor = Color.Orange
                        seatLabel.ForeColor = Color.White
                    ElseIf .priceBand = "E" Then
                        seatLabel.BackColor = Color.DarkBlue
                        seatLabel.ForeColor = Color.White
                    ElseIf .priceBand = "F" Then
                        seatLabel.BackColor = Color.MediumPurple
                        seatLabel.ForeColor = Color.White
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

                'Open the reserved seats file
                FileOpen(2, reservedSeatsFile, OpenMode.Random,,, Len(reservedSeatsRecord))

                'Determine number of records
                reservedSeatsNumOfRecords = LOF(2) / Len(reservedSeatsRecord)

                'Read in a rerved seats file record
                For reservedSeatsRecordPos = 1 To reservedSeatsNumOfRecords
                    FileGet(2, reservedSeatsRecord, reservedSeatsRecordPos)

                    Dim record As String
                    Dim splitrecord() As String

                    record = reservedSeatsRecord.seats
                    splitrecord = Split(record, "*")

                    'Convert array to array list
                    For i = 0 To splitrecord.Length - 1
                        reserved.Add(splitrecord(i))
                    Next

                    'If seat is the one being drawn, and is reserved during this showtime, in this area then
                    If reserved.Contains(Trim(seatLabel.Name)) = True And Trim(reservedSeatsRecord.showtimeID) = Trim(SelectShowTime.showtimeID) And Trim(reservedSeatsRecord.block) = Trim(cmbArea.Text) And reservedSeatsRecord.reservationID > 0 Then
                        seatLabel.BackColor = Color.Red
                    End If

                    'Clear the arraylist
                    reserved.Clear()
                Next

                'Close the file
                FileClose(2)
            End If
        Next

        'Close the file
        FileClose(1)
    End Sub

    Public Sub ctl_MouseDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs)
        Dim ctl As Control = sender
        Dim numOfRecords As Integer

        numOfRecords = 0

        'Exit if seat is unavailable
        If ctl.BackColor = Color.Red Then
            Exit Sub
        End If

        'If left click, select seat
        If e.Button = Windows.Forms.MouseButtons.Left Then
            ctl.BackColor = Color.LimeGreen
            'Adds selected seat to array list if seat is not already selected
            If seat.Contains(ctl.Name) <> True Then
                seat.Add(ctl.Name)
            End If

            'Open the file
            FileOpen(1, seatsFile, OpenMode.Random,,, Len(seatsRecord))

            'Determine number of records
            numOfRecords = LOF(1) / Len(seatsRecord)

            'read in the seats records
            For recordPos = 1 To numOfRecords
                FileGet(1, seatsRecord, recordPos)

                With seatsRecord
                    'If seat record matches selected seat
                    If Trim(.block) = Trim(cmbArea.Text) And Trim(.seat) = Trim(ctl.Name) Then
                        'Determine price
                        If .priceBand = "A" Then
                            priceTotal = priceTotal + 80
                        ElseIf .priceBand = "B" Then
                            priceTotal = priceTotal + 67.5
                        ElseIf .priceBand = "C" Then
                            priceTotal = priceTotal + 57.5
                        ElseIf .priceBand = "D" Then
                            priceTotal = priceTotal + 42.5
                        ElseIf .priceBand = "E" Then
                            priceTotal = priceTotal + 20
                        ElseIf .priceBand = "F" Then
                            priceTotal = priceTotal + 15
                        End If
                        'Exit for, as seat was found
                        Exit For
                    End If
                End With

            Next

            'Close the file
            FileClose(1)

            'Set count to include new seats
            count = count + 1
        ElseIf e.Button = Windows.Forms.MouseButtons.Right Then
            'Open the file
            FileOpen(1, seatsFile, OpenMode.Random,,, Len(seatsRecord))

            'Determine number of records
            numOfRecords = LOF(1) / Len(seatsRecord)

            For recordPos = 1 To numOfRecords
                FileGet(1, seatsRecord, recordPos)
                With seatsRecord
                    'If seat record matches selected seat
                    If Trim(.block) = Trim(cmbArea.Text) And Trim(.seat) = Trim(ctl.Name) Then
                        'Revert back to previous colour and remove price
                        If .priceBand = "A" Then
                            ctl.BackColor = Color.LightPink
                            priceTotal = priceTotal - 80
                        ElseIf .priceBand = "B" Then
                            ctl.BackColor = Color.Yellow
                            priceTotal = priceTotal - 67.5
                        ElseIf .priceBand = "C" Then
                            ctl.BackColor = Color.Turquoise
                            priceTotal = priceTotal - 57.5
                        ElseIf .priceBand = "D" Then
                            ctl.BackColor = Color.Orange
                            priceTotal = priceTotal - 42.5
                        ElseIf .priceBand = "E" Then
                            ctl.BackColor = Color.DarkBlue
                            priceTotal = priceTotal - 20
                        ElseIf .priceBand = "F" Then
                            ctl.BackColor = Color.MediumPurple
                            priceTotal = priceTotal - 15
                        End If
                        'Exit for, as seat was found
                        Exit For
                    End If
                End With
            Next

            'Close the file
            FileClose(1)

            'Remove seat from array list
            seat.Remove(ctl.Name)

            'Change count of selected seats
            count = count - 1
        End If

    End Sub

    'Choosing best available seat
    Private Sub btnBest_Click(sender As Object, e As EventArgs) Handles btnBest.Click
        Dim seatCtl As Control
        Dim seats As New ArrayList
        Dim priceband As Integer
        Dim bestprice As Integer
        Dim bestseat As String
        Dim numOfRecords As Integer

        'Initalise variables
        seats.Clear()
        priceband = 0
        bestprice = 0
        bestseat = 0
        numOfRecords = 0

        'Error handling
        If cmbArea.Text = "" Then
            MsgBox("Please select an area of the auditorium", MsgBoxStyle.Critical)
            Exit Sub
        End If

        'Create list of booked or selected seats
        For Each seatCtl In panSeats.Controls
            If TypeOf seatCtl Is Label Then
                If seatCtl.BackColor = Color.Red Or seatCtl.BackColor = Color.LimeGreen Then
                    seats.Add(Trim(seatCtl.Name))
                End If
            End If
        Next

        Dim seatsNumOfRecords As Integer
        FileOpen(1, seatsFile, OpenMode.Random,,, Len(seatsRecord))
        seatsNumOfRecords = LOF(1) / Len(seatsRecord)

        For seatsRecordPos = 1 To seatsNumOfRecords
            FileGet(1, seatsRecord, seatsRecordPos)

            'Parse priceband to a number
            With seatsRecord
                If .priceBand = "A" Then
                    priceband = 6
                ElseIf .priceBand = "B" Then
                    priceband = 5
                ElseIf .priceBand = "C" Then
                    priceband = 4
                ElseIf .priceBand = "D" Then
                    priceband = 3
                ElseIf .priceBand = "E" Then
                    priceband = 2
                ElseIf .priceBand = "F" Then
                    priceband = 1
                End If

                'Record best seat, if price is bigger than previously record, and in the right block, and is not booked
                If bestprice < priceband And Trim(cmbArea.Text) = Trim(.block) And seats.Contains(Trim(.seat)) <> True Then
                    bestseat = .seat
                    bestprice = priceband
                End If
            End With

        Next

        FileClose(1)

        'Select seat
        For Each ctl In panSeats.Controls
            If TypeOf ctl Is Label Then
                'If label being checked is the seat that was found
                If Trim(ctl.Name) = Trim(bestseat) Then
                    ctl.BackColor = Color.LimeGreen
                    'Adds selected seat to array list if seat is not already selected
                    If seat.Contains(ctl.Name) <> True Then
                        seat.Add(ctl.Name)
                    End If

                    'Open the file
                    FileOpen(1, seatsFile, OpenMode.Random,,, Len(seatsRecord))

                    'Determine number of records
                    numOfRecords = LOF(1) / Len(seatsRecord)

                    'read in the seats records
                    For recordPos = 1 To numOfRecords
                        FileGet(1, seatsRecord, recordPos)

                        With seatsRecord
                            'If seat record matches selected seat
                            If Trim(.block) = Trim(cmbArea.Text) And Trim(.seat) = Trim(ctl.Name) Then
                                'Determine price
                                If .priceBand = "A" Then
                                    priceTotal = priceTotal + 80
                                ElseIf .priceBand = "B" Then
                                    priceTotal = priceTotal + 67.5
                                ElseIf .priceBand = "C" Then
                                    priceTotal = priceTotal + 57.5
                                ElseIf .priceBand = "D" Then
                                    priceTotal = priceTotal + 42.5
                                ElseIf .priceBand = "E" Then
                                    priceTotal = priceTotal + 20
                                ElseIf .priceBand = "F" Then
                                    priceTotal = priceTotal + 15
                                End If
                                'Exit for, as seat was found
                                Exit For
                            End If
                        End With

                    Next

                    'Close the file
                    FileClose(1)

                    'Set count to include new seats
                    count = count + 1
                End If
            End If
        Next

    End Sub

    Private Sub SelectSeat_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        Application.Exit()
    End Sub
End Class