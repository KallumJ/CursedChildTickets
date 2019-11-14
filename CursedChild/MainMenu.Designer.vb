<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MainMenu
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
        Me.btnStaffLogin = New System.Windows.Forms.Button()
        Me.btnFAQ = New System.Windows.Forms.Button()
        Me.btnShowInfo = New System.Windows.Forms.Button()
        Me.btnBook = New System.Windows.Forms.Button()
        Me.picImages = New System.Windows.Forms.PictureBox()
        CType(Me.picImages, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnStaffLogin
        '
        Me.btnStaffLogin.Location = New System.Drawing.Point(12, 12)
        Me.btnStaffLogin.Name = "btnStaffLogin"
        Me.btnStaffLogin.Size = New System.Drawing.Size(75, 23)
        Me.btnStaffLogin.TabIndex = 0
        Me.btnStaffLogin.Text = "Staff Login"
        Me.btnStaffLogin.UseVisualStyleBackColor = True
        '
        'btnFAQ
        '
        Me.btnFAQ.Location = New System.Drawing.Point(244, 12)
        Me.btnFAQ.Name = "btnFAQ"
        Me.btnFAQ.Size = New System.Drawing.Size(75, 23)
        Me.btnFAQ.TabIndex = 1
        Me.btnFAQ.Text = "FAQ"
        Me.btnFAQ.UseVisualStyleBackColor = True
        '
        'btnShowInfo
        '
        Me.btnShowInfo.Location = New System.Drawing.Point(469, 12)
        Me.btnShowInfo.Name = "btnShowInfo"
        Me.btnShowInfo.Size = New System.Drawing.Size(75, 23)
        Me.btnShowInfo.TabIndex = 2
        Me.btnShowInfo.Text = "Show Info"
        Me.btnShowInfo.UseVisualStyleBackColor = True
        '
        'btnBook
        '
        Me.btnBook.Location = New System.Drawing.Point(698, 12)
        Me.btnBook.Name = "btnBook"
        Me.btnBook.Size = New System.Drawing.Size(80, 23)
        Me.btnBook.TabIndex = 3
        Me.btnBook.Text = "Book Tickets"
        Me.btnBook.UseVisualStyleBackColor = True
        '
        'picImages
        '
        Me.picImages.BackColor = System.Drawing.Color.White
        Me.picImages.Image = Global.CursedChild.My.Resources.Resources.MainMenuImage
        Me.picImages.Location = New System.Drawing.Point(12, 50)
        Me.picImages.Name = "picImages"
        Me.picImages.Size = New System.Drawing.Size(776, 388)
        Me.picImages.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picImages.TabIndex = 4
        Me.picImages.TabStop = False
        '
        'MainMenu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.picImages)
        Me.Controls.Add(Me.btnBook)
        Me.Controls.Add(Me.btnShowInfo)
        Me.Controls.Add(Me.btnFAQ)
        Me.Controls.Add(Me.btnStaffLogin)
        Me.Name = "MainMenu"
        Me.Text = "Main Menu"
        CType(Me.picImages, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnStaffLogin As Button
    Friend WithEvents btnFAQ As Button
    Friend WithEvents btnShowInfo As Button
    Friend WithEvents btnBook As Button
    Friend WithEvents picImages As PictureBox
End Class
