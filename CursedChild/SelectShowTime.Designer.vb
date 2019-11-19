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
        Me.calCalendar = New System.Windows.Forms.MonthCalendar()
        Me.lstAvaliable = New System.Windows.Forms.ListBox()
        Me.SuspendLayout()
        '
        'calCalendar
        '
        Me.calCalendar.Location = New System.Drawing.Point(18, 18)
        Me.calCalendar.MaxSelectionCount = 1
        Me.calCalendar.Name = "calCalendar"
        Me.calCalendar.TabIndex = 0
        '
        'lstAvaliable
        '
        Me.lstAvaliable.FormattingEnabled = True
        Me.lstAvaliable.Location = New System.Drawing.Point(257, 18)
        Me.lstAvaliable.Name = "lstAvaliable"
        Me.lstAvaliable.Size = New System.Drawing.Size(259, 160)
        Me.lstAvaliable.TabIndex = 1
        '
        'SelectShowTime
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.lstAvaliable)
        Me.Controls.Add(Me.calCalendar)
        Me.Name = "SelectShowTime"
        Me.Text = "SelectShowTime"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents calCalendar As MonthCalendar
    Friend WithEvents lstAvaliable As ListBox
End Class
