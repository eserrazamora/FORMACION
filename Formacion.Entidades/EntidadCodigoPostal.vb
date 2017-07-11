Public Class EntidadCodigoPostal
    Public Property CodigoPostal() As String
        Get
            Return m_CodigoPostal
        End Get
        Set(ByVal value As String)
            m_CodigoPostal = value
        End Set
    End Property
    Private m_CodigoPostal As String

    Public Property Provincia() As String
        Get
            Return m_Provincia
        End Get
        Set(ByVal value As String)
            m_Provincia = value
        End Set
    End Property
    Private m_Provincia As String

    Public Property Localidad() As String
        Get
            Return m_Localidad
        End Get
        Set(ByVal value As String)
            m_Localidad = value
        End Set
    End Property
    Private m_Localidad As String

End Class
