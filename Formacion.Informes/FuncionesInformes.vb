Imports System.Data.SqlClient
Imports System.Configuration
Imports System.IO
Imports System.Windows.Forms
Public Module FuncionesInformes
    Public Function CargarDatasets(ByVal CodigoCurso As String) As CrystalDecisions.CrystalReports.Engine.ReportDocument
        Dim crInformeUnCurso As New CrystalDecisions.CrystalReports.Engine.ReportDocument
        Dim rutaInformeCursos As String
        Dim ds As New DataSetInformeUnCurso
        Using conn As New SqlConnection(ConfigurationManager.ConnectionStrings("default").ToString())
            conn.Open()

            Dim cmd As New SqlCommand("PROC_CURSOS_InformeDatosUnCurso", conn)
            cmd.CommandType = CommandType.StoredProcedure

            cmd.Parameters.AddWithValue("@CodigoCurso", CodigoCurso)

            Dim da As New SqlDataAdapter(cmd)

            da.Fill(ds, "dtCURSOS")

        End Using

        'Esta funcion busca todos los cursos matriculados de un alumno
        Using conn As New SqlConnection(ConfigurationManager.ConnectionStrings("default").ToString())
            conn.Open()

            Dim cmd As New SqlCommand("PROC_PERSONAS_CargarTodosAlumnosCurso", conn)
            cmd.CommandType = CommandType.StoredProcedure

            cmd.Parameters.AddWithValue("@CodigoCurso", CodigoCurso)

            Dim da As New SqlDataAdapter(cmd)

            da.Fill(ds, "dtMATRICULAS")

        End Using

        Dim InformesPath As String = Path.Combine(Application.StartupPath, ConfigurationManager.AppSettings("RutaInformes").ToString())

        rutaInformeCursos = InformesPath & "\InformeDatosUnCurso.rpt"
        crInformeUnCurso.Load(rutaInformeCursos)
        crInformeUnCurso.SetDataSource(ds)

        Return crInformeUnCurso

    End Function

End Module
