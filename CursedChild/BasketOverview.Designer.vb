<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class BasketOverview
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtBasket = New System.Windows.Forms.TextBox()
        Me.btnEditBasket = New System.Windows.Forms.Button()
        Me.btnContinue = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(43, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Basket:"
        '
        'txtBasket
        '
        Me.txtBasket.Location = New System.Drawing.Point(12, 25)
        Me.txtBasket.Multiline = True
        Me.txtBasket.Name = "txtBasket"
        Me.txtBasket.Size = New System.Drawing.Size(361, 162)
        Me.txtBasket.TabIndex = 1
        '
        'btnEditBasket
        '
        Me.btnEditBasket.Location = New System.Drawing.Point(12, 193)
        Me.btnEditBasket.Name = "btnEditBasket"
        Me.btnEditBasket.Size = New System.Drawing.Size(75, 23)
        Me.btnEditBasket.TabIndex = 2
        Me.btnEditBasket.Text = "Edit"
        Me.btnEditBasket.UseVisualStyleBackColor = True
        '
        'btnContinue
        '
        Me.btnContinue.Location = New System.Drawing.Point(298, 193)
        Me.btnContinue.Name = "btnContinue"
        Me.btnContinue.Size = New System.Drawing.Size(75, 23)
        Me.btnContinue.TabIndex = 3
        Me.btnContinue.Text = "Continue"
        Me.btnContinue.UseVisualStyleBackColor = True
        '
        'BasketOverview
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(390, 236)
        Me.Controls.Add(Me.btnContinue)
        Me.Controls.Add(Me.btnEditBasket)
        Me.Controls.Add(Me.txtBasket)
        Me.Controls.Add(Me.Label1)
        Me.Name = "BasketOverview"
        Me.Text = "BasketOverview"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents txtBasket As TextBox
    Friend WithEvents btnEditBasket As Button
    Friend WithEvents btnContinue As Button
End Class
