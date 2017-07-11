Imports Formacion.AccesoDatos
Imports Formacion.Entidades
Public Class LoginBO
    Public Shared Function CargarDatosLogin(ByVal usuario As String) As EntidadLogin
        Return LoginDAL.CargarDatosLogin(usuario)
    End Function
    Public Shared Function CargarDatosLoginNif(ByRef NIF As String) As EntidadLogin
        Return LoginDAL.CargarDatosLoginNif(NIF)
    End Function
    Public Shared Function EncodePassword(ByVal originalPassword As String) As String
        Return LoginDAL.EncodePassword(originalPassword)
    End Function
    Public Shared Function ComprobarLogin(ByRef user As EntidadLogin) As Boolean
        Return LoginDAL.ComprobarLogin(user)
    End Function
    Public Shared Function Guardar(ByVal login As EntidadLogin) As EntidadLogin
        Dim result As MsgBoxResult

        If LoginBO.ExisteNif(login.Nif) Then
            result = MsgBox("El registro ya existe" + vbCrLf + _
                             "¿Desea actualizarlo?", CType(MsgBoxStyle.YesNo + MsgBoxStyle.Question, MsgBoxStyle), "El registro ya existe...")
            If result = MsgBoxResult.Yes Then
                Return (LoginBO.Actualizar(login))
            Else
                Return login
            End If
        Else
            Return LoginBO.Crear(login)
        End If

    End Function
    Public Shared Function Crear(ByRef user As EntidadLogin) As EntidadLogin
        Return LoginDAL.Crear(user)
    End Function
    Public Shared Function Actualizar(ByRef user As EntidadLogin) As EntidadLogin
        Return LoginDAL.Actualizar(user)
    End Function
    Public Shared Function ExisteUser(ByRef user As String) As Boolean
        Return LoginDAL.ExisteUser(user)
    End Function
    Public Shared Function ExisteNif(ByRef NIF As String) As Boolean
        Return LoginDAL.ExisteNif(NIF)
    End Function

End Class
