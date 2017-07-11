Imports Formacion.CapaDeNegocio
Imports Formacion.Entidades
Public Class frmConsultaAlumnos

    Private alumno As EntidadPersona

    Private Sub BorrarCajasTexto()
        txtNif.Text = String.Empty
        txtNombre.Text = String.Empty
        txtApellidos.Text = String.Empty
        txtTelefonoFijo.Text = String.Empty
        txtTelefonoMovil.Text = String.Empty
        txtEmail.Text = String.Empty
    End Sub
    Private Function CargarControlesEnEntidad() As EntidadPersona
        Dim alumno As New EntidadPersona

        alumno.Nif = txtNif.Text
        alumno.Nombre = txtNombre.Text
        alumno.Apellidos = txtApellidos.Text
        alumno.TelefonoFijo = txtTelefonoFijo.Text
        alumno.TelefonoMovil = txtTelefonoMovil.Text
        alumno.Email = txtEmail.Text

        Return alumno

    End Function
    Private Sub BuscarAlumno()
        If alumno Is Nothing Then
            alumno = New EntidadPersona()
        End If

        alumno = CargarControlesEnEntidad()

        'Cargo el Datagrid de Personas
        dgvListadoAlumnos.AutoGenerateColumns = False
        dgvListadoAlumnos.DataSource = PersonasBO.ConsultarDatosAlumnos(alumno)
        dgvListadoAlumnos.ClearSelection()
    End Sub
    Private Sub EstadoInicialFormulario()
        Call BorrarCajasTexto()
        txtNif.Focus()
    End Sub
    Private Sub frmConsultaAlumnos_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call EstiloDataGrid(dgvListadoAlumnos)
        Call EstadoInicialFormulario()

    End Sub

    Private Sub btnBuscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBuscar.Click
        Try
            Call BuscarAlumno()
        Catch ex As Exception
            MsgBox("Se ha producido la siguiente excepción: " + vbCrLf + _
                    ex.Message, CType(MsgBoxStyle.OkOnly + MsgBoxStyle.Critical, MsgBoxStyle), "Error...")
        End Try
    End Sub

    Private Sub btnBorrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBorrar.Click
        Call BorrarCajasTexto()
        dgvListadoAlumnos.DataSource = Nothing

        txtNif.Focus()
    End Sub

    Private Sub dgvListadoAlumnos_CellMouseDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles dgvListadoAlumnos.CellMouseDoubleClick
        If e.RowIndex >= 0 Then
            Dim nif As String = CStr(dgvListadoAlumnos.Rows(e.RowIndex).Cells("clnNIF").Value)
            Using VarFrmPersonas As New frmCrudPersonas(nif, True)
                Call VarFrmPersonas.ProcModoFormulario("ALM")
                VarFrmPersonas.ShowDialog()
                Call BuscarAlumno()
            End Using
        End If
    End Sub

    Private Sub dgvListadoAlumnos_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvListadoAlumnos.CellContentClick

    End Sub

    Private Sub lblLimpiar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblLimpiar.Click

    End Sub

    Private Sub lblConsultar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblConsultar.Click

    End Sub
End Class