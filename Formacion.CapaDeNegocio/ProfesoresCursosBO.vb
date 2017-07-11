Imports Formacion.Entidades
Imports Formacion.AccesoDatos
Imports System.Data.SqlClient
Imports System.Configuration

Public NotInheritable Class ProfesoresCursosBO
    Public Shared Function CargarProfesoresNoEstenEnCurso(ByVal codigocurso As String) As DataTable
        Return ProfesoresCursosDAL.CargarProfesoresNoEstenEnCurso(codigocurso)
    End Function
    Public Shared Function CargarCursosProfesor(ByVal codigocurso As String) As DataTable
        Return ProfesoresCursosDAL.CargarCursosProfesor(codigocurso)
    End Function
    Public Shared Function Crear(ByVal profesorcurso As EntidadProfesorCurso) As EntidadProfesorCurso
        Return ProfesoresCursosDAL.Crear(profesorcurso)
    End Function
End Class
