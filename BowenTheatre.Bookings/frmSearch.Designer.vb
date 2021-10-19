<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSearch
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
        Me.grpSearch = New System.Windows.Forms.GroupBox()
        Me.radSearchTicketNumber = New System.Windows.Forms.RadioButton()
        Me.radSearchName = New System.Windows.Forms.RadioButton()
        Me.txtLastName = New System.Windows.Forms.TextBox()
        Me.lblLastName = New System.Windows.Forms.Label()
        Me.txtFirstName = New System.Windows.Forms.TextBox()
        Me.lblFirstName = New System.Windows.Forms.Label()
        Me.lblTicketNumber = New System.Windows.Forms.Label()
        Me.txtTicketNumber = New System.Windows.Forms.TextBox()
        Me.lblSearchResults = New System.Windows.Forms.Label()
        Me.lvSearchResults = New System.Windows.Forms.ListView()
        Me.btnOK = New System.Windows.Forms.Button()
        Me.btnCancelSelected = New System.Windows.Forms.Button()
        Me.lblCancelInstructions = New System.Windows.Forms.Label()
        Me.btnSearch = New System.Windows.Forms.Button()
        Me.ttSearch = New System.Windows.Forms.ToolTip(Me.components)
        Me.grpSearch.SuspendLayout()
        Me.SuspendLayout()
        '
        'grpSearch
        '
        Me.grpSearch.Controls.Add(Me.radSearchTicketNumber)
        Me.grpSearch.Controls.Add(Me.radSearchName)
        Me.grpSearch.Location = New System.Drawing.Point(17, 16)
        Me.grpSearch.Margin = New System.Windows.Forms.Padding(4)
        Me.grpSearch.Name = "grpSearch"
        Me.grpSearch.Padding = New System.Windows.Forms.Padding(4)
        Me.grpSearch.Size = New System.Drawing.Size(389, 48)
        Me.grpSearch.TabIndex = 0
        Me.grpSearch.TabStop = False
        Me.grpSearch.Text = "Search by Name or Seat Number"
        '
        'radSearchTicketNumber
        '
        Me.radSearchTicketNumber.AutoSize = True
        Me.radSearchTicketNumber.Location = New System.Drawing.Point(193, 17)
        Me.radSearchTicketNumber.Name = "radSearchTicketNumber"
        Me.radSearchTicketNumber.Size = New System.Drawing.Size(186, 21)
        Me.radSearchTicketNumber.TabIndex = 1
        Me.radSearchTicketNumber.TabStop = True
        Me.radSearchTicketNumber.Text = "Search by Ticket Number"
        Me.ttSearch.SetToolTip(Me.radSearchTicketNumber, "Search by Seat")
        Me.radSearchTicketNumber.UseVisualStyleBackColor = True
        '
        'radSearchName
        '
        Me.radSearchName.AutoSize = True
        Me.radSearchName.Checked = True
        Me.radSearchName.Location = New System.Drawing.Point(8, 17)
        Me.radSearchName.Name = "radSearchName"
        Me.radSearchName.Size = New System.Drawing.Size(131, 21)
        Me.radSearchName.TabIndex = 0
        Me.radSearchName.TabStop = True
        Me.radSearchName.Text = "Search by Name"
        Me.ttSearch.SetToolTip(Me.radSearchName, "Search by Name")
        Me.radSearchName.UseVisualStyleBackColor = True
        '
        'txtLastName
        '
        Me.txtLastName.Location = New System.Drawing.Point(318, 80)
        Me.txtLastName.Name = "txtLastName"
        Me.txtLastName.Size = New System.Drawing.Size(143, 23)
        Me.txtLastName.TabIndex = 7
        '
        'lblLastName
        '
        Me.lblLastName.AutoSize = True
        Me.lblLastName.Location = New System.Drawing.Point(231, 83)
        Me.lblLastName.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblLastName.Name = "lblLastName"
        Me.lblLastName.Size = New System.Drawing.Size(80, 17)
        Me.lblLastName.TabIndex = 6
        Me.lblLastName.Text = "Last Name:"
        '
        'txtFirstName
        '
        Me.txtFirstName.Location = New System.Drawing.Point(103, 80)
        Me.txtFirstName.Name = "txtFirstName"
        Me.txtFirstName.Size = New System.Drawing.Size(125, 23)
        Me.txtFirstName.TabIndex = 5
        '
        'lblFirstName
        '
        Me.lblFirstName.AutoSize = True
        Me.lblFirstName.Location = New System.Drawing.Point(16, 83)
        Me.lblFirstName.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblFirstName.Name = "lblFirstName"
        Me.lblFirstName.Size = New System.Drawing.Size(80, 17)
        Me.lblFirstName.TabIndex = 4
        Me.lblFirstName.Text = "First Name:"
        '
        'lblTicketNumber
        '
        Me.lblTicketNumber.AutoSize = True
        Me.lblTicketNumber.Location = New System.Drawing.Point(267, 84)
        Me.lblTicketNumber.Name = "lblTicketNumber"
        Me.lblTicketNumber.Size = New System.Drawing.Size(100, 17)
        Me.lblTicketNumber.TabIndex = 8
        Me.lblTicketNumber.Text = "Ticket Number"
        Me.lblTicketNumber.Visible = False
        '
        'txtTicketNumber
        '
        Me.txtTicketNumber.Location = New System.Drawing.Point(373, 81)
        Me.txtTicketNumber.Name = "txtTicketNumber"
        Me.txtTicketNumber.Size = New System.Drawing.Size(88, 23)
        Me.txtTicketNumber.TabIndex = 9
        Me.txtTicketNumber.Visible = False
        '
        'lblSearchResults
        '
        Me.lblSearchResults.AutoSize = True
        Me.lblSearchResults.Location = New System.Drawing.Point(19, 127)
        Me.lblSearchResults.Name = "lblSearchResults"
        Me.lblSearchResults.Size = New System.Drawing.Size(108, 17)
        Me.lblSearchResults.TabIndex = 10
        Me.lblSearchResults.Text = "Search Results:"
        '
        'lvSearchResults
        '
        Me.lvSearchResults.Location = New System.Drawing.Point(21, 154)
        Me.lvSearchResults.MultiSelect = False
        Me.lvSearchResults.Name = "lvSearchResults"
        Me.lvSearchResults.Size = New System.Drawing.Size(585, 206)
        Me.lvSearchResults.TabIndex = 11
        Me.lvSearchResults.UseCompatibleStateImageBehavior = False
        '
        'btnOK
        '
        Me.btnOK.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnOK.Location = New System.Drawing.Point(531, 375)
        Me.btnOK.Name = "btnOK"
        Me.btnOK.Size = New System.Drawing.Size(75, 35)
        Me.btnOK.TabIndex = 12
        Me.btnOK.Text = "OK"
        Me.ttSearch.SetToolTip(Me.btnOK, "Close and return to Main Menu")
        Me.btnOK.UseVisualStyleBackColor = True
        '
        'btnCancelSelected
        '
        Me.btnCancelSelected.Location = New System.Drawing.Point(22, 375)
        Me.btnCancelSelected.Name = "btnCancelSelected"
        Me.btnCancelSelected.Size = New System.Drawing.Size(206, 35)
        Me.btnCancelSelected.TabIndex = 13
        Me.btnCancelSelected.Text = "Cancel selected Reservations"
        Me.ttSearch.SetToolTip(Me.btnCancelSelected, "Cancel selected reservation")
        Me.btnCancelSelected.UseVisualStyleBackColor = True
        Me.btnCancelSelected.Visible = False
        '
        'lblCancelInstructions
        '
        Me.lblCancelInstructions.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCancelInstructions.Location = New System.Drawing.Point(234, 375)
        Me.lblCancelInstructions.Name = "lblCancelInstructions"
        Me.lblCancelInstructions.Size = New System.Drawing.Size(291, 35)
        Me.lblCancelInstructions.TabIndex = 14
        Me.lblCancelInstructions.Text = "Select booking to cancel, then click ""Cancel selected Reservations"""
        Me.lblCancelInstructions.Visible = False
        '
        'btnSearch
        '
        Me.btnSearch.BackColor = System.Drawing.Color.Transparent
        Me.btnSearch.Image = Global.BowenTheatre.Bookings.My.Resources.Resources.Search_16x
        Me.btnSearch.Location = New System.Drawing.Point(474, 80)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(39, 24)
        Me.btnSearch.TabIndex = 15
        Me.ttSearch.SetToolTip(Me.btnSearch, "Search")
        Me.btnSearch.UseVisualStyleBackColor = False
        '
        'frmSearch
        '
        Me.AcceptButton = Me.btnSearch
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.btnOK
        Me.ClientSize = New System.Drawing.Size(626, 429)
        Me.Controls.Add(Me.btnSearch)
        Me.Controls.Add(Me.lblCancelInstructions)
        Me.Controls.Add(Me.btnCancelSelected)
        Me.Controls.Add(Me.btnOK)
        Me.Controls.Add(Me.lvSearchResults)
        Me.Controls.Add(Me.lblSearchResults)
        Me.Controls.Add(Me.txtTicketNumber)
        Me.Controls.Add(Me.lblTicketNumber)
        Me.Controls.Add(Me.txtLastName)
        Me.Controls.Add(Me.lblLastName)
        Me.Controls.Add(Me.txtFirstName)
        Me.Controls.Add(Me.lblFirstName)
        Me.Controls.Add(Me.grpSearch)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "frmSearch"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Bowen Theatre - Search Bookings"
        Me.grpSearch.ResumeLayout(False)
        Me.grpSearch.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents grpSearch As GroupBox
    Friend WithEvents radSearchTicketNumber As RadioButton
    Friend WithEvents radSearchName As RadioButton
    Friend WithEvents txtLastName As TextBox
    Friend WithEvents lblLastName As Label
    Friend WithEvents txtFirstName As TextBox
    Friend WithEvents lblFirstName As Label
    Friend WithEvents lblTicketNumber As Label
    Friend WithEvents txtTicketNumber As TextBox
    Friend WithEvents lblSearchResults As Label
    Friend WithEvents lvSearchResults As ListView
    Friend WithEvents btnOK As Button
    Friend WithEvents btnCancelSelected As Button
    Friend WithEvents lblCancelInstructions As Label
    Friend WithEvents btnSearch As Button
    Friend WithEvents ttSearch As ToolTip
End Class
