Imports Formacion.AccesoDatos
Imports Formacion.Entidades

Public Class AulasBO
    Public Shared Function CargarTodos() As List(Of EntidadAula)
        Return AulasDAL.CargarTodos
    End Function

    Public Shared Function CargarUnCodigoPostal(ByVal codigo As String) As EntidadAula

        Return AulasDAL.CargarUnAula(codigo)

    End Function

    Public Shared Function Existe(ByVal codigo As String) As Boolean
        Return AulasDAL.Existe(codigo)
    End Function

    Public Shared Function Guardar(ByVal aula As EntidadAula) As EntidadAula
        Dim result As MsgBoxResult

        If AulasDAL.Existe(aula.Codigo) Then
            result = MsgBox("El registro ya existe." + vbCrLf + _
                        "¿Desea actualizarlo?", _
                        CType(MsgBoxStyle.YesNo + MsgBoxStyle.Question, MsgBoxStyle), _
                        "El registro ya existe...")
            If result = MsgBoxResult.Yes Then
                Return AulasDAL.Actualizar(aula)
            Else
                Return aula
            End If
        Else
            Return AulasDAL.Crear(aula)
        End If

    End Function
    Public Shared Function Actualizar(ByVal aula As EntidadAula) As EntidadAula
        Return AulasDAL.Actualizar(aula)
    End Function
    Public Shared Function CargarAulasDatatable() As DataTable
        Return AulasDAL.CargarAulasDatatable()
    End Function
    Public Shared Function ComprobarDependencias(ByVal codigo As String) As Boolean
        Return AulasDAL.ComprobarDependencias(codigo)
    End Function
    Public Shared Function Borrar(ByVal codigo As String) As Integer
        Return AulasDAL.Borrar(codigo)
    End Function
    Public Shared Function InformeAulas() As DataTable
        Return AulasDAL.InformeAulas
    End Function
End Class
