Imports Formacion.CapaDeNegocio
Imports Formacion.Entidades
Public Class frmConsultaCursos

    Private curso As EntidadCursos

    Private Sub BorrarCajasTexto()
        txtCodigo.Text = String.Empty
        txtNombreCurso.Text = String.Empty
        txtFechaInicio.Text = String.Empty
        txtFechaFin.Text = String.Empty
        txtDuracion.Text = String.Empty
    End Sub
    Private Function CargarControlesEnEntidad() As EntidadCursos
        Dim curso As New EntidadCursos

        curso.CodigoCurso = CStr(txtCodigo.Text)
        curso.Nombre = CStr(txtNombreCurso.Text)
        If Not IsDate(txtFechaInicio.Text) Then
            curso.FechaInicio = Nothing
        Else
            curso.FechaInicio = CDate(txtFechaInicio.Text)
        End If

        If Not IsDate(txtFechaFin.Text) Then
            curso.FechaFin = Nothing
        Else
            curso.FechaFin = CDate(txtFechaFin.Text)
        End If

        If txtDuracion.Text = String.Empty Then
            curso.Duracion = Nothing
        Else
            curso.Duracion = CInt(txtDuracion.Text)
        End If

        Return (curso)

    End Function
    Private Sub BuscarCurso()
        If curso Is Nothing Then
            curso = New EntidadCursos()
        End If

        curso = CargarControlesEnEntidad()

        'Cargo el Datagrid de Personas
        dgvListadoCursos.AutoGenerateColumns = False
        dgvListadoCursos.DataSource = CursosBO.ConsultarDatosCursos(curso)
        dgvListadoCursos.ClearSelection()
    End Sub
    Private Sub EstadoInicialFormulario()
        Call BorrarCajasTexto()
        txtCodigo.Focus()
    End Sub
    Private Sub frmConsultacursos_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call EstiloDataGrid(dgvListadoCursos)
        Call EstadoInicialFormulario()

    End Sub


  

    Private Sub dgvListadoCursos_CellMouseDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles dgvListadoCursos.CellMouseDoubleClick
        If e.RowIndex >= 0 Then
            Dim curso As String = CStr(dgvListadoCursos.Rows(e.RowIndex).Cells("clnCodigo").Value)
            Using VarFrmCursos As New frmCrudCursos(curso, True)
                VarFrmCursos.ShowDialog()
                Call BuscarCurso()
            End Using
        End If
    End Sub



    Private Sub btnBuscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBuscar.Click
        Try
            Call BuscarCurso()
        Catch ex As Exception
            MsgBox("Se ha producido la siguiente excepción: " + vbCrLf + _
                    ex.Message, CType(MsgBoxStyle.OkOnly + MsgBoxStyle.Critical, MsgBoxStyle), "Error...")
        End Try
    End Sub

    Private Sub btnBorrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBorrar.Click
        Call BorrarCajasTexto()
        dgvListadoCursos.DataSource = Nothing

        txtCodigo.Focus()
    End Sub
End Class