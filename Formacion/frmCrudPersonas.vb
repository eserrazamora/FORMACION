Imports Formacion.CapaDeNegocio
Imports Formacion.Entidades
Imports System.IO
Imports System.Configuration


Public Class frmCrudPersonas
    Private ModoFormulario As String = String.Empty 'Establece el modo del Formulario ALM para Alumno o PRF para profesor
    Private FormularioInvocado As Boolean = False  'Si esta a true indica que el formulario ha sido llamado
    Private persona As EntidadPersona = Nothing
    Dim InformesPath As String = Path.Combine(Application.StartupPath, ConfigurationManager.AppSettings("RutaInformes").ToString())
    Private Function Validaciones() As Boolean
        'El NIF no puede ser vacio
        'Los apellidos no pueden ser vacio
        'El sexo no puede ser vacio
        'El email no puede ser vacio
        'La fecha de alta no puede ser vacia
        'Si hay codigo postal hay que meter la provincia y la localidad
        Dim cadena As String = String.Empty
        Dim numerrores As Integer = 0

        If txtNif.Text = String.Empty Then
            cadena = "El campo 'NIF' no puede ser vacio." + vbCrLf
            txtNif.BackColor = Color.Red
            numerrores += 1
        Else
            txtNif.BackColor = System.Drawing.ColorTranslator.FromWin32(RGB(64, 64, 64))
        End If

        If txtApellidos.Text = String.Empty Then
            cadena = cadena + "El campo 'Apellidos' no puede ser vacio." + vbCrLf
            txtApellidos.BackColor = Color.Red
            numerrores += 1
        Else
            txtApellidos.BackColor = System.Drawing.ColorTranslator.FromWin32(RGB(64, 64, 64))
        End If

        If Not rbtHombre.Checked And Not rbtMujer.Checked Then
            cadena = cadena + "Debe seleccionar el sexo de la persona." + vbCrLf
            rbtHombre.BackColor = Color.Red
            rbtMujer.BackColor = Color.Red
            numerrores += 1
        Else
            rbtHombre.BackColor = System.Drawing.ColorTranslator.FromWin32(RGB(64, 64, 64))
            rbtMujer.BackColor = System.Drawing.ColorTranslator.FromWin32(RGB(64, 64, 64))
        End If

        If txtEmail.Text = String.Empty Then
            cadena = cadena + "El campo 'Email' no puede ser vacio." + vbCrLf
            txtEmail.BackColor = Color.Red
            numerrores += 1
        Else
            txtEmail.BackColor = System.Drawing.ColorTranslator.FromWin32(RGB(64, 64, 64))
        End If

        If Not IsDate(mskFechaAlta.Text) Then
            cadena = cadena + "El campo 'Fecha de Alta' no puede ser vacio." + vbCrLf
            mskFechaAlta.BackColor = Color.Red
            numerrores += 1
        Else
            mskFechaAlta.BackColor = System.Drawing.ColorTranslator.FromWin32(RGB(64, 64, 64))
        End If

        If CStr(cboCodigoPostal.Text) <> "<Seleccionar>" Then
            If txtProvincia.Text = String.Empty Then
                cadena = cadena + "El campo 'Provincia' no puede ser vacio." + vbCrLf
                txtProvincia.BackColor = Color.Red
                numerrores += 1
            Else
                txtProvincia.BackColor = System.Drawing.ColorTranslator.FromWin32(RGB(64, 64, 64))

            End If

            If txtLocalidad.Text = String.Empty Then
                cadena = cadena + "El campo 'Localidad' no puede ser vacio." + vbCrLf
                txtLocalidad.BackColor = Color.Red
                numerrores += 1
            Else
                txtLocalidad.BackColor = System.Drawing.ColorTranslator.FromWin32(RGB(64, 64, 64))
            End If
        End If

        If numerrores = 0 Then
            txtNif.BackColor = System.Drawing.ColorTranslator.FromWin32(RGB(64, 64, 64))
            txtApellidos.BackColor = System.Drawing.ColorTranslator.FromWin32(RGB(64, 64, 64))
            rbtHombre.BackColor = System.Drawing.ColorTranslator.FromWin32(RGB(64, 64, 64))
            rbtMujer.BackColor = System.Drawing.ColorTranslator.FromWin32(RGB(64, 64, 64))
            txtEmail.BackColor = System.Drawing.ColorTranslator.FromWin32(RGB(64, 64, 64))
            mskFechaAlta.BackColor = System.Drawing.ColorTranslator.FromWin32(RGB(64, 64, 64))
            txtProvincia.BackColor = System.Drawing.ColorTranslator.FromWin32(RGB(64, 64, 64))
            txtLocalidad.BackColor = System.Drawing.ColorTranslator.FromWin32(RGB(64, 64, 64))
            Return (True)
        Else
            If numerrores = 1 Then
                cadena = cadena + "Debe corregir este error antes de continuar."
            Else
                cadena = cadena + "Debe corregir estos errores antes de continuar."
            End If
            MsgBox(cadena, CType(MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, MsgBoxStyle), "Fallo en las validaciones...")

            'Paso el foco al primer error
            If txtNif.BackColor = Color.Red Then
                txtNif.Focus()
            Else
                If txtApellidos.BackColor = Color.Red Then
                    txtApellidos.Focus()
                Else
                    If txtEmail.BackColor = Color.Red Then
                        txtEmail.Focus()
                    Else
                        If mskFechaAlta.BackColor = Color.Red Then
                            mskFechaAlta.Focus()
                        Else
                            If txtProvincia.BackColor = Color.Red Then
                                txtProvincia.Focus()
                            Else
                                txtLocalidad.Focus()
                            End If
                        End If
                    End If
                End If
            End If
            Return False
        End If

    End Function
    Public Sub New(ByVal nif As String, ByVal invocado As Boolean)

        ' Llamada necesaria para el diseñador.
        InitializeComponent()

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
        FormularioInvocado = invocado
        txtNif.Text = nif

    End Sub
    Public Function BuscarNif(ByVal nif As String, ByVal dgv As DataGridView) As Boolean
        Dim encontrado As Boolean = False

        encontrado = BuscarEnDataGrid(nif, "clnNif", dgv)

        If encontrado Then
            'DesHabilito las cajas
            Call DesHabilitarCajasTexto()

            Call HabilitarBotonesOperacionBarra()
            dgv.Enabled = True

            btnBuscarNIF.Visible = False

            'Copio los valores en las cajas
            Call CargarValoresDatagridEnControles(dgv)

        End If

        Return encontrado

    End Function
    Public Sub ProcModoFormulario(ByVal modo As String)
        With Me
            If modo = "ALM" Then
                .btnAsistencia.Show()
                lblAsistencia.Show()

                .btnCalificaciones.Show()
                lblCalificaciones.Show()

                .btnMatricularse.Show()
                lblMatricularse.Show()

                .btnCursos.Hide()
                lblCursos.Hide()

                .btnConsultas.Hide()
                lblConsultas.Hide()

                .btnInformes.Hide()
                lblInformes.Hide()

                .cboTipo.Text = "ALUMNO"

                .Text = "MANTENIMIENTO DE ALUMNOS"
                .ModoFormulario = "ALM"
            Else
                If modo = "PRF" Then
                    .btnAsistencia.Hide()
                    lblAsistencia.Hide()

                    .btnCalificaciones.Hide()
                    lblCalificaciones.Hide()

                    .btnMatricularse.Hide()
                    lblMatricularse.Hide()

                    .btnCursos.Show()
                    lblCursos.Show()

                    .btnConsultas.Show()
                    lblConsultas.Show()

                    .btnInformes.Show()
                    lblInformes.Show()

                    Text = "MANTENIMIENTO DE PROFESORES"
                    ModoFormulario = "PRF"

                End If
            End If

        End With
    End Sub

    Private Sub BorrarCajasTexto()
        txtNif.Text = String.Empty
        mskFechaAlta.Text = String.Empty
        mskFechaNacimiento.Text = String.Empty
        txtNombre.Text = String.Empty
        txtApellidos.Text = String.Empty
        txtDireccion.Text = String.Empty
        txtTelefonoFijo.Text = String.Empty
        txtTelefonoMovil.Text = String.Empty
        txtEmail.Text = String.Empty
        txtProvincia.Text = String.Empty
        txtLocalidad.Text = String.Empty
        txtObservaciones.Text = String.Empty

        rbtHombre.Checked = False
        rbtMujer.Checked = False
    End Sub
    Private Sub HabilitarCajasTexto()
        txtNif.Enabled = True
        mskFechaAlta.Enabled = True
        mskFechaNacimiento.Enabled = True
        txtNombre.Enabled = True
        txtApellidos.Enabled = True
        txtDireccion.Enabled = True
        txtTelefonoFijo.Enabled = True
        txtTelefonoMovil.Enabled = True
        txtEmail.Enabled = True
        txtProvincia.Enabled = True
        txtLocalidad.Enabled = True
        txtObservaciones.Enabled = True

        grpSexo.Enabled = True
        rbtHombre.Enabled = True
        rbtMujer.Enabled = True

        txtNif.BackColor = Me.BackColor
        mskFechaAlta.BackColor = Me.BackColor
        mskFechaNacimiento.BackColor = Me.BackColor
        txtNombre.BackColor = Me.BackColor
        txtApellidos.BackColor = Me.BackColor
        txtDireccion.BackColor = Me.BackColor
        txtTelefonoFijo.BackColor = Me.BackColor
        txtTelefonoMovil.BackColor = Me.BackColor
        txtEmail.BackColor = Me.BackColor
        txtProvincia.BackColor = Me.BackColor
        txtLocalidad.BackColor = Me.BackColor
        txtObservaciones.BackColor = Me.BackColor
        rbtHombre.BackColor = Me.BackColor
        rbtMujer.BackColor = Me.BackColor
    End Sub
    Private Sub DesHabilitarCajasTexto()
        txtNif.Enabled = False
        mskFechaAlta.Enabled = False
        mskFechaNacimiento.Enabled = False
        txtNombre.Enabled = False
        txtApellidos.Enabled = False
        txtDireccion.Enabled = False
        txtTelefonoFijo.Enabled = False
        txtTelefonoMovil.Enabled = False
        txtEmail.Enabled = False
        txtProvincia.Enabled = False
        txtLocalidad.Enabled = False
        txtObservaciones.Enabled = False

        rbtHombre.Enabled = False
        rbtMujer.Enabled = False
        grpSexo.ForeColor = Color.Gold

        txtNif.BackColor = Color.LightGray
        mskFechaAlta.BackColor = Color.LightGray
        mskFechaNacimiento.BackColor = Color.LightGray
        txtNombre.BackColor = Color.LightGray
        txtApellidos.BackColor = Color.LightGray
        txtDireccion.BackColor = Color.LightGray
        txtTelefonoFijo.BackColor = Color.LightGray
        txtTelefonoMovil.BackColor = Color.LightGray
        txtEmail.BackColor = Color.LightGray
        txtProvincia.BackColor = Color.LightGray
        txtLocalidad.BackColor = Color.LightGray
        txtObservaciones.BackColor = Color.LightGray
        rbtHombre.BackColor = Color.LightGray
        rbtMujer.BackColor = Color.LightGray
    End Sub
    Private Sub HabilitarCombos()
        'cboTipo.Enabled = True
        cboCodigoPostal.Enabled = True
    End Sub
    Private Sub DeshabilitarCombos()
        'cboTipo.Enabled = False
        cboCodigoPostal.Enabled = False
    End Sub

    Private Sub HabilitarBotonesFormularios()
        btnAsistencia.Enabled = True
        btnCalificaciones.Enabled = True
        btnConsultas.Enabled = True
        btnCursos.Enabled = True
        btnInfoLogin.Enabled = True
        btnInformes.Enabled = True
        btnMatricularse.Enabled = True
    End Sub
    Private Sub DesHabilitarBotonesFormularios()
        btnAsistencia.Enabled = False
        btnCalificaciones.Enabled = False
        btnConsultas.Enabled = False
        btnCursos.Enabled = False
        btnInfoLogin.Enabled = False
        btnInformes.Enabled = False
        btnMatricularse.Enabled = False
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

    Private Sub CargarComboCodigosPostales()
        Try
            Dim dtCodigosPostales As DataTable

            'Cargo el ComboBox de Tipos de Aulas
            dtCodigosPostales = CodigoPostalBO.CargarTodosEnDatatable


            ' Añadimos una nueva fila al objeto DataTable
            Dim row As DataRow = dtCodigosPostales.NewRow

            ' Establecemos el valor a mostrar
            ' row("INFO") = "<Seleccionar>"

            ' Establecemos el valor oculto
            row("CodigoPostal") = "<Seleccionar>"

            ' Insertamos la fila en la primera posición
            dtCodigosPostales.Rows.InsertAt(row, 0)

            'cboCodigoPostal.ValueMember = "CodigoPostal"
            cboCodigoPostal.DisplayMember = "CodigoPostal"
            cboCodigoPostal.DataSource = dtCodigosPostales

            cboCodigoPostal.Text = "<Seleccionar>"
        Catch ex As Exception
            MsgBox("Se ha producido la siguiente excepción: " + vbCrLf + _
                    ex.Message, CType(MsgBoxStyle.OkOnly + MsgBoxStyle.Critical, MsgBoxStyle), "Error...")
        End Try
    End Sub
    Private Sub CargarComboRoles()
        Try
            Dim dtRoles As New DataTable

            dtRoles.Columns.Add("Tipo")
            dtRoles.Columns.Add("Codigo")

            Dim row As DataRow = dtRoles.NewRow
            Dim row2 As DataRow = dtRoles.NewRow
            Dim row3 As DataRow = dtRoles.NewRow

            row("Tipo") = "<Seleccionar>"
            row("Codigo") = "SELE"

            dtRoles.Rows.InsertAt(row, 0)

            row2("Tipo") = "Profesor"
            row2("Codigo") = "PRF"

            dtRoles.Rows.InsertAt(row2, 1)

            row3("Tipo") = "Alumno"
            row3("Codigo") = "ALM"

            dtRoles.Rows.InsertAt(row3, 2)

            cboTipo.ValueMember = "Codigo"
            cboTipo.DisplayMember = "Tipo"

            cboTipo.DataSource = dtRoles

            cboTipo.SelectedValue = "SELE"
        Catch ex As Exception
            MsgBox("Se ha producido la siguiente excepción: " + vbCrLf + _
                    ex.Message, CType(MsgBoxStyle.OkOnly + MsgBoxStyle.Critical, MsgBoxStyle), "Error...")
        End Try

    End Sub

    Private Sub CargarValoresDatagridEnControles(ByVal dgv As DataGridView)
        Try
            txtNif.Text = CStr(dgv.CurrentRow.Cells("clnNif").Value)
            mskFechaAlta.Text = CStr(dgv.CurrentRow.Cells("clnFechaAlta").Value)
            mskFechaNacimiento.Text = CStr(dgv.CurrentRow.Cells("clnFechaNacimiento").Value)
            cboTipo.SelectedValue = CStr(dgv.CurrentRow.Cells("clnRol").Value)
            txtNombre.Text = CStr(dgv.CurrentRow.Cells("clnNombre").Value)
            txtApellidos.Text = CStr(dgv.CurrentRow.Cells("clnApellidos").Value)
            txtDireccion.Text = CStr(dgv.CurrentRow.Cells("clnDireccion").Value)
            txtTelefonoMovil.Text = CStr(dgv.CurrentRow.Cells("clnTelefonoMovil").Value)
            txtTelefonoFijo.Text = CStr(dgv.CurrentRow.Cells("clnTelefonoFijo").Value)

            If CStr(dgv.CurrentRow.Cells("clnSexo").Value) = "H" Then
                rbtHombre.Checked = True
            Else
                rbtMujer.Checked = True
            End If

            txtEmail.Text = CStr(dgv.CurrentRow.Cells("clnEmail").Value)
            If IsNothing(CStr(dgv.CurrentRow.Cells("clnCodigoPostal").Value)) Then
                cboCodigoPostal.Text = "<Seleccionar>"
            Else
                cboCodigoPostal.Text = CStr(dgv.CurrentRow.Cells("clnCodigoPostal").Value)

                Dim rowView As DataRowView = TryCast(cboCodigoPostal.SelectedValue, DataRowView)

                txtProvincia.Text = CStr(rowView("Provincia"))
                txtLocalidad.Text = CStr(rowView("Localidad"))
            End If
            

            txtObservaciones.Text = CStr(dgv.CurrentRow.Cells("clnObservaciones").Value)
        Catch ex As Exception
            MsgBox("Se ha producido la siguiente excepción: " + vbCrLf + _
                    ex.Message, CType(MsgBoxStyle.OkOnly + MsgBoxStyle.Critical, MsgBoxStyle), "Error...")
        End Try

    End Sub
    Private Function CargarValoresControlesEnEntidad() As EntidadPersona
        Try
            Dim entPer As New EntidadPersona

            entPer.Nif = CStr(txtNif.Text)

            If txtNombre.Text <> String.Empty Then
                entPer.Nombre = CStr(txtNombre.Text)
            Else
                entPer.Nombre = Nothing
            End If

            If txtApellidos.Text <> String.Empty Then
                entPer.Apellidos = CStr(txtApellidos.Text)
            Else
                entPer.Apellidos = Nothing
            End If

            If rbtHombre.Checked Then
                entPer.Sexo = CChar("H")
            Else
                If rbtMujer.Checked Then
                    entPer.Sexo = CChar("M")
                End If
            End If


            If IsDate(mskFechaNacimiento.Text) Then
                entPer.FechaNacimiento = Convert.ToDateTime(mskFechaNacimiento.Text)
            Else
                entPer.FechaNacimiento = Nothing
            End If

            If txtDireccion.Text <> String.Empty Then
                entPer.Direccion = CStr(txtDireccion.Text)
            Else
                entPer.Direccion = Nothing
            End If


            If cboCodigoPostal.Text <> "<Seleccionar>" Then
                entPer.Codigopostal = CStr(cboCodigoPostal.Text)
            Else
                entPer.Codigopostal = Nothing
            End If


            entPer.Email = CStr(txtEmail.Text)



            If txtTelefonoFijo.Text <> String.Empty Then
                entPer.TelefonoFijo = CStr(txtTelefonoFijo.Text)
            Else
                entPer.TelefonoFijo = Nothing
            End If

            If txtTelefonoMovil.Text <> String.Empty Then
                entPer.TelefonoMovil = CStr(txtTelefonoMovil.Text)
            Else
                entPer.TelefonoMovil = Nothing
            End If


            entPer.Rol = CStr(cboTipo.SelectedValue)


            If IsDate(mskFechaAlta.Text) Then
                entPer.FechaAlta = Convert.ToDateTime(mskFechaAlta.Text)
            Else
                entPer.FechaAlta = Nothing
            End If



            entPer.Observaciones = CStr(txtObservaciones.Text)

            Return entPer
        Catch ex As Exception
            MsgBox("Se ha producido la siguiente excepción: " + vbCrLf + _
                    ex.Message, CType(MsgBoxStyle.OkOnly + MsgBoxStyle.Critical, MsgBoxStyle), "Error...")
            Return Nothing
        End Try
    End Function


    Private Sub EstadoInicialFormulario()
        Try
            'Cargo el Datagrid de Personas
            dgvListadoPersonas.AutoGenerateColumns = False
            dgvListadoPersonas.DataSource = PersonasBO.CargarTodos(ModoFormulario)
            dgvListadoPersonas.ClearSelection()
            dgvListadoPersonas.Enabled = True

            'Cargo el Combo de Tipos
            Call CargarComboRoles()

            'Cargo el Combo de Codigos Postales
            Call CargarComboCodigosPostales()

            Call DeshabilitarCombos()

            'Deshabilito Cajas de Texto
            If Not FormularioInvocado Then
                Call BorrarCajasTexto()
            End If

            Call DesHabilitarCajasTexto()

            Call OcultarBotonesGuardar()

            'Oculto el boton de Buscar NIF
            btnBuscarNIF.Visible = False

            If FormularioInvocado Then

                Call BuscarNif(txtNif.Text, dgvListadoPersonas)
                'Preparo los botones para editar
                Call DesHabilitarBotonesOperacionBarra()
                tlbEditar.Enabled = True

                Call DesHabilitarBotonesFormularios()

                dgvListadoPersonas.Enabled = False
            Else
                Call DesHabilitarBotonesFormularios()

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

    Private Sub frmCrudPersonas_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call EstadoInicialFormulario()
        Call EstiloDataGrid(dgvListadoPersonas)
    End Sub

    Private Sub tlbNuevo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tlbNuevo.Click
        'Borro y habilito las cajas
        Call BorrarCajasTexto()
        Call HabilitarCajasTexto()
        Call HabilitarCombos()

        'Quito la seleccion del Grid y lo deshabilito
        dgvListadoPersonas.ClearSelection()
        dgvListadoPersonas.Enabled = False

        'Muestro/Oculto botones del Menu
        Call DesHabilitarBotonesOperacionBarra()
        Call DesHabilitarBotonesFormularios()
        Call MostrarBotonesGuardar()
        tlbActualizar.Visible = False

        cboCodigoPostal.Text = "<Seleccionar>"
        cboTipo.Text = "<Seleccionar>"
        mskFechaAlta.Text = CStr(Today.Date)

        If ModoFormulario = "ALM" Then
            cboTipo.SelectedValue = "ALM"
        Else
            cboTipo.SelectedValue = "PRF"
        End If

        'Paso el Foco a la primera caja
        txtNif.Focus()
    End Sub

    Private Sub tlbEditar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tlbEditar.Click
        'Preparo las cajas
        Call HabilitarCajasTexto()
        txtNif.Enabled = False

        Call HabilitarCombos()


        'Deshabilito el Grid
        dgvListadoPersonas.Enabled = False

        'Muestro/Oculto botones del Menu
        Call DesHabilitarBotonesOperacionBarra()
        Call HabilitarBotonesFormularios()

        Call MostrarBotonesGuardar()
        tlbGuardar.Visible = False

        txtNombre.Focus()
    End Sub

    Private Sub tlbBuscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tlbBuscar.Click
        If dgvListadoPersonas.RowCount > 0 Then
            'Preparo las cajase
            Call DesHabilitarCajasTexto()
            Call BorrarCajasTexto()

            txtNif.Enabled = True
            txtNif.BackColor = Me.BackColor
            txtNif.Focus()

            'Muestro/Oculto botones del Menu
            Call DesHabilitarBotonesOperacionBarra()
            Call DesHabilitarBotonesFormularios()
            Call OcultarBotonesGuardar()

            btnBuscarNIF.Visible = True
        Else
            MsgBox("No existen registros que buscar.", CType(MsgBoxStyle.Exclamation + vbOKOnly, MsgBoxStyle), "No existen registros...")
            Call EstadoInicialFormulario()
        End If
    End Sub
    Private Sub btnBuscarNif_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBuscarNIF.Click

        Try

            Dim encontrado As Boolean = False
            encontrado = BuscarNif(txtNif.Text, dgvListadoPersonas)
            If Not encontrado Then
                MsgBox("No se encontro ninguna coincidencia.", CType(MsgBoxStyle.Information + vbOKOnly, MsgBoxStyle), "Ninguna coincidencia...")
                txtNif.Focus()
            End If

        Catch ex As Exception
            MsgBox("Se ha producido la siguiente excepción: " + vbCrLf + _
                    ex.Message, CType(MsgBoxStyle.OkOnly + MsgBoxStyle.Critical, MsgBoxStyle), "Error...")
        End Try
    End Sub

    Private Sub tlbGuardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tlbGuardar.Click
        Try
            If Validaciones() Then
                If persona Is Nothing Then
                    persona = New EntidadPersona()
                End If

                'Guardon en la entidad los valores de las cajas
                persona = CargarValoresControlesEnEntidad()

                PersonasBO.Guardar(persona)

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
                If persona Is Nothing Then
                    persona = New EntidadPersona()
                End If

                'Guardon en la entidad los valores de las cajas
                persona = CargarValoresControlesEnEntidad()

                PersonasBO.Guardar(persona)

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

    Private Sub btnMatricularse_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnMatricularse.Click
        Dim nif As String = txtNif.Text

        If nif <> String.Empty Then
            Dim VarFrmMatriculacion As New frmMatriculacion(txtNif.Text, True)
            VarFrmMatriculacion.ShowDialog()
        Else
            MsgBox("Debe introducir un NIF.", CType(MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, MsgBoxStyle), "Debe introducir un NIF...")
        End If
        

    End Sub

    Private Sub btnCursos_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCursos.Click
        Dim VarFrmConsultaCursos As New frmConsultaCursos

        VarFrmConsultaCursos.ShowDialog()
    End Sub

    Private Sub btnAsistencia_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAsistencia.Click
        Using VarFmAsistenciasAlumno As New frmAsistenciasAlumno(String.Empty, False)
            VarFmAsistenciasAlumno.ShowDialog()
        End Using
    End Sub

    Private Sub btnCalificaciones_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCalificaciones.Click
        Dim nif As String = txtNif.Text

        If nif <> String.Empty Then
            Dim VarFrmCrudCalificaciones As New frmCrudCalificaciones(String.Empty, txtNif.Text, "ALM", True)
            VarFrmCrudCalificaciones.ShowDialog()
        Else
            MsgBox("Debe introducir un NIF.", CType(MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, MsgBoxStyle), "Debe introducir un NIF...")
        End If

    End Sub

    Private Sub btnInfoLogin_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnInfoLogin.Click
        Dim nif As String = txtNif.Text

        If nif <> String.Empty Then
            Dim VarFrmCrudLogin As New frmCrudLogin

            VarFrmCrudLogin.ShowDialog()

        Else
            MsgBox("Debe introducir un NIF.", CType(MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, MsgBoxStyle), "Debe introducir un NIF...")
        End If

    End Sub


    Private Sub dgvListadoPersonas_CellMouseClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles dgvListadoPersonas.CellMouseClick
        If e.RowIndex >= 0 Then

            Call CargarValoresDatagridEnControles(dgvListadoPersonas)

            'Muestro/Oculto botones del Menu
            Call HabilitarBotonesOperacionBarra()
            Call OcultarBotonesGuardar()

        End If
    End Sub

    Private Sub cboCodigoPostal_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles cboCodigoPostal.Leave
        'Si no existe, limpio las cajas
        If Not CodigoPostalBO.Existe(cboCodigoPostal.Text) Then
            txtProvincia.Text = String.Empty
            txtLocalidad.Text = String.Empty
        Else
        
            Dim i As Integer
            Dim codigo As String = cboCodigoPostal.Text

            Dim rowView As DataRowView = Nothing

            'Empiezo en 1 porque el 0 es el seleccionar
            For i = 1 To cboCodigoPostal.Items.Count - 1

                rowView = TryCast(cboCodigoPostal.Items(i), DataRowView)
                If (rowView("CodigoPostal").ToString()) = codigo Then
                    Exit For
                End If

            Next

            If (i <= cboCodigoPostal.Items.Count - 1) Then
                ' Si existe el elemento, lo seleccionamos.
                cboCodigoPostal.SelectedIndex = i
            End If

            rowView = TryCast(cboCodigoPostal.SelectedValue, DataRowView)

            txtProvincia.Text = Convert.ToString(rowView("Provincia"))
            txtLocalidad.Text = Convert.ToString(rowView("Localidad"))
        End If
    End Sub

    Private Sub cboCodigoPostal_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboCodigoPostal.SelectedIndexChanged

        Dim rowView As DataRowView = TryCast(cboCodigoPostal.SelectedValue, DataRowView)

        txtProvincia.Text = Convert.ToString(rowView("Provincia"))
        txtLocalidad.Text = Convert.ToString(rowView("Localidad"))

    End Sub



    Private Sub tlbBorrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tlbBorrar.Click
        Try
            Dim nif As String

            nif = txtNif.Text

            'Compruebo si existen registros en las tablas dependientes, PERSONAS
            If PersonasBO.ComprobarDependencias(nif) Then
                MsgBox("Existen dependencias en otras tablas. " + vbCrLf + _
                       "No se puede borrar el registro.", CType(MsgBoxStyle.OkOnly + MsgBoxStyle.Critical, MsgBoxStyle), "Error...")
            Else
                Call PersonasBO.Borrar(nif)
                Call EstadoInicialFormulario()

            End If
        Catch ex As Exception
            MsgBox("Se ha producido la siguiente excepción: " + vbCrLf + _
                    ex.Message, CType(MsgBoxStyle.OkOnly + MsgBoxStyle.Critical, MsgBoxStyle), "Error...")
        End Try

    End Sub

    Private Sub btnInformes_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnInformes.Click
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

    Private Sub btnConsultas_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnConsultas.Click
        Using VarFrmConsultaProfesores As New frmConsultaProfesores
            VarFrmConsultaProfesores.ShowDialog()
        End Using
    End Sub
End Class