<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ViewReservedSeats
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ViewReservedSeats))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtShowID = New System.Windows.Forms.TextBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.txtResID = New System.Windows.Forms.TextBox()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.btnEdit = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnBack = New System.Windows.Forms.Button()
        Me.btnCustSearch = New System.Windows.Forms.Button()
        Me.txtStaffSearch = New System.Windows.Forms.TextBox()
        Me.lstResSeats = New System.Windows.Forms.ListBox()
        Me.btnShowAdd = New System.Windows.Forms.Button()
        Me.txtBlock = New System.Windows.Forms.TextBox()
        Me.txtSeats = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(345, 82)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(64, 13)
        Me.Label1.TabIndex = 83
        Me.Label1.Text = "ShowtimeID"
        '
        'txtShowID
        '
        Me.txtShowID.Location = New System.Drawing.Point(415, 79)
        Me.txtShowID.Name = "txtShowID"
        Me.txtShowID.Size = New System.Drawing.Size(200, 20)
        Me.txtShowID.TabIndex = 82
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(334, 56)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(75, 13)
        Me.Label15.TabIndex = 81
        Me.Label15.Text = "ReservationID"
        '
        'txtResID
        '
        Me.txtResID.Location = New System.Drawing.Point(415, 53)
        Me.txtResID.Name = "txtResID"
        Me.txtResID.ReadOnly = True
        Me.txtResID.Size = New System.Drawing.Size(200, 20)
        Me.txtResID.TabIndex = 80
        '
        'btnDelete
        '
        Me.btnDelete.BackColor = System.Drawing.Color.SaddleBrown
        Me.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnDelete.ForeColor = System.Drawing.Color.Khaki
        Me.btnDelete.Location = New System.Drawing.Point(415, 186)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(200, 23)
        Me.btnDelete.TabIndex = 79
        Me.btnDelete.Text = "Delete Record"
        Me.btnDelete.UseVisualStyleBackColor = False
        '
        'btnEdit
        '
        Me.btnEdit.BackColor = System.Drawing.Color.SaddleBrown
        Me.btnEdit.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnEdit.ForeColor = System.Drawing.Color.Khaki
        Me.btnEdit.Location = New System.Drawing.Point(415, 157)
        Me.btnEdit.Name = "btnEdit"
        Me.btnEdit.Size = New System.Drawing.Size(200, 23)
        Me.btnEdit.TabIndex = 78
        Me.btnEdit.Text = "Edit Record"
        Me.btnEdit.UseVisualStyleBackColor = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(333, 22)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(156, 13)
        Me.Label2.TabIndex = 77
        Me.Label2.Text = "Current Reserved Seat Record:"
        '
        'btnBack
        '
        Me.btnBack.BackColor = System.Drawing.Color.SaddleBrown
        Me.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnBack.ForeColor = System.Drawing.Color.Khaki
        Me.btnBack.Location = New System.Drawing.Point(553, 12)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(75, 23)
        Me.btnBack.TabIndex = 76
        Me.btnBack.Text = "Back"
        Me.btnBack.UseVisualStyleBackColor = False
        '
        'btnCustSearch
        '
        Me.btnCustSearch.BackColor = System.Drawing.Color.SaddleBrown
        Me.btnCustSearch.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnCustSearch.ForeColor = System.Drawing.Color.Khaki
        Me.btnCustSearch.Location = New System.Drawing.Point(199, 386)
        Me.btnCustSearch.Name = "btnCustSearch"
        Me.btnCustSearch.Size = New System.Drawing.Size(75, 23)
        Me.btnCustSearch.TabIndex = 75
        Me.btnCustSearch.Text = "Search"
        Me.btnCustSearch.UseVisualStyleBackColor = False
        '
        'txtStaffSearch
        '
        Me.txtStaffSearch.Location = New System.Drawing.Point(12, 386)
        Me.txtStaffSearch.Name = "txtStaffSearch"
        Me.txtStaffSearch.Size = New System.Drawing.Size(181, 20)
        Me.txtStaffSearch.TabIndex = 74
        Me.txtStaffSearch.Text = "Please enter a record to search"
        '
        'lstResSeats
        '
        Me.lstResSeats.FormattingEnabled = True
        Me.lstResSeats.Location = New System.Drawing.Point(12, 12)
        Me.lstResSeats.Name = "lstResSeats"
        Me.lstResSeats.Size = New System.Drawing.Size(315, 368)
        Me.lstResSeats.TabIndex = 73
        '
        'btnShowAdd
        '
        Me.btnShowAdd.BackColor = System.Drawing.Color.SaddleBrown
        Me.btnShowAdd.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnShowAdd.ForeColor = System.Drawing.Color.Khaki
        Me.btnShowAdd.Location = New System.Drawing.Point(12, 415)
        Me.btnShowAdd.Name = "btnShowAdd"
        Me.btnShowAdd.Size = New System.Drawing.Size(133, 23)
        Me.btnShowAdd.TabIndex = 72
        Me.btnShowAdd.Text = "Add Record"
        Me.btnShowAdd.UseVisualStyleBackColor = False
        '
        'txtBlock
        '
        Me.txtBlock.Location = New System.Drawing.Point(415, 131)
        Me.txtBlock.Name = "txtBlock"
        Me.txtBlock.Size = New System.Drawing.Size(200, 20)
        Me.txtBlock.TabIndex = 84
        '
        'txtSeats
        '
        Me.txtSeats.Location = New System.Drawing.Point(415, 105)
        Me.txtSeats.Name = "txtSeats"
        Me.txtSeats.Size = New System.Drawing.Size(200, 20)
        Me.txtSeats.TabIndex = 85
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(375, 134)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(34, 13)
        Me.Label3.TabIndex = 86
        Me.Label3.Text = "Block"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(375, 108)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(34, 13)
        Me.Label4.TabIndex = 87
        Me.Label4.Text = "Seats"
        '
        'ViewReservedSeats
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Khaki
        Me.ClientSize = New System.Drawing.Size(647, 450)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtSeats)
        Me.Controls.Add(Me.txtBlock)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtShowID)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.txtResID)
        Me.Controls.Add(Me.btnDelete)
        Me.Controls.Add(Me.btnEdit)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.btnBack)
        Me.Controls.Add(Me.btnCustSearch)
        Me.Controls.Add(Me.txtStaffSearch)
        Me.Controls.Add(Me.lstResSeats)
        Me.Controls.Add(Me.btnShowAdd)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "ViewReservedSeats"
        Me.Text = "ViewReservedSeats"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents txtShowID As TextBox
    Friend WithEvents Label15 As Label
    Friend WithEvents txtResID As TextBox
    Friend WithEvents btnDelete As Button
    Friend WithEvents btnEdit As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents btnBack As Button
    Friend WithEvents btnCustSearch As Button
    Friend WithEvents txtStaffSearch As TextBox
    Friend WithEvents lstResSeats As ListBox
    Friend WithEvents btnShowAdd As Button
    Friend WithEvents txtBlock As TextBox
    Friend WithEvents txtSeats As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
End Class
