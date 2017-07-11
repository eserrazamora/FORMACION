Imports Formacion.Entidades
Imports System.Data.SqlClient
Imports System.Configuration

Public NotInheritable Class ProfesoresCursosDAL
    Public Shared Function CargarCursosProfesor(ByVal NifProfesor As String) As DataTable
        'Esta funcion busca todos los cursos impartidos por un profesor
        Dim dt As New DataTable()

        Using conn As New SqlConnection(ConfigurationManager.ConnectionStrings("default").ToString())
            conn.Open()


            Dim cmd As New SqlCommand("PROC_PROFESORESCURSOS_CargarCursosProfesor", conn)
            cmd.CommandType = CommandType.StoredProcedure

            cmd.Parameters.AddWithValue("@NifProfesor", NifProfesor)

            Dim da As New SqlDataAdapter(cmd)

            da.Fill(dt)

        End Using

        Return dt
    End Function
    Public Shared Function CargarProfesoresNoEstenEnCurso(ByVal codigocurso As String) As DataTable
        'Esta funcion busca todos los cursos impartidos por un profesor
        Dim dt As New DataTable()

        Using conn As New SqlConnection(ConfigurationManager.ConnectionStrings("default").ToString())
            conn.Open()


            Dim cmd As New SqlCommand("PROC_PROFESORESCURSOS_CargarTodosLosProfesoresNoEstenEnCurso", conn)
            cmd.CommandType = CommandType.StoredProcedure

            cmd.Parameters.AddWithValue("@CodigoCurso", codigocurso)

            Dim da As New SqlDataAdapter(cmd)

            da.Fill(dt)

        End Using

        Return dt
    End Function
    Public Shared Function Crear(ByVal profesorcurso As EntidadProfesorCurso) As EntidadProfesorCurso

        Using conn As New SqlConnection(ConfigurationManager.ConnectionStrings("default").ToString())

            conn.Open()

            Dim cmd As New SqlCommand("PROC_PROFESORESCURSOS_CrearProfesorCurso", conn)
            cmd.CommandType = CommandType.StoredProcedure

            cmd.Parameters.AddWithValue("@NifProfesor", profesorcurso.NifProfesor)
            cmd.Parameters.AddWithValue("@CodigoCurso", profesorcurso.CodigoCurso)

            cmd.ExecuteNonQuery()

        End Using

        Return profesorcurso

    End Function


End Class
