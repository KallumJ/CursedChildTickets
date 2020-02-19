<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ViewCustomers
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.lstCustomers = New System.Windows.Forms.ListBox()
        Me.txtCustSearch = New System.Windows.Forms.TextBox()
        Me.btnCustSearch = New System.Windows.Forms.Button()
        Me.btnCustAdd = New System.Windows.Forms.Button()
        Me.btnBack = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnEdit = New System.Windows.Forms.Button()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cmbTitle = New System.Windows.Forms.ComboBox()
        Me.txtPostcode = New System.Windows.Forms.TextBox()
        Me.txtAddress = New System.Windows.Forms.TextBox()
        Me.txtEmail = New System.Windows.Forms.TextBox()
        Me.txtPhone = New System.Windows.Forms.TextBox()
        Me.txtSurname = New System.Windows.Forms.TextBox()
        Me.txtFirstName = New System.Windows.Forms.TextBox()
        Me.txtCustID = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'lstCustomers
        '
        Me.lstCustomers.FormattingEnabled = True
        Me.lstCustomers.Location = New System.Drawing.Point(12, 12)
        Me.lstCustomers.Name = "lstCustomers"
        Me.lstCustomers.Size = New System.Drawing.Size(315, 368)
        Me.lstCustomers.TabIndex = 0
        '
        'txtCustSearch
        '
        Me.txtCustSearch.Location = New System.Drawing.Point(12, 386)
        Me.txtCustSearch.Name = "txtCustSearch"
        Me.txtCustSearch.Size = New System.Drawing.Size(169, 20)
        Me.txtCustSearch.TabIndex = 1
        Me.txtCustSearch.Text = "Please enter a surname to search"
        '
        'btnCustSearch
        '
        Me.btnCustSearch.BackColor = System.Drawing.Color.SaddleBrown
        Me.btnCustSearch.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnCustSearch.ForeColor = System.Drawing.Color.Khaki
        Me.btnCustSearch.Location = New System.Drawing.Point(187, 386)
        Me.btnCustSearch.Name = "btnCustSearch"
        Me.btnCustSearch.Size = New System.Drawing.Size(75, 23)
        Me.btnCustSearch.TabIndex = 2
        Me.btnCustSearch.Text = "Search"
        Me.btnCustSearch.UseVisualStyleBackColor = False
        '
        'btnCustAdd
        '
        Me.btnCustAdd.BackColor = System.Drawing.Color.SaddleBrown
        Me.btnCustAdd.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnCustAdd.ForeColor = System.Drawing.Color.Khaki
        Me.btnCustAdd.Location = New System.Drawing.Point(12, 415)
        Me.btnCustAdd.Name = "btnCustAdd"
        Me.btnCustAdd.Size = New System.Drawing.Size(133, 23)
        Me.btnCustAdd.TabIndex = 3
        Me.btnCustAdd.Text = "Add Customer"
        Me.btnCustAdd.UseVisualStyleBackColor = False
        '
        'btnBack
        '
        Me.btnBack.BackColor = System.Drawing.Color.SaddleBrown
        Me.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnBack.ForeColor = System.Drawing.Color.Khaki
        Me.btnBack.Location = New System.Drawing.Point(553, 12)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(75, 23)
        Me.btnBack.TabIndex = 4
        Me.btnBack.Text = "Back"
        Me.btnBack.UseVisualStyleBackColor = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(333, 22)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(91, 13)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Current Customer:"
        '
        'btnEdit
        '
        Me.btnEdit.BackColor = System.Drawing.Color.SaddleBrown
        Me.btnEdit.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnEdit.ForeColor = System.Drawing.Color.Khaki
        Me.btnEdit.Location = New System.Drawing.Point(419, 270)
        Me.btnEdit.Name = "btnEdit"
        Me.btnEdit.Size = New System.Drawing.Size(121, 23)
        Me.btnEdit.TabIndex = 23
        Me.btnEdit.Text = "Edit Record"
        Me.btnEdit.UseVisualStyleBackColor = False
        '
        'btnDelete
        '
        Me.btnDelete.BackColor = System.Drawing.Color.SaddleBrown
        Me.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnDelete.ForeColor = System.Drawing.Color.Khaki
        Me.btnDelete.Location = New System.Drawing.Point(419, 299)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(121, 23)
        Me.btnDelete.TabIndex = 24
        Me.btnDelete.Text = "Delete Record"
        Me.btnDelete.UseVisualStyleBackColor = False
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(361, 244)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(52, 13)
        Me.Label9.TabIndex = 61
        Me.Label9.Text = "Postcode"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(368, 218)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(45, 13)
        Me.Label8.TabIndex = 60
        Me.Label8.Text = "Address"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(381, 192)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(32, 13)
        Me.Label7.TabIndex = 59
        Me.Label7.Text = "Email"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(375, 166)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(38, 13)
        Me.Label6.TabIndex = 58
        Me.Label6.Text = "Phone"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(364, 140)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(49, 13)
        Me.Label5.TabIndex = 57
        Me.Label5.Text = "Surname"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(356, 114)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(57, 13)
        Me.Label4.TabIndex = 56
        Me.Label4.Text = "First Name"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(386, 87)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(27, 13)
        Me.Label3.TabIndex = 55
        Me.Label3.Text = "Title"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(351, 61)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(62, 13)
        Me.Label1.TabIndex = 54
        Me.Label1.Text = "CustomerID"
        '
        'cmbTitle
        '
        Me.cmbTitle.FormattingEnabled = True
        Me.cmbTitle.Location = New System.Drawing.Point(419, 84)
        Me.cmbTitle.Name = "cmbTitle"
        Me.cmbTitle.Size = New System.Drawing.Size(121, 21)
        Me.cmbTitle.TabIndex = 53
        '
        'txtPostcode
        '
        Me.txtPostcode.Location = New System.Drawing.Point(419, 241)
        Me.txtPostcode.Name = "txtPostcode"
        Me.txtPostcode.Size = New System.Drawing.Size(121, 20)
        Me.txtPostcode.TabIndex = 52
        '
        'txtAddress
        '
        Me.txtAddress.Location = New System.Drawing.Point(419, 215)
        Me.txtAddress.Name = "txtAddress"
        Me.txtAddress.Size = New System.Drawing.Size(121, 20)
        Me.txtAddress.TabIndex = 51
        '
        'txtEmail
        '
        Me.txtEmail.Location = New System.Drawing.Point(419, 189)
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.Size = New System.Drawing.Size(121, 20)
        Me.txtEmail.TabIndex = 50
        '
        'txtPhone
        '
        Me.txtPhone.Location = New System.Drawing.Point(419, 163)
        Me.txtPhone.Name = "txtPhone"
        Me.txtPhone.Size = New System.Drawing.Size(121, 20)
        Me.txtPhone.TabIndex = 49
        '
        'txtSurname
        '
        Me.txtSurname.Location = New System.Drawing.Point(419, 137)
        Me.txtSurname.Name = "txtSurname"
        Me.txtSurname.Size = New System.Drawing.Size(121, 20)
        Me.txtSurname.TabIndex = 48
        '
        'txtFirstName
        '
        Me.txtFirstName.Location = New System.Drawing.Point(419, 111)
        Me.txtFirstName.Name = "txtFirstName"
        Me.txtFirstName.Size = New System.Drawing.Size(121, 20)
        Me.txtFirstName.TabIndex = 47
        '
        'txtCustID
        '
        Me.txtCustID.Location = New System.Drawing.Point(419, 58)
        Me.txtCustID.Name = "txtCustID"
        Me.txtCustID.ReadOnly = True
        Me.txtCustID.Size = New System.Drawing.Size(121, 20)
        Me.txtCustID.TabIndex = 46
        '
        'ViewCustomers
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Khaki
        Me.ClientSize = New System.Drawing.Size(648, 450)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cmbTitle)
        Me.Controls.Add(Me.txtPostcode)
        Me.Controls.Add(Me.txtAddress)
        Me.Controls.Add(Me.txtEmail)
        Me.Controls.Add(Me.txtPhone)
        Me.Controls.Add(Me.txtSurname)
        Me.Controls.Add(Me.txtFirstName)
        Me.Controls.Add(Me.txtCustID)
        Me.Controls.Add(Me.btnDelete)
        Me.Controls.Add(Me.btnEdit)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.btnBack)
        Me.Controls.Add(Me.btnCustAdd)
        Me.Controls.Add(Me.btnCustSearch)
        Me.Controls.Add(Me.txtCustSearch)
        Me.Controls.Add(Me.lstCustomers)
        Me.Name = "ViewCustomers"
        Me.Text = "ViewCustomers"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lstCustomers As ListBox
    Friend WithEvents txtCustSearch As TextBox
    Friend WithEvents btnCustSearch As Button
    Friend WithEvents btnCustAdd As Button
    Friend WithEvents btnBack As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents btnEdit As Button
    Friend WithEvents btnDelete As Button
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents cmbTitle As ComboBox
    Friend WithEvents txtPostcode As TextBox
    Friend WithEvents txtAddress As TextBox
    Friend WithEvents txtEmail As TextBox
    Friend WithEvents txtPhone As TextBox
    Friend WithEvents txtSurname As TextBox
    Friend WithEvents txtFirstName As TextBox
    Friend WithEvents txtCustID As TextBox
End Class
