<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class StaffArea
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(StaffArea))
        Me.btnViewCustomers = New System.Windows.Forms.Button()
        Me.btnViewReservations = New System.Windows.Forms.Button()
        Me.btnViewShowtimes = New System.Windows.Forms.Button()
        Me.btnViewStaff = New System.Windows.Forms.Button()
        Me.btnViewReseervedSeats = New System.Windows.Forms.Button()
        Me.btnLogOut = New System.Windows.Forms.Button()
        Me.btnViewSeatPlan = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnViewCustomers
        '
        Me.btnViewCustomers.BackColor = System.Drawing.Color.SaddleBrown
        Me.btnViewCustomers.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnViewCustomers.ForeColor = System.Drawing.Color.Khaki
        Me.btnViewCustomers.Location = New System.Drawing.Point(13, 64)
        Me.btnViewCustomers.Name = "btnViewCustomers"
        Me.btnViewCustomers.Size = New System.Drawing.Size(122, 46)
        Me.btnViewCustomers.TabIndex = 0
        Me.btnViewCustomers.Text = "View Customers"
        Me.btnViewCustomers.UseVisualStyleBackColor = False
        '
        'btnViewReservations
        '
        Me.btnViewReservations.BackColor = System.Drawing.Color.SaddleBrown
        Me.btnViewReservations.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnViewReservations.ForeColor = System.Drawing.Color.Khaki
        Me.btnViewReservations.Location = New System.Drawing.Point(141, 64)
        Me.btnViewReservations.Name = "btnViewReservations"
        Me.btnViewReservations.Size = New System.Drawing.Size(122, 46)
        Me.btnViewReservations.TabIndex = 1
        Me.btnViewReservations.Text = "View Reservations"
        Me.btnViewReservations.UseVisualStyleBackColor = False
        '
        'btnViewShowtimes
        '
        Me.btnViewShowtimes.BackColor = System.Drawing.Color.SaddleBrown
        Me.btnViewShowtimes.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnViewShowtimes.ForeColor = System.Drawing.Color.Khaki
        Me.btnViewShowtimes.Location = New System.Drawing.Point(269, 64)
        Me.btnViewShowtimes.Name = "btnViewShowtimes"
        Me.btnViewShowtimes.Size = New System.Drawing.Size(122, 46)
        Me.btnViewShowtimes.TabIndex = 2
        Me.btnViewShowtimes.Text = "View Showtimes"
        Me.btnViewShowtimes.UseVisualStyleBackColor = False
        '
        'btnViewStaff
        '
        Me.btnViewStaff.BackColor = System.Drawing.Color.SaddleBrown
        Me.btnViewStaff.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnViewStaff.ForeColor = System.Drawing.Color.Khaki
        Me.btnViewStaff.Location = New System.Drawing.Point(13, 116)
        Me.btnViewStaff.Name = "btnViewStaff"
        Me.btnViewStaff.Size = New System.Drawing.Size(122, 46)
        Me.btnViewStaff.TabIndex = 3
        Me.btnViewStaff.Text = "View Staff"
        Me.btnViewStaff.UseVisualStyleBackColor = False
        '
        'btnViewReseervedSeats
        '
        Me.btnViewReseervedSeats.BackColor = System.Drawing.Color.SaddleBrown
        Me.btnViewReseervedSeats.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnViewReseervedSeats.ForeColor = System.Drawing.Color.Khaki
        Me.btnViewReseervedSeats.Location = New System.Drawing.Point(141, 12)
        Me.btnViewReseervedSeats.Name = "btnViewReseervedSeats"
        Me.btnViewReseervedSeats.Size = New System.Drawing.Size(122, 46)
        Me.btnViewReseervedSeats.TabIndex = 4
        Me.btnViewReseervedSeats.Text = "View Reserved Seats"
        Me.btnViewReseervedSeats.UseVisualStyleBackColor = False
        '
        'btnLogOut
        '
        Me.btnLogOut.BackColor = System.Drawing.Color.SaddleBrown
        Me.btnLogOut.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnLogOut.ForeColor = System.Drawing.Color.Khaki
        Me.btnLogOut.Location = New System.Drawing.Point(323, 12)
        Me.btnLogOut.Name = "btnLogOut"
        Me.btnLogOut.Size = New System.Drawing.Size(68, 21)
        Me.btnLogOut.TabIndex = 5
        Me.btnLogOut.Text = "Log Out"
        Me.btnLogOut.UseVisualStyleBackColor = False
        '
        'btnViewSeatPlan
        '
        Me.btnViewSeatPlan.BackColor = System.Drawing.Color.SaddleBrown
        Me.btnViewSeatPlan.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnViewSeatPlan.ForeColor = System.Drawing.Color.Khaki
        Me.btnViewSeatPlan.Location = New System.Drawing.Point(269, 116)
        Me.btnViewSeatPlan.Name = "btnViewSeatPlan"
        Me.btnViewSeatPlan.Size = New System.Drawing.Size(122, 46)
        Me.btnViewSeatPlan.TabIndex = 6
        Me.btnViewSeatPlan.Text = "Create Seating Plan"
        Me.btnViewSeatPlan.UseVisualStyleBackColor = False
        '
        'StaffArea
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Khaki
        Me.ClientSize = New System.Drawing.Size(419, 194)
        Me.Controls.Add(Me.btnViewSeatPlan)
        Me.Controls.Add(Me.btnLogOut)
        Me.Controls.Add(Me.btnViewReseervedSeats)
        Me.Controls.Add(Me.btnViewStaff)
        Me.Controls.Add(Me.btnViewShowtimes)
        Me.Controls.Add(Me.btnViewReservations)
        Me.Controls.Add(Me.btnViewCustomers)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "StaffArea"
        Me.Text = "Cursed Child Booking"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnViewCustomers As Button
    Friend WithEvents btnViewReservations As Button
    Friend WithEvents btnViewShowtimes As Button
    Friend WithEvents btnViewStaff As Button
    Friend WithEvents btnViewReseervedSeats As Button
    Friend WithEvents btnLogOut As Button
    Friend WithEvents btnViewSeatPlan As Button
End Class
