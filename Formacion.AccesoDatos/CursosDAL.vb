Imports Formacion.Entidades
Imports System.Data.SqlClient
Imports System.Configuration

Public NotInheritable Class CursosDAL

    Public Shared Function CargarTodos() As List(Of EntidadCursos)
        Dim list As New List(Of EntidadCursos)()

        Using conn As New SqlConnection(ConfigurationManager.ConnectionStrings("default").ToString())
            conn.Open()

            Dim cmd As New SqlCommand("PROC_CURSOS_CargarCursos", conn)
            cmd.CommandType = CommandType.StoredProcedure

            Dim reader As SqlDataReader = cmd.ExecuteReader()

            While reader.Read()
                list.Add(CargarCurso(reader))
            End While
        End Using

        Return list
    End Function
    
    Public Shared Function CargarCursosAula(ByVal aula As String) As List(Of EntidadCursos)
        Dim list As New List(Of EntidadCursos)()

        Using conn As New SqlConnection(ConfigurationManager.ConnectionStrings("default").ToString())
            conn.Open()

            Dim cmd As New SqlCommand("PROC_CURSOS_CargarCursosAula", conn)
            cmd.CommandType = CommandType.StoredProcedure

            cmd.Parameters.AddWithValue("@aula", aula)

            Dim reader As SqlDataReader = cmd.ExecuteReader()

            While reader.Read()
                list.Add(CargarCurso(reader))
            End While
        End Using

        Return list
    End Function

    Private Shared Function CargarCurso(ByVal reader As IDataReader) As EntidadCursos
        Dim curso As New EntidadCursos()

        curso.CodigoCurso = CStr(reader("CodigoCurso"))
        curso.Nombre = CStr(reader("Nombre"))

        If reader("Tipo") Is DBNull.Value Then
            curso.Tipo = Nothing
        Else
            curso.Tipo = CStr(reader("Tipo"))
        End If

        If reader("TipoNombre") Is DBNull.Value Then
            curso.TipoNombre = Nothing
        Else
            curso.TipoNombre = CStr(reader("TipoNombre"))
        End If

        curso.Duracion = Convert.ToInt32(reader("Duracion"))
        curso.FechaInicio = Convert.ToDateTime(reader("FechaInicio"))
        curso.FechaFin = Convert.ToDateTime(reader("FechaFin"))

        If reader("Coste") Is DBNull.Value Then
            curso.Coste = Nothing
        Else
            curso.Coste = Convert.ToDecimal(reader("Coste"))
        End If

        If reader("Aula") Is DBNull.Value Then
            curso.Aula = Nothing
        Else
            curso.Aula = CStr(reader("Aula"))
        End If

        If reader("AulaNombre") Is DBNull.Value Then
            curso.AulaNombre = Nothing
        Else
            curso.AulaNombre = CStr(reader("AulaNombre"))
        End If
        If reader("Observaciones") Is DBNull.Value Then
            curso.Observaciones = Nothing
        Else
            curso.Observaciones = CStr(reader("Observaciones"))
        End If

        Return curso

    End Function

    Public Shared Function CargarUnCurso(ByVal codigo As String) As EntidadCursos
        Dim curso As EntidadCursos = Nothing

        Using conn As New SqlConnection(ConfigurationManager.ConnectionStrings("default").ToString())

            conn.Open()

            Dim cmd As New SqlCommand("PROC_CURSOS_CargarUnCurso", conn)
            cmd.CommandType = CommandType.StoredProcedure

            cmd.Parameters.AddWithValue("@codigo", codigo)

            Dim reader As SqlDataReader = cmd.ExecuteReader()
            If reader.Read() Then
                curso = New EntidadCursos
                curso.CodigoCurso = Convert.ToString(reader("CodigoCurso"))
                curso.Nombre = Convert.ToString(reader("Nombre"))
                curso.Tipo = Convert.ToString(reader("Tipo"))
                curso.TipoNombre = Convert.ToString(reader("TipoNombre"))
                curso.Duracion = Convert.ToInt32(reader("Duracion"))
                curso.FechaInicio = Convert.ToDateTime(reader("FechaInicio"))
                curso.FechaFin = Convert.ToDateTime(reader("FechaFin"))
                curso.Coste = Convert.ToDecimal(reader("Coste"))
                curso.Aula = Convert.ToString(reader("Aula"))
                curso.AulaNombre = Convert.ToString(reader("AulaNombre"))
                curso.Observaciones = Convert.ToString(reader("Observaciones"))
            End If

        End Using

        Return curso

    End Function

   

    Public Shared Function Existe(ByVal codigo As String) As Boolean
        Dim numeroderegistros As Integer = 0

        Using conn As New SqlConnection(ConfigurationManager.ConnectionStrings("default").ToString())
            conn.Open()

            Dim cmd As New SqlCommand("PROC_CURSOS_Existe", conn)
            cmd.CommandType = CommandType.StoredProcedure

            cmd.Parameters.AddWithValue("@codigo", codigo)

            numeroderegistros = Convert.ToInt32(cmd.ExecuteScalar())
        End Using

        Return numeroderegistros > 0

    End Function

    Public Shared Function Crear(ByVal curso As EntidadCursos) As EntidadCursos
        Using conn As New SqlConnection(ConfigurationManager.ConnectionStrings("default").ToString())
            conn.Open()

            Dim cmd As New SqlCommand("PROC_CURSOS_CrearCurso", conn)
            cmd.CommandType = CommandType.StoredProcedure

            cmd.Parameters.AddWithValue("@CodigoCurso", curso.CodigoCurso)
            cmd.Parameters.AddWithValue("@Nombre", curso.Nombre)

            If curso.Tipo Is Nothing Then
                cmd.Parameters.AddWithValue("@Tipo", DBNull.Value)
            Else
                cmd.Parameters.AddWithValue("@Tipo", curso.Tipo)
            End If

            cmd.Parameters.AddWithValue("@Duracion", curso.Duracion)

            cmd.Parameters.AddWithValue("@FechaInicio", curso.FechaInicio)
            cmd.Parameters.AddWithValue("@FechaFin", curso.FechaFin)

            If curso.Coste = Nothing Then
                cmd.Parameters.AddWithValue("@Coste", DBNull.Value)
            Else
                cmd.Parameters.AddWithValue("@Coste", curso.Coste)
            End If

            If curso.Aula Is Nothing Then
                cmd.Parameters.AddWithValue("@Aula", DBNull.Value)
            Else
                cmd.Parameters.AddWithValue("@Aula", curso.Aula)
            End If

            If curso.Observaciones Is Nothing Then
                cmd.Parameters.AddWithValue("@Observaciones", DBNull.Value)
            Else
                cmd.Parameters.AddWithValue("@Observaciones", curso.Observaciones)
            End If

            cmd.ExecuteNonQuery()

        End Using

        Return curso

    End Function


    Public Shared Function Actualizar(ByVal curso As EntidadCursos) As EntidadCursos
        Using conn As New SqlConnection(ConfigurationManager.ConnectionStrings("default").ToString())
            conn.Open()

            Dim cmd As New SqlCommand("PROC_CURSOS_ActualizarCurso", conn)
            cmd.CommandType = CommandType.StoredProcedure

            cmd.Parameters.AddWithValue("@CodigoCurso", curso.CodigoCurso)
            cmd.Parameters.AddWithValue("@Nombre", curso.Nombre)

            If curso.Tipo Is Nothing Then
                cmd.Parameters.AddWithValue("@Tipo", DBNull.Value)
            Else
                cmd.Parameters.AddWithValue("@Tipo", curso.Tipo)
            End If

            cmd.Parameters.AddWithValue("@Duracion", curso.Duracion)

            cmd.Parameters.AddWithValue("@FechaInicio", curso.FechaInicio)
            cmd.Parameters.AddWithValue("@FechaFin", curso.FechaFin)

            If curso.Coste = Nothing Then
                cmd.Parameters.AddWithValue("@Coste", DBNull.Value)
            Else
                cmd.Parameters.AddWithValue("@Coste", curso.Coste)
            End If

            If curso.Aula Is Nothing Then
                cmd.Parameters.AddWithValue("@Aula", DBNull.Value)
            Else
                cmd.Parameters.AddWithValue("@Aula", curso.Aula)
            End If

            If curso.Observaciones Is Nothing Then
                cmd.Parameters.AddWithValue("@Observaciones", DBNull.Value)
            Else
                cmd.Parameters.AddWithValue("@Observaciones", curso.Observaciones)
            End If

            cmd.ExecuteNonQuery()


        End Using

        Return curso

    End Function
    Public Shared Function ActualizarAula(ByVal curso As EntidadCursos) As EntidadCursos
        Using conn As New SqlConnection(ConfigurationManager.ConnectionStrings("default").ToString())
            conn.Open()

            Dim cmd As New SqlCommand("PROC_CURSOS_ActualizarAula", conn)
            cmd.CommandType = CommandType.StoredProcedure

            cmd.Parameters.AddWithValue("@CodigoCurso", curso.CodigoCurso)
            cmd.Parameters.AddWithValue("@Aula", curso.Aula)

            cmd.ExecuteNonQuery()

        End Using

        Return curso

    End Function
    Public Shared Function CargarTodosEnDataTable() As DataTable

        Dim dt As New DataTable()

        Using conn As New SqlConnection(ConfigurationManager.ConnectionStrings("default").ToString())
            conn.Open()

            Dim cmd As New SqlCommand("PROC_CURSOS_CargarTodosEnDatatable", conn)
            cmd.CommandType = CommandType.StoredProcedure

            Dim da As New SqlDataAdapter(cmd)

            da.Fill(dt)
        End Using

        Return dt

    End Function
    Public Shared Function CargarCursosSinAulaenDatatable() As DataTable

        Dim dt As New DataTable()

        Using conn As New SqlConnection(ConfigurationManager.ConnectionStrings("default").ToString())
            conn.Open()

            Dim cmd As New SqlCommand("PROC_CURSOS_CargarCursosSinAulaEnDatatable", conn)
            cmd.CommandType = CommandType.StoredProcedure

            Dim da As New SqlDataAdapter(cmd)

            da.Fill(dt)
        End Using

        Return dt

    End Function
    Public Shared Function CargarDatosUnCursoEnDataTable(ByVal CodigoCurso As String) As DataTable

        Dim dt As New DataTable()

        Using conn As New SqlConnection(ConfigurationManager.ConnectionStrings("default").ToString())
            conn.Open()


            Dim cmd As New SqlCommand("PROC_CURSOS_InformeDatosUnCurso", conn)
            cmd.CommandType = CommandType.StoredProcedure

            cmd.Parameters.AddWithValue("@CodigoCurso", CodigoCurso)

            Dim da As New SqlDataAdapter(cmd)

            da.Fill(dt)

        End Using

        Return dt
    End Function


    Public Shared Function ComprobarDependencias(ByVal codigo As String) As Boolean

        Using conn As New SqlConnection(ConfigurationManager.ConnectionStrings("default").ToString())
            conn.Open()

            Dim cmd As New SqlCommand("PROC_CURSOS_ComprobarDependencias", conn)
            cmd.CommandType = CommandType.StoredProcedure

            Dim paramIndicador As New SqlParameter("indicador", SqlDbType.Int)
            paramIndicador.Direction = ParameterDirection.Output
            cmd.Parameters.Add(paramIndicador)

            cmd.Parameters.AddWithValue("@CodigoCurso", codigo)
            Dim rowsAffected As Integer = cmd.ExecuteNonQuery()

            If (Convert.ToInt32(cmd.Parameters("Indicador").Value)) > 0 Then
                'Si indicador esta a 1 entonces hay dependencias
                Return True
            Else
                Return False
            End If

            Return rowsAffected > 0

        End Using



    End Function
    Public Shared Function Borrar(ByVal codigo As String) As Integer
        Dim numeroderegistros As Integer = 0

        Using conn As New SqlConnection(ConfigurationManager.ConnectionStrings("default").ToString())
            conn.Open()

            Dim cmd As New SqlCommand("PROC_CURSOS_BorrarCurso", conn)
            cmd.CommandType = CommandType.StoredProcedure

            cmd.Parameters.AddWithValue("@codigo", codigo)

            numeroderegistros = Convert.ToInt32(cmd.ExecuteScalar())
        End Using

        Return numeroderegistros
    End Function
    Public Shared Function ConsultarDatosCursos(ByVal curso As EntidadCursos) As DataTable

        Dim dt As New DataTable()

        Using conn As New SqlConnection(ConfigurationManager.ConnectionStrings("default").ToString())
            conn.Open()

            Dim cmd As New SqlCommand("PROC_CURSOS_ConsultarDatosCursos", conn)
            cmd.CommandType = CommandType.StoredProcedure

            If curso.CodigoCurso <> String.Empty Then
                cmd.Parameters.AddWithValue("@CodigoCurso", curso.CodigoCurso)
            End If

            If curso.Nombre <> String.Empty Then
                cmd.Parameters.AddWithValue("@NombreCurso", curso.Nombre)
            End If

            If Not IsNothing(curso.FechaInicio) Then
                cmd.Parameters.AddWithValue("@FechaInicio", curso.FechaInicio)
            End If

            If Not IsNothing(curso.FechaFin) Then
                cmd.Parameters.AddWithValue("@FechaFin", curso.FechaFin)
            End If

            If Not IsNothing(curso.Duracion) Then
                cmd.Parameters.AddWithValue("@Duracion", curso.Duracion)
            End If

            Dim da As New SqlDataAdapter(cmd)

            da.Fill(dt)

        End Using

        Return dt

    End Function
    Public Shared Function InformeCursos() As DataTable

        Dim dt As New DataTable()

        Using conn As New SqlConnection(ConfigurationManager.ConnectionStrings("default").ToString())
            conn.Open()

            Dim cmd As New SqlCommand("PROC_CURSOS_CargarCursos", conn)
            cmd.CommandType = CommandType.StoredProcedure

            Dim da As New SqlDataAdapter(cmd)

            da.Fill(dt)
        End Using

        Return dt

    End Function
End Class
