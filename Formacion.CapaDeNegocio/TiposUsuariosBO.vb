Imports Formacion.AccesoDatos
Imports Formacion.Entidades
Public Class TiposUsuariosBO
    Public Shared Function CargarTodos() As List(Of EntidadTiposUsuarios)
        Return TiposUsuariosDAL.CargarTodos
    End Function

    Public Shared Function CargarUnTiposUsuarios(ByVal codigo As String) As EntidadTiposUsuarios

        Return TiposUsuariosDAL.CargarUnTipoUsuario(codigo)

    End Function

    Public Shared Function Existe(ByVal codigo As String) As Boolean
        Return TiposUsuariosDAL.Existe(codigo)
    End Function

    Public Shared Function Guardar(ByVal tipousuario As EntidadTiposUsuarios) As EntidadTiposUsuarios
        Dim result As MsgBoxResult

        If TiposUsuariosDAL.Existe(tipousuario.Codigo) Then
            result = MsgBox("El registro ya existe" + vbCrLf + _
                    "¿Desea actualizarlo?", CType(MsgBoxStyle.YesNo + MsgBoxStyle.Question, MsgBoxStyle), "El registro ya existe...")
            If result = MsgBoxResult.Yes Then
                Return (TiposUsuariosDAL.Actualizar(tipousuario))
            Else
                Return tipousuario
            End If
        Else
            Return TiposUsuariosDAL.Crear(tipousuario)
        End If

    End Function
    Public Shared Function Actualizar(ByVal tipousuario As EntidadTiposUsuarios) As EntidadTiposUsuarios
        Return TiposUsuariosDAL.Actualizar(tipousuario)
    End Function
    Public Shared Function ComprobarDependencias(ByVal codigo As String) As Boolean
        Return TiposUsuariosDAL.ComprobarDependencias(codigo)
    End Function
    Public Shared Function Borrar(ByVal codigo As String) As Integer
        Return TiposUsuariosDAL.Borrar(codigo)
    End Function
    Public Shared Function CargarTodosDatatable() As DataTable
        Return TiposUsuariosDAL.CargarTodosDatatable
    End Function
End Class

