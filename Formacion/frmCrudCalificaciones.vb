Imports Formacion.CapaDeNegocio
Imports Formacion.Entidades

Public Class frmCrudCalificaciones
    Private ModoFormulario As String = String.Empty 'Establece el modo del Formulario ALM para Alumno o PRF para profesor
    Private FormularioInvocado As Boolean = False  'Si esta a true indica que el formulario ha sido llamado
    Private nifpersona As String = String.Empty
    Private curso As String = String.Empty
    Private calificacion As EntidadCalificacion = Nothing
    Public Sub New(ByVal codigo As String, ByVal nif As String, ByVal modo As String, ByVal invocado As Boolean)

        ' Llamada necesaria para el diseñador.
        InitializeComponent()

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
        FormularioInvocado = invocado
        curso = codigo
        nifpersona = nif
        ModoFormulario = modo

    End Sub

    Private Sub HabilitarBotonesOperacionBarra()

        tlbEditar.Enabled = True
        tlbBuscar.Enabled = True

    End Sub

    Private Sub DesHabilitarBotonesOperacionBarra()
        tlbEditar.Enabled = False
        tlbBuscar.Enabled = False

    End Sub

    Private Sub MostrarBotonesGuardar()
        tlbGuardar.Visible = True
        tlbCancelar.Visible = True
    End Sub

    Private Sub OcultarBotonesGuardar()
        tlbGuardar.Visible = False
        tlbCancelar.Visible = False
    End Sub

    Private Sub CargarComboCursos()
        Try
            Dim dtCursos As DataTable

            'Cargo el ComboBox de Tipos de Aulas
            If nifpersona <> String.Empty Then
                If ModoFormulario = "ALM" Then
                    dtCursos = MatriculasBO.CargarCursosNIFenDataTable(nifpersona)
                Else
                    dtCursos = ProfesoresCursosBO.CargarCursosProfesor(nifpersona)
                End If
            Else
                dtCursos = CursosBO.CargarTodosEnDataTable
            End If
            ' Añadimos una nueva fila al objeto DataTable
            Dim row As DataRow = dtCursos.NewRow

            ' Establecemos el valor a mostrar
            If ModoFormulario = "ALM" Then
                row("INFOCURSO") = "<Seleccionar>"
            Else
                row("INFO") = "<Seleccionar>"
            End If
            ' Establecemos el valor oculto
            row("CodigoCurso") = "SELE"

            ' Insertamos la fila en la primera posición
            dtCursos.Rows.InsertAt(row, 0)

            cboCursos.ValueMember = "CodigoCurso"
            If ModoFormulario = "ALM" Then
                cboCursos.DisplayMember = "INFOCURSO"
            Else
                cboCursos.DisplayMember = "INFO"
            End If
            cboCursos.DataSource = dtCursos

            cboCursos.Text = "<Seleccionar>"
        Catch ex As Exception
            MsgBox("Se ha producido la siguiente excepción: " + vbCrLf + _
                    ex.Message, CType(MsgBoxStyle.OkOnly + MsgBoxStyle.Critical, MsgBoxStyle), "Error...")
        End Try
    End Sub
    Private Sub CargarDataGridCalificaciones(ByVal codigocurso As String)
        Try
            Dim dtAlumnos As DataTable

            dtAlumnos = CalificacionesBO.CargarTodosEnDataTable(codigocurso)

            If ModoFormulario = "ALM" Then
                Dim cadena As String = "NIF=" + nifpersona
                Dim rows() As DataRow = dtAlumnos.Select(cadena)

                ' Clonamos la estructura del objeto DataTable principal
                '
                Dim dtAlumnoNIF As DataTable = dtAlumnos.Clone()

                ' Importamos los registros al nuevo DataTable
                '
                For Each row As DataRow In rows
                    dtAlumnoNIF.ImportRow(row)
                Next
                'Cargo el DatagridView
                dgvListadoAlumnos.AutoGenerateColumns = False

                dgvListadoAlumnos.DataSource = dtAlumnoNIF
                dgvListadoAlumnos.ClearSelection()

            Else
                'Cargo el DatagridView
                dgvListadoAlumnos.AutoGenerateColumns = False

                dgvListadoAlumnos.DataSource = dtAlumnos
                dgvListadoAlumnos.ClearSelection()
            End If

            



        Catch ex As Exception
            MsgBox("Se ha producido la siguiente excepción: " + vbCrLf + _
                    ex.Message, CType(MsgBoxStyle.OkOnly + MsgBoxStyle.Critical, MsgBoxStyle), "Error...")
        End Try
    End Sub
    Private Sub EstadoInicialFormulario()
        Try

            Call CargarComboCursos()

            If FormularioInvocado Then
                If ModoFormulario = "PRF" Then
                    cboCursos.SelectedValue = curso
                    cboCursos.Enabled = False
                End If
                lblDobleClicNif.Visible = False
            Else
                Call DesHabilitarBotonesOperacionBarra()
                cboCursos.Enabled = True
                lblDobleClicNif.Visible = True
            End If

            Call OcultarBotonesGuardar()

            dgvListadoAlumnos.ReadOnly = True
            dgvListadoAlumnos.Enabled = False

        Catch ex As Exception
            MsgBox("Se ha producido la siguiente excepción: " + vbCrLf + _
                    ex.Message, CType(MsgBoxStyle.OkOnly + MsgBoxStyle.Critical, MsgBoxStyle), "Error...")
        End Try
    End Sub

    Private Sub frmCrudCalificaciones_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            Call EstiloDataGrid(dgvListadoAlumnos)
            Call EstadoInicialFormulario()
        Catch ex As Exception
            MsgBox("Se ha producido la siguiente excepción: " + vbCrLf + _
                    ex.Message, CType(MsgBoxStyle.OkOnly + MsgBoxStyle.Critical, MsgBoxStyle), "Error...")
        End Try
    End Sub

    Private Sub cboCursos_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboCursos.SelectedIndexChanged
        Try
            Dim curso As String
            curso = CStr(cboCursos.SelectedValue)
            If curso <> "SELE" Then
                Call CargarDataGridCalificaciones(curso)
                If ModoFormulario <> "ALM" Then
                    Call HabilitarBotonesOperacionBarra()
                Else
                    If dgvListadoAlumnos.RowCount > 0 Then
                        dgvListadoAlumnos.Enabled = True
                    Else
                        dgvListadoAlumnos.Enabled = False
                    End If
                End If
            Else
                dgvListadoAlumnos.DataSource = Nothing
                Call DesHabilitarBotonesOperacionBarra()
            End If
        Catch ex As Exception
            MsgBox("Se ha producido la siguiente excepción: " + vbCrLf + _
                    ex.Message, CType(MsgBoxStyle.OkOnly + MsgBoxStyle.Critical, MsgBoxStyle), "Error...")
        End Try
    End Sub

    Private Sub tlbEditar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tlbEditar.Click
        Try
            dgvListadoAlumnos.Enabled = True
            dgvListadoAlumnos.ReadOnly = False
            dgvListadoAlumnos.CurrentRow.Cells("clnNif").ReadOnly = True
            dgvListadoAlumnos.CurrentRow.Cells("clnNombre").ReadOnly = True
            dgvListadoAlumnos.CurrentRow.Cells("clnCalificacion").ReadOnly = False
            dgvListadoAlumnos.CurrentRow.Cells("clnObservaciones").ReadOnly = False

            Call DesHabilitarBotonesOperacionBarra()
            Call MostrarBotonesGuardar()

            cboCursos.Enabled = False

        Catch ex As Exception
            MsgBox("Se ha producido la siguiente excepción: " + vbCrLf + _
                    ex.Message, CType(MsgBoxStyle.OkOnly + MsgBoxStyle.Critical, MsgBoxStyle), "Error...")
        End Try
    End Sub

    Private Sub dgvListadoAlumnos_CellBeginEdit(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellCancelEventArgs) Handles dgvListadoAlumnos.CellBeginEdit
        Call OcultarBotonesGuardar()
    End Sub

    Private Sub dgvListadoAlumnos_CellDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvListadoAlumnos.CellDoubleClick
        Try
            If ModoFormulario <> "ALM" Then
                If e.RowIndex >= 0 Then
                    If dgvListadoAlumnos.Columns(e.ColumnIndex).Name.ToString = "clnNif" Then
                        'Si pincho en la columna NIF y el combo esta habilitado
                        If cboCursos.Enabled Then
                            Dim nif As String = CStr(dgvListadoAlumnos.Rows(e.RowIndex).Cells("clnNIF").Value)
                            Using VarFrmPersonas As New frmCrudPersonas(nif, True)
                                Dim curso As String
                                curso = CStr(cboCursos.SelectedValue)
                                Call VarFrmPersonas.ProcModoFormulario("ALM")
                                VarFrmPersonas.ShowDialog()
                                Call CargarDataGridCalificaciones(curso)
                            End Using
                        End If
                    End If
                End If
            End If
        Catch ex As Exception
            MsgBox("Se ha producido la siguiente excepción: " + vbCrLf + _
                    ex.Message, CType(MsgBoxStyle.OkOnly + MsgBoxStyle.Critical, MsgBoxStyle), "Error...")
        End Try
    End Sub


    Private Sub dgvListadoAlumnos_CellEndEdit(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvListadoAlumnos.CellEndEdit
        Try
            'Clear the row error in case the user presses ESC.   
            dgvListadoAlumnos.Rows(e.RowIndex).ErrorText = String.Empty
            dgvListadoAlumnos.RowHeadersVisible = False
            Call MostrarBotonesGuardar()
        Catch ex As Exception
            MsgBox("Se ha producido la siguiente excepción: " + vbCrLf + _
                    ex.Message, CType(MsgBoxStyle.OkOnly + MsgBoxStyle.Critical, MsgBoxStyle), "Error...")
        End Try
    End Sub

    Private Sub dgvListadoAlumnos_CellValidating(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellValidatingEventArgs) Handles dgvListadoAlumnos.CellValidating
        Try
            If dgvListadoAlumnos.Columns(e.ColumnIndex).Name = "clnCalificacion" Then
                If (e.FormattedValue.ToString) = String.Empty Then
                    dgvListadoAlumnos.Rows(e.RowIndex).ErrorText = "Debe insertar un numero del 0 al 10"
                Else
                    If IsNumeric(e.FormattedValue) Then
                        Dim celda As Integer
                        celda = CInt(e.FormattedValue)
                        If Not ((celda >= 0) And (celda <= 10)) Then
                            dgvListadoAlumnos.Rows(e.RowIndex).ErrorText = "El numero debe estar comprendido entre 0 y 10"
                            dgvListadoAlumnos.RowHeadersVisible = True
                            e.Cancel = True
                        End If
                    Else
                        dgvListadoAlumnos.Rows(e.RowIndex).ErrorText = "Debe introducir un numero entre 0 y 10"
                        dgvListadoAlumnos.RowHeadersVisible = True
                        e.Cancel = True
                    End If
                End If
            End If
        Catch ex As Exception
            MsgBox("Se ha producido la siguiente excepción: " + vbCrLf + _
                    ex.Message, CType(MsgBoxStyle.OkOnly + MsgBoxStyle.Critical, MsgBoxStyle), "Error...")
        End Try
    End Sub

    Private Sub tlbCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tlbCancelar.Click
        If FormularioInvocado Then
            Me.Close()
        Else
            Call EstadoInicialFormulario()
        End If
    End Sub

    Private Sub tlbGuardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tlbGuardar.Click
        Try
            Dim i As Integer = 0
            Dim calif As String = String.Empty

            If calificacion Is Nothing Then
                calificacion = New EntidadCalificacion
            End If


            For i = 0 To dgvListadoAlumnos.RowCount - 1

                'Guardo en la entidad los valores del Grid
                calificacion.CodigoMatricula = dgvListadoAlumnos.Rows(i).Cells("clnCodigoMatricula").Value.ToString
                If dgvListadoAlumnos.Rows(i).Cells("clnCalificacion").Value Is DBNull.Value Then
                    calificacion.Calificacion = Nothing
                Else
                    If CStr(dgvListadoAlumnos.Rows(i).Cells("clnCalificacion").Value) = String.Empty Then
                        calificacion.Calificacion = Nothing
                    Else
                        calificacion.Calificacion = CDec(dgvListadoAlumnos.Rows(i).Cells("clnCalificacion").Value)
                    End If
                End If
                If dgvListadoAlumnos.Rows(i).Cells("clnObservaciones").Value.ToString = String.Empty Then
                    calificacion.Observaciones = Nothing
                Else
                    calificacion.Observaciones = dgvListadoAlumnos.Rows(i).Cells("clnObservaciones").Value.ToString
                End If

                'Guardo la entidad
                Call CalificacionesBO.GuardarCalificacion(calificacion)

            Next
            If FormularioInvocado Then
                Me.Close()
            Else
                Call EstadoInicialFormulario()
            End If
        Catch ex As Exception
            MsgBox("Se ha producido la siguiente excepción: " + vbCrLf + _
                    ex.Message, CType(MsgBoxStyle.OkOnly + MsgBoxStyle.Critical, MsgBoxStyle), "Error...")
        End Try
    End Sub

    Private Sub tlbBuscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tlbBuscar.Click
        Try
            If dgvListadoAlumnos.RowCount > 0 Then
                Dim cadena As String
                Dim encontrado As Boolean

                cadena = InputBox("Introduzca NIF a buscar: ", "Buscar NIF", "")

                encontrado = BuscarEnDataGrid(cadena, "clnNif", dgvListadoAlumnos)

                If Not encontrado Then
                    MsgBox("No se encontro el NIF solicitado.", CType(MsgBoxStyle.OkOnly + MsgBoxStyle.Exclamation, MsgBoxStyle), "No encontrado...")
                End If
            Else
                MsgBox("No existen registros que buscar.", CType(MsgBoxStyle.Exclamation + vbOKOnly, MsgBoxStyle), "No existen registros...")
                Call EstadoInicialFormulario()
            End If
        Catch ex As Exception
            MsgBox("Se ha producido la siguiente excepción: " + vbCrLf + _
                    ex.Message, CType(MsgBoxStyle.OkOnly + MsgBoxStyle.Critical, MsgBoxStyle), "Error...")
        End Try
    End Sub

  
End Class