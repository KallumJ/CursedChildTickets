<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SelectSeat
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(SelectSeat))
        Me.btnViewSeatPlan = New System.Windows.Forms.Button()
        Me.cmbArea = New System.Windows.Forms.ComboBox()
        Me.cmbRow = New System.Windows.Forms.ComboBox()
        Me.cmbSeat = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btnContinue = New System.Windows.Forms.Button()
        Me.btnAuto = New System.Windows.Forms.Button()
        Me.btnBack = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnViewSeatPlan
        '
        Me.btnViewSeatPlan.Location = New System.Drawing.Point(12, 12)
        Me.btnViewSeatPlan.Name = "btnViewSeatPlan"
        Me.btnViewSeatPlan.Size = New System.Drawing.Size(195, 44)
        Me.btnViewSeatPlan.TabIndex = 0
        Me.btnViewSeatPlan.Text = "View Seat Plan"
        Me.btnViewSeatPlan.UseVisualStyleBackColor = True
        '
        'cmbArea
        '
        Me.cmbArea.FormattingEnabled = True
        Me.cmbArea.Items.AddRange(New Object() {"Balcony", "Upper Circle", "Dress Circle", "Stalls"})
        Me.cmbArea.Location = New System.Drawing.Point(12, 127)
        Me.cmbArea.Name = "cmbArea"
        Me.cmbArea.Size = New System.Drawing.Size(121, 21)
        Me.cmbArea.TabIndex = 1
        '
        'cmbRow
        '
        Me.cmbRow.FormattingEnabled = True
        Me.cmbRow.Items.AddRange(New Object() {"A", "B", "C", "D", "E", "F", "G", "H", "I", "J", "K", "L", "M", "N", "O", "P", "Q", "R", "S", "T", "U", "V", "W", "X", "Y", "Z"})
        Me.cmbRow.Location = New System.Drawing.Point(277, 127)
        Me.cmbRow.Name = "cmbRow"
        Me.cmbRow.Size = New System.Drawing.Size(121, 21)
        Me.cmbRow.TabIndex = 2
        '
        'cmbSeat
        '
        Me.cmbSeat.FormattingEnabled = True
        Me.cmbSeat.Items.AddRange(New Object() {"1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12", "13", "14", "15", "16", "17", "18", "19", "20", "21", "22", "23", "24", "25", "26", "27", "28", "29", "30"})
        Me.cmbSeat.Location = New System.Drawing.Point(552, 127)
        Me.cmbSeat.Name = "cmbSeat"
        Me.cmbSeat.Size = New System.Drawing.Size(121, 21)
        Me.cmbSeat.TabIndex = 3
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 111)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(29, 13)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Area"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(274, 111)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(29, 13)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Row"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(549, 111)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(29, 13)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Seat"
        '
        'btnContinue
        '
        Me.btnContinue.Location = New System.Drawing.Point(277, 164)
        Me.btnContinue.Name = "btnContinue"
        Me.btnContinue.Size = New System.Drawing.Size(121, 23)
        Me.btnContinue.TabIndex = 7
        Me.btnContinue.Text = "Continue"
        Me.btnContinue.UseVisualStyleBackColor = True
        '
        'btnAuto
        '
        Me.btnAuto.Location = New System.Drawing.Point(12, 206)
        Me.btnAuto.Name = "btnAuto"
        Me.btnAuto.Size = New System.Drawing.Size(661, 23)
        Me.btnAuto.TabIndex = 8
        Me.btnAuto.Text = "Let the system choose the best avaliable seat"
        Me.btnAuto.UseVisualStyleBackColor = True
        '
        'btnBack
        '
        Me.btnBack.BackColor = System.Drawing.Color.SaddleBrown
        Me.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnBack.ForeColor = System.Drawing.Color.Khaki
        Me.btnBack.Location = New System.Drawing.Point(586, 12)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(91, 23)
        Me.btnBack.TabIndex = 9
        Me.btnBack.Text = "Back"
        Me.btnBack.UseVisualStyleBackColor = False
        '
        'SelectSeat
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Khaki
        Me.ClientSize = New System.Drawing.Size(689, 450)
        Me.Controls.Add(Me.btnBack)
        Me.Controls.Add(Me.btnAuto)
        Me.Controls.Add(Me.btnContinue)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cmbSeat)
        Me.Controls.Add(Me.cmbRow)
        Me.Controls.Add(Me.cmbArea)
        Me.Controls.Add(Me.btnViewSeatPlan)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "SelectSeat"
        Me.Text = "SelectSeat"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnViewSeatPlan As Button
    Friend WithEvents cmbArea As ComboBox
    Friend WithEvents cmbRow As ComboBox
    Friend WithEvents cmbSeat As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents btnContinue As Button
    Friend WithEvents btnAuto As Button
    Friend WithEvents btnBack As Button
End Class
