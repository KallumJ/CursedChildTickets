<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SeatPlan
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(SeatPlan))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cmbArea = New System.Windows.Forms.ComboBox()
        Me.picArea = New System.Windows.Forms.PictureBox()
        Me.picKey = New System.Windows.Forms.PictureBox()
        Me.btnBack = New System.Windows.Forms.Button()
        CType(Me.picArea, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picKey, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(85, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Choose an area:"
        '
        'cmbArea
        '
        Me.cmbArea.FormattingEnabled = True
        Me.cmbArea.Items.AddRange(New Object() {"Balcony", "Upper Circle", "Dress Circle", "Stalls"})
        Me.cmbArea.Location = New System.Drawing.Point(103, 6)
        Me.cmbArea.Name = "cmbArea"
        Me.cmbArea.Size = New System.Drawing.Size(121, 21)
        Me.cmbArea.TabIndex = 2
        '
        'picArea
        '
        Me.picArea.Image = Global.CursedChild.My.Resources.Resources.Stalls
        Me.picArea.Location = New System.Drawing.Point(15, 50)
        Me.picArea.Name = "picArea"
        Me.picArea.Size = New System.Drawing.Size(672, 425)
        Me.picArea.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.picArea.TabIndex = 3
        Me.picArea.TabStop = False
        '
        'picKey
        '
        Me.picKey.Image = Global.CursedChild.My.Resources.Resources.Key
        Me.picKey.Location = New System.Drawing.Point(1089, 58)
        Me.picKey.Name = "picKey"
        Me.picKey.Size = New System.Drawing.Size(116, 268)
        Me.picKey.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.picKey.TabIndex = 4
        Me.picKey.TabStop = False
        '
        'btnBack
        '
        Me.btnBack.Location = New System.Drawing.Point(1130, 12)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(75, 23)
        Me.btnBack.TabIndex = 5
        Me.btnBack.Text = "Back"
        Me.btnBack.UseVisualStyleBackColor = True
        '
        'SeatPlan
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Khaki
        Me.ClientSize = New System.Drawing.Size(1217, 491)
        Me.Controls.Add(Me.btnBack)
        Me.Controls.Add(Me.picKey)
        Me.Controls.Add(Me.picArea)
        Me.Controls.Add(Me.cmbArea)
        Me.Controls.Add(Me.Label1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "SeatPlan"
        Me.Text = "SeatPlan"
        CType(Me.picArea, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picKey, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents cmbArea As ComboBox
    Friend WithEvents picArea As PictureBox
    Friend WithEvents picKey As PictureBox
    Friend WithEvents btnBack As Button
End Class
