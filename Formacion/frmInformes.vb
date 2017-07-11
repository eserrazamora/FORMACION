Imports Formacion.Entidades
Imports Formacion.CapaDeNegocio
Imports Formacion.Informes
Imports System.Configuration
Imports System.IO



Public Class frmInformes
    Dim InformesPath As String = Path.Combine(Application.StartupPath, ConfigurationManager.AppSettings("RutaInformes").ToString())

    Private Sub btnListadoAlumnos_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnListadoAlumnos.Click
        Try
            Using VarFrmPrevisualizacionInforme As New frmPrevisualizacionInforme
                Dim rutaInforme As String

                Using dt As DataTable = PersonasBO.CargarTodosEnDataTable("ALM")

                    Using CrReport As New CrystalDecisions.CrystalReports.Engine.ReportDocument

                        rutaInforme = InformesPath & "\InformeListadoAlumnos.rpt"
                        CrReport.Load(rutaInforme)
                        CrReport.SetDataSource(dt)


                        VarFrmPrevisualizacionInforme.crViewer.ReportSource = CrReport
                        VarFrmPrevisualizacionInforme.ShowDialog()
                    End Using

                End Using
            End Using
        Catch ex As Exception
            MsgBox("Se ha producido la siguiente excepción: " + vbCrLf + _
                    ex.Message, CType(MsgBoxStyle.OkOnly + MsgBoxStyle.Critical, MsgBoxStyle), "Error...")
        End Try
    End Sub

    Private Sub btnListadoProfesores_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnListadoProfesores.Click
        Try
            Dim dt As New DataTable
            Dim VarFrmPrevisualizacionInforme As New frmPrevisualizacionInforme
            Dim rutaInforme As String

            dt = PersonasBO.CargarTodosEnDataTable("PRF")

            Dim CrReport As New CrystalDecisions.CrystalReports.Engine.ReportDocument

            rutaInforme = InformesPath & "\InformeListadoProfesores.rpt"
            CrReport.Load(rutaInforme)
            CrReport.SetDataSource(dt)


            VarFrmPrevisualizacionInforme.crViewer.ReportSource = CrReport
            VarFrmPrevisualizacionInforme.ShowDialog()
        Catch ex As Exception
            MsgBox("Se ha producido la siguiente excepción: " + vbCrLf + _
                    ex.Message, CType(MsgBoxStyle.OkOnly + MsgBoxStyle.Critical, MsgBoxStyle), "Error...")
        End Try
    End Sub

    Private Sub btnInformeUnCurso_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnInformeUnCurso.Click
        Try
            Dim VarFrmSeleccionCUrso As New frmSeleccionCurso

            frmSeleccionCurso.ShowDialog()
            '    Dim VarFrmPrevisualizacionInforme As New frmPrevisualizacionInforme
            '    Dim crDatosCurso As New CrystalDecisions.CrystalReports.Engine.ReportDocument

            '    crDatosCurso = Formacion.Informes.vb.FuncionesInformes.CargarDatasets("0000000")

            '    VarFrmPrevisualizacionInforme.crViewer.ReportSource = crDatosCurso
            '    VarFrmPrevisualizacionInforme.ShowDialog()
        Catch ex As Exception
            MsgBox("Se ha producido la siguiente excepción: " + vbCrLf + _
                    ex.Message, CType(MsgBoxStyle.OkOnly + MsgBoxStyle.Critical, MsgBoxStyle), "Error...")
        End Try
    End Sub

 
    Private Sub btnListadoAulas_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnListadoAulas.Click
        Try
            Dim dt As New DataTable
            Dim VarFrmPrevisualizacionInforme As New frmPrevisualizacionInforme
            Dim rutaInforme As String

            dt = AulasBO.InformeAulas

            Dim CrReport As New CrystalDecisions.CrystalReports.Engine.ReportDocument

            rutaInforme = InformesPath & "\InformeListadoAulas.rpt"
            CrReport.Load(rutaInforme)
            CrReport.SetDataSource(dt)


            VarFrmPrevisualizacionInforme.crViewer.ReportSource = CrReport
            VarFrmPrevisualizacionInforme.ShowDialog()
        Catch ex As Exception
            MsgBox("Se ha producido la siguiente excepción: " + vbCrLf + _
                    ex.Message, CType(MsgBoxStyle.OkOnly + MsgBoxStyle.Critical, MsgBoxStyle), "Error...")
        End Try
    End Sub

    Private Sub btnListadoCursos_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnListadoCursos.Click
        Try
            Dim dt As New DataTable
            Dim VarFrmPrevisualizacionInforme As New frmPrevisualizacionInforme
            Dim rutaInforme As String

            dt = CursosBO.InformeCursos

            Dim CrReport As New CrystalDecisions.CrystalReports.Engine.ReportDocument

            rutaInforme = InformesPath & "\InformeListadoCursos.rpt"
            CrReport.Load(rutaInforme)
            CrReport.SetDataSource(dt)


            VarFrmPrevisualizacionInforme.crViewer.ReportSource = CrReport
            VarFrmPrevisualizacionInforme.ShowDialog()
        Catch ex As Exception
            MsgBox("Se ha producido la siguiente excepción: " + vbCrLf + _
                    ex.Message, CType(MsgBoxStyle.OkOnly + MsgBoxStyle.Critical, MsgBoxStyle), "Error...")
        End Try
    End Sub

    Private Sub btnListadoInformacionCurso_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnListadoInformacionCurso.Click

    End Sub

    Private Sub btnInformeAlumno_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnInformeAlumno.Click

    End Sub
End Class