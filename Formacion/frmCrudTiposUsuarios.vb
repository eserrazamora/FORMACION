Imports Formacion.CapaDeNegocio
Imports Formacion.Entidades
Public Class frmCrudTiposUsuarios
    Private Function Validaciones() As Boolean
        Try
            'El Codigo no puede ser vacio
            'El Tipo de Usuario no puede ser vacio

            Dim cadena As String = String.Empty
            Dim numerrores As Integer = 0

            If txtCodigo.Text = String.Empty Then
                cadena = "El campo 'Codigo' no puede ser vacio." + vbCrLf
                txtCodigo.BackColor = Color.Red
                numerrores += 1
            Else
                txtCodigo.BackColor = System.Drawing.ColorTranslator.FromWin32(RGB(64, 64, 64))
            End If

            If txtTipoUsuario.Text = String.Empty Then
                cadena = cadena + "El campo 'Tipo de Usuario' no puede ser vacio." + vbCrLf
                txtTipoUsuario.BackColor = Color.Red
                numerrores += 1
            Else
                txtTipoUsuario.BackColor = System.Drawing.ColorTranslator.FromWin32(RGB(64, 64, 64))
            End If

            If numerrores = 0 Then
                txtCodigo.BackColor = System.Drawing.ColorTranslator.FromWin32(RGB(64, 64, 64))
                txtTipoUsuario.BackColor = System.Drawing.ColorTranslator.FromWin32(RGB(64, 64, 64))
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
                    txtTipoUsuario.Focus()
                End If

                Return False
            End If

        Catch ex As Exception
            MsgBox("Se ha producido la siguiente excepción: " + vbCrLf + _
                    ex.Message, CType(MsgBoxStyle.OkOnly + MsgBoxStyle.Critical, MsgBoxStyle), "Error...")
            Return False
        End Try
    End Function
    Private Sub BorrarCajasTexto()
        txtCodigo.Text = String.Empty
        txtTipoUsuario.Text = String.Empty
    End Sub

    Private Sub HabilitarCajasTexto()
        txtCodigo.Enabled = True
        txtTipoUsuario.Enabled = True

        txtCodigo.BackColor = Me.BackColor
        txtTipoUsuario.BackColor = Me.BackColor

    End Sub
    Private Sub DesHabilitarCajasTexto()
        txtCodigo.Enabled = False
        txtTipoUsuario.Enabled = False

        txtCodigo.BackColor = Color.LightGray
        txtTipoUsuario.BackColor = Color.LightGray

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

    Private Sub EstadoInicialFormulario()
        Try
            'Cargo el Datagrid
            dgvListadoTiposUsuarios.AutoGenerateColumns = False
            dgvListadoTiposUsuarios.DataSource = TiposUsuariosBO.CargarTodos()
            dgvListadoTiposUsuarios.ClearSelection()
            dgvListadoTiposUsuarios.Enabled = True

            'Deshabilito Cajas de Texto
            Call BorrarCajasTexto()
            Call DesHabilitarCajasTexto()

            'Muestro/Oculto botones del Menu
            Call DesHabilitarBotonesOperacionBarra()
            tlbNuevo.Enabled = True
            tlbBuscar.Enabled = True

            Call OcultarBotonesGuardar()

            'Oculto el boton de Buscar Codigo Postal
            btnBuscarCodigo.Visible = False
        Catch ex As Exception
            MsgBox("Se ha producido la siguiente excepción: " + vbCrLf + _
                    ex.Message, CType(MsgBoxStyle.OkOnly + MsgBoxStyle.Critical, MsgBoxStyle), "Error...")
        End Try
    End Sub


    Private tipousuario As EntidadTiposUsuarios = Nothing

    Private Sub frmCrudTiposUsuarios_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call EstiloDataGrid(dgvListadoTiposUsuarios)
        Call EstadoInicialFormulario()
    End Sub


    Private Sub dgvListadoTiposUsuarios_CellMouseClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles dgvListadoTiposUsuarios.CellMouseClick
        Try
            If e.RowIndex >= 0 Then
                txtCodigo.Text = CStr(dgvListadoTiposUsuarios.Rows(e.RowIndex).Cells("clnCodigo").Value)
                txtTipoUsuario.Text = CStr(dgvListadoTiposUsuarios.Rows(e.RowIndex).Cells("clnTipo").Value)

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
        dgvListadoTiposUsuarios.ClearSelection()
        dgvListadoTiposUsuarios.Enabled = False

        'Muestro/Oculto botones del Menu
        Call DesHabilitarBotonesOperacionBarra()
        Call MostrarBotonesGuardar()
        tlbActualizar.Visible = False

        'Paso el Foco a la primera caja
        txtCodigo.Focus()

    End Sub
    Private Sub tlbEditar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tlbEditar.Click
        'Preparo las cajas
        Call HabilitarCajasTexto()
        txtCodigo.Enabled = False

        'Deshabilito el Grid
        dgvListadoTiposUsuarios.Enabled = False

        'Muestro/Oculto botones del Menu
        Call DesHabilitarBotonesOperacionBarra()
        Call MostrarBotonesGuardar()
        tlbGuardar.Visible = False

    End Sub


    Private Sub tlbBuscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tlbBuscar.Click
        Try
            If dgvListadoTiposUsuarios.RowCount > 0 Then
                'Preparo las cajase
                Call DesHabilitarCajasTexto()
                Call BorrarCajasTexto()

                txtCodigo.Enabled = True
                txtCodigo.BackColor = Me.BackColor
                txtCodigo.Focus()

                'Muestro/Oculto botones del Menu
                Call DesHabilitarBotonesOperacionBarra()
                Call OcultarBotonesGuardar()

                btnBuscarCodigo.Visible = True
            Else
                MsgBox("No existen registros que buscar.", CType(MsgBoxStyle.Exclamation + vbOKOnly, MsgBoxStyle), "No existen registros...")
                Call EstadoInicialFormulario()
            End If
        Catch ex As Exception
            MsgBox("Se ha producido la siguiente excepción: " + vbCrLf + _
                    ex.Message, CType(MsgBoxStyle.OkOnly + MsgBoxStyle.Critical, MsgBoxStyle), "Error...")
        End Try
    End Sub

    Private Sub btnBuscarCodigo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBuscarCodigo.Click
        Try
            Dim encontrado As Boolean = False

            encontrado = BuscarEnDataGrid(txtCodigo.Text, "clnCodigo", dgvListadoTiposUsuarios)

            If encontrado Then
                'DesHabilito las cajas
                Call DesHabilitarCajasTexto()

                Call HabilitarBotonesOperacionBarra()
                dgvListadoTiposUsuarios.Enabled = True

                btnBuscarCodigo.Visible = False

                'Copio los valores en las cajas
                txtCodigo.Text = CStr(dgvListadoTiposUsuarios.CurrentRow.Cells("clnCodigo").Value)
                txtTipoUsuario.Text = CStr(dgvListadoTiposUsuarios.CurrentRow.Cells("clnTipo").Value)
            Else
                MsgBox("No se encontro ninguna coincidencia.", CType(MsgBoxStyle.Information + vbOKOnly, MsgBoxStyle), "Ninguna coincidencia...")
                txtCodigo.Focus()
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
                If tipousuario Is Nothing Then
                    tipousuario = New EntidadTiposUsuarios()
                End If

                'Guardon en la entidad los valores de las cajas
                tipousuario.Codigo = txtCodigo.Text
                tipousuario.Tipo = txtTipoUsuario.Text

                TiposUsuariosBO.Guardar(tipousuario)

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
            If Validaciones() Then
                If tipousuario Is Nothing Then
                    tipousuario = New EntidadTiposUsuarios()
                End If

                'Guardon en la entidad los valores de las cajas
                tipousuario.Codigo = txtCodigo.Text
                tipousuario.Tipo = txtTipoUsuario.Text

                TiposUsuariosBO.Actualizar(tipousuario)

                'Pongo el formulario en su estado inicial
                Call EstadoInicialFormulario()
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

            'Compruebo si existen registros en las tablas dependientes, PERSONAS
            If TiposUsuariosBO.ComprobarDependencias(codigo) Then
                MsgBox("Existen dependencias en otras tablas. " + vbCrLf + _
                       "No se puede borrar el registro.", CType(MsgBoxStyle.OkOnly + MsgBoxStyle.Critical, MsgBoxStyle), "Error...")
            Else
                Call TiposUsuariosBO.Borrar(codigo)
                Call EstadoInicialFormulario()

            End If
        Catch ex As Exception
            MsgBox("Se ha producido la siguiente excepción: " + vbCrLf + _
                    ex.Message, CType(MsgBoxStyle.OkOnly + MsgBoxStyle.Critical, MsgBoxStyle), "Error...")
        End Try
    End Sub
End Class