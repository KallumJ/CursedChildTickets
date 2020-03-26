Public Class StaffArea

    Private Sub btnLogOut_Click(sender As Object, e As EventArgs) Handles btnLogOut.Click
        'Exit the staff area
        MainMenu.Show()
        Me.Hide()
    End Sub

    Private Sub btnViewCustomers_Click(sender As Object, e As EventArgs) Handles btnViewCustomers.Click
        'Open the view customers form
        Call ViewCustomers.ViewCustomers_Load(Me, e)
        ViewCustomers.Show()
        Me.Hide()
    End Sub

    Private Sub btnViewReservations_Click(sender As Object, e As EventArgs) Handles btnViewReservations.Click
        'Open the view reservations form
        Call ViewReservations.ViewReservations_Load(Me, e)
        ViewReservations.Show()
        Me.Hide()
    End Sub

    Private Sub btnViewShowtimes_Click(sender As Object, e As EventArgs) Handles btnViewShowtimes.Click
        'Open the view show times form
        Call ViewShowTimes.ViewShowTimes_Load(Me, e)
        ViewShowTimes.Show()
        Me.Hide()
    End Sub

    Private Sub btnViewStaff_Click(sender As Object, e As EventArgs) Handles btnViewStaff.Click
        'Open the view staff form
        Call ViewStaff.ViewStaff_Load(Me, e)
        ViewStaff.Show()
        Me.Hide()
    End Sub

    Private Sub btnViewReseervedSeats_Click(sender As Object, e As EventArgs) Handles btnViewReseervedSeats.Click
        'Open the view reserved seats form
        Call ViewReservedSeats.ViewReservedSeats_Load(Me, e)
        ViewReservedSeats.Show()
        Me.Hide()
    End Sub

    Private Sub btnViewSeatPlan_Click(sender As Object, e As EventArgs) Handles btnViewSeatPlan.Click
        'Open the view seat plan form
        ViewStaffSeatPlan.Show()
        Me.Hide()
    End Sub

    Private Sub StaffArea_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Notifications for overdue tickets

        'Declare variables
        Dim reservationsFile As String = Application.StartupPath & "/reservations.dat"
        Dim numOfRecords As Integer
        Dim overdue As New ArrayList

        'Open the file and determine number of records
        FileOpen(1, reservationsFile, OpenMode.Random,,, Len(reservationRecord))
        numOfRecords = LOF(1) / Len(reservationRecord)

        'Read in the records
        For recordPos = 1 To numOfRecords
            FileGet(1, reservationRecord, recordPos)

            'If reservation is before today, and not deleted then
            If Date.Compare(Convert.ToDateTime(reservationRecord.reservationDate), Today) < 0 And Not reservationRecord.reservationID < 0 Then
                'Add the overdue reservation to the list
                overdue.Add(reservationRecord.reservationID)
            End If
        Next

        'Close the file
        FileClose(1)

        'Create string
        Dim str As String
        Dim idString As String

        'Construct the id string
        For Each str In overdue
            If idString = "" Then
                idString = str
            Else
                idString = idString & ", " & str
            End If
        Next

        'Declare label
        Dim label As New Label

        'Set label properties
        label.Text = "Reservations with ID: " & idString & " are overdue."
        label.TextAlign = ContentAlignment.MiddleCenter
        label.Size = New System.Drawing.Size(250, 30)
        label.Location = New System.Drawing.Point(80, 170)

        'Draw label to form
        Me.Controls.Add(label)
    End Sub

    Private Sub StaffArea_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        'Close the application
        Application.Exit()
    End Sub
End Class