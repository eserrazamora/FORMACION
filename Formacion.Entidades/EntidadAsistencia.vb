Public Class EntidadAsistencia
    Public Property CodigoMatricula() As String
        Get
            Return m_CodigoMatricula
        End Get
        Set(ByVal value As String)
            m_CodigoMatricula = value
        End Set
    End Property
    Private m_CodigoMatricula As String

    Public Property Fecha() As Date?
        Get
            Return m_Fecha
        End Get
        Set(ByVal value As Date?)
            m_Fecha = value
        End Set
    End Property
    Private m_Fecha As Date?

    Public Property Asistio() As Char
        Get
            Return m_Asistio
        End Get
        Set(ByVal value As Char)
            m_Asistio = value
        End Set
    End Property
    Private m_Asistio As Char
End Class
