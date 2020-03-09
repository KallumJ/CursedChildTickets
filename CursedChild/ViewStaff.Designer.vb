<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ViewStaff
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ViewStaff))
        Me.Label15 = New System.Windows.Forms.Label()
        Me.txtStaffID = New System.Windows.Forms.TextBox()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.btnEdit = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnBack = New System.Windows.Forms.Button()
        Me.btnCustSearch = New System.Windows.Forms.Button()
        Me.txtStaffSearch = New System.Windows.Forms.TextBox()
        Me.lstStaff = New System.Windows.Forms.ListBox()
        Me.btnShowAdd = New System.Windows.Forms.Button()
        Me.txtUsername = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(359, 56)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(40, 13)
        Me.Label15.TabIndex = 69
        Me.Label15.Text = "StaffID"
        '
        'txtStaffID
        '
        Me.txtStaffID.Location = New System.Drawing.Point(405, 53)
        Me.txtStaffID.Name = "txtStaffID"
        Me.txtStaffID.ReadOnly = True
        Me.txtStaffID.Size = New System.Drawing.Size(200, 20)
        Me.txtStaffID.TabIndex = 68
        '
        'btnDelete
        '
        Me.btnDelete.BackColor = System.Drawing.Color.SaddleBrown
        Me.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnDelete.ForeColor = System.Drawing.Color.Khaki
        Me.btnDelete.Location = New System.Drawing.Point(405, 134)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(200, 23)
        Me.btnDelete.TabIndex = 67
        Me.btnDelete.Text = "Delete Record"
        Me.btnDelete.UseVisualStyleBackColor = False
        '
        'btnEdit
        '
        Me.btnEdit.BackColor = System.Drawing.Color.SaddleBrown
        Me.btnEdit.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnEdit.ForeColor = System.Drawing.Color.Khaki
        Me.btnEdit.Location = New System.Drawing.Point(405, 105)
        Me.btnEdit.Name = "btnEdit"
        Me.btnEdit.Size = New System.Drawing.Size(200, 23)
        Me.btnEdit.TabIndex = 66
        Me.btnEdit.Text = "Edit Record"
        Me.btnEdit.UseVisualStyleBackColor = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(333, 22)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(110, 13)
        Me.Label2.TabIndex = 65
        Me.Label2.Text = "Current Staff Member:"
        '
        'btnBack
        '
        Me.btnBack.BackColor = System.Drawing.Color.SaddleBrown
        Me.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnBack.ForeColor = System.Drawing.Color.Khaki
        Me.btnBack.Location = New System.Drawing.Point(553, 12)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(75, 23)
        Me.btnBack.TabIndex = 64
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
        Me.btnCustSearch.TabIndex = 63
        Me.btnCustSearch.Text = "Search"
        Me.btnCustSearch.UseVisualStyleBackColor = False
        '
        'txtStaffSearch
        '
        Me.txtStaffSearch.Location = New System.Drawing.Point(12, 386)
        Me.txtStaffSearch.Name = "txtStaffSearch"
        Me.txtStaffSearch.Size = New System.Drawing.Size(181, 20)
        Me.txtStaffSearch.TabIndex = 62
        Me.txtStaffSearch.Text = "Please enter a Username to search"
        '
        'lstStaff
        '
        Me.lstStaff.FormattingEnabled = True
        Me.lstStaff.Location = New System.Drawing.Point(12, 12)
        Me.lstStaff.Name = "lstStaff"
        Me.lstStaff.Size = New System.Drawing.Size(315, 368)
        Me.lstStaff.TabIndex = 61
        '
        'btnShowAdd
        '
        Me.btnShowAdd.BackColor = System.Drawing.Color.SaddleBrown
        Me.btnShowAdd.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnShowAdd.ForeColor = System.Drawing.Color.Khaki
        Me.btnShowAdd.Location = New System.Drawing.Point(12, 415)
        Me.btnShowAdd.Name = "btnShowAdd"
        Me.btnShowAdd.Size = New System.Drawing.Size(133, 23)
        Me.btnShowAdd.TabIndex = 60
        Me.btnShowAdd.Text = "Add Staff Member"
        Me.btnShowAdd.UseVisualStyleBackColor = False
        '
        'txtUsername
        '
        Me.txtUsername.Location = New System.Drawing.Point(405, 79)
        Me.txtUsername.Name = "txtUsername"
        Me.txtUsername.Size = New System.Drawing.Size(200, 20)
        Me.txtUsername.TabIndex = 70
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(344, 82)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(55, 13)
        Me.Label1.TabIndex = 71
        Me.Label1.Text = "Username"
        '
        'ViewStaff
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Khaki
        Me.ClientSize = New System.Drawing.Size(645, 450)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtUsername)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.txtStaffID)
        Me.Controls.Add(Me.btnDelete)
        Me.Controls.Add(Me.btnEdit)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.btnBack)
        Me.Controls.Add(Me.btnCustSearch)
        Me.Controls.Add(Me.txtStaffSearch)
        Me.Controls.Add(Me.lstStaff)
        Me.Controls.Add(Me.btnShowAdd)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "ViewStaff"
        Me.Text = "Cursed Child Booking"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label15 As Label
    Friend WithEvents txtStaffID As TextBox
    Friend WithEvents btnDelete As Button
    Friend WithEvents btnEdit As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents btnBack As Button
    Friend WithEvents btnCustSearch As Button
    Friend WithEvents txtStaffSearch As TextBox
    Friend WithEvents lstStaff As ListBox
    Friend WithEvents btnShowAdd As Button
    Friend WithEvents txtUsername As TextBox
    Friend WithEvents Label1 As Label
End Class
