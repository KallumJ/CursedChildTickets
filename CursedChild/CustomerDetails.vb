Imports System.Text.RegularExpressions

Public Class CustomerDetails

    Public title As String
    Public firstName As String
    Public surname As String
    Public phone As String
    Public email As String
    Public address As String
    Public postcode As String

    Private Sub btnContinue_Click(sender As Object, e As EventArgs) Handles btnContinue.Click
        'Validation

        'Length check on phone number
        If Len(txtPhone.Text) <> 11 Then
            MsgBox("Please enter a phone number that has 11 numbers")
            Exit Sub
        End If

        'Lookup check on title
        If cmbTitle.Text <> "Mr." And cmbTitle.Text <> "Mrs." And cmbTitle.Text <> "Miss." And cmbTitle.Text <> "Dr." And cmbTitle.Text <> "Master." Then
            MsgBox("Please enter a valid title from the dropdown")
            Exit Sub
        End If

        'Regular expressions check on postcode
        Dim regex As Regex = New Regex("([A-Z]{2})([0-9]{1,2})([0-9]{1})([A-Z]{2})")
        Dim post As String = txtPostcode.Text.ToUpper
        Dim match As Match = regex.Match(post)

        If match.Success Then
        Else
            MsgBox("Please enter a valid postcode")
            Exit Sub
        End If

        'Save customer details
        title = cmbTitle.Text
        firstName = txtFirstName.Text
        surname = txtSurname.Text
        phone = txtPhone.Text
        email = txtEmail.Text
        address = txtAddress.Text
        postcode = txtPostcode.Text

        'Reset timer
        SelectShowTime.reset = 300

        'Proceed to next form
        Call DetailsConfirmation.DetailsConfirmation_Load(Me, e)
        DetailsConfirmation.Show()
        Me.Hide()

    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        'Return to Main Menu
        MainMenu.Show()
        Me.Close()
    End Sub

    Private Sub CustomerDetails_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        MainMenu.Close()
    End Sub
End Class