Imports Formacion.AccesoDatos
Imports Formacion.Entidades
Public Class TiposAulasBO
    Public Shared Function CargarTodos() As List(Of EntidadTiposAulas)
        Return TiposAulasDAL.CargarTodos
    End Function
    Public Shared Function CargarUnTipoAula(ByVal codigo As String) As EntidadTiposAulas
        Return TiposAulasDAL.CargarUnTipoAula(codigo)
    End Function
    Public Shared Function Existe(ByVal codigo As String) As Boolean
        Return TiposAulasDAL.Existe(codigo)
    End Function
    Public Shared Function Crear(ByVal tipoaula As EntidadTiposAulas) As EntidadTiposAulas
        Return TiposAulasDAL.Crear(tipoaula)
    End Function
    Public Shared Function Actualizar(ByVal tipoaula As EntidadTiposAulas) As EntidadTiposAulas
        Return TiposAulasDAL.Actualizar(tipoaula)
    End Function
    Public Shared Function Guardar(ByVal tipoaula As EntidadTiposAulas) As EntidadTiposAulas
        Dim result As MsgBoxResult
        If TiposAulasDAL.Existe(tipoaula.Codigo) Then
            result = MsgBox("El registro ya existe" + vbCrLf + _
                             "¿Desea actualizarlo?", CType(MsgBoxStyle.YesNo + MsgBoxStyle.Question, MsgBoxStyle), "El registro ya existe...")
            If result = MsgBoxResult.Yes Then
                Return TiposAulasDAL.Actualizar(tipoaula)
            Else
                Return tipoaula
            End If
        Else
            Return TiposAulasDAL.Crear(tipoaula)
        End If
    End Function
    Public Shared Function CargarTodosEnDataTable() As DataTable
        Return TiposAulasDAL.CargarTodosEnDataTable
    End Function
    Public Shared Function ComprobarDependencias(ByVal codigo As String) As Boolean
        Return TiposAulasDAL.ComprobarDependencias(codigo)
    End Function
    Public Shared Function Borrar(ByVal codigo As String) As Integer
        Return TiposAulasDAL.Borrar(codigo)
    End Function
End Class
