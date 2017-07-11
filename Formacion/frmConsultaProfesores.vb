Imports Formacion.CapaDeNegocio
Imports Formacion.Entidades
Public Class frmConsultaProfesores


    Private profesor As EntidadPersona

    Private Sub BorrarCajasTexto()
        txtNif.Text = String.Empty
        txtNombre.Text = String.Empty
        txtApellidos.Text = String.Empty
        txtTelefonoFijo.Text = String.Empty
        txtTelefonoMovil.Text = String.Empty
        txtEmail.Text = String.Empty
    End Sub
    Private Function CargarControlesEnEntidad() As EntidadPersona
        Dim profesor As New EntidadPersona

        profesor.Nif = txtNif.Text
        profesor.Nombre = txtNombre.Text
        profesor.Apellidos = txtApellidos.Text
        profesor.TelefonoFijo = txtTelefonoFijo.Text
        profesor.TelefonoMovil = txtTelefonoMovil.Text
        profesor.Email = txtEmail.Text

        Return profesor

    End Function
    Private Sub BuscarProfesor()
        If profesor Is Nothing Then
            profesor = New EntidadPersona()
        End If

        profesor = CargarControlesEnEntidad()

        'Cargo el Datagrid de Personas
        dgvListadoProfesores.AutoGenerateColumns = False
        dgvListadoProfesores.DataSource = PersonasBO.ConsultarDatosProfesores(profesor)
        dgvListadoProfesores.ClearSelection()
    End Sub

    Private Sub EstadoInicialFormulario()
        Call BorrarCajasTexto()
        txtNif.Focus()
    End Sub
    Private Sub frmConsultaAlumnos_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call EstiloDataGrid(dgvListadoProfesores)
        Call EstadoInicialFormulario()

    End Sub


    Private Sub dgvListadoProfesores_CellMouseDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles dgvListadoProfesores.CellMouseDoubleClick
        If e.RowIndex >= 0 Then
            Dim nif As String = CStr(dgvListadoProfesores.Rows(e.RowIndex).Cells("clnNIF").Value)
            Using VarFrmPersonas As New frmCrudPersonas(nif, True)
                Call VarFrmPersonas.ProcModoFormulario("PRF")
                VarFrmPersonas.ShowDialog()
                Call BuscarProfesor()
            End Using
        End If
    End Sub
    Private Sub frmConsultaProfesores_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call EstiloDataGrid(dgvListadoProfesores)
        Call EstadoInicialFormulario()
    End Sub





    Private Sub btnBuscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBuscar.Click
        Try
            Call BuscarProfesor()

        Catch ex As Exception
            MsgBox("Se ha producido la siguiente excepción: " + vbCrLf + _
                    ex.Message, CType(MsgBoxStyle.OkOnly + MsgBoxStyle.Critical, MsgBoxStyle), "Error...")
        End Try
    End Sub

    Private Sub btnBorrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBorrar.Click
        Call BorrarCajasTexto()
        dgvListadoProfesores.DataSource = Nothing
        txtNif.Focus()
    End Sub
End Class