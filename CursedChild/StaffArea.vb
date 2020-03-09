Public Class StaffArea

    Private Sub btnLogOut_Click(sender As Object, e As EventArgs) Handles btnLogOut.Click
        'Exit the staff area
        MainMenu.Show()
        Me.Close()
    End Sub

    Private Sub btnViewCustomers_Click(sender As Object, e As EventArgs) Handles btnViewCustomers.Click
        'Open the view customers form
        ViewCustomers.Show()
        Me.Close()
    End Sub

    Private Sub btnViewReservations_Click(sender As Object, e As EventArgs) Handles btnViewReservations.Click
        'Open the view reservations form
        ViewReservations.Show()
        Me.Close()
    End Sub

    Private Sub btnViewShowtimes_Click(sender As Object, e As EventArgs) Handles btnViewShowtimes.Click
        'Open the view show times form
        ViewShowTimes.Show()
        Me.Close()
    End Sub

    Private Sub btnViewStaff_Click(sender As Object, e As EventArgs) Handles btnViewStaff.Click
        'Open the view staff form
        ViewStaff.Show()
        Me.Close()
    End Sub

    Private Sub btnViewReseervedSeats_Click(sender As Object, e As EventArgs) Handles btnViewReseervedSeats.Click
        'Open the view reserved seats form
        ViewReservedSeats.Show()
        Me.Close()
    End Sub

    Private Sub btnViewSeatPlan_Click(sender As Object, e As EventArgs) Handles btnViewSeatPlan.Click
        'Open the view seat plan form
        ViewStaffSeatPlan.Show()
        Me.Close()
    End Sub

End Class