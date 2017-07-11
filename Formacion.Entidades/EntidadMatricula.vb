Public Class EntidadMatricula
    Public Property CodigoMatricula() As String
        Get
            Return m_CodigoMatricula
        End Get
        Set(ByVal value As String)
            m_CodigoMatricula = value
        End Set
    End Property
    Private m_CodigoMatricula As String

    Public Property NifAlumno() As String
        Get
            Return m_NifAlumno
        End Get
        Set(ByVal value As String)
            m_NifAlumno = value
        End Set
    End Property
    Private m_NifAlumno As String

    Public Property CodigoCurso() As String
        Get
            Return m_CodigoCurso
        End Get
        Set(ByVal value As String)
            m_CodigoCurso = value
        End Set
    End Property
    Private m_CodigoCurso As String

    Public Property Pagado() As Char
        Get
            Return m_Pagado
        End Get
        Set(ByVal value As Char)
            m_Pagado = value
        End Set
    End Property
    Private m_Pagado As Char

End Class
