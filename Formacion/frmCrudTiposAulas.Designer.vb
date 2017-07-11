<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCrudTiposAulas
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmCrudTiposAulas))
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lblTipoAula = New System.Windows.Forms.Label()
        Me.txtTipoAula = New System.Windows.Forms.TextBox()
        Me.lblCodigo = New System.Windows.Forms.Label()
        Me.txtCodigo = New System.Windows.Forms.TextBox()
        Me.BarraHerramientas = New System.Windows.Forms.ToolStrip()
        Me.tlbNuevo = New System.Windows.Forms.ToolStripButton()
        Me.tlbEditar = New System.Windows.Forms.ToolStripButton()
        Me.tlbBorrar = New System.Windows.Forms.ToolStripButton()
        Me.tlbBuscar = New System.Windows.Forms.ToolStripButton()
        Me.tlbGuardar = New System.Windows.Forms.ToolStripButton()
        Me.tlbActualizar = New System.Windows.Forms.ToolStripButton()
        Me.tlbCancelar = New System.Windows.Forms.ToolStripButton()
        Me.btnBuscarCodigo = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.dgvListadoTiposAulas = New System.Windows.Forms.DataGridView()
        Me.clnCodigo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.clnTipo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BarraHerramientas.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.dgvListadoTiposAulas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(147, 675)
        Me.Label2.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(249, 13)
        Me.Label2.TabIndex = 133
        Me.Label2.Text = "Doble Clic en el Codigo para Editar el Aula"
        '
        'lblTipoAula
        '
        Me.lblTipoAula.AutoSize = True
        Me.lblTipoAula.Font = New System.Drawing.Font("MS Reference Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTipoAula.ForeColor = System.Drawing.Color.Gold
        Me.lblTipoAula.Location = New System.Drawing.Point(18, 76)
        Me.lblTipoAula.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.lblTipoAula.Name = "lblTipoAula"
        Me.lblTipoAula.Size = New System.Drawing.Size(83, 15)
        Me.lblTipoAula.TabIndex = 131
        Me.lblTipoAula.Text = "Tipo de Aula:"
        '
        'txtTipoAula
        '
        Me.txtTipoAula.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txtTipoAula.Font = New System.Drawing.Font("MS Reference Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTipoAula.ForeColor = System.Drawing.Color.White
        Me.txtTipoAula.Location = New System.Drawing.Point(18, 94)
        Me.txtTipoAula.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.txtTipoAula.MaxLength = 30
        Me.txtTipoAula.Name = "txtTipoAula"
        Me.txtTipoAula.Size = New System.Drawing.Size(216, 21)
        Me.txtTipoAula.TabIndex = 130
        '
        'lblCodigo
        '
        Me.lblCodigo.AutoSize = True
        Me.lblCodigo.Font = New System.Drawing.Font("MS Reference Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCodigo.ForeColor = System.Drawing.Color.Gold
        Me.lblCodigo.Location = New System.Drawing.Point(18, 23)
        Me.lblCodigo.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.lblCodigo.Name = "lblCodigo"
        Me.lblCodigo.Size = New System.Drawing.Size(52, 15)
        Me.lblCodigo.TabIndex = 129
        Me.lblCodigo.Text = "Código:"
        '
        'txtCodigo
        '
        Me.txtCodigo.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txtCodigo.Font = New System.Drawing.Font("MS Reference Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCodigo.ForeColor = System.Drawing.Color.White
        Me.txtCodigo.Location = New System.Drawing.Point(18, 41)
        Me.txtCodigo.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.txtCodigo.MaxLength = 4
        Me.txtCodigo.Name = "txtCodigo"
        Me.txtCodigo.Size = New System.Drawing.Size(52, 21)
        Me.txtCodigo.TabIndex = 128
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
        Me.BarraHerramientas.Size = New System.Drawing.Size(415, 66)
        Me.BarraHerramientas.TabIndex = 134
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
        Me.tlbGuardar.Margin = New System.Windows.Forms.Padding(50, 2, 2, 2)
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
        Me.tlbActualizar.Margin = New System.Windows.Forms.Padding(45, 2, 2, 2)
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
        'btnBuscarCodigo
        '
        Me.btnBuscarCodigo.BackgroundImage = Global.Formacion.My.Resources.Resources.BuscarIcono
        Me.btnBuscarCodigo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnBuscarCodigo.Location = New System.Drawing.Point(79, 37)
        Me.btnBuscarCodigo.Name = "btnBuscarCodigo"
        Me.btnBuscarCodigo.Size = New System.Drawing.Size(28, 29)
        Me.btnBuscarCodigo.TabIndex = 144
        Me.btnBuscarCodigo.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txtTipoAula)
        Me.GroupBox1.Controls.Add(Me.txtCodigo)
        Me.GroupBox1.Controls.Add(Me.btnBuscarCodigo)
        Me.GroupBox1.Controls.Add(Me.lblCodigo)
        Me.GroupBox1.Controls.Add(Me.lblTipoAula)
        Me.GroupBox1.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.Color.Gold
        Me.GroupBox1.Location = New System.Drawing.Point(14, 69)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(387, 125)
        Me.GroupBox1.TabIndex = 146
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Datos"
        '
        'dgvListadoTiposAulas
        '
        Me.dgvListadoTiposAulas.AllowUserToAddRows = False
        Me.dgvListadoTiposAulas.AllowUserToDeleteRows = False
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("MS Reference Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvListadoTiposAulas.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvListadoTiposAulas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvListadoTiposAulas.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.clnCodigo, Me.clnTipo})
        Me.dgvListadoTiposAulas.Location = New System.Drawing.Point(14, 200)
        Me.dgvListadoTiposAulas.Name = "dgvListadoTiposAulas"
        Me.dgvListadoTiposAulas.ReadOnly = True
        Me.dgvListadoTiposAulas.Size = New System.Drawing.Size(387, 223)
        Me.dgvListadoTiposAulas.TabIndex = 147
        '
        'clnCodigo
        '
        Me.clnCodigo.DataPropertyName = "Codigo"
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.clnCodigo.DefaultCellStyle = DataGridViewCellStyle2
        Me.clnCodigo.HeaderText = "CODIGO"
        Me.clnCodigo.Name = "clnCodigo"
        Me.clnCodigo.ReadOnly = True
        '
        'clnTipo
        '
        Me.clnTipo.DataPropertyName = "Tipo"
        Me.clnTipo.HeaderText = "TIPO"
        Me.clnTipo.Name = "clnTipo"
        Me.clnTipo.ReadOnly = True
        Me.clnTipo.Width = 265
        '
        'frmCrudTiposAulas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 19.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(415, 438)
        Me.Controls.Add(Me.dgvListadoTiposAulas)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.BarraHerramientas)
        Me.Controls.Add(Me.Label2)
        Me.Font = New System.Drawing.Font("MS Reference Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.Name = "frmCrudTiposAulas"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "MANTENIMIENTO DE TIPOS DE AULAS"
        Me.BarraHerramientas.ResumeLayout(False)
        Me.BarraHerramientas.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.dgvListadoTiposAulas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents lblTipoAula As System.Windows.Forms.Label
    Friend WithEvents txtTipoAula As System.Windows.Forms.TextBox
    Friend WithEvents lblCodigo As System.Windows.Forms.Label
    Friend WithEvents txtCodigo As System.Windows.Forms.TextBox
    Friend WithEvents BarraHerramientas As System.Windows.Forms.ToolStrip
    Friend WithEvents tlbNuevo As System.Windows.Forms.ToolStripButton
    Friend WithEvents tlbEditar As System.Windows.Forms.ToolStripButton
    Friend WithEvents tlbBorrar As System.Windows.Forms.ToolStripButton
    Friend WithEvents tlbBuscar As System.Windows.Forms.ToolStripButton
    Friend WithEvents tlbGuardar As System.Windows.Forms.ToolStripButton
    Friend WithEvents tlbActualizar As System.Windows.Forms.ToolStripButton
    Friend WithEvents tlbCancelar As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnBuscarCodigo As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents dgvListadoTiposAulas As System.Windows.Forms.DataGridView
    Friend WithEvents clnCodigo As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents clnTipo As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
