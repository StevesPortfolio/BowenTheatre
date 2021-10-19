Imports System.IO

'Program Title: Bowen Theatre
'Author: Steve Teece
'Student Number: 804727850
'Version: 1.0
'Date: 12 April, 2018
'Module: modCommon
'Task: Continuing VB, Assessment Task 1

''' <summary>
''' This module will contain public code and public define variables common to the whole program.
''' </summary>

Module modCommon

#Region "Public Variables and Structures"

    Public Enum TicketType
        Available
        Adult
        Concession
    End Enum

    Public Structure Ticket
        Public FirstName As String
        Public LastName As String
        Public SeatNumber As String
        Public Type As TicketType
    End Structure

    Public Seats(3, 5) As Ticket

    Public Const bookingFile = "Bookings.csv"

    Public Booking() As Ticket

    Public Const AdultSeatPrice As Decimal = 14.5D
    Public Const ConcessionSeatPrice As Decimal = 8.75D

    Public CancelReservation As Boolean = False
    Public IsNoBookingFile As Boolean = False

    Public SeatingButtons As Dictionary(Of String, Button) = New Dictionary(Of String, Button)

#End Region

#Region "Public Methods"


    Public Function ConvertSeat(r As Integer) As String

        Select Case r
            Case 0
                Return "A"
            Case 1
                Return "B"
            Case 2
                Return "C"
            Case 3
                Return "D"
        End Select

        'If r not a valid row
        Return Nothing
    End Function

    Public Function ConvertSeat(seat As String) As Integer

        'Look at first letter of Seat Number, and convert to numeric value for Row Index
        Select Case seat.Substring(0, 1)
            Case "A"
                Return 0
            Case "B"
                Return 1
            Case "C"
                Return 2
            Case "D"
                Return 3
        End Select
        'If not a valid row, return nothing 
        Return Nothing

    End Function

    ''' <summary>
    ''' Inflates a single line of comma seperated test into a Ticket
    ''' </summary>
    ''' <param name="line">String containing comma separated values</param>
    ''' <returns>Ticket</returns>
    Public Function Inflate(line As String) As Ticket

        'Expected File Format
        'FirstName,LastName,SeatNumber,SeatType
        'Indexes:
        ' 0 = FirstName
        ' 1 = LastName
        ' 2 = SeatNumber
        ' 3 = SeatType

        Dim output As Ticket = Nothing
        Dim temp As String()

        temp = Split(line, ","c)
        output.FirstName = temp(0)
        output.LastName = temp(1)
        output.SeatNumber = temp(2)
        output.Type = (3)

        Return output

    End Function

    Public Function Deflate(t As Ticket) As String

        'Expected File Format
        'FirstName,LastName,SeatNumber,SeatType

        Dim output As String = ""

        output = t.FirstName.ToString() & "," &
            t.LastName.ToString() & "," &
            t.SeatNumber.ToString() & "," &
            t.Type.ToString()

        Return output

    End Function

    ''' <summary>
    ''' Converts list of type Ticket into a reserved seat, and populates the seating array
    ''' </summary>
    ''' <param name="bookings">List of type Ticket</param>
    Public Sub PopulateReservations(bookings As List(Of Ticket))

        For Each b In bookings
            Dim r As Integer = 0
            Dim c As Integer = 0
            r = ConvertSeat(b.SeatNumber)
            c = CInt(b.SeatNumber.Substring(1, 1)) - 1
            Seats(r, c) = b

        Next
    End Sub





#End Region

End Module
