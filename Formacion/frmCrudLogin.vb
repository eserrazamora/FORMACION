Imports Formacion.Entidades
Imports Formacion.CapaDeNegocio
Imports System.Text.RegularExpressions

Public Class frmCrudLogin
    Private login As EntidadLogin
    Private Function Validaciones() As Boolean
        Try
            'El Nif no puede ser vacio
            'El usuario no puede ser vacio
            'La contraseña no puede ser vacia
            'DEbe seleccionar un tipo de usuario

            Dim cadena As String = String.Empty
            Dim numerrores As Integer = 0

            If txtNif.Text = String.Empty Then
                cadena = "El campo 'NIF' no puede ser vacio." + vbCrLf
                txtNif.BackColor = Color.Red
                numerrores += 1
            Else
                txtNif.BackColor = System.Drawing.ColorTranslator.FromWin32(RGB(64, 64, 64))
            End If

            If txtUsuario.Text = String.Empty Then
                cadena = cadena + "El campo 'Usuario' no puede ser vacio." + vbCrLf
                txtUsuario.BackColor = Color.Red
                numerrores += 1
            Else
                txtUsuario.BackColor = System.Drawing.ColorTranslator.FromWin32(RGB(64, 64, 64))
            End If

            If txtContraseña.Text = String.Empty Then
                cadena = cadena + "El campo 'Contraseña' no puede ser vacio." + vbCrLf
                txtContraseña.BackColor = Color.Red
                numerrores += 1
            Else
                txtContraseña.BackColor = System.Drawing.ColorTranslator.FromWin32(RGB(64, 64, 64))
            End If

            If CStr(cboTipoUsuario.SelectedValue) = "SELE" Then
                cadena = cadena + "El campo 'Tipo de Usuario' no puede ser vacio." + vbCrLf
                cboTipoUsuario.BackColor = Color.Red
                numerrores += 1
            Else
                cboTipoUsuario.BackColor = System.Drawing.ColorTranslator.FromWin32(RGB(64, 64, 64))
            End If

            If numerrores = 0 Then
                txtNif.BackColor = System.Drawing.ColorTranslator.FromWin32(RGB(64, 64, 64))
                txtUsuario.BackColor = System.Drawing.ColorTranslator.FromWin32(RGB(64, 64, 64))
                txtContraseña.BackColor = System.Drawing.ColorTranslator.FromWin32(RGB(64, 64, 64))
                cboTipoUsuario.BackColor = System.Drawing.ColorTranslator.FromWin32(RGB(64, 64, 64))
                Return True
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
                    If txtUsuario.BackColor = Color.Red Then
                        txtUsuario.Focus()
                    Else
                        If txtContraseña.BackColor = Color.Red Then
                            txtContraseña.Focus()
                        Else
                            cboTipoUsuario.Focus()
                        End If
                    End If
                End If
                Return False
            End If
        Catch ex As Exception
            MsgBox("Se ha producido la siguiente excepción: " + vbCrLf + _
                    ex.Message, CType(MsgBoxStyle.OkOnly + MsgBoxStyle.Critical, MsgBoxStyle), "Error...")
            Return False
        End Try
    End Function
    Public Sub CargarDatosNif()
        Try
            Dim nif As String
            If login Is Nothing Then
                login = New EntidadLogin()
            End If

            nif = txtNif.Text
            login = LoginBO.CargarDatosLoginNif(nif)

            If login Is Nothing Then
                MsgBox("El NIF no existe", CType(MsgBoxStyle.OkOnly + MsgBoxStyle.Critical, MsgBoxStyle), "Error...")
                txtNif.SelectionStart = 0
                txtNif.SelectionLength = Len(txtNif.Text)
                txtNif.Focus()
            Else
                lblNombreCompletoText.Text = login.NombreCompleto
                txtUsuario.Text = login.Usuario
                If login.Usuario = String.Empty Then
                    txtContraseña.Text = String.Empty
                Else
                    txtContraseña.Text = "*****CODIFICADA*****"
                End If

                If login.TipoUsuario = String.Empty Then
                    cboTipoUsuario.SelectedValue = "SELE"
                Else
                    cboTipoUsuario.SelectedValue = login.TipoUsuario
                End If
                'Habilito controles
                Call HabilitarBotonesOperacionBarra()

            End If
        Catch ex As Exception
            MsgBox("Se ha producido la siguiente excepción: " + vbCrLf + _
                    ex.Message, CType(MsgBoxStyle.OkOnly + MsgBoxStyle.Critical, MsgBoxStyle), "Error...")
        End Try
    End Sub

    Public Sub CargarComboTiposUsuarios()
        Try
            Dim dtTiposUsuarios As DataTable

            'Cargo el ComboBox de Tipos de Aulas
            dtTiposUsuarios = TiposUsuariosBO.CargarTodosDatatable

            ' Añadimos una nueva fila al objeto DataTable
            Dim row As DataRow = dtTiposUsuarios.NewRow

            ' Establecemos el valor del campo Nombre
            row("Tipo") = "<Seleccionar>"

            ' Establecemos el valor de otro Campo
            row("Codigo") = "SELE"

            ' Insertamos la fila en la primera posición
            dtTiposUsuarios.Rows.InsertAt(row, 0)

            cboTipoUsuario.ValueMember = "Codigo"
            cboTipoUsuario.DisplayMember = "Tipo"
            cboTipoUsuario.DataSource = dtTiposUsuarios

            cboTipoUsuario.SelectedValue = "SELE"
        Catch ex As Exception
            MsgBox("Se ha producido la siguiente excepción: " + vbCrLf + _
                    ex.Message, CType(MsgBoxStyle.OkOnly + MsgBoxStyle.Critical, MsgBoxStyle), "Error...")
        End Try
    End Sub

    Public Sub BorrarControles()
        txtNif.Text = String.Empty
        lblNombreCompletoText.Text = String.Empty
        txtUsuario.Text = String.Empty
        txtContraseña.Text = String.Empty
        cboTipoUsuario.SelectedValue = "SELE"
    End Sub
    Public Sub HabilitarControles()
        txtUsuario.Enabled = True
        txtContraseña.Enabled = True
        cboTipoUsuario.Enabled = True
    End Sub
    Public Sub DesHabilitarControles()
        txtUsuario.Enabled = False
        txtContraseña.Enabled = False
        cboTipoUsuario.Enabled = False
    End Sub

    Private Sub HabilitarBotonesOperacionBarra()
        tlbEditar.Enabled = True
    End Sub

    Private Sub DesHabilitarBotonesOperacionBarra()
        tlbEditar.Enabled = False
    End Sub
    Private Sub MostrarBotonesGuardar()
        tlbGuardar.Visible = True
        tlbCancelar.Visible = True
    End Sub

    Private Sub OcultarBotonesGuardar()
        tlbGuardar.Visible = False
        tlbCancelar.Visible = False
    End Sub
    Public Sub EstadoInicialFormulario()
        Try
            Call CargarComboTiposUsuarios()
            Call BorrarControles()

            Call DesHabilitarBotonesOperacionBarra()
            Call OcultarBotonesGuardar()

            Call DesHabilitarControles()

            tlbBorrar.Enabled = True

            txtNif.Focus()
        Catch ex As Exception
            MsgBox("Se ha producido la siguiente excepción: " + vbCrLf + _
                    ex.Message, CType(MsgBoxStyle.OkOnly + MsgBoxStyle.Critical, MsgBoxStyle), "Error...")
        End Try
    End Sub
    Private Sub frmCrudLogin_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call EstadoInicialFormulario()
    End Sub

    Private Sub txtNif_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtNif.Leave
        Try
            If txtNif.Text <> "" Then
                Call CargarDatosNif()
            Else
                txtNif.Focus()
            End If
        Catch ex As Exception
            MsgBox("Se ha producido la siguiente excepción: " + vbCrLf + _
                    ex.Message, CType(MsgBoxStyle.OkOnly + MsgBoxStyle.Critical, MsgBoxStyle), "Error...")
        End Try
    End Sub

    Private Sub tlbBorrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tlbBorrar.Click

        Call BorrarControles()
        Call DesHabilitarBotonesOperacionBarra()

    End Sub

    Private Sub tlbEditar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tlbEditar.Click

        Call HabilitarControles()
        tlbBorrar.Enabled = False

        Call MostrarBotonesGuardar()

        txtContraseña.Text = String.Empty

        txtNif.Enabled = False
        txtUsuario.Focus()
    End Sub

    Private Sub tlbGuardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tlbGuardar.Click
        Try
            If Validaciones() Then
                If login Is Nothing Then
                    login = New EntidadLogin()
                End If

                login.Nif = CStr(txtNif.Text)
                login.Usuario = CStr(txtUsuario.Text)
                login.Contraseña = CStr(txtContraseña.Text)
                login.TipoUsuario = CStr(cboTipoUsuario.SelectedValue)

                Call LoginBO.Guardar(login)

                Call OcultarBotonesGuardar()

                Call CargarDatosNif()

                Call DesHabilitarControles()
                txtNif.Enabled = True
            End If
        Catch ex As Exception
            MsgBox("Se ha producido la siguiente excepción: " + vbCrLf + _
                    ex.Message, CType(MsgBoxStyle.OkOnly + MsgBoxStyle.Critical, MsgBoxStyle), "Error...")
        End Try
    End Sub

    Private Sub tlbCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tlbCancelar.Click
        Call EstadoInicialFormulario()
    End Sub



    Private Sub txtContraseña_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtContraseña.KeyPress
        Try
            Dim re As New Regex("[^A-Z0-9Ñ._\-\b]", RegexOptions.IgnoreCase)

            e.Handled = re.IsMatch(e.KeyChar)

        Catch ex As Exception
            MsgBox("Se ha producido la siguiente excepción: " + vbCrLf + _
                    ex.Message, CType(MsgBoxStyle.OkOnly + MsgBoxStyle.Critical, MsgBoxStyle), "Error...")
        End Try
    End Sub


End Class