<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class MainMenu
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MainMenu))
        Me.btnStaffLogin = New System.Windows.Forms.Button()
        Me.btnFAQ = New System.Windows.Forms.Button()
        Me.btnShowInfo = New System.Windows.Forms.Button()
        Me.btnBook = New System.Windows.Forms.Button()
        Me.AxWindowsMediaPlayer1 = New AxWMPLib.AxWindowsMediaPlayer()
        CType(Me.AxWindowsMediaPlayer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnStaffLogin
        '
        Me.btnStaffLogin.BackColor = System.Drawing.Color.SaddleBrown
        Me.btnStaffLogin.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnStaffLogin.ForeColor = System.Drawing.Color.Khaki
        Me.btnStaffLogin.Location = New System.Drawing.Point(12, 12)
        Me.btnStaffLogin.Name = "btnStaffLogin"
        Me.btnStaffLogin.Size = New System.Drawing.Size(75, 23)
        Me.btnStaffLogin.TabIndex = 0
        Me.btnStaffLogin.Text = "Staff Login"
        Me.btnStaffLogin.UseVisualStyleBackColor = False
        '
        'btnFAQ
        '
        Me.btnFAQ.BackColor = System.Drawing.Color.SaddleBrown
        Me.btnFAQ.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnFAQ.ForeColor = System.Drawing.Color.Khaki
        Me.btnFAQ.Location = New System.Drawing.Point(244, 12)
        Me.btnFAQ.Name = "btnFAQ"
        Me.btnFAQ.Size = New System.Drawing.Size(75, 23)
        Me.btnFAQ.TabIndex = 1
        Me.btnFAQ.Text = "FAQ"
        Me.btnFAQ.UseVisualStyleBackColor = False
        '
        'btnShowInfo
        '
        Me.btnShowInfo.BackColor = System.Drawing.Color.SaddleBrown
        Me.btnShowInfo.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnShowInfo.ForeColor = System.Drawing.Color.Khaki
        Me.btnShowInfo.Location = New System.Drawing.Point(469, 12)
        Me.btnShowInfo.Name = "btnShowInfo"
        Me.btnShowInfo.Size = New System.Drawing.Size(75, 23)
        Me.btnShowInfo.TabIndex = 2
        Me.btnShowInfo.Text = "Show Info"
        Me.btnShowInfo.UseVisualStyleBackColor = False
        '
        'btnBook
        '
        Me.btnBook.BackColor = System.Drawing.Color.SaddleBrown
        Me.btnBook.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnBook.ForeColor = System.Drawing.Color.Khaki
        Me.btnBook.Location = New System.Drawing.Point(698, 12)
        Me.btnBook.Name = "btnBook"
        Me.btnBook.Size = New System.Drawing.Size(80, 23)
        Me.btnBook.TabIndex = 3
        Me.btnBook.Text = "Book Tickets"
        Me.btnBook.UseVisualStyleBackColor = False
        '
        'AxWindowsMediaPlayer1
        '
        Me.AxWindowsMediaPlayer1.Enabled = True
        Me.AxWindowsMediaPlayer1.Location = New System.Drawing.Point(53, 41)
        Me.AxWindowsMediaPlayer1.Name = "AxWindowsMediaPlayer1"
        Me.AxWindowsMediaPlayer1.OcxState = CType(resources.GetObject("AxWindowsMediaPlayer1.OcxState"), System.Windows.Forms.AxHost.State)
        Me.AxWindowsMediaPlayer1.Size = New System.Drawing.Size(691, 397)
        Me.AxWindowsMediaPlayer1.TabIndex = 4
        '
        'MainMenu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Khaki
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.AxWindowsMediaPlayer1)
        Me.Controls.Add(Me.btnBook)
        Me.Controls.Add(Me.btnShowInfo)
        Me.Controls.Add(Me.btnFAQ)
        Me.Controls.Add(Me.btnStaffLogin)
        Me.Cursor = System.Windows.Forms.Cursors.Default
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "MainMenu"
        Me.Text = "Cursed Child Booking"
        CType(Me.AxWindowsMediaPlayer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnStaffLogin As Button
    Friend WithEvents btnFAQ As Button
    Friend WithEvents btnShowInfo As Button
    Friend WithEvents btnBook As Button
    Friend WithEvents AxWindowsMediaPlayer1 As AxWMPLib.AxWindowsMediaPlayer
End Class
