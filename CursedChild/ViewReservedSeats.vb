Public Class ViewReservedSeats

    'Declare variables
    Dim reservedSeatsFile As String = Application.StartupPath & "/reservedseats.dat"

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

End Class