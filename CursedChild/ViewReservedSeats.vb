Public Class ViewReservedSeats

    'Declare variables
    Dim reservedSeatsFile As String = Application.StartupPath & "/reservedseats.dat"
    Dim recordPos As Integer

    Private Sub ViewReservedSeats_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        'Declare variables
        Dim numOfRecords As Integer
        Dim listString As String

        'Clear the listbox
        lstResSeats.Items.Clear()

        'Listbox title
        lstResSeats.Items.Add("ReservationID    ShowtimeID  Seats")

        'Open the file
        FileOpen(1, reservedSeatsFile, OpenMode.Random,,, Len(reservedSeatsRecord))

        'Find the number of records
        numOfRecords = LOF(1) / Len(reservedSeatsRecord)

        'read in the records
        For recordPos = 1 To numOfRecords

            FileGet(1, reservedSeatsRecord, recordPos)

            With reservedSeatsRecord
                If .reservationID > 0 Then
                    listString = .reservationID
                    listString = listString & "                           " & .showtimeID
                    listString = listString & "                   " & .seats
                    lstResSeats.Items.Add(listString)
                End If
            End With
        Next

        'Close the file
        FileClose(1)
    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        'Return to staff area
        StaffArea.Show()
        Me.Close()
    End Sub

    Private Sub lstResSeats_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstResSeats.SelectedIndexChanged
        'Declare variables
        Dim NumOfRecordsFound As Integer
        Dim resSeatsString As String
        Dim searchID As Integer

        'Find the selected reservationID
        resSeatsString = lstResSeats.Text
        searchID = Val(Microsoft.VisualBasic.Left(resSeatsString, 10))

        FileOpen(1, reservedSeatsFile, OpenMode.Random,,, Len(reservedSeatsRecord))

        recordPos = 1

        Do While Not EOF(1)
            FileGet(1, reservedSeatsRecord, recordPos)

            'If the record matches the selected record
            If reservedSeatsRecord.reservationID = searchID Then
                NumOfRecordsFound = NumOfRecordsFound + 1

                With reservedSeatsRecord
                    txtResID.Text = .reservationID
                    txtSeats.Text = .seats
                    txtBlock.Text = .block
                    txtShowID.Text = .showtimeID
                End With

                Exit Do

            End If

            'Increment Record
            recordPos = recordPos + 1
        Loop

        'If no records are found, output an error message
        If NumOfRecordsFound = 0 And searchID <> 0 Then
            MsgBox("Reserved seats record with ID " & searchID & " could not be found, please contact your system adminstrator")
        End If

        FileClose(1)
    End Sub

End Class