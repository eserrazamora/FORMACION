<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMatriculacion
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMatriculacion))
        Me.lblCurso = New System.Windows.Forms.Label()
        Me.cboAsignarCurso = New System.Windows.Forms.ComboBox()
        Me.lblNifAlumno = New System.Windows.Forms.Label()
        Me.cboNifAlumno = New System.Windows.Forms.ComboBox()
        Me.lblCodigoMatricula = New System.Windows.Forms.Label()
        Me.dgvListadoCursosMatriculados = New System.Windows.Forms.DataGridView()
        Me.clnCurso = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.clnCodigoCurso = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.clnCodigoMatricula = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.clnFechaInicio = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.clnFechaFin = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.clnPagado = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.chkPagado = New System.Windows.Forms.CheckBox()
        Me.BarraHerramientas = New System.Windows.Forms.ToolStrip()
        Me.tlbNuevo = New System.Windows.Forms.ToolStripButton()
        Me.tlbEditar = New System.Windows.Forms.ToolStripButton()
        Me.tlbBorrar = New System.Windows.Forms.ToolStripButton()
        Me.tlbGuardar = New System.Windows.Forms.ToolStripButton()
        Me.tlbActualizar = New System.Windows.Forms.ToolStripButton()
        Me.tlbCancelar = New System.Windows.Forms.ToolStripButton()
        Me.lblCursosAula = New System.Windows.Forms.Label()
        Me.lblCodigoMatriculaText = New System.Windows.Forms.Label()
        CType(Me.dgvListadoCursosMatriculados, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.BarraHerramientas.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblCurso
        '
        Me.lblCurso.AutoSize = True
        Me.lblCurso.Font = New System.Drawing.Font("MS Reference Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCurso.ForeColor = System.Drawing.Color.Gold
        Me.lblCurso.Location = New System.Drawing.Point(12, 144)
        Me.lblCurso.Name = "lblCurso"
        Me.lblCurso.Size = New System.Drawing.Size(121, 15)
        Me.lblCurso.TabIndex = 110
        Me.lblCurso.Text = "Cursos Disponibles:"
        Me.lblCurso.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'cboAsignarCurso
        '
        Me.cboAsignarCurso.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.cboAsignarCurso.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboAsignarCurso.ForeColor = System.Drawing.Color.White
        Me.cboAsignarCurso.FormattingEnabled = True
        Me.cboAsignarCurso.Location = New System.Drawing.Point(12, 162)
        Me.cboAsignarCurso.Name = "cboAsignarCurso"
        Me.cboAsignarCurso.Size = New System.Drawing.Size(491, 21)
        Me.cboAsignarCurso.TabIndex = 109
        '
        'lblNifAlumno
        '
        Me.lblNifAlumno.AutoSize = True
        Me.lblNifAlumno.Font = New System.Drawing.Font("MS Reference Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNifAlumno.ForeColor = System.Drawing.Color.Gold
        Me.lblNifAlumno.Location = New System.Drawing.Point(153, 81)
        Me.lblNifAlumno.Name = "lblNifAlumno"
        Me.lblNifAlumno.Size = New System.Drawing.Size(55, 15)
        Me.lblNifAlumno.TabIndex = 108
        Me.lblNifAlumno.Text = "Alumno:"
        Me.lblNifAlumno.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'cboNifAlumno
        '
        Me.cboNifAlumno.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.cboNifAlumno.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboNifAlumno.ForeColor = System.Drawing.Color.White
        Me.cboNifAlumno.FormattingEnabled = True
        Me.cboNifAlumno.Location = New System.Drawing.Point(156, 99)
        Me.cboNifAlumno.Name = "cboNifAlumno"
        Me.cboNifAlumno.Size = New System.Drawing.Size(464, 21)
        Me.cboNifAlumno.TabIndex = 107
        '
        'lblCodigoMatricula
        '
        Me.lblCodigoMatricula.AutoSize = True
        Me.lblCodigoMatricula.Font = New System.Drawing.Font("MS Reference Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCodigoMatricula.ForeColor = System.Drawing.Color.Gold
        Me.lblCodigoMatricula.Location = New System.Drawing.Point(12, 81)
        Me.lblCodigoMatricula.Name = "lblCodigoMatricula"
        Me.lblCodigoMatricula.Size = New System.Drawing.Size(107, 15)
        Me.lblCodigoMatricula.TabIndex = 106
        Me.lblCodigoMatricula.Text = "Código Matricula:"
        '
        'dgvListadoCursosMatriculados
        '
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvListadoCursosMatriculados.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvListadoCursosMatriculados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvListadoCursosMatriculados.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.clnCurso, Me.clnCodigoCurso, Me.clnCodigoMatricula, Me.clnFechaInicio, Me.clnFechaFin, Me.clnPagado})
        Me.dgvListadoCursosMatriculados.Location = New System.Drawing.Point(12, 220)
        Me.dgvListadoCursosMatriculados.Name = "dgvListadoCursosMatriculados"
        Me.dgvListadoCursosMatriculados.ReadOnly = True
        Me.dgvListadoCursosMatriculados.RowHeadersVisible = False
        Me.dgvListadoCursosMatriculados.Size = New System.Drawing.Size(608, 199)
        Me.dgvListadoCursosMatriculados.TabIndex = 128
        '
        'clnCurso
        '
        Me.clnCurso.DataPropertyName = "Nombre"
        Me.clnCurso.HeaderText = "CURSO"
        Me.clnCurso.Name = "clnCurso"
        Me.clnCurso.ReadOnly = True
        Me.clnCurso.Width = 270
        '
        'clnCodigoCurso
        '
        Me.clnCodigoCurso.DataPropertyName = "CodigoCurso"
        Me.clnCodigoCurso.HeaderText = "CODIGOCURSO"
        Me.clnCodigoCurso.Name = "clnCodigoCurso"
        Me.clnCodigoCurso.ReadOnly = True
        Me.clnCodigoCurso.Visible = False
        '
        'clnCodigoMatricula
        '
        Me.clnCodigoMatricula.DataPropertyName = "CodigoMatricula"
        Me.clnCodigoMatricula.HeaderText = "CODIGOMATRICULA"
        Me.clnCodigoMatricula.Name = "clnCodigoMatricula"
        Me.clnCodigoMatricula.ReadOnly = True
        Me.clnCodigoMatricula.Visible = False
        '
        'clnFechaInicio
        '
        Me.clnFechaInicio.DataPropertyName = "FechaInicio"
        Me.clnFechaInicio.HeaderText = "FECHA INICIO"
        Me.clnFechaInicio.Name = "clnFechaInicio"
        Me.clnFechaInicio.ReadOnly = True
        Me.clnFechaInicio.Width = 115
        '
        'clnFechaFin
        '
        Me.clnFechaFin.DataPropertyName = "FechaFin"
        Me.clnFechaFin.HeaderText = "FECHA FIN"
        Me.clnFechaFin.Name = "clnFechaFin"
        Me.clnFechaFin.ReadOnly = True
        Me.clnFechaFin.Width = 115
        '
        'clnPagado
        '
        Me.clnPagado.DataPropertyName = "Pagado"
        Me.clnPagado.FalseValue = "N"
        Me.clnPagado.HeaderText = "PAGADO"
        Me.clnPagado.Name = "clnPagado"
        Me.clnPagado.ReadOnly = True
        Me.clnPagado.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.clnPagado.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.clnPagado.TrueValue = "S"
        Me.clnPagado.Width = 75
        '
        'chkPagado
        '
        Me.chkPagado.AutoSize = True
        Me.chkPagado.Font = New System.Drawing.Font("MS Reference Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkPagado.ForeColor = System.Drawing.Color.Gold
        Me.chkPagado.Location = New System.Drawing.Point(523, 162)
        Me.chkPagado.Name = "chkPagado"
        Me.chkPagado.Size = New System.Drawing.Size(88, 24)
        Me.chkPagado.TabIndex = 131
        Me.chkPagado.Text = "Pagado"
        Me.chkPagado.UseVisualStyleBackColor = True
        '
        'BarraHerramientas
        '
        Me.BarraHerramientas.BackColor = System.Drawing.Color.DarkOliveGreen
        Me.BarraHerramientas.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.BarraHerramientas.ImageScalingSize = New System.Drawing.Size(40, 40)
        Me.BarraHerramientas.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tlbNuevo, Me.tlbEditar, Me.tlbBorrar, Me.tlbGuardar, Me.tlbActualizar, Me.tlbCancelar})
        Me.BarraHerramientas.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow
        Me.BarraHerramientas.Location = New System.Drawing.Point(0, 0)
        Me.BarraHerramientas.Name = "BarraHerramientas"
        Me.BarraHerramientas.Size = New System.Drawing.Size(632, 66)
        Me.BarraHerramientas.TabIndex = 133
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
        'tlbGuardar
        '
        Me.tlbGuardar.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tlbGuardar.ForeColor = System.Drawing.Color.Gold
        Me.tlbGuardar.Image = Global.Formacion.My.Resources.Resources.Guardar
        Me.tlbGuardar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tlbGuardar.Margin = New System.Windows.Forms.Padding(320, 2, 2, 2)
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
        Me.tlbActualizar.Margin = New System.Windows.Forms.Padding(315, 2, 2, 2)
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
        Me.lblCursosAula.ForeColor = System.Drawing.Color.White
        Me.lblCursosAula.Location = New System.Drawing.Point(183, 195)
        Me.lblCursosAula.Name = "lblCursosAula"
        Me.lblCursosAula.Size = New System.Drawing.Size(250, 22)
        Me.lblCursosAula.TabIndex = 134
        Me.lblCursosAula.Text = "CURSOS MATRICULADOS"
        '
        'lblCodigoMatriculaText
        '
        Me.lblCodigoMatriculaText.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblCodigoMatriculaText.ForeColor = System.Drawing.Color.Yellow
        Me.lblCodigoMatriculaText.Location = New System.Drawing.Point(12, 99)
        Me.lblCodigoMatriculaText.Name = "lblCodigoMatriculaText"
        Me.lblCodigoMatriculaText.Size = New System.Drawing.Size(100, 21)
        Me.lblCodigoMatriculaText.TabIndex = 135
        Me.lblCodigoMatriculaText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'frmMatriculacion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(632, 430)
        Me.Controls.Add(Me.lblCodigoMatriculaText)
        Me.Controls.Add(Me.lblCursosAula)
        Me.Controls.Add(Me.BarraHerramientas)
        Me.Controls.Add(Me.chkPagado)
        Me.Controls.Add(Me.dgvListadoCursosMatriculados)
        Me.Controls.Add(Me.lblCurso)
        Me.Controls.Add(Me.cboAsignarCurso)
        Me.Controls.Add(Me.lblNifAlumno)
        Me.Controls.Add(Me.cboNifAlumno)
        Me.Controls.Add(Me.lblCodigoMatricula)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmMatriculacion"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "MATRICULACION"
        CType(Me.dgvListadoCursosMatriculados, System.ComponentModel.ISupportInitialize).EndInit()
        Me.BarraHerramientas.ResumeLayout(False)
        Me.BarraHerramientas.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblCurso As System.Windows.Forms.Label
    Friend WithEvents cboAsignarCurso As System.Windows.Forms.ComboBox
    Friend WithEvents lblNifAlumno As System.Windows.Forms.Label
    Friend WithEvents cboNifAlumno As System.Windows.Forms.ComboBox
    Friend WithEvents lblCodigoMatricula As System.Windows.Forms.Label
    Friend WithEvents dgvListadoCursosMatriculados As System.Windows.Forms.DataGridView
    Friend WithEvents chkPagado As System.Windows.Forms.CheckBox
    Friend WithEvents BarraHerramientas As System.Windows.Forms.ToolStrip
    Friend WithEvents tlbNuevo As System.Windows.Forms.ToolStripButton
    Friend WithEvents tlbEditar As System.Windows.Forms.ToolStripButton
    Friend WithEvents tlbBorrar As System.Windows.Forms.ToolStripButton
    Friend WithEvents tlbGuardar As System.Windows.Forms.ToolStripButton
    Friend WithEvents tlbActualizar As System.Windows.Forms.ToolStripButton
    Friend WithEvents tlbCancelar As System.Windows.Forms.ToolStripButton
    Friend WithEvents lblCursosAula As System.Windows.Forms.Label
    Friend WithEvents lblCodigoMatriculaTexto As System.Windows.Forms.Label
    Friend WithEvents lblCodigoMatriculaText As System.Windows.Forms.Label
    Friend WithEvents clnCurso As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents clnCodigoCurso As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents clnCodigoMatricula As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents clnFechaInicio As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents clnFechaFin As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents clnPagado As System.Windows.Forms.DataGridViewCheckBoxColumn
End Class
