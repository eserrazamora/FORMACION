Imports Formacion.CapaDeNegocio

Public Class frmSeleccionCurso
    Public Sub CargarComboCursos()
        Try
            Dim dtCursos As DataTable = Nothing

            dtCursos = CursosBO.CargarTodosEnDataTable

            ' Añadimos una nueva fila al objeto DataTable
            Dim row As DataRow = dtCursos.NewRow

            ' Establecemos el valor del campo Nombre
            row("Info") = "<Seleccionar>"
            row("CodigoCurso") = "SELE"

            ' Insertamos la fila en la primera posición
            dtCursos.Rows.InsertAt(row, 0)

            cboCursos.DisplayMember = "Info"
            cboCursos.ValueMember = "CodigoCurso"
            cboCursos.DataSource = dtCursos

        Catch ex As Exception
            MsgBox("Se ha producido la siguiente excepción: " + vbCrLf + _
                    ex.Message, CType(MsgBoxStyle.OkOnly + MsgBoxStyle.Critical, MsgBoxStyle), "Error...")
        End Try
    End Sub
    Private Sub EstadoInicialFormulario()
        Call CargarComboCursos()

    End Sub

    Private Sub frmSeleccionCurso_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call EstadoInicialFormulario()
    End Sub

    Private Sub btnInformeUnCurso_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnInformeUnCurso.Click
        Try
            Dim curso As String
            curso = CStr(cboCursos.SelectedValue)

            If curso <> "SELE" Then
                Dim VarFrmPrevisualizacionInforme As New frmPrevisualizacionInforme
                Dim crDatosCurso As New CrystalDecisions.CrystalReports.Engine.ReportDocument

                crDatosCurso = Formacion.Informes.vb.FuncionesInformes.CargarDatasets(curso)

                VarFrmPrevisualizacionInforme.crViewer.ReportSource = crDatosCurso
                VarFrmPrevisualizacionInforme.ShowDialog()
            Else
                MsgBox("Debe seleccionar un curso.", CType(MsgBoxStyle.OkOnly + MsgBoxStyle.Information, MsgBoxStyle), "Selección Incorrecta...")
                cboCursos.Focus()
            End If

        Catch ex As Exception
            MsgBox("Se ha producido la siguiente excepción: " + vbCrLf + _
                    ex.Message, CType(MsgBoxStyle.OkOnly + MsgBoxStyle.Critical, MsgBoxStyle), "Error...")
        End Try
    End Sub
End Class