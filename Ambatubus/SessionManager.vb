''' <summary>
''' Holds the currently logged-in passenger's session for the lifetime of the application.
''' Session is cleared when the user logs out or the app closes.
''' </summary>
Public Module SessionManager
    Private _passengerId As Integer = 0
    Private _passengerName As String = String.Empty
    Private _passengerPhone As String = String.Empty

    ''' <summary>True if a passenger is currently logged in.</summary>
    Public ReadOnly Property IsLoggedIn As Boolean
        Get
            Return _passengerId > 0
        End Get
    End Property

    ''' <summary>The logged-in passenger's database ID.</summary>
    Public ReadOnly Property CurrentPassengerId As Integer
        Get
            Return _passengerId
        End Get
    End Property

    ''' <summary>The logged-in passenger's full name.</summary>
    Public ReadOnly Property CurrentPassengerName As String
        Get
            Return _passengerName
        End Get
    End Property

    ''' <summary>The logged-in passenger's phone number.</summary>
    Public ReadOnly Property CurrentPassengerPhone As String
        Get
            Return _passengerPhone
        End Get
    End Property

    ''' <summary>Sets the session after a successful login.</summary>
    Public Sub Login(passengerId As Integer, name As String, phone As String)
        _passengerId = passengerId
        _passengerName = name
        _passengerPhone = phone
    End Sub

    ''' <summary>Clears the session (logout).</summary>
    Public Sub Logout()
        _passengerId = 0
        _passengerName = String.Empty
        _passengerPhone = String.Empty
    End Sub
End Module
