<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ViewShowTimes
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
        Me.btnShowAdd = New System.Windows.Forms.Button()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.btnEdit = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnBack = New System.Windows.Forms.Button()
        Me.btnCustSearch = New System.Windows.Forms.Button()
        Me.txtShowSearch = New System.Windows.Forms.TextBox()
        Me.lstShowtimes = New System.Windows.Forms.ListBox()
        Me.chkAvailable = New System.Windows.Forms.CheckBox()
        Me.cmbPart = New System.Windows.Forms.ComboBox()
        Me.cmbTimeMM = New System.Windows.Forms.ComboBox()
        Me.cmbTimeHH = New System.Windows.Forms.ComboBox()
        Me.datDate = New System.Windows.Forms.DateTimePicker()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.txtShowtimeID = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'btnShowAdd
        '
        Me.btnShowAdd.BackColor = System.Drawing.Color.SaddleBrown
        Me.btnShowAdd.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnShowAdd.ForeColor = System.Drawing.Color.Khaki
        Me.btnShowAdd.Location = New System.Drawing.Point(12, 415)
        Me.btnShowAdd.Name = "btnShowAdd"
        Me.btnShowAdd.Size = New System.Drawing.Size(133, 23)
        Me.btnShowAdd.TabIndex = 4
        Me.btnShowAdd.Text = "Add Showtime"
        Me.btnShowAdd.UseVisualStyleBackColor = False
        '
        'btnDelete
        '
        Me.btnDelete.BackColor = System.Drawing.Color.SaddleBrown
        Me.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnDelete.ForeColor = System.Drawing.Color.Khaki
        Me.btnDelete.Location = New System.Drawing.Point(405, 235)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(200, 23)
        Me.btnDelete.TabIndex = 47
        Me.btnDelete.Text = "Delete Record"
        Me.btnDelete.UseVisualStyleBackColor = False
        '
        'btnEdit
        '
        Me.btnEdit.BackColor = System.Drawing.Color.SaddleBrown
        Me.btnEdit.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnEdit.ForeColor = System.Drawing.Color.Khaki
        Me.btnEdit.Location = New System.Drawing.Point(405, 206)
        Me.btnEdit.Name = "btnEdit"
        Me.btnEdit.Size = New System.Drawing.Size(200, 23)
        Me.btnEdit.TabIndex = 46
        Me.btnEdit.Text = "Edit Record"
        Me.btnEdit.UseVisualStyleBackColor = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(333, 22)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(93, 13)
        Me.Label2.TabIndex = 29
        Me.Label2.Text = "Current Showtime:"
        '
        'btnBack
        '
        Me.btnBack.BackColor = System.Drawing.Color.SaddleBrown
        Me.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnBack.ForeColor = System.Drawing.Color.Khaki
        Me.btnBack.Location = New System.Drawing.Point(553, 12)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(75, 23)
        Me.btnBack.TabIndex = 28
        Me.btnBack.Text = "Back"
        Me.btnBack.UseVisualStyleBackColor = False
        '
        'btnCustSearch
        '
        Me.btnCustSearch.BackColor = System.Drawing.Color.SaddleBrown
        Me.btnCustSearch.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnCustSearch.ForeColor = System.Drawing.Color.Khaki
        Me.btnCustSearch.Location = New System.Drawing.Point(187, 386)
        Me.btnCustSearch.Name = "btnCustSearch"
        Me.btnCustSearch.Size = New System.Drawing.Size(75, 23)
        Me.btnCustSearch.TabIndex = 27
        Me.btnCustSearch.Text = "Search"
        Me.btnCustSearch.UseVisualStyleBackColor = False
        '
        'txtShowSearch
        '
        Me.txtShowSearch.Location = New System.Drawing.Point(12, 386)
        Me.txtShowSearch.Name = "txtShowSearch"
        Me.txtShowSearch.Size = New System.Drawing.Size(169, 20)
        Me.txtShowSearch.TabIndex = 26
        Me.txtShowSearch.Text = "Please enter an ID to search"
        '
        'lstShowtimes
        '
        Me.lstShowtimes.FormattingEnabled = True
        Me.lstShowtimes.Location = New System.Drawing.Point(12, 12)
        Me.lstShowtimes.Name = "lstShowtimes"
        Me.lstShowtimes.Size = New System.Drawing.Size(315, 368)
        Me.lstShowtimes.TabIndex = 25
        '
        'chkAvailable
        '
        Me.chkAvailable.AutoSize = True
        Me.chkAvailable.Location = New System.Drawing.Point(405, 186)
        Me.chkAvailable.Name = "chkAvailable"
        Me.chkAvailable.Size = New System.Drawing.Size(15, 14)
        Me.chkAvailable.TabIndex = 59
        Me.chkAvailable.UseVisualStyleBackColor = True
        '
        'cmbPart
        '
        Me.cmbPart.FormattingEnabled = True
        Me.cmbPart.Location = New System.Drawing.Point(405, 159)
        Me.cmbPart.Name = "cmbPart"
        Me.cmbPart.Size = New System.Drawing.Size(200, 21)
        Me.cmbPart.TabIndex = 58
        '
        'cmbTimeMM
        '
        Me.cmbTimeMM.FormattingEnabled = True
        Me.cmbTimeMM.Location = New System.Drawing.Point(405, 132)
        Me.cmbTimeMM.Name = "cmbTimeMM"
        Me.cmbTimeMM.Size = New System.Drawing.Size(200, 21)
        Me.cmbTimeMM.TabIndex = 57
        '
        'cmbTimeHH
        '
        Me.cmbTimeHH.FormattingEnabled = True
        Me.cmbTimeHH.Location = New System.Drawing.Point(405, 105)
        Me.cmbTimeHH.Name = "cmbTimeHH"
        Me.cmbTimeHH.Size = New System.Drawing.Size(200, 21)
        Me.cmbTimeHH.TabIndex = 56
        '
        'datDate
        '
        Me.datDate.Location = New System.Drawing.Point(405, 79)
        Me.datDate.Name = "datDate"
        Me.datDate.Size = New System.Drawing.Size(200, 20)
        Me.datDate.TabIndex = 55
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(349, 187)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(50, 13)
        Me.Label10.TabIndex = 54
        Me.Label10.Text = "Available"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(372, 162)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(26, 13)
        Me.Label11.TabIndex = 53
        Me.Label11.Text = "Part"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(354, 135)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(48, 13)
        Me.Label12.TabIndex = 52
        Me.Label12.Text = "TimeMM"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(356, 108)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(46, 13)
        Me.Label13.TabIndex = 51
        Me.Label13.Text = "TimeHH"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(372, 82)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(30, 13)
        Me.Label14.TabIndex = 50
        Me.Label14.Text = "Date"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(337, 56)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(64, 13)
        Me.Label15.TabIndex = 49
        Me.Label15.Text = "ShowtimeID"
        '
        'txtShowtimeID
        '
        Me.txtShowtimeID.Location = New System.Drawing.Point(405, 53)
        Me.txtShowtimeID.Name = "txtShowtimeID"
        Me.txtShowtimeID.ReadOnly = True
        Me.txtShowtimeID.Size = New System.Drawing.Size(200, 20)
        Me.txtShowtimeID.TabIndex = 48
        '
        'ViewShowTimes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Khaki
        Me.ClientSize = New System.Drawing.Size(634, 450)
        Me.Controls.Add(Me.chkAvailable)
        Me.Controls.Add(Me.cmbPart)
        Me.Controls.Add(Me.cmbTimeMM)
        Me.Controls.Add(Me.cmbTimeHH)
        Me.Controls.Add(Me.datDate)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.txtShowtimeID)
        Me.Controls.Add(Me.btnDelete)
        Me.Controls.Add(Me.btnEdit)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.btnBack)
        Me.Controls.Add(Me.btnCustSearch)
        Me.Controls.Add(Me.txtShowSearch)
        Me.Controls.Add(Me.lstShowtimes)
        Me.Controls.Add(Me.btnShowAdd)
        Me.Name = "ViewShowTimes"
        Me.Text = "ViewShowTimes"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnShowAdd As Button
    Friend WithEvents btnDelete As Button
    Friend WithEvents btnEdit As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents btnBack As Button
    Friend WithEvents btnCustSearch As Button
    Friend WithEvents txtShowSearch As TextBox
    Friend WithEvents lstShowtimes As ListBox
    Friend WithEvents chkAvailable As CheckBox
    Friend WithEvents cmbPart As ComboBox
    Friend WithEvents cmbTimeMM As ComboBox
    Friend WithEvents cmbTimeHH As ComboBox
    Friend WithEvents datDate As DateTimePicker
    Friend WithEvents Label10 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents txtShowtimeID As TextBox
End Class
