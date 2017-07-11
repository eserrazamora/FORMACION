Imports Formacion.CapaDeNegocio
Imports Formacion.Entidades
Public Class frmAsistenciasAlumno

    Private asistencia As EntidadAsistencia
    Private FormularioInvocado As Boolean = False  'Si esta a true indica que el formulario ha sido llamado
    Private curso As String = String.Empty

    Public Sub New(ByVal codigo As String, ByVal invocado As Boolean)

        ' Llamada necesaria para el diseñador.
        InitializeComponent()

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
        FormularioInvocado = invocado
        curso = codigo
    End Sub
    Private Sub BorrarCajasTexto()
        txtFechaInicio.Text = String.Empty
        txtFechaFin.Text = String.Empty
    End Sub
    Private Sub HabilitarBotonesOperacionBarra()
        tlbEditar.Enabled = True
    End Sub

    Private Sub DesHabilitarBotonesOperacionBarra()
        tlbEditar.Enabled = False
    End Sub

    Private Sub MostrarBotonesGuardar()
        tlbGuardar.Visible = True
        tlbCancelar.Visible = True
    End Sub

    Private Sub OcultarBotonesGuardar()
        tlbGuardar.Visible = False
        tlbCancelar.Visible = False
    End Sub
    Private Sub HabilitarDataGridView()
        dgvListadoCursos.Enabled = True
        dgvListadoCursos.ReadOnly = False

        dgvListadoCursos.Columns("clnNombre").ReadOnly = True
        dgvListadoCursos.Columns("clnFecha").ReadOnly = True
        dgvListadoCursos.Columns("clnAsistencia").ReadOnly = False

    End Sub
    Private Sub DesHabilitarDataGridView()
        dgvListadoCursos.Enabled = False
        dgvListadoCursos.ReadOnly = True
    End Sub
    Public Sub CargarComboCursos()
        Try
            Dim dtCursos As DataTable
            dtCursos = MatriculasBO.CargarCursosEnDatatable

            ' Añadimos una nueva fila al objeto DataTable
            Dim row As DataRow = dtCursos.NewRow

            ' Establecemos el valor del campo Nombre
            row("InfoCurso") = "<Seleccionar>"

            ' Insertamos la fila en la primera posición
            dtCursos.Rows.InsertAt(row, 0)

            cboCursos.DisplayMember = "InfoCurso"
            cboCursos.DataSource = dtCursos
        Catch ex As Exception
            MsgBox("Se ha producido la siguiente excepción: " + vbCrLf + _
                    ex.Message, CType(MsgBoxStyle.OkOnly + MsgBoxStyle.Critical, MsgBoxStyle), "Error...")
        End Try

    End Sub
    Private Sub CargarDataGridAlumnos(ByVal codigocurso As String, ByVal fecha As Date)
        Try
            Dim dtAlumnos As DataTable

            dtAlumnos = AsistenciasBO.CargarAsistenciasAlumnos(codigocurso, fecha)

            'Cargo Todas las personas de un curso en Datagrid
            dgvListadoCursos.AutoGenerateColumns = False
            dgvListadoCursos.DataSource = dtAlumnos
            dgvListadoCursos.ClearSelection()

            'Hago operaciones segun el Datagrid tenga datos o no
            If dgvListadoCursos.Rows.Count > 0 Then
                Call HabilitarBotonesOperacionBarra()
                Call OcultarBotonesGuardar()
            Else
                Call DesHabilitarBotonesOperacionBarra()
                Call OcultarBotonesGuardar()
            End If
        Catch ex As Exception
            MsgBox("Se ha producido la siguiente excepción: " + vbCrLf + _
                    ex.Message, CType(MsgBoxStyle.OkOnly + MsgBoxStyle.Critical, MsgBoxStyle), "Error...")
        End Try
    End Sub
    Private Sub EstadoInicialFormulario()
        Call BorrarCajasTexto()

        'Cargo el combo de cursos con los cursos disponibles
        Call CargarComboCursos()

        If FormularioInvocado Then

            'Dim row As DataRow
            Dim i As Integer

            'Empiezo en 1 porque el 0 es el seleccionar
            For i = 1 To cboCursos.Items.Count - 1
                Dim rowView As DataRowView = TryCast(cboCursos.Items(i), DataRowView)

                If (rowView("CodigoCurso").ToString()) = curso Then
                    Exit For
                End If

            Next

            If (i <= cboCursos.Items.Count - 1) Then
                ' Si existe el elemento, lo seleccionamos.
                cboCursos.SelectedIndex = i
            End If

            Call HabilitarBotonesOperacionBarra()
            cboCursos.Enabled = False
        Else
            Call DesHabilitarBotonesOperacionBarra()
            cboCursos.Enabled = True
        End If

        Call OcultarBotonesGuardar()

        chkSeleccionarTodos.Enabled = False
        dtpFechaAsistencia.Enabled = True
        chkSeleccionarTodos.Checked = False

        Call DesHabilitarDataGridView()


    End Sub
    Private Sub frmAsistenciasAlumno_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Call EstiloDataGrid(dgvListadoCursos)
        Call EstadoInicialFormulario()

    End Sub


    Private Sub cboCursos_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboCursos.SelectedIndexChanged
        Try
            Dim fechainicio As String = String.Empty
            Dim fechafin As String = String.Empty
            Dim codigocurso As String = String.Empty


            If cboCursos.Text = "<Seleccionar>" Then
                Call BorrarCajasTexto()
                dtpFechaAsistencia.MinDate = New Date(1900, 1, 1)
                dtpFechaAsistencia.MaxDate = New Date(2500, 1, 1)
                dtpFechaAsistencia.Value = Date.Today
                dgvListadoCursos.DataSource = Nothing

            Else
                Dim rowView As DataRowView = TryCast(cboCursos.SelectedValue, DataRowView)

                'Cargo Fecha de Inicio y Fecha de Fin del curso en las cajas y variables auxiliares
                fechainicio = CDate((rowView("FechaInicio"))).ToShortDateString
                fechafin = CDate((rowView("FechaFin"))).ToShortDateString

                txtFechaInicio.Text = fechainicio
                txtFechaFin.Text = fechafin

                'Establezco las propiedads MinValue y MaxValue del DateTimePicker
                dtpFechaAsistencia.MinDate = Convert.ToDateTime(fechainicio)
                dtpFechaAsistencia.MaxDate = Convert.ToDateTime(fechafin)

                'Cargo el Listado de Alumnos del curso
                codigocurso = Convert.ToString(rowView("CodigoCurso"))

                Call CargarDataGridAlumnos(codigocurso, dtpFechaAsistencia.Value)

            End If
        Catch ex As Exception
            MsgBox("Se ha producido la siguiente excepción: " + vbCrLf + _
                    ex.Message, CType(MsgBoxStyle.OkOnly + MsgBoxStyle.Critical, MsgBoxStyle), "Error...")
        End Try
    End Sub

    Private Sub tlbEditar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tlbEditar.Click

        cboCursos.Enabled = False
        dtpFechaAsistencia.Enabled = False

        chkSeleccionarTodos.Enabled = True
        Call DesHabilitarBotonesOperacionBarra()
        Call MostrarBotonesGuardar()

        Call HabilitarDataGridView()

    End Sub

    Private Sub tlbGuardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tlbGuardar.Click
        Try
            Dim i As Integer = 0

            If asistencia Is Nothing Then
                asistencia = New EntidadAsistencia
            End If


            For i = 0 To dgvListadoCursos.RowCount - 1

                'Guardo en la entidad los valores del Grid
                asistencia.CodigoMatricula = CStr(dgvListadoCursos.Rows(i).Cells("clnCodigoMatricula").Value)
                asistencia.Fecha = CDate(dgvListadoCursos.Rows(i).Cells("clnFecha").Value)
                If chkSeleccionarTodos.Checked Then
                    asistencia.Asistio = CChar("S")
                Else
                    asistencia.Asistio = CChar(dgvListadoCursos.Rows(i).Cells("clnAsistencia").Value)
                End If


                'Guardo la entidad
                Call AsistenciasBO.Guardar(asistencia)

            Next

            If FormularioInvocado Then
                Me.Close()
            Else
                'Pongo el formulario en su estado inicial
                Call EstadoInicialFormulario()
            End If
        Catch ex As Exception
            MsgBox("Se ha producido la siguiente excepción: " + vbCrLf + _
                    ex.Message, CType(MsgBoxStyle.OkOnly + MsgBoxStyle.Critical, MsgBoxStyle), "Error...")
        End Try
    End Sub
    Private Sub tlbCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tlbCancelar.Click
        Try
            If FormularioInvocado Then
                Me.Close()
            Else

                Dim codigocurso As String = String.Empty
                Dim rowView As DataRowView = TryCast(cboCursos.SelectedValue, DataRowView)

                Call HabilitarBotonesOperacionBarra()
                Call OcultarBotonesGuardar()

                cboCursos.Enabled = True
                dtpFechaAsistencia.Enabled = True

                Call DesHabilitarDataGridView()

                'Cargo el Listado de Alumnos del curso
                codigocurso = Convert.ToString(rowView("CodigoCurso"))

                Call CargarDataGridAlumnos(codigocurso, dtpFechaAsistencia.Value)
                dgvListadoCursos.Columns("clnAsistencia").ReadOnly = True
            End If
        Catch ex As Exception
            MsgBox("Se ha producido la siguiente excepción: " + vbCrLf + _
                    ex.Message, CType(MsgBoxStyle.OkOnly + MsgBoxStyle.Critical, MsgBoxStyle), "Error...")
        End Try
    End Sub

    Private Sub chkSeleccionarTodos_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkSeleccionarTodos.CheckedChanged
        Try
            For Each row As DataGridViewRow In dgvListadoCursos.Rows
                row.Cells("clnAsistencia").Value = chkSeleccionarTodos.Checked
            Next
        Catch ex As Exception
            MsgBox("Se ha producido la siguiente excepción: " + vbCrLf + _
                    ex.Message, CType(MsgBoxStyle.OkOnly + MsgBoxStyle.Critical, MsgBoxStyle), "Error...")
        End Try
    End Sub

    Private Sub dtpFechaAsistencia_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dtpFechaAsistencia.ValueChanged
        Try
            Dim rowView As DataRowView = TryCast(cboCursos.SelectedValue, DataRowView)
            Dim codigocurso As String = String.Empty

            'Cargo el Listado de Alumnos del curso
            codigocurso = Convert.ToString(rowView("CodigoCurso"))

            Call CargarDataGridAlumnos(codigocurso, dtpFechaAsistencia.Value)
        Catch ex As Exception
            MsgBox("Se ha producido la siguiente excepción: " + vbCrLf + _
                    ex.Message, CType(MsgBoxStyle.OkOnly + MsgBoxStyle.Critical, MsgBoxStyle), "Error...")
        End Try

    End Sub

   

    Private Sub dgvListadoCursos_CurrentCellDirtyStateChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles dgvListadoCursos.CurrentCellDirtyStateChanged
        If dgvListadoCursos.IsCurrentCellDirty Then
            dgvListadoCursos.CommitEdit(DataGridViewDataErrorContexts.Commit)
        End If
    End Sub

    
End Class