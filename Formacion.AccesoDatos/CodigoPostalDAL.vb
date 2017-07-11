Imports Formacion.Entidades
Imports System.Data.SqlClient
Imports System.Configuration

Public NotInheritable Class CodigoPostalDAL

    Public Shared Function CargarTodos() As List(Of EntidadCodigoPostal)
        Dim list As New List(Of EntidadCodigoPostal)()

        Using conn As New SqlConnection(ConfigurationManager.ConnectionStrings("default").ToString())
            conn.Open()

            Dim cmd As New SqlCommand("PROC_CODIGOSPOSTALES_CargarCodigosPostales", conn)
            cmd.CommandType = CommandType.StoredProcedure

            Dim reader As SqlDataReader = cmd.ExecuteReader()

            While reader.Read()
                list.Add(CargarCodigoPostal(reader))
            End While
        End Using

        Return list
    End Function

    Private Shared Function CargarCodigoPostal(ByVal reader As IDataReader) As EntidadCodigoPostal
        Dim cp As New EntidadCodigoPostal()

        cp.CodigoPostal = Convert.ToString(reader("CodigoPostal"))
        cp.Localidad = Convert.ToString(reader("Localidad"))
        cp.Provincia = Convert.ToString(reader("Provincia"))
        
        Return cp

    End Function


    Public Shared Function CargarUnCodigoPostal(ByVal codigo As String) As EntidadCodigoPostal
        Dim cp As EntidadCodigoPostal = Nothing

        Using conn As New SqlConnection(ConfigurationManager.ConnectionStrings("default").ToString())

            conn.Open()

            Dim cmd As New SqlCommand("PROC_CODIGOSPOSTALES_CargarUnCodigoPostal", conn)
            cmd.CommandType = CommandType.StoredProcedure

            cmd.Parameters.AddWithValue("@CodigoPostal", codigo)

            Dim reader As SqlDataReader = cmd.ExecuteReader()
            If reader.Read() Then

                cp = New EntidadCodigoPostal
                cp.CodigoPostal = Convert.ToString(reader("CodigoPostal"))
                cp.Localidad = Convert.ToString(reader("Localidad"))
                cp.Provincia = Convert.ToString(reader("Provincia"))
            End If


        End Using

        Return cp

    End Function

    Public Shared Function Existe(ByVal codigo As String) As Boolean
        Dim numeroderegistros As Integer = 0

        Using conn As New SqlConnection(ConfigurationManager.ConnectionStrings("default").ToString())
            conn.Open()

            Dim cmd As New SqlCommand("PROC_CODIGOSPOSTALES_Existe", conn)
            cmd.CommandType = CommandType.StoredProcedure

            cmd.Parameters.AddWithValue("@codigopostal", codigo)

            numeroderegistros = Convert.ToInt32(cmd.ExecuteScalar())
        End Using

        Return numeroderegistros > 0

    End Function
    Public Shared Function Crear(ByVal cp As EntidadCodigoPostal) As EntidadCodigoPostal
        Using conn As New SqlConnection(ConfigurationManager.ConnectionStrings("default").ToString())
            conn.Open()

            Dim cmd As New SqlCommand("PROC_CODIGOSPOSTALES_CrearCodigoPostal", conn)
            cmd.CommandType = CommandType.StoredProcedure

            cmd.Parameters.AddWithValue("@CodigoPostal", cp.CodigoPostal)
            cmd.Parameters.AddWithValue("@Provincia", cp.Provincia)
            If cp.Localidad = Nothing Then
                cmd.Parameters.AddWithValue("@Localidad", DBNull.Value)
            Else
                cmd.Parameters.AddWithValue("@Localidad", cp.Localidad)
            End If

            cmd.ExecuteNonQuery()
        End Using

        Return cp

    End Function

    Public Shared Function Actualizar(ByVal cp As EntidadCodigoPostal) As EntidadCodigoPostal
        Using conn As New SqlConnection(ConfigurationManager.ConnectionStrings("default").ToString())
            conn.Open()

            Dim cmd As New SqlCommand("PROC_CODIGOSPOSTALES_ActualizarCodigoPostal", conn)
            cmd.CommandType = CommandType.StoredProcedure

            cmd.Parameters.AddWithValue("@CodigoPostal", cp.CodigoPostal)
            cmd.Parameters.AddWithValue("@Provincia", cp.Provincia)
            If cp.Localidad = Nothing Then
                cmd.Parameters.AddWithValue("@Localidad", DBNull.Value)
            Else
                cmd.Parameters.AddWithValue("@Localidad", cp.Localidad)
            End If


            cmd.ExecuteNonQuery()

        End Using

        Return cp
    End Function
    Public Shared Function CargarTodosEnDatatable() As DataTable
        Dim dt As New DataTable()

        Using conn As New SqlConnection(ConfigurationManager.ConnectionStrings("default").ToString())
            conn.Open()

            Dim cmd As New SqlCommand("PROC_CODIGOSPOSTALES_CargarTodosEnDatatable", conn)
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

            Dim cmd As New SqlCommand("PROC_CODIGOSPOSTALES_ComprobarDependencias", conn)
            cmd.CommandType = CommandType.StoredProcedure

            Dim paramIndicador As New SqlParameter("indicador", SqlDbType.Int)
            paramIndicador.Direction = ParameterDirection.Output
            cmd.Parameters.Add(paramIndicador)

            cmd.Parameters.AddWithValue("@codigopostal", codigo)
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

            Dim cmd As New SqlCommand("PROC_CODIGOSPOSTALES_BorrarCodigoPostal", conn)
            cmd.CommandType = CommandType.StoredProcedure

            cmd.Parameters.AddWithValue("@codigopostal", codigo)

            numeroderegistros = Convert.ToInt32(cmd.ExecuteScalar())
        End Using

        Return numeroderegistros
    End Function

    Protected Overrides Sub Finalize()
        MyBase.Finalize()
    End Sub
End Class

