
'Program Title: Bowen Theatre
'Author: Steve Teece
'Student Number: 804727850
'Version: 1.0
'Date: 17 April, 2018
'Module: frmSearch
'Task: Continuing VB, Assessment Task 1

Public Class frmSearch


    Dim bookingsList As List(Of Ticket)
    Dim NameSearch As Boolean = True

    ''' <summary>
    ''' Check Name Search radio button. Show FirstName and Surname fields to search on, and hide Seat number field
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub radSearchName_CheckedChanged(sender As Object, e As EventArgs) Handles radSearchName.CheckedChanged

        If True Then
            lblFirstName.Visible = True
            txtFirstName.Visible = True
            lblLastName.Visible = True
            txtLastName.Visible = True
            lblTicketNumber.Visible = False
            txtTicketNumber.Visible = False
            NameSearch = True
        End If
    End Sub

    ''' <summary>
    ''' Check Seat Number search button. Show Seat Number search and hide name search fields
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub radSearchTicketNumber_CheckedChanged(sender As Object, e As EventArgs) Handles radSearchTicketNumber.CheckedChanged
        If True Then
            lblFirstName.Visible = False
            txtFirstName.Visible = False
            lblLastName.Visible = False
            txtLastName.Visible = False
            lblTicketNumber.Visible = True
            txtTicketNumber.Visible = True
            NameSearch = False
        End If
    End Sub

    Private Sub frmSearch_Load(sender As Object, e As EventArgs) Handles Me.Load

        DisplayCorrectLayout()
        lvSearchResults = PopulateBookings(lvSearchResults)

    End Sub

    Private Sub btnOK_Click(sender As Object, e As EventArgs) Handles btnOK.Click
        Me.Close()
    End Sub

    ''' <summary>
    ''' Check boolean variable CancelReservation. If set to True, show cancel button and instructions,
    ''' otherwise hide cancel button and instructions.
    ''' </summary>
    Private Sub DisplayCorrectLayout()
        If CancelReservation Then
            lblCancelInstructions.Visible = True
            btnCancelSelected.Visible = True
        Else
            lblCancelInstructions.Visible = False
            btnCancelSelected.Visible = False
        End If
    End Sub

    ''' <summary>
    ''' Populate List view control with column headers and data for existing bookings
    ''' </summary>
    ''' <param name="lv"></param>
    ''' <returns></returns>
    Private Function PopulateBookings(ByVal lv As ListView) As ListView

        bookingsList = New List(Of Ticket)

        'Loop through existing bookings and make a list
        For r = 0 To Seats.GetUpperBound(0)
            For c = 0 To Seats.GetUpperBound(1)
                If Seats(r, c).Type <> TicketType.Available Then
                    'Do not add tickets listed as 'Available' to the list
                    bookingsList.Add(Seats(r, c))
                End If
            Next
        Next

        'Add columns to list view and populate with bookings data from the list
        With lv
            .Columns.Add("First Name", 100, HorizontalAlignment.Left)
            .Columns.Add("Last Name", 100, HorizontalAlignment.Left)
            .Columns.Add("Seat Number", 50, HorizontalAlignment.Left)
            .View = View.Details
            .FullRowSelect = True
            For Each b As Ticket In bookingsList
                .Items.Add(New ListViewItem({b.FirstName.ToString(), b.LastName.ToString(), b.SeatNumber.ToString()}))
            Next
        End With

        Return lv
    End Function

    Private Sub btnCancelSelected_Click(sender As Object, e As EventArgs) Handles btnCancelSelected.Click
        'Get selected reservation seat number

        Dim resSeat As String = lvSearchResults.SelectedItems(0).SubItems(2).Text
        'Dim resSeat As String = lvSearchResults.SelectedItems(0).Text

        'Remove record from Current Reservations list
        lvSearchResults.Items.RemoveAt(lvSearchResults.SelectedIndices(0))

        CancelRes(resSeat)

        lvSearchResults = PopulateBookings(lvSearchResults)


    End Sub

    Private Sub CancelRes(seat As String)
        'Convert seat number to row and column
        Dim row As Integer = ConvertSeat(seat.Substring(0, 1))
        Dim col As Integer = CInt(seat.Substring(1, 1).ToString()) - 1

        'Replace passenger in selected seat with a new empty instance of Person type
        Seats(row, col) = New Ticket()

        'Save reservations file
        SaveReservations()
    End Sub

    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click

        Dim resFound As ListViewItem = Nothing
        Dim searchTerm As String = ""

        If NameSearch Then

            'Search using person's name
            'If First Name is blank, only search on Last Name
            If String.IsNullOrWhiteSpace(txtFirstName.Text) Then
                searchTerm = txtLastName.Text
            Else
                searchTerm = txtFirstName.Text & " " & txtLastName.Text
            End If

        Else
            'Search using Seat Number
            searchTerm = txtTicketNumber.Text

        End If

        'resFound = lvSearchResults.FindItemWithText(searchTerm, True, 0)
        resFound = lvSearchResults.FindItemWithText(searchTerm)

        'Search returns index of -1 if text not found, otherwise it returns the index of the found item in the list
        If resFound.Index <> -1 Then
            'Select the found item, and make sure it is visible to the user
            lvSearchResults.Focus()
            resFound.Selected = True
            lvSearchResults.Items(resFound.Index).Selected = True
            resFound.EnsureVisible()
        Else
            'Reservation was not found
            MessageBox.Show("The reservation for " & searchTerm & " was not found.",
                            "Reservation not found", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If

        'Erase previous search terms
        txtFirstName.Text = ""
        txtLastName.Text = ""
        txtTicketNumber.Text = ""


    End Sub
End Class