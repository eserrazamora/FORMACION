Imports Formacion.Entidades
Imports Formacion.CapaDeNegocio

Public Class frmSeleccionAlumnosParaCurso
    Public rol As String
    Public codigocurso As String
    Public NombreCurso As String
    Dim codigomatricula As String
    Dim matricula As EntidadMatricula


    Private Sub frmSeleccionAlumnosParaCurso_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim dt As DataTable

        If rol = "ALM" Then
            dt = MatriculasBO.CargarAlumnosNoMatriculados(codigocurso)
            clbSeleccionAlumnos.DataSource = dt
            clbSeleccionAlumnos.DisplayMember = "Info"
            clbSeleccionAlumnos.ValueMember = "Nif"

            lblCodigoCurso.Text = codigocurso

        End If



    End Sub

   
    Private Sub btnAsignar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAsignar.Click
        Dim i As Integer
        Dim s As String = String.Empty
        Dim numcursos As Integer
        Dim nif As String
        Dim codigomatricula As String
        'Recorro el los elementos Checkeados
        If clbSeleccionAlumnos.CheckedItems.Count <> 0 Then
            For Each item As DataRowView In clbSeleccionAlumnos.CheckedItems
                nif = item("Nif").ToString
                MsgBox("El NIF es: " & nif)
                numcursos = MatriculasBO.ObtenerNumeroCursosMatriculados(nif)
                MsgBox("EL numero de cursos matriculados es: " & numcursos.ToString)
                'Compongo la cadena codigomatricula
                numcursos += 1
                codigomatricula = nif & String.Format(String.Format("{0:000}", numcursos))
                MsgBox(codigomatricula)
                codigomatricula = String.Empty
                nif = String.Empty
                numcursos = 0

            Next
        End If

    End Sub
End Class