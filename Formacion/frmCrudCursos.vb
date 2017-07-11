Imports Formacion.CapaDeNegocio
Imports Formacion.Entidades
Public Class frmCrudCursos

    Private ModoFormulario As String = String.Empty 'Establece el modo del Formulario ALM para Alumno o PRF para profesor
    Private FormularioInvocado As Boolean = False  'Si esta a true indica que el formulario ha sido llamado
    Private cursos As EntidadCursos = Nothing
    Public Sub New(ByVal codigo As String, ByVal invocado As Boolean)

        ' Llamada necesaria para el diseñador.
        InitializeComponent()

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
        FormularioInvocado = invocado
        txtCodigo.Text = codigo

    End Sub
    Private Function Validaciones() As Boolean
        'El codigo de curso no puede ser vacio
        'La fecha de Fin tiene que ser mayor que la de Inicio
        'El nombre del curso no puede ser vacio
        'El campo numeracion deber ser un numero y no puede ser vacio
        Dim cadena As String = String.Empty
        Dim numerrores As Integer = 0

        If txtCodigo.Text = String.Empty Then
            cadena = "El campo 'Codigo del Curso' no puede ser vacio." + vbCrLf
            txtCodigo.BackColor = Color.Red
            numerrores += 1
        Else
            txtCodigo.BackColor = System.Drawing.ColorTranslator.FromWin32(RGB(64, 64, 64))
        End If

        If dtpFechaFin.Value < dtpFechaInicio.Value Then
            cadena = cadena + "La Fecha de Fin tiene que ser mayor que la Fecha de Inicio" + vbCrLf
            dtpFechaInicio.BackColor = Color.Red
            dtpFechaFin.BackColor = Color.Red
            numerrores += 1
        Else
            dtpFechaInicio.BackColor = System.Drawing.ColorTranslator.FromWin32(RGB(64, 64, 64))
            dtpFechaFin.BackColor = System.Drawing.ColorTranslator.FromWin32(RGB(64, 64, 64))
        End If

        If txtNombreCurso.Text = String.Empty Then
            cadena = cadena + "El campo 'Nombre' no puede ser vacio." + vbCrLf
            txtNombreCurso.BackColor = Color.Red
            numerrores += 1
        Else
            txtNombreCurso.BackColor = System.Drawing.ColorTranslator.FromWin32(RGB(64, 64, 64))
        End If

        If Not IsNumeric(txtDuracion.Text) Or txtDuracion.Text = String.Empty Then
            cadena = cadena + "El campo 'Duracion' tiene que contener números y no puede estar vacío." + vbCrLf
            txtDuracion.BackColor = Color.Red
            numerrores += 1
        Else
            txtDuracion.BackColor = System.Drawing.ColorTranslator.FromWin32(RGB(64, 64, 64))
        End If

   

        If numerrores = 0 Then
            txtCodigo.BackColor = System.Drawing.ColorTranslator.FromWin32(RGB(64, 64, 64))
            txtNombreCurso.BackColor = System.Drawing.ColorTranslator.FromWin32(RGB(64, 64, 64))
            txtDuracion.BackColor = System.Drawing.ColorTranslator.FromWin32(RGB(64, 64, 64))
            dtpFechaInicio.BackColor = System.Drawing.ColorTranslator.FromWin32(RGB(64, 64, 64))
            dtpFechaFin.BackColor = System.Drawing.ColorTranslator.FromWin32(RGB(64, 64, 64))
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
                If txtNombreCurso.BackColor = Color.Red Then
                    txtNombreCurso.Focus()
                Else
                    If txtDuracion.BackColor = Color.Red Then
                        txtDuracion.Focus()
                    Else
                        dtpFechaFin.Focus()
                    End If
                End If
            End If
            Return False
        End If

    End Function
    Private Function GuardarControlesEnEntidad() As EntidadCursos
        Try
            Dim curso As New EntidadCursos

            'Guardo en la entidad los valores de las cajas
            curso.CodigoCurso = CStr(txtCodigo.Text)
            curso.Nombre = CStr(txtNombreCurso.Text)

            If CStr(cboTiposCursos.SelectedValue) = "SELE" Then
                curso.Tipo = Nothing
            Else
                curso.Tipo = CStr(cboTiposCursos.SelectedValue)
            End If

            curso.FechaInicio = Convert.ToDateTime(dtpFechaInicio.Text)
            curso.FechaFin = Convert.ToDateTime(dtpFechaFin.Text)

            If txtCoste.Text = String.Empty Then
                curso.Coste = Nothing
            Else
                curso.Coste = CDec(txtCoste.Text)
            End If

            If CStr(cboAulas.SelectedValue) = "SELE" Then
                curso.Aula = Nothing
            Else
                curso.Aula = CStr(cboAulas.SelectedValue)
            End If

            curso.Duracion = Convert.ToInt32(txtDuracion.Text)

            If txtObservaciones.Text = String.Empty Then
                curso.Observaciones = Nothing
            Else
                curso.Observaciones = CStr(txtObservaciones.Text)
            End If


            Return curso

        Catch ex As Exception
            MsgBox("Se ha producido la siguiente excepción: " + vbCrLf + _
                    ex.Message, CType(MsgBoxStyle.OkOnly + MsgBoxStyle.Critical, MsgBoxStyle), "Error...")
            Return Nothing
        End Try

    End Function
    Public Function BuscarCodigo(ByVal codigo As String, ByVal dgv As DataGridView) As Boolean
        Try
            Dim encontrado As Boolean = False

            encontrado = BuscarEnDataGrid(codigo, "clnCodigoCurso", dgv)

            If encontrado Then
                'DesHabilito las cajas
                Call DesHabilitarCajasTexto()

                Call HabilitarBotonesOperacionBarra()
                dgv.Enabled = True

                btnBuscarCodigo.Visible = False

                'Copio los valores en las cajas
                Call CargarValoresDatagridEnControles(dgv)

            End If

            Return encontrado

        Catch ex As Exception
            MsgBox("Se ha producido la siguiente excepción: " + vbCrLf + _
                    ex.Message, CType(MsgBoxStyle.OkOnly + MsgBoxStyle.Critical, MsgBoxStyle), "Error...")
            Return False
        End Try
    End Function
    Public Sub CargarValoresDatagridEnControles(ByVal dgv As DataGridView)
        Try
            Dim n As Decimal

            txtCodigo.Text = CStr(dgv.CurrentRow.Cells("clnCodigoCurso").Value)
            dtpFechaInicio.Text = CStr(dgv.CurrentRow.Cells("clnFechaInicioCurso").Value)
            dtpFechaFin.Text = CStr(dgv.CurrentRow.Cells("clnFechaFinCurso").Value)

            Decimal.TryParse(dgv.CurrentRow.Cells("clnCosteCurso").Value.ToString, n)
            txtCoste.Text = String.Format("{0:C2}", n)


            If dgv.CurrentRow.Cells("clnCodigoAula").Value Is Nothing Then
                cboAulas.SelectedValue = "SELE"
            Else
                cboAulas.SelectedValue = CStr(dgv.CurrentRow.Cells("clnCodigoAula").Value)
            End If

            txtNombreCurso.Text = CStr(dgv.CurrentRow.Cells("clnNombreCurso").Value)

            If dgv.CurrentRow.Cells("clnCodigoTipoCurso").Value Is Nothing Then
                cboTiposCursos.SelectedValue = "SELE"
            Else
                cboTiposCursos.SelectedValue = CStr(dgv.CurrentRow.Cells("clnCodigoTipoCurso").Value)
            End If

            txtDuracion.Text = CStr(dgv.CurrentRow.Cells("clnDuracionCurso").Value)
            txtObservaciones.Text = CStr(dgv.CurrentRow.Cells("clnObservaciones").Value)

            'Cargo Listview de Profesores y alumnos
            Call CargarListview(CStr(dgv.CurrentRow.Cells("clnCodigoCurso").Value))

        Catch ex As Exception
            MsgBox("Se ha producido la siguiente excepción: " + vbCrLf + _
                    ex.Message, CType(MsgBoxStyle.OkOnly + MsgBoxStyle.Critical, MsgBoxStyle), "Error...")
        End Try

    End Sub
    Private Sub BorrarListView()
        lstAlumnos.SelectionMode = SelectionMode.One
        lstProfesores.SelectionMode = SelectionMode.One
        'Borro los Listview
        lstAlumnos.DataSource = Nothing
        lstProfesores.DataSource = Nothing
        lstAlumnos.SelectionMode = SelectionMode.None
        lstProfesores.SelectionMode = SelectionMode.None
    End Sub
    Private Sub BorrarCajasTexto()
        txtCodigo.Text = String.Empty
        dtpFechaInicio.Text = String.Empty
        dtpFechaFin.Text = String.Empty
        txtCoste.Text = String.Empty
        txtNombreCurso.Text = String.Empty
        txtDuracion.Text = String.Empty
        txtObservaciones.Text = String.Empty

    End Sub

    Private Sub HabilitarCajasTexto()
        txtCodigo.Enabled = True
        dtpFechaInicio.Enabled = True
        dtpFechaFin.Enabled = True
        txtCoste.Enabled = True
        txtNombreCurso.Enabled = True
        txtDuracion.Enabled = True
        txtObservaciones.Enabled = True

        txtCodigo.BackColor = Me.BackColor
        dtpFechaInicio.BackColor = Me.BackColor
        dtpFechaFin.BackColor = Me.BackColor
        txtCoste.BackColor = Me.BackColor
        txtNombreCurso.BackColor = Me.BackColor
        txtDuracion.BackColor = Me.BackColor
        txtObservaciones.BackColor = Me.BackColor

    End Sub


    Private Sub DesHabilitarCajasTexto()
        txtCodigo.Enabled = False
        dtpFechaInicio.Enabled = False
        dtpFechaFin.Enabled = False
        txtCoste.Enabled = False
        txtNombreCurso.Enabled = False
        txtDuracion.Enabled = False
        txtObservaciones.Enabled = False

        txtCodigo.BackColor = Color.LightGray
        dtpFechaInicio.BackColor = Color.LightGray
        dtpFechaFin.BackColor = Color.LightGray
        txtCoste.BackColor = Color.LightGray
        txtNombreCurso.BackColor = Color.LightGray
        txtDuracion.BackColor = Color.LightGray
        txtObservaciones.BackColor = Color.LightGray
    End Sub

    Private Sub HabilitarCombos()
        cboAulas.Enabled = True
        cboTiposCursos.Enabled = True

        cboAulas.BackColor = Me.BackColor
        cboTiposCursos.BackColor = Me.BackColor
    End Sub
    Private Sub DesHabilitarCombos()
        cboAulas.Enabled = False
        cboTiposCursos.Enabled = False

        cboAulas.BackColor = Color.LightGray
        cboTiposCursos.BackColor = Color.LightGray
    End Sub
    Private Sub HabilitarBotonesListView()
        btnSeleccionarAlumnos.Enabled = True
        btnSeleccionarProfesores.Enabled = True
    End Sub

    Private Sub DeshabilitarBotonesListView()
        btnSeleccionarAlumnos.Enabled = False
        btnSeleccionarProfesores.Enabled = False
    End Sub

    Private Sub HabilitarBotonesFormularios()
        btnAsistencia.Enabled = True
        btnCalificaciones.Enabled = True
    End Sub
    Private Sub DesHabilitarBotonesFormularios()
        btnAsistencia.Enabled = False
        btnCalificaciones.Enabled = False
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

    Private Sub CargarComboAulas()
        Try
            Dim dtAulas As DataTable
            'Cargo el ComboBox de Aulas
            dtAulas = AulasBO.CargarAulasDatatable

            ' Añadimos una nueva fila al objeto DataTable
            Dim row As DataRow = dtAulas.NewRow

            ' Establecemos el valor del campo Nombre
            row("CodigoyNombre") = "<Seleccionar>"

            ' Establecemos el valor de otro Campo
            row("Codigo") = "SELE"

            ' Insertamos la fila en la primera posición
            dtAulas.Rows.InsertAt(row, 0)

            cboAulas.ValueMember = "Codigo"
            cboAulas.DisplayMember = "CodigoyNombre"
            cboAulas.DataSource = dtAulas

            cboAulas.SelectedValue = "SELE"
        Catch ex As Exception
            MsgBox("Se ha producido la siguiente excepción: " + vbCrLf + _
                    ex.Message, CType(MsgBoxStyle.OkOnly + MsgBoxStyle.Critical, MsgBoxStyle), "Error...")
        End Try
    End Sub

    Private Sub CargarComboTiposCursos()
        Try
            Dim dtTiposCursos As DataTable
            'Cargo el ComboBox de Aulas
            dtTiposCursos = TiposCursosBO.CargarCodigoTipoDatatable

            ' Añadimos una nueva fila al objeto DataTable
            Dim row As DataRow = dtTiposCursos.NewRow

            ' Establecemos el valor del campo Nombre
            row("CodigoyTipo") = "<Seleccionar>"

            ' Establecemos el valor de otro Campo
            row("Codigo") = "SELE"

            ' Insertamos la fila en la primera posición
            dtTiposCursos.Rows.InsertAt(row, 0)

            cboTiposCursos.ValueMember = "Codigo"
            cboTiposCursos.DisplayMember = "CodigoyTipo"
            cboTiposCursos.DataSource = dtTiposCursos

            cboTiposCursos.SelectedValue = "SELE"

        Catch ex As Exception
            MsgBox("Se ha producido la siguiente excepción: " + vbCrLf + _
                    ex.Message, CType(MsgBoxStyle.OkOnly + MsgBoxStyle.Critical, MsgBoxStyle), "Error...")
        End Try
    End Sub
    Private Sub CargarListview(ByVal CodigoCurso As String)
        Try

            lstAlumnos.SelectionMode = SelectionMode.One
            lstProfesores.SelectionMode = SelectionMode.One

            Call BorrarListView()

            Dim dtPrincipal As DataTable

            'Cargo en el Datatable los profesores y los alumnos del curso
            dtPrincipal = PersonasBO.CargarPersonasCursoEnDatatable(CodigoCurso)

            ''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
            'Cargo el ListBox de Profesores
            ''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
            Dim rows() As DataRow = dtPrincipal.Select("Rol = 'PRF'")

            ' Clonamos la estructura del objeto DataTable principal
            '
            Dim dtProfesores As DataTable = dtPrincipal.Clone()

            ' Importamos los registros al nuevo DataTable
            '
            For Each row As DataRow In rows
                dtProfesores.ImportRow(row)
            Next

            lstProfesores.DisplayMember = "Info"
            lstProfesores.ValueMember = "Nif"
            lstProfesores.DataSource = dtProfesores
            lstProfesores.ClearSelected()

            ''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''

            ''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
            'Cargo el ListBox de Alumnos
            ''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
            rows = dtPrincipal.Select("Rol = 'ALM'")

            ' Clonamos la estructura del objeto DataTable principal
            '
            Dim dtAlumnos As DataTable = dtPrincipal.Clone()

            ' Importamos los registros al nuevo DataTable
            '
            For Each row As DataRow In rows
                dtAlumnos.ImportRow(row)
            Next

            lstAlumnos.DisplayMember = "Info"
            lstAlumnos.ValueMember = "Nif"
            lstAlumnos.DataSource = dtAlumnos
            lstAlumnos.ClearSelected()

            ''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
            lstAlumnos.SelectionMode = SelectionMode.None
            lstProfesores.SelectionMode = SelectionMode.None
        Catch ex As Exception
            MsgBox("Se ha producido la siguiente excepción: " + vbCrLf + _
                    ex.Message, CType(MsgBoxStyle.OkOnly + MsgBoxStyle.Critical, MsgBoxStyle), "Error...")
        End Try
    End Sub

    Private Sub EstadoInicialFormulario()
        Try
            'Cargo el DatagridView
            dgvListadoCursos.AutoGenerateColumns = False
            dgvListadoCursos.DataSource = CursosBO.CargarTodos
            dgvListadoCursos.ClearSelection()
            dgvListadoCursos.Enabled = True

            'Cargar Combo Aulas
            Call CargarComboAulas()

            'Cargo Combo Tipos Cursos
            Call CargarComboTiposCursos()

            Call DesHabilitarCombos()
            Call DesHabilitarBotonesFormularios()

            If Not FormularioInvocado Then
                'Deshabilito Cajas de Texto
                Call BorrarCajasTexto()
            End If

            Call DesHabilitarCajasTexto()

            Call OcultarBotonesGuardar()

            'Oculto el boton de Buscar Codigo Postal
            btnBuscarCodigo.Visible = False

            'Deshabilitar Listview y sus botones
            Call DeshabilitarBotonesListView()

            'Limpio Listview
            Call BorrarListView()
            If FormularioInvocado Then
                Call BuscarCodigo(txtCodigo.Text, dgvListadoCursos)
                Call DesHabilitarBotonesOperacionBarra()
                tlbEditar.Enabled = True

                ' Call DesHabilitarBotonesFormularios()
                dgvListadoCursos.Enabled = False
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

    Private Sub frmCrudCursos_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        dtpFechaInicio.Format = DateTimePickerFormat.Custom
        dtpFechaInicio.CustomFormat = ("dd - MM - yyyy, HH:mm")
        dtpFechaInicio.Value = Now

        dtpFechaFin.Format = DateTimePickerFormat.Custom
        dtpFechaFin.CustomFormat = ("dd - MM - yyyy, HH:mm")
        dtpFechaFin.Value = Now

        Call EstiloDataGrid(dgvListadoCursos)
        Call EstadoInicialFormulario()

    End Sub

    Private Sub dgvListadoAulas_CellMouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles dgvListadoCursos.CellMouseClick
        Try
            If e.RowIndex >= 0 Then

                CargarValoresDatagridEnControles(dgvListadoCursos)

                'Muestro/Oculto botones del Menu
                Call HabilitarBotonesOperacionBarra()
                Call OcultarBotonesGuardar()

                Call HabilitarBotonesFormularios()
            End If
        Catch ex As Exception
            MsgBox("Se ha producido la siguiente excepción: " + vbCrLf + _
                    ex.Message, CType(MsgBoxStyle.OkOnly + MsgBoxStyle.Critical, MsgBoxStyle), "Error...")
        End Try
    End Sub

    Private Sub tlbNuevo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tlbNuevo.Click

        'Borro y habilito las cajas y los combos
        Call BorrarCajasTexto()
        Call BorrarListView()

        Call HabilitarCajasTexto()
        Call HabilitarCombos()
        Call DesHabilitarBotonesFormularios()

        'Quito la seleccion del Grid de Listado de Aulas y lo deshabilito
        dgvListadoCursos.ClearSelection()
        dgvListadoCursos.Enabled = False

        'Muestro/Oculto botones del Menu
        Call DesHabilitarBotonesOperacionBarra()
        Call MostrarBotonesGuardar()
        tlbActualizar.Visible = False

        cboAulas.SelectedValue = "SELE"
        cboTiposCursos.SelectedValue = "SELE"

        'Paso el Foco a la primera caja
        txtCodigo.Focus()

    End Sub
    Private Sub tlbEditar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tlbEditar.Click
        'Preparo las cajas
        Call HabilitarCajasTexto()
        txtCodigo.Enabled = False

        Call HabilitarCombos()
        Call DesHabilitarBotonesFormularios()

        'Habilito los Listview
        Call HabilitarBotonesListView()

        'Deshabilito el Grid de listado de cursos por aulas
        dgvListadoCursos.Enabled = False

        'Muestro/Oculto botones del Menu
        Call DesHabilitarBotonesOperacionBarra()
        Call MostrarBotonesGuardar()
        tlbGuardar.Visible = False

    End Sub
    Private Sub tlbBuscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tlbBuscar.Click
        If dgvListadoCursos.RowCount > 0 Then
            'Preparo las cajas
            Call DesHabilitarCajasTexto()
            Call BorrarCajasTexto()

            txtCodigo.Enabled = True
            txtCodigo.BackColor = Me.BackColor
            txtCodigo.Focus()

            'Deshabilito los combos
            Call DesHabilitarCombos()
            Call DesHabilitarBotonesFormularios()

            'Muestro/Oculto botones del Menu
            Call DesHabilitarBotonesOperacionBarra()
            Call OcultarBotonesGuardar()

            btnBuscarCodigo.Visible = True
        Else
            MsgBox("No existen registros que buscar.", CType(MsgBoxStyle.Exclamation + vbOKOnly, MsgBoxStyle), "No existen registros...")
            Call EstadoInicialFormulario()
        End If
    End Sub


    Private Sub tlbGuardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tlbGuardar.Click
        Try
            If Validaciones() Then
                If cursos Is Nothing Then
                    cursos = New EntidadCursos()
                End If

                cursos = GuardarControlesEnEntidad()

                CursosBO.Guardar(cursos)

                If FormularioInvocado Then
                    Me.Close()
                Else
                    Call EstadoInicialFormulario()
                End If
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
                If cursos Is Nothing Then
                    cursos = New EntidadCursos()
                End If

                cursos = GuardarControlesEnEntidad()

                CursosBO.Actualizar(cursos)

                'Si el formulario esta invocado lo cierro
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

    Private Sub btnSeleccionarAlumnos_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSeleccionarAlumnos.Click
        Dim VarFrmSeleccionPersonasCurso As New frmSeleccionPersonasCurso

        VarFrmSeleccionPersonasCurso.CodigoCurso = txtCodigo.Text
        VarFrmSeleccionPersonasCurso.rol = "ALM"
        VarFrmSeleccionPersonasCurso.Text = "SELECCION DE ALUMNOS PARA EL CURSO"
        VarFrmSeleccionPersonasCurso.NombreCurso = txtNombreCurso.Text
        VarFrmSeleccionPersonasCurso.ShowDialog()

        'Cargo Listview de Profesores y alumnos
        Call CargarListview(txtCodigo.Text)

    End Sub


    Private Sub btnSeleccionarProfesores_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSeleccionarProfesores.Click
        Dim VarFrmSeleccionPersonasCurso As New frmSeleccionPersonasCurso

        VarFrmSeleccionPersonasCurso.CodigoCurso = txtCodigo.Text
        VarFrmSeleccionPersonasCurso.rol = "PRF"
        VarFrmSeleccionPersonasCurso.Text = "SELECCION DE PROFESORES PARA EL CURSO"
        VarFrmSeleccionPersonasCurso.NombreCurso = txtNombreCurso.Text
        VarFrmSeleccionPersonasCurso.ShowDialog()

        'Cargo Listview de Profesores y alumnos
        Call CargarListview(txtCodigo.Text)
    End Sub

    Private Sub tlbBorrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tlbBorrar.Click
        Dim codigo As String

        codigo = txtCodigo.Text

        If CursosBO.ComprobarDependencias(codigo) Then
            MsgBox("Existen dependencias en otras tablas. " + vbCrLf + _
                   "No se puede borrar el registro.", CType(MsgBoxStyle.OkOnly + MsgBoxStyle.Critical, MsgBoxStyle), "Error...")
        Else
            Call CursosBO.Borrar(codigo)
            Call EstadoInicialFormulario()
        End If

    End Sub

    Private Sub btnBuscarCodigo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBuscarCodigo.Click
        Try

            Dim encontrado As Boolean = False
            encontrado = BuscarCodigo(txtCodigo.Text, dgvListadoCursos)
            If Not encontrado Then
                MsgBox("No se encontro ninguna coincidencia.", CType(MsgBoxStyle.Information + vbOKOnly, MsgBoxStyle), "Ninguna coincidencia...")
                txtCodigo.Focus()
            End If

        Catch ex As Exception
            MsgBox("Se ha producido la siguiente excepción: " + vbCrLf + _
                    ex.Message, CType(MsgBoxStyle.OkOnly + MsgBoxStyle.Critical, MsgBoxStyle), "Error...")
        End Try
    End Sub

    Private Sub txtCoste_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtCoste.Leave
        Dim n As Decimal

        Decimal.TryParse(txtCoste.Text, n)

        txtCoste.Text = String.Format("{0:C2}", n)

    End Sub
    Private Sub btnCalificaciones_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCalificaciones.Click
        Try
            Dim nif As String = String.Empty
            Dim curso As String = txtCodigo.Text
            Using VarFrmCalificaciones As New frmCrudCalificaciones(curso, nif, "PRF", True)
                VarFrmCalificaciones.ShowDialog()
            End Using
        Catch ex As Exception
            MsgBox("Se ha producido la siguiente excepción: " + vbCrLf + _
                    ex.Message, CType(MsgBoxStyle.OkOnly + MsgBoxStyle.Critical, MsgBoxStyle), "Error...")
        End Try
    End Sub

    Private Sub btnAsistencia_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAsistencia.Click
        Dim curso As String = txtCodigo.Text
        Using VarFrmAsistenciasAlumno As New frmAsistenciasAlumno(curso, True)
            VarFrmAsistenciasAlumno.ShowDialog()
        End Using
    End Sub

    
    Private Sub dgvListadoCursos_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvListadoCursos.CellContentClick

    End Sub
End Class