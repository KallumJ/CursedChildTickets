Public Class ViewCustomers
    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        'Return to staff area
        StaffArea.Show()
        Me.Close()
    End Sub

    Private Sub ViewCustomers_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Declare variables
        Dim customerFile As String = Application.StartupPath & "/customers.dat"
        Dim numOfRecords As Integer
        Dim recordPos As Integer
        Dim listString As String
        Dim title As String
        Dim firstName As String
        Dim surname As String
        Dim phone As String
        Dim email As String
        Dim address As String
        Dim postcode As String

        'Clear the listbox
        lstCustomers.Items.Clear()

        'Listbox title
        lstCustomers.Items.Add("CustomerID      First Name  Surname")

        FileOpen(1, customerFile, OpenMode.Random,,, Len(customerRecord))

        numOfRecords = LOF(1) / Len(customerRecord)

        For recordPos = 1 To numOfRecords
            'Read in record
            FileGet(1, customerRecord, recordPos)

            'Read in the data
            With customerRecord

                title = .title
                Do While Microsoft.VisualBasic.Right(title, 1) = " "
                    title = Mid(title, 1, Len(title) - 1)
                Loop

            End With
        Next

    End Sub
End Class