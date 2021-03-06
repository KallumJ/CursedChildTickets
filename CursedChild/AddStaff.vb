﻿Imports System.Security
Imports System.Security.Cryptography

Public Class AddStaff
    'Declare variables
    Dim userFile As String = Application.StartupPath & "/users.dat"
    Dim score As Integer

    Public Shared Function EncryptData(ByVal Message As String) As String
        'Declare variables
        Dim passphrase As String = "password"
        Dim results() As Byte
        Dim UTF8 As System.Text.UTF8Encoding = New System.Text.UTF8Encoding()
        Dim hashProvider As MD5CryptoServiceProvider = New MD5CryptoServiceProvider()
        Dim TDESKey As Byte() = hashProvider.ComputeHash(UTF8.GetBytes(passphrase))
        Dim TDESAlgorithm As TripleDESCryptoServiceProvider = New TripleDESCryptoServiceProvider()

        'Set encryption algorithms properites
        TDESAlgorithm.Key = TDESKey
        TDESAlgorithm.Mode = CipherMode.ECB
        TDESAlgorithm.Padding = PaddingMode.PKCS7

        'Encrypt data
        Dim DataToEncrypt As Byte() = UTF8.GetBytes(Message)
        Try
            Dim Encryptor As ICryptoTransform = TDESAlgorithm.CreateEncryptor
            results = Encryptor.TransformFinalBlock(DataToEncrypt, 0, DataToEncrypt.Length)
        Finally
            'Reset algorithm
            TDESAlgorithm.Clear()
            hashProvider.Clear()
        End Try

        Return Convert.ToBase64String(results)
    End Function

    Public Function Truncate(value As String, length As Integer) As String
        ' If argument is too big, return the original string.
        ' ... Otherwise take a substring from the string's start index.
        If length > value.Length Then
            Return value
        Else
            Return value.Substring(0, length)
        End If
    End Function

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        'Declare variable
        Dim numOfRecords As Integer
        Dim recordPos As Integer

        'Validation

        'Double keying on password
        If txtPassword.Text <> txtConfirmPassword.Text Then
            'Output error message
            MsgBox("The two passwords entered must match")
            Exit Sub
        End If

        'Open the file
        FileOpen(1, userFile, OpenMode.Random,,, Len(userRecord))

        'Determine poisition of the next record
        numOfRecords = LOF(1) / Len(userRecord)
        
        'Set record position to next position in file
        recordPos = numOfRecords + 1

        'Read in the entered data
        With userRecord
            .staffID = txtStaffID.Text
            .username = txtUsername.Text
            .password = EncryptData(Truncate(txtPassword.Text, 8))
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
        
        'Get the record from file
        FileGet(1, userRecord, numOfrecords)
        
        'Set record position
        recordPos = userRecord.staffID + 1

        'If the record position is negative, make it positive
        If recordPos < 0 Then
            recordPos = Math.Abs(recordPos) + 1
        End If

        'Display staff ID
        txtStaffID.Text = recordPos

        'Close the file
        FileClose(1)

    End Sub

    Private Sub AddStaff_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Update ID
        updateStaffID()
    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        'Return to View Staff form
        Call ViewStaff.ViewStaff_Load(Me, e)
        ViewStaff.Show()
        Me.Hide()
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

        'For the length of the password
        For i = 0 To password.Length - 1
            'If the character is a letter
            If Char.IsLetter(password(i)) Then
                'If the character is uppercase
                If Char.IsUpper(password(i)) Then
                    'Add 1 to the upper count
                    upper = upper + 1
                Else
                    'Add 1 to the lower count
                    lower = lower + 1
                End If
            'If the character is a number
            ElseIf Char.IsNumber(password(i)) Then
                'Add one to the number count
                numbers = numbers + 1
            Else
                'Add one to the special count
                other = other + 1
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

    Private Sub AddStaff_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        'Close the application
        Application.Exit()
    End Sub
End Class