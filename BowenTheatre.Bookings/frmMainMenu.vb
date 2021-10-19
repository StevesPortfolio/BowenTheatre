Public Class frmMainMenu




#Region "Event Handlers"

    Private Sub frmMainMenu_Load(sender As Object, e As EventArgs) Handles Me.Load

        CreateReservationsArray()

        'Prepare list to hold bookings from file
        Dim res As New List(Of Ticket)

        'Read the bookings file and put contents into temp variable res
        res = GetReservations()

        'Using list of bookings (res), populate seat array with reserved seats
        PopulateReservations(res)

    End Sub

    Private Sub btnCancelBooking_Click(sender As Object, e As EventArgs) Handles btnCancelBooking.Click, mnuBookingsCancelBooking.Click
        CancelReservation = True
        frmSearch.Show()
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click, mnuBookingsExit.Click
        Application.Exit()
    End Sub

    Private Sub btnMakeBooking_Click(sender As Object, e As EventArgs) Handles btnMakeBooking.Click, mnuBookingsNew.Click
        frmMakeBooking.Show()
    End Sub

    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click, mnuSearch.Click
        CancelReservation = False
        frmSearch.Show()
    End Sub

    Private Sub btnDisplaySeats_Click(sender As Object, e As EventArgs) Handles btnDisplaySeats.Click, mnuBookingsView.Click
        frmSelectSeat.Show()
    End Sub


#End Region

#Region "Private Methods"

    Private Sub CreateReservationsArray()

        'Create array and fill with known "blank" values
        Seats(3, 5) = New Ticket With {.FirstName = "", .LastName = "", .Type = TicketType.Available}

        'Loop through seats and assign seat numbers
        For r = 0 To Seats.GetUpperBound(0)
            For c = 0 To Seats.GetUpperBound(1)

                Seats(r, c).SeatNumber = ConvertSeat(r).ToString() + CType((c + 1), String)
            Next
        Next
    End Sub



#End Region
End Class
