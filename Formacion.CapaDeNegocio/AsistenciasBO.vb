Imports Formacion.AccesoDatos
Imports Formacion.Entidades
Public Class AsistenciasBO
    Public Shared Function CargarAsistenciasAlumnos(ByVal codigocurso As String, ByVal Fecha As Date) As DataTable
        Return AsistenciasDAL.CargarAsistenciasAlumnos(codigocurso, Fecha)
    End Function
    Public Shared Function Guardar(ByVal asistencia As EntidadAsistencia) As EntidadAsistencia

        If AsistenciasDAL.Existe(asistencia.CodigoMatricula, CDate(asistencia.Fecha)) Then
            Return AsistenciasDAL.Actualizar(asistencia)
        Else
            Return AsistenciasDAL.Crear(asistencia)
        End If
    End Function
End Class
