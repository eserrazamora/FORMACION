Public Class EntidadRol
    Public Property Codigo() As String
        Get
            Return m_Codigo
        End Get
        Set(ByVal value As String)
            m_Codigo = value
        End Set
    End Property
    Private m_Codigo As String

    Public Property Rol() As String
        Get
            Return m_Rol
        End Get
        Set(ByVal value As String)
            m_Rol = value
        End Set
    End Property
    Private m_Rol As String

End Class
