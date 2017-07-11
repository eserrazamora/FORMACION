Imports Formacion.Entidades
Imports Formacion.CapaDeNegocio

Public Class frmLogin
    Private Sub BorrarCajasTexto()
        txtUsuario.Text = String.Empty
        txtContraseña.Text = String.Empty
    End Sub
    Private Sub EstadoInicialFormulario()
        Call BorrarCajasTexto()
        tooltip.SetToolTip(btnBorrar, "Limpiar Cajas")
        tooltip.SetToolTip(btnLogin, "Validarse en el Sistema")
        txtUsuario.Focus()
    End Sub
    Private Sub frmLogin_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call EstadoInicialFormulario()
    End Sub
    Private Sub btnLogin_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLogin.Click
        Try
            Dim user As New EntidadLogin
            Dim comprobado As Boolean

            'Guardo en la entidad los valores
            user.Usuario = txtUsuario.Text
            user.Contraseña = txtContraseña.Text

            If user.Usuario = String.Empty Then
                MsgBox("Debe introducir un nombre de usuario.", _
                       CType(MsgBoxStyle.Information + MsgBoxStyle.OkOnly, MsgBoxStyle), _
                       "Nombre de usuario vacio.")
                txtUsuario.Focus()
            Else
                'Compruebo si esta bien el usuario/password

                comprobado = LoginBO.ComprobarLogin(user)

                If comprobado Then
                    Dim login As EntidadLogin = Nothing

                    login = LoginBO.CargarDatosLogin(user.Usuario)
                    Dim VarfrmMenuPrincipal As New frmMenuPrincipal(login.TipoUsuario)
                    Me.Hide()
                    VarfrmMenuPrincipal.Show()
                Else
                    MsgBox("Usuario/Contraseña incorrectos.", _
                           CType(MsgBoxStyle.Information + MsgBoxStyle.OkOnly, MsgBoxStyle), _
                           "Error...")
                    txtUsuario.Focus()
                End If
            End If
        Catch ex As Exception
            MsgBox("Se ha producido la siguiente excepción: " + vbCrLf + _
                    ex.Message, CType(MsgBoxStyle.OkOnly + MsgBoxStyle.Critical, MsgBoxStyle), "Error...")
        End Try
    End Sub

    Private Sub btnBorrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBorrar.Click
        Call BorrarCajasTexto()
        txtUsuario.Focus()
    End Sub

End Class
