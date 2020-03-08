﻿Public Class AddStaff
    'Declare variables
    Dim userFile As String = Application.StartupPath & "/users.dat"
    Dim score As Integer
    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        'Declare variable
        Dim numOfRecords As Integer
        Dim recordPos As Integer

        'Validation

        'Double keying on password
        If txtPassword.Text <> txtConfirmPassword.Text Then
            MsgBox("The two passwords entered must match")
            Exit Sub
        End If

        'Open the file
        FileOpen(1, userFile, OpenMode.Random,,, Len(userRecord))

        'Determine poisition of the next record
        numOfRecords = LOF(1) / Len(userRecord)
        recordPos = numOfRecords + 1

        'Read in the entered data
        With userRecord
            .staffID = txtStaffID.Text
            .username = txtUsername.Text
            .password = txtPassword.Text
        End With

        'Write the record to file
        FilePut(1, userRecord, recordPos)

        'Close the file
        FileClose(1)

        'Output success message
        MsgBox("User successfully added")

        'Update the staff ID
        updateStaffID()

        'Clear the text boxes
        txtUsername.Text = ""
        txtPassword.Text = ""
        txtConfirmPassword.Text = ""
    End Sub

    Private Sub updateStaffID()
        'Declare variables
        Dim numOfrecords As Integer
        Dim recordPos As Integer

        'Open the file
        FileOpen(1, userFile, OpenMode.Random,,, Len(userRecord))

        'Determine record position
        numOfrecords = LOF(1) / Len(userRecord)
        recordPos = numOfrecords + 1

        'Display staff ID
        txtStaffID.Text = recordPos

        'Close the file
        FileClose(1)

    End Sub

    Private Sub AddStaff_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        updateStaffID()
    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        'Return to View Staff form
        ViewStaff.Show()
        Me.Close()
    End Sub

    'Check password strength
    Private Sub txtPassword_TextChanged(sender As Object, e As EventArgs) Handles txtPassword.TextChanged

        'Declare variables
        Dim password As String = txtPassword.Text
        Dim upper As Integer = 0
        Dim lower As Integer = 0
        Dim numbers As Integer = 0
        Dim other As Integer = 0

        'Gather information about the password
        For i = 0 To password.Length - 1
            If Char.IsLetter(password(i)) Then
                If Char.IsUpper(password(i)) Then
                    upper = upper + 1
                Else
                    lower = lower + 1
                End If
            ElseIf Char.IsNumber(password(i)) Then
                numbers = numbers + 1
            Else
                other = numbers + 1
            End If
        Next

        'Evaluate score
        score = ((upper * 3) + (lower * 1) + (numbers + 3) + (other * 5)) - 4
        If txtPassword.Text = "" Or txtPassword.Text = "password" Or txtPassword.Text = txtUsername.Text Then score = 0

        'Display strength
        If txtPassword.Text = "" Then
            txtStrength.BackColor = Color.White
            txtStrength.Text = "None"
        ElseIf score <= 5 Then
            txtStrength.BackColor = Color.DarkRed
            txtStrength.Text = "Very Weak"
        ElseIf score <= 10 Then
            txtStrength.BackColor = Color.PaleVioletRed
            txtStrength.Text = "Weak"
        ElseIf score <= 15 Then
            txtStrength.BackColor = Color.Yellow
            txtStrength.Text = "Ok"
        ElseIf score <= 20 Then
            txtStrength.BackColor = Color.LightGreen
            txtStrength.Text = "Strong"
        ElseIf score > 20 Then
            txtStrength.BackColor = Color.LimeGreen
            txtStrength.Text = "Very Strong"
        End If
    End Sub

End Class