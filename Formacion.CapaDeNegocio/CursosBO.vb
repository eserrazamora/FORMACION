Imports Formacion.AccesoDatos
Imports Formacion.Entidades
Public Class CursosBO
    Public Shared Function CargarTodos() As List(Of EntidadCursos)
        Return CursosDAL.CargarTodos
    End Function
    Public Shared Function CargarCursosAula(ByVal aula As String) As List(Of EntidadCursos)
        Return CursosDAL.CargarCursosAula(aula)
    End Function
    Public Shared Function CargarUnCurso(ByVal codigo As String) As EntidadCursos
        Return CursosDAL.CargarUnCurso(codigo)
    End Function
    Public Shared Function Existe(ByVal codigo As String) As Boolean
        Return CursosDAL.Existe(codigo)
    End Function
    Public Shared Function Guardar(ByVal curso As EntidadCursos) As EntidadCursos
        Dim result As MsgBoxResult

        If CursosDAL.Existe(curso.CodigoCurso) Then
            result = MsgBox("El registro ya existe." + vbCrLf + _
                            "¿Desea actualizarlo?", _
                            CType(MsgBoxStyle.YesNo + MsgBoxStyle.Question, MsgBoxStyle), _
                            "El registro ya existe...")
            If result = MsgBoxResult.Yes Then
                Return CursosDAL.Actualizar(curso)
            Else
                Return curso
            End If
        Else
            Return CursosDAL.Crear(curso)
        End If
    End Function
    Public Shared Function Actualizar(ByVal curso As EntidadCursos) As EntidadCursos
        Return CursosDAL.Actualizar(curso)
    End Function
    'Funcion para actualizar solo el campo aula de un registro
    Public Shared Function ActualizarAula(ByVal curso As EntidadCursos) As EntidadCursos
        Return CursosDAL.ActualizarAula(curso)
    End Function
    Public Shared Function CargarTodosEnDataTable() As DataTable
        Return CursosDAL.CargarTodosEnDataTable
    End Function
    Public Shared Function CargarDatosUnCursoEnDataTable(ByVal CodigoCurso As String) As DataTable
        Return CursosDAL.CargarDatosUnCursoEnDataTable(CodigoCurso)
    End Function
    Public Shared Function CargarCursosSinAulaenDatatable() As DataTable
        Return CursosDAL.CargarCursosSinAulaenDatatable
    End Function
    Public Shared Function ComprobarDependencias(ByVal codigo As String) As Boolean
        Return CursosDAL.ComprobarDependencias(codigo)
    End Function
    Public Shared Function Borrar(ByVal codigo As String) As Integer
        Return CursosDAL.Borrar(codigo)
    End Function
    Public Shared Function ConsultarDatosCursos(ByVal curso As EntidadCursos) As DataTable
        Return CursosDAL.ConsultarDatosCursos(curso)
    End Function
    Public Shared Function InformeCursos() As DataTable
        Return CursosDAL.InformeCursos
    End Function
End Class
