<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCrudLogin
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmCrudLogin))
        Me.lblNombreCompleto = New System.Windows.Forms.Label()
        Me.lblNif = New System.Windows.Forms.Label()
        Me.lblUsuario = New System.Windows.Forms.Label()
        Me.txtUsuario = New System.Windows.Forms.TextBox()
        Me.lblContraseña = New System.Windows.Forms.Label()
        Me.txtContraseña = New System.Windows.Forms.TextBox()
        Me.BarraHerramientas = New System.Windows.Forms.ToolStrip()
        Me.tlbEditar = New System.Windows.Forms.ToolStripButton()
        Me.tlbBorrar = New System.Windows.Forms.ToolStripButton()
        Me.tlbGuardar = New System.Windows.Forms.ToolStripButton()
        Me.tlbCancelar = New System.Windows.Forms.ToolStripButton()
        Me.lblTipoUsuario = New System.Windows.Forms.Label()
        Me.cboTipoUsuario = New System.Windows.Forms.ComboBox()
        Me.lblNombreCompletoText = New System.Windows.Forms.Label()
        Me.txtNif = New System.Windows.Forms.TextBox()
        Me.BarraHerramientas.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblNombreCompleto
        '
        Me.lblNombreCompleto.AutoSize = True
        Me.lblNombreCompleto.Location = New System.Drawing.Point(102, 90)
        Me.lblNombreCompleto.Name = "lblNombreCompleto"
        Me.lblNombreCompleto.Size = New System.Drawing.Size(116, 15)
        Me.lblNombreCompleto.TabIndex = 120
        Me.lblNombreCompleto.Text = "Nombre Completo:"
        '
        'lblNif
        '
        Me.lblNif.AutoSize = True
        Me.lblNif.Location = New System.Drawing.Point(10, 90)
        Me.lblNif.Name = "lblNif"
        Me.lblNif.Size = New System.Drawing.Size(31, 15)
        Me.lblNif.TabIndex = 118
        Me.lblNif.Text = "NIF:"
        '
        'lblUsuario
        '
        Me.lblUsuario.AutoSize = True
        Me.lblUsuario.Location = New System.Drawing.Point(10, 154)
        Me.lblUsuario.Name = "lblUsuario"
        Me.lblUsuario.Size = New System.Drawing.Size(55, 15)
        Me.lblUsuario.TabIndex = 125
        Me.lblUsuario.Text = "Usuario:"
        '
        'txtUsuario
        '
        Me.txtUsuario.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txtUsuario.ForeColor = System.Drawing.Color.White
        Me.txtUsuario.Location = New System.Drawing.Point(10, 172)
        Me.txtUsuario.MaxLength = 50
        Me.txtUsuario.Name = "txtUsuario"
        Me.txtUsuario.Size = New System.Drawing.Size(150, 21)
        Me.txtUsuario.TabIndex = 4
        '
        'lblContraseña
        '
        Me.lblContraseña.AutoSize = True
        Me.lblContraseña.Location = New System.Drawing.Point(179, 153)
        Me.lblContraseña.Name = "lblContraseña"
        Me.lblContraseña.Size = New System.Drawing.Size(78, 15)
        Me.lblContraseña.TabIndex = 127
        Me.lblContraseña.Text = "Contraseña:"
        '
        'txtContraseña
        '
        Me.txtContraseña.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txtContraseña.ForeColor = System.Drawing.Color.White
        Me.txtContraseña.Location = New System.Drawing.Point(179, 171)
        Me.txtContraseña.MaxLength = 50
        Me.txtContraseña.Name = "txtContraseña"
        Me.txtContraseña.Size = New System.Drawing.Size(161, 21)
        Me.txtContraseña.TabIndex = 5
        Me.txtContraseña.Text = "*****CODIFICADA*****"
        Me.txtContraseña.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'BarraHerramientas
        '
        Me.BarraHerramientas.BackColor = System.Drawing.Color.DarkOliveGreen
        Me.BarraHerramientas.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.BarraHerramientas.ImageScalingSize = New System.Drawing.Size(40, 40)
        Me.BarraHerramientas.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tlbEditar, Me.tlbBorrar, Me.tlbGuardar, Me.tlbCancelar})
        Me.BarraHerramientas.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow
        Me.BarraHerramientas.Location = New System.Drawing.Point(0, 0)
        Me.BarraHerramientas.Name = "BarraHerramientas"
        Me.BarraHerramientas.Size = New System.Drawing.Size(531, 66)
        Me.BarraHerramientas.TabIndex = 135
        Me.BarraHerramientas.TabStop = True
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
        'tlbBorrar
        '
        Me.tlbBorrar.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tlbBorrar.ForeColor = System.Drawing.Color.Gold
        Me.tlbBorrar.Image = Global.Formacion.My.Resources.Resources.Borrar
        Me.tlbBorrar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tlbBorrar.Margin = New System.Windows.Forms.Padding(2)
        Me.tlbBorrar.Name = "tlbBorrar"
        Me.tlbBorrar.Size = New System.Drawing.Size(85, 62)
        Me.tlbBorrar.Text = "Borrar Cajas"
        Me.tlbBorrar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.tlbBorrar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'tlbGuardar
        '
        Me.tlbGuardar.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tlbGuardar.ForeColor = System.Drawing.Color.Gold
        Me.tlbGuardar.Image = Global.Formacion.My.Resources.Resources.Guardar
        Me.tlbGuardar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tlbGuardar.Margin = New System.Windows.Forms.Padding(230, 2, 2, 2)
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
        'lblTipoUsuario
        '
        Me.lblTipoUsuario.AutoSize = True
        Me.lblTipoUsuario.Location = New System.Drawing.Point(357, 153)
        Me.lblTipoUsuario.Name = "lblTipoUsuario"
        Me.lblTipoUsuario.Size = New System.Drawing.Size(101, 15)
        Me.lblTipoUsuario.TabIndex = 128
        Me.lblTipoUsuario.Text = "Tipo de Usuario:"
        '
        'cboTipoUsuario
        '
        Me.cboTipoUsuario.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.cboTipoUsuario.ForeColor = System.Drawing.Color.White
        Me.cboTipoUsuario.FormattingEnabled = True
        Me.cboTipoUsuario.Location = New System.Drawing.Point(360, 171)
        Me.cboTipoUsuario.Name = "cboTipoUsuario"
        Me.cboTipoUsuario.Size = New System.Drawing.Size(159, 23)
        Me.cboTipoUsuario.TabIndex = 6
        '
        'lblNombreCompletoText
        '
        Me.lblNombreCompletoText.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblNombreCompletoText.Font = New System.Drawing.Font("MS Reference Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNombreCompletoText.Location = New System.Drawing.Point(105, 106)
        Me.lblNombreCompletoText.Name = "lblNombreCompletoText"
        Me.lblNombreCompletoText.Size = New System.Drawing.Size(414, 21)
        Me.lblNombreCompletoText.TabIndex = 136
        '
        'txtNif
        '
        Me.txtNif.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txtNif.ForeColor = System.Drawing.Color.White
        Me.txtNif.Location = New System.Drawing.Point(10, 106)
        Me.txtNif.MaxLength = 9
        Me.txtNif.Name = "txtNif"
        Me.txtNif.Size = New System.Drawing.Size(77, 21)
        Me.txtNif.TabIndex = 3
        '
        'frmCrudLogin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(531, 226)
        Me.Controls.Add(Me.txtNif)
        Me.Controls.Add(Me.lblNombreCompletoText)
        Me.Controls.Add(Me.BarraHerramientas)
        Me.Controls.Add(Me.cboTipoUsuario)
        Me.Controls.Add(Me.lblTipoUsuario)
        Me.Controls.Add(Me.lblContraseña)
        Me.Controls.Add(Me.txtContraseña)
        Me.Controls.Add(Me.lblUsuario)
        Me.Controls.Add(Me.txtUsuario)
        Me.Controls.Add(Me.lblNombreCompleto)
        Me.Controls.Add(Me.lblNif)
        Me.Font = New System.Drawing.Font("MS Reference Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.Color.Gold
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmCrudLogin"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "MANTENIMIENTO DE DATOS DE ACCESO"
        Me.BarraHerramientas.ResumeLayout(False)
        Me.BarraHerramientas.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblNombreCompleto As System.Windows.Forms.Label
    Friend WithEvents lblNif As System.Windows.Forms.Label
    Friend WithEvents lblUsuario As System.Windows.Forms.Label
    Friend WithEvents txtUsuario As System.Windows.Forms.TextBox
    Friend WithEvents lblContraseña As System.Windows.Forms.Label
    Friend WithEvents txtContraseña As System.Windows.Forms.TextBox
    Friend WithEvents BarraHerramientas As System.Windows.Forms.ToolStrip
    Friend WithEvents tlbEditar As System.Windows.Forms.ToolStripButton
    Friend WithEvents tlbBorrar As System.Windows.Forms.ToolStripButton
    Friend WithEvents tlbGuardar As System.Windows.Forms.ToolStripButton
    Friend WithEvents tlbCancelar As System.Windows.Forms.ToolStripButton
    Friend WithEvents lblTipoUsuario As System.Windows.Forms.Label
    Friend WithEvents cboTipoUsuario As System.Windows.Forms.ComboBox
    Friend WithEvents lblNombreCompletoText As System.Windows.Forms.Label
    Friend WithEvents txtNif As System.Windows.Forms.TextBox
End Class
