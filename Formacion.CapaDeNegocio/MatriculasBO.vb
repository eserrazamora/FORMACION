Imports Formacion.AccesoDatos
Imports Formacion.Entidades
Public Class MatriculasBO
    Public Shared Function CargarCursosNIFenDataTable(ByVal NIF As String) As DataTable
        Return MatriculasDAL.CargarCursosNIFenDataTable(NIF)
    End Function
    Public Shared Function CargarCursosNifNoMatriculadosEnDatatable(ByVal NIF As String) As DataTable
        Return MatriculasDAL.CargarCursosNifNoMatriculadosEnDatatable(NIF)
    End Function
    Public Shared Function CargarCursosEnDatatable() As DataTable
        Return MatriculasDAL.CargarCursosEnDatatable
    End Function
    Public Shared Function CargarAlumnosNoMatriculados(ByVal codigocurso As String) As DataTable
        Return MatriculasDAL.CargarAlumnosNoMatriculados(codigocurso)
    End Function
    Public Shared Function Existe(ByVal codigomatricula As String) As Boolean
        Return MatriculasDAL.Existe(codigomatricula)
    End Function
    Public Shared Function Crear(ByVal matricula As EntidadMatricula) As EntidadMatricula
        Return MatriculasDAL.Crear(matricula)
    End Function
    Public Shared Function Actualizar(ByVal matricula As EntidadMatricula) As EntidadMatricula
        Return MatriculasDAL.Actualizar(matricula)
    End Function
    Public Shared Function Borrar(ByVal matricula As String) As Integer
        Return MatriculasDAL.Borrar(matricula)
    End Function
    Public Shared Function ObtenerNumeroCursosMatriculados(ByVal nif As String) As Integer
        Return MatriculasDAL.ObtenerNumeroCursosMatriculados(nif)
    End Function
    Public Shared Function ComprobarDependencias(ByVal codigo As String) As Boolean
        Return MatriculasDAL.ComprobarDependencias(codigo)
    End Function
End Class
