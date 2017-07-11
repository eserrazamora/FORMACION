Imports Formacion.AccesoDatos
Imports Formacion.Entidades

Public Class CodigoPostalBO

    Public Shared Function CargarTodos() As List(Of EntidadCodigoPostal)
        Return CodigoPostalDAL.CargarTodos
    End Function

    Public Shared Function CargarUnCodigoPostal(ByVal codigo As String) As EntidadCodigoPostal
        Return CodigoPostalDAL.CargarUnCodigoPostal(codigo)
    End Function

    Public Shared Function Existe(ByVal codigo As String) As Boolean
        Return CodigoPostalDAL.Existe(codigo)
    End Function

    Public Shared Function Guardar(ByVal cp As EntidadCodigoPostal) As EntidadCodigoPostal
        Dim result As MsgBoxResult

        If CodigoPostalDAL.Existe(cp.CodigoPostal) Then
            result = MsgBox("El registro ya existe." + vbCrLf + _
                            "¿Desea actualizarlo?", _
                            CType(MsgBoxStyle.YesNo + MsgBoxStyle.Question, MsgBoxStyle), _
                            "El registro ya existe...")
            If result = MsgBoxResult.Yes Then
                Return (CodigoPostalDAL.Actualizar(cp))
            Else
                Return cp
            End If
        Else
            Return CodigoPostalDAL.Crear(cp)
        End If

    End Function
    Public Shared Function Actualizar(ByVal cp As EntidadCodigoPostal) As EntidadCodigoPostal
        Return (CodigoPostalDAL.Actualizar(cp))
    End Function
    Public Shared Function CargarTodosEnDatatable() As DataTable

        Return CodigoPostalDAL.CargarTodosEnDatatable

    End Function
    Public Shared Function ComprobarDependencias(ByVal codigo As String) As Boolean
        Return CodigoPostalDAL.ComprobarDependencias(codigo)
    End Function
    Public Shared Function Borrar(ByVal codigo As String) As Integer
        Return CodigoPostalDAL.Borrar(codigo)
    End Function
End Class
