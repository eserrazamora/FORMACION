
Imports Formacion.Entidades
Imports System.Data.SqlClient
Imports System.Configuration


Public NotInheritable Class PersonasDAL

    Public Shared Function CargarTodos(ByVal rol As String) As List(Of EntidadPersona)
        Dim list As New List(Of EntidadPersona)()

        Using conn As New SqlConnection(ConfigurationManager.ConnectionStrings("default").ToString())
            conn.Open()

            Dim cmd As New SqlCommand("PROC_PERSONAS_CargarTodos", conn)
            cmd.CommandType = CommandType.StoredProcedure

            If rol <> "TODOS" Then
                cmd.Parameters.AddWithValue("@Rol", rol)
            End If

            Dim reader As SqlDataReader = cmd.ExecuteReader()

            While reader.Read()
                list.Add(CargarPersona(reader))
            End While
        End Using

        Return list
    End Function


    Private Shared Function CargarPersona(ByVal reader As IDataReader) As EntidadPersona
        Dim persona As New EntidadPersona()

        persona.Nif = CStr(reader("Nif"))

        If reader("Nombre") Is DBNull.Value Then
            persona.Nombre = Nothing
        Else
            persona.Nombre = CStr(reader("Nombre"))
        End If

        persona.Apellidos = CStr(reader("Apellidos"))
        persona.Sexo = CChar(reader("Sexo"))

        If reader("FechaNacimiento") Is DBNull.Value Then
            persona.FechaNacimiento = Nothing
        Else
            persona.FechaNacimiento = Convert.ToDateTime(reader("FechaNacimiento"))
        End If

        If reader("Direccion") Is DBNull.Value Then
            persona.Direccion = Nothing
        Else
            persona.Direccion = CStr(reader("Direccion"))
        End If

        If reader("CodigoPostal") Is DBNull.Value Then
            persona.Codigopostal = Nothing
        Else
            persona.Codigopostal = CStr(reader("CodigoPostal"))
        End If

        persona.Email = CStr(reader("Email"))

        If reader("TelefonoFijo") Is DBNull.Value Then
            persona.TelefonoFijo = Nothing
        Else
            persona.TelefonoFijo = CStr(reader("TelefonoFijo"))
        End If

        If reader("TelefonoMovil") Is DBNull.Value Then
            persona.TelefonoMovil = Nothing
        Else
            persona.TelefonoMovil = CStr(reader("TelefonoMovil"))
        End If

        persona.Rol = CStr(reader("Rol"))

        If reader("FechaAlta") Is DBNull.Value Then
            persona.FechaAlta = Nothing
        Else
            persona.FechaAlta = Convert.ToDateTime(reader("FechaAlta"))
        End If

        If reader("FechaBaja") Is DBNull.Value Then
            persona.FechaBaja = Nothing
        Else
            persona.FechaBaja = Convert.ToDateTime(reader("FechaBaja"))
        End If

        If reader("Observaciones") Is DBNull.Value Then
            persona.Observaciones = Nothing
        Else
            persona.Observaciones = CStr(reader("Observaciones"))
        End If

        Return persona

    End Function


    Public Shared Function CargarUnNif(ByVal nif As String) As EntidadPersona
        Dim persona As EntidadPersona = Nothing

        Using conn As New SqlConnection(ConfigurationManager.ConnectionStrings("default").ToString())

            conn.Open()

            Dim cmd As New SqlCommand("PROC_PERSONAS_CargarNif", conn)
            cmd.CommandType = CommandType.StoredProcedure

            cmd.Parameters.AddWithValue("@NIF", nif)

            Dim reader As SqlDataReader = cmd.ExecuteReader()
            If reader.Read() Then
                persona = CargarPersona(reader)
            End If
        End Using

        Return persona

    End Function

    Public Shared Function Existe(ByVal nif As String) As Boolean
        Dim numeroderegistros As Integer = 0

        Using conn As New SqlConnection(ConfigurationManager.ConnectionStrings("default").ToString())
            conn.Open()

            Dim cmd As New SqlCommand("PROC_PERSONAS_Existe", conn)
            cmd.CommandType = CommandType.StoredProcedure

            cmd.Parameters.AddWithValue("@NIF", nif)

            numeroderegistros = CInt(cmd.ExecuteScalar())

        End Using

        Return numeroderegistros > 0

    End Function

    Public Shared Function Crear(ByVal persona As EntidadPersona) As EntidadPersona

        Using conn As New SqlConnection(ConfigurationManager.ConnectionStrings("default").ToString())

            conn.Open()

            Dim cmd As New SqlCommand("PROC_PERSONAS_CrearPersona", conn)
            cmd.CommandType = CommandType.StoredProcedure

            If persona.Nif <> Nothing Then
                cmd.Parameters.AddWithValue("@NIF", persona.Nif)
            Else
                cmd.Parameters.AddWithValue("@NIF", DBNull.Value)
            End If

            If persona.Nombre <> Nothing Then
                cmd.Parameters.AddWithValue("@Nombre", persona.Nombre)
            Else
                cmd.Parameters.AddWithValue("@Nombre", DBNull.Value)
            End If

            If persona.Apellidos <> Nothing Then
                cmd.Parameters.AddWithValue("@Apellidos", persona.Apellidos)
            Else
                cmd.Parameters.AddWithValue("@Apellidos", DBNull.Value)
            End If

            cmd.Parameters.AddWithValue("@Sexo", persona.Sexo)

            If Not IsNothing(persona.FechaNacimiento) Then
                cmd.Parameters.AddWithValue("@FechaNacimiento", persona.FechaNacimiento)
            Else
                cmd.Parameters.AddWithValue("@FechaNacimiento", DBNull.Value)
            End If

            If persona.Direccion <> Nothing Then
                cmd.Parameters.AddWithValue("@Direccion", persona.Direccion)
            Else
                cmd.Parameters.AddWithValue("@Direccion", DBNull.Value)
            End If


            If persona.Codigopostal <> Nothing Then
                cmd.Parameters.AddWithValue("@CodigoPostal", persona.Codigopostal)
            Else
                cmd.Parameters.AddWithValue("@CodigoPostal", DBNull.Value)
            End If


            If persona.Email <> Nothing Then
                cmd.Parameters.AddWithValue("@Email", persona.Email)
            Else
                cmd.Parameters.AddWithValue("@Email", DBNull.Value)
            End If


            If persona.TelefonoFijo <> Nothing Then
                cmd.Parameters.AddWithValue("@TelefonoFijo", persona.TelefonoFijo)
            Else
                cmd.Parameters.AddWithValue("@TelefonoFijo", DBNull.Value)
            End If

            If persona.TelefonoMovil <> Nothing Then
                cmd.Parameters.AddWithValue("@TelefonoMovil", persona.TelefonoMovil)
            Else
                cmd.Parameters.AddWithValue("@TelefonoMovil", DBNull.Value)
            End If

            cmd.Parameters.AddWithValue("@Rol", persona.Rol)

            If Not IsNothing(persona.FechaAlta) Then
                cmd.Parameters.AddWithValue("@FechaAlta", Convert.ToDateTime(persona.FechaAlta))
            Else
                cmd.Parameters.AddWithValue("@FechaAlta", DBNull.Value)
            End If

            cmd.Parameters.AddWithValue("@FechaBaja", DBNull.Value)

            cmd.Parameters.AddWithValue("@Observaciones", persona.Observaciones)

            cmd.ExecuteNonQuery()

        End Using

        Return persona

    End Function

    Public Shared Function Actualizar(ByVal persona As EntidadPersona) As EntidadPersona
        Using conn As New SqlConnection(ConfigurationManager.ConnectionStrings("default").ToString())
            conn.Open()

            Dim cmd As New SqlCommand("PROC_PERSONAS_ActualizarPersona", conn)
            cmd.CommandType = CommandType.StoredProcedure

            If persona.Nif <> Nothing Then
                cmd.Parameters.AddWithValue("@NIF", persona.Nif)
            Else
                cmd.Parameters.AddWithValue("@NIF", DBNull.Value)
            End If

            If persona.Nombre <> Nothing Then
                cmd.Parameters.AddWithValue("@Nombre", persona.Nombre)
            Else
                cmd.Parameters.AddWithValue("@Nombre", DBNull.Value)
            End If

            If persona.Apellidos <> Nothing Then
                cmd.Parameters.AddWithValue("@Apellidos", persona.Apellidos)
            Else
                cmd.Parameters.AddWithValue("@Apellidos", DBNull.Value)
            End If

            cmd.Parameters.AddWithValue("@Sexo", persona.Sexo)

            If Not IsNothing(persona.FechaNacimiento) Then
                cmd.Parameters.AddWithValue("@FechaNacimiento", persona.FechaNacimiento)
            Else
                cmd.Parameters.AddWithValue("@FechaNacimiento", DBNull.Value)
            End If

            If persona.Direccion <> Nothing Then
                cmd.Parameters.AddWithValue("@Direccion", persona.Direccion)
            Else
                cmd.Parameters.AddWithValue("@Direccion", DBNull.Value)
            End If


            If persona.Codigopostal <> Nothing Then
                cmd.Parameters.AddWithValue("@CodigoPostal", persona.Codigopostal)
            Else
                cmd.Parameters.AddWithValue("@CodigoPostal", DBNull.Value)
            End If


            If persona.Email <> Nothing Then
                cmd.Parameters.AddWithValue("@Email", persona.Email)
            Else
                cmd.Parameters.AddWithValue("@Email", DBNull.Value)
            End If


            If persona.TelefonoFijo <> Nothing Then
                cmd.Parameters.AddWithValue("@TelefonoFijo", persona.TelefonoFijo)
            Else
                cmd.Parameters.AddWithValue("@TelefonoFijo", DBNull.Value)
            End If

            If persona.TelefonoMovil <> Nothing Then
                cmd.Parameters.AddWithValue("@TelefonoMovil", persona.TelefonoMovil)
            Else
                cmd.Parameters.AddWithValue("@TelefonoMovil", DBNull.Value)
            End If

            cmd.Parameters.AddWithValue("@Rol", persona.Rol)

            If Not IsNothing(persona.FechaAlta) Then
                cmd.Parameters.AddWithValue("@FechaAlta", Convert.ToDateTime(persona.FechaAlta))
            Else
                cmd.Parameters.AddWithValue("@FechaAlta", DBNull.Value)
            End If

            cmd.Parameters.AddWithValue("@FechaBaja", DBNull.Value)

            cmd.Parameters.AddWithValue("@Observaciones", persona.Observaciones)

            cmd.ExecuteNonQuery()

        End Using

        Return persona
    End Function

    Public Shared Function CargarTodosEnDataTable(ByVal rol As String) As DataTable

        Dim dt As New DataTable()

        Using conn As New SqlConnection(ConfigurationManager.ConnectionStrings("default").ToString())
            conn.Open()


            Dim cmd As New SqlCommand("PROC_PERSONAS_CargarTodosEnDatatable", conn)
            cmd.CommandType = CommandType.StoredProcedure

            If rol <> "TODOS" Then
                cmd.Parameters.AddWithValue("@Rol", rol)
            End If

            Dim da As New SqlDataAdapter(cmd)

            da.Fill(dt)

        End Using

        Return dt

    End Function


    Public Shared Function CargarPersonasCursoEnDatatable(ByVal codigocurso As String) As DataTable

        Dim dt As New DataTable()

        Using conn As New SqlConnection(ConfigurationManager.ConnectionStrings("default").ToString())
            conn.Open()


            Dim cmd As New SqlCommand("PROC_PERSONAS_CargarTodasPersonasCurso", conn)
            cmd.CommandType = CommandType.StoredProcedure

            cmd.Parameters.AddWithValue("@CodigoCurso", codigocurso)

            Dim da As New SqlDataAdapter(cmd)

            da.Fill(dt)

        End Using

        Return dt

    End Function
    Public Shared Function CargarTodosAlumnosCursoEnDatatable(ByVal codigocurso As String) As DataTable

        Dim dt As New DataTable()

        Using conn As New SqlConnection(ConfigurationManager.ConnectionStrings("default").ToString())
            conn.Open()


            Dim cmd As New SqlCommand("PROC_PERSONAS_CargarTodosAlumnosCurso", conn)
            cmd.CommandType = CommandType.StoredProcedure

            cmd.Parameters.AddWithValue("@CodigoCurso", codigocurso)

            Dim da As New SqlDataAdapter(cmd)

            da.Fill(dt)

        End Using

        Return dt

    End Function

    Public Shared Function ConsultarDatosAlumnos(ByVal alumno As EntidadPersona) As DataTable

        Dim dt As New DataTable()

        Using conn As New SqlConnection(ConfigurationManager.ConnectionStrings("default").ToString())
            conn.Open()

            Dim cmd As New SqlCommand("PROC_PERSONAS_ConsultarDatosAlumnos", conn)
            cmd.CommandType = CommandType.StoredProcedure

            If alumno.Nif <> String.Empty Then
                cmd.Parameters.AddWithValue("@Nif", alumno.Nif)
            End If

            If alumno.Nombre <> String.Empty Then
                cmd.Parameters.AddWithValue("@Nombre", alumno.Nombre)
            End If

            If alumno.Apellidos <> String.Empty Then
                cmd.Parameters.AddWithValue("@Apellidos", alumno.Apellidos)
            End If

            If alumno.Email <> String.Empty Then
                cmd.Parameters.AddWithValue("@Email", alumno.Email)
            End If

            If alumno.TelefonoFijo <> String.Empty Then
                cmd.Parameters.AddWithValue("@TelefonoFijo", alumno.TelefonoFijo)
            End If

            If alumno.TelefonoMovil <> String.Empty Then
                cmd.Parameters.AddWithValue("@TelefonoMovil", alumno.TelefonoMovil)
            End If

            Dim da As New SqlDataAdapter(cmd)

            da.Fill(dt)

        End Using

        Return dt

    End Function
    Public Shared Function ConsultarDatosProfesores(ByVal profesor As EntidadPersona) As DataTable

        Dim dt As New DataTable()

        Using conn As New SqlConnection(ConfigurationManager.ConnectionStrings("default").ToString())
            conn.Open()

            Dim cmd As New SqlCommand("PROC_PERSONAS_ConsultarDatosProfesores", conn)
            cmd.CommandType = CommandType.StoredProcedure

            If profesor.Nif <> String.Empty Then
                cmd.Parameters.AddWithValue("@Nif", profesor.Nif)
            End If

            If profesor.Nombre <> String.Empty Then
                cmd.Parameters.AddWithValue("@Nombre", profesor.Nombre)
            End If

            If profesor.Apellidos <> String.Empty Then
                cmd.Parameters.AddWithValue("@Apellidos", profesor.Apellidos)
            End If

            If profesor.Email <> String.Empty Then
                cmd.Parameters.AddWithValue("@Email", profesor.Email)
            End If

            If profesor.TelefonoFijo <> String.Empty Then
                cmd.Parameters.AddWithValue("@TelefonoFijo", profesor.TelefonoFijo)
            End If

            If profesor.TelefonoMovil <> String.Empty Then
                cmd.Parameters.AddWithValue("@TelefonoMovil", profesor.TelefonoMovil)
            End If

            Dim da As New SqlDataAdapter(cmd)

            da.Fill(dt)

        End Using

        Return dt

    End Function
    Public Shared Function ComprobarDependencias(ByVal nif As String) As Boolean
        Dim numeroderegistros As Integer = 0

        Using conn As New SqlConnection(ConfigurationManager.ConnectionStrings("default").ToString())
            conn.Open()

            Dim cmd As New SqlCommand("PROC_PERSONAS_ComprobarDependencias", conn)
            cmd.CommandType = CommandType.StoredProcedure

            Dim paramIndicador As New SqlParameter("indicador", SqlDbType.Int)
            paramIndicador.Direction = ParameterDirection.Output
            cmd.Parameters.Add(paramIndicador)

            cmd.Parameters.AddWithValue("@NIF", nif)
            Dim rowsAffected As Integer = cmd.ExecuteNonQuery()

            If (Convert.ToInt32(cmd.Parameters("Indicador").Value)) > 0 Then
                'Si indicador esta a 1 entonces hay dependencias
                Return True
            Else
                Return False
            End If

        End Using

        Return numeroderegistros > 0

    End Function
    Public Shared Function Borrar(ByVal codigo As String) As Integer
        Dim numeroderegistros As Integer = 0

        Using conn As New SqlConnection(ConfigurationManager.ConnectionStrings("default").ToString())
            conn.Open()

            Dim cmd As New SqlCommand("PROC_PERSONAS_BorrarPersona", conn)
            cmd.CommandType = CommandType.StoredProcedure

            cmd.Parameters.AddWithValue("@NifAlumno", codigo)

            numeroderegistros = Convert.ToInt32(cmd.ExecuteScalar())
        End Using

        Return numeroderegistros
    End Function
End Class
