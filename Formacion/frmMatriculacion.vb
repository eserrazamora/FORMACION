Imports Formacion.CapaDeNegocio
Imports Formacion.Entidades
Public Class frmMatriculacion

    Private matricula As EntidadMatricula
    Private FormularioInvocado As Boolean = False  'Si esta a true indica que el formulario ha sido llamado
    Private nif As String = String.Empty

    Public Sub New(ByVal nifalumno As String, ByVal invocado As Boolean)

        ' Llamada necesaria para el diseñador.
        InitializeComponent()

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
        FormularioInvocado = invocado
        nif = nifalumno
    End Sub
    Private Function Validaciones() As Boolean
        Try
            'Si estamos Guardando, se debe seleccionar un curso
            Dim cadena As String = String.Empty
            Dim numerrores As Integer = 0

            If CStr(cboAsignarCurso.SelectedValue) = "SELE" Then
                cadena = "Debe seleccionar un curso al que matricularse." + vbCrLf
                cboAsignarCurso.BackColor = Color.Red
                numerrores += 1
            End If

            If numerrores = 0 Then
                cboAsignarCurso.BackColor = System.Drawing.ColorTranslator.FromWin32(RGB(64, 64, 64))
                Return True
            Else
                If numerrores = 1 Then
                    cadena = cadena + "Debe corregir este error antes de continuar."
                Else
                    cadena = cadena + "Debe corregir estos errores antes de continuar."
                End If

                MsgBox(cadena, CType(MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, MsgBoxStyle), "Fallo en las validaciones...")

                'Paso el foco al primer error
                If cboAsignarCurso.BackColor = Color.Red Then
                    cboAsignarCurso.Focus()
                End If

                Return False
            End If

        Catch ex As Exception
            MsgBox("Se ha producido la siguiente excepción: " + vbCrLf + _
                    ex.Message, CType(MsgBoxStyle.OkOnly + MsgBoxStyle.Critical, MsgBoxStyle), "Error...")
            Return False
        End Try
    End Function
    Private Sub HabilitarDataGridView()
        dgvListadoCursosMatriculados.Enabled = True
    End Sub
    Private Sub DesHabilitarDataGridView()
        dgvListadoCursosMatriculados.Enabled = False
        dgvListadoCursosMatriculados.ReadOnly = True
    End Sub
    Private Sub DesHabilitaryOcultarPagado()
        chkPagado.Enabled = False
        chkPagado.Visible = False
    End Sub
    Private Sub HabilitaryMostrarPagado()
        chkPagado.Enabled = True
        chkPagado.Visible = True
    End Sub
    Private Sub BorrarPagadoyCodMatricula()
        lblCodigoMatriculaText.Text = String.Empty
        chkPagado.Checked = False
    End Sub
    Private Sub HabilitarBotonesOperacionBarra()

        If cboAsignarCurso.Items.Count > 1 Then
            tlbNuevo.Enabled = True
        Else
            tlbNuevo.Enabled = False
        End If

        If dgvListadoCursosMatriculados.RowCount > 0 Then
            tlbEditar.Enabled = True
            tlbBorrar.Enabled = True
        Else
            tlbEditar.Enabled = False
            tlbBorrar.Enabled = False
        End If

    End Sub

    Private Sub DesHabilitarBotonesOperacionBarra()
        tlbNuevo.Enabled = False
        tlbEditar.Enabled = False
        tlbBorrar.Enabled = False

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
    Private Function GuardarValoresEntidad() As EntidadMatricula
        Dim matricula As EntidadMatricula

        matricula = New EntidadMatricula()

        matricula.CodigoMatricula = CStr(lblCodigoMatriculaText.Text)
        matricula.NifAlumno = CStr(cboNifAlumno.SelectedValue)
        matricula.CodigoCurso = CStr(cboAsignarCurso.SelectedValue)

        If chkPagado.Checked Then
            matricula.Pagado = CChar("S")
        Else
            matricula.Pagado = CChar("N")
        End If

        Return matricula

    End Function
    Private Function CargarValoresControlesEnEntidad() As EntidadMatricula
        Try
            'Guardo en la entidad los valores de las cajas
            matricula.CodigoCurso = CStr(cboAsignarCurso.SelectedValue)
            matricula.NifAlumno = CStr(cboNifAlumno.SelectedValue)
            matricula.CodigoMatricula = CStr(lblCodigoMatriculaText.Text)
            If chkPagado.CheckState = CheckState.Checked Then
                matricula.Pagado = CChar("S")
            Else
                matricula.Pagado = CChar("N")
            End If
            Return matricula
        Catch ex As Exception
            MsgBox("Se ha producido la siguiente excepción: " + vbCrLf + _
                    ex.Message, CType(MsgBoxStyle.OkOnly + MsgBoxStyle.Critical, MsgBoxStyle), "Error...")
            Return Nothing
        End Try
    End Function

    Private Sub CargarValoresDatagridEnControles(ByVal dgv As DataGridView)
        Try
            lblCodigoMatriculaText.Text = CStr(dgv.CurrentRow.Cells("clnCodigoMatricula").Value)

            If CChar(dgv.CurrentRow.Cells("clnPagado").Value) = "S" Then
                chkPagado.Checked = True
            Else
                chkPagado.Checked = False
            End If
        Catch ex As Exception
            MsgBox("Se ha producido la siguiente excepción: " + vbCrLf + _
                    ex.Message, CType(MsgBoxStyle.OkOnly + MsgBoxStyle.Critical, MsgBoxStyle), "Error...")
        End Try

    End Sub

    Private Sub CargarAlumnosCombo()
        Try
            Dim dtCursos As DataTable

            dtCursos = PersonasBO.CargarTodosEnDataTable("ALM")

            ' Añadimos una nueva fila al objeto DataTable
            Dim row As DataRow = dtCursos.NewRow

            ' Establecemos el valor del campo Nombre
            row("INFO") = "<Seleccionar>"
            row("NIF") = "SELE"

            ' Insertamos la fila en la primera posición
            dtCursos.Rows.InsertAt(row, 0)

            cboNifAlumno.DisplayMember = "INFO"
            cboNifAlumno.ValueMember = "NIF"
            cboNifAlumno.DataSource = dtCursos
        Catch ex As Exception
            MsgBox("Se ha producido la siguiente excepción: " + vbCrLf + _
                    ex.Message, CType(MsgBoxStyle.OkOnly + MsgBoxStyle.Critical, MsgBoxStyle), "Error...")
        End Try

    End Sub

    Public Sub CargarComboCursos()
        Try
            Dim dtCursos As DataTable = Nothing
            Dim nif As String = String.Empty

            nif = CStr(cboNifAlumno.SelectedValue)
            dtCursos = MatriculasBO.CargarCursosNifNoMatriculadosEnDatatable(nif)

            ' Añadimos una nueva fila al objeto DataTable
            Dim row As DataRow = dtCursos.NewRow

            ' Establecemos el valor del campo Nombre
            row("InfoCurso") = "<Seleccionar>"
            row("CodigoCurso") = "SELE"

            ' Insertamos la fila en la primera posición
            dtCursos.Rows.InsertAt(row, 0)

            cboAsignarCurso.DisplayMember = "InfoCurso"
            cboAsignarCurso.ValueMember = "CodigoCurso"
            cboAsignarCurso.DataSource = dtCursos

        Catch ex As Exception
            MsgBox("Se ha producido la siguiente excepción: " + vbCrLf + _
                    ex.Message, CType(MsgBoxStyle.OkOnly + MsgBoxStyle.Critical, MsgBoxStyle), "Error...")
        End Try
    End Sub
    Private Sub CargarDatagridCursosMatriculados()
        Try
            'Cargo el DataGridView con los cursos Matriculados
            dgvListadoCursosMatriculados.AutoGenerateColumns = False
            dgvListadoCursosMatriculados.DataSource = MatriculasBO.CargarCursosNIFenDataTable(CStr(cboNifAlumno.SelectedValue))
            dgvListadoCursosMatriculados.ClearSelection()
            If dgvListadoCursosMatriculados.RowCount > 0 Then
                Call HabilitarDataGridView()
                dgvListadoCursosMatriculados.ReadOnly = True
            Else
                Call DesHabilitarDataGridView()
            End If
        Catch ex As Exception
            MsgBox("Se ha producido la siguiente excepción: " + vbCrLf + _
                    ex.Message, CType(MsgBoxStyle.OkOnly + MsgBoxStyle.Critical, MsgBoxStyle), "Error...")
        End Try
    End Sub

    Private Sub EstadoInicialFormulario()
        Try
            'Cargo el Combo de Alumnos
            Call CargarAlumnosCombo()

            If FormularioInvocado Then
                cboNifAlumno.Enabled = False
                cboNifAlumno.SelectedValue = nif
                Call DesHabilitarBotonesOperacionBarra()
                If cboAsignarCurso.Items.Count > 1 Then
                    tlbNuevo.Enabled = True
                Else
                    tlbNuevo.Enabled = False
                End If
            Else
                cboNifAlumno.Enabled = True
                cboAsignarCurso.DataSource = Nothing
                dgvListadoCursosMatriculados.DataSource = Nothing
                'Deshabilito y borro los controles

                Call BorrarPagadoyCodMatricula()
                Call DesHabilitaryOcultarPagado()

                'Muestro/Oculto botones del Menu
                Call DesHabilitarBotonesOperacionBarra()
            End If

            cboAsignarCurso.Enabled = False
            Call OcultarBotonesGuardar()

        Catch ex As Exception
            MsgBox("Se ha producido la siguiente excepción: " + vbCrLf + _
                    ex.Message, CType(MsgBoxStyle.OkOnly + MsgBoxStyle.Critical, MsgBoxStyle), "Error...")
        End Try
    End Sub

    Private Sub frmMatriculacion_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call EstiloDataGrid(dgvListadoCursosMatriculados)
        Call EstadoInicialFormulario()

    End Sub

    Private Sub cboNifAlumno_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboNifAlumno.SelectedIndexChanged
        Try
            If CStr(cboNifAlumno.SelectedValue) <> "SELE" Then
                Call CargarComboCursos()
                Call CargarDatagridCursosMatriculados()
                If FormularioInvocado Then
                    Call DesHabilitarBotonesOperacionBarra()

                    tlbNuevo.Enabled = True
                Else
                    Call HabilitarBotonesOperacionBarra()
                End If

            Else
                Call EstadoInicialFormulario()
            End If

            Call BorrarPagadoyCodMatricula()
        Catch ex As Exception
            MsgBox("Se ha producido la siguiente excepción: " + vbCrLf + _
                    ex.Message, CType(MsgBoxStyle.OkOnly + MsgBoxStyle.Critical, MsgBoxStyle), "Error...")
        End Try
    End Sub
    Private Sub tlbNuevo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tlbNuevo.Click
        Try
            Dim numcursos As Integer
            Dim codigomatricula As String
            Dim nif As String


            'Borro y habilito las cajas
            Call BorrarPagadoyCodMatricula()
            Call HabilitaryMostrarPagado()

            nif = CStr(cboNifAlumno.SelectedValue)

            'Compongo la cadena codigomatricula
            numcursos = MatriculasBO.ObtenerNumeroCursosMatriculados(nif)
            numcursos += 1
            codigomatricula = nif & String.Format(String.Format("{0:000}", numcursos))
            lblCodigoMatriculaText.Text = codigomatricula

            cboNifAlumno.Enabled = False
            cboAsignarCurso.Enabled = True

            'Quito la seleccion del Grid y lo deshabilito
            dgvListadoCursosMatriculados.ClearSelection()
            Call DesHabilitarDataGridView()

            'Muestro/Oculto botones del Menu
            Call DesHabilitarBotonesOperacionBarra()
            Call MostrarBotonesGuardar()
            tlbActualizar.Visible = False

            cboAsignarCurso.Text = "<Seleccionar>"

            'Paso el Foco a la primera caja
            cboAsignarCurso.Focus()
        Catch ex As Exception
            MsgBox("Se ha producido la siguiente excepción: " + vbCrLf + _
                    ex.Message, CType(MsgBoxStyle.OkOnly + MsgBoxStyle.Critical, MsgBoxStyle), "Error...")
        End Try
    End Sub
    Private Sub tlbEditar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tlbEditar.Click
        Try
            Dim i As Integer = 0
            'Deshabilito todo excepto el Datagrid
            Call DesHabilitaryOcultarPagado()
            cboNifAlumno.Enabled = False
            cboAsignarCurso.Enabled = False

            Call HabilitarDataGridView()

            dgvListadoCursosMatriculados.ReadOnly = False
            dgvListadoCursosMatriculados.Columns("clnCurso").ReadOnly = True
            dgvListadoCursosMatriculados.Columns("clnFechaInicio").ReadOnly = True
            dgvListadoCursosMatriculados.Columns("clnFechaFin").ReadOnly = True
            dgvListadoCursosMatriculados.Columns("clnPagado").ReadOnly = False

            'Muestro/Oculto botones del Menu
            Call DesHabilitarBotonesOperacionBarra()

            Call MostrarBotonesGuardar()
            tlbGuardar.Visible = False
        Catch ex As Exception
            MsgBox("Se ha producido la siguiente excepción: " + vbCrLf + _
                    ex.Message, CType(MsgBoxStyle.OkOnly + MsgBoxStyle.Critical, MsgBoxStyle), "Error...")
        End Try
    End Sub
    Private Sub tlbGuardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tlbGuardar.Click
        Try
            If Validaciones() Then
                If matricula Is Nothing Then
                    matricula = New EntidadMatricula()
                End If

                'Guardar Valores Entidad
                matricula = GuardarValoresEntidad()

                'Creo la matricula
                Call MatriculasBO.Crear(matricula)


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
    Private Sub tlbActualizar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tlbActualizar.Click
        Try
            Dim i As Integer

            If matricula Is Nothing Then
                matricula = New EntidadMatricula()
            End If

            'Recorro el Datagrid para guardar los valores de pagado
            For i = 0 To dgvListadoCursosMatriculados.RowCount - 1

                'Guardar Valores Entidad
                matricula.CodigoCurso = CStr(dgvListadoCursosMatriculados.Rows(i).Cells("clnCodigoCurso").Value)
                matricula.CodigoMatricula = CStr(dgvListadoCursosMatriculados.Rows(i).Cells("clnCodigoMatricula").Value)
                matricula.NifAlumno = CStr(cboNifAlumno.SelectedValue)
                matricula.Pagado = CChar(dgvListadoCursosMatriculados.Rows(i).Cells("clnPagado").Value)

                'Actualizo la entidad
                Call MatriculasBO.Actualizar(matricula)

            Next
            'Pongo el formulario en su estado inicial
            Call EstadoInicialFormulario()
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

    Private Sub cboAsignarCurso_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboAsignarCurso.SelectedIndexChanged
        'Quito el Check a Pagado
        chkPagado.Checked = False
    End Sub

    Private Sub dgvListadoCursosMatriculados_CellMouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles dgvListadoCursosMatriculados.CellMouseClick
        If e.RowIndex > 0 Then

        End If
    End Sub
    
    Private Sub dgvListadoCursosMatriculados_CurrentCellDirtyStateChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles dgvListadoCursosMatriculados.CurrentCellDirtyStateChanged
        If dgvListadoCursosMatriculados.IsCurrentCellDirty Then
            dgvListadoCursosMatriculados.CommitEdit(DataGridViewDataErrorContexts.Commit)
        End If
    End Sub

  
    Private Sub tlbBorrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tlbBorrar.Click
        Try
            Dim codigo As String = String.Empty

            codigo = CStr(dgvListadoCursosMatriculados.CurrentRow.Cells("clnCodigoMatricula").Value)

            'Compruebo si existen registros en las tablas dependientes, PERSONAS
            If MatriculasBO.ComprobarDependencias(codigo) Then
                MsgBox("Existen dependencias en otras tablas. " + vbCrLf + _
                       "No se puede borrar el registro.", CType(MsgBoxStyle.OkOnly + MsgBoxStyle.Critical, MsgBoxStyle), "Error...")
            Else
                Call MatriculasBO.Borrar(codigo)
                Call EstadoInicialFormulario()

            End If
        Catch ex As Exception
            MsgBox("Se ha producido la siguiente excepción: " + vbCrLf + _
                    ex.Message, CType(MsgBoxStyle.OkOnly + MsgBoxStyle.Critical, MsgBoxStyle), "Error...")
        End Try
    End Sub

    Private Sub tlbBuscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If dgvListadoCursosMatriculados.RowCount > 0 Then
        Else
            MsgBox("No se encontro ninguna coincidencia.", CType(MsgBoxStyle.Information + vbOKOnly, MsgBoxStyle), "Ninguna coincidencia...")
            Return
        End If
    End Sub

End Class