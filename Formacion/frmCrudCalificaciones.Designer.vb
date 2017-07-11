<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCrudCalificaciones
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmCrudCalificaciones))
        Me.lblCursos = New System.Windows.Forms.Label()
        Me.dgvListadoAlumnos = New System.Windows.Forms.DataGridView()
        Me.clnNif = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.clnCodigoMatricula = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.clnNombre = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.clnCalificacion = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.clnObservaciones = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.lblDobleClicNif = New System.Windows.Forms.Label()
        Me.cboCursos = New System.Windows.Forms.ComboBox()
        Me.BarraHerramientas = New System.Windows.Forms.ToolStrip()
        Me.tlbEditar = New System.Windows.Forms.ToolStripButton()
        Me.tlbBuscar = New System.Windows.Forms.ToolStripButton()
        Me.tlbGuardar = New System.Windows.Forms.ToolStripButton()
        Me.tlbCancelar = New System.Windows.Forms.ToolStripButton()
        CType(Me.dgvListadoAlumnos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.BarraHerramientas.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblCursos
        '
        Me.lblCursos.AutoSize = True
        Me.lblCursos.Location = New System.Drawing.Point(12, 76)
        Me.lblCursos.Name = "lblCursos"
        Me.lblCursos.Size = New System.Drawing.Size(46, 15)
        Me.lblCursos.TabIndex = 97
        Me.lblCursos.Text = "Curso:"
        Me.lblCursos.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'dgvListadoAlumnos
        '
        Me.dgvListadoAlumnos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvListadoAlumnos.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.clnNif, Me.clnCodigoMatricula, Me.clnNombre, Me.clnCalificacion, Me.clnObservaciones})
        Me.dgvListadoAlumnos.Location = New System.Drawing.Point(12, 134)
        Me.dgvListadoAlumnos.Name = "dgvListadoAlumnos"
        Me.dgvListadoAlumnos.RowHeadersVisible = False
        Me.dgvListadoAlumnos.Size = New System.Drawing.Size(636, 253)
        Me.dgvListadoAlumnos.TabIndex = 127
        '
        'clnNif
        '
        Me.clnNif.DataPropertyName = "NIF"
        Me.clnNif.HeaderText = "NIF"
        Me.clnNif.Name = "clnNif"
        Me.clnNif.Width = 80
        '
        'clnCodigoMatricula
        '
        Me.clnCodigoMatricula.DataPropertyName = "CodigoMatricula"
        Me.clnCodigoMatricula.HeaderText = "CODIGOMATRICULA"
        Me.clnCodigoMatricula.Name = "clnCodigoMatricula"
        Me.clnCodigoMatricula.Visible = False
        '
        'clnNombre
        '
        Me.clnNombre.DataPropertyName = "NombreAlumno"
        Me.clnNombre.HeaderText = "NOMBRE"
        Me.clnNombre.Name = "clnNombre"
        Me.clnNombre.Width = 250
        '
        'clnCalificacion
        '
        Me.clnCalificacion.DataPropertyName = "Calificacion"
        DataGridViewCellStyle1.Format = "N2"
        Me.clnCalificacion.DefaultCellStyle = DataGridViewCellStyle1
        Me.clnCalificacion.HeaderText = "CALIF."
        Me.clnCalificacion.Name = "clnCalificacion"
        Me.clnCalificacion.Width = 65
        '
        'clnObservaciones
        '
        Me.clnObservaciones.DataPropertyName = "Observaciones"
        Me.clnObservaciones.HeaderText = "OBSERVACIONES"
        Me.clnObservaciones.Name = "clnObservaciones"
        Me.clnObservaciones.Width = 220
        '
        'lblDobleClicNif
        '
        Me.lblDobleClicNif.AutoSize = True
        Me.lblDobleClicNif.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDobleClicNif.Location = New System.Drawing.Point(12, 390)
        Me.lblDobleClicNif.Name = "lblDobleClicNif"
        Me.lblDobleClicNif.Size = New System.Drawing.Size(301, 13)
        Me.lblDobleClicNif.TabIndex = 128
        Me.lblDobleClicNif.Text = "Doble Clic en la columna NIF para Editar el  Alumno"
        '
        'cboCursos
        '
        Me.cboCursos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboCursos.FormattingEnabled = True
        Me.cboCursos.Location = New System.Drawing.Point(12, 96)
        Me.cboCursos.Name = "cboCursos"
        Me.cboCursos.Size = New System.Drawing.Size(636, 23)
        Me.cboCursos.TabIndex = 129
        '
        'BarraHerramientas
        '
        Me.BarraHerramientas.BackColor = System.Drawing.Color.DarkOliveGreen
        Me.BarraHerramientas.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.BarraHerramientas.ImageScalingSize = New System.Drawing.Size(40, 40)
        Me.BarraHerramientas.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tlbEditar, Me.tlbBuscar, Me.tlbGuardar, Me.tlbCancelar})
        Me.BarraHerramientas.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow
        Me.BarraHerramientas.Location = New System.Drawing.Point(0, 0)
        Me.BarraHerramientas.Name = "BarraHerramientas"
        Me.BarraHerramientas.Size = New System.Drawing.Size(664, 66)
        Me.BarraHerramientas.TabIndex = 137
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
        Me.tlbGuardar.Margin = New System.Windows.Forms.Padding(390, 2, 2, 2)
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
        'frmCrudCalificaciones
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(664, 414)
        Me.Controls.Add(Me.BarraHerramientas)
        Me.Controls.Add(Me.cboCursos)
        Me.Controls.Add(Me.lblDobleClicNif)
        Me.Controls.Add(Me.dgvListadoAlumnos)
        Me.Controls.Add(Me.lblCursos)
        Me.Font = New System.Drawing.Font("MS Reference Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.Color.Gold
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmCrudCalificaciones"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "MANTENIMIENTO DE CALIFICACIONES"
        CType(Me.dgvListadoAlumnos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.BarraHerramientas.ResumeLayout(False)
        Me.BarraHerramientas.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblCursos As System.Windows.Forms.Label
    Friend WithEvents dgvListadoAlumnos As System.Windows.Forms.DataGridView
    Friend WithEvents lblDobleClicNif As System.Windows.Forms.Label
    Friend WithEvents cboCursos As System.Windows.Forms.ComboBox
    Friend WithEvents BarraHerramientas As System.Windows.Forms.ToolStrip
    Friend WithEvents tlbEditar As System.Windows.Forms.ToolStripButton
    Friend WithEvents tlbBuscar As System.Windows.Forms.ToolStripButton
    Friend WithEvents tlbGuardar As System.Windows.Forms.ToolStripButton
    Friend WithEvents tlbCancelar As System.Windows.Forms.ToolStripButton
    Friend WithEvents clnNif As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents clnCodigoMatricula As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents clnNombre As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents clnCalificacion As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents clnObservaciones As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
