<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AddShowTimes
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(AddShowTimes))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtShowID = New System.Windows.Forms.TextBox()
        Me.datDate = New System.Windows.Forms.DateTimePicker()
        Me.cmbTimeHH = New System.Windows.Forms.ComboBox()
        Me.cmbTimeMM = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.cmbPart = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.btnBack = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(67, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Showtime ID"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(51, 36)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(30, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Date"
        '
        'txtShowID
        '
        Me.txtShowID.Location = New System.Drawing.Point(85, 6)
        Me.txtShowID.Name = "txtShowID"
        Me.txtShowID.ReadOnly = True
        Me.txtShowID.Size = New System.Drawing.Size(200, 20)
        Me.txtShowID.TabIndex = 0
        '
        'datDate
        '
        Me.datDate.Location = New System.Drawing.Point(85, 32)
        Me.datDate.Name = "datDate"
        Me.datDate.Size = New System.Drawing.Size(200, 20)
        Me.datDate.TabIndex = 1
        '
        'cmbTimeHH
        '
        Me.cmbTimeHH.FormattingEnabled = True
        Me.cmbTimeHH.Items.AddRange(New Object() {"14", "19"})
        Me.cmbTimeHH.Location = New System.Drawing.Point(85, 59)
        Me.cmbTimeHH.Name = "cmbTimeHH"
        Me.cmbTimeHH.Size = New System.Drawing.Size(200, 21)
        Me.cmbTimeHH.TabIndex = 2
        '
        'cmbTimeMM
        '
        Me.cmbTimeMM.FormattingEnabled = True
        Me.cmbTimeMM.Items.AddRange(New Object() {"00", "30"})
        Me.cmbTimeMM.Location = New System.Drawing.Point(85, 87)
        Me.cmbTimeMM.Name = "cmbTimeMM"
        Me.cmbTimeMM.Size = New System.Drawing.Size(200, 21)
        Me.cmbTimeMM.TabIndex = 3
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(30, 62)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(49, 13)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Time HH"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(30, 90)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(51, 13)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Time MM"
        '
        'cmbPart
        '
        Me.cmbPart.FormattingEnabled = True
        Me.cmbPart.Items.AddRange(New Object() {"1", "2"})
        Me.cmbPart.Location = New System.Drawing.Point(85, 115)
        Me.cmbPart.Name = "cmbPart"
        Me.cmbPart.Size = New System.Drawing.Size(200, 21)
        Me.cmbPart.TabIndex = 4
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(53, 118)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(26, 13)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "Part"
        '
        'btnAdd
        '
        Me.btnAdd.BackColor = System.Drawing.Color.SaddleBrown
        Me.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnAdd.ForeColor = System.Drawing.Color.Khaki
        Me.btnAdd.Location = New System.Drawing.Point(15, 142)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(270, 23)
        Me.btnAdd.TabIndex = 5
        Me.btnAdd.Text = "Add Showtime"
        Me.btnAdd.UseVisualStyleBackColor = False
        '
        'btnBack
        '
        Me.btnBack.BackColor = System.Drawing.Color.SaddleBrown
        Me.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnBack.ForeColor = System.Drawing.Color.Khaki
        Me.btnBack.Location = New System.Drawing.Point(15, 171)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(270, 23)
        Me.btnBack.TabIndex = 6
        Me.btnBack.Text = "Back"
        Me.btnBack.UseVisualStyleBackColor = False
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(12, 197)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(284, 26)
        Me.Label6.TabIndex = 10
        Me.Label6.Text = "Notice: The latter showtime in a pair of consecutive " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "show times should be added" &
    " straight after the previous one"
        '
        'AddShowTimes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Khaki
        Me.ClientSize = New System.Drawing.Size(303, 238)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.btnBack)
        Me.Controls.Add(Me.btnAdd)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.cmbPart)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.cmbTimeMM)
        Me.Controls.Add(Me.cmbTimeHH)
        Me.Controls.Add(Me.datDate)
        Me.Controls.Add(Me.txtShowID)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "AddShowTimes"
        Me.Text = "Cursed Child Booking"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtShowID As TextBox
    Friend WithEvents datDate As DateTimePicker
    Friend WithEvents cmbTimeHH As ComboBox
    Friend WithEvents cmbTimeMM As ComboBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents cmbPart As ComboBox
    Friend WithEvents Label5 As Label
    Friend WithEvents btnAdd As Button
    Friend WithEvents btnBack As Button
    Friend WithEvents Label6 As Label
End Class
