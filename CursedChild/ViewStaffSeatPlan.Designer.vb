<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ViewStaffSeatPlan
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
        Me.panSeats = New System.Windows.Forms.Panel()
        Me.cmbArea = New System.Windows.Forms.ComboBox()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'panSeats
        '
        Me.panSeats.Location = New System.Drawing.Point(12, 38)
        Me.panSeats.Name = "panSeats"
        Me.panSeats.Size = New System.Drawing.Size(1415, 684)
        Me.panSeats.TabIndex = 0
        '
        'cmbArea
        '
        Me.cmbArea.FormattingEnabled = True
        Me.cmbArea.Items.AddRange(New Object() {"Stalls", "Upper Circle", "Dress Circle", "Balcony"})
        Me.cmbArea.Location = New System.Drawing.Point(12, 11)
        Me.cmbArea.Name = "cmbArea"
        Me.cmbArea.Size = New System.Drawing.Size(121, 21)
        Me.cmbArea.TabIndex = 1
        '
        'btnSave
        '
        Me.btnSave.BackColor = System.Drawing.Color.SaddleBrown
        Me.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnSave.ForeColor = System.Drawing.Color.Khaki
        Me.btnSave.Location = New System.Drawing.Point(139, 9)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(75, 23)
        Me.btnSave.TabIndex = 0
        Me.btnSave.Text = "Save"
        Me.btnSave.UseVisualStyleBackColor = False
        '
        'ViewStaffSeatPlan
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Khaki
        Me.ClientSize = New System.Drawing.Size(1439, 734)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.cmbArea)
        Me.Controls.Add(Me.panSeats)
        Me.Name = "ViewStaffSeatPlan"
        Me.Text = "ViewStaffSeatPlan"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents panSeats As Panel
    Friend WithEvents cmbArea As ComboBox
    Friend WithEvents btnSave As Button
End Class
