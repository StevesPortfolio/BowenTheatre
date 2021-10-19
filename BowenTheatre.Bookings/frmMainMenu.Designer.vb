<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMainMenu
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
        Me.btnMakeBooking = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.btnSearch = New System.Windows.Forms.Button()
        Me.btnCancelBooking = New System.Windows.Forms.Button()
        Me.mnuMainMenu = New System.Windows.Forms.MenuStrip()
        Me.mnuBookingsNewBooking = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuBookingsView = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuBookingsNew = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuBookingsCancelBooking = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.mnuBookingsExit = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuSearch = New System.Windows.Forms.ToolStripMenuItem()
        Me.btnDisplaySeats = New System.Windows.Forms.Button()
        Me.ttMain = New System.Windows.Forms.ToolTip(Me.components)
        Me.mnuMainMenu.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnMakeBooking
        '
        Me.btnMakeBooking.Location = New System.Drawing.Point(19, 48)
        Me.btnMakeBooking.Name = "btnMakeBooking"
        Me.btnMakeBooking.Size = New System.Drawing.Size(260, 31)
        Me.btnMakeBooking.TabIndex = 1
        Me.btnMakeBooking.Text = "Make a new Booking"
        Me.ttMain.SetToolTip(Me.btnMakeBooking, "Make a new booking. Can include multiple seats and prices")
        Me.btnMakeBooking.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(19, 218)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(260, 31)
        Me.btnExit.TabIndex = 2
        Me.btnExit.Text = "Exit"
        Me.ttMain.SetToolTip(Me.btnExit, "Close the program and Exit")
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'btnSearch
        '
        Me.btnSearch.Location = New System.Drawing.Point(19, 120)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(260, 31)
        Me.btnSearch.TabIndex = 3
        Me.btnSearch.Text = "Search for an existing Booking"
        Me.ttMain.SetToolTip(Me.btnSearch, "Search for an existing booking by name or seat")
        Me.btnSearch.UseVisualStyleBackColor = True
        '
        'btnCancelBooking
        '
        Me.btnCancelBooking.Location = New System.Drawing.Point(19, 156)
        Me.btnCancelBooking.Name = "btnCancelBooking"
        Me.btnCancelBooking.Size = New System.Drawing.Size(260, 31)
        Me.btnCancelBooking.TabIndex = 4
        Me.btnCancelBooking.Text = "Cancel a Booking"
        Me.ttMain.SetToolTip(Me.btnCancelBooking, "Cancel an existing booking by name or seat")
        Me.btnCancelBooking.UseVisualStyleBackColor = True
        '
        'mnuMainMenu
        '
        Me.mnuMainMenu.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuBookingsNewBooking, Me.mnuSearch})
        Me.mnuMainMenu.Location = New System.Drawing.Point(0, 0)
        Me.mnuMainMenu.Name = "mnuMainMenu"
        Me.mnuMainMenu.Size = New System.Drawing.Size(299, 24)
        Me.mnuMainMenu.TabIndex = 5
        Me.mnuMainMenu.Text = "MenuStrip1"
        '
        'mnuBookingsNewBooking
        '
        Me.mnuBookingsNewBooking.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuBookingsView, Me.mnuBookingsNew, Me.mnuBookingsCancelBooking, Me.ToolStripSeparator1, Me.mnuBookingsExit})
        Me.mnuBookingsNewBooking.Name = "mnuBookingsNewBooking"
        Me.mnuBookingsNewBooking.Size = New System.Drawing.Size(68, 20)
        Me.mnuBookingsNewBooking.Text = "&Bookings"
        '
        'mnuBookingsView
        '
        Me.mnuBookingsView.Name = "mnuBookingsView"
        Me.mnuBookingsView.Size = New System.Drawing.Size(194, 22)
        Me.mnuBookingsView.Text = "View Existing Bookings"
        '
        'mnuBookingsNew
        '
        Me.mnuBookingsNew.Name = "mnuBookingsNew"
        Me.mnuBookingsNew.Size = New System.Drawing.Size(194, 22)
        Me.mnuBookingsNew.Text = "&New Booking"
        '
        'mnuBookingsCancelBooking
        '
        Me.mnuBookingsCancelBooking.Name = "mnuBookingsCancelBooking"
        Me.mnuBookingsCancelBooking.Size = New System.Drawing.Size(194, 22)
        Me.mnuBookingsCancelBooking.Text = "&Cancel Booking"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(191, 6)
        '
        'mnuBookingsExit
        '
        Me.mnuBookingsExit.Name = "mnuBookingsExit"
        Me.mnuBookingsExit.Size = New System.Drawing.Size(194, 22)
        Me.mnuBookingsExit.Text = "E&xit"
        '
        'mnuSearch
        '
        Me.mnuSearch.Name = "mnuSearch"
        Me.mnuSearch.Size = New System.Drawing.Size(54, 20)
        Me.mnuSearch.Text = "Search"
        '
        'btnDisplaySeats
        '
        Me.btnDisplaySeats.Location = New System.Drawing.Point(19, 84)
        Me.btnDisplaySeats.Name = "btnDisplaySeats"
        Me.btnDisplaySeats.Size = New System.Drawing.Size(260, 31)
        Me.btnDisplaySeats.TabIndex = 6
        Me.btnDisplaySeats.Text = "Display Seating Chart"
        Me.ttMain.SetToolTip(Me.btnDisplaySeats, "Display current seating chart. Selection of seats disabled")
        Me.btnDisplaySeats.UseVisualStyleBackColor = True
        '
        'frmMainMenu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(299, 296)
        Me.Controls.Add(Me.btnDisplaySeats)
        Me.Controls.Add(Me.btnCancelBooking)
        Me.Controls.Add(Me.btnSearch)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnMakeBooking)
        Me.Controls.Add(Me.mnuMainMenu)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MainMenuStrip = Me.mnuMainMenu
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "frmMainMenu"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Bowen Theatre Bookings Main Menu"
        Me.ttMain.SetToolTip(Me, "Main screen to make, view adn cancel bookings")
        Me.mnuMainMenu.ResumeLayout(False)
        Me.mnuMainMenu.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnMakeBooking As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents btnSearch As Button
    Friend WithEvents btnCancelBooking As Button
    Friend WithEvents mnuMainMenu As MenuStrip
    Friend WithEvents mnuBookingsNewBooking As ToolStripMenuItem
    Friend WithEvents mnuBookingsNew As ToolStripMenuItem
    Friend WithEvents mnuBookingsCancelBooking As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents mnuBookingsExit As ToolStripMenuItem
    Friend WithEvents mnuSearch As ToolStripMenuItem
    Friend WithEvents btnDisplaySeats As Button
    Friend WithEvents mnuBookingsView As ToolStripMenuItem
    Friend WithEvents ttMain As ToolTip
End Class
