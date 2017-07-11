Public Class EntidadCurso
    Public Property CodigoCurso() As String
        Get
            Return m_CodigoCurso
        End Get
        Set(ByVal value As String)
            m_CodigoCurso = value
        End Set
    End Property
    Private m_CodigoCurso As String

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

    Public Property Duracion() As UShort
        Get
            Return m_Duracion
        End Get
        Set(ByVal value As UShort)
            m_Duracion = value
        End Set
    End Property
    Private m_Duracion As UShort

    Public Property FechaInicio() As Date
        Get
            Return m_FechaInicio
        End Get
        Set(ByVal value As Date)
            m_FechaInicio = value
        End Set
    End Property
    Private m_FechaInicio As Date

    Public Property FechaFin() As Date
        Get
            Return m_FechaFin
        End Get
        Set(ByVal value As Date)
            m_FechaFin = value
        End Set
    End Property
    Private m_FechaFin As Date

    Public Property Coste() As UShort
        Get
            Return m_Coste
        End Get
        Set(ByVal value As UShort)
            m_Coste = value
        End Set
    End Property
    Private m_Coste As UShort

    Public Property Aula() As String
        Get
            Return m_Aula
        End Get
        Set(ByVal value As String)
            m_Aula = value
        End Set
    End Property
    Private m_Aula As String

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
