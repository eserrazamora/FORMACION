Public Class EntidadProfesorCurso
    Public Property NifProfesor() As String
        Get
            Return m_NifProfesor
        End Get
        Set(ByVal value As String)
            m_NifProfesor = value
        End Set
    End Property
    Private m_NifProfesor As String

    Public Property CodigoCurso() As String
        Get
            Return m_CodigoCurso
        End Get
        Set(ByVal value As String)
            m_CodigoCurso = value
        End Set
    End Property
    Private m_CodigoCurso As String
End Class
