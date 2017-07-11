Imports System.IO
Imports System.Configuration
Imports Formacion.CapaDeNegocio
Public Class frmMenuPrincipal
    Private modo As String = String.Empty
    Dim InformesPath As String = Path.Combine(Application.StartupPath, ConfigurationManager.AppSettings("RutaInformes").ToString())
    Public Sub New(ByVal modoformulario As String)

        ' Llamada necesaria para el diseñador.
        InitializeComponent()

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
        modo = modoformulario
    End Sub

    Private Sub frmMenuPrincipal_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        End
    End Sub
    Private Sub PrepararFormulario()

        If modo = "AL" Then
            ALUMNOSToolStripMenuItem.Visible = True
            AlumnosMantenimiento.Visible = False
            AlumnosConsulta.Visible = False

            PROFESORESToolStripMenuItem.Visible = False
            AULASToolStripMenuItem.Visible = False
            CURSOSToolStripMenuItem.Visible = False
            TABLASAUXILIARESToolStripMenuItem.Visible = False
            CONSULTASToolStripMenuItem.Visible = False

            INFORMESToolStripMenuItem.Visible = True
            InformesInformacionPorCurso.Visible = False
            InformesInformeDeIndividualDeUnAlumno.Visible = True
            InformesInformeDeUnCurso.Visible = False
            InformesListadoDeAlumnos.Visible = False
            InformesListadoDeAulas.Visible = False
            InformesListadoDeCursos.Visible = False
            InformesListadoDeProfesores.Visible = False


            btnCrudProfesores.Visible = False
            lblProfesores.Visible = False

            btnCrudAulas.Visible = False
            lblAulas.Visible = False

        Else
            If modo = "PF" Then
                ALUMNOSToolStripMenuItem.Visible = False
                PROFESORESToolStripMenuItem.Visible = False
                AULASToolStripMenuItem.Visible = True
                CURSOSToolStripMenuItem.Visible = False
                TABLASAUXILIARESToolStripMenuItem.Visible = False
                CONSULTASToolStripMenuItem.Visible = True
                INFORMESToolStripMenuItem.Visible = True

                btnCrudAulas.Visible = False
                lblAulas.Visible = False

                AULASToolStripMenuItem.Visible = False

            Else
                ALUMNOSToolStripMenuItem.Visible = True
                PROFESORESToolStripMenuItem.Visible = True
                AULASToolStripMenuItem.Visible = True
                CURSOSToolStripMenuItem.Visible = True
                TABLASAUXILIARESToolStripMenuItem.Visible = True
                CONSULTASToolStripMenuItem.Visible = True
                INFORMESToolStripMenuItem.Visible = True
            End If
        End If
    End Sub

    Private Sub btnCrudAlumnos_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCrudAlumnos.Click
        Using VarFrmCrudPersonas As New frmCrudPersonas(String.Empty, False)
            Call VarFrmCrudPersonas.ProcModoFormulario("ALM")

            VarFrmCrudPersonas.ShowDialog()
        End Using
    End Sub

    Private Sub btnCrudProfesores_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCrudProfesores.Click
        Using VarfrmCrudPersonas As New frmCrudPersonas(String.Empty, False)
            Call VarfrmCrudPersonas.ProcModoFormulario("PRF")
            VarfrmCrudPersonas.ShowDialog()
        End Using
    End Sub

    Private Sub btnCrudCursos_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCrudCursos.Click
        Using VarFrmCrudCursos As New frmCrudCursos(String.Empty, False)

            VarFrmCrudCursos.ShowDialog()
        End Using
    End Sub

    Private Sub btnMatriculacion_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnMatriculacion.Click
        Using VarFrmMatriculacion As New frmMatriculacion(String.Empty, False)

            VarFrmMatriculacion.ShowDialog()
        End Using
    End Sub

    Private Sub btnCrudAulas_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCrudAulas.Click
        Using VarFrmCrudAulas As New frmCrudAulas(String.Empty, False)
            VarFrmCrudAulas.ShowDialog()
        End Using
    End Sub



    'Private Sub btnTiposAulas_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnTiposAulas.Click
    '   

    'End Sub

    'Private Sub btnTiposUsuarios_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnTiposUsuarios.Click
    '    Using VarFrmTiposUsuarios As New frmCrudTiposUsuarios
    '        VarFrmTiposUsuarios.ShowDialog()
    '    End Using
    'End Sub

    'Private Sub btnTiposCursos_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnTiposCursos.Click
  
    'End Sub

    Private Sub btnAsistencia_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAsistencia.Click
        Using VarFmAsistenciasAlumno As New frmAsistenciasAlumno(String.Empty, False)
            VarFmAsistenciasAlumno.ShowDialog()
        End Using
    End Sub

   


    Private Sub btnCalificaciones_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCalificaciones.Click
        Using VarFrmCrudCalificaciones As New frmCrudCalificaciones(String.Empty, String.Empty, String.Empty, False)
            VarFrmCrudCalificaciones.ShowDialog()
        End Using
    End Sub



    'Private Sub btnConsultaProfesores_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnConsultaProfesores.Click
    '    Using VarFrmConsultaProfesores As New frmConsultaProfesores
    '        VarFrmConsultaProfesores.ShowDialog()
    '    End Using
    'End Sub

   
    Private Sub frmMenuPrincipal_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call PrepararFormulario()

    End Sub



    Private Sub TablasInformaciónDeLogin_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TablasInformaciónDeLogin.Click
        Using VarFrmCrudLogin As New frmCrudLogin
            VarFrmCrudLogin.ShowDialog()
        End Using
    End Sub

    Private Sub InformesListadoDeAlumnos_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles InformesListadoDeAlumnos.Click
        Try
            Dim InformesPath As String = Path.Combine(Application.StartupPath, ConfigurationManager.AppSettings("RutaInformes").ToString())
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

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        'Private Sub btnInformes_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnInformes.Click
        Using VarFrmInformes As New frmInformes
            VarFrmInformes.ShowDialog()
        End Using
        'End Sub
    End Sub

    Private Sub AlumnosMantenimiento_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AlumnosMantenimiento.Click
        Using VarFrmCrudPersonas As New frmCrudPersonas(String.Empty, False)
            Call VarFrmCrudPersonas.ProcModoFormulario("ALM")

            VarFrmCrudPersonas.ShowDialog()
        End Using
    End Sub

    Private Sub AlumnosConsulta_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AlumnosConsulta.Click
        Using VarFrmConsultaAlumnos As New frmConsultaAlumnos
            VarFrmConsultaAlumnos.ShowDialog()
        End Using
    End Sub

    Private Sub AlumnosMatriculacion_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AlumnosMatriculacion.Click
        Using VarFrmMatriculacion As New frmMatriculacion(String.Empty, False)

            VarFrmMatriculacion.ShowDialog()
        End Using
    End Sub

    Private Sub AlumnosAsistencia_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AlumnosAsistencia.Click
        Using VarFmAsistenciasAlumno As New frmAsistenciasAlumno(String.Empty, False)
            VarFmAsistenciasAlumno.ShowDialog()
        End Using
    End Sub

    Private Sub AlumnosCalificaciones_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AlumnosCalificaciones.Click
        Using VarFrmCrudCalificaciones As New frmCrudCalificaciones(String.Empty, String.Empty, String.Empty, False)
            VarFrmCrudCalificaciones.ShowDialog()
        End Using
    End Sub

    Private Sub ProfesoresMantenimiento_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ProfesoresMantenimiento.Click
        Using VarfrmCrudPersonas As New frmCrudPersonas(String.Empty, False)
            Call VarfrmCrudPersonas.ProcModoFormulario("PRF")
            VarfrmCrudPersonas.ShowDialog()
        End Using
    End Sub

    Private Sub ProfesoresConsulta_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ProfesoresConsulta.Click
        Using VarFrmConsultaProfesores As New frmConsultaProfesores
            VarFrmConsultaProfesores.ShowDialog()
        End Using
    End Sub

    Private Sub ProfesoresAsignaciónACursos_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ProfesoresAsignaciónACursos.Click
        Using VarFrmCrudCursos As New frmCrudCursos(String.Empty, False)

            VarFrmCrudCursos.ShowDialog()
        End Using
    End Sub

    Private Sub ProfesoresControlDeAsistencia_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ProfesoresControlDeAsistencia.Click
        Using VarFmAsistenciasAlumno As New frmAsistenciasAlumno(String.Empty, False)
            VarFmAsistenciasAlumno.ShowDialog()
        End Using
    End Sub

    Private Sub ProfesoresControlDeCalificaciones_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ProfesoresControlDeCalificaciones.Click
        Using VarFrmCrudCalificaciones As New frmCrudCalificaciones(String.Empty, String.Empty, String.Empty, False)
            VarFrmCrudCalificaciones.ShowDialog()
        End Using
    End Sub

    Private Sub AulasMantenimiento_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AulasMantenimiento.Click
        Using VarFrmCrudAulas As New frmCrudAulas(String.Empty, False)
            VarFrmCrudAulas.ShowDialog()
        End Using
    End Sub

    Private Sub CursosMantenimiento_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CursosMantenimiento.Click
        Using VarFrmCrudCursos As New frmCrudCursos(String.Empty, False)

            VarFrmCrudCursos.ShowDialog()
        End Using
    End Sub

    Private Sub CursosConsulta_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CursosConsulta.Click
        Using VarFrmConsultaCursos As New frmConsultaCursos
            VarFrmConsultaCursos.ShowDialog()
        End Using
    End Sub

    Private Sub TablasCodigosPostales_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TablasCodigosPostales.Click
        Using VarFrmCodigosPostales As New frmCrudCodigosPostales
            VarFrmCodigosPostales.ShowDialog()
        End Using
    End Sub

    Private Sub TablasTiposAulas_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TablasTiposAulas.Click
        Using VarFrmTiposAulas As New frmCrudTiposAulas
            VarFrmTiposAulas.ShowDialog()
        End Using
    End Sub

    Private Sub TablasTiposDeCursos_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TablasTiposDeCursos.Click
        Using VarFrmTiposCursos As New frmCrudTiposCursos
            VarFrmTiposCursos.ShowDialog()
        End Using
    End Sub

    Private Sub TablasTiposDeUsuarios_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TablasTiposDeUsuarios.Click
        Using VarFrmTiposUsuarios As New frmCrudTiposUsuarios
            VarFrmTiposUsuarios.ShowDialog()
        End Using
    End Sub

    Private Sub ConsultasAlumnos_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ConsultasAlumnos.Click
        Using VarFrmConsultaAlumnos As New frmConsultaAlumnos
            VarFrmConsultaAlumnos.ShowDialog()
        End Using
    End Sub

    Private Sub ConsultasProfesores_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ConsultasProfesores.Click
        Using VarFrmConsultaProfesores As New frmConsultaProfesores
            VarFrmConsultaProfesores.ShowDialog()
        End Using
    End Sub

    Private Sub ConsultasCursos_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ConsultasCursos.Click
        Using VarFrmConsultaCursos As New frmConsultaCursos
            VarFrmConsultaCursos.ShowDialog()
        End Using
    End Sub

    Private Sub InformesListadoDeProfesores_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles InformesListadoDeProfesores.Click
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

    Private Sub InformesListadoDeAulas_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles InformesListadoDeAulas.Click
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

    Private Sub InformesListadoDeCursos_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles InformesListadoDeCursos.Click
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

    Private Sub InformesInformacionPorCurso_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles InformesInformacionPorCurso.Click

    End Sub

    Private Sub InformesInformeDeUnCurso_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles InformesInformeDeUnCurso.Click
        Try
            Dim VarFrmSeleccionCUrso As New frmSeleccionCurso

            frmSeleccionCurso.ShowDialog()
        Catch ex As Exception
            MsgBox("Se ha producido la siguiente excepción: " + vbCrLf + _
                    ex.Message, CType(MsgBoxStyle.OkOnly + MsgBoxStyle.Critical, MsgBoxStyle), "Error...")
        End Try
    End Sub
End Class