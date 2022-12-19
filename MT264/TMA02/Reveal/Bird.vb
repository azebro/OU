Public Class Bird
    Private _species As String
    Public Property Species() As String
        Get
            Return _species
        End Get
        Set(ByVal value As String)
            _species = value
        End Set
    End Property

    Private _habitat As String
    Public Property Habitat() As String
        Get
            Return _habitat
        End Get
        Set(ByVal value As String)
            _habitat = value
        End Set
    End Property

End Class
