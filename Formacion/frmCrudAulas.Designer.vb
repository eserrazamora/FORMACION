<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCrudAulas
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
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle9 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle11 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle12 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle10 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmCrudAulas))
        Me.lblObservaciones = New System.Windows.Forms.Label()
        Me.txtObservaciones = New System.Windows.Forms.TextBox()
        Me.lblAula = New System.Windows.Forms.Label()
        Me.cboTipoAula = New System.Windows.Forms.ComboBox()
        Me.lblNombreCurso = New System.Windows.Forms.Label()
        Me.txtNombreAula = New System.Windows.Forms.TextBox()
        Me.lblCodigo = New System.Windows.Forms.Label()
        Me.lblAsignarCurso = New System.Windows.Forms.Label()
        Me.cboAsignarCurso = New System.Windows.Forms.ComboBox()
        Me.lblDobleClic = New System.Windows.Forms.Label()
        Me.dgvListadoCursosAula = New System.Windows.Forms.DataGridView()
        Me.BarraHerramientas = New System.Windows.Forms.ToolStrip()
        Me.tlbNuevo = New System.Windows.Forms.ToolStripButton()
        Me.tlbEditar = New System.Windows.Forms.ToolStripButton()
        Me.tlbBorrar = New System.Windows.Forms.ToolStripButton()
        Me.tlbBuscar = New System.Windows.Forms.ToolStripButton()
        Me.tlbGuardar = New System.Windows.Forms.ToolStripButton()
        Me.tlbActualizar = New System.Windows.Forms.ToolStripButton()
        Me.tlbCancelar = New System.Windows.Forms.ToolStripButton()
        Me.lblCursosAula = New System.Windows.Forms.Label()
        Me.dgvListadoAulas = New System.Windows.Forms.DataGridView()
        Me.lblListadoAulas = New System.Windows.Forms.Label()
        Me.txtCodigo = New System.Windows.Forms.TextBox()
        Me.btnBuscarCodigoAula = New System.Windows.Forms.Button()
        Me.clnCodigoAula = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.clnNombreAula = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.clnCodigoTipoAula = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.clnTipoAula = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.clnObservacionesAula = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.clnCodigo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.clnNombre = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.clnFechaInicio = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.clnFechaFin = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.clnDuracion = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.dgvListadoCursosAula, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.BarraHerramientas.SuspendLayout()
        CType(Me.dgvListadoAulas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblObservaciones
        '
        Me.lblObservaciones.AutoSize = True
        Me.lblObservaciones.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.lblObservaciones.Font = New System.Drawing.Font("MS Reference Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblObservaciones.ForeColor = System.Drawing.Color.Gold
        Me.lblObservaciones.Location = New System.Drawing.Point(12, 123)
        Me.lblObservaciones.Name = "lblObservaciones"
        Me.lblObservaciones.Size = New System.Drawing.Size(96, 15)
        Me.lblObservaciones.TabIndex = 93
        Me.lblObservaciones.Text = "Observaciones:"
        '
        'txtObservaciones
        '
        Me.txtObservaciones.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txtObservaciones.ForeColor = System.Drawing.Color.White
        Me.txtObservaciones.Location = New System.Drawing.Point(15, 141)
        Me.txtObservaciones.Multiline = True
        Me.txtObservaciones.Name = "txtObservaciones"
        Me.txtObservaciones.Size = New System.Drawing.Size(642, 39)
        Me.txtObservaciones.TabIndex = 4
        '
        'lblAula
        '
        Me.lblAula.AutoSize = True
        Me.lblAula.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.lblAula.Font = New System.Drawing.Font("MS Reference Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAula.ForeColor = System.Drawing.Color.Gold
        Me.lblAula.Location = New System.Drawing.Point(425, 74)
        Me.lblAula.Name = "lblAula"
        Me.lblAula.Size = New System.Drawing.Size(83, 15)
        Me.lblAula.TabIndex = 91
        Me.lblAula.Text = "Tipo de Aula:"
        Me.lblAula.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'cboTipoAula
        '
        Me.cboTipoAula.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.cboTipoAula.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboTipoAula.ForeColor = System.Drawing.Color.White
        Me.cboTipoAula.FormattingEnabled = True
        Me.cboTipoAula.Location = New System.Drawing.Point(425, 92)
        Me.cboTipoAula.Name = "cboTipoAula"
        Me.cboTipoAula.Size = New System.Drawing.Size(232, 23)
        Me.cboTipoAula.TabIndex = 3
        '
        'lblNombreCurso
        '
        Me.lblNombreCurso.AutoSize = True
        Me.lblNombreCurso.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.lblNombreCurso.Font = New System.Drawing.Font("MS Reference Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNombreCurso.ForeColor = System.Drawing.Color.Gold
        Me.lblNombreCurso.Location = New System.Drawing.Point(101, 76)
        Me.lblNombreCurso.Name = "lblNombreCurso"
        Me.lblNombreCurso.Size = New System.Drawing.Size(107, 15)
        Me.lblNombreCurso.TabIndex = 83
        Me.lblNombreCurso.Text = "Nombre del Aula:"
        '
        'txtNombreAula
        '
        Me.txtNombreAula.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txtNombreAula.ForeColor = System.Drawing.Color.White
        Me.txtNombreAula.Location = New System.Drawing.Point(100, 94)
        Me.txtNombreAula.MaxLength = 40
        Me.txtNombreAula.Name = "txtNombreAula"
        Me.txtNombreAula.Size = New System.Drawing.Size(309, 21)
        Me.txtNombreAula.TabIndex = 2
        '
        'lblCodigo
        '
        Me.lblCodigo.AutoSize = True
        Me.lblCodigo.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.lblCodigo.Font = New System.Drawing.Font("MS Reference Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCodigo.ForeColor = System.Drawing.Color.Gold
        Me.lblCodigo.Location = New System.Drawing.Point(12, 74)
        Me.lblCodigo.Name = "lblCodigo"
        Me.lblCodigo.Size = New System.Drawing.Size(52, 15)
        Me.lblCodigo.TabIndex = 81
        Me.lblCodigo.Text = "Código:"
        '
        'lblAsignarCurso
        '
        Me.lblAsignarCurso.AutoSize = True
        Me.lblAsignarCurso.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.lblAsignarCurso.Font = New System.Drawing.Font("MS Reference Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAsignarCurso.ForeColor = System.Drawing.Color.Gold
        Me.lblAsignarCurso.Location = New System.Drawing.Point(15, 185)
        Me.lblAsignarCurso.Name = "lblAsignarCurso"
        Me.lblAsignarCurso.Size = New System.Drawing.Size(171, 15)
        Me.lblAsignarCurso.TabIndex = 104
        Me.lblAsignarCurso.Text = "Cursos Sin Aulas Asignadas:"
        Me.lblAsignarCurso.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'cboAsignarCurso
        '
        Me.cboAsignarCurso.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.cboAsignarCurso.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboAsignarCurso.ForeColor = System.Drawing.Color.White
        Me.cboAsignarCurso.FormattingEnabled = True
        Me.cboAsignarCurso.Location = New System.Drawing.Point(15, 203)
        Me.cboAsignarCurso.Name = "cboAsignarCurso"
        Me.cboAsignarCurso.Size = New System.Drawing.Size(642, 23)
        Me.cboAsignarCurso.TabIndex = 5
        '
        'lblDobleClic
        '
        Me.lblDobleClic.AutoSize = True
        Me.lblDobleClic.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDobleClic.Location = New System.Drawing.Point(36, 581)
        Me.lblDobleClic.Name = "lblDobleClic"
        Me.lblDobleClic.Size = New System.Drawing.Size(256, 13)
        Me.lblDobleClic.TabIndex = 127
        Me.lblDobleClic.Text = "Doble Clic en el Codigo para Editar el Curso"
        '
        'dgvListadoCursosAula
        '
        Me.dgvListadoCursosAula.AllowUserToAddRows = False
        Me.dgvListadoCursosAula.AllowUserToResizeColumns = False
        Me.dgvListadoCursosAula.AllowUserToResizeRows = False
        Me.dgvListadoCursosAula.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.dgvListadoCursosAula.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.DarkOliveGreen
        DataGridViewCellStyle1.Font = New System.Drawing.Font("MS Reference Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.Gold
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvListadoCursosAula.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvListadoCursosAula.ColumnHeadersHeight = 21
        Me.dgvListadoCursosAula.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.clnCodigo, Me.clnNombre, Me.clnFechaInicio, Me.clnFechaFin, Me.clnDuracion})
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle6.Font = New System.Drawing.Font("MS Reference Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle6.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.Yellow
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvListadoCursosAula.DefaultCellStyle = DataGridViewCellStyle6
        Me.dgvListadoCursosAula.EnableHeadersVisualStyles = False
        Me.dgvListadoCursosAula.GridColor = System.Drawing.Color.Silver
        Me.dgvListadoCursosAula.Location = New System.Drawing.Point(15, 429)
        Me.dgvListadoCursosAula.MultiSelect = False
        Me.dgvListadoCursosAula.Name = "dgvListadoCursosAula"
        Me.dgvListadoCursosAula.ReadOnly = True
        Me.dgvListadoCursosAula.RowHeadersVisible = False
        DataGridViewCellStyle7.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.Yellow
        DataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.Black
        Me.dgvListadoCursosAula.RowsDefaultCellStyle = DataGridViewCellStyle7
        Me.dgvListadoCursosAula.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvListadoCursosAula.Size = New System.Drawing.Size(642, 138)
        Me.dgvListadoCursosAula.TabIndex = 8
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
        Me.BarraHerramientas.Size = New System.Drawing.Size(678, 66)
        Me.BarraHerramientas.TabIndex = 130
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
        Me.tlbGuardar.Margin = New System.Windows.Forms.Padding(300, 2, 2, 2)
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
        Me.tlbActualizar.Margin = New System.Windows.Forms.Padding(300, 2, 2, 2)
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
        'lblCursosAula
        '
        Me.lblCursosAula.AutoSize = True
        Me.lblCursosAula.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCursosAula.Location = New System.Drawing.Point(177, 404)
        Me.lblCursosAula.Name = "lblCursosAula"
        Me.lblCursosAula.Size = New System.Drawing.Size(328, 22)
        Me.lblCursosAula.TabIndex = 132
        Me.lblCursosAula.Text = "LISTADO DE CURSOS EN EL AULA"
        '
        'dgvListadoAulas
        '
        Me.dgvListadoAulas.AllowUserToAddRows = False
        Me.dgvListadoAulas.AllowUserToResizeColumns = False
        Me.dgvListadoAulas.AllowUserToResizeRows = False
        DataGridViewCellStyle8.BackColor = System.Drawing.Color.Silver
        Me.dgvListadoAulas.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle8
        Me.dgvListadoAulas.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.dgvListadoAulas.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken
        DataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle9.BackColor = System.Drawing.Color.DarkOliveGreen
        DataGridViewCellStyle9.Font = New System.Drawing.Font("MS Reference Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle9.ForeColor = System.Drawing.Color.Gold
        DataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvListadoAulas.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle9
        Me.dgvListadoAulas.ColumnHeadersHeight = 21
        Me.dgvListadoAulas.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.clnCodigoAula, Me.clnNombreAula, Me.clnCodigoTipoAula, Me.clnTipoAula, Me.clnObservacionesAula})
        DataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle11.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle11.Font = New System.Drawing.Font("MS Reference Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle11.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle11.SelectionBackColor = System.Drawing.Color.Yellow
        DataGridViewCellStyle11.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvListadoAulas.DefaultCellStyle = DataGridViewCellStyle11
        Me.dgvListadoAulas.EnableHeadersVisualStyles = False
        Me.dgvListadoAulas.GridColor = System.Drawing.Color.Silver
        Me.dgvListadoAulas.Location = New System.Drawing.Point(15, 263)
        Me.dgvListadoAulas.MultiSelect = False
        Me.dgvListadoAulas.Name = "dgvListadoAulas"
        Me.dgvListadoAulas.ReadOnly = True
        Me.dgvListadoAulas.RowHeadersVisible = False
        DataGridViewCellStyle12.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle12.SelectionBackColor = System.Drawing.Color.Yellow
        DataGridViewCellStyle12.SelectionForeColor = System.Drawing.Color.Black
        Me.dgvListadoAulas.RowsDefaultCellStyle = DataGridViewCellStyle12
        Me.dgvListadoAulas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvListadoAulas.Size = New System.Drawing.Size(642, 138)
        Me.dgvListadoAulas.TabIndex = 7
        '
        'lblListadoAulas
        '
        Me.lblListadoAulas.AutoSize = True
        Me.lblListadoAulas.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblListadoAulas.Location = New System.Drawing.Point(240, 238)
        Me.lblListadoAulas.Name = "lblListadoAulas"
        Me.lblListadoAulas.Size = New System.Drawing.Size(194, 22)
        Me.lblListadoAulas.TabIndex = 134
        Me.lblListadoAulas.Text = "LISTADO DE AULAS"
        '
        'txtCodigo
        '
        Me.txtCodigo.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txtCodigo.ForeColor = System.Drawing.Color.White
        Me.txtCodigo.Location = New System.Drawing.Point(15, 94)
        Me.txtCodigo.MaxLength = 4
        Me.txtCodigo.Name = "txtCodigo"
        Me.txtCodigo.Size = New System.Drawing.Size(49, 21)
        Me.txtCodigo.TabIndex = 0
        Me.txtCodigo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'btnBuscarCodigoAula
        '
        Me.btnBuscarCodigoAula.BackgroundImage = Global.Formacion.My.Resources.Resources.BuscarIcono
        Me.btnBuscarCodigoAula.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnBuscarCodigoAula.Location = New System.Drawing.Point(68, 92)
        Me.btnBuscarCodigoAula.Name = "btnBuscarCodigoAula"
        Me.btnBuscarCodigoAula.Size = New System.Drawing.Size(25, 24)
        Me.btnBuscarCodigoAula.TabIndex = 1
        Me.btnBuscarCodigoAula.UseVisualStyleBackColor = True
        '
        'clnCodigoAula
        '
        Me.clnCodigoAula.DataPropertyName = "Codigo"
        DataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.clnCodigoAula.DefaultCellStyle = DataGridViewCellStyle10
        Me.clnCodigoAula.HeaderText = "CODIGO"
        Me.clnCodigoAula.Name = "clnCodigoAula"
        Me.clnCodigoAula.ReadOnly = True
        Me.clnCodigoAula.Width = 75
        '
        'clnNombreAula
        '
        Me.clnNombreAula.DataPropertyName = "Nombre"
        Me.clnNombreAula.HeaderText = "NOMBRE"
        Me.clnNombreAula.Name = "clnNombreAula"
        Me.clnNombreAula.ReadOnly = True
        Me.clnNombreAula.Width = 250
        '
        'clnCodigoTipoAula
        '
        Me.clnCodigoTipoAula.DataPropertyName = "Tipo"
        Me.clnCodigoTipoAula.HeaderText = "CODIGOTIPO"
        Me.clnCodigoTipoAula.Name = "clnCodigoTipoAula"
        Me.clnCodigoTipoAula.ReadOnly = True
        Me.clnCodigoTipoAula.Visible = False
        Me.clnCodigoTipoAula.Width = 150
        '
        'clnTipoAula
        '
        Me.clnTipoAula.DataPropertyName = "TipoNombre"
        Me.clnTipoAula.HeaderText = "TIPO"
        Me.clnTipoAula.Name = "clnTipoAula"
        Me.clnTipoAula.ReadOnly = True
        Me.clnTipoAula.Width = 150
        '
        'clnObservacionesAula
        '
        Me.clnObservacionesAula.DataPropertyName = "Observaciones"
        Me.clnObservacionesAula.HeaderText = "OBSERVACIONES"
        Me.clnObservacionesAula.Name = "clnObservacionesAula"
        Me.clnObservacionesAula.ReadOnly = True
        Me.clnObservacionesAula.Width = 150
        '
        'clnCodigo
        '
        Me.clnCodigo.DataPropertyName = "CodigoCurso"
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.clnCodigo.DefaultCellStyle = DataGridViewCellStyle2
        Me.clnCodigo.HeaderText = "CODIGO"
        Me.clnCodigo.Name = "clnCodigo"
        Me.clnCodigo.ReadOnly = True
        Me.clnCodigo.Width = 75
        '
        'clnNombre
        '
        Me.clnNombre.DataPropertyName = "Nombre"
        Me.clnNombre.HeaderText = "NOMBRE"
        Me.clnNombre.Name = "clnNombre"
        Me.clnNombre.ReadOnly = True
        Me.clnNombre.Width = 250
        '
        'clnFechaInicio
        '
        Me.clnFechaInicio.DataPropertyName = "FechaInicio"
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.clnFechaInicio.DefaultCellStyle = DataGridViewCellStyle3
        Me.clnFechaInicio.HeaderText = "F.INICIO"
        Me.clnFechaInicio.Name = "clnFechaInicio"
        Me.clnFechaInicio.ReadOnly = True
        Me.clnFechaInicio.Width = 120
        '
        'clnFechaFin
        '
        Me.clnFechaFin.DataPropertyName = "FechaFin"
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.clnFechaFin.DefaultCellStyle = DataGridViewCellStyle4
        Me.clnFechaFin.HeaderText = "F. FIN"
        Me.clnFechaFin.Name = "clnFechaFin"
        Me.clnFechaFin.ReadOnly = True
        Me.clnFechaFin.Width = 120
        '
        'clnDuracion
        '
        Me.clnDuracion.DataPropertyName = "Duracion"
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.clnDuracion.DefaultCellStyle = DataGridViewCellStyle5
        Me.clnDuracion.HeaderText = "HORAS"
        Me.clnDuracion.Name = "clnDuracion"
        Me.clnDuracion.ReadOnly = True
        Me.clnDuracion.Width = 70
        '
        'frmCrudAulas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(678, 602)
        Me.Controls.Add(Me.btnBuscarCodigoAula)
        Me.Controls.Add(Me.txtCodigo)
        Me.Controls.Add(Me.lblListadoAulas)
        Me.Controls.Add(Me.dgvListadoAulas)
        Me.Controls.Add(Me.lblCursosAula)
        Me.Controls.Add(Me.BarraHerramientas)
        Me.Controls.Add(Me.lblDobleClic)
        Me.Controls.Add(Me.dgvListadoCursosAula)
        Me.Controls.Add(Me.lblAsignarCurso)
        Me.Controls.Add(Me.cboAsignarCurso)
        Me.Controls.Add(Me.lblObservaciones)
        Me.Controls.Add(Me.txtObservaciones)
        Me.Controls.Add(Me.lblAula)
        Me.Controls.Add(Me.cboTipoAula)
        Me.Controls.Add(Me.lblNombreCurso)
        Me.Controls.Add(Me.txtNombreAula)
        Me.Controls.Add(Me.lblCodigo)
        Me.Font = New System.Drawing.Font("MS Reference Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.Color.White
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmCrudAulas"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "MANTENIMIENTO DE AULAS"
        CType(Me.dgvListadoCursosAula, System.ComponentModel.ISupportInitialize).EndInit()
        Me.BarraHerramientas.ResumeLayout(False)
        Me.BarraHerramientas.PerformLayout()
        CType(Me.dgvListadoAulas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblObservaciones As System.Windows.Forms.Label
    Friend WithEvents txtObservaciones As System.Windows.Forms.TextBox
    Friend WithEvents lblAula As System.Windows.Forms.Label
    Friend WithEvents cboTipoAula As System.Windows.Forms.ComboBox
    Friend WithEvents lblNombreCurso As System.Windows.Forms.Label
    Friend WithEvents txtNombreAula As System.Windows.Forms.TextBox
    Friend WithEvents lblCodigo As System.Windows.Forms.Label
    Friend WithEvents lblAsignarCurso As System.Windows.Forms.Label
    Friend WithEvents cboAsignarCurso As System.Windows.Forms.ComboBox
    Friend WithEvents lblDobleClic As System.Windows.Forms.Label
    Private WithEvents dgvListadoCursosAula As System.Windows.Forms.DataGridView
    Friend WithEvents BarraHerramientas As System.Windows.Forms.ToolStrip
    Friend WithEvents tlbNuevo As System.Windows.Forms.ToolStripButton
    Friend WithEvents tlbEditar As System.Windows.Forms.ToolStripButton
    Friend WithEvents tlbBorrar As System.Windows.Forms.ToolStripButton
    Friend WithEvents tlbBuscar As System.Windows.Forms.ToolStripButton
    Friend WithEvents tlbGuardar As System.Windows.Forms.ToolStripButton
    Friend WithEvents tlbActualizar As System.Windows.Forms.ToolStripButton
    Friend WithEvents tlbCancelar As System.Windows.Forms.ToolStripButton
    Friend WithEvents lblCursosAula As System.Windows.Forms.Label
    Private WithEvents dgvListadoAulas As System.Windows.Forms.DataGridView
    Friend WithEvents lblListadoAulas As System.Windows.Forms.Label
    Friend WithEvents txtCodigo As System.Windows.Forms.TextBox
    Friend WithEvents btnBuscarCodigoAula As System.Windows.Forms.Button
    Friend WithEvents clnCodigoAula As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents clnNombreAula As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents clnCodigoTipoAula As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents clnTipoAula As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents clnObservacionesAula As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents clnCodigo As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents clnNombre As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents clnFechaInicio As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents clnFechaFin As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents clnDuracion As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
