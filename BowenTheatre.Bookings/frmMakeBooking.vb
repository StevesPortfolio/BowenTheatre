
'Program Title: Bowen Theatre
'Author: Steve Teece
'Student Number: 804727850
'Version: 1.0
'Date: 17 April, 2018
'Module: frmMakeBooking
'Task: Continuing VB, Assessment Task 1

Public Class frmMakeBooking
    Dim payable As Decimal
    Dim totaltickets As Integer = 0
    Dim adultTickets As Integer = 0
    Dim concessionTickets As Integer = 0

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub

    Private Sub UpdatePayable()

        payable = (nudAdultSeats.Value * AdultSeatPrice) + (nudConcessionSeats.Value * ConcessionSeatPrice)
        totaltickets = nudAdultSeats.Value + nudConcessionSeats.Value
        txtAmountPayable.Text = FormatCurrency(payable)

    End Sub

    Private Sub nudAdultSeats_ValueChanged(sender As Object, e As EventArgs) Handles nudAdultSeats.ValueChanged
        UpdatePayable()
    End Sub

    Private Sub nudConcessionSeats_ValueChanged(sender As Object, e As EventArgs) Handles nudConcessionSeats.ValueChanged
        UpdatePayable()
    End Sub

    Private Sub frmMakeBooking_Load(sender As Object, e As EventArgs) Handles Me.Load
        ResetForm()
    End Sub

    Private Sub btnSelectSeats_Click(sender As Object, e As EventArgs) Handles btnSelectSeats.Click
        'Find out how many tickets are needed
        adultTickets = nudAdultSeats.Value
        concessionTickets = nudConcessionSeats.Value
        totaltickets = adultTickets + concessionTickets
        Dim index As Integer = totaltickets - 1

        'Resize temporary booking() to allocate tickets to customer
        ReDim Booking(index)

        'Build new Bookings array for this customer
        Booking(index) = New Ticket

        For counter As Integer = 0 To index
            With Booking(counter)
                .FirstName = txtFirstName.Text
                .LastName = txtLastName.Text
                If adultTickets > 0 Then
                    .Type = TicketType.Adult
                    adultTickets -= 1

                ElseIf concessionTickets > 0 Then
                    .Type = TicketType.Concession
                    concessionTickets -= 1

                End If
            End With

        Next

        frmSelectSeat.Show()
        'Once Select Seats form is finished with, destroy it to prevent errors when  attempting to redraw screen for next bookings

        ResetForm()


    End Sub

    Private Sub btnOK_Click(sender As Object, e As EventArgs) Handles btnOK.Click
        SaveReservations()
        Me.Close()

    End Sub

    Private Sub ResetForm()
        txtFirstName.Text = ""
        txtLastName.Text = ""
        payable = 0
        nudAdultSeats.Value = 1
        nudConcessionSeats.Value = 0
        concessionTickets = 0
        adultTickets = 0
        totaltickets = 0
    End Sub


End Class