Imports Formacion.Entidades
Imports System.Data.SqlClient
Imports System.Configuration


Public NotInheritable Class AsistenciasDAL
    Public Shared Function CargarAsistenciasAlumnos(ByVal codigocurso As String, ByVal Fecha As Date) As DataTable
        Dim dt As New DataTable()

        Using conn As New SqlConnection(ConfigurationManager.ConnectionStrings("default").ToString())
            conn.Open()


            Dim cmd As New SqlCommand("PROC_ASISTENCIAS_CargarAsistenciasAlumnos", conn)
            cmd.CommandType = CommandType.StoredProcedure

            cmd.Parameters.AddWithValue("@CodigoCurso", codigocurso)
            cmd.Parameters.AddWithValue("@Fecha", Fecha)

            Dim da As New SqlDataAdapter(cmd)

            da.Fill(dt)


            Return dt

        End Using

    End Function

    Public Shared Function Existe(ByVal codigomatricula As String, ByVal fecha As Date) As Boolean
        Dim numeroderegistros As Integer = 0

        Using conn As New SqlConnection(ConfigurationManager.ConnectionStrings("default").ToString())
            conn.Open()

            Dim cmd As New SqlCommand("PROC_ASISTENCIAS_Existe", conn)
            cmd.CommandType = CommandType.StoredProcedure

            cmd.Parameters.AddWithValue("@CodigoMatricula", codigomatricula)
            cmd.Parameters.AddWithValue("@Fecha", fecha)

            numeroderegistros = CInt(cmd.ExecuteScalar())

        End Using

        Return numeroderegistros > 0

    End Function

    Public Shared Function Crear(ByVal asistencia As EntidadAsistencia) As EntidadAsistencia

        Using conn As New SqlConnection(ConfigurationManager.ConnectionStrings("default").ToString())

            conn.Open()

            Dim cmd As New SqlCommand("PROC_ASISTENCIAS_CrearAsistencia", conn)
            cmd.CommandType = CommandType.StoredProcedure

            cmd.Parameters.AddWithValue("@CodigoMatricula", asistencia.CodigoMatricula)
            cmd.Parameters.AddWithValue("@Fecha", asistencia.Fecha)
            cmd.Parameters.AddWithValue("@Asistio", asistencia.Asistio)

            cmd.ExecuteNonQuery()
           
        End Using

        Return asistencia

    End Function

    Public Shared Function Actualizar(ByVal asistencia As EntidadAsistencia) As EntidadAsistencia
        Dim numregistros As Integer
        Using conn As New SqlConnection(ConfigurationManager.ConnectionStrings("default").ToString())
            conn.Open()

            Dim cmd As New SqlCommand("PROC_ASISTENCIAS_ActualizarAsistencia", conn)
            cmd.CommandType = CommandType.StoredProcedure

            cmd.Parameters.AddWithValue("@CodigoMatricula", asistencia.CodigoMatricula)
            cmd.Parameters.AddWithValue("@Fecha", asistencia.Fecha)
            cmd.Parameters.AddWithValue("@Asistio", asistencia.Asistio)

            numregistros = cmd.ExecuteNonQuery()


        End Using

        Return asistencia
    End Function

End Class
