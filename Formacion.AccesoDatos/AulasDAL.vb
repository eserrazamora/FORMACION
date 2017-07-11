Imports Formacion.Entidades
Imports System.Data.SqlClient
Imports System.Configuration
Public NotInheritable Class AulasDAL
    Public Shared Function CargarTodos() As List(Of EntidadAula)
        Dim list As New List(Of EntidadAula)()

        Using conn As New SqlConnection(ConfigurationManager.ConnectionStrings("default").ToString())
            conn.Open()

            Dim cmd As New SqlCommand("PROC_AULAS_CargarAulas", conn)
            cmd.CommandType = CommandType.StoredProcedure

            Dim reader As SqlDataReader = cmd.ExecuteReader()

            While reader.Read()
                list.Add(CargarAula(reader))
            End While
        End Using

        Return list
    End Function

    Private Shared Function CargarAula(ByVal reader As IDataReader) As EntidadAula
        Dim aula As New EntidadAula()


        aula.Codigo = Convert.ToString(reader("Codigo"))
        aula.Nombre = Convert.ToString(reader("Nombre"))
        aula.Tipo = Convert.ToString(reader("Tipo"))
        aula.TipoNombre = Convert.ToString(reader("TipoAula"))
        aula.Observaciones = Convert.ToString(reader("Observaciones"))


        Return aula

    End Function

    Public Shared Function CargarUnAula(ByVal codigo As String) As EntidadAula
        Dim aula As EntidadAula = Nothing

        Using conn As New SqlConnection(ConfigurationManager.ConnectionStrings("default").ToString())

            conn.Open()

            Dim cmd As New SqlCommand("PROC_AULAS_CargarUnAula", conn)
            cmd.CommandType = CommandType.StoredProcedure

            cmd.Parameters.AddWithValue("@Codigo", codigo)

            Dim reader As SqlDataReader = cmd.ExecuteReader()
            If reader.Read() Then

                aula = New EntidadAula
                aula.Codigo = Convert.ToString(reader("Codigo"))
                aula.Nombre = Convert.ToString(reader("Nombre"))
                aula.Tipo = Convert.ToString(reader("Tipo"))
                aula.Observaciones = Convert.ToString(reader("Observaciones"))
            End If
        End Using

        Return aula

    End Function

    Public Shared Function Existe(ByVal codigo As String) As Boolean
        Dim numeroderegistros As Integer = 0

        Using conn As New SqlConnection(ConfigurationManager.ConnectionStrings("default").ToString())
            conn.Open()

            Dim cmd As New SqlCommand("PROC_AULAS_Existe", conn)
            cmd.CommandType = CommandType.StoredProcedure

            cmd.Parameters.AddWithValue("@Codigo", codigo)

            numeroderegistros = Convert.ToInt32(cmd.ExecuteScalar())
        End Using

        Return numeroderegistros > 0

    End Function

    Public Shared Function Crear(ByVal aula As EntidadAula) As EntidadAula
        Using conn As New SqlConnection(ConfigurationManager.ConnectionStrings("default").ToString())
            conn.Open()

            Dim cmd As New SqlCommand("PROC_AULAS_CrearAula", conn)
            cmd.CommandType = CommandType.StoredProcedure

            cmd.Parameters.AddWithValue("@Codigo", aula.Codigo)
            cmd.Parameters.AddWithValue("@Nombre", aula.Nombre)
            If aula.Tipo Is Nothing Then
                cmd.Parameters.AddWithValue("@Tipo", DBNull.Value)
            Else
                cmd.Parameters.AddWithValue("@Tipo", aula.Tipo)
            End If

            cmd.Parameters.AddWithValue("@Observaciones", aula.Observaciones)

            cmd.ExecuteNonQuery()
        End Using

        Return aula

    End Function

    Public Shared Function Actualizar(ByVal aula As EntidadAula) As EntidadAula
        Using conn As New SqlConnection(ConfigurationManager.ConnectionStrings("default").ToString())
            conn.Open()

            Dim cmd As New SqlCommand("PROC_AULAS_ActualizarAula", conn)
            cmd.CommandType = CommandType.StoredProcedure

            cmd.Parameters.AddWithValue("@Codigo", aula.Codigo)
            cmd.Parameters.AddWithValue("@Nombre", aula.Nombre)
            cmd.Parameters.AddWithValue("@Tipo", aula.Tipo)
            cmd.Parameters.AddWithValue("@Observaciones", aula.Observaciones)

            cmd.ExecuteNonQuery()

        End Using

        Return aula
    End Function

    Public Shared Function CargarAulasDatatable() As DataTable

        Dim dt As New DataTable()

        Using conn As New SqlConnection(ConfigurationManager.ConnectionStrings("default").ToString())

            conn.Open()

            Dim cmd As New SqlCommand("PROC_AULAS_CargarTodosEnDatatable", conn)
            cmd.CommandType = CommandType.StoredProcedure

            Dim da As New SqlDataAdapter(cmd)

            da.Fill(dt)

        End Using

        Return dt

    End Function
    Public Shared Function ComprobarDependencias(ByVal codigo As String) As Boolean
        Dim numeroderegistros As Integer = 0

        Using conn As New SqlConnection(ConfigurationManager.ConnectionStrings("default").ToString())
            conn.Open()

            Dim cmd As New SqlCommand("PROC_AULAS_ComprobarDependencias", conn)
            cmd.CommandType = CommandType.StoredProcedure

            Dim paramIndicador As New SqlParameter("indicador", SqlDbType.Int)
            paramIndicador.Direction = ParameterDirection.Output
            cmd.Parameters.Add(paramIndicador)

            cmd.Parameters.AddWithValue("@codigoaula", codigo)
            Dim rowsAffected As Integer = cmd.ExecuteNonQuery()

            If (Convert.ToInt32(cmd.Parameters("Indicador").Value)) > 0 Then
                'Si indicador esta a 1 entonces hay dependencias
                Return True
            Else
                Return False
            End If

        End Using
    End Function
    Public Shared Function Borrar(ByVal codigo As String) As Integer
        Dim numeroderegistros As Integer = 0

        Using conn As New SqlConnection(ConfigurationManager.ConnectionStrings("default").ToString())
            conn.Open()

            Dim cmd As New SqlCommand("PROC_AULAS_BorrarAula", conn)
            cmd.CommandType = CommandType.StoredProcedure

            cmd.Parameters.AddWithValue("@codigo", codigo)

            numeroderegistros = Convert.ToInt32(cmd.ExecuteScalar())
        End Using

        Return numeroderegistros
    End Function
    Public Shared Function InformeAulas() As DataTable

        Dim dt As New DataTable()

        Using conn As New SqlConnection(ConfigurationManager.ConnectionStrings("default").ToString())

            conn.Open()

            Dim cmd As New SqlCommand("PROC_AULAS_CargarAulas", conn)
            cmd.CommandType = CommandType.StoredProcedure

            Dim da As New SqlDataAdapter(cmd)

            da.Fill(dt)

        End Using

        Return dt

    End Function
End Class
