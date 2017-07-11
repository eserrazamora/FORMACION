Public Class EntidadAula
    Public Property Codigo() As String
        Get
            Return m_Codigo
        End Get
        Set(ByVal value As String)
            m_Codigo = value
        End Set
    End Property
    Private m_Codigo As String

    Public Property Nombre() As String
        Get
            Return m_Nombre
        End Get
        Set(ByVal value As String)
            m_Nombre = value
        End Set
    End Property
    Private m_Nombre As String

    Public Property Tipo() As String
        Get
            Return m_Tipo
        End Get
        Set(ByVal value As String)
            m_Tipo = value
        End Set
    End Property
    Private m_Tipo As String
    Public Property TipoNombre() As String
        Get
            Return m_TipoNombre
        End Get
        Set(ByVal value As String)
            m_TipoNombre = value
        End Set
    End Property
    Private m_TipoNombre As String
    Public Property Observaciones() As String
        Get
            Return m_Observaciones
        End Get
        Set(ByVal value As String)
            m_Observaciones = value
        End Set
    End Property
    Private m_Observaciones As String

End Class
