Imports Formacion.Entidades
Imports System.Data.SqlClient
Imports System.Configuration
Public Class TiposUsuariosDAL
    Private tipousuario As EntidadTiposAulas
    Public Shared Function CargarTodos() As List(Of EntidadTiposUsuarios)
        Dim list As New List(Of EntidadTiposUsuarios)()

        Using conn As New SqlConnection(ConfigurationManager.ConnectionStrings("default").ToString())
            conn.Open()

            Dim cmd As New SqlCommand("PROC_TIPOSUSUARIOS_CargarTodos", conn)
            cmd.CommandType = CommandType.StoredProcedure

            Dim reader As SqlDataReader = cmd.ExecuteReader()

            While reader.Read()
                list.Add(CargarTipoUsuario(reader))

            End While
        End Using

        Return list
    End Function
    Public Shared Function CargarTodosDatatable() As DataTable
        ' Obtengo la lista de Tipos
        '
        Dim dt As New DataTable()

        Using conn As New SqlConnection(ConfigurationManager.ConnectionStrings("default").ToString())
            conn.Open()

            Dim cmd As New SqlCommand("PROC_TIPOSUSUARIOS_CargarTodos", conn)
            cmd.CommandType = CommandType.StoredProcedure

            Dim da As New SqlDataAdapter(cmd)

            da.Fill(dt)
        End Using

        Return dt

    End Function

    Private Shared Function CargarTipoUsuario(ByVal reader As IDataReader) As EntidadTiposUsuarios
        Dim tipousuario As New EntidadTiposUsuarios()


        tipousuario.Codigo = CStr(reader("Codigo"))
        tipousuario.Tipo = CStr(reader("Tipo"))


        Return tipousuario

    End Function

    Public Shared Function CargarUnTipoUsuario(ByVal codigo As String) As EntidadTiposUsuarios
        Dim tipousuario As EntidadTiposUsuarios = Nothing

        Using conn As New SqlConnection(ConfigurationManager.ConnectionStrings("default").ToString())

            conn.Open()

            Dim cmd As New SqlCommand("PROC_TIPOSUSUARIOS_CargarUnTipoUsuario", conn)
            cmd.CommandType = CommandType.StoredProcedure

            cmd.Parameters.AddWithValue("@codigo", codigo)

            Dim reader As SqlDataReader = cmd.ExecuteReader()
            If reader.Read() Then

                tipousuario = New EntidadTiposUsuarios
                tipousuario.Codigo = CStr(reader("Codigo"))
                tipousuario.Tipo = CStr(reader("Tipo"))
            End If

        End Using

        Return tipousuario

    End Function

    Public Shared Function Existe(ByVal codigo As String) As Boolean
        Dim numeroderegistros As Integer = 0

        Using conn As New SqlConnection(ConfigurationManager.ConnectionStrings("default").ToString())
            conn.Open()

            Dim cmd As New SqlCommand("PROC_TIPOSUSUARIOS_Existe", conn)
            cmd.CommandType = CommandType.StoredProcedure

            cmd.Parameters.AddWithValue("@codigo", codigo)

            numeroderegistros = CInt(cmd.ExecuteScalar())

        End Using

        Return numeroderegistros > 0

    End Function

    Public Shared Function Crear(ByVal tipousuario As EntidadTiposUsuarios) As EntidadTiposUsuarios
        Using conn As New SqlConnection(ConfigurationManager.ConnectionStrings("default").ToString())
            conn.Open()

            Dim cmd As New SqlCommand("PROC_TIPOSUSUARIOS_CrearTipoUsuario", conn)
            cmd.CommandType = CommandType.StoredProcedure

            cmd.Parameters.AddWithValue("@Codigo", tipousuario.Codigo)
            cmd.Parameters.AddWithValue("@Tipo", tipousuario.Tipo)

            cmd.ExecuteNonQuery()
        End Using

        Return tipousuario

    End Function

    Public Shared Function Actualizar(ByVal tipousuario As EntidadTiposUsuarios) As EntidadTiposUsuarios
        Using conn As New SqlConnection(ConfigurationManager.ConnectionStrings("default").ToString())
            conn.Open()

            Dim cmd As New SqlCommand("PROC_TIPOSUSUARIOS_ActualizarTipoUsuario", conn)
            cmd.CommandType = CommandType.StoredProcedure

            cmd.Parameters.AddWithValue("@Codigo", tipousuario.Codigo)
            cmd.Parameters.AddWithValue("@Tipo", tipousuario.Tipo)

            cmd.ExecuteNonQuery()

        End Using

        Return tipousuario
    End Function
    Public Shared Function ComprobarDependencias(ByVal codigo As String) As Boolean

        Using conn As New SqlConnection(ConfigurationManager.ConnectionStrings("default").ToString())
         
            conn.Open()

            Dim cmd As New SqlCommand("PROC_TIPOSUSUARIOS_ComprobarDependencias", conn)
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

            Dim cmd As New SqlCommand("PROC_TIPOSUSUARIOS_BorrarTipoUsuario", conn)
            cmd.CommandType = CommandType.StoredProcedure

            cmd.Parameters.AddWithValue("@codigo", codigo)

            numeroderegistros = Convert.ToInt32(cmd.ExecuteScalar())
        End Using

        Return numeroderegistros
    End Function


End Class
