Imports Formacion.Entidades
Imports System.Data.SqlClient
Imports System.Configuration
Public NotInheritable Class TiposCursosDAL
    Public Shared Function CargarTodos() As List(Of EntidadTiposCursos)
        Dim list As New List(Of EntidadTiposCursos)()

        Using conn As New SqlConnection(ConfigurationManager.ConnectionStrings("default").ToString())
            conn.Open()

            Dim cmd As New SqlCommand("PROC_TIPOSCURSOS_CargarTodos", conn)
            cmd.CommandType = CommandType.StoredProcedure


            Dim reader As SqlDataReader = cmd.ExecuteReader()

            While reader.Read()
                list.Add(CargarTipoCurso(reader))

            End While
        End Using

        Return list
    End Function

    Private Shared Function CargarTipoCurso(ByVal reader As IDataReader) As EntidadTiposCursos
        Dim tipocurso As New EntidadTiposCursos()


        tipocurso.Codigo = CStr(reader("Codigo"))
        tipocurso.Tipo = CStr(reader("Tipo"))

        Return tipocurso

    End Function

    Public Shared Function CargarUnTipoCurso(ByVal codigo As String) As EntidadTiposCursos
        Dim tipocurso As EntidadTiposCursos = Nothing

        Using conn As New SqlConnection(ConfigurationManager.ConnectionStrings("default").ToString())

            conn.Open()

            Dim cmd As New SqlCommand("PROC_TIPOSCURSOS_CargarUnTipoCurso", conn)
            cmd.CommandType = CommandType.StoredProcedure

            cmd.Parameters.AddWithValue("@codigo", codigo)

            Dim reader As SqlDataReader = cmd.ExecuteReader()
            If reader.Read() Then

                tipocurso = New EntidadTiposCursos
                tipocurso.Codigo = CStr(reader("Codigo"))
                tipocurso.Tipo = CStr(reader("Tipo"))
            End If

        End Using

        Return tipocurso

    End Function

    Public Shared Function Existe(ByVal codigo As String) As Boolean
        Dim numeroderegistros As Integer = 0

        Using conn As New SqlConnection(ConfigurationManager.ConnectionStrings("default").ToString())
            conn.Open()

            Dim cmd As New SqlCommand("PROC_TIPOSCURSOS_Existe", conn)
            cmd.CommandType = CommandType.StoredProcedure

            cmd.Parameters.AddWithValue("@codigo", codigo)

            numeroderegistros = Convert.ToInt32(cmd.ExecuteScalar())
        End Using

        Return numeroderegistros > 0

    End Function

    Public Shared Function Crear(ByVal tipocurso As EntidadTiposCursos) As EntidadTiposCursos
        Using conn As New SqlConnection(ConfigurationManager.ConnectionStrings("default").ToString())
            conn.Open()

            Dim cmd As New SqlCommand("PROC_TIPOSCURSOS_CrearTipoCurso", conn)
            cmd.CommandType = CommandType.StoredProcedure

            cmd.Parameters.AddWithValue("@Codigo", tipocurso.Codigo)
            cmd.Parameters.AddWithValue("@Tipo", tipocurso.Tipo)

            cmd.ExecuteNonQuery()
        End Using

        Return tipocurso

    End Function
    Public Shared Function Actualizar(ByVal tipocurso As EntidadTiposCursos) As EntidadTiposCursos
        Using conn As New SqlConnection(ConfigurationManager.ConnectionStrings("default").ToString())
            conn.Open()

            Dim cmd As New SqlCommand("PROC_TIPOSCURSOS_ActualizarTipoCurso", conn)
            cmd.CommandType = CommandType.StoredProcedure

            cmd.Parameters.AddWithValue("@Codigo", tipocurso.Codigo)
            cmd.Parameters.AddWithValue("@Tipo", tipocurso.Tipo)

            cmd.ExecuteNonQuery()

        End Using

        Return tipocurso
    End Function

    Public Shared Function CargarCodigoTipoDatatable() As DataTable
        ' Obtengo la lista de Tipos
        '
        Dim dt As New DataTable()

        Using conn As New SqlConnection(ConfigurationManager.ConnectionStrings("default").ToString())
            conn.Open()

            Dim cmd As New SqlCommand("PROC_TIPOSCURSOS_CargarTodosEnDataTable", conn)
            cmd.CommandType = CommandType.StoredProcedure

            Dim da As New SqlDataAdapter(cmd)

            da.Fill(dt)
        End Using

        Return dt

    End Function
    Public Shared Function ComprobarDependencias(ByVal codigo As String) As Boolean

        Using conn As New SqlConnection(ConfigurationManager.ConnectionStrings("default").ToString())
            conn.Open()

            Dim cmd As New SqlCommand("PROC_TIPOSCURSOS_ComprobarDependencias", conn)
            cmd.CommandType = CommandType.StoredProcedure

            Dim paramIndicador As New SqlParameter("indicador", SqlDbType.Int)
            paramIndicador.Direction = ParameterDirection.Output
            cmd.Parameters.Add(paramIndicador)

            cmd.Parameters.AddWithValue("@codigo", codigo)
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

            Dim cmd As New SqlCommand("PROC_TIPOSCURSOS_BorrarTipoCurso", conn)
            cmd.CommandType = CommandType.StoredProcedure

            cmd.Parameters.AddWithValue("@codigo", codigo)

            numeroderegistros = Convert.ToInt32(cmd.ExecuteScalar())
        End Using

        Return numeroderegistros
    End Function
End Class
