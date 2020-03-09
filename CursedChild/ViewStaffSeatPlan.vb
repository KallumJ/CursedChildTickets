Public Class ViewStaffSeatPlan
    Dim seatsFile As String = Application.StartupPath & "/seats.dat"

    Private Sub cmbArea_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbArea.SelectedIndexChanged
        'Clear the panel
        panSeats.Controls.Clear()
        Dim seat As String
        Dim seatNum As Integer

        If cmbArea.Text = "Stalls" Then

            'Allocate row letter letter
            For i = -1 To 22
                If i = -1 Then
                    seat = "AA"
                ElseIf i = 0 Then
                    seat = "BB"
                Else
                    seat = Convert.ToChar(i + 64)
                End If

                'NO O or U
                If seat <> "O" And seat <> "U" Then

                    For j = 1 To 30
                        'Assign a seat number
                        seatNum = j

                        'Create label for the seats
                        Dim seatLabel As New Label

                        'Name each Seat
                        seatLabel.Name = seat & seatNum
                        seatLabel.Text = seatLabel.Name

                        'Set AutoSize to false
                        seatLabel.AutoSize = False

                        'Set all new seats to price band A
                        seatLabel.BackColor = Color.LightPink
                        seatLabel.ForeColor = Color.White
                        seatLabel.Size = New System.Drawing.Size(35, 20)
                        seatLabel.TextAlign = ContentAlignment.MiddleCenter

                        'Draw to panel
                        seatLabel.Location = New System.Drawing.Point((j * 40) + 5, ((22 - i) * 22) + 5)
                        panSeats.Controls.Add(seatLabel)
                        AddHandler seatLabel.MouseDown, AddressOf ctl_MouseDown
                    Next

                End If
            Next

        ElseIf cmbArea.Text = "Dress Circle" Then

            'Allocate row letter letter
            For i = 1 To 10
                seat = Convert.ToChar(i + 64)

                For j = 1 To 36

                    'Assign a seat number
                    seatNum = j

                    'Create label for the seats
                    Dim seatLabel As New Label

                    'Name each Seat
                    seatLabel.Name = seat & seatNum
                    seatLabel.Text = seatLabel.Name

                    'Set AutoSize to false
                    seatLabel.AutoSize = False

                    'Set all new seats to price band A
                    seatLabel.BackColor = Color.LightPink
                    seatLabel.ForeColor = Color.White
                    seatLabel.Size = New System.Drawing.Size(35, 20)
                    seatLabel.TextAlign = ContentAlignment.MiddleCenter

                    'Draw to panel
                    seatLabel.Location = New System.Drawing.Point((j * 40) + 5, ((22 - i) * 22) + 5)
                    panSeats.Controls.Add(seatLabel)
                    AddHandler seatLabel.MouseDown, AddressOf ctl_MouseDown
                Next
            Next

        ElseIf cmbArea.Text = "Upper Circle" Then

            'Allocate row letter letter
            For i = 1 To 8
                seat = Convert.ToChar(i + 64)

                For j = 1 To 43

                    'Assign a seat number
                    seatNum = j

                    'Create label for the seats
                    Dim seatLabel As New Label

                    'Name each Seat
                    seatLabel.Name = seat & seatNum
                    seatLabel.Text = seatLabel.Name

                    'Set AutoSize to false
                    seatLabel.AutoSize = False

                    'Set all new seats to price band A
                    seatLabel.BackColor = Color.LightPink
                    seatLabel.ForeColor = Color.White
                    seatLabel.Size = New System.Drawing.Size(35, 20)
                    seatLabel.TextAlign = ContentAlignment.MiddleCenter

                    'Draw to panel
                    seatLabel.Location = New System.Drawing.Point((j * 40) + 5, ((22 - i) * 22) + 5)
                    panSeats.Controls.Add(seatLabel)
                    AddHandler seatLabel.MouseDown, AddressOf ctl_MouseDown
                Next
            Next
        Else

            'Allocate row letter letter
            For i = 1 To 14
                seat = Convert.ToChar(i + 64)

                'No I
                If seat <> "I" Then
                    For j = 1 To 28

                        'Assign a seat number
                        seatNum = j

                        'Create label for the seats
                        Dim seatLabel As New Label

                        'Name each Seat
                        seatLabel.Name = seat & seatNum
                        seatLabel.Text = seatLabel.Name

                        'Set AutoSize to false
                        seatLabel.AutoSize = False

                        'Set all new seats to price band A
                        seatLabel.BackColor = Color.LightPink
                        seatLabel.ForeColor = Color.White
                        seatLabel.Size = New System.Drawing.Size(35, 20)
                        seatLabel.TextAlign = ContentAlignment.MiddleCenter

                        'Draw to panel
                        seatLabel.Location = New System.Drawing.Point((j * 40) + 5, ((22 - i) * 22) + 5)
                        panSeats.Controls.Add(seatLabel)
                        AddHandler seatLabel.MouseDown, AddressOf ctl_MouseDown
                    Next
                End If
            Next

        End If

    End Sub

    'Change label colour to indicate priceband
    Public Sub ctl_MouseDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs)
        Dim ctl As Control = sender

        'If right click, set to unavailiable
        If e.Button = Windows.Forms.MouseButtons.Right Then
            ctl.BackColor = Color.Black
        End If

        'If leftclick, change the price band
        If e.Button = Windows.Forms.MouseButtons.Left Then

            If ctl.BackColor = Color.LightPink Then

                ctl.BackColor = Color.Yellow                'Change to price band B

            ElseIf ctl.BackColor = Color.Yellow Then

                ctl.BackColor = Color.Turquoise             'Change to price band C

            ElseIf ctl.BackColor = Color.Turquoise Then

                ctl.BackColor = Color.Orange                'Change to price band D

            ElseIf ctl.BackColor = Color.Orange Then

                ctl.BackColor = Color.DarkBlue              'Change to price band E

            ElseIf ctl.BackColor = Color.DarkBlue Then

                ctl.BackColor = Color.MediumPurple          'Change to price band F

            ElseIf ctl.BackColor = Color.MediumPurple Or ctl.BackColor = Color.Black Then

                ctl.BackColor = Color.LightPink             'Change to price band A

            End If
        End If
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        'Declare variables
        Dim seatsFile As String = Application.StartupPath & "/seats.dat"
        Dim numOfRecords As Integer
        Dim recPos As Integer

        'Open the seats file
        FileOpen(1, seatsFile, OpenMode.Random,,, Len(seatsRecord))

        'Calculate record position
        numOfRecords = LOF(1) / Len(seatsRecord)
        recPos = numOfRecords + 1

        'For each seat
        For Each c In panSeats.Controls
            If TypeOf c Is Label Then
                'Read in the seat name
                seatsRecord.seat = c.name

                'Read in the seat price band
                If c.backcolor = Color.LightPink Then
                    seatsRecord.priceBand = "A"
                ElseIf c.backcolor = Color.Yellow Then
                    seatsRecord.priceBand = "B"
                ElseIf c.backcolor = Color.Turquoise Then
                    seatsRecord.priceBand = "C"
                ElseIf c.backcolor = Color.Orange Then
                    seatsRecord.priceBand = "D"
                ElseIf c.backcolor = Color.DarkBlue Then
                    seatsRecord.priceBand = "E"
                ElseIf c.backcolor = Color.MediumPurple Then
                    seatsRecord.priceBand = "F"
                ElseIf c.backcolor = Color.Black Then
                    seatsRecord.priceBand = "U"
                End If

                'Read in the seat block
                seatsRecord.block = cmbArea.Text
                seatsRecord.xCoOrd = c.Location.X.ToString()
                seatsRecord.yCoOrd = c.Location.Y.ToString()

                'Write the record to the file
                FilePut(1, seatsRecord, recPos)

                recPos = recPos + 1
            End If
        Next

        MsgBox(seatsRecord.xCoOrd)
        MsgBox(seatsRecord.yCoOrd)

        'Close the file
        FileClose(1)
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        'Delete the previous seating plan
        Kill(seatsFile)
        MsgBox("Previous seating plan successfully deleted")
    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        'Open the staff area
        StaffArea.Show()
        Me.Close()
    End Sub

End Class