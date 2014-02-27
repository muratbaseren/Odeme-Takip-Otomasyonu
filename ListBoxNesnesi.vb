Public Class ListBoxNesnesi

#Region "yerel degiskenler"
    Private myValue As String
    Private myId As String
#End Region

#Region "kurucu kod"

    Public Sub New(ByVal srtValue As String, ByVal strId As String)
        myValue = srtValue
        myId = strId
    End Sub

    Public Sub New()
        myValue = ""
        myId = ""
    End Sub
#End Region

#Region "ozellikler"
    Property Id() As String

        Get
            Return myId

        End Get
        Set(ByVal Value As String)
            myId = Value

        End Set
    End Property

    Property value() As String
        Get
            Return myValue

        End Get
        Set(ByVal Value As String)
            myValue = Value

        End Set
    End Property

#End Region

#Region "metotlar"

    Public Overrides Function tostring() As String
        Return myValue
    End Function
#End Region

End Class
