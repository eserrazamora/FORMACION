﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCrudTiposUsuarios
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
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmCrudTiposUsuarios))
        Me.dgvListadoTiposUsuarios = New System.Windows.Forms.DataGridView()
        Me.clnCodigo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.clnTipo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.lblTipo = New System.Windows.Forms.Label()
        Me.txtTipoUsuario = New System.Windows.Forms.TextBox()
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
        Me.grpDatos = New System.Windows.Forms.GroupBox()
        Me.btnBuscarCodigo = New System.Windows.Forms.Button()
        CType(Me.dgvListadoTiposUsuarios, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.BarraHerramientas.SuspendLayout()
        Me.grpDatos.SuspendLayout()
        Me.SuspendLayout()
        '
        'dgvListadoTiposUsuarios
        '
        Me.dgvListadoTiposUsuarios.AllowUserToAddRows = False
        Me.dgvListadoTiposUsuarios.AllowUserToDeleteRows = False
        Me.dgvListadoTiposUsuarios.AllowUserToResizeColumns = False
        Me.dgvListadoTiposUsuarios.AllowUserToResizeRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.Silver
        Me.dgvListadoTiposUsuarios.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvListadoTiposUsuarios.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.DarkOliveGreen
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.Gold
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvListadoTiposUsuarios.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.dgvListadoTiposUsuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.dgvListadoTiposUsuarios.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.clnCodigo, Me.clnTipo})
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle3.Font = New System.Drawing.Font("MS Reference Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Yellow
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvListadoTiposUsuarios.DefaultCellStyle = DataGridViewCellStyle3
        Me.dgvListadoTiposUsuarios.EnableHeadersVisualStyles = False
        Me.dgvListadoTiposUsuarios.Location = New System.Drawing.Point(12, 209)
        Me.dgvListadoTiposUsuarios.Name = "dgvListadoTiposUsuarios"
        Me.dgvListadoTiposUsuarios.RowHeadersVisible = False
        Me.dgvListadoTiposUsuarios.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvListadoTiposUsuarios.ShowEditingIcon = False
        Me.dgvListadoTiposUsuarios.Size = New System.Drawing.Size(420, 178)
        Me.dgvListadoTiposUsuarios.TabIndex = 137
        '
        'clnCodigo
        '
        Me.clnCodigo.DataPropertyName = "Codigo"
        Me.clnCodigo.HeaderText = "CODIGO"
        Me.clnCodigo.Name = "clnCodigo"
        Me.clnCodigo.ReadOnly = True
        Me.clnCodigo.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        '
        'clnTipo
        '
        Me.clnTipo.DataPropertyName = "Tipo"
        Me.clnTipo.HeaderText = "TIPOS DE USUARIOS"
        Me.clnTipo.Name = "clnTipo"
        Me.clnTipo.ReadOnly = True
        Me.clnTipo.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.clnTipo.Width = 300
        '
        'lblTipo
        '
        Me.lblTipo.AutoSize = True
        Me.lblTipo.Font = New System.Drawing.Font("MS Reference Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTipo.Location = New System.Drawing.Point(15, 79)
        Me.lblTipo.Name = "lblTipo"
        Me.lblTipo.Size = New System.Drawing.Size(101, 15)
        Me.lblTipo.TabIndex = 136
        Me.lblTipo.Text = "Tipo de Usuario:"
        '
        'txtTipoUsuario
        '
        Me.txtTipoUsuario.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txtTipoUsuario.Font = New System.Drawing.Font("MS Reference Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTipoUsuario.ForeColor = System.Drawing.Color.White
        Me.txtTipoUsuario.Location = New System.Drawing.Point(15, 95)
        Me.txtTipoUsuario.MaxLength = 20
        Me.txtTipoUsuario.Name = "txtTipoUsuario"
        Me.txtTipoUsuario.Size = New System.Drawing.Size(151, 21)
        Me.txtTipoUsuario.TabIndex = 135
        '
        'lblCodigo
        '
        Me.lblCodigo.AutoSize = True
        Me.lblCodigo.Font = New System.Drawing.Font("MS Reference Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCodigo.Location = New System.Drawing.Point(15, 27)
        Me.lblCodigo.Name = "lblCodigo"
        Me.lblCodigo.Size = New System.Drawing.Size(52, 15)
        Me.lblCodigo.TabIndex = 134
        Me.lblCodigo.Text = "Código:"
        '
        'txtCodigo
        '
        Me.txtCodigo.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txtCodigo.Font = New System.Drawing.Font("MS Reference Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCodigo.ForeColor = System.Drawing.Color.White
        Me.txtCodigo.Location = New System.Drawing.Point(15, 43)
        Me.txtCodigo.MaxLength = 2
        Me.txtCodigo.Name = "txtCodigo"
        Me.txtCodigo.Size = New System.Drawing.Size(52, 21)
        Me.txtCodigo.TabIndex = 133
        Me.txtCodigo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
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
        Me.BarraHerramientas.Size = New System.Drawing.Size(448, 66)
        Me.BarraHerramientas.TabIndex = 138
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
        Me.tlbGuardar.Margin = New System.Windows.Forms.Padding(80, 2, 2, 2)
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
        Me.tlbActualizar.Margin = New System.Windows.Forms.Padding(75, 2, 2, 2)
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
        'grpDatos
        '
        Me.grpDatos.Controls.Add(Me.btnBuscarCodigo)
        Me.grpDatos.Controls.Add(Me.txtTipoUsuario)
        Me.grpDatos.Controls.Add(Me.txtCodigo)
        Me.grpDatos.Controls.Add(Me.lblTipo)
        Me.grpDatos.Controls.Add(Me.lblCodigo)
        Me.grpDatos.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpDatos.ForeColor = System.Drawing.Color.Gold
        Me.grpDatos.Location = New System.Drawing.Point(12, 69)
        Me.grpDatos.Name = "grpDatos"
        Me.grpDatos.Size = New System.Drawing.Size(420, 134)
        Me.grpDatos.TabIndex = 139
        Me.grpDatos.TabStop = False
        Me.grpDatos.Text = "Datos"
        '
        'btnBuscarCodigo
        '
        Me.btnBuscarCodigo.BackgroundImage = Global.Formacion.My.Resources.Resources.BuscarIcono
        Me.btnBuscarCodigo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnBuscarCodigo.Location = New System.Drawing.Point(73, 40)
        Me.btnBuscarCodigo.Name = "btnBuscarCodigo"
        Me.btnBuscarCodigo.Size = New System.Drawing.Size(23, 26)
        Me.btnBuscarCodigo.TabIndex = 143
        Me.btnBuscarCodigo.UseVisualStyleBackColor = True
        '
        'frmCrudTiposUsuarios
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(448, 404)
        Me.Controls.Add(Me.grpDatos)
        Me.Controls.Add(Me.BarraHerramientas)
        Me.Controls.Add(Me.dgvListadoTiposUsuarios)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmCrudTiposUsuarios"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "MANTENIMIENTO DE TIPOS DE USUARIOS"
        CType(Me.dgvListadoTiposUsuarios, System.ComponentModel.ISupportInitialize).EndInit()
        Me.BarraHerramientas.ResumeLayout(False)
        Me.BarraHerramientas.PerformLayout()
        Me.grpDatos.ResumeLayout(False)
        Me.grpDatos.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents dgvListadoTiposUsuarios As System.Windows.Forms.DataGridView
    Friend WithEvents lblTipo As System.Windows.Forms.Label
    Friend WithEvents txtTipoUsuario As System.Windows.Forms.TextBox
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
    Friend WithEvents grpDatos As System.Windows.Forms.GroupBox
    Friend WithEvents btnBuscarCodigo As System.Windows.Forms.Button
    Friend WithEvents clnCodigo As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents clnTipo As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
