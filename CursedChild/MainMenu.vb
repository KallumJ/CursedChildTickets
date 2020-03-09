Public Class MainMenu
    Private Sub btnStaffLogin_Click(sender As Object, e As EventArgs) Handles btnStaffLogin.Click
        'Open staff login form
        StaffLogin.Show()
        Me.Hide()

    End Sub

    Private Sub btnFAQ_Click(sender As Object, e As EventArgs) Handles btnFAQ.Click

        'Open FAQ Form
        FAQ.Show()
        Me.Hide()

    End Sub

    Private Sub btnShowInfo_Click(sender As Object, e As EventArgs) Handles btnShowInfo.Click

        'Open Show Info Form
        ShowInfo.Show()
        Me.Hide()

    End Sub

    Private Sub btnBook_Click(sender As Object, e As EventArgs) Handles btnBook.Click
        'Start ticket booking process
        TicketType.Show()
        Me.Hide()
    End Sub

    Private Sub MainMenu_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Autoplay video on form load
        AxWindowsMediaPlayer1.uiMode = "none"
        AxWindowsMediaPlayer1.URL = "D:\Subjects\Computer Science\A2 Computer Science\Unit 5\Implementation\CursedChildTickets\CursedChild\Resources\Trailer.mp4"
        AxWindowsMediaPlayer1.settings.setMode("loop", True)
        AxWindowsMediaPlayer1.settings.mute = True

        'Housekeeping routines
        Dim custNumOfRecords As Integer
        Dim newCustRecordPos As Integer
        Dim showNumOfRecords As Integer
        Dim newShowRecordPos As Integer
        Dim resNumOfRecords As Integer
        Dim newResRecordPos As Integer
        Dim seatsNumOfRecords As Integer
        Dim newSeatsRecordPos As Integer
        Dim usersNumOfRecords As Integer
        Dim newUserRecordPos As Integer

        'File paths
        Dim customersFile As String = Application.StartupPath & "/customers.dat"
        Dim oldCustomersFile As String = Application.StartupPath & "/oldcustomers.dat"
        Dim newCustomersFile As String = Application.StartupPath & "/newcustomers.dat"

        Dim showtimesFile As String = Application.StartupPath & "/showtimes.dat"
        Dim oldShowtimesFile As String = Application.StartupPath & "/oldshowtimes.dat"
        Dim newShowtimesFile As String = Application.StartupPath & "/newshowtimes.dat"

        Dim reservationsFile As String = Application.StartupPath & "/reservations.dat"
        Dim oldReservationsFile As String = Application.StartupPath & "/oldreservations.dat"
        Dim newReservationsFile As String = Application.StartupPath & "/newreservations.dat"

        Dim reservedSeatsFile As String = Application.StartupPath & "/reservedseats.dat"
        Dim oldReservedSeatsFile As String = Application.StartupPath & "/oldreservedseats.dat"
        Dim newReservedSeatsFile As String = Application.StartupPath & "/newreservedseats.dat"

        Dim userFile As String = Application.StartupPath & "/users.dat"
        Dim oldUserFile As String = Application.StartupPath & "/oldusers.dat"
        Dim newUserFile As String = Application.StartupPath & "/newusers.dat"

        'Customer routine
        Try
            If Dir(customersFile) <> "" Then
                FileOpen(1, customersFile, OpenMode.Random,,, Len(customerRecord))

                custNumOfRecords = LOF(1) / Len(customerRecord)

                For custRecordPos = 1 To custNumOfRecords
                    FileGet(1, customerRecord, custRecordPos)

                    With customerRecord
                        'If customer is not deleted, write to new file
                        If Val(.customerID) > 0 Then
                            FileOpen(2, newCustomersFile, OpenMode.Random,,, Len(customerRecord))

                            newCustRecordPos = LOF(2) / Len(customerRecord) + 1

                            FilePut(2, customerRecord, newCustRecordPos)

                            FileClose(2)
                        End If
                    End With
                Next
                FileClose(1)

                'Archive old file
                If Dir(oldCustomersFile) <> "" Then
                    Kill(oldCustomersFile)
                End If
                Rename(customersFile, oldCustomersFile)

                'Make new file, current file
                If Dir(customersFile) <> "" Then
                    Kill(customersFile)
                End If
                Rename(newCustomersFile, customersFile)

            End If

        Catch ex As Exception
            MsgBox(ex.ToString & " Please contact a system administrator.")
        End Try

        'Showtime routine
        Try
            If Dir(showtimesFile) <> "" Then
                FileOpen(1, showtimesFile, OpenMode.Random,,, Len(showtimeRecord))

                showNumOfRecords = LOF(1) / Len(showtimeRecord)

                For showRecordPos = 1 To showNumOfRecords
                    FileGet(1, showtimeRecord, showRecordPos)

                    With showtimeRecord
                        If Val(.showtimeID) > 0 Then
                            FileOpen(2, newShowtimesFile, OpenMode.Random,,, Len(showtimeRecord))

                            newShowRecordPos = LOF(2) / Len(showtimeRecord) + 1

                            FilePut(2, showtimeRecord, newShowRecordPos)

                            FileClose(2)
                        End If
                    End With
                Next
                FileClose(1)

                'Archive old file
                If Dir(oldShowtimesFile) <> "" Then
                    Kill(oldShowtimesFile)
                End If
                Rename(showtimesFile, oldShowtimesFile)

                'Make new file, current file
                If Dir(showtimesFile) <> "" Then
                    Kill(showtimesFile)
                End If
                Rename(newShowtimesFile, showtimesFile)

            End If
        Catch ex As Exception
            MsgBox(ex.ToString & " Please contact a system administrator.")
        End Try

        'Reservations Routine
        Try
            If Dir(reservationsFile) <> "" Then
                FileOpen(1, reservationsFile, OpenMode.Random,,, Len(reservationRecord))

                resNumOfRecords = LOF(1) / Len(reservationRecord)

                For resRecordPos = 1 To resNumOfRecords
                    FileGet(1, reservationRecord, resRecordPos)

                    With reservationRecord
                        If Val(.reservationID) > 0 Then
                            FileOpen(2, newReservationsFile, OpenMode.Random,,, Len(reservationRecord))

                            newResRecordPos = LOF(2) / Len(reservationRecord) + 1

                            FilePut(2, reservationRecord, newResRecordPos)

                            FileClose(2)
                        End If
                    End With
                Next
                FileClose(1)

                'Archive the old file
                If Dir(oldReservationsFile) <> "" Then
                    Kill(oldReservationsFile)
                End If
                Rename(reservationsFile, oldReservationsFile)

                'Make new file, current file
                If Dir(reservationsFile) <> "" Then
                    Kill(reservationsFile)
                End If
                Rename(newReservationsFile, reservationsFile)
            End If

        Catch ex As Exception
            MsgBox(ex.ToString & " Please contact a system administrator.")
        End Try

        'Reserved seats file routine
        Try
            If Dir(reservedSeatsFile) <> "" Then
                FileOpen(1, reservedSeatsFile, OpenMode.Random,,, Len(reservedSeatsRecord))

                seatsNumOfRecords = LOF(1) / Len(reservedSeatsRecord)

                For seatsRecordPos = 1 To seatsNumOfRecords
                    FileGet(1, reservedSeatsRecord, seatsRecordPos)

                    With reservedSeatsRecord
                        If Val(.reservationID) > 0 Then
                            FileOpen(2, newReservedSeatsFile, OpenMode.Random,,, Len(reservedSeatsRecord))

                            newSeatsRecordPos = LOF(2) / Len(reservedSeatsRecord) + 1

                            FilePut(2, reservedSeatsRecord, newSeatsRecordPos)

                            FileClose(2)
                        End If
                    End With
                Next
                FileClose(1)

                'Archive the old file
                If Dir(oldReservedSeatsFile) <> "" Then
                    Kill(oldReservedSeatsFile)
                End If
                Rename(reservedSeatsFile, oldReservedSeatsFile)

                'Make new file, current file
                If Dir(reservedSeatsFile) <> "" Then
                    Kill(reservedSeatsFile)
                End If
                Rename(newReservedSeatsFile, reservedSeatsFile)
            End If
        Catch ex As Exception
            MsgBox(ex.ToString & " Please contact a system administrator.")
        End Try

        'Users routine
        Try
            If Dir(userFile) <> "" Then
                FileOpen(1, userFile, OpenMode.Random,,, Len(userRecord))

                usersNumOfRecords = LOF(1) / Len(userRecord)

                For userRecordPos = 1 To usersNumOfRecords
                    FileGet(1, userRecord, userRecordPos)

                    With userRecord
                        If Val(.staffID) > 0 Then
                            FileOpen(2, newUserFile, OpenMode.Random,,, Len(userRecord))

                            newUserRecordPos = LOF(2) / Len(userRecord) + 1

                            FilePut(2, userRecord, newUserRecordPos)

                            FileClose(2)
                        End If
                    End With
                Next
                FileClose(1)

                'Archive old file
                If Dir(oldUserFile) <> "" Then
                    Kill(oldUserFile)
                End If
                Rename(userFile, oldUserFile)

                'Make new file, current file
                If Dir(userFile) <> "" Then
                    Kill(userFile)
                End If
                Rename(newUserFile, userFile)
            End If

        Catch ex As Exception
            MsgBox(ex.ToString & " Please contact a system administrator.")
        End Try
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)
        Try


            MsgBox("Success")
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub
End Class
