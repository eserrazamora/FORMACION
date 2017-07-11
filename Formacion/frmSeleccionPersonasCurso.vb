Imports Formacion.Entidades
Imports Formacion.CapaDeNegocio

Public Class frmSeleccionPersonasCurso
    Public rol As String
    Public CodigoCurso As String
    Public NombreCurso As String
    Dim codigomatricula As String
    Dim matricula As EntidadMatricula
    Dim profesorcurso As EntidadProfesorCurso



    Private Sub frmSeleccionAlumnosParaCurso_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            Dim dt As DataTable = Nothing

            If rol = "ALM" Then
                dt = MatriculasBO.CargarAlumnosNoMatriculados(CodigoCurso)
            Else
                If rol = "PRF" Then
                    dt = ProfesoresCursosBO.CargarProfesoresNoEstenEnCurso(CodigoCurso)
                End If
            End If

            clbSeleccionPersonas.DataSource = dt
            clbSeleccionPersonas.DisplayMember = "Info"
            clbSeleccionPersonas.ValueMember = "Nif"
            lblCodigoCurso.Text = CodigoCurso & " - " & NombreCurso
        Catch ex As Exception
            MsgBox("Se ha producido la siguiente excepción: " + vbCrLf + _
                    ex.Message, CType(MsgBoxStyle.OkOnly + MsgBoxStyle.Critical, MsgBoxStyle), "Error...")
        End Try
    End Sub


    Private Sub btnAsignar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAsignar.Click
        Try
            Dim s As String = String.Empty
            Dim numcursos As Integer
            Dim nif As String
            Dim codigomatricula As String
            'Recorro el los elementos Checkeados
            If clbSeleccionPersonas.CheckedItems.Count <> 0 Then

                If rol = "ALM" Then
                    If matricula Is Nothing Then
                        matricula = New EntidadMatricula()
                    End If

                    For Each item As DataRowView In clbSeleccionPersonas.CheckedItems
                        nif = item("Nif").ToString

                        numcursos = MatriculasBO.ObtenerNumeroCursosMatriculados(nif)
                        'Compongo la cadena codigomatricula
                        numcursos += 1
                        codigomatricula = nif & String.Format(String.Format("{0:000}", numcursos))

                        'Le doy valores a la entidad
                        matricula.CodigoCurso = CodigoCurso
                        matricula.CodigoMatricula = codigomatricula
                        matricula.NifAlumno = nif
                        matricula.Pagado = CChar("N")

                        'Guardo la entidad en la BD
                        Call MatriculasBO.Crear(matricula)

                        codigomatricula = String.Empty
                        nif = String.Empty
                        numcursos = 0

                        matricula.CodigoCurso = String.Empty
                        matricula.CodigoMatricula = String.Empty
                        matricula.NifAlumno = String.Empty
                        matricula.Pagado = CChar(String.Empty)

                    Next
                Else
                    If profesorcurso Is Nothing Then
                        profesorcurso = New EntidadProfesorCurso()
                    End If
                    For Each item As DataRowView In clbSeleccionPersonas.CheckedItems

                        profesorcurso.CodigoCurso = CodigoCurso
                        profesorcurso.NifProfesor = item("Nif").ToString

                        'Guardo la entidad en la BD
                        Call ProfesoresCursosBO.Crear(profesorcurso)

                        profesorcurso.CodigoCurso = String.Empty
                        profesorcurso.NifProfesor = String.Empty
                    Next
                End If


                Me.Close()

            End If
        Catch ex As Exception
            MsgBox("Se ha producido la siguiente excepción: " + vbCrLf + _
                    ex.Message, CType(MsgBoxStyle.OkOnly + MsgBoxStyle.Critical, MsgBoxStyle), "Error...")
        End Try
    End Sub
End Class