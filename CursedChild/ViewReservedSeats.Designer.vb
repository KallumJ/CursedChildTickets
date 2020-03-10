<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ViewReservedSeats
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ViewReservedSeats))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtShowID = New System.Windows.Forms.TextBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.txtResID = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnBack = New System.Windows.Forms.Button()
        Me.lstResSeats = New System.Windows.Forms.ListBox()
        Me.txtBlock = New System.Windows.Forms.TextBox()
        Me.txtSeats = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(345, 82)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(64, 13)
        Me.Label1.TabIndex = 83
        Me.Label1.Text = "ShowtimeID"
        '
        'txtShowID
        '
        Me.txtShowID.Location = New System.Drawing.Point(415, 79)
        Me.txtShowID.Name = "txtShowID"
        Me.txtShowID.Size = New System.Drawing.Size(200, 20)
        Me.txtShowID.TabIndex = 82
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(334, 56)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(75, 13)
        Me.Label15.TabIndex = 81
        Me.Label15.Text = "ReservationID"
        '
        'txtResID
        '
        Me.txtResID.Location = New System.Drawing.Point(415, 53)
        Me.txtResID.Name = "txtResID"
        Me.txtResID.ReadOnly = True
        Me.txtResID.Size = New System.Drawing.Size(200, 20)
        Me.txtResID.TabIndex = 80
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(333, 22)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(156, 13)
        Me.Label2.TabIndex = 77
        Me.Label2.Text = "Current Reserved Seat Record:"
        '
        'btnBack
        '
        Me.btnBack.BackColor = System.Drawing.Color.SaddleBrown
        Me.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnBack.ForeColor = System.Drawing.Color.Khaki
        Me.btnBack.Location = New System.Drawing.Point(553, 12)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(75, 23)
        Me.btnBack.TabIndex = 76
        Me.btnBack.Text = "Back"
        Me.btnBack.UseVisualStyleBackColor = False
        '
        'lstResSeats
        '
        Me.lstResSeats.FormattingEnabled = True
        Me.lstResSeats.Location = New System.Drawing.Point(12, 12)
        Me.lstResSeats.Name = "lstResSeats"
        Me.lstResSeats.Size = New System.Drawing.Size(315, 368)
        Me.lstResSeats.TabIndex = 73
        '
        'txtBlock
        '
        Me.txtBlock.Location = New System.Drawing.Point(415, 131)
        Me.txtBlock.Name = "txtBlock"
        Me.txtBlock.Size = New System.Drawing.Size(200, 20)
        Me.txtBlock.TabIndex = 84
        '
        'txtSeats
        '
        Me.txtSeats.Location = New System.Drawing.Point(415, 105)
        Me.txtSeats.Name = "txtSeats"
        Me.txtSeats.Size = New System.Drawing.Size(200, 20)
        Me.txtSeats.TabIndex = 85
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(375, 134)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(34, 13)
        Me.Label3.TabIndex = 86
        Me.Label3.Text = "Block"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(375, 108)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(34, 13)
        Me.Label4.TabIndex = 87
        Me.Label4.Text = "Seats"
        '
        'ViewReservedSeats
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Khaki
        Me.ClientSize = New System.Drawing.Size(647, 391)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtSeats)
        Me.Controls.Add(Me.txtBlock)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtShowID)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.txtResID)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.btnBack)
        Me.Controls.Add(Me.lstResSeats)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "ViewReservedSeats"
        Me.Text = "Cursed Child Booking"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents txtShowID As TextBox
    Friend WithEvents Label15 As Label
    Friend WithEvents txtResID As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents btnBack As Button
    Friend WithEvents lstResSeats As ListBox
    Friend WithEvents txtBlock As TextBox
    Friend WithEvents txtSeats As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
End Class
