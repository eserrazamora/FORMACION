Imports Formacion.Entidades
Imports System.Data.SqlClient
Imports System.Configuration
Public NotInheritable Class TiposAulasDAL
    Public Shared Function CargarTodos() As List(Of EntidadTiposAulas)
        Dim list As New List(Of EntidadTiposAulas)()

        Using conn As New SqlConnection(ConfigurationManager.ConnectionStrings("default").ToString())
            conn.Open()

            Dim cmd As New SqlCommand("PROC_TIPOSAULAS_CargarTodos", conn)
            cmd.CommandType = CommandType.StoredProcedure

            Dim reader As SqlDataReader = cmd.ExecuteReader()

            While reader.Read()
                list.Add(CargarTipoAula(reader))

            End While
        End Using

        Return list
    End Function

    Private Shared Function CargarTipoAula(ByVal reader As IDataReader) As EntidadTiposAulas
        Dim tipoaula As New EntidadTiposAulas()

        tipoaula.Codigo = Convert.ToString(reader("Codigo"))
        tipoaula.Tipo = Convert.ToString(reader("Tipo"))

        Return tipoaula

    End Function


    Public Shared Function CargarUnTipoAula(ByVal codigo As String) As EntidadTiposAulas
        Dim tipoaula As EntidadTiposAulas = Nothing

        Using conn As New SqlConnection(ConfigurationManager.ConnectionStrings("default").ToString())

            conn.Open()

            Dim cmd As New SqlCommand("PROC_TIPOSAULAS_CargarUnTipoAula", conn)
            cmd.CommandType = CommandType.StoredProcedure

            cmd.Parameters.AddWithValue("@codigo", codigo)

            Dim reader As SqlDataReader = cmd.ExecuteReader()
            If reader.Read() Then

                tipoaula = New EntidadTiposAulas
                tipoaula.Codigo = Convert.ToString(reader("Codigo"))
                tipoaula.Tipo = Convert.ToString(reader("Tipo"))
            End If

        End Using

        Return tipoaula

    End Function

    Public Shared Function Existe(ByVal codigo As String) As Boolean
        Dim numeroderegistros As Integer = 0

        Using conn As New SqlConnection(ConfigurationManager.ConnectionStrings("default").ToString())
            conn.Open()


            Dim cmd As New SqlCommand("PROC_TIPOSAULAS_Existe", conn)
            cmd.CommandType = CommandType.StoredProcedure

            cmd.Parameters.AddWithValue("@codigo", codigo)

            numeroderegistros = Convert.ToInt32(cmd.ExecuteScalar())
        End Using

        Return numeroderegistros > 0

    End Function

    Public Shared Function Crear(ByVal tipoaula As EntidadTiposAulas) As EntidadTiposAulas
        Using conn As New SqlConnection(ConfigurationManager.ConnectionStrings("default").ToString())
            conn.Open()

            Dim cmd As New SqlCommand("PROC_TIPOSAULAS_CrearTipoAula", conn)
            cmd.CommandType = CommandType.StoredProcedure


            cmd.Parameters.AddWithValue("@Codigo", tipoaula.Codigo)
            cmd.Parameters.AddWithValue("@Tipo", tipoaula.Tipo)

            cmd.ExecuteNonQuery()
        End Using

        Return tipoaula

    End Function

    Public Shared Function Actualizar(ByVal tipoaula As EntidadTiposAulas) As EntidadTiposAulas
        Using conn As New SqlConnection(ConfigurationManager.ConnectionStrings("default").ToString())
            conn.Open()

            Dim cmd As New SqlCommand("PROC_TIPOSAULAS_ActualizarTipoAula", conn)
            cmd.CommandType = CommandType.StoredProcedure

            cmd.Parameters.AddWithValue("@Codigo", tipoaula.Codigo)
            cmd.Parameters.AddWithValue("@Tipo", tipoaula.Tipo)

            cmd.ExecuteNonQuery()

        End Using

        Return tipoaula

    End Function

    Public Shared Function CargarTodosEnDataTable() As DataTable

        Dim dt As New DataTable()

        Using conn As New SqlConnection(ConfigurationManager.ConnectionStrings("default").ToString())
            conn.Open()

            Dim cmd As New SqlCommand("PROC_TIPOSAULAS_CargarTodosEnDataTable", conn)
            cmd.CommandType = CommandType.StoredProcedure

            Dim da As New SqlDataAdapter(cmd)

            da.Fill(dt)
        End Using

        Return dt

    End Function
    Public Shared Function ComprobarDependencias(ByVal codigo As String) As Boolean

        Using conn As New SqlConnection(ConfigurationManager.ConnectionStrings("default").ToString())
            conn.Open()

            Dim cmd As New SqlCommand("PROC_TIPOSAULAS_ComprobarDependencias", conn)
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

            Dim cmd As New SqlCommand("PROC_TIPOSAULAS_BorrarTipoAula", conn)
            cmd.CommandType = CommandType.StoredProcedure

            cmd.Parameters.AddWithValue("@codigo", codigo)

            numeroderegistros = Convert.ToInt32(cmd.ExecuteScalar())
        End Using

        Return numeroderegistros
    End Function
End Class
