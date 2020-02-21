<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class SelectShowTime
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(SelectShowTime))
        Me.calCalendar = New System.Windows.Forms.MonthCalendar()
        Me.lstAvaliable = New System.Windows.Forms.ListBox()
        Me.btnContinue = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnNext = New System.Windows.Forms.Button()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'calCalendar
        '
        Me.calCalendar.Location = New System.Drawing.Point(16, 25)
        Me.calCalendar.MaxSelectionCount = 1
        Me.calCalendar.Name = "calCalendar"
        Me.calCalendar.TabIndex = 0
        '
        'lstAvaliable
        '
        Me.lstAvaliable.FormattingEnabled = True
        Me.lstAvaliable.Location = New System.Drawing.Point(255, 27)
        Me.lstAvaliable.Name = "lstAvaliable"
        Me.lstAvaliable.Size = New System.Drawing.Size(259, 160)
        Me.lstAvaliable.TabIndex = 1
        '
        'btnContinue
        '
        Me.btnContinue.BackColor = System.Drawing.Color.SaddleBrown
        Me.btnContinue.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnContinue.ForeColor = System.Drawing.Color.Khaki
        Me.btnContinue.Location = New System.Drawing.Point(440, 189)
        Me.btnContinue.Name = "btnContinue"
        Me.btnContinue.Size = New System.Drawing.Size(75, 23)
        Me.btnContinue.TabIndex = 2
        Me.btnContinue.Text = "Continue"
        Me.btnContinue.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(13, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(188, 13)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Select a date and choose a showtime:"
        '
        'btnNext
        '
        Me.btnNext.BackColor = System.Drawing.Color.SaddleBrown
        Me.btnNext.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnNext.ForeColor = System.Drawing.Color.Khaki
        Me.btnNext.Location = New System.Drawing.Point(16, 189)
        Me.btnNext.Name = "btnNext"
        Me.btnNext.Size = New System.Drawing.Size(123, 23)
        Me.btnNext.TabIndex = 4
        Me.btnNext.Text = "Next Available Time"
        Me.btnNext.UseVisualStyleBackColor = False
        '
        'btnCancel
        '
        Me.btnCancel.BackColor = System.Drawing.Color.SaddleBrown
        Me.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnCancel.ForeColor = System.Drawing.Color.Khaki
        Me.btnCancel.Location = New System.Drawing.Point(145, 189)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(98, 23)
        Me.btnCancel.TabIndex = 5
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = False
        '
        'SelectShowTime
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Khaki
        Me.ClientSize = New System.Drawing.Size(527, 224)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnNext)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnContinue)
        Me.Controls.Add(Me.lstAvaliable)
        Me.Controls.Add(Me.calCalendar)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "SelectShowTime"
        Me.Text = "SelectShowTime"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents calCalendar As MonthCalendar
    Friend WithEvents lstAvaliable As ListBox
    Friend WithEvents btnContinue As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents btnNext As Button
    Friend WithEvents btnCancel As Button
End Class
