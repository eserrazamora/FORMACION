<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAsistenciasAlumno
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmAsistenciasAlumno))
        Me.lblCurso = New System.Windows.Forms.Label()
        Me.cboCursos = New System.Windows.Forms.ComboBox()
        Me.lblFechaAsistencia = New System.Windows.Forms.Label()
        Me.dgvListadoCursos = New System.Windows.Forms.DataGridView()
        Me.clnNombre = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.clnCodigoMatricula = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.clnFecha = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.clnAsistencia = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.txtFechaInicio = New System.Windows.Forms.TextBox()
        Me.lblFechaInicio = New System.Windows.Forms.Label()
        Me.lblFechaFin = New System.Windows.Forms.Label()
        Me.txtFechaFin = New System.Windows.Forms.TextBox()
        Me.dtpFechaAsistencia = New System.Windows.Forms.DateTimePicker()
        Me.chkSeleccionarTodos = New System.Windows.Forms.CheckBox()
        Me.BarraHerramientas = New System.Windows.Forms.ToolStrip()
        Me.tlbEditar = New System.Windows.Forms.ToolStripButton()
        Me.tlbGuardar = New System.Windows.Forms.ToolStripButton()
        Me.tlbCancelar = New System.Windows.Forms.ToolStripButton()
        CType(Me.dgvListadoCursos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.BarraHerramientas.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblCurso
        '
        Me.lblCurso.AutoSize = True
        Me.lblCurso.Font = New System.Drawing.Font("MS Reference Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCurso.ForeColor = System.Drawing.Color.Gold
        Me.lblCurso.Location = New System.Drawing.Point(12, 93)
        Me.lblCurso.Name = "lblCurso"
        Me.lblCurso.Size = New System.Drawing.Size(41, 15)
        Me.lblCurso.TabIndex = 39
        Me.lblCurso.Text = "Curso"
        Me.lblCurso.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'cboCursos
        '
        Me.cboCursos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboCursos.FormattingEnabled = True
        Me.cboCursos.Location = New System.Drawing.Point(12, 114)
        Me.cboCursos.Name = "cboCursos"
        Me.cboCursos.Size = New System.Drawing.Size(525, 21)
        Me.cboCursos.TabIndex = 38
        '
        'lblFechaAsistencia
        '
        Me.lblFechaAsistencia.AutoSize = True
        Me.lblFechaAsistencia.Font = New System.Drawing.Font("MS Reference Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFechaAsistencia.ForeColor = System.Drawing.Color.Gold
        Me.lblFechaAsistencia.Location = New System.Drawing.Point(233, 156)
        Me.lblFechaAsistencia.Name = "lblFechaAsistencia"
        Me.lblFechaAsistencia.Size = New System.Drawing.Size(124, 15)
        Me.lblFechaAsistencia.TabIndex = 35
        Me.lblFechaAsistencia.Text = "Fecha de Asistencia:"
        '
        'dgvListadoCursos
        '
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvListadoCursos.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvListadoCursos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvListadoCursos.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.clnNombre, Me.clnCodigoMatricula, Me.clnFecha, Me.clnAsistencia})
        Me.dgvListadoCursos.Location = New System.Drawing.Point(12, 214)
        Me.dgvListadoCursos.Name = "dgvListadoCursos"
        Me.dgvListadoCursos.RowHeadersVisible = False
        Me.dgvListadoCursos.Size = New System.Drawing.Size(525, 294)
        Me.dgvListadoCursos.TabIndex = 128
        '
        'clnNombre
        '
        Me.clnNombre.DataPropertyName = "NOMBRECOMPLETO"
        Me.clnNombre.HeaderText = "NOMBRE"
        Me.clnNombre.Name = "clnNombre"
        Me.clnNombre.Width = 300
        '
        'clnCodigoMatricula
        '
        Me.clnCodigoMatricula.DataPropertyName = "CodigoMatricula"
        Me.clnCodigoMatricula.HeaderText = "COD.MATRICULA"
        Me.clnCodigoMatricula.Name = "clnCodigoMatricula"
        Me.clnCodigoMatricula.Visible = False
        '
        'clnFecha
        '
        Me.clnFecha.DataPropertyName = "Fecha"
        Me.clnFecha.HeaderText = "FECHA"
        Me.clnFecha.Name = "clnFecha"
        '
        'clnAsistencia
        '
        Me.clnAsistencia.DataPropertyName = "Asistio"
        Me.clnAsistencia.FalseValue = "N"
        Me.clnAsistencia.HeaderText = "ASISTIO"
        Me.clnAsistencia.Name = "clnAsistencia"
        Me.clnAsistencia.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.clnAsistencia.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.clnAsistencia.TrueValue = "S"
        '
        'txtFechaInicio
        '
        Me.txtFechaInicio.Enabled = False
        Me.txtFechaInicio.Location = New System.Drawing.Point(12, 178)
        Me.txtFechaInicio.Name = "txtFechaInicio"
        Me.txtFechaInicio.Size = New System.Drawing.Size(90, 20)
        Me.txtFechaInicio.TabIndex = 129
        '
        'lblFechaInicio
        '
        Me.lblFechaInicio.AutoSize = True
        Me.lblFechaInicio.Font = New System.Drawing.Font("MS Reference Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFechaInicio.ForeColor = System.Drawing.Color.Gold
        Me.lblFechaInicio.Location = New System.Drawing.Point(12, 158)
        Me.lblFechaInicio.Name = "lblFechaInicio"
        Me.lblFechaInicio.Size = New System.Drawing.Size(71, 15)
        Me.lblFechaInicio.TabIndex = 130
        Me.lblFechaInicio.Text = "FechaInicio"
        '
        'lblFechaFin
        '
        Me.lblFechaFin.AutoSize = True
        Me.lblFechaFin.Font = New System.Drawing.Font("MS Reference Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFechaFin.ForeColor = System.Drawing.Color.Gold
        Me.lblFechaFin.Location = New System.Drawing.Point(126, 158)
        Me.lblFechaFin.Name = "lblFechaFin"
        Me.lblFechaFin.Size = New System.Drawing.Size(56, 15)
        Me.lblFechaFin.TabIndex = 132
        Me.lblFechaFin.Text = "FechaFin"
        '
        'txtFechaFin
        '
        Me.txtFechaFin.Enabled = False
        Me.txtFechaFin.Location = New System.Drawing.Point(126, 178)
        Me.txtFechaFin.Name = "txtFechaFin"
        Me.txtFechaFin.Size = New System.Drawing.Size(90, 20)
        Me.txtFechaFin.TabIndex = 131
        '
        'dtpFechaAsistencia
        '
        Me.dtpFechaAsistencia.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFechaAsistencia.Location = New System.Drawing.Point(236, 175)
        Me.dtpFechaAsistencia.Name = "dtpFechaAsistencia"
        Me.dtpFechaAsistencia.Size = New System.Drawing.Size(103, 20)
        Me.dtpFechaAsistencia.TabIndex = 133
        '
        'chkSeleccionarTodos
        '
        Me.chkSeleccionarTodos.Font = New System.Drawing.Font("MS Reference Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkSeleccionarTodos.ForeColor = System.Drawing.Color.Gold
        Me.chkSeleccionarTodos.Location = New System.Drawing.Point(397, 156)
        Me.chkSeleccionarTodos.Name = "chkSeleccionarTodos"
        Me.chkSeleccionarTodos.Size = New System.Drawing.Size(130, 50)
        Me.chkSeleccionarTodos.TabIndex = 134
        Me.chkSeleccionarTodos.Text = "Seleccionar Todos los Alumnos"
        Me.chkSeleccionarTodos.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.chkSeleccionarTodos.UseVisualStyleBackColor = True
        '
        'BarraHerramientas
        '
        Me.BarraHerramientas.BackColor = System.Drawing.Color.DarkOliveGreen
        Me.BarraHerramientas.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.BarraHerramientas.ImageScalingSize = New System.Drawing.Size(40, 40)
        Me.BarraHerramientas.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tlbEditar, Me.tlbGuardar, Me.tlbCancelar})
        Me.BarraHerramientas.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow
        Me.BarraHerramientas.Location = New System.Drawing.Point(0, 0)
        Me.BarraHerramientas.Name = "BarraHerramientas"
        Me.BarraHerramientas.Size = New System.Drawing.Size(554, 66)
        Me.BarraHerramientas.TabIndex = 136
        Me.BarraHerramientas.Text = "ToolStrip1"
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
        'tlbGuardar
        '
        Me.tlbGuardar.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tlbGuardar.ForeColor = System.Drawing.Color.Gold
        Me.tlbGuardar.Image = Global.Formacion.My.Resources.Resources.Guardar
        Me.tlbGuardar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tlbGuardar.Margin = New System.Windows.Forms.Padding(340, 2, 2, 2)
        Me.tlbGuardar.Name = "tlbGuardar"
        Me.tlbGuardar.Size = New System.Drawing.Size(61, 62)
        Me.tlbGuardar.Text = "Guardar"
        Me.tlbGuardar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.tlbGuardar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'tlbCancelar
        '
        Me.tlbCancelar.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tlbCancelar.ForeColor = System.Drawing.Color.Gold
        Me.tlbCancelar.Image = Global.Formacion.My.Resources.Resources.Cancelar
        Me.tlbCancelar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tlbCancelar.Name = "tlbCancelar"
        Me.tlbCancelar.Size = New System.Drawing.Size(65, 63)
        Me.tlbCancelar.Text = "Cancelar"
        Me.tlbCancelar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'frmAsistenciasAlumno
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(554, 518)
        Me.Controls.Add(Me.BarraHerramientas)
        Me.Controls.Add(Me.chkSeleccionarTodos)
        Me.Controls.Add(Me.dtpFechaAsistencia)
        Me.Controls.Add(Me.lblFechaFin)
        Me.Controls.Add(Me.txtFechaFin)
        Me.Controls.Add(Me.lblFechaInicio)
        Me.Controls.Add(Me.txtFechaInicio)
        Me.Controls.Add(Me.dgvListadoCursos)
        Me.Controls.Add(Me.lblCurso)
        Me.Controls.Add(Me.cboCursos)
        Me.Controls.Add(Me.lblFechaAsistencia)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmAsistenciasAlumno"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ASISTENCIAS DE ALUMNOS"
        CType(Me.dgvListadoCursos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.BarraHerramientas.ResumeLayout(False)
        Me.BarraHerramientas.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblCurso As System.Windows.Forms.Label
    Friend WithEvents cboCursos As System.Windows.Forms.ComboBox
    Friend WithEvents lblFechaAsistencia As System.Windows.Forms.Label
    Friend WithEvents dgvListadoCursos As System.Windows.Forms.DataGridView
    Friend WithEvents txtFechaInicio As System.Windows.Forms.TextBox
    Friend WithEvents lblFechaInicio As System.Windows.Forms.Label
    Friend WithEvents lblFechaFin As System.Windows.Forms.Label
    Friend WithEvents txtFechaFin As System.Windows.Forms.TextBox
    Friend WithEvents dtpFechaAsistencia As System.Windows.Forms.DateTimePicker
    Friend WithEvents chkSeleccionarTodos As System.Windows.Forms.CheckBox
    Friend WithEvents BarraHerramientas As System.Windows.Forms.ToolStrip
    Friend WithEvents tlbEditar As System.Windows.Forms.ToolStripButton
    Friend WithEvents tlbGuardar As System.Windows.Forms.ToolStripButton
    Friend WithEvents tlbCancelar As System.Windows.Forms.ToolStripButton
    Friend WithEvents clnNombre As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents clnCodigoMatricula As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents clnFecha As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents clnAsistencia As System.Windows.Forms.DataGridViewCheckBoxColumn
End Class
