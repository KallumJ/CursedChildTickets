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
        Me.btnViewCustomers.Location = New System.Drawing.Point(13, 64)
        Me.btnViewCustomers.Name = "btnViewCustomers"
        Me.btnViewCustomers.Size = New System.Drawing.Size(122, 46)
        Me.btnViewCustomers.TabIndex = 0
        Me.btnViewCustomers.Text = "View Customers"
        Me.btnViewCustomers.UseVisualStyleBackColor = True
        '
        'btnViewReservations
        '
        Me.btnViewReservations.Location = New System.Drawing.Point(141, 64)
        Me.btnViewReservations.Name = "btnViewReservations"
        Me.btnViewReservations.Size = New System.Drawing.Size(122, 46)
        Me.btnViewReservations.TabIndex = 1
        Me.btnViewReservations.Text = "View Reservations"
        Me.btnViewReservations.UseVisualStyleBackColor = True
        '
        'btnViewShowtimes
        '
        Me.btnViewShowtimes.Location = New System.Drawing.Point(269, 64)
        Me.btnViewShowtimes.Name = "btnViewShowtimes"
        Me.btnViewShowtimes.Size = New System.Drawing.Size(122, 46)
        Me.btnViewShowtimes.TabIndex = 2
        Me.btnViewShowtimes.Text = "View Showtimes"
        Me.btnViewShowtimes.UseVisualStyleBackColor = True
        '
        'btnViewStaff
        '
        Me.btnViewStaff.Location = New System.Drawing.Point(13, 116)
        Me.btnViewStaff.Name = "btnViewStaff"
        Me.btnViewStaff.Size = New System.Drawing.Size(122, 46)
        Me.btnViewStaff.TabIndex = 3
        Me.btnViewStaff.Text = "View Staff"
        Me.btnViewStaff.UseVisualStyleBackColor = True
        '
        'btnViewReseervedSeats
        '
        Me.btnViewReseervedSeats.Location = New System.Drawing.Point(141, 12)
        Me.btnViewReseervedSeats.Name = "btnViewReseervedSeats"
        Me.btnViewReseervedSeats.Size = New System.Drawing.Size(122, 46)
        Me.btnViewReseervedSeats.TabIndex = 4
        Me.btnViewReseervedSeats.Text = "View Reserved Seats"
        Me.btnViewReseervedSeats.UseVisualStyleBackColor = True
        '
        'btnLogOut
        '
        Me.btnLogOut.Location = New System.Drawing.Point(323, 12)
        Me.btnLogOut.Name = "btnLogOut"
        Me.btnLogOut.Size = New System.Drawing.Size(68, 21)
        Me.btnLogOut.TabIndex = 5
        Me.btnLogOut.Text = "Log Out"
        Me.btnLogOut.UseVisualStyleBackColor = True
        '
        'btnViewSeatPlan
        '
        Me.btnViewSeatPlan.Location = New System.Drawing.Point(269, 116)
        Me.btnViewSeatPlan.Name = "btnViewSeatPlan"
        Me.btnViewSeatPlan.Size = New System.Drawing.Size(122, 46)
        Me.btnViewSeatPlan.TabIndex = 6
        Me.btnViewSeatPlan.Text = "View Seating Plan"
        Me.btnViewSeatPlan.UseVisualStyleBackColor = True
        '
        'StaffArea
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(419, 194)
        Me.Controls.Add(Me.btnViewSeatPlan)
        Me.Controls.Add(Me.btnLogOut)
        Me.Controls.Add(Me.btnViewReseervedSeats)
        Me.Controls.Add(Me.btnViewStaff)
        Me.Controls.Add(Me.btnViewShowtimes)
        Me.Controls.Add(Me.btnViewReservations)
        Me.Controls.Add(Me.btnViewCustomers)
        Me.Name = "StaffArea"
        Me.Text = "StaffArea"
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
