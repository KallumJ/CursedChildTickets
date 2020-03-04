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
        Me.btnBack = New System.Windows.Forms.Button()
        Me.cmbArea = New System.Windows.Forms.ComboBox()
        Me.panSeats = New System.Windows.Forms.Panel()
        Me.SuspendLayout()
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
        'cmbArea
        '
        Me.cmbArea.FormattingEnabled = True
        Me.cmbArea.Items.AddRange(New Object() {"Stalls", "Upper Circle", "Dress Circle", "Balcony"})
        Me.cmbArea.Location = New System.Drawing.Point(12, 12)
        Me.cmbArea.Name = "cmbArea"
        Me.cmbArea.Size = New System.Drawing.Size(121, 21)
        Me.cmbArea.TabIndex = 10
        '
        'panSeats
        '
        Me.panSeats.Location = New System.Drawing.Point(12, 39)
        Me.panSeats.Name = "panSeats"
        Me.panSeats.Size = New System.Drawing.Size(1771, 684)
        Me.panSeats.TabIndex = 11
        '
        'SelectSeat
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Khaki
        Me.ClientSize = New System.Drawing.Size(1795, 734)
        Me.Controls.Add(Me.panSeats)
        Me.Controls.Add(Me.cmbArea)
        Me.Controls.Add(Me.btnBack)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "SelectSeat"
        Me.Text = "SelectSeat"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnBack As Button
    Friend WithEvents cmbArea As ComboBox
    Friend WithEvents panSeats As Panel
End Class
