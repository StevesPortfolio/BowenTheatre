
'Program Title: Bowen Theatre
'Author: Steve Teece
'Student Number: 804727850
'Version: 1.0
'Date: 12 April, 2018
'Module: frmSeatSelect
'Task: Continuing VB, Assessment Task 1


Imports System.ComponentModel

Public Class frmSelectSeat

    Public SeatsLeft As Integer = 0

#Region "Private Methods"

    ''' <summary>
    ''' Draw a dynamic array of Buttons to act as a seating chart
    ''' </summary>
    Private Sub DrawSeatButtons()

        'Create seating array
        Dim rows As Integer = 3
        Dim cols As Integer = 5
        Dim width As Integer = 50
        Dim space As Integer = 3
        Dim IsleSpace As Integer = 50
        Dim r, c As Integer
        Dim topStartingPosition As Integer = 175
        Dim leftStartingPosition As Integer = 80

        'Clear any previous array dictionary
        SeatingButtons.Clear()

        'Create seating chart as array of buttons
        For r = 0 To rows
            leftStartingPosition = 80
            'Create first three seats
            For c = 0 To 2
                Dim temp As New Button
                With temp
                    .Width = width
                    .Height = width
                    .Left = leftStartingPosition + c * (space + width)
                    .Top = topStartingPosition + r * (space + width)
                    .Text = (ConvertSeat(r)).ToString() & c + 1
                    .Name = "btn" & (ConvertSeat(r)).ToString() & c + 1

                    AddHandler temp.Click, AddressOf Seat_Click
                End With
                ttSelectSeat.SetToolTip(temp, "Select a seat to reserve")
                'Add button to dictionary
                SeatingButtons.Add(temp.Text, temp)
                'Track button in dictionary by tag
                temp.Tag = ConvertSeat(r) + (cols + 1).ToString()
                Me.Controls.Add(temp)
            Next
            'Create last 3 seats and leave a gap for the isle
            For c = 3 To cols
                leftStartingPosition = 150
                Dim temp As New Button
                With temp
                    .Width = width
                    .Height = width
                    .Left = leftStartingPosition + c * (space + width)
                    .Top = topStartingPosition + r * (space + width)
                    .Text = (ConvertSeat(r)).ToString() & c + 1
                    .Name = "btn" & (ConvertSeat(r)).ToString() & c + 1
                    AddHandler temp.Click, AddressOf Seat_Click
                End With
                ttSelectSeat.SetToolTip(temp, "Select a seat to reserve")
                'Add button to dictionary
                SeatingButtons.Add(temp.Text, temp)
                'Track button in dictionary by tag
                temp.Tag = ConvertSeat(r) + (cols + 1).ToString()
                Me.Controls.Add(temp)
            Next
        Next

    End Sub



    ''' <summary>
    ''' Loop through seating array, and mark seats that have a name recorded against them as Reserved
    ''' </summary>
    Private Sub MarkReservations()

        'Loop through seats looking for reservations
        For r As Integer = 0 To Seats.GetUpperBound(0)
            For c As Integer = 0 To Seats.GetUpperBound(1)
                Dim seatname As String = ConvertSeat(r) + CType(c + 1, String)
                If Seats(r, c).Type = TicketType.Available Then
                    'Seat is available
                    SeatingButtons.Item(seatname).BackColor = lblAvailable.BackColor

                Else
                    'Seat has been reserved
                    SeatingButtons.Item(seatname).BackColor = lblSeatReserved.BackColor
                End If

            Next
        Next

    End Sub

#End Region



#Region "Event Handlers"
    Private Sub frmSelectSeat_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DrawSeatButtons()
        MarkReservations()

        Try
            SeatsLeft = Booking.Count()
        Catch ex As Exception
            SeatsLeft = 0
        End Try

        txtSeatsLeft.Text = SeatsLeft


    End Sub

    Private Sub btnOK_Click(sender As Object, e As EventArgs) Handles btnOK.Click
        SaveReservations()
        Me.Close()
    End Sub


#End Region


    Private Sub Seat_Click(sender As Object, e As EventArgs)

        'If customer has not picked all their seats
        If SeatsLeft > 0 Then
            Dim seatname As String = Strings.Right(sender.ToString(), 2)
            Dim r As Integer = 0
            Dim c As Integer = 0
            Dim index As Integer = SeatsLeft - 1

            r = ConvertSeat(Strings.Left(seatname, 1))
            c = CInt(Strings.Right(seatname, 1)) - 1

            With Seats(r, c)
                .FirstName = Booking(index).FirstName
                .LastName = Booking(index).LastName
                .Type = Booking(index).Type
                .SeatNumber = seatname

            End With

            SeatingButtons(seatname).BackColor = lblSeatReserved.BackColor

            SeatsLeft -= 1
            txtSeatsLeft.Text = SeatsLeft

        Else
            MessageBox.Show("You have selected all of your seats", "All seats selected", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If



    End Sub

    Private Sub frmSelectSeat_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        Me.Dispose()
    End Sub
End Class