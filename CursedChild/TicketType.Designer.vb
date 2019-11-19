<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class TicketType
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
        Me.btnConsecutive = New System.Windows.Forms.Button()
        Me.btnNonConsecutive = New System.Windows.Forms.Button()
        Me.btnSinglePart = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnConsecutive
        '
        Me.btnConsecutive.Location = New System.Drawing.Point(12, 12)
        Me.btnConsecutive.Name = "btnConsecutive"
        Me.btnConsecutive.Size = New System.Drawing.Size(194, 56)
        Me.btnConsecutive.TabIndex = 0
        Me.btnConsecutive.Text = "Consecutive"
        Me.btnConsecutive.UseVisualStyleBackColor = True
        '
        'btnNonConsecutive
        '
        Me.btnNonConsecutive.Location = New System.Drawing.Point(12, 74)
        Me.btnNonConsecutive.Name = "btnNonConsecutive"
        Me.btnNonConsecutive.Size = New System.Drawing.Size(194, 56)
        Me.btnNonConsecutive.TabIndex = 1
        Me.btnNonConsecutive.Text = "Non-consecutive"
        Me.btnNonConsecutive.UseVisualStyleBackColor = True
        '
        'btnSinglePart
        '
        Me.btnSinglePart.Location = New System.Drawing.Point(12, 136)
        Me.btnSinglePart.Name = "btnSinglePart"
        Me.btnSinglePart.Size = New System.Drawing.Size(194, 56)
        Me.btnSinglePart.TabIndex = 2
        Me.btnSinglePart.Text = "Single Part Only"
        Me.btnSinglePart.UseVisualStyleBackColor = True
        '
        'TicketType
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(226, 208)
        Me.Controls.Add(Me.btnSinglePart)
        Me.Controls.Add(Me.btnNonConsecutive)
        Me.Controls.Add(Me.btnConsecutive)
        Me.Name = "TicketType"
        Me.Text = "TicketType"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnConsecutive As Button
    Friend WithEvents btnNonConsecutive As Button
    Friend WithEvents btnSinglePart As Button
End Class
