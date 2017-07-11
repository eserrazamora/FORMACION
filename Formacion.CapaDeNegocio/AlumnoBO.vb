Imports Formacion.AccesoDatos
Imports Formacion.Entidades
Public Class AlumnoBO
    Public Shared Function CargarTodos() As List(Of EntidadAula)
        Return AulasDAL.CargarTodos
    End Function

    Public Shared Function CargarUnAula(ByVal codigo As String) As EntidadAula

        Return AulasDAL.CargarUnAula(codigo)

    End Function

    Public Shared Function Existe(ByVal codigo As String) As Boolean
        Return AulasDAL.Existe(codigo)
    End Function

    Public Shared Function Guardar(ByVal aula As EntidadAula) As EntidadAula

        If AulasDAL.Existe(aula.Codigo) Then
            Return AulasDAL.Actualizar(aula)
        Else
            Return AulasDAL.Crear(aula)
        End If

    End Function
End Class
