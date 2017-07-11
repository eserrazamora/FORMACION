<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmConsultaAlumnos
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
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmConsultaAlumnos))
        Me.lblEmail = New System.Windows.Forms.Label()
        Me.txtEmail = New System.Windows.Forms.TextBox()
        Me.lblMovil = New System.Windows.Forms.Label()
        Me.txtTelefonoMovil = New System.Windows.Forms.TextBox()
        Me.lblTelefonoFijo = New System.Windows.Forms.Label()
        Me.txtTelefonoFijo = New System.Windows.Forms.TextBox()
        Me.lblApellidos = New System.Windows.Forms.Label()
        Me.txtApellidos = New System.Windows.Forms.TextBox()
        Me.lblNombre = New System.Windows.Forms.Label()
        Me.txtNombre = New System.Windows.Forms.TextBox()
        Me.lblNif = New System.Windows.Forms.Label()
        Me.txtNif = New System.Windows.Forms.TextBox()
        Me.dgvListadoAlumnos = New System.Windows.Forms.DataGridView()
        Me.btnBorrar = New System.Windows.Forms.Button()
        Me.btnBuscar = New System.Windows.Forms.Button()
        Me.lblLimpiar = New System.Windows.Forms.Label()
        Me.lblConsultar = New System.Windows.Forms.Label()
        Me.clnNif = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.clnNombre = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.clnApellidos = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.clnTlfFijo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.clnTlfMovil = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.clnEmail = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.dgvListadoAlumnos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblEmail
        '
        Me.lblEmail.AutoSize = True
        Me.lblEmail.Font = New System.Drawing.Font("MS Reference Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEmail.ForeColor = System.Drawing.Color.Gold
        Me.lblEmail.Location = New System.Drawing.Point(10, 125)
        Me.lblEmail.Name = "lblEmail"
        Me.lblEmail.Size = New System.Drawing.Size(43, 15)
        Me.lblEmail.TabIndex = 30
        Me.lblEmail.Text = "Email:"
        '
        'txtEmail
        '
        Me.txtEmail.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txtEmail.ForeColor = System.Drawing.Color.White
        Me.txtEmail.Location = New System.Drawing.Point(12, 141)
        Me.txtEmail.MaxLength = 80
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.Size = New System.Drawing.Size(513, 20)
        Me.txtEmail.TabIndex = 5
        '
        'lblMovil
        '
        Me.lblMovil.AutoSize = True
        Me.lblMovil.Font = New System.Drawing.Font("MS Reference Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMovil.ForeColor = System.Drawing.Color.Gold
        Me.lblMovil.Location = New System.Drawing.Point(394, 22)
        Me.lblMovil.Name = "lblMovil"
        Me.lblMovil.Size = New System.Drawing.Size(94, 15)
        Me.lblMovil.TabIndex = 28
        Me.lblMovil.Text = "Teléfono Móvil:"
        '
        'txtTelefonoMovil
        '
        Me.txtTelefonoMovil.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txtTelefonoMovil.ForeColor = System.Drawing.Color.White
        Me.txtTelefonoMovil.Location = New System.Drawing.Point(397, 41)
        Me.txtTelefonoMovil.MaxLength = 20
        Me.txtTelefonoMovil.Name = "txtTelefonoMovil"
        Me.txtTelefonoMovil.Size = New System.Drawing.Size(128, 20)
        Me.txtTelefonoMovil.TabIndex = 2
        '
        'lblTelefonoFijo
        '
        Me.lblTelefonoFijo.AutoSize = True
        Me.lblTelefonoFijo.Font = New System.Drawing.Font("MS Reference Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTelefonoFijo.ForeColor = System.Drawing.Color.Gold
        Me.lblTelefonoFijo.Location = New System.Drawing.Point(216, 22)
        Me.lblTelefonoFijo.Name = "lblTelefonoFijo"
        Me.lblTelefonoFijo.Size = New System.Drawing.Size(85, 15)
        Me.lblTelefonoFijo.TabIndex = 26
        Me.lblTelefonoFijo.Text = "Teléfono Fijo:"
        '
        'txtTelefonoFijo
        '
        Me.txtTelefonoFijo.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txtTelefonoFijo.ForeColor = System.Drawing.Color.White
        Me.txtTelefonoFijo.Location = New System.Drawing.Point(216, 41)
        Me.txtTelefonoFijo.MaxLength = 20
        Me.txtTelefonoFijo.Name = "txtTelefonoFijo"
        Me.txtTelefonoFijo.Size = New System.Drawing.Size(128, 20)
        Me.txtTelefonoFijo.TabIndex = 1
        '
        'lblApellidos
        '
        Me.lblApellidos.AutoSize = True
        Me.lblApellidos.Font = New System.Drawing.Font("MS Reference Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblApellidos.ForeColor = System.Drawing.Color.Gold
        Me.lblApellidos.Location = New System.Drawing.Point(213, 71)
        Me.lblApellidos.Name = "lblApellidos"
        Me.lblApellidos.Size = New System.Drawing.Size(63, 15)
        Me.lblApellidos.TabIndex = 24
        Me.lblApellidos.Text = "Apellidos:"
        '
        'txtApellidos
        '
        Me.txtApellidos.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txtApellidos.ForeColor = System.Drawing.Color.White
        Me.txtApellidos.Location = New System.Drawing.Point(216, 90)
        Me.txtApellidos.MaxLength = 50
        Me.txtApellidos.Name = "txtApellidos"
        Me.txtApellidos.Size = New System.Drawing.Size(309, 20)
        Me.txtApellidos.TabIndex = 4
        '
        'lblNombre
        '
        Me.lblNombre.AutoSize = True
        Me.lblNombre.Font = New System.Drawing.Font("MS Reference Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNombre.ForeColor = System.Drawing.Color.Gold
        Me.lblNombre.Location = New System.Drawing.Point(12, 71)
        Me.lblNombre.Name = "lblNombre"
        Me.lblNombre.Size = New System.Drawing.Size(57, 15)
        Me.lblNombre.TabIndex = 22
        Me.lblNombre.Text = "Nombre:"
        '
        'txtNombre
        '
        Me.txtNombre.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txtNombre.ForeColor = System.Drawing.Color.White
        Me.txtNombre.Location = New System.Drawing.Point(12, 90)
        Me.txtNombre.MaxLength = 30
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(188, 20)
        Me.txtNombre.TabIndex = 3
        '
        'lblNif
        '
        Me.lblNif.AutoSize = True
        Me.lblNif.Font = New System.Drawing.Font("MS Reference Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNif.ForeColor = System.Drawing.Color.Gold
        Me.lblNif.Location = New System.Drawing.Point(12, 22)
        Me.lblNif.Name = "lblNif"
        Me.lblNif.Size = New System.Drawing.Size(31, 15)
        Me.lblNif.TabIndex = 20
        Me.lblNif.Text = "NIF:"
        '
        'txtNif
        '
        Me.txtNif.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txtNif.ForeColor = System.Drawing.Color.White
        Me.txtNif.Location = New System.Drawing.Point(12, 41)
        Me.txtNif.MaxLength = 9
        Me.txtNif.Name = "txtNif"
        Me.txtNif.Size = New System.Drawing.Size(71, 20)
        Me.txtNif.TabIndex = 0
        '
        'dgvListadoAlumnos
        '
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvListadoAlumnos.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvListadoAlumnos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvListadoAlumnos.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.clnNif, Me.clnNombre, Me.clnApellidos, Me.clnTlfFijo, Me.clnTlfMovil, Me.clnEmail})
        Me.dgvListadoAlumnos.Location = New System.Drawing.Point(13, 196)
        Me.dgvListadoAlumnos.Name = "dgvListadoAlumnos"
        Me.dgvListadoAlumnos.RowHeadersVisible = False
        Me.dgvListadoAlumnos.Size = New System.Drawing.Size(751, 215)
        Me.dgvListadoAlumnos.TabIndex = 8
        '
        'btnBorrar
        '
        Me.btnBorrar.BackgroundImage = Global.Formacion.My.Resources.Resources.LimpiarCajas
        Me.btnBorrar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnBorrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBorrar.ForeColor = System.Drawing.Color.Transparent
        Me.btnBorrar.Location = New System.Drawing.Point(614, 108)
        Me.btnBorrar.Name = "btnBorrar"
        Me.btnBorrar.Size = New System.Drawing.Size(80, 64)
        Me.btnBorrar.TabIndex = 7
        Me.btnBorrar.UseVisualStyleBackColor = True
        '
        'btnBuscar
        '
        Me.btnBuscar.BackgroundImage = Global.Formacion.My.Resources.Resources.Filtrar
        Me.btnBuscar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBuscar.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBuscar.ForeColor = System.Drawing.Color.Transparent
        Me.btnBuscar.Location = New System.Drawing.Point(614, 16)
        Me.btnBuscar.Name = "btnBuscar"
        Me.btnBuscar.Size = New System.Drawing.Size(79, 64)
        Me.btnBuscar.TabIndex = 6
        Me.btnBuscar.UseVisualStyleBackColor = True
        '
        'lblLimpiar
        '
        Me.lblLimpiar.AutoSize = True
        Me.lblLimpiar.Font = New System.Drawing.Font("MS Reference Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLimpiar.ForeColor = System.Drawing.Color.Gold
        Me.lblLimpiar.Location = New System.Drawing.Point(624, 176)
        Me.lblLimpiar.Name = "lblLimpiar"
        Me.lblLimpiar.Size = New System.Drawing.Size(55, 15)
        Me.lblLimpiar.TabIndex = 172
        Me.lblLimpiar.Text = "LIMPIAR"
        Me.lblLimpiar.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'lblConsultar
        '
        Me.lblConsultar.AutoSize = True
        Me.lblConsultar.Font = New System.Drawing.Font("MS Reference Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblConsultar.ForeColor = System.Drawing.Color.Gold
        Me.lblConsultar.Location = New System.Drawing.Point(615, 83)
        Me.lblConsultar.Name = "lblConsultar"
        Me.lblConsultar.Size = New System.Drawing.Size(78, 15)
        Me.lblConsultar.TabIndex = 173
        Me.lblConsultar.Text = "CONSULTAR"
        Me.lblConsultar.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'clnNif
        '
        Me.clnNif.DataPropertyName = "Nif"
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.clnNif.DefaultCellStyle = DataGridViewCellStyle2
        Me.clnNif.Frozen = True
        Me.clnNif.HeaderText = "NIF"
        Me.clnNif.Name = "clnNif"
        Me.clnNif.Width = 80
        '
        'clnNombre
        '
        Me.clnNombre.DataPropertyName = "Nombre"
        Me.clnNombre.Frozen = True
        Me.clnNombre.HeaderText = "NOMBRE"
        Me.clnNombre.Name = "clnNombre"
        Me.clnNombre.Width = 125
        '
        'clnApellidos
        '
        Me.clnApellidos.DataPropertyName = "Apellidos"
        Me.clnApellidos.Frozen = True
        Me.clnApellidos.HeaderText = "APELLIDOS"
        Me.clnApellidos.Name = "clnApellidos"
        Me.clnApellidos.Width = 175
        '
        'clnTlfFijo
        '
        Me.clnTlfFijo.DataPropertyName = "TelefonoFijo"
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.clnTlfFijo.DefaultCellStyle = DataGridViewCellStyle3
        Me.clnTlfFijo.Frozen = True
        Me.clnTlfFijo.HeaderText = "TLF. FIJO"
        Me.clnTlfFijo.Name = "clnTlfFijo"
        '
        'clnTlfMovil
        '
        Me.clnTlfMovil.DataPropertyName = "TelefonoMovil"
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.clnTlfMovil.DefaultCellStyle = DataGridViewCellStyle4
        Me.clnTlfMovil.Frozen = True
        Me.clnTlfMovil.HeaderText = "TLF. MOVIL"
        Me.clnTlfMovil.Name = "clnTlfMovil"
        '
        'clnEmail
        '
        Me.clnEmail.DataPropertyName = "Email"
        Me.clnEmail.HeaderText = "EMAIL"
        Me.clnEmail.Name = "clnEmail"
        Me.clnEmail.Width = 150
        '
        'frmConsultaAlumnos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(778, 423)
        Me.Controls.Add(Me.lblConsultar)
        Me.Controls.Add(Me.lblLimpiar)
        Me.Controls.Add(Me.btnBorrar)
        Me.Controls.Add(Me.dgvListadoAlumnos)
        Me.Controls.Add(Me.btnBuscar)
        Me.Controls.Add(Me.lblEmail)
        Me.Controls.Add(Me.txtEmail)
        Me.Controls.Add(Me.lblMovil)
        Me.Controls.Add(Me.txtTelefonoMovil)
        Me.Controls.Add(Me.lblTelefonoFijo)
        Me.Controls.Add(Me.txtTelefonoFijo)
        Me.Controls.Add(Me.lblApellidos)
        Me.Controls.Add(Me.txtApellidos)
        Me.Controls.Add(Me.lblNombre)
        Me.Controls.Add(Me.txtNombre)
        Me.Controls.Add(Me.lblNif)
        Me.Controls.Add(Me.txtNif)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmConsultaAlumnos"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "CONSULTA DE ALUMNOS"
        CType(Me.dgvListadoAlumnos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblEmail As System.Windows.Forms.Label
    Friend WithEvents txtEmail As System.Windows.Forms.TextBox
    Friend WithEvents lblMovil As System.Windows.Forms.Label
    Friend WithEvents txtTelefonoMovil As System.Windows.Forms.TextBox
    Friend WithEvents lblTelefonoFijo As System.Windows.Forms.Label
    Friend WithEvents txtTelefonoFijo As System.Windows.Forms.TextBox
    Friend WithEvents lblApellidos As System.Windows.Forms.Label
    Friend WithEvents txtApellidos As System.Windows.Forms.TextBox
    Friend WithEvents lblNombre As System.Windows.Forms.Label
    Friend WithEvents txtNombre As System.Windows.Forms.TextBox
    Friend WithEvents lblNif As System.Windows.Forms.Label
    Friend WithEvents txtNif As System.Windows.Forms.TextBox
    Friend WithEvents btnBuscar As System.Windows.Forms.Button
    Friend WithEvents dgvListadoAlumnos As System.Windows.Forms.DataGridView
    Friend WithEvents btnBorrar As System.Windows.Forms.Button
    Friend WithEvents lblLimpiar As System.Windows.Forms.Label
    Friend WithEvents lblConsultar As System.Windows.Forms.Label
    Friend WithEvents clnNif As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents clnNombre As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents clnApellidos As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents clnTlfFijo As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents clnTlfMovil As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents clnEmail As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
