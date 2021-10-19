<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSelectSeat
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
        Me.components = New System.ComponentModel.Container()
        Me.lblStage = New System.Windows.Forms.Label()
        Me.btnOK = New System.Windows.Forms.Button()
        Me.lblSeats = New System.Windows.Forms.Label()
        Me.txtSeatsLeft = New System.Windows.Forms.TextBox()
        Me.lblAvailable = New System.Windows.Forms.Label()
        Me.lblSeatReserved = New System.Windows.Forms.Label()
        Me.lblInstructions = New System.Windows.Forms.Label()
        Me.ttSelectSeat = New System.Windows.Forms.ToolTip(Me.components)
        Me.SuspendLayout()
        '
        'lblStage
        '
        Me.lblStage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblStage.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblStage.Location = New System.Drawing.Point(62, 56)
        Me.lblStage.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblStage.Name = "lblStage"
        Me.lblStage.Size = New System.Drawing.Size(422, 44)
        Me.lblStage.TabIndex = 0
        Me.lblStage.Text = "S T A G E"
        Me.lblStage.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'btnOK
        '
        Me.btnOK.Location = New System.Drawing.Point(486, 507)
        Me.btnOK.Name = "btnOK"
        Me.btnOK.Size = New System.Drawing.Size(75, 35)
        Me.btnOK.TabIndex = 1
        Me.btnOK.Text = "OK"
        Me.ttSelectSeat.SetToolTip(Me.btnOK, "Save booking and return to previous screen")
        Me.btnOK.UseVisualStyleBackColor = True
        '
        'lblSeats
        '
        Me.lblSeats.AutoSize = True
        Me.lblSeats.Location = New System.Drawing.Point(27, 507)
        Me.lblSeats.Name = "lblSeats"
        Me.lblSeats.Size = New System.Drawing.Size(225, 17)
        Me.lblSeats.TabIndex = 2
        Me.lblSeats.Text = "Seats left to select for this booking"
        '
        'txtSeatsLeft
        '
        Me.txtSeatsLeft.Location = New System.Drawing.Point(259, 507)
        Me.txtSeatsLeft.Name = "txtSeatsLeft"
        Me.txtSeatsLeft.Size = New System.Drawing.Size(100, 23)
        Me.txtSeatsLeft.TabIndex = 3
        Me.ttSelectSeat.SetToolTip(Me.txtSeatsLeft, "Number of seats left to select for this booking")
        '
        'lblAvailable
        '
        Me.lblAvailable.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.lblAvailable.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblAvailable.Location = New System.Drawing.Point(120, 400)
        Me.lblAvailable.Name = "lblAvailable"
        Me.lblAvailable.Size = New System.Drawing.Size(77, 61)
        Me.lblAvailable.TabIndex = 4
        Me.lblAvailable.Text = "Seat Available"
        Me.lblAvailable.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.ttSelectSeat.SetToolTip(Me.lblAvailable, "Available seats are marked in Green")
        '
        'lblSeatReserved
        '
        Me.lblSeatReserved.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.lblSeatReserved.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblSeatReserved.Location = New System.Drawing.Point(351, 400)
        Me.lblSeatReserved.Name = "lblSeatReserved"
        Me.lblSeatReserved.Size = New System.Drawing.Size(77, 61)
        Me.lblSeatReserved.TabIndex = 5
        Me.lblSeatReserved.Text = "Seat Reserved"
        Me.lblSeatReserved.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.ttSelectSeat.SetToolTip(Me.lblSeatReserved, "Reserved seats are marked in Red")
        '
        'lblInstructions
        '
        Me.lblInstructions.AutoSize = True
        Me.lblInstructions.Location = New System.Drawing.Point(27, 24)
        Me.lblInstructions.Name = "lblInstructions"
        Me.lblInstructions.Size = New System.Drawing.Size(340, 17)
        Me.lblInstructions.TabIndex = 6
        Me.lblInstructions.Text = "Click on the available sears you would like to reserve"
        '
        'frmSelectSeat
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(573, 554)
        Me.Controls.Add(Me.lblInstructions)
        Me.Controls.Add(Me.lblSeatReserved)
        Me.Controls.Add(Me.lblAvailable)
        Me.Controls.Add(Me.txtSeatsLeft)
        Me.Controls.Add(Me.lblSeats)
        Me.Controls.Add(Me.btnOK)
        Me.Controls.Add(Me.lblStage)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "frmSelectSeat"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Bowen Theatre - Seating Chart"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblStage As Label
    Friend WithEvents btnOK As Button
    Friend WithEvents lblSeats As Label
    Friend WithEvents txtSeatsLeft As TextBox
    Friend WithEvents lblAvailable As Label
    Friend WithEvents lblSeatReserved As Label
    Friend WithEvents lblInstructions As Label
    Friend WithEvents ttSelectSeat As ToolTip
End Class
