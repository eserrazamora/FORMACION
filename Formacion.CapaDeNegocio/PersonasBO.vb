Imports Formacion.AccesoDatos
Imports Formacion.Entidades
Public Class PersonasBO
    Public Shared Function CargarTodos(ByVal rol As String) As List(Of EntidadPersona)
        Return PersonasDAL.CargarTodos(rol)
    End Function

    Public Shared Function CargarUnNif(ByVal nif As String) As EntidadPersona
        Return PersonasDAL.CargarUnNif(nif)
    End Function

    Public Shared Function Existe(ByVal nif As String) As Boolean
        Return PersonasDAL.Existe(nif)
    End Function
    Public Shared Function Guardar(ByVal persona As EntidadPersona) As EntidadPersona
        Dim result As MsgBoxResult

        If PersonasDAL.Existe(persona.Nif) Then
            result = MsgBox("El registro ya existe." + vbCrLf + _
                            "¿Desea actualizarlo?", _
                            CType(MsgBoxStyle.YesNo + MsgBoxStyle.Question, MsgBoxStyle), _
                            "El registro ya existe...")
            If result = MsgBoxResult.Yes Then
                Return (PersonasDAL.Actualizar(persona))
            Else
                Return persona
            End If
        Else
            Return PersonasDAL.Crear(persona)
        End If
       
    End Function
    Public Shared Function Actualizar(ByVal persona As EntidadPersona) As EntidadPersona
        Return PersonasDAL.Actualizar(persona)
    End Function

    Public Shared Function CargarTodosEnDataTable(ByVal rol As String) As DataTable
        Return PersonasDAL.CargarTodosEnDataTable(rol)
    End Function
    Public Shared Function CargarPersonasCursoEnDatatable(ByVal codigocurso As String) As DataTable
        Return PersonasDAL.CargarPersonasCursoEnDatatable(codigocurso)
    End Function
    Public Shared Function CargarTodosAlumnosCursoEnDatatable(ByVal codigocurso As String) As DataTable
        Return PersonasDAL.CargarTodosAlumnosCursoEnDatatable(codigocurso)
    End Function
    Public Shared Function ConsultarDatosAlumnos(ByVal alumno As EntidadPersona) As DataTable
        Return PersonasDAL.ConsultarDatosAlumnos(alumno)
    End Function
    Public Shared Function ConsultarDatosProfesores(ByVal alumno As EntidadPersona) As DataTable
        Return PersonasDAL.ConsultarDatosProfesores(alumno)
    End Function
    Public Shared Function ComprobarDependencias(ByVal nif As String) As Boolean
        Return PersonasDAL.ComprobarDependencias(nif)
    End Function
    Public Shared Function Borrar(ByVal nif As String) As Integer
        Return PersonasDAL.Borrar(nif)
    End Function
End Class
