Public Class EntidadLogin
    Public Property Nif() As String
        Get
            Return m_Nif
        End Get
        Set(ByVal value As String)
            m_Nif = value
        End Set
    End Property
    Private m_Nif As String
    Public Property NombreCompleto() As String
        Get
            Return m_NombreCompleto
        End Get
        Set(ByVal value As String)
            m_NombreCompleto = value
        End Set
    End Property
    Private m_NombreCompleto As String
    Public Property Usuario() As String
        Get
            Return m_Usuario
        End Get
        Set(ByVal value As String)
            m_Usuario = value
        End Set
    End Property
    Private m_Usuario As String

    Public Property Contraseña() As String
        Get
            Return m_Contraseña
        End Get
        Set(ByVal value As String)
            m_Contraseña = value
        End Set
    End Property
    Private m_Contraseña As String

    Public Property TipoUsuario() As String
        Get
            Return m_TipoUsuario
        End Get
        Set(ByVal value As String)
            m_TipoUsuario = value
        End Set
    End Property
    Private m_TipoUsuario As String

End Class
