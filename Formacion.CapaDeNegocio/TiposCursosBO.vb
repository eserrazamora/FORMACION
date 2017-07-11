Imports Formacion.AccesoDatos
Imports Formacion.Entidades
Public Class TiposCursosBO
    Public Shared Function CargarTodos() As List(Of EntidadTiposCursos)
        Return TiposCursosDAL.CargarTodos
    End Function

    Public Shared Function CargarUnTipoCurso(ByVal codigo As String) As EntidadTiposCursos

        Return TiposCursosDAL.CargarUnTipoCurso(codigo)

    End Function

    Public Shared Function Existe(ByVal codigo As String) As Boolean
        Return TiposCursosDAL.Existe(codigo)
    End Function

    Public Shared Function Guardar(ByVal tipocurso As EntidadTiposCursos) As EntidadTiposCursos
        Dim result As MsgBoxResult

        If TiposCursosDAL.Existe(tipocurso.Codigo) Then
            result = MsgBox("El registro ya existe" + vbCrLf + _
                             "¿Desea actualizarlo?", CType(MsgBoxStyle.YesNo + MsgBoxStyle.Question, MsgBoxStyle), "El registro ya existe...")
            If result = MsgBoxResult.Yes Then
                Return TiposCursosDAL.Actualizar(tipocurso)
            Else
                Return tipocurso
            End If
        Else
            Return TiposCursosDAL.Crear(tipocurso)
        End If

    End Function
    Public Shared Function Actualizar(ByVal tipocurso As EntidadTiposCursos) As EntidadTiposCursos
        Return TiposCursosDAL.Actualizar(tipocurso)
    End Function
    Public Shared Function CargarCodigoTipoDatatable() As DataTable
        Return TiposCursosDAL.CargarCodigoTipoDatatable
    End Function
    Public Shared Function ComprobarDependencias(ByVal codigo As String) As Boolean
        Return TiposCursosDAL.ComprobarDependencias(codigo)
    End Function
    Public Shared Function Borrar(ByVal codigo As String) As Integer
        Return TiposCursosDAL.Borrar(codigo)
    End Function
End Class
