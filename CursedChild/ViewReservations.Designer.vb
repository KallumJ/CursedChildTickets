<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ViewReservations
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ViewReservations))
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtPrice = New System.Windows.Forms.TextBox()
        Me.txtTime = New System.Windows.Forms.TextBox()
        Me.txtSurname = New System.Windows.Forms.TextBox()
        Me.txtFirstName = New System.Windows.Forms.TextBox()
        Me.txtShowID = New System.Windows.Forms.TextBox()
        Me.txtResID = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnBack = New System.Windows.Forms.Button()
        Me.btnResSearch = New System.Windows.Forms.Button()
        Me.txtResSearch = New System.Windows.Forms.TextBox()
        Me.lstReservations = New System.Windows.Forms.ListBox()
        Me.datDate = New System.Windows.Forms.DateTimePicker()
        Me.lstSeats = New System.Windows.Forms.ListBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txtCustID = New System.Windows.Forms.TextBox()
        Me.btnEdit = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnDelete
        '
        Me.btnDelete.BackColor = System.Drawing.Color.SaddleBrown
        Me.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnDelete.ForeColor = System.Drawing.Color.Khaki
        Me.btnDelete.Location = New System.Drawing.Point(421, 400)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(121, 23)
        Me.btnDelete.TabIndex = 10
        Me.btnDelete.Text = "Delete Record"
        Me.btnDelete.UseVisualStyleBackColor = False
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(382, 247)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(31, 13)
        Me.Label9.TabIndex = 46
        Me.Label9.Text = "Price"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(382, 221)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(30, 13)
        Me.Label8.TabIndex = 45
        Me.Label8.Text = "Time"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(382, 197)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(30, 13)
        Me.Label7.TabIndex = 44
        Me.Label7.Text = "Date"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(364, 169)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(49, 13)
        Me.Label6.TabIndex = 43
        Me.Label6.Text = "Surname"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(356, 143)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(57, 13)
        Me.Label5.TabIndex = 42
        Me.Label5.Text = "First Name"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(346, 117)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(67, 13)
        Me.Label4.TabIndex = 41
        Me.Label4.Text = "Showtime ID"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(348, 90)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(65, 13)
        Me.Label3.TabIndex = 40
        Me.Label3.Text = "Customer ID"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(335, 64)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(78, 13)
        Me.Label1.TabIndex = 39
        Me.Label1.Text = "Reservation ID"
        '
        'txtPrice
        '
        Me.txtPrice.Location = New System.Drawing.Point(421, 244)
        Me.txtPrice.Name = "txtPrice"
        Me.txtPrice.Size = New System.Drawing.Size(121, 20)
        Me.txtPrice.TabIndex = 7
        '
        'txtTime
        '
        Me.txtTime.Location = New System.Drawing.Point(419, 218)
        Me.txtTime.Name = "txtTime"
        Me.txtTime.ReadOnly = True
        Me.txtTime.Size = New System.Drawing.Size(121, 20)
        Me.txtTime.TabIndex = 6
        '
        'txtSurname
        '
        Me.txtSurname.Location = New System.Drawing.Point(419, 166)
        Me.txtSurname.Name = "txtSurname"
        Me.txtSurname.ReadOnly = True
        Me.txtSurname.Size = New System.Drawing.Size(121, 20)
        Me.txtSurname.TabIndex = 4
        '
        'txtFirstName
        '
        Me.txtFirstName.Location = New System.Drawing.Point(419, 140)
        Me.txtFirstName.Name = "txtFirstName"
        Me.txtFirstName.ReadOnly = True
        Me.txtFirstName.Size = New System.Drawing.Size(121, 20)
        Me.txtFirstName.TabIndex = 3
        '
        'txtShowID
        '
        Me.txtShowID.Location = New System.Drawing.Point(419, 113)
        Me.txtShowID.Name = "txtShowID"
        Me.txtShowID.ReadOnly = True
        Me.txtShowID.Size = New System.Drawing.Size(121, 20)
        Me.txtShowID.TabIndex = 2
        '
        'txtResID
        '
        Me.txtResID.Location = New System.Drawing.Point(419, 61)
        Me.txtResID.Name = "txtResID"
        Me.txtResID.ReadOnly = True
        Me.txtResID.Size = New System.Drawing.Size(121, 20)
        Me.txtResID.TabIndex = 0
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(333, 22)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(104, 13)
        Me.Label2.TabIndex = 30
        Me.Label2.Text = "Current Reservation:"
        '
        'btnBack
        '
        Me.btnBack.BackColor = System.Drawing.Color.SaddleBrown
        Me.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnBack.ForeColor = System.Drawing.Color.Khaki
        Me.btnBack.Location = New System.Drawing.Point(553, 12)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(75, 23)
        Me.btnBack.TabIndex = 29
        Me.btnBack.Text = "Back"
        Me.btnBack.UseVisualStyleBackColor = False
        '
        'btnResSearch
        '
        Me.btnResSearch.BackColor = System.Drawing.Color.SaddleBrown
        Me.btnResSearch.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnResSearch.ForeColor = System.Drawing.Color.Khaki
        Me.btnResSearch.Location = New System.Drawing.Point(187, 386)
        Me.btnResSearch.Name = "btnResSearch"
        Me.btnResSearch.Size = New System.Drawing.Size(75, 23)
        Me.btnResSearch.TabIndex = 12
        Me.btnResSearch.Text = "Search"
        Me.btnResSearch.UseVisualStyleBackColor = False
        '
        'txtResSearch
        '
        Me.txtResSearch.Location = New System.Drawing.Point(12, 386)
        Me.txtResSearch.Name = "txtResSearch"
        Me.txtResSearch.Size = New System.Drawing.Size(169, 20)
        Me.txtResSearch.TabIndex = 11
        Me.txtResSearch.Text = "Please enter an ID to search"
        '
        'lstReservations
        '
        Me.lstReservations.FormattingEnabled = True
        Me.lstReservations.Location = New System.Drawing.Point(12, 12)
        Me.lstReservations.Name = "lstReservations"
        Me.lstReservations.Size = New System.Drawing.Size(315, 368)
        Me.lstReservations.TabIndex = 25
        '
        'datDate
        '
        Me.datDate.Location = New System.Drawing.Point(419, 192)
        Me.datDate.Name = "datDate"
        Me.datDate.Size = New System.Drawing.Size(123, 20)
        Me.datDate.TabIndex = 5
        '
        'lstSeats
        '
        Me.lstSeats.FormattingEnabled = True
        Me.lstSeats.Location = New System.Drawing.Point(422, 270)
        Me.lstSeats.Name = "lstSeats"
        Me.lstSeats.Size = New System.Drawing.Size(120, 95)
        Me.lstSeats.TabIndex = 8
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(382, 270)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(34, 13)
        Me.Label10.TabIndex = 51
        Me.Label10.Text = "Seats"
        '
        'txtCustID
        '
        Me.txtCustID.Location = New System.Drawing.Point(419, 87)
        Me.txtCustID.Name = "txtCustID"
        Me.txtCustID.ReadOnly = True
        Me.txtCustID.Size = New System.Drawing.Size(121, 20)
        Me.txtCustID.TabIndex = 1
        '
        'btnEdit
        '
        Me.btnEdit.BackColor = System.Drawing.Color.SaddleBrown
        Me.btnEdit.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnEdit.ForeColor = System.Drawing.Color.Khaki
        Me.btnEdit.Location = New System.Drawing.Point(421, 371)
        Me.btnEdit.Name = "btnEdit"
        Me.btnEdit.Size = New System.Drawing.Size(121, 23)
        Me.btnEdit.TabIndex = 9
        Me.btnEdit.Text = "Edit Record"
        Me.btnEdit.UseVisualStyleBackColor = False
        '
        'ViewReservations
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Khaki
        Me.ClientSize = New System.Drawing.Size(659, 428)
        Me.Controls.Add(Me.btnEdit)
        Me.Controls.Add(Me.txtCustID)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.lstSeats)
        Me.Controls.Add(Me.datDate)
        Me.Controls.Add(Me.btnDelete)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtPrice)
        Me.Controls.Add(Me.txtTime)
        Me.Controls.Add(Me.txtSurname)
        Me.Controls.Add(Me.txtFirstName)
        Me.Controls.Add(Me.txtShowID)
        Me.Controls.Add(Me.txtResID)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.btnBack)
        Me.Controls.Add(Me.btnResSearch)
        Me.Controls.Add(Me.txtResSearch)
        Me.Controls.Add(Me.lstReservations)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "ViewReservations"
        Me.Text = "Cursed Child Booking"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnDelete As Button
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents txtPrice As TextBox
    Friend WithEvents txtTime As TextBox
    Friend WithEvents txtSurname As TextBox
    Friend WithEvents txtFirstName As TextBox
    Friend WithEvents txtShowID As TextBox
    Friend WithEvents txtResID As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents btnBack As Button
    Friend WithEvents btnResSearch As Button
    Friend WithEvents txtResSearch As TextBox
    Friend WithEvents lstReservations As ListBox
    Friend WithEvents datDate As DateTimePicker
    Friend WithEvents lstSeats As ListBox
    Friend WithEvents Label10 As Label
    Friend WithEvents txtCustID As TextBox
    Friend WithEvents btnEdit As Button
End Class
