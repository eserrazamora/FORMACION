
Imports Formacion.Entidades
Imports System.Data.SqlClient
Imports System.Configuration

Public Class CalificacionesDAL
    Public Shared Function CargarTodos(ByVal CodigoCurso As String) As List(Of EntidadCalificacion)
        Dim list As New List(Of EntidadCalificacion)()

        Using conn As New SqlConnection(ConfigurationManager.ConnectionStrings("default").ToString())
            conn.Open()

            Dim cmd As New SqlCommand("PROC_CALIFICACIONES_CargarAlumnosCurso", conn)
            cmd.CommandType = CommandType.StoredProcedure

            cmd.Parameters.AddWithValue("@CodigoCurso", CodigoCurso)

            Dim reader As SqlDataReader = cmd.ExecuteReader()

            While reader.Read()
                list.Add(CargarCalificacion(reader))
            End While
        End Using

        Return list
    End Function

    Private Shared Function CargarCalificacion(ByVal reader As IDataReader) As EntidadCalificacion
        Dim calificacion As New EntidadCalificacion()

        calificacion.CodigoMatricula = CStr(reader("CodigoMatricula"))
        If reader("Calificacion") Is DBNull.Value Then
            calificacion.Calificacion = Nothing
        Else
            calificacion.Calificacion = CDec(reader("Calificacion"))
        End If

        calificacion.Observaciones = CStr(reader("Observaciones"))

        Return calificacion

    End Function

    Public Shared Function CargarTodosEnDataTable(ByVal CodigoCurso As String) As DataTable
        Dim dt As New DataTable

        Using conn As New SqlConnection(ConfigurationManager.ConnectionStrings("default").ToString())
            conn.Open()

            Dim cmd As New SqlCommand("PROC_CALIFICACIONES_CargarAlumnosCurso", conn)
            cmd.CommandType = CommandType.StoredProcedure

            cmd.Parameters.AddWithValue("@CodigoCurso", CodigoCurso)

            Dim da As New SqlDataAdapter(cmd)

            da.Fill(dt)

        End Using

        Return dt

    End Function
    

    Public Shared Function CrearCalificacion(ByVal calificacion As EntidadCalificacion) As EntidadCalificacion
        Using conn As New SqlConnection(ConfigurationManager.ConnectionStrings("default").ToString())
            conn.Open()

            Dim cmd As New SqlCommand("PROC_CALIFICACIONES_CrearCalificacion", conn)
            cmd.CommandType = CommandType.StoredProcedure

            cmd.Parameters.AddWithValue("@CodigoMatricula", calificacion.CodigoMatricula)

            If IsNothing(calificacion.Calificacion) Then
                cmd.Parameters.AddWithValue("@Calificacion ", DBNull.Value)
            Else
                cmd.Parameters.AddWithValue("@Calificacion ", calificacion.Calificacion)
            End If

            If IsNothing(calificacion.Observaciones) Then
                cmd.Parameters.AddWithValue("@Observaciones ", DBNull.Value)
            Else
                cmd.Parameters.AddWithValue("@Observaciones ", calificacion.Observaciones)
            End If

            cmd.ExecuteNonQuery()

            Return calificacion

        End Using
    End Function
    Public Shared Function ActualizarCalificacion(ByVal calificacion As EntidadCalificacion) As EntidadCalificacion
        Using conn As New SqlConnection(ConfigurationManager.ConnectionStrings("default").ToString())
            conn.Open()

            Dim cmd As New SqlCommand("PROC_CALIFICACIONES_ActualizarCalificacion", conn)
            cmd.CommandType = CommandType.StoredProcedure

            cmd.Parameters.AddWithValue("@CodigoMatricula", calificacion.CodigoMatricula)

            If IsNothing(calificacion.Calificacion) Then
                cmd.Parameters.AddWithValue("@Calificacion ", DBNull.Value)
            Else
                cmd.Parameters.AddWithValue("@Calificacion ", calificacion.Calificacion)
            End If

            If IsNothing(calificacion.Observaciones) Then
                cmd.Parameters.AddWithValue("@Observaciones ", DBNull.Value)
            Else
                cmd.Parameters.AddWithValue("@Observaciones ", calificacion.Observaciones)
            End If


            cmd.ExecuteNonQuery()

            Return calificacion

        End Using



    End Function


    Public Shared Function Existe(ByVal codigomatricula As String) As Boolean
        Dim numeroderegistros As Integer = 0

        Using conn As New SqlConnection(ConfigurationManager.ConnectionStrings("default").ToString())
            conn.Open()

            Dim cmd As New SqlCommand("PROC_CALIFICACIONES_Existe", conn)
            cmd.CommandType = CommandType.StoredProcedure

            cmd.Parameters.AddWithValue("@CodigoMatricula", codigomatricula)

            numeroderegistros = CInt(cmd.ExecuteScalar())

        End Using

        Return numeroderegistros > 0

    End Function

End Class
