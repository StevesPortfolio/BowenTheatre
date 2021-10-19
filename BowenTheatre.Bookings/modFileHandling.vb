Imports System.IO

'Program Title: Bowen Theatre
'Author: Steve Teece
'Student Number: 804727850
'Version: 1.0
'Date: 12 April, 2018
'Module: modFileHandling
'Task: Continuing VB, Assessment Task 1

''' <summary>
''' This module contains the code to load and save the reservations file.
''' </summary>
''' 
Module modFileHandling

    Public Function GetReservations() As List(Of Ticket)

        Dim bookings As New List(Of Ticket)

        'Try to read the Bookings file
        Try
            Dim sr As New StreamReader(bookingFile)

            Do While Not sr.EndOfStream
                If sr.Peek() >= 0 Then
                    Dim tempstring As String
                    tempstring = sr.ReadLine()
                    bookings.Add(Inflate(tempstring))

                End If
            Loop
            sr.Close()
            IsNoBookingFile = False
        Catch ex As FileNotFoundException
            MessageBox.Show("The bookings file could not be found. A new file has been created.", "Bookings file not found", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Dim sw As New StreamWriter(bookingFile)
            sw.Close()
            IsNoBookingFile = True
        End Try

        Return bookings
    End Function

    Public Sub SaveReservations()

        Try
            Dim sw As New StreamWriter(bookingFile)

            For r = 0 To Seats.GetUpperBound(0)
                For c = 0 To Seats.GetUpperBound(1)
                    If Not String.IsNullOrWhiteSpace(Seats(r, c).FirstName) Or
                        Not String.IsNullOrWhiteSpace(Seats(r, c).LastName) Then
                        Dim line As String
                        line = Deflate(Seats(r, c))
                        sw.WriteLine(line)
                    End If
                Next
            Next
            sw.Close()
            IsNoBookingFile = False
        Catch ex As FileNotFoundException
            MessageBox.Show("The bookings file could not be found.", "Bookings file not found", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Try
    End Sub


End Module
