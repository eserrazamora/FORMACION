Imports Formacion.CapaDeNegocio
Imports Formacion.Entidades

Public Class frmCrudAulas
    Private FormularioInvocado As Boolean = False  'Si esta a true indica que el formulario ha sido llamado
    Private aula As EntidadAula = Nothing
    Public Sub New(ByVal codigo As String, ByVal invocado As Boolean)
        ' Llamada necesaria para el diseñador.
        InitializeComponent()

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
        FormularioInvocado = invocado
        txtCodigo.Text = codigo
    End Sub
    Private Function Validaciones() As Boolean
        'Validaciones que se van a llevar a cabo en este formulario
        'Devolvera TRUE si no hay errores
        'El campo codigo debe contener 4 digitos y no puede ir vacio
        'El campo nombre es requerido, luego no puede ir vacio
        'El combo tipo de aula debe contener un valor
        Dim cadena As String = String.Empty
        Dim numerrores As Integer = 0

        If txtCodigo.Text = String.Empty Then
            cadena = "El campo 'Codigo' no puede ser vacio." + vbCrLf
            txtCodigo.BackColor = Color.Red
            numerrores += 1
        Else
            txtCodigo.BackColor = System.Drawing.ColorTranslator.FromWin32(RGB(64, 64, 64))
        End If

        If txtCodigo.TextLength <> 4 Then
            cadena = cadena + "El campo 'Codigo' debe contener 4 caracteres." + vbCrLf
            txtCodigo.BackColor = Color.Red
            numerrores += 1
        Else
            If numerrores = 0 Then
                txtCodigo.BackColor = System.Drawing.ColorTranslator.FromWin32(RGB(64, 64, 64))
            End If
        End If

        If txtNombreAula.Text = String.Empty Then
            cadena = cadena + "El campo 'Nombre del Aula' no puede ser vacio." + vbCrLf
            txtNombreAula.BackColor = Color.Red
            numerrores += 1
        Else
            txtNombreAula.BackColor = System.Drawing.ColorTranslator.FromWin32(RGB(64, 64, 64))
        End If

        If CStr(cboTipoAula.SelectedValue) = "SELE" Then
            cadena = cadena + "Debe seleccionar el Tipo del Aula." + vbCrLf
            cboTipoAula.BackColor = Color.Red
            numerrores += 1
        Else
            cboTipoAula.BackColor = System.Drawing.ColorTranslator.FromWin32(RGB(64, 64, 64))
        End If

        If numerrores = 0 Then
            txtCodigo.BackColor = System.Drawing.ColorTranslator.FromWin32(RGB(64, 64, 64))
            txtNombreAula.BackColor = System.Drawing.ColorTranslator.FromWin32(RGB(64, 64, 64))
            cboTipoAula.BackColor = System.Drawing.ColorTranslator.FromWin32(RGB(64, 64, 64))
            Return True
        Else
            If numerrores = 1 Then
                cadena = cadena + "Debe corregir este error antes de continuar."
            Else
                cadena = cadena + "Debe corregir estos errores antes de continuar."
            End If
            MsgBox(cadena, CType(MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, MsgBoxStyle), "Fallo en las validaciones...")

            'Paso el foco al primer error
            If txtCodigo.BackColor = Color.Red Then
                txtCodigo.Focus()
            Else
                If txtNombreAula.BackColor = Color.Red Then
                    txtNombreAula.Focus()
                Else
                    If cboTipoAula.BackColor = Color.Red Then
                        cboAsignarCurso.Focus()
                    End If
                End If
            End If

            Return False
        End If


    End Function
    Private Function BuscarCodigoAula(ByVal codigo As String, ByVal dgv As DataGridView) As Boolean
        Dim encontrado As Boolean = False

        encontrado = BuscarEnDataGrid(txtCodigo.Text, "clnCodigoAula", dgvListadoAulas)

        If encontrado Then

            'DesHabilito las cajas y los combos
            Call DesHabilitarCajasTexto()
            Call DesHabilitarCombos()

            Call HabilitarBotonesOperacionBarra()

            dgvListadoAulas.Enabled = True
            dgvListadoCursosAula.Enabled = True

            btnBuscarCodigoAula.Visible = False

            'Copio los valores en las cajas
            txtCodigo.Text = CStr(dgvListadoAulas.CurrentRow.Cells("clnCodigoAula").Value)
            txtNombreAula.Text = CStr(dgvListadoAulas.CurrentRow.Cells("clnNombreAula").Value)
            cboTipoAula.SelectedValue = CStr(dgvListadoAulas.CurrentRow.Cells("clnCodigoTipoAula").Value)
            txtObservaciones.Text = CStr(dgvListadoAulas.CurrentRow.Cells("clnObservacionesAula").Value)

            'Cargo los cursos asociados al aula seleccionada
            Dim codigoaula As String

            codigoaula = CStr(dgvListadoAulas.CurrentRow.Cells("clnCodigoAula").Value)

            dgvListadoCursosAula.AutoGenerateColumns = False
            dgvListadoCursosAula.DataSource = CursosBO.CargarCursosAula(codigoaula)
            dgvListadoCursosAula.ClearSelection()
            dgvListadoCursosAula.Enabled = True

        End If

        Return encontrado

    End Function
    Private Function CargarValoresControlesEnEntidad() As EntidadAula
        Dim aula As New EntidadAula

        'Guardo en la entidad los valores de las cajas
        aula.Codigo = txtCodigo.Text
        aula.Nombre = txtNombreAula.Text
        aula.Tipo = CStr(cboTipoAula.SelectedValue)
        aula.Observaciones = txtObservaciones.Text

        Return aula
    End Function
    Private Sub ActualizarAula()
        Dim curso As New EntidadCursos

        'Actualizo el Aula del Curso
        If CStr(cboAsignarCurso.SelectedValue) <> "SELE" Then
            curso.CodigoCurso = CStr(cboAsignarCurso.SelectedValue)
            curso.Aula = txtCodigo.Text

            Call CursosBO.ActualizarAula(curso)

        End If
    End Sub
    Private Sub BorrarCajasTexto()
        txtCodigo.Text = String.Empty
        txtNombreAula.Text = String.Empty
        txtObservaciones.Text = String.Empty
    End Sub
    Private Sub HabilitarCajasTexto()
        txtCodigo.Enabled = True
        txtNombreAula.Enabled = True
        txtObservaciones.Enabled = True

        txtCodigo.BackColor = Me.BackColor
        txtNombreAula.BackColor = Me.BackColor
        txtObservaciones.BackColor = Me.BackColor

    End Sub
    Private Sub DesHabilitarCajasTexto()
        txtCodigo.Enabled = False
        txtNombreAula.Enabled = False
        txtObservaciones.Enabled = False

        txtCodigo.BackColor = Color.LightGray
        txtNombreAula.BackColor = Color.LightGray
        txtObservaciones.BackColor = Color.LightGray

    End Sub
    Private Sub HabilitarCombos()
        cboAsignarCurso.Enabled = True
        cboTipoAula.Enabled = True
    End Sub
    Private Sub DesHabilitarCombos()
        cboAsignarCurso.Enabled = False
        cboTipoAula.Enabled = False
    End Sub

    Private Sub HabilitarBotonesOperacionBarra()

        tlbNuevo.Enabled = True
        tlbEditar.Enabled = True
        tlbBorrar.Enabled = True
        tlbBuscar.Enabled = True

    End Sub

    Private Sub DesHabilitarBotonesOperacionBarra()
        tlbNuevo.Enabled = False
        tlbEditar.Enabled = False
        tlbBorrar.Enabled = False
        tlbBuscar.Enabled = False

    End Sub

    Private Sub MostrarBotonesGuardar()
        tlbGuardar.Visible = True
        tlbActualizar.Visible = True
        tlbCancelar.Visible = True
    End Sub

    Private Sub OcultarBotonesGuardar()
        tlbGuardar.Visible = False
        tlbActualizar.Visible = False
        tlbCancelar.Visible = False
    End Sub
    Private Sub CargarComboTiposAulas()
        Try
            Dim dtTipoAula As DataTable

            'Cargo el ComboBox de Tipos de Aulas
            dtTipoAula = TiposAulasBO.CargarTodosEnDataTable

            ' Añadimos una nueva fila al objeto DataTable
            Dim row As DataRow = dtTipoAula.NewRow

            ' Establecemos el valor del campo Nombre
            row("Tipo") = "<Seleccionar>"

            ' Establecemos el valor de otro Campo
            row("Codigo") = "SELE"

            ' Insertamos la fila en la primera posición
            dtTipoAula.Rows.InsertAt(row, 0)

            cboTipoAula.ValueMember = "Codigo"
            cboTipoAula.DisplayMember = "Tipo"
            cboTipoAula.DataSource = dtTipoAula

            cboTipoAula.SelectedValue = "SELE"
        Catch ex As Exception
            MsgBox("Se ha producido la siguiente excepción: " + vbCrLf + _
                    ex.Message, CType(MsgBoxStyle.OkOnly + MsgBoxStyle.Critical, MsgBoxStyle), "Error...")
        End Try
    End Sub
    'Este procedimiento carga los cursos sin aula
    Private Sub CargarComboCursos()
        Try
            Dim dtCursos As DataTable

            'Cargo el ComboBox de Tipos de Aulas
            dtCursos = CursosBO.CargarCursosSinAulaenDatatable

            ' Añadimos una nueva fila al objeto DataTable
            Dim row As DataRow = dtCursos.NewRow

            ' Establecemos el valor del campo Nombre
            row("Info") = "<Seleccionar>"

            ' Establecemos el valor de otro Campo
            row("CodigoCurso") = "SELE"

            ' Insertamos la fila en la primera posición
            dtCursos.Rows.InsertAt(row, 0)

            cboAsignarCurso.ValueMember = "CodigoCurso"
            cboAsignarCurso.DisplayMember = "Info"
            cboAsignarCurso.DataSource = dtCursos

            cboAsignarCurso.SelectedValue = "SELE"
        Catch ex As Exception
            MsgBox("Se ha producido la siguiente excepción: " + vbCrLf + _
                    ex.Message, CType(MsgBoxStyle.OkOnly + MsgBoxStyle.Critical, MsgBoxStyle), "Error...")
        End Try
    End Sub

    Private Sub EstadoInicialFormulario()
        Try
            'Cargo el Datagrid de Aulas
            dgvListadoAulas.AutoGenerateColumns = False
            dgvListadoAulas.DataSource = AulasBO.CargarTodos()
            dgvListadoAulas.ClearSelection()
            dgvListadoAulas.Enabled = True

            'Borro el grid de Listado de Curso
            dgvListadoCursosAula.ClearSelection()
            dgvListadoCursosAula.DataSource = Nothing

            'Cargo el Combo de Tipos de Aulas
            Call CargarComboTiposAulas()

            'Cargo el Combo de Cursos
            Call CargarComboCursos()

            'Deshabilito Cajas de Texto
            If Not FormularioInvocado Then
                Call BorrarCajasTexto()
            End If

            Call DesHabilitarCajasTexto()
            Call OcultarBotonesGuardar()

            btnBuscarCodigoAula.Visible = False

            'Deshabilito los combo
            Call DesHabilitarCombos()

            If FormularioInvocado Then
                Call BuscarCodigoAula(txtCodigo.Text, dgvListadoAulas)
                'Muestro/Oculto botones del Menu
                Call DesHabilitarBotonesOperacionBarra()
                tlbEditar.Enabled = True

                dgvListadoAulas.Enabled = False
                dgvListadoCursosAula.Enabled = False
            Else
                'Muestro/Oculto botones del Menu
                Call DesHabilitarBotonesOperacionBarra()
                tlbNuevo.Enabled = True
                tlbBuscar.Enabled = True
            End If

        Catch ex As Exception
            MsgBox("Se ha producido la siguiente excepción: " + vbCrLf + _
                    ex.Message, CType(MsgBoxStyle.OkOnly + MsgBoxStyle.Critical, MsgBoxStyle), "Error...")
        End Try
    End Sub




    Private Sub frmCrudAulas_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Call EstiloDataGrid(dgvListadoAulas)
        Call EstiloDataGrid(dgvListadoCursosAula)
        Call EstadoInicialFormulario()
    End Sub

    Private Sub dgvListadoAulas_CellMouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles dgvListadoAulas.CellMouseClick
        Try
            If e.RowIndex >= 0 Then

                Dim codigoaula As String

                txtCodigo.Text = CStr(dgvListadoAulas.Rows(e.RowIndex).Cells("clnCodigoAula").Value)
                txtNombreAula.Text = CStr(dgvListadoAulas.Rows(e.RowIndex).Cells("clnNombreAula").Value)
                cboTipoAula.SelectedValue = CStr(dgvListadoAulas.Rows(e.RowIndex).Cells("clnCodigoTipoAula").Value)
                txtObservaciones.Text = CStr(dgvListadoAulas.Rows(e.RowIndex).Cells("clnObservacionesAula").Value)

                'Cargo los cursos asociados al aula seleccionada
                codigoaula = CStr(dgvListadoAulas.Rows(e.RowIndex).Cells("clnCodigoAula").Value)

                dgvListadoCursosAula.AutoGenerateColumns = False
                dgvListadoCursosAula.DataSource = CursosBO.CargarCursosAula(codigoaula)
                dgvListadoCursosAula.ClearSelection()
                dgvListadoCursosAula.Enabled = True

                'Muestro/Oculto botones del Menu
                Call HabilitarBotonesOperacionBarra()
                Call OcultarBotonesGuardar()

            End If
        Catch ex As Exception
            MsgBox("Se ha producido la siguiente excepción: " + vbCrLf + _
                    ex.Message, CType(MsgBoxStyle.OkOnly + MsgBoxStyle.Critical, MsgBoxStyle), "Error...")
        End Try
    End Sub
    Private Sub tlbNuevo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tlbNuevo.Click

        'Borro y habilito las cajas y los combos
        Call BorrarCajasTexto()

        Call HabilitarCajasTexto()
        Call HabilitarCombos()


        'Quito la seleccion del Grid de Listado de Aulas y lo deshabilito
        dgvListadoAulas.ClearSelection()
        dgvListadoAulas.Enabled = False

        'Limpio el grid de cursos en un aula
        dgvListadoCursosAula.ClearSelection()
        dgvListadoCursosAula.Enabled = False
        dgvListadoCursosAula.DataSource = vbNull

        'Muestro/Oculto botones del Menu
        Call DesHabilitarBotonesOperacionBarra()
        Call MostrarBotonesGuardar()
        tlbActualizar.Visible = False

        cboTipoAula.SelectedValue = "SELE"

        'Paso el Foco a la primera caja
        txtCodigo.Focus()

    End Sub
    Private Sub tlbEditar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tlbEditar.Click
        'Preparo las cajas
        Call HabilitarCajasTexto()
        Call HabilitarCombos()
        txtCodigo.Enabled = False

        'Deshabilito el Grid de listado de aulas y el de cursos por aulas
        dgvListadoAulas.Enabled = False
        dgvListadoCursosAula.Enabled = False
        dgvListadoCursosAula.ClearSelection()

        'Muestro/Oculto botones del Menu
        Call DesHabilitarBotonesOperacionBarra()
        Call MostrarBotonesGuardar()
        tlbGuardar.Visible = False

    End Sub

    Private Sub tlbBuscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tlbBuscar.Click
        If dgvListadoAulas.RowCount > 0 Then
            'Preparo las cajas
            Call BorrarCajasTexto()
            Call DesHabilitarCajasTexto()

            txtCodigo.Enabled = True
            txtCodigo.BackColor = Me.BackColor
            txtCodigo.Focus()

            dgvListadoAulas.Enabled = False
            dgvListadoAulas.ClearSelection()

            dgvListadoCursosAula.Enabled = False
            dgvListadoCursosAula.ClearSelection()

            'Deshabilito los combos
            Call DesHabilitarCombos()

            'Muestro/Oculto botones del Menu
            Call DesHabilitarBotonesOperacionBarra()
            Call OcultarBotonesGuardar()

            btnBuscarCodigoAula.Visible = True
        Else
            MsgBox("No existen registros que buscar.", CType(MsgBoxStyle.Exclamation + vbOKOnly, MsgBoxStyle), "No existen registros...")
            Call EstadoInicialFormulario()
        End If
    End Sub


    Private Sub btnBuscarCodigoAula_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBuscarCodigoAula.Click
        Try

            Dim encontrado As Boolean = False
            encontrado = BuscarCodigoAula(txtCodigo.Text, dgvListadoAulas)

            If Not encontrado Then
                MsgBox("No se encontro ninguna coincidencia.", CType(MsgBoxStyle.Information + vbOKOnly, MsgBoxStyle), "Ninguna coincidencia...")
                txtCodigo.Focus()
            End If

        Catch ex As Exception
            MsgBox("Se ha producido la siguiente excepción: " + vbCrLf + _
                    ex.Message, CType(MsgBoxStyle.OkOnly + MsgBoxStyle.Critical, MsgBoxStyle), "Error...")
        End Try
    End Sub
    Private Sub tlbGuardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tlbGuardar.Click
        Try
            If Validaciones() Then
                Dim curso As New EntidadCursos

                If aula Is Nothing Then
                    aula = New EntidadAula()
                End If

                aula = CargarValoresControlesEnEntidad()

                Call AulasBO.Guardar(aula)
                Call ActualizarAula()

                'Pongo el formulario en su estado inicial
                Call EstadoInicialFormulario()
            End If
        Catch ex As Exception
            MsgBox("Se ha producido la siguiente excepción: " + vbCrLf + _
                    ex.Message, CType(MsgBoxStyle.OkOnly + MsgBoxStyle.Critical, MsgBoxStyle), "Error...")
        End Try

    End Sub
    Private Sub tlbCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tlbCancelar.Click
        If FormularioInvocado Then
            Me.Close()
        Else
            Call EstadoInicialFormulario()
        End If

    End Sub
    Private Sub tlbActualizar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tlbActualizar.Click
        Try
            If Validaciones() Then
                Dim curso As New EntidadCursos

                If aula Is Nothing Then
                    aula = New EntidadAula()
                End If

                aula = CargarValoresControlesEnEntidad()
                'Actualizo la informacion del aula
                Call AulasBO.Actualizar(aula)

                'Actualizo el aula del curso
                Call ActualizarAula()

                If FormularioInvocado Then
                    Me.Close()
                Else
                    'Pongo el formulario en su estado inicial
                    Call EstadoInicialFormulario()
                End If
               
            End If
        Catch ex As Exception
            MsgBox("Se ha producido la siguiente excepción: " + vbCrLf + _
                    ex.Message, CType(MsgBoxStyle.OkOnly + MsgBoxStyle.Critical, MsgBoxStyle), "Error...")
        End Try
    End Sub

    Private Sub tlbBorrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tlbBorrar.Click
        Try
            Dim codigo As String

            codigo = txtCodigo.Text

            If AulasBO.ComprobarDependencias(codigo) Then
                MsgBox("Existen dependencias en otras tablas. " + vbCrLf + _
                       "No se puede borrar el registro.", CType(MsgBoxStyle.OkOnly + MsgBoxStyle.Critical, MsgBoxStyle), "Error...")
            Else
                Call AulasBO.Borrar(codigo)
                Call EstadoInicialFormulario()
            End If
        Catch ex As Exception
            MsgBox("Se ha producido la siguiente excepción: " + vbCrLf + _
                    ex.Message, CType(MsgBoxStyle.OkOnly + MsgBoxStyle.Critical, MsgBoxStyle), "Error...")
        End Try
    End Sub

    Private Sub dgvListadoCursosAula_CellMouseDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles dgvListadoCursosAula.CellMouseDoubleClick
        Try
            If e.RowIndex >= 0 Then
                Dim curso As String = CStr(dgvListadoCursosAula.Rows(e.RowIndex).Cells("clnCodigo").Value)
                Dim codigoaula As String = CStr(dgvListadoAulas.CurrentRow.Cells("clnCodigoAula").Value)
                Using VarFrmCursos As New frmCrudCursos(curso, True)
                    VarFrmCursos.ShowDialog()
                    BuscarCodigoAula(codigoaula, dgvListadoAulas)
                End Using
            End If

        Catch ex As Exception
            MsgBox("Se ha producido la siguiente excepción: " + vbCrLf + _
                    ex.Message, CType(MsgBoxStyle.OkOnly + MsgBoxStyle.Critical, MsgBoxStyle), "Error...")
        End Try
    End Sub

    Private Sub dgvListadoAulas_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvListadoAulas.CellContentClick

    End Sub
End Class