Public Class EntidadCalificacion
    Public Property CodigoMatricula() As String
        Get
            Return m_CodigoMatricula
        End Get
        Set(ByVal value As String)
            m_CodigoMatricula = value
        End Set
    End Property
    Private m_CodigoMatricula As String

    Public Property Calificacion() As Decimal?
        Get
            Return m_Calificacion
        End Get
        Set(ByVal value As Decimal?)
            m_Calificacion = value
        End Set
    End Property
    Private m_Calificacion As Decimal?

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
