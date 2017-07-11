Public Class EntidadPersona
    Public Property Nif() As String
        Get
            Return m_Nif
        End Get
        Set(ByVal value As String)
            m_Nif = value
        End Set
    End Property
    Private m_Nif As String

    Public Property Nombre() As String
        Get
            Return m_Nombre
        End Get
        Set(ByVal value As String)
            m_Nombre = value
        End Set
    End Property
    Private m_Nombre As String

    Public Property Apellidos() As String
        Get
            Return m_Apellidos
        End Get
        Set(ByVal value As String)
            m_Apellidos = value
        End Set
    End Property
    Private m_Apellidos As String

    Public Property Sexo() As Char
        Get
            Return m_Sexo
        End Get
        Set(ByVal value As Char)
            m_Sexo = value
        End Set
    End Property
    Private m_Sexo As Char

    Public Property FechaNacimiento() As Date?
        Get
            Return m_FechaNacimiento
        End Get
        Set(ByVal value As Date?)
            m_FechaNacimiento = value
        End Set
    End Property
    Private m_FechaNacimiento As Date?

    Public Property Direccion() As String
        Get
            Return m_Direccion
        End Get
        Set(ByVal value As String)
            m_Direccion = value
        End Set
    End Property
    Private m_Direccion As String

    Public Property Codigopostal() As String
        Get
            Return m_Codigopostal
        End Get
        Set(ByVal value As String)
            m_Codigopostal = value
        End Set
    End Property
    Private m_Codigopostal As String

    Public Property Email() As String
        Get
            Return m_Email
        End Get
        Set(ByVal value As String)
            m_Email = value
        End Set
    End Property
    Private m_Email As String

    Public Property TelefonoFijo() As String
        Get
            Return m_TelefonoFijo
        End Get
        Set(ByVal value As String)
            m_TelefonoFijo = value
        End Set
    End Property
    Private m_TelefonoFijo As String

    Public Property TelefonoMovil() As String
        Get
            Return m_TelefonoMovil
        End Get
        Set(ByVal value As String)
            m_TelefonoMovil = value
        End Set
    End Property
    Private m_TelefonoMovil As String

    Public Property Rol() As String
        Get
            Return m_Rol
        End Get
        Set(ByVal value As String)
            m_Rol = value
        End Set
    End Property
    Private m_Rol As String

    Public Property FechaAlta() As Date?
        Get
            Return m_FechaAlta
        End Get
        Set(ByVal value As Date?)
            m_FechaAlta = value
        End Set
    End Property
    Private m_FechaAlta As Date?


    Public Property FechaBaja() As Date?
        Get
            Return m_FechaBaja
        End Get
        Set(ByVal value As Date?)
            m_FechaBaja = value
        End Set
    End Property
    Private m_FechaBaja As Date?

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

