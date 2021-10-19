<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMakeBooking
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
        Me.lblFirstName = New System.Windows.Forms.Label()
        Me.txtFirstName = New System.Windows.Forms.TextBox()
        Me.txtLastName = New System.Windows.Forms.TextBox()
        Me.lblLastName = New System.Windows.Forms.Label()
        Me.lblAdultSeats = New System.Windows.Forms.Label()
        Me.lblConcessionSeats = New System.Windows.Forms.Label()
        Me.nudAdultSeats = New System.Windows.Forms.NumericUpDown()
        Me.nudConcessionSeats = New System.Windows.Forms.NumericUpDown()
        Me.LblPayable = New System.Windows.Forms.Label()
        Me.txtAmountPayable = New System.Windows.Forms.TextBox()
        Me.btnSelectSeats = New System.Windows.Forms.Button()
        Me.btnOK = New System.Windows.Forms.Button()
        Me.lblInstructions = New System.Windows.Forms.Label()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.ttMakeBooking = New System.Windows.Forms.ToolTip(Me.components)
        CType(Me.nudAdultSeats, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudConcessionSeats, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblFirstName
        '
        Me.lblFirstName.AutoSize = True
        Me.lblFirstName.Location = New System.Drawing.Point(14, 79)
        Me.lblFirstName.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblFirstName.Name = "lblFirstName"
        Me.lblFirstName.Size = New System.Drawing.Size(80, 17)
        Me.lblFirstName.TabIndex = 0
        Me.lblFirstName.Text = "First Name:"
        '
        'txtFirstName
        '
        Me.txtFirstName.Location = New System.Drawing.Point(101, 76)
        Me.txtFirstName.Name = "txtFirstName"
        Me.txtFirstName.Size = New System.Drawing.Size(195, 23)
        Me.txtFirstName.TabIndex = 1
        Me.ttMakeBooking.SetToolTip(Me.txtFirstName, "Enter the customer's First Name")
        '
        'txtLastName
        '
        Me.txtLastName.Location = New System.Drawing.Point(410, 76)
        Me.txtLastName.Name = "txtLastName"
        Me.txtLastName.Size = New System.Drawing.Size(195, 23)
        Me.txtLastName.TabIndex = 3
        Me.ttMakeBooking.SetToolTip(Me.txtLastName, "Enter the customer's Last Name")
        '
        'lblLastName
        '
        Me.lblLastName.AutoSize = True
        Me.lblLastName.Location = New System.Drawing.Point(323, 79)
        Me.lblLastName.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblLastName.Name = "lblLastName"
        Me.lblLastName.Size = New System.Drawing.Size(80, 17)
        Me.lblLastName.TabIndex = 2
        Me.lblLastName.Text = "Last Name:"
        '
        'lblAdultSeats
        '
        Me.lblAdultSeats.AutoSize = True
        Me.lblAdultSeats.Location = New System.Drawing.Point(43, 111)
        Me.lblAdultSeats.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblAdultSeats.Name = "lblAdultSeats"
        Me.lblAdultSeats.Size = New System.Drawing.Size(302, 17)
        Me.lblAdultSeats.TabIndex = 4
        Me.lblAdultSeats.Text = "Number of Adult seats required ($14.50 each):"
        '
        'lblConcessionSeats
        '
        Me.lblConcessionSeats.AutoSize = True
        Me.lblConcessionSeats.Location = New System.Drawing.Point(10, 142)
        Me.lblConcessionSeats.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblConcessionSeats.Name = "lblConcessionSeats"
        Me.lblConcessionSeats.Size = New System.Drawing.Size(335, 17)
        Me.lblConcessionSeats.TabIndex = 5
        Me.lblConcessionSeats.Text = "Number of Concession seats required ($8.75 each):"
        '
        'nudAdultSeats
        '
        Me.nudAdultSeats.Location = New System.Drawing.Point(362, 109)
        Me.nudAdultSeats.Name = "nudAdultSeats"
        Me.nudAdultSeats.Size = New System.Drawing.Size(41, 23)
        Me.nudAdultSeats.TabIndex = 6
        Me.ttMakeBooking.SetToolTip(Me.nudAdultSeats, "Select the number of Adult seats to book")
        Me.nudAdultSeats.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'nudConcessionSeats
        '
        Me.nudConcessionSeats.Location = New System.Drawing.Point(362, 140)
        Me.nudConcessionSeats.Name = "nudConcessionSeats"
        Me.nudConcessionSeats.Size = New System.Drawing.Size(41, 23)
        Me.nudConcessionSeats.TabIndex = 7
        Me.ttMakeBooking.SetToolTip(Me.nudConcessionSeats, "Select the number of Concession seats to book")
        '
        'LblPayable
        '
        Me.LblPayable.AutoSize = True
        Me.LblPayable.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblPayable.Location = New System.Drawing.Point(228, 178)
        Me.LblPayable.Name = "LblPayable"
        Me.LblPayable.Size = New System.Drawing.Size(122, 20)
        Me.LblPayable.TabIndex = 8
        Me.LblPayable.Text = "Total Payable:"
        '
        'txtAmountPayable
        '
        Me.txtAmountPayable.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAmountPayable.Location = New System.Drawing.Point(362, 171)
        Me.txtAmountPayable.Name = "txtAmountPayable"
        Me.txtAmountPayable.Size = New System.Drawing.Size(100, 32)
        Me.txtAmountPayable.TabIndex = 9
        Me.ttMakeBooking.SetToolTip(Me.txtAmountPayable, "Total amount payable")
        '
        'btnSelectSeats
        '
        Me.btnSelectSeats.Location = New System.Drawing.Point(443, 111)
        Me.btnSelectSeats.Name = "btnSelectSeats"
        Me.btnSelectSeats.Size = New System.Drawing.Size(162, 34)
        Me.btnSelectSeats.TabIndex = 10
        Me.btnSelectSeats.Text = "Select Seats"
        Me.ttMakeBooking.SetToolTip(Me.btnSelectSeats, "Click to display seating chart and select seats to be reserved")
        Me.btnSelectSeats.UseVisualStyleBackColor = True
        '
        'btnOK
        '
        Me.btnOK.Location = New System.Drawing.Point(503, 220)
        Me.btnOK.Name = "btnOK"
        Me.btnOK.Size = New System.Drawing.Size(102, 32)
        Me.btnOK.TabIndex = 11
        Me.btnOK.Text = "OK"
        Me.ttMakeBooking.SetToolTip(Me.btnOK, "Save bookings and return to Main Menu")
        Me.btnOK.UseVisualStyleBackColor = True
        '
        'lblInstructions
        '
        Me.lblInstructions.Location = New System.Drawing.Point(20, 13)
        Me.lblInstructions.Name = "lblInstructions"
        Me.lblInstructions.Size = New System.Drawing.Size(586, 59)
        Me.lblInstructions.TabIndex = 12
        Me.lblInstructions.Text = "Please enter you name, and the number of each seat type needed. Click on ""Select " &
    "Seats to bring up a seating chart you can choose your seats from. Click OK when " &
    "finished making your booking"
        '
        'btnCancel
        '
        Me.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnCancel.Location = New System.Drawing.Point(362, 220)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(102, 32)
        Me.btnCancel.TabIndex = 13
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'frmMakeBooking
        '
        Me.AcceptButton = Me.btnSelectSeats
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.btnCancel
        Me.ClientSize = New System.Drawing.Size(619, 268)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.lblInstructions)
        Me.Controls.Add(Me.btnOK)
        Me.Controls.Add(Me.btnSelectSeats)
        Me.Controls.Add(Me.txtAmountPayable)
        Me.Controls.Add(Me.LblPayable)
        Me.Controls.Add(Me.nudConcessionSeats)
        Me.Controls.Add(Me.nudAdultSeats)
        Me.Controls.Add(Me.lblConcessionSeats)
        Me.Controls.Add(Me.lblAdultSeats)
        Me.Controls.Add(Me.txtLastName)
        Me.Controls.Add(Me.lblLastName)
        Me.Controls.Add(Me.txtFirstName)
        Me.Controls.Add(Me.lblFirstName)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "frmMakeBooking"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Bowen Theatre - Make a Booking"
        CType(Me.nudAdultSeats, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudConcessionSeats, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblFirstName As Label
    Friend WithEvents txtFirstName As TextBox
    Friend WithEvents txtLastName As TextBox
    Friend WithEvents lblLastName As Label
    Friend WithEvents lblAdultSeats As Label
    Friend WithEvents lblConcessionSeats As Label
    Friend WithEvents nudAdultSeats As NumericUpDown
    Friend WithEvents nudConcessionSeats As NumericUpDown
    Friend WithEvents LblPayable As Label
    Friend WithEvents txtAmountPayable As TextBox
    Friend WithEvents btnSelectSeats As Button
    Friend WithEvents btnOK As Button
    Friend WithEvents lblInstructions As Label
    Friend WithEvents btnCancel As Button
    Friend WithEvents ttMakeBooking As ToolTip
End Class
