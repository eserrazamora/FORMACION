Public Class EntidadTiposUsuarios
    Public Property Codigo() As String
        Get
            Return m_Codigo
        End Get
        Set(ByVal value As String)
            m_Codigo = value
        End Set
    End Property
    Private m_Codigo As String

    Public Property Tipo() As String
        Get
            Return m_Tipo
        End Get
        Set(ByVal value As String)
            m_Tipo = value
        End Set
    End Property
    Private m_Tipo As String
End Class
