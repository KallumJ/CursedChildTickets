Module DataStructures

    'Define Customer structure
    Public Structure CustomerType
        Dim customerID As Integer
        <VBFixedString(4)> Dim title As String
        <VBFixedString(20)> Dim firstName As String
        <VBFixedString(20)> Dim Surname As String
        <VBFixedString(11)> Dim phoneNumber As String
        <VBFixedString(50)> Dim email As String
        <VBFixedString(75)> Dim address As String
        <VBFixedString(8)> Dim Postcode As String
    End Structure

    'Declare Customer Record
    Public customerRecord As CustomerType

    'Define Show Time structure
    Public Structure ShowTimeType
        Dim showtimeID As Integer
        <VBFixedString(10)> Dim showtimeDate As Date
        Dim part As Integer
        Dim avaliable As Boolean
    End Structure

    'Declare Show Time Record
    Public showtimeRecord As ShowTimeType

    'Define Reservations structure
    Public Structure ReservationsType
        Dim reservationID As Integer
        Dim customerID As Integer
        Dim showtimeID As Integer
        <VBFixedString(10)> Dim reservationDate As Date
        Dim quantity As Integer
        <VBFixedString(10)> Dim totalPrice As Decimal
    End Structure

    'Declare Reservations Record
    Public reservationRecord As ReservationsType

    'Define Reserved Seats structure
    Public Structure ReservedSeatsType
        Dim reservationID As Integer
        <VBFixedString(4)> Dim seat As String
    End Structure

    'Declare Reserved Seats Record
    Public reservedSeatsRecord As ReservedSeatsType

    'Define Seats structure
    Public Structure SeatsType
        <VBFixedString(4)> Dim seat As String
        <VBFixedString(1)> Dim priceBand As Char
    End Structure

    'Declare Seats Record
    Public seatsRecord As SeatsType

    'Define Users Structure
    Public Structure UserType
        Dim staffID As integer
        <VBFixedString(25)> Dim username As String
        <VBFixedString(30)> Dim password As String
    End Structure

    'Declare User Record
    Public userRecord As UserType
End Module
