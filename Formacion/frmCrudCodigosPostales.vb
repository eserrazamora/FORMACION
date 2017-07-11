Imports Formacion.CapaDeNegocio
Imports Formacion.Entidades

Public Class frmCrudCodigosPostales

    Private Function Validaciones() As Boolean
        'El codigo postal no puede ser vacio
        'La provincia no puede ser vacia
        Dim cadena As String = String.Empty
        Dim numerrores As Integer = 0

        If txtCodigoPostal.Text = String.Empty Then
            cadena = "El campo 'Código Postal' no puede ser vacio." + vbCrLf
            txtCodigoPostal.BackColor = Color.Red
            numerrores += 1
        Else
            txtCodigoPostal.BackColor = System.Drawing.ColorTranslator.FromWin32(RGB(64, 64, 64))
        End If

        If txtProvincia.Text = String.Empty Then
            cadena = cadena + "El campo 'Provincia' no puede ser vacio." + vbCrLf
            txtProvincia.BackColor = Color.Red
            numerrores += 1
        Else
            txtProvincia.BackColor = System.Drawing.ColorTranslator.FromWin32(RGB(64, 64, 64))
        End If

        If numerrores = 0 Then
            txtCodigoPostal.BackColor = System.Drawing.ColorTranslator.FromWin32(RGB(64, 64, 64))
            txtProvincia.BackColor = System.Drawing.ColorTranslator.FromWin32(RGB(64, 64, 64))
            Return True
        Else
            If numerrores = 1 Then
                cadena = cadena + "Debe corregir este error antes de continuar."
            Else
                cadena = cadena + "Debe corregir estos errores antes de continuar."
            End If
            MsgBox(cadena, CType(MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, MsgBoxStyle), "Fallo en las validaciones...")

            'Paso el foco al primer error
            If txtCodigoPostal.BackColor = Color.Red Then
                txtCodigoPostal.Focus()
            Else
                txtProvincia.Focus()
            End If
            Return False
        End If

    End Function
    Private Sub HabilitarCajasTexto()
        txtCodigoPostal.Enabled = True
        txtLocalidad.Enabled = True
        txtProvincia.Enabled = True

        txtCodigoPostal.BackColor = Me.BackColor
        txtLocalidad.BackColor = Me.BackColor
        txtProvincia.BackColor = Me.BackColor

    End Sub
    Private Sub DesHabilitarCajasTexto()
        txtCodigoPostal.Enabled = False
        txtLocalidad.Enabled = False
        txtProvincia.Enabled = False

        txtCodigoPostal.BackColor = Color.LightGray
        txtLocalidad.BackColor = Color.LightGray
        txtProvincia.BackColor = Color.LightGray

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
    Private Sub BorrarCajasTexto()
        txtCodigoPostal.Text = String.Empty
        txtLocalidad.Text = String.Empty
        txtProvincia.Text = String.Empty
    End Sub
    Private Function GuardarControlesEnEntidad() As EntidadCodigoPostal
        Dim cp As New EntidadCodigoPostal

        'Guardo en la entidad los valores de las cajas
        cp.CodigoPostal = CStr(txtCodigoPostal.Text)
        cp.Provincia = CStr(txtProvincia.Text)
        If txtLocalidad.Text = String.Empty Then
            cp.Localidad = Nothing
        Else
            cp.Localidad = txtLocalidad.Text
        End If

        Return cp

    End Function
    Private Sub EstadoInicialFormulario()
        Try
            'Cargo el Datagrid
            dgvListadoCodigosPostales.AutoGenerateColumns = False
            dgvListadoCodigosPostales.DataSource = CodigoPostalBO.CargarTodos()
            dgvListadoCodigosPostales.ClearSelection()
            dgvListadoCodigosPostales.Enabled = True

            'Deshabilito Cajas de Texto
            Call BorrarCajasTexto()
            Call DesHabilitarCajasTexto()

            'Muestro/Oculto botones del Menu
            Call DesHabilitarBotonesOperacionBarra()
            tlbNuevo.Enabled = True
            tlbBuscar.Enabled = True

            Call OcultarBotonesGuardar()

            'Oculto el boton de Buscar Codigo Postal
            btnBuscarCodigoPostal.Visible = False
        Catch ex As Exception
            MsgBox("Se ha producido la siguiente excepción: " + vbCrLf + _
                    ex.Message, CType(MsgBoxStyle.OkOnly + MsgBoxStyle.Critical, MsgBoxStyle), "Error...")
        End Try
    End Sub

    Private cp As EntidadCodigoPostal = Nothing

    Private Sub frmCrudCodigosPostales_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call EstadoInicialFormulario()
        Call EstiloDataGrid(dgvListadoCodigosPostales)
    End Sub

    Private Sub dgvListadoCursos_CellMouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles dgvListadoCodigosPostales.CellMouseClick
        Try
            If e.RowIndex >= 0 Then
                txtCodigoPostal.Text = CStr(dgvListadoCodigosPostales.Rows(e.RowIndex).Cells("clnCodigoPostal").Value)
                txtLocalidad.Text = CStr(dgvListadoCodigosPostales.Rows(e.RowIndex).Cells("clnLocalidad").Value)
                txtProvincia.Text = CStr(dgvListadoCodigosPostales.Rows(e.RowIndex).Cells("clnProvincia").Value)

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

        'Borro y habilito las cajas
        Call BorrarCajasTexto()
        Call HabilitarCajasTexto()

        'Quito la seleccion del Grid y lo deshabilito
        dgvListadoCodigosPostales.ClearSelection()
        dgvListadoCodigosPostales.Enabled = False

        'Muestro/Oculto botones del Menu
        Call DesHabilitarBotonesOperacionBarra()
        Call MostrarBotonesGuardar()
        tlbActualizar.Visible = False

        'Paso el Foco a la primera caja
        txtCodigoPostal.Focus()

    End Sub

    Private Sub tlbEditar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tlbEditar.Click
        'Preparo las cajas
        Call HabilitarCajasTexto()
        txtCodigoPostal.Enabled = False

        'Deshabilito el Grid
        dgvListadoCodigosPostales.Enabled = False

        'Muestro/Oculto botones del Menu
        Call DesHabilitarBotonesOperacionBarra()
        Call MostrarBotonesGuardar()
        tlbGuardar.Visible = False

    End Sub

    Private Sub tlbBuscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tlbBuscar.Click
        If dgvListadoCodigosPostales.RowCount > 0 Then
            'Preparo las cajas
            Call DesHabilitarCajasTexto()
            Call BorrarCajasTexto()

            txtCodigoPostal.Enabled = True
            txtCodigoPostal.BackColor = Me.BackColor
            txtCodigoPostal.Focus()

            'Muestro/Oculto botones del Menu
            Call DesHabilitarBotonesOperacionBarra()
            Call OcultarBotonesGuardar()

            btnBuscarCodigoPostal.Visible = True
        Else
            MsgBox("No existen registros que buscar.", CType(MsgBoxStyle.Exclamation + vbOKOnly, MsgBoxStyle), "No existen registros...")
            Call EstadoInicialFormulario()
        End If
    End Sub

    Private Sub btnBuscarCodigoPostal_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBuscarCodigoPostal.Click
        Try

            Dim encontrado As Boolean = False

            encontrado = BuscarEnDataGrid(txtCodigoPostal.Text, "clnCodigoPostal", dgvListadoCodigosPostales)

            If encontrado Then
                'DesHabilito las cajas
                Call DesHabilitarCajasTexto()

                Call HabilitarBotonesOperacionBarra()
                dgvListadoCodigosPostales.Enabled = True

                btnBuscarCodigoPostal.Visible = False

                'Copio los valores en las cajas
                txtCodigoPostal.Text = CStr(dgvListadoCodigosPostales.CurrentRow.Cells("clnCodigoPostal").Value)
                txtLocalidad.Text = CStr(dgvListadoCodigosPostales.CurrentRow.Cells("clnLocalidad").Value)
                txtProvincia.Text = CStr(dgvListadoCodigosPostales.CurrentRow.Cells("clnProvincia").Value)
            Else
                MsgBox("No se encontro ninguna coincidencia.", CType(MsgBoxStyle.Information + vbOKOnly, MsgBoxStyle), "Ninguna coincidencia...")
                txtCodigoPostal.Focus()
                Return

            End If
         
        Catch ex As Exception
            MsgBox("Se ha producido la siguiente excepción: " + vbCrLf + _
                    ex.Message, CType(MsgBoxStyle.OkOnly + MsgBoxStyle.Critical, MsgBoxStyle), "Error...")
        End Try
    End Sub


    Private Sub tlbGuardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tlbGuardar.Click
        Try
            If Validaciones() Then
                If cp Is Nothing Then
                    cp = New EntidadCodigoPostal()
                End If

                cp = GuardarControlesEnEntidad()

                CodigoPostalBO.Guardar(cp)

                'Pongo el formulario en su estado inicial
                Call EstadoInicialFormulario()
            End If
        Catch ex As Exception
            MsgBox("Se ha producido la siguiente excepción: " + vbCrLf + _
                    ex.Message, CType(MsgBoxStyle.OkOnly + MsgBoxStyle.Critical, MsgBoxStyle), "Error...")
        End Try

    End Sub

    Private Sub tlbCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tlbCancelar.Click
        Call EstadoInicialFormulario()
    End Sub

    Private Sub tlbActualizar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tlbActualizar.Click
        Try
            If cp Is Nothing Then
                cp = New EntidadCodigoPostal()
            End If

            cp = GuardarControlesEnEntidad()

            CodigoPostalBO.Actualizar(cp)

            'Pongo el formulario en su estado inicial
            Call EstadoInicialFormulario()
        Catch ex As Exception
            MsgBox("Se ha producido la siguiente excepción: " + vbCrLf + _
                    ex.Message, CType(MsgBoxStyle.OkOnly + MsgBoxStyle.Critical, MsgBoxStyle), "Error...")
        End Try
    End Sub

    Private Sub tlbBorrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tlbBorrar.Click
        Try
            Dim codigo As String

            codigo = txtCodigoPostal.Text

            'Compruebo si existen registros en las tablas dependientes, PERSONAS
            If CodigoPostalBO.ComprobarDependencias(codigo) Then
                MsgBox("Existen dependencias en otras tablas. " + vbCrLf + _
                       "No se puede borrar el registro.", CType(MsgBoxStyle.OkOnly + MsgBoxStyle.Critical, MsgBoxStyle), "Error...")
            Else
                Call CodigoPostalBO.Borrar(codigo)
                Call EstadoInicialFormulario()

            End If
        Catch ex As Exception
            MsgBox("Se ha producido la siguiente excepción: " + vbCrLf + _
                    ex.Message, CType(MsgBoxStyle.OkOnly + MsgBoxStyle.Critical, MsgBoxStyle), "Error...")
        End Try

    End Sub


End Class