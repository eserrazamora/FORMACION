Imports Formacion.AccesoDatos
Imports Formacion.Entidades

Public Class CalificacionesBO
    Public Shared Function CargarTodos(ByVal CodigoCurso As String) As List(Of EntidadCalificacion)
        Return CalificacionesDAL.CargarTodos(CodigoCurso)
    End Function
    Public Shared Function CargarTodosEnDataTable(ByVal CodigoCurso As String) As DataTable
        Return CalificacionesDAL.CargarTodosEnDataTable(CodigoCurso)
    End Function
    Public Shared Function GuardarCalificacion(ByVal calificacion As EntidadCalificacion) As EntidadCalificacion

        If CalificacionesDAL.Existe(calificacion.CodigoMatricula) Then
            Return CalificacionesDAL.ActualizarCalificacion(calificacion)
        Else
            Return CalificacionesDAL.CrearCalificacion(calificacion)
        End If
    End Function

End Class
