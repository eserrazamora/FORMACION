<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCrudCursos
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmCrudCursos))
        Me.BarraHerramientas = New System.Windows.Forms.ToolStrip()
        Me.tlbNuevo = New System.Windows.Forms.ToolStripButton()
        Me.tlbEditar = New System.Windows.Forms.ToolStripButton()
        Me.tlbBorrar = New System.Windows.Forms.ToolStripButton()
        Me.tlbBuscar = New System.Windows.Forms.ToolStripButton()
        Me.tlbGuardar = New System.Windows.Forms.ToolStripButton()
        Me.tlbActualizar = New System.Windows.Forms.ToolStripButton()
        Me.tlbCancelar = New System.Windows.Forms.ToolStripButton()
        Me.btnSeleccionarAlumnos = New System.Windows.Forms.Button()
        Me.dgvListadoCursos = New System.Windows.Forms.DataGridView()
        Me.clnCodigoCurso = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.clnNombreCurso = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.clnCodigoTipoCurso = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.clnNombreTipoCurso = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.clnDuracionCurso = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.clnFechaInicioCurso = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.clnFechaFinCurso = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.clnCosteCurso = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.clnCodigoAula = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.clnNombreAula = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.clnObservaciones = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.btnSeleccionarProfesores = New System.Windows.Forms.Button()
        Me.lblAlumnos = New System.Windows.Forms.Label()
        Me.lblProfesores = New System.Windows.Forms.Label()
        Me.lstAlumnos = New System.Windows.Forms.ListBox()
        Me.lstProfesores = New System.Windows.Forms.ListBox()
        Me.lblFechaFin = New System.Windows.Forms.Label()
        Me.lblFechaInicio = New System.Windows.Forms.Label()
        Me.lblObservaciones = New System.Windows.Forms.Label()
        Me.txtObservaciones = New System.Windows.Forms.TextBox()
        Me.lblAula = New System.Windows.Forms.Label()
        Me.cboAulas = New System.Windows.Forms.ComboBox()
        Me.lblTipoCurso = New System.Windows.Forms.Label()
        Me.cboTiposCursos = New System.Windows.Forms.ComboBox()
        Me.lblDuracion = New System.Windows.Forms.Label()
        Me.txtDuracion = New System.Windows.Forms.TextBox()
        Me.lblCoste = New System.Windows.Forms.Label()
        Me.txtCoste = New System.Windows.Forms.TextBox()
        Me.lblNombreCurso = New System.Windows.Forms.Label()
        Me.txtNombreCurso = New System.Windows.Forms.TextBox()
        Me.lblCodigo = New System.Windows.Forms.Label()
        Me.txtCodigo = New System.Windows.Forms.TextBox()
        Me.dtpFechaInicio = New System.Windows.Forms.DateTimePicker()
        Me.dtpFechaFin = New System.Windows.Forms.DateTimePicker()
        Me.btnBuscarCodigo = New System.Windows.Forms.Button()
        Me.lblCalificaciones = New System.Windows.Forms.Label()
        Me.lblAsistencia = New System.Windows.Forms.Label()
        Me.btnCalificaciones = New System.Windows.Forms.Button()
        Me.btnAsistencia = New System.Windows.Forms.Button()
        Me.BarraHerramientas.SuspendLayout()
        CType(Me.dgvListadoCursos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BarraHerramientas
        '
        Me.BarraHerramientas.BackColor = System.Drawing.Color.DarkOliveGreen
        Me.BarraHerramientas.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.BarraHerramientas.ImageScalingSize = New System.Drawing.Size(40, 40)
        Me.BarraHerramientas.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tlbNuevo, Me.tlbEditar, Me.tlbBorrar, Me.tlbBuscar, Me.tlbGuardar, Me.tlbActualizar, Me.tlbCancelar})
        Me.BarraHerramientas.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow
        Me.BarraHerramientas.Location = New System.Drawing.Point(0, 0)
        Me.BarraHerramientas.Name = "BarraHerramientas"
        Me.BarraHerramientas.Size = New System.Drawing.Size(767, 66)
        Me.BarraHerramientas.TabIndex = 137
        Me.BarraHerramientas.Text = "ToolStrip1"
        '
        'tlbNuevo
        '
        Me.tlbNuevo.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tlbNuevo.ForeColor = System.Drawing.Color.Gold
        Me.tlbNuevo.Image = Global.Formacion.My.Resources.Resources.Nuevo
        Me.tlbNuevo.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tlbNuevo.Margin = New System.Windows.Forms.Padding(2)
        Me.tlbNuevo.Name = "tlbNuevo"
        Me.tlbNuevo.Size = New System.Drawing.Size(53, 62)
        Me.tlbNuevo.Text = "Nuevo"
        Me.tlbNuevo.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.tlbNuevo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'tlbEditar
        '
        Me.tlbEditar.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tlbEditar.ForeColor = System.Drawing.Color.Gold
        Me.tlbEditar.Image = Global.Formacion.My.Resources.Resources.Editar
        Me.tlbEditar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tlbEditar.Margin = New System.Windows.Forms.Padding(2)
        Me.tlbEditar.Name = "tlbEditar"
        Me.tlbEditar.Size = New System.Drawing.Size(48, 62)
        Me.tlbEditar.Text = "Editar"
        Me.tlbEditar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.tlbEditar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'tlbBorrar
        '
        Me.tlbBorrar.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tlbBorrar.ForeColor = System.Drawing.Color.Gold
        Me.tlbBorrar.Image = Global.Formacion.My.Resources.Resources.Borrar
        Me.tlbBorrar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tlbBorrar.Margin = New System.Windows.Forms.Padding(2)
        Me.tlbBorrar.Name = "tlbBorrar"
        Me.tlbBorrar.Size = New System.Drawing.Size(50, 62)
        Me.tlbBorrar.Text = "Borrar"
        Me.tlbBorrar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.tlbBorrar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'tlbBuscar
        '
        Me.tlbBuscar.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tlbBuscar.ForeColor = System.Drawing.Color.Gold
        Me.tlbBuscar.Image = Global.Formacion.My.Resources.Resources.Buscar
        Me.tlbBuscar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tlbBuscar.Margin = New System.Windows.Forms.Padding(2)
        Me.tlbBuscar.Name = "tlbBuscar"
        Me.tlbBuscar.Size = New System.Drawing.Size(52, 62)
        Me.tlbBuscar.Text = "Buscar"
        Me.tlbBuscar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.tlbBuscar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'tlbGuardar
        '
        Me.tlbGuardar.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tlbGuardar.ForeColor = System.Drawing.Color.Gold
        Me.tlbGuardar.Image = Global.Formacion.My.Resources.Resources.Guardar
        Me.tlbGuardar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tlbGuardar.Margin = New System.Windows.Forms.Padding(395, 2, 2, 2)
        Me.tlbGuardar.Name = "tlbGuardar"
        Me.tlbGuardar.Size = New System.Drawing.Size(61, 62)
        Me.tlbGuardar.Text = "Guardar"
        Me.tlbGuardar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.tlbGuardar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'tlbActualizar
        '
        Me.tlbActualizar.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tlbActualizar.ForeColor = System.Drawing.Color.Gold
        Me.tlbActualizar.Image = Global.Formacion.My.Resources.Resources.Actualizar
        Me.tlbActualizar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tlbActualizar.Margin = New System.Windows.Forms.Padding(395, 2, 2, 2)
        Me.tlbActualizar.Name = "tlbActualizar"
        Me.tlbActualizar.Size = New System.Drawing.Size(73, 62)
        Me.tlbActualizar.Text = "Actualizar"
        Me.tlbActualizar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.tlbActualizar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'tlbCancelar
        '
        Me.tlbCancelar.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tlbCancelar.ForeColor = System.Drawing.Color.Gold
        Me.tlbCancelar.Image = Global.Formacion.My.Resources.Resources.Cancelar
        Me.tlbCancelar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tlbCancelar.Name = "tlbCancelar"
        Me.tlbCancelar.Size = New System.Drawing.Size(65, 62)
        Me.tlbCancelar.Text = "Cancelar"
        Me.tlbCancelar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'btnSeleccionarAlumnos
        '
        Me.btnSeleccionarAlumnos.ForeColor = System.Drawing.Color.Black
        Me.btnSeleccionarAlumnos.Location = New System.Drawing.Point(382, 316)
        Me.btnSeleccionarAlumnos.Name = "btnSeleccionarAlumnos"
        Me.btnSeleccionarAlumnos.Size = New System.Drawing.Size(176, 27)
        Me.btnSeleccionarAlumnos.TabIndex = 150
        Me.btnSeleccionarAlumnos.Text = "Seleccionar Alumnos"
        Me.btnSeleccionarAlumnos.UseVisualStyleBackColor = True
        '
        'dgvListadoCursos
        '
        Me.dgvListadoCursos.AllowUserToAddRows = False
        Me.dgvListadoCursos.AllowUserToDeleteRows = False
        Me.dgvListadoCursos.AllowUserToResizeColumns = False
        Me.dgvListadoCursos.AllowUserToResizeRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.Silver
        Me.dgvListadoCursos.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvListadoCursos.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.dgvListadoCursos.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.DarkOliveGreen
        DataGridViewCellStyle2.Font = New System.Drawing.Font("MS Reference Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.Gold
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvListadoCursos.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.dgvListadoCursos.ColumnHeadersHeight = 21
        Me.dgvListadoCursos.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.clnCodigoCurso, Me.clnNombreCurso, Me.clnCodigoTipoCurso, Me.clnNombreTipoCurso, Me.clnDuracionCurso, Me.clnFechaInicioCurso, Me.clnFechaFinCurso, Me.clnCosteCurso, Me.clnCodigoAula, Me.clnNombreAula, Me.clnObservaciones})
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle6.Font = New System.Drawing.Font("MS Reference Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle6.ForeColor = System.Drawing.Color.Gold
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.Yellow
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvListadoCursos.DefaultCellStyle = DataGridViewCellStyle6
        Me.dgvListadoCursos.EnableHeadersVisualStyles = False
        Me.dgvListadoCursos.GridColor = System.Drawing.Color.Silver
        Me.dgvListadoCursos.Location = New System.Drawing.Point(12, 465)
        Me.dgvListadoCursos.MultiSelect = False
        Me.dgvListadoCursos.Name = "dgvListadoCursos"
        Me.dgvListadoCursos.ReadOnly = True
        Me.dgvListadoCursos.RowHeadersVisible = False
        DataGridViewCellStyle7.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle7.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.Yellow
        DataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.Black
        Me.dgvListadoCursos.RowsDefaultCellStyle = DataGridViewCellStyle7
        Me.dgvListadoCursos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvListadoCursos.Size = New System.Drawing.Size(743, 178)
        Me.dgvListadoCursos.TabIndex = 154
        '
        'clnCodigoCurso
        '
        Me.clnCodigoCurso.DataPropertyName = "CodigoCurso"
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.clnCodigoCurso.DefaultCellStyle = DataGridViewCellStyle3
        Me.clnCodigoCurso.HeaderText = "CODIGO"
        Me.clnCodigoCurso.Name = "clnCodigoCurso"
        Me.clnCodigoCurso.ReadOnly = True
        Me.clnCodigoCurso.Width = 70
        '
        'clnNombreCurso
        '
        Me.clnNombreCurso.DataPropertyName = "Nombre"
        Me.clnNombreCurso.HeaderText = "NOMBRE"
        Me.clnNombreCurso.Name = "clnNombreCurso"
        Me.clnNombreCurso.ReadOnly = True
        Me.clnNombreCurso.Width = 230
        '
        'clnCodigoTipoCurso
        '
        Me.clnCodigoTipoCurso.DataPropertyName = "Tipo"
        Me.clnCodigoTipoCurso.HeaderText = "CODIGOTIPO"
        Me.clnCodigoTipoCurso.Name = "clnCodigoTipoCurso"
        Me.clnCodigoTipoCurso.ReadOnly = True
        Me.clnCodigoTipoCurso.Visible = False
        '
        'clnNombreTipoCurso
        '
        Me.clnNombreTipoCurso.DataPropertyName = "TipoNombre"
        Me.clnNombreTipoCurso.HeaderText = "TIPO"
        Me.clnNombreTipoCurso.Name = "clnNombreTipoCurso"
        Me.clnNombreTipoCurso.ReadOnly = True
        Me.clnNombreTipoCurso.Width = 130
        '
        'clnDuracionCurso
        '
        Me.clnDuracionCurso.DataPropertyName = "Duracion"
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.clnDuracionCurso.DefaultCellStyle = DataGridViewCellStyle4
        Me.clnDuracionCurso.HeaderText = "HORAS"
        Me.clnDuracionCurso.Name = "clnDuracionCurso"
        Me.clnDuracionCurso.ReadOnly = True
        Me.clnDuracionCurso.Width = 75
        '
        'clnFechaInicioCurso
        '
        Me.clnFechaInicioCurso.DataPropertyName = "FechaInicio"
        Me.clnFechaInicioCurso.HeaderText = "F.INICIO"
        Me.clnFechaInicioCurso.Name = "clnFechaInicioCurso"
        Me.clnFechaInicioCurso.ReadOnly = True
        Me.clnFechaInicioCurso.Width = 90
        '
        'clnFechaFinCurso
        '
        Me.clnFechaFinCurso.DataPropertyName = "FechaFin"
        Me.clnFechaFinCurso.HeaderText = "F.FIN"
        Me.clnFechaFinCurso.Name = "clnFechaFinCurso"
        Me.clnFechaFinCurso.ReadOnly = True
        Me.clnFechaFinCurso.Width = 90
        '
        'clnCosteCurso
        '
        Me.clnCosteCurso.DataPropertyName = "Coste"
        DataGridViewCellStyle5.Format = "C2"
        DataGridViewCellStyle5.NullValue = Nothing
        Me.clnCosteCurso.DefaultCellStyle = DataGridViewCellStyle5
        Me.clnCosteCurso.HeaderText = "COSTE"
        Me.clnCosteCurso.Name = "clnCosteCurso"
        Me.clnCosteCurso.ReadOnly = True
        Me.clnCosteCurso.Width = 80
        '
        'clnCodigoAula
        '
        Me.clnCodigoAula.DataPropertyName = "Aula"
        Me.clnCodigoAula.HeaderText = "CODIGOAULA"
        Me.clnCodigoAula.Name = "clnCodigoAula"
        Me.clnCodigoAula.ReadOnly = True
        Me.clnCodigoAula.Visible = False
        '
        'clnNombreAula
        '
        Me.clnNombreAula.DataPropertyName = "AulaNombre"
        Me.clnNombreAula.HeaderText = "AULA"
        Me.clnNombreAula.Name = "clnNombreAula"
        Me.clnNombreAula.ReadOnly = True
        Me.clnNombreAula.Width = 150
        '
        'clnObservaciones
        '
        Me.clnObservaciones.DataPropertyName = "Observaciones"
        Me.clnObservaciones.HeaderText = "OBSERVACIONES"
        Me.clnObservaciones.Name = "clnObservaciones"
        Me.clnObservaciones.ReadOnly = True
        Me.clnObservaciones.Width = 200
        '
        'btnSeleccionarProfesores
        '
        Me.btnSeleccionarProfesores.ForeColor = System.Drawing.Color.Black
        Me.btnSeleccionarProfesores.Location = New System.Drawing.Point(53, 317)
        Me.btnSeleccionarProfesores.Name = "btnSeleccionarProfesores"
        Me.btnSeleccionarProfesores.Size = New System.Drawing.Size(176, 27)
        Me.btnSeleccionarProfesores.TabIndex = 149
        Me.btnSeleccionarProfesores.Text = "Seleccionar Profesores"
        Me.btnSeleccionarProfesores.UseVisualStyleBackColor = True
        '
        'lblAlumnos
        '
        Me.lblAlumnos.AutoSize = True
        Me.lblAlumnos.Font = New System.Drawing.Font("MS Reference Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAlumnos.ForeColor = System.Drawing.Color.Gold
        Me.lblAlumnos.Location = New System.Drawing.Point(317, 184)
        Me.lblAlumnos.Name = "lblAlumnos"
        Me.lblAlumnos.Size = New System.Drawing.Size(61, 15)
        Me.lblAlumnos.TabIndex = 165
        Me.lblAlumnos.Text = "Alumnos:"
        '
        'lblProfesores
        '
        Me.lblProfesores.AutoSize = True
        Me.lblProfesores.Font = New System.Drawing.Font("MS Reference Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblProfesores.ForeColor = System.Drawing.Color.Gold
        Me.lblProfesores.Location = New System.Drawing.Point(12, 184)
        Me.lblProfesores.Name = "lblProfesores"
        Me.lblProfesores.Size = New System.Drawing.Size(73, 15)
        Me.lblProfesores.TabIndex = 164
        Me.lblProfesores.Text = "Profesores:"
        '
        'lstAlumnos
        '
        Me.lstAlumnos.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.lstAlumnos.ForeColor = System.Drawing.Color.White
        Me.lstAlumnos.FormattingEnabled = True
        Me.lstAlumnos.Location = New System.Drawing.Point(320, 201)
        Me.lstAlumnos.Name = "lstAlumnos"
        Me.lstAlumnos.SelectionMode = System.Windows.Forms.SelectionMode.None
        Me.lstAlumnos.Size = New System.Drawing.Size(294, 108)
        Me.lstAlumnos.TabIndex = 148
        '
        'lstProfesores
        '
        Me.lstProfesores.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.lstProfesores.ForeColor = System.Drawing.Color.White
        Me.lstProfesores.FormattingEnabled = True
        Me.lstProfesores.Location = New System.Drawing.Point(12, 201)
        Me.lstProfesores.Name = "lstProfesores"
        Me.lstProfesores.SelectionMode = System.Windows.Forms.SelectionMode.None
        Me.lstProfesores.Size = New System.Drawing.Size(294, 108)
        Me.lstProfesores.TabIndex = 147
        '
        'lblFechaFin
        '
        Me.lblFechaFin.AutoSize = True
        Me.lblFechaFin.Font = New System.Drawing.Font("MS Reference Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFechaFin.ForeColor = System.Drawing.Color.Gold
        Me.lblFechaFin.Location = New System.Drawing.Point(249, 75)
        Me.lblFechaFin.Name = "lblFechaFin"
        Me.lblFechaFin.Size = New System.Drawing.Size(83, 15)
        Me.lblFechaFin.TabIndex = 163
        Me.lblFechaFin.Text = "Fecha de Fin:"
        '
        'lblFechaInicio
        '
        Me.lblFechaInicio.AutoSize = True
        Me.lblFechaInicio.Font = New System.Drawing.Font("MS Reference Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFechaInicio.ForeColor = System.Drawing.Color.Gold
        Me.lblFechaInicio.Location = New System.Drawing.Point(103, 75)
        Me.lblFechaInicio.Name = "lblFechaInicio"
        Me.lblFechaInicio.Size = New System.Drawing.Size(98, 15)
        Me.lblFechaInicio.TabIndex = 162
        Me.lblFechaInicio.Text = "Fecha de Inicio:"
        '
        'lblObservaciones
        '
        Me.lblObservaciones.AutoSize = True
        Me.lblObservaciones.Font = New System.Drawing.Font("MS Reference Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblObservaciones.ForeColor = System.Drawing.Color.Gold
        Me.lblObservaciones.Location = New System.Drawing.Point(8, 355)
        Me.lblObservaciones.Name = "lblObservaciones"
        Me.lblObservaciones.Size = New System.Drawing.Size(96, 15)
        Me.lblObservaciones.TabIndex = 161
        Me.lblObservaciones.Text = "Observaciones:"
        '
        'txtObservaciones
        '
        Me.txtObservaciones.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txtObservaciones.ForeColor = System.Drawing.Color.White
        Me.txtObservaciones.Location = New System.Drawing.Point(12, 373)
        Me.txtObservaciones.Multiline = True
        Me.txtObservaciones.Name = "txtObservaciones"
        Me.txtObservaciones.Size = New System.Drawing.Size(602, 81)
        Me.txtObservaciones.TabIndex = 151
        '
        'lblAula
        '
        Me.lblAula.AutoSize = True
        Me.lblAula.Font = New System.Drawing.Font("MS Reference Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAula.ForeColor = System.Drawing.Color.Gold
        Me.lblAula.Location = New System.Drawing.Point(413, 76)
        Me.lblAula.Name = "lblAula"
        Me.lblAula.Size = New System.Drawing.Size(37, 15)
        Me.lblAula.TabIndex = 160
        Me.lblAula.Text = "Aula:"
        Me.lblAula.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'cboAulas
        '
        Me.cboAulas.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.cboAulas.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboAulas.ForeColor = System.Drawing.Color.White
        Me.cboAulas.FormattingEnabled = True
        Me.cboAulas.Location = New System.Drawing.Point(416, 94)
        Me.cboAulas.Name = "cboAulas"
        Me.cboAulas.Size = New System.Drawing.Size(264, 21)
        Me.cboAulas.TabIndex = 142
        '
        'lblTipoCurso
        '
        Me.lblTipoCurso.AutoSize = True
        Me.lblTipoCurso.Font = New System.Drawing.Font("MS Reference Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTipoCurso.ForeColor = System.Drawing.Color.Gold
        Me.lblTipoCurso.Location = New System.Drawing.Point(413, 129)
        Me.lblTipoCurso.Name = "lblTipoCurso"
        Me.lblTipoCurso.Size = New System.Drawing.Size(92, 15)
        Me.lblTipoCurso.TabIndex = 159
        Me.lblTipoCurso.Text = "Tipo de Curso:"
        '
        'cboTiposCursos
        '
        Me.cboTiposCursos.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.cboTiposCursos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboTiposCursos.ForeColor = System.Drawing.Color.White
        Me.cboTiposCursos.FormattingEnabled = True
        Me.cboTiposCursos.Location = New System.Drawing.Point(416, 147)
        Me.cboTiposCursos.Name = "cboTiposCursos"
        Me.cboTiposCursos.Size = New System.Drawing.Size(264, 21)
        Me.cboTiposCursos.TabIndex = 145
        '
        'lblDuracion
        '
        Me.lblDuracion.AutoSize = True
        Me.lblDuracion.Font = New System.Drawing.Font("MS Reference Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDuracion.ForeColor = System.Drawing.Color.Gold
        Me.lblDuracion.Location = New System.Drawing.Point(692, 129)
        Me.lblDuracion.Name = "lblDuracion"
        Me.lblDuracion.Size = New System.Drawing.Size(63, 15)
        Me.lblDuracion.TabIndex = 158
        Me.lblDuracion.Text = "Duración:"
        '
        'txtDuracion
        '
        Me.txtDuracion.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txtDuracion.ForeColor = System.Drawing.Color.White
        Me.txtDuracion.Location = New System.Drawing.Point(695, 147)
        Me.txtDuracion.Name = "txtDuracion"
        Me.txtDuracion.Size = New System.Drawing.Size(60, 20)
        Me.txtDuracion.TabIndex = 146
        '
        'lblCoste
        '
        Me.lblCoste.AutoSize = True
        Me.lblCoste.Font = New System.Drawing.Font("MS Reference Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCoste.ForeColor = System.Drawing.Color.Gold
        Me.lblCoste.Location = New System.Drawing.Point(692, 76)
        Me.lblCoste.Name = "lblCoste"
        Me.lblCoste.Size = New System.Drawing.Size(45, 15)
        Me.lblCoste.TabIndex = 157
        Me.lblCoste.Text = "Coste:"
        '
        'txtCoste
        '
        Me.txtCoste.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txtCoste.ForeColor = System.Drawing.Color.White
        Me.txtCoste.Location = New System.Drawing.Point(695, 95)
        Me.txtCoste.Name = "txtCoste"
        Me.txtCoste.Size = New System.Drawing.Size(60, 20)
        Me.txtCoste.TabIndex = 143
        '
        'lblNombreCurso
        '
        Me.lblNombreCurso.AutoSize = True
        Me.lblNombreCurso.Font = New System.Drawing.Font("MS Reference Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNombreCurso.ForeColor = System.Drawing.Color.Gold
        Me.lblNombreCurso.Location = New System.Drawing.Point(12, 131)
        Me.lblNombreCurso.Name = "lblNombreCurso"
        Me.lblNombreCurso.Size = New System.Drawing.Size(116, 15)
        Me.lblNombreCurso.TabIndex = 156
        Me.lblNombreCurso.Text = "Nombre del Curso:"
        '
        'txtNombreCurso
        '
        Me.txtNombreCurso.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txtNombreCurso.ForeColor = System.Drawing.Color.White
        Me.txtNombreCurso.Location = New System.Drawing.Point(12, 148)
        Me.txtNombreCurso.MaxLength = 50
        Me.txtNombreCurso.Name = "txtNombreCurso"
        Me.txtNombreCurso.Size = New System.Drawing.Size(380, 20)
        Me.txtNombreCurso.TabIndex = 144
        '
        'lblCodigo
        '
        Me.lblCodigo.AutoSize = True
        Me.lblCodigo.Font = New System.Drawing.Font("MS Reference Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCodigo.ForeColor = System.Drawing.Color.Gold
        Me.lblCodigo.Location = New System.Drawing.Point(12, 75)
        Me.lblCodigo.Name = "lblCodigo"
        Me.lblCodigo.Size = New System.Drawing.Size(52, 15)
        Me.lblCodigo.TabIndex = 155
        Me.lblCodigo.Text = "Código:"
        '
        'txtCodigo
        '
        Me.txtCodigo.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txtCodigo.ForeColor = System.Drawing.Color.White
        Me.txtCodigo.Location = New System.Drawing.Point(12, 93)
        Me.txtCodigo.MaxLength = 7
        Me.txtCodigo.Name = "txtCodigo"
        Me.txtCodigo.Size = New System.Drawing.Size(61, 20)
        Me.txtCodigo.TabIndex = 138
        '
        'dtpFechaInicio
        '
        Me.dtpFechaInicio.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpFechaInicio.Location = New System.Drawing.Point(106, 92)
        Me.dtpFechaInicio.Name = "dtpFechaInicio"
        Me.dtpFechaInicio.Size = New System.Drawing.Size(140, 20)
        Me.dtpFechaInicio.TabIndex = 167
        '
        'dtpFechaFin
        '
        Me.dtpFechaFin.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpFechaFin.Location = New System.Drawing.Point(252, 93)
        Me.dtpFechaFin.Name = "dtpFechaFin"
        Me.dtpFechaFin.Size = New System.Drawing.Size(140, 20)
        Me.dtpFechaFin.TabIndex = 168
        '
        'btnBuscarCodigo
        '
        Me.btnBuscarCodigo.BackgroundImage = Global.Formacion.My.Resources.Resources.BuscarIcono
        Me.btnBuscarCodigo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnBuscarCodigo.Location = New System.Drawing.Point(77, 89)
        Me.btnBuscarCodigo.Name = "btnBuscarCodigo"
        Me.btnBuscarCodigo.Size = New System.Drawing.Size(23, 28)
        Me.btnBuscarCodigo.TabIndex = 139
        Me.btnBuscarCodigo.UseVisualStyleBackColor = True
        '
        'lblCalificaciones
        '
        Me.lblCalificaciones.AutoSize = True
        Me.lblCalificaciones.Font = New System.Drawing.Font("MS Reference Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCalificaciones.ForeColor = System.Drawing.Color.Gold
        Me.lblCalificaciones.Location = New System.Drawing.Point(646, 283)
        Me.lblCalificaciones.Name = "lblCalificaciones"
        Me.lblCalificaciones.Size = New System.Drawing.Size(109, 15)
        Me.lblCalificaciones.TabIndex = 171
        Me.lblCalificaciones.Text = "CALIFICACIONES"
        Me.lblCalificaciones.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'lblAsistencia
        '
        Me.lblAsistencia.AutoSize = True
        Me.lblAsistencia.Font = New System.Drawing.Font("MS Reference Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAsistencia.ForeColor = System.Drawing.Color.Gold
        Me.lblAsistencia.Location = New System.Drawing.Point(657, 398)
        Me.lblAsistencia.Name = "lblAsistencia"
        Me.lblAsistencia.Size = New System.Drawing.Size(80, 15)
        Me.lblAsistencia.TabIndex = 172
        Me.lblAsistencia.Text = "ASISTENCIA"
        Me.lblAsistencia.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'btnCalificaciones
        '
        Me.btnCalificaciones.BackgroundImage = Global.Formacion.My.Resources.Resources.calificacionesAMARILLO
        Me.btnCalificaciones.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnCalificaciones.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCalificaciones.Location = New System.Drawing.Point(660, 201)
        Me.btnCalificaciones.Name = "btnCalificaciones"
        Me.btnCalificaciones.Size = New System.Drawing.Size(77, 79)
        Me.btnCalificaciones.TabIndex = 173
        Me.btnCalificaciones.UseVisualStyleBackColor = True
        '
        'btnAsistencia
        '
        Me.btnAsistencia.BackgroundImage = Global.Formacion.My.Resources.Resources.Asistencia
        Me.btnAsistencia.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnAsistencia.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAsistencia.Location = New System.Drawing.Point(660, 317)
        Me.btnAsistencia.Name = "btnAsistencia"
        Me.btnAsistencia.Size = New System.Drawing.Size(77, 79)
        Me.btnAsistencia.TabIndex = 174
        Me.btnAsistencia.UseVisualStyleBackColor = True
        '
        'frmCrudCursos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(767, 666)
        Me.Controls.Add(Me.btnAsistencia)
        Me.Controls.Add(Me.btnCalificaciones)
        Me.Controls.Add(Me.lblAsistencia)
        Me.Controls.Add(Me.lblCalificaciones)
        Me.Controls.Add(Me.dtpFechaFin)
        Me.Controls.Add(Me.dtpFechaInicio)
        Me.Controls.Add(Me.btnSeleccionarAlumnos)
        Me.Controls.Add(Me.btnBuscarCodigo)
        Me.Controls.Add(Me.dgvListadoCursos)
        Me.Controls.Add(Me.btnSeleccionarProfesores)
        Me.Controls.Add(Me.lblAlumnos)
        Me.Controls.Add(Me.lblProfesores)
        Me.Controls.Add(Me.lstAlumnos)
        Me.Controls.Add(Me.lstProfesores)
        Me.Controls.Add(Me.lblFechaFin)
        Me.Controls.Add(Me.lblFechaInicio)
        Me.Controls.Add(Me.lblObservaciones)
        Me.Controls.Add(Me.txtObservaciones)
        Me.Controls.Add(Me.lblAula)
        Me.Controls.Add(Me.cboAulas)
        Me.Controls.Add(Me.lblTipoCurso)
        Me.Controls.Add(Me.cboTiposCursos)
        Me.Controls.Add(Me.lblDuracion)
        Me.Controls.Add(Me.txtDuracion)
        Me.Controls.Add(Me.lblCoste)
        Me.Controls.Add(Me.txtCoste)
        Me.Controls.Add(Me.lblNombreCurso)
        Me.Controls.Add(Me.txtNombreCurso)
        Me.Controls.Add(Me.lblCodigo)
        Me.Controls.Add(Me.txtCodigo)
        Me.Controls.Add(Me.BarraHerramientas)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmCrudCursos"
        Me.Text = "MANTENIMIENTO DE CURSOS"
        Me.BarraHerramientas.ResumeLayout(False)
        Me.BarraHerramientas.PerformLayout()
        CType(Me.dgvListadoCursos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents BarraHerramientas As System.Windows.Forms.ToolStrip
    Friend WithEvents tlbNuevo As System.Windows.Forms.ToolStripButton
    Friend WithEvents tlbEditar As System.Windows.Forms.ToolStripButton
    Friend WithEvents tlbBorrar As System.Windows.Forms.ToolStripButton
    Friend WithEvents tlbBuscar As System.Windows.Forms.ToolStripButton
    Friend WithEvents tlbGuardar As System.Windows.Forms.ToolStripButton
    Friend WithEvents tlbActualizar As System.Windows.Forms.ToolStripButton
    Friend WithEvents tlbCancelar As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnSeleccionarAlumnos As System.Windows.Forms.Button
    Friend WithEvents btnBuscarCodigo As System.Windows.Forms.Button
    Private WithEvents dgvListadoCursos As System.Windows.Forms.DataGridView
    Friend WithEvents btnSeleccionarProfesores As System.Windows.Forms.Button
    Friend WithEvents lblAlumnos As System.Windows.Forms.Label
    Friend WithEvents lblProfesores As System.Windows.Forms.Label
    Friend WithEvents lstAlumnos As System.Windows.Forms.ListBox
    Friend WithEvents lstProfesores As System.Windows.Forms.ListBox
    Friend WithEvents lblFechaFin As System.Windows.Forms.Label
    Friend WithEvents lblFechaInicio As System.Windows.Forms.Label
    Friend WithEvents lblObservaciones As System.Windows.Forms.Label
    Friend WithEvents txtObservaciones As System.Windows.Forms.TextBox
    Friend WithEvents lblAula As System.Windows.Forms.Label
    Friend WithEvents cboAulas As System.Windows.Forms.ComboBox
    Friend WithEvents lblTipoCurso As System.Windows.Forms.Label
    Friend WithEvents cboTiposCursos As System.Windows.Forms.ComboBox
    Friend WithEvents lblDuracion As System.Windows.Forms.Label
    Friend WithEvents txtDuracion As System.Windows.Forms.TextBox
    Friend WithEvents lblCoste As System.Windows.Forms.Label
    Friend WithEvents txtCoste As System.Windows.Forms.TextBox
    Friend WithEvents lblNombreCurso As System.Windows.Forms.Label
    Friend WithEvents txtNombreCurso As System.Windows.Forms.TextBox
    Friend WithEvents lblCodigo As System.Windows.Forms.Label
    Friend WithEvents txtCodigo As System.Windows.Forms.TextBox
    Friend WithEvents dtpFechaInicio As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtpFechaFin As System.Windows.Forms.DateTimePicker
    Friend WithEvents lblCalificaciones As System.Windows.Forms.Label
    Friend WithEvents lblAsistencia As System.Windows.Forms.Label
    Friend WithEvents btnCalificaciones As System.Windows.Forms.Button
    Friend WithEvents btnAsistencia As System.Windows.Forms.Button
    Friend WithEvents clnCodigoCurso As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents clnNombreCurso As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents clnCodigoTipoCurso As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents clnNombreTipoCurso As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents clnDuracionCurso As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents clnFechaInicioCurso As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents clnFechaFinCurso As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents clnCosteCurso As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents clnCodigoAula As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents clnNombreAula As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents clnObservaciones As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
