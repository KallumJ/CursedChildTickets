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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(TicketType))
        Me.btnConsecutive = New System.Windows.Forms.Button()
        Me.btnNonConsecutive = New System.Windows.Forms.Button()
        Me.btnSinglePart = New System.Windows.Forms.Button()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnConsecutive
        '
        Me.btnConsecutive.BackColor = System.Drawing.Color.SaddleBrown
        Me.btnConsecutive.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnConsecutive.ForeColor = System.Drawing.Color.Khaki
        Me.btnConsecutive.Location = New System.Drawing.Point(12, 12)
        Me.btnConsecutive.Name = "btnConsecutive"
        Me.btnConsecutive.Size = New System.Drawing.Size(194, 56)
        Me.btnConsecutive.TabIndex = 0
        Me.btnConsecutive.Text = "Consecutive"
        Me.btnConsecutive.UseVisualStyleBackColor = False
        '
        'btnNonConsecutive
        '
        Me.btnNonConsecutive.BackColor = System.Drawing.Color.SaddleBrown
        Me.btnNonConsecutive.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnNonConsecutive.ForeColor = System.Drawing.Color.Khaki
        Me.btnNonConsecutive.Location = New System.Drawing.Point(12, 74)
        Me.btnNonConsecutive.Name = "btnNonConsecutive"
        Me.btnNonConsecutive.Size = New System.Drawing.Size(194, 56)
        Me.btnNonConsecutive.TabIndex = 1
        Me.btnNonConsecutive.Text = "Non-consecutive"
        Me.btnNonConsecutive.UseVisualStyleBackColor = False
        '
        'btnSinglePart
        '
        Me.btnSinglePart.BackColor = System.Drawing.Color.SaddleBrown
        Me.btnSinglePart.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnSinglePart.ForeColor = System.Drawing.Color.Khaki
        Me.btnSinglePart.Location = New System.Drawing.Point(12, 136)
        Me.btnSinglePart.Name = "btnSinglePart"
        Me.btnSinglePart.Size = New System.Drawing.Size(194, 56)
        Me.btnSinglePart.TabIndex = 2
        Me.btnSinglePart.Text = "Single Part Only"
        Me.btnSinglePart.UseVisualStyleBackColor = False
        '
        'btnCancel
        '
        Me.btnCancel.BackColor = System.Drawing.Color.SaddleBrown
        Me.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnCancel.ForeColor = System.Drawing.Color.Khaki
        Me.btnCancel.Location = New System.Drawing.Point(12, 228)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(194, 56)
        Me.btnCancel.TabIndex = 3
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = False
        '
        'TicketType
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Khaki
        Me.ClientSize = New System.Drawing.Size(226, 297)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnSinglePart)
        Me.Controls.Add(Me.btnNonConsecutive)
        Me.Controls.Add(Me.btnConsecutive)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "TicketType"
        Me.Text = "TicketType"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnConsecutive As Button
    Friend WithEvents btnNonConsecutive As Button
    Friend WithEvents btnSinglePart As Button
    Friend WithEvents btnCancel As Button
End Class
