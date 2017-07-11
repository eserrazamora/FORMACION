Imports Formacion.Entidades
Imports System.Data.SqlClient
Imports System.Configuration
Public NotInheritable Class MatriculasDAL
    Public Shared Function CargarCursosNIFenDataTable(ByVal NIF As String) As DataTable
        'Esta funcion busca todos los cursos matriculados de un alumno

        Dim dt As New DataTable()

        Using conn As New SqlConnection(ConfigurationManager.ConnectionStrings("default").ToString())
            conn.Open()


            Dim cmd As New SqlCommand("PROC_MATRICULAS_CargarCursosNif", conn)
            cmd.CommandType = CommandType.StoredProcedure

            'Si nif=Todos entonces no se pone ningun parametro
            If NIF <> "TODOS" Then
                cmd.Parameters.AddWithValue("@NIF", NIF)
            End If

            Dim da As New SqlDataAdapter(cmd)

            da.Fill(dt)

        End Using

        Return dt
    End Function
    Public Shared Function CargarCursosNifNoMatriculadosEnDatatable(ByVal NIF As String) As DataTable
        'Esta funcion busca todos los cursos matriculados de un alumno

        Dim dt As New DataTable()

        Using conn As New SqlConnection(ConfigurationManager.ConnectionStrings("default").ToString())
            conn.Open()


            Dim cmd As New SqlCommand("PROC_MATRICULAS_CargarCursosNifNoMatriculados", conn)
            cmd.CommandType = CommandType.StoredProcedure

            cmd.Parameters.AddWithValue("@NIF", NIF)
            Dim da As New SqlDataAdapter(cmd)

            da.Fill(dt)

        End Using

        Return dt
    End Function

    Public Shared Function CargarCursosEnDatatable() As DataTable
        'Esta funcion busca todos los cursos matriculados de un alumno

        Dim dt As New DataTable()

        Using conn As New SqlConnection(ConfigurationManager.ConnectionStrings("default").ToString())
            conn.Open()


            Dim cmd As New SqlCommand("PROC_MATRICULAS_CargarCursos", conn)
            cmd.CommandType = CommandType.StoredProcedure

            Dim da As New SqlDataAdapter(cmd)

            da.Fill(dt)

        End Using

        Return dt
    End Function
    Public Shared Function Existe(ByVal codigomatricula As String) As Boolean
        Dim numeroderegistros As Integer = 0

        Using conn As New SqlConnection(ConfigurationManager.ConnectionStrings("default").ToString())
            conn.Open()

            Dim cmd As New SqlCommand("PROC_MATRICULAS_Existe", conn)
            cmd.CommandType = CommandType.StoredProcedure

            cmd.Parameters.AddWithValue("@CodigoMatricula", codigomatricula)

            numeroderegistros = CInt(cmd.ExecuteScalar())

        End Using

        Return numeroderegistros > 0

    End Function

    Public Shared Function Crear(ByVal matricula As EntidadMatricula) As EntidadMatricula

        Using conn As New SqlConnection(ConfigurationManager.ConnectionStrings("default").ToString())

            conn.Open()

            Dim cmd As New SqlCommand("PROC_MATRICULAS_CrearMatricula", conn)
            cmd.CommandType = CommandType.StoredProcedure

            cmd.Parameters.AddWithValue("@CodigoMatricula", matricula.CodigoMatricula)
            cmd.Parameters.AddWithValue("@NifAlumno", matricula.NifAlumno)
            cmd.Parameters.AddWithValue("@CodigoCurso", matricula.CodigoCurso)
            cmd.Parameters.AddWithValue("@Pagado", matricula.Pagado)


            cmd.ExecuteNonQuery()

        End Using

        Return matricula

    End Function

    Public Shared Function Actualizar(ByVal matricula As EntidadMatricula) As EntidadMatricula
        Using conn As New SqlConnection(ConfigurationManager.ConnectionStrings("default").ToString())
            conn.Open()

            Dim cmd As New SqlCommand("PROC_MATRICULAS_ActualizarMatricula", conn)
            cmd.CommandType = CommandType.StoredProcedure

            cmd.Parameters.AddWithValue("@CodigoMatricula", matricula.CodigoMatricula)
            cmd.Parameters.AddWithValue("@NifAlumno", matricula.NifAlumno)
            cmd.Parameters.AddWithValue("@CodigoCurso", matricula.CodigoCurso)
            cmd.Parameters.AddWithValue("@Pagado", matricula.Pagado)

            cmd.ExecuteNonQuery()

        End Using

        Return matricula
    End Function
    Public Shared Function Borrar(ByVal codigo As String) As Integer
        Dim numeroderegistros As Integer = 0

        Using conn As New SqlConnection(ConfigurationManager.ConnectionStrings("default").ToString())
            conn.Open()

            Dim cmd As New SqlCommand("PROC_MATRICULAS_BorrarMatricula", conn)
            cmd.CommandType = CommandType.StoredProcedure

            cmd.Parameters.AddWithValue("@codigo", codigo)

            numeroderegistros = Convert.ToInt32(cmd.ExecuteScalar())
        End Using

        Return numeroderegistros
    End Function


    Public Shared Function CargarAlumnosNoMatriculados(ByVal codigocurso As String) As DataTable
        'Esta funcion busca todos los cursos matriculados de un alumno

        Dim dt As New DataTable()

        Using conn As New SqlConnection(ConfigurationManager.ConnectionStrings("default").ToString())
            conn.Open()


            Dim cmd As New SqlCommand("PROC_MATRICULAS_CargarTodosAlumnosNoMatriculadosEnCurso", conn)
            cmd.CommandType = CommandType.StoredProcedure

            cmd.Parameters.AddWithValue("@CodigoCurso", codigocurso)

            Dim da As New SqlDataAdapter(cmd)

            da.Fill(dt)

        End Using

        Return dt
    End Function
    Public Shared Function ObtenerNumeroCursosMatriculados(ByVal nif As String) As Integer
        Dim numeroderegistros As Integer = 0

        Using conn As New SqlConnection(ConfigurationManager.ConnectionStrings("default").ToString())
            conn.Open()

            Dim cmd As New SqlCommand("PROC_MATRICULAS_ObtenerNumeroCursosMatriculadosNIF", conn)
            cmd.CommandType = CommandType.StoredProcedure

            cmd.Parameters.AddWithValue("@Nif", nif)

            numeroderegistros = CInt(cmd.ExecuteScalar())

        End Using

        Return numeroderegistros
    End Function
    Public Shared Function ComprobarDependencias(ByVal codigo As String) As Boolean
        Dim numeroderegistros As Integer = 0

        Using conn As New SqlConnection(ConfigurationManager.ConnectionStrings("default").ToString())
            conn.Open()

            Dim cmd As New SqlCommand("PROC_MATRICULAS_ComprobarDependencias", conn)
            cmd.CommandType = CommandType.StoredProcedure

            Dim paramIndicador As New SqlParameter("indicador", SqlDbType.Int)
            paramIndicador.Direction = ParameterDirection.Output
            cmd.Parameters.Add(paramIndicador)

            cmd.Parameters.AddWithValue("@CodigoMatricula", codigo)
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
   
End Class
