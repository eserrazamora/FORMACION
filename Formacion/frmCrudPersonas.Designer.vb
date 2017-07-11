<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCrudPersonas
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmCrudPersonas))
        Me.txtNif = New System.Windows.Forms.TextBox()
        Me.lblNif = New System.Windows.Forms.Label()
        Me.lblFechaAlta = New System.Windows.Forms.Label()
        Me.lblNombre = New System.Windows.Forms.Label()
        Me.txtNombre = New System.Windows.Forms.TextBox()
        Me.lblApellidos = New System.Windows.Forms.Label()
        Me.txtApellidos = New System.Windows.Forms.TextBox()
        Me.lblFechaNacimiento = New System.Windows.Forms.Label()
        Me.lblDireccion = New System.Windows.Forms.Label()
        Me.txtDireccion = New System.Windows.Forms.TextBox()
        Me.lblTelefonoFijo = New System.Windows.Forms.Label()
        Me.txtTelefonoFijo = New System.Windows.Forms.TextBox()
        Me.lblMovil = New System.Windows.Forms.Label()
        Me.txtTelefonoMovil = New System.Windows.Forms.TextBox()
        Me.lblEmail = New System.Windows.Forms.Label()
        Me.txtEmail = New System.Windows.Forms.TextBox()
        Me.lblProvincia = New System.Windows.Forms.Label()
        Me.txtProvincia = New System.Windows.Forms.TextBox()
        Me.lblLocalidad = New System.Windows.Forms.Label()
        Me.txtLocalidad = New System.Windows.Forms.TextBox()
        Me.grpSexo = New System.Windows.Forms.GroupBox()
        Me.rbtMujer = New System.Windows.Forms.RadioButton()
        Me.rbtHombre = New System.Windows.Forms.RadioButton()
        Me.cboTipo = New System.Windows.Forms.ComboBox()
        Me.lblTipo = New System.Windows.Forms.Label()
        Me.lblCodigoPostal = New System.Windows.Forms.Label()
        Me.cboCodigoPostal = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtObservaciones = New System.Windows.Forms.TextBox()
        Me.BarraHerramientas = New System.Windows.Forms.ToolStrip()
        Me.tlbNuevo = New System.Windows.Forms.ToolStripButton()
        Me.tlbEditar = New System.Windows.Forms.ToolStripButton()
        Me.tlbBorrar = New System.Windows.Forms.ToolStripButton()
        Me.tlbBuscar = New System.Windows.Forms.ToolStripButton()
        Me.tlbGuardar = New System.Windows.Forms.ToolStripButton()
        Me.tlbActualizar = New System.Windows.Forms.ToolStripButton()
        Me.tlbCancelar = New System.Windows.Forms.ToolStripButton()
        Me.dgvListadoPersonas = New System.Windows.Forms.DataGridView()
        Me.clnNIF = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.clnNombre = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.clnApellidos = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.clnFechaAlta = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.clnFechaNacimiento = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.clnTelefonoFijo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.clnTelefonoMovil = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.clnRol = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.clnEmail = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.clnDireccion = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.clnSexo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.clnCodigoPostal = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.clnObservaciones = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.mskFechaAlta = New System.Windows.Forms.MaskedTextBox()
        Me.mskFechaNacimiento = New System.Windows.Forms.MaskedTextBox()
        Me.lblInformes = New System.Windows.Forms.Label()
        Me.lblConsultas = New System.Windows.Forms.Label()
        Me.lblCursos = New System.Windows.Forms.Label()
        Me.lblAsistencia = New System.Windows.Forms.Label()
        Me.lblCalificaciones = New System.Windows.Forms.Label()
        Me.lblInfoLogin = New System.Windows.Forms.Label()
        Me.btnBuscarNIF = New System.Windows.Forms.Button()
        Me.btnConsultas = New System.Windows.Forms.Button()
        Me.btnInformes = New System.Windows.Forms.Button()
        Me.btnCursos = New System.Windows.Forms.Button()
        Me.btnInfoLogin = New System.Windows.Forms.Button()
        Me.btnCalificaciones = New System.Windows.Forms.Button()
        Me.btnAsistencia = New System.Windows.Forms.Button()
        Me.btnMatricularse = New System.Windows.Forms.Button()
        Me.lblMatricularse = New System.Windows.Forms.Label()
        Me.grpSexo.SuspendLayout()
        Me.BarraHerramientas.SuspendLayout()
        CType(Me.dgvListadoPersonas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtNif
        '
        Me.txtNif.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txtNif.Font = New System.Drawing.Font("MS Reference Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNif.ForeColor = System.Drawing.Color.White
        Me.txtNif.Location = New System.Drawing.Point(12, 101)
        Me.txtNif.MaxLength = 9
        Me.txtNif.Name = "txtNif"
        Me.txtNif.Size = New System.Drawing.Size(71, 21)
        Me.txtNif.TabIndex = 0
        '
        'lblNif
        '
        Me.lblNif.AutoSize = True
        Me.lblNif.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.lblNif.Font = New System.Drawing.Font("MS Reference Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNif.ForeColor = System.Drawing.Color.Gold
        Me.lblNif.Location = New System.Drawing.Point(12, 84)
        Me.lblNif.Name = "lblNif"
        Me.lblNif.Size = New System.Drawing.Size(31, 15)
        Me.lblNif.TabIndex = 2
        Me.lblNif.Text = "NIF:"
        '
        'lblFechaAlta
        '
        Me.lblFechaAlta.AutoSize = True
        Me.lblFechaAlta.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.lblFechaAlta.Font = New System.Drawing.Font("MS Reference Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFechaAlta.ForeColor = System.Drawing.Color.Gold
        Me.lblFechaAlta.Location = New System.Drawing.Point(137, 84)
        Me.lblFechaAlta.Name = "lblFechaAlta"
        Me.lblFechaAlta.Size = New System.Drawing.Size(89, 15)
        Me.lblFechaAlta.TabIndex = 4
        Me.lblFechaAlta.Text = "Fecha de Alta:"
        '
        'lblNombre
        '
        Me.lblNombre.AutoSize = True
        Me.lblNombre.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.lblNombre.Font = New System.Drawing.Font("MS Reference Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNombre.ForeColor = System.Drawing.Color.Gold
        Me.lblNombre.Location = New System.Drawing.Point(12, 136)
        Me.lblNombre.Name = "lblNombre"
        Me.lblNombre.Size = New System.Drawing.Size(57, 15)
        Me.lblNombre.TabIndex = 6
        Me.lblNombre.Text = "Nombre:"
        '
        'txtNombre
        '
        Me.txtNombre.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txtNombre.Font = New System.Drawing.Font("MS Reference Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNombre.ForeColor = System.Drawing.Color.White
        Me.txtNombre.Location = New System.Drawing.Point(12, 155)
        Me.txtNombre.MaxLength = 30
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(176, 21)
        Me.txtNombre.TabIndex = 5
        '
        'lblApellidos
        '
        Me.lblApellidos.AutoSize = True
        Me.lblApellidos.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.lblApellidos.Font = New System.Drawing.Font("MS Reference Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblApellidos.ForeColor = System.Drawing.Color.Gold
        Me.lblApellidos.Location = New System.Drawing.Point(191, 137)
        Me.lblApellidos.Name = "lblApellidos"
        Me.lblApellidos.Size = New System.Drawing.Size(63, 15)
        Me.lblApellidos.TabIndex = 8
        Me.lblApellidos.Text = "Apellidos:"
        '
        'txtApellidos
        '
        Me.txtApellidos.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txtApellidos.Font = New System.Drawing.Font("MS Reference Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtApellidos.ForeColor = System.Drawing.Color.White
        Me.txtApellidos.Location = New System.Drawing.Point(194, 155)
        Me.txtApellidos.MaxLength = 50
        Me.txtApellidos.Name = "txtApellidos"
        Me.txtApellidos.Size = New System.Drawing.Size(354, 21)
        Me.txtApellidos.TabIndex = 6
        '
        'lblFechaNacimiento
        '
        Me.lblFechaNacimiento.AutoSize = True
        Me.lblFechaNacimiento.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.lblFechaNacimiento.Font = New System.Drawing.Font("MS Reference Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFechaNacimiento.ForeColor = System.Drawing.Color.Gold
        Me.lblFechaNacimiento.Location = New System.Drawing.Point(264, 84)
        Me.lblFechaNacimiento.Name = "lblFechaNacimiento"
        Me.lblFechaNacimiento.Size = New System.Drawing.Size(112, 15)
        Me.lblFechaNacimiento.TabIndex = 10
        Me.lblFechaNacimiento.Text = "Fecha Nacimiento:"
        '
        'lblDireccion
        '
        Me.lblDireccion.AutoSize = True
        Me.lblDireccion.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.lblDireccion.Font = New System.Drawing.Font("MS Reference Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDireccion.ForeColor = System.Drawing.Color.Gold
        Me.lblDireccion.Location = New System.Drawing.Point(12, 187)
        Me.lblDireccion.Name = "lblDireccion"
        Me.lblDireccion.Size = New System.Drawing.Size(65, 15)
        Me.lblDireccion.TabIndex = 12
        Me.lblDireccion.Text = "Dirección:"
        '
        'txtDireccion
        '
        Me.txtDireccion.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txtDireccion.Font = New System.Drawing.Font("MS Reference Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDireccion.ForeColor = System.Drawing.Color.White
        Me.txtDireccion.Location = New System.Drawing.Point(12, 206)
        Me.txtDireccion.MaxLength = 50
        Me.txtDireccion.Name = "txtDireccion"
        Me.txtDireccion.Size = New System.Drawing.Size(438, 21)
        Me.txtDireccion.TabIndex = 7
        '
        'lblTelefonoFijo
        '
        Me.lblTelefonoFijo.AutoSize = True
        Me.lblTelefonoFijo.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.lblTelefonoFijo.Font = New System.Drawing.Font("MS Reference Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTelefonoFijo.ForeColor = System.Drawing.Color.Gold
        Me.lblTelefonoFijo.Location = New System.Drawing.Point(9, 246)
        Me.lblTelefonoFijo.Name = "lblTelefonoFijo"
        Me.lblTelefonoFijo.Size = New System.Drawing.Size(85, 15)
        Me.lblTelefonoFijo.TabIndex = 14
        Me.lblTelefonoFijo.Text = "Teléfono Fijo:"
        '
        'txtTelefonoFijo
        '
        Me.txtTelefonoFijo.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txtTelefonoFijo.Font = New System.Drawing.Font("MS Reference Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTelefonoFijo.ForeColor = System.Drawing.Color.White
        Me.txtTelefonoFijo.Location = New System.Drawing.Point(12, 262)
        Me.txtTelefonoFijo.MaxLength = 20
        Me.txtTelefonoFijo.Name = "txtTelefonoFijo"
        Me.txtTelefonoFijo.Size = New System.Drawing.Size(85, 21)
        Me.txtTelefonoFijo.TabIndex = 8
        '
        'lblMovil
        '
        Me.lblMovil.AutoSize = True
        Me.lblMovil.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.lblMovil.Font = New System.Drawing.Font("MS Reference Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMovil.ForeColor = System.Drawing.Color.Gold
        Me.lblMovil.Location = New System.Drawing.Point(103, 247)
        Me.lblMovil.Name = "lblMovil"
        Me.lblMovil.Size = New System.Drawing.Size(94, 15)
        Me.lblMovil.TabIndex = 16
        Me.lblMovil.Text = "Teléfono Móvil:"
        '
        'txtTelefonoMovil
        '
        Me.txtTelefonoMovil.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txtTelefonoMovil.Font = New System.Drawing.Font("MS Reference Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTelefonoMovil.ForeColor = System.Drawing.Color.White
        Me.txtTelefonoMovil.Location = New System.Drawing.Point(103, 262)
        Me.txtTelefonoMovil.MaxLength = 20
        Me.txtTelefonoMovil.Name = "txtTelefonoMovil"
        Me.txtTelefonoMovil.Size = New System.Drawing.Size(94, 21)
        Me.txtTelefonoMovil.TabIndex = 9
        '
        'lblEmail
        '
        Me.lblEmail.AutoSize = True
        Me.lblEmail.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.lblEmail.Font = New System.Drawing.Font("MS Reference Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEmail.ForeColor = System.Drawing.Color.Gold
        Me.lblEmail.Location = New System.Drawing.Point(202, 247)
        Me.lblEmail.Name = "lblEmail"
        Me.lblEmail.Size = New System.Drawing.Size(43, 15)
        Me.lblEmail.TabIndex = 18
        Me.lblEmail.Text = "Email:"
        '
        'txtEmail
        '
        Me.txtEmail.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txtEmail.Font = New System.Drawing.Font("MS Reference Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEmail.ForeColor = System.Drawing.Color.White
        Me.txtEmail.Location = New System.Drawing.Point(203, 262)
        Me.txtEmail.MaxLength = 80
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.Size = New System.Drawing.Size(247, 21)
        Me.txtEmail.TabIndex = 10
        '
        'lblProvincia
        '
        Me.lblProvincia.AutoSize = True
        Me.lblProvincia.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.lblProvincia.Font = New System.Drawing.Font("MS Reference Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblProvincia.ForeColor = System.Drawing.Color.Gold
        Me.lblProvincia.Location = New System.Drawing.Point(118, 302)
        Me.lblProvincia.Name = "lblProvincia"
        Me.lblProvincia.Size = New System.Drawing.Size(64, 15)
        Me.lblProvincia.TabIndex = 20
        Me.lblProvincia.Text = "Provincia:"
        '
        'txtProvincia
        '
        Me.txtProvincia.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txtProvincia.Font = New System.Drawing.Font("MS Reference Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtProvincia.ForeColor = System.Drawing.Color.White
        Me.txtProvincia.Location = New System.Drawing.Point(119, 319)
        Me.txtProvincia.MaxLength = 50
        Me.txtProvincia.Name = "txtProvincia"
        Me.txtProvincia.Size = New System.Drawing.Size(211, 21)
        Me.txtProvincia.TabIndex = 12
        '
        'lblLocalidad
        '
        Me.lblLocalidad.AutoSize = True
        Me.lblLocalidad.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.lblLocalidad.Font = New System.Drawing.Font("MS Reference Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLocalidad.ForeColor = System.Drawing.Color.Gold
        Me.lblLocalidad.Location = New System.Drawing.Point(335, 301)
        Me.lblLocalidad.Name = "lblLocalidad"
        Me.lblLocalidad.Size = New System.Drawing.Size(65, 15)
        Me.lblLocalidad.TabIndex = 22
        Me.lblLocalidad.Text = "Localidad:"
        '
        'txtLocalidad
        '
        Me.txtLocalidad.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txtLocalidad.Font = New System.Drawing.Font("MS Reference Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtLocalidad.ForeColor = System.Drawing.Color.White
        Me.txtLocalidad.Location = New System.Drawing.Point(336, 319)
        Me.txtLocalidad.MaxLength = 50
        Me.txtLocalidad.Name = "txtLocalidad"
        Me.txtLocalidad.Size = New System.Drawing.Size(212, 21)
        Me.txtLocalidad.TabIndex = 13
        '
        'grpSexo
        '
        Me.grpSexo.Controls.Add(Me.rbtMujer)
        Me.grpSexo.Controls.Add(Me.rbtHombre)
        Me.grpSexo.Font = New System.Drawing.Font("MS Reference Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpSexo.ForeColor = System.Drawing.Color.Gold
        Me.grpSexo.Location = New System.Drawing.Point(456, 195)
        Me.grpSexo.Name = "grpSexo"
        Me.grpSexo.Size = New System.Drawing.Size(92, 88)
        Me.grpSexo.TabIndex = 27
        Me.grpSexo.TabStop = False
        Me.grpSexo.Text = "Sexo"
        '
        'rbtMujer
        '
        Me.rbtMujer.AutoSize = True
        Me.rbtMujer.Font = New System.Drawing.Font("MS Reference Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbtMujer.ForeColor = System.Drawing.Color.Gold
        Me.rbtMujer.Location = New System.Drawing.Point(16, 53)
        Me.rbtMujer.Name = "rbtMujer"
        Me.rbtMujer.Size = New System.Drawing.Size(57, 19)
        Me.rbtMujer.TabIndex = 1
        Me.rbtMujer.TabStop = True
        Me.rbtMujer.Text = "Mujer"
        Me.rbtMujer.UseVisualStyleBackColor = True
        '
        'rbtHombre
        '
        Me.rbtHombre.AutoSize = True
        Me.rbtHombre.Font = New System.Drawing.Font("MS Reference Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbtHombre.ForeColor = System.Drawing.Color.Gold
        Me.rbtHombre.Location = New System.Drawing.Point(16, 23)
        Me.rbtHombre.Name = "rbtHombre"
        Me.rbtHombre.Size = New System.Drawing.Size(70, 19)
        Me.rbtHombre.TabIndex = 0
        Me.rbtHombre.TabStop = True
        Me.rbtHombre.Text = "Hombre"
        Me.rbtHombre.UseVisualStyleBackColor = True
        '
        'cboTipo
        '
        Me.cboTipo.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.cboTipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboTipo.Enabled = False
        Me.cboTipo.Font = New System.Drawing.Font("MS Reference Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboTipo.ForeColor = System.Drawing.Color.White
        Me.cboTipo.FormattingEnabled = True
        Me.cboTipo.Location = New System.Drawing.Point(394, 100)
        Me.cboTipo.Name = "cboTipo"
        Me.cboTipo.Size = New System.Drawing.Size(154, 23)
        Me.cboTipo.TabIndex = 4
        '
        'lblTipo
        '
        Me.lblTipo.AutoSize = True
        Me.lblTipo.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.lblTipo.Font = New System.Drawing.Font("MS Reference Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTipo.ForeColor = System.Drawing.Color.Gold
        Me.lblTipo.Location = New System.Drawing.Point(394, 84)
        Me.lblTipo.Name = "lblTipo"
        Me.lblTipo.Size = New System.Drawing.Size(36, 15)
        Me.lblTipo.TabIndex = 29
        Me.lblTipo.Text = "Tipo:"
        '
        'lblCodigoPostal
        '
        Me.lblCodigoPostal.AutoSize = True
        Me.lblCodigoPostal.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.lblCodigoPostal.Font = New System.Drawing.Font("MS Reference Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCodigoPostal.ForeColor = System.Drawing.Color.Gold
        Me.lblCodigoPostal.Location = New System.Drawing.Point(12, 302)
        Me.lblCodigoPostal.Name = "lblCodigoPostal"
        Me.lblCodigoPostal.Size = New System.Drawing.Size(90, 15)
        Me.lblCodigoPostal.TabIndex = 31
        Me.lblCodigoPostal.Text = "Codigo Postal:"
        Me.lblCodigoPostal.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'cboCodigoPostal
        '
        Me.cboCodigoPostal.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.cboCodigoPostal.Font = New System.Drawing.Font("MS Reference Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboCodigoPostal.ForeColor = System.Drawing.Color.White
        Me.cboCodigoPostal.FormattingEnabled = True
        Me.cboCodigoPostal.Location = New System.Drawing.Point(12, 320)
        Me.cboCodigoPostal.MaxLength = 5
        Me.cboCodigoPostal.Name = "cboCodigoPostal"
        Me.cboCodigoPostal.Size = New System.Drawing.Size(101, 23)
        Me.cboCodigoPostal.TabIndex = 11
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label2.Font = New System.Drawing.Font("MS Reference Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Gold
        Me.Label2.Location = New System.Drawing.Point(12, 352)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(96, 15)
        Me.Label2.TabIndex = 33
        Me.Label2.Text = "Observaciones:"
        '
        'txtObservaciones
        '
        Me.txtObservaciones.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txtObservaciones.Font = New System.Drawing.Font("MS Reference Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtObservaciones.ForeColor = System.Drawing.Color.White
        Me.txtObservaciones.Location = New System.Drawing.Point(12, 368)
        Me.txtObservaciones.Multiline = True
        Me.txtObservaciones.Name = "txtObservaciones"
        Me.txtObservaciones.Size = New System.Drawing.Size(536, 62)
        Me.txtObservaciones.TabIndex = 14
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
        Me.BarraHerramientas.Size = New System.Drawing.Size(676, 66)
        Me.BarraHerramientas.TabIndex = 136
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
        Me.tlbGuardar.Margin = New System.Windows.Forms.Padding(305, 2, 2, 2)
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
        'dgvListadoPersonas
        '
        Me.dgvListadoPersonas.AllowUserToAddRows = False
        Me.dgvListadoPersonas.AllowUserToDeleteRows = False
        Me.dgvListadoPersonas.AllowUserToOrderColumns = True
        Me.dgvListadoPersonas.AllowUserToResizeColumns = False
        Me.dgvListadoPersonas.AllowUserToResizeRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.Silver
        Me.dgvListadoPersonas.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvListadoPersonas.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.dgvListadoPersonas.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.DarkOliveGreen
        DataGridViewCellStyle2.Font = New System.Drawing.Font("MS Reference Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.Gold
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvListadoPersonas.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.dgvListadoPersonas.ColumnHeadersHeight = 21
        Me.dgvListadoPersonas.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.clnNIF, Me.clnNombre, Me.clnApellidos, Me.clnFechaAlta, Me.clnFechaNacimiento, Me.clnTelefonoFijo, Me.clnTelefonoMovil, Me.clnRol, Me.clnEmail, Me.clnDireccion, Me.clnSexo, Me.clnCodigoPostal, Me.clnObservaciones})
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle3.Font = New System.Drawing.Font("MS Reference Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.Gold
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Yellow
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvListadoPersonas.DefaultCellStyle = DataGridViewCellStyle3
        Me.dgvListadoPersonas.EnableHeadersVisualStyles = False
        Me.dgvListadoPersonas.GridColor = System.Drawing.Color.Silver
        Me.dgvListadoPersonas.Location = New System.Drawing.Point(12, 451)
        Me.dgvListadoPersonas.MultiSelect = False
        Me.dgvListadoPersonas.Name = "dgvListadoPersonas"
        Me.dgvListadoPersonas.ReadOnly = True
        Me.dgvListadoPersonas.RowHeadersVisible = False
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.Yellow
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Black
        Me.dgvListadoPersonas.RowsDefaultCellStyle = DataGridViewCellStyle4
        Me.dgvListadoPersonas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvListadoPersonas.Size = New System.Drawing.Size(654, 173)
        Me.dgvListadoPersonas.TabIndex = 137
        '
        'clnNIF
        '
        Me.clnNIF.DataPropertyName = "NIF"
        Me.clnNIF.HeaderText = "NIF"
        Me.clnNIF.Name = "clnNIF"
        Me.clnNIF.ReadOnly = True
        Me.clnNIF.Width = 80
        '
        'clnNombre
        '
        Me.clnNombre.DataPropertyName = "Nombre"
        Me.clnNombre.HeaderText = "NOMBRE"
        Me.clnNombre.Name = "clnNombre"
        Me.clnNombre.ReadOnly = True
        Me.clnNombre.Width = 150
        '
        'clnApellidos
        '
        Me.clnApellidos.DataPropertyName = "Apellidos"
        Me.clnApellidos.HeaderText = "APELLIDOS"
        Me.clnApellidos.Name = "clnApellidos"
        Me.clnApellidos.ReadOnly = True
        Me.clnApellidos.Width = 175
        '
        'clnFechaAlta
        '
        Me.clnFechaAlta.DataPropertyName = "FechaAlta"
        Me.clnFechaAlta.HeaderText = "F.ALTA"
        Me.clnFechaAlta.Name = "clnFechaAlta"
        Me.clnFechaAlta.ReadOnly = True
        Me.clnFechaAlta.Visible = False
        '
        'clnFechaNacimiento
        '
        Me.clnFechaNacimiento.DataPropertyName = "FechaNacimiento"
        Me.clnFechaNacimiento.HeaderText = "F.NACIM."
        Me.clnFechaNacimiento.Name = "clnFechaNacimiento"
        Me.clnFechaNacimiento.ReadOnly = True
        Me.clnFechaNacimiento.Width = 80
        '
        'clnTelefonoFijo
        '
        Me.clnTelefonoFijo.DataPropertyName = "TelefonoFijo"
        Me.clnTelefonoFijo.HeaderText = "FIJO"
        Me.clnTelefonoFijo.Name = "clnTelefonoFijo"
        Me.clnTelefonoFijo.ReadOnly = True
        Me.clnTelefonoFijo.Width = 80
        '
        'clnTelefonoMovil
        '
        Me.clnTelefonoMovil.DataPropertyName = "TelefonoMovil"
        Me.clnTelefonoMovil.HeaderText = "MOVIL"
        Me.clnTelefonoMovil.Name = "clnTelefonoMovil"
        Me.clnTelefonoMovil.ReadOnly = True
        Me.clnTelefonoMovil.Width = 80
        '
        'clnRol
        '
        Me.clnRol.DataPropertyName = "ROL"
        Me.clnRol.HeaderText = "ROL"
        Me.clnRol.Name = "clnRol"
        Me.clnRol.ReadOnly = True
        Me.clnRol.Visible = False
        '
        'clnEmail
        '
        Me.clnEmail.DataPropertyName = "Email"
        Me.clnEmail.HeaderText = "EMAIL"
        Me.clnEmail.Name = "clnEmail"
        Me.clnEmail.ReadOnly = True
        Me.clnEmail.Width = 200
        '
        'clnDireccion
        '
        Me.clnDireccion.DataPropertyName = "Direccion"
        Me.clnDireccion.HeaderText = "DIRECCION"
        Me.clnDireccion.Name = "clnDireccion"
        Me.clnDireccion.ReadOnly = True
        Me.clnDireccion.Visible = False
        '
        'clnSexo
        '
        Me.clnSexo.DataPropertyName = "Sexo"
        Me.clnSexo.HeaderText = "SEXO"
        Me.clnSexo.Name = "clnSexo"
        Me.clnSexo.ReadOnly = True
        Me.clnSexo.Visible = False
        '
        'clnCodigoPostal
        '
        Me.clnCodigoPostal.DataPropertyName = "CodigoPostal"
        Me.clnCodigoPostal.HeaderText = "C.POSTAL"
        Me.clnCodigoPostal.Name = "clnCodigoPostal"
        Me.clnCodigoPostal.ReadOnly = True
        Me.clnCodigoPostal.Visible = False
        '
        'clnObservaciones
        '
        Me.clnObservaciones.DataPropertyName = "Observaciones"
        Me.clnObservaciones.HeaderText = "OBSERVACIONES"
        Me.clnObservaciones.Name = "clnObservaciones"
        Me.clnObservaciones.ReadOnly = True
        Me.clnObservaciones.Visible = False
        '
        'mskFechaAlta
        '
        Me.mskFechaAlta.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.mskFechaAlta.Font = New System.Drawing.Font("MS Reference Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mskFechaAlta.ForeColor = System.Drawing.Color.White
        Me.mskFechaAlta.Location = New System.Drawing.Point(137, 101)
        Me.mskFechaAlta.Mask = "00/00/0000"
        Me.mskFechaAlta.Name = "mskFechaAlta"
        Me.mskFechaAlta.Size = New System.Drawing.Size(93, 21)
        Me.mskFechaAlta.TabIndex = 2
        Me.mskFechaAlta.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.mskFechaAlta.ValidatingType = GetType(Date)
        '
        'mskFechaNacimiento
        '
        Me.mskFechaNacimiento.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.mskFechaNacimiento.Font = New System.Drawing.Font("MS Reference Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mskFechaNacimiento.ForeColor = System.Drawing.Color.White
        Me.mskFechaNacimiento.Location = New System.Drawing.Point(267, 100)
        Me.mskFechaNacimiento.Mask = "00/00/0000"
        Me.mskFechaNacimiento.Name = "mskFechaNacimiento"
        Me.mskFechaNacimiento.Size = New System.Drawing.Size(93, 21)
        Me.mskFechaNacimiento.TabIndex = 3
        Me.mskFechaNacimiento.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.mskFechaNacimiento.ValidatingType = GetType(Date)
        '
        'lblInformes
        '
        Me.lblInformes.AutoSize = True
        Me.lblInformes.Font = New System.Drawing.Font("MS Reference Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblInformes.ForeColor = System.Drawing.Color.Gold
        Me.lblInformes.Location = New System.Drawing.Point(578, 146)
        Me.lblInformes.Name = "lblInformes"
        Me.lblInformes.Size = New System.Drawing.Size(67, 15)
        Me.lblInformes.TabIndex = 172
        Me.lblInformes.Text = "INFORMES"
        Me.lblInformes.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'lblConsultas
        '
        Me.lblConsultas.AutoSize = True
        Me.lblConsultas.Font = New System.Drawing.Font("MS Reference Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblConsultas.ForeColor = System.Drawing.Color.Gold
        Me.lblConsultas.Location = New System.Drawing.Point(579, 233)
        Me.lblConsultas.Name = "lblConsultas"
        Me.lblConsultas.Size = New System.Drawing.Size(78, 15)
        Me.lblConsultas.TabIndex = 173
        Me.lblConsultas.Text = "CONSULTAS"
        Me.lblConsultas.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'lblCursos
        '
        Me.lblCursos.AutoSize = True
        Me.lblCursos.Font = New System.Drawing.Font("MS Reference Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCursos.ForeColor = System.Drawing.Color.Gold
        Me.lblCursos.Location = New System.Drawing.Point(588, 322)
        Me.lblCursos.Name = "lblCursos"
        Me.lblCursos.Size = New System.Drawing.Size(57, 15)
        Me.lblCursos.TabIndex = 174
        Me.lblCursos.Text = "CURSOS"
        Me.lblCursos.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'lblAsistencia
        '
        Me.lblAsistencia.AutoSize = True
        Me.lblAsistencia.Font = New System.Drawing.Font("MS Reference Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAsistencia.ForeColor = System.Drawing.Color.Gold
        Me.lblAsistencia.Location = New System.Drawing.Point(575, 323)
        Me.lblAsistencia.Name = "lblAsistencia"
        Me.lblAsistencia.Size = New System.Drawing.Size(80, 15)
        Me.lblAsistencia.TabIndex = 175
        Me.lblAsistencia.Text = "ASISTENCIA"
        Me.lblAsistencia.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'lblCalificaciones
        '
        Me.lblCalificaciones.AutoSize = True
        Me.lblCalificaciones.Font = New System.Drawing.Font("MS Reference Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCalificaciones.ForeColor = System.Drawing.Color.Gold
        Me.lblCalificaciones.Location = New System.Drawing.Point(562, 233)
        Me.lblCalificaciones.Name = "lblCalificaciones"
        Me.lblCalificaciones.Size = New System.Drawing.Size(109, 15)
        Me.lblCalificaciones.TabIndex = 176
        Me.lblCalificaciones.Text = "CALIFICACIONES"
        Me.lblCalificaciones.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'lblInfoLogin
        '
        Me.lblInfoLogin.AutoSize = True
        Me.lblInfoLogin.Font = New System.Drawing.Font("MS Reference Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblInfoLogin.ForeColor = System.Drawing.Color.Gold
        Me.lblInfoLogin.Location = New System.Drawing.Point(579, 415)
        Me.lblInfoLogin.Name = "lblInfoLogin"
        Me.lblInfoLogin.Size = New System.Drawing.Size(76, 15)
        Me.lblInfoLogin.TabIndex = 177
        Me.lblInfoLogin.Text = "INFO.LOGIN"
        Me.lblInfoLogin.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'btnBuscarNIF
        '
        Me.btnBuscarNIF.BackgroundImage = Global.Formacion.My.Resources.Resources.BuscarIcono
        Me.btnBuscarNIF.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnBuscarNIF.Location = New System.Drawing.Point(89, 97)
        Me.btnBuscarNIF.Name = "btnBuscarNIF"
        Me.btnBuscarNIF.Size = New System.Drawing.Size(28, 29)
        Me.btnBuscarNIF.TabIndex = 1
        Me.btnBuscarNIF.UseVisualStyleBackColor = True
        '
        'btnConsultas
        '
        Me.btnConsultas.BackgroundImage = Global.Formacion.My.Resources.Resources.Consulta
        Me.btnConsultas.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnConsultas.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnConsultas.Location = New System.Drawing.Point(583, 171)
        Me.btnConsultas.Name = "btnConsultas"
        Me.btnConsultas.Size = New System.Drawing.Size(66, 59)
        Me.btnConsultas.TabIndex = 35
        Me.btnConsultas.UseVisualStyleBackColor = True
        '
        'btnInformes
        '
        Me.btnInformes.BackgroundImage = Global.Formacion.My.Resources.Resources.informe
        Me.btnInformes.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnInformes.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnInformes.Location = New System.Drawing.Point(583, 84)
        Me.btnInformes.Name = "btnInformes"
        Me.btnInformes.Size = New System.Drawing.Size(66, 58)
        Me.btnInformes.TabIndex = 36
        Me.btnInformes.UseVisualStyleBackColor = True
        '
        'btnCursos
        '
        Me.btnCursos.BackgroundImage = Global.Formacion.My.Resources.Resources.cursos
        Me.btnCursos.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnCursos.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCursos.Location = New System.Drawing.Point(577, 259)
        Me.btnCursos.Name = "btnCursos"
        Me.btnCursos.Size = New System.Drawing.Size(72, 60)
        Me.btnCursos.TabIndex = 34
        Me.btnCursos.UseVisualStyleBackColor = True
        '
        'btnInfoLogin
        '
        Me.btnInfoLogin.BackgroundImage = Global.Formacion.My.Resources.Resources.Login
        Me.btnInfoLogin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnInfoLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnInfoLogin.Location = New System.Drawing.Point(583, 348)
        Me.btnInfoLogin.Name = "btnInfoLogin"
        Me.btnInfoLogin.Size = New System.Drawing.Size(72, 60)
        Me.btnInfoLogin.TabIndex = 26
        Me.btnInfoLogin.UseVisualStyleBackColor = True
        '
        'btnCalificaciones
        '
        Me.btnCalificaciones.BackgroundImage = Global.Formacion.My.Resources.Resources.calificacionesAMARILLO
        Me.btnCalificaciones.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnCalificaciones.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCalificaciones.Location = New System.Drawing.Point(583, 171)
        Me.btnCalificaciones.Name = "btnCalificaciones"
        Me.btnCalificaciones.Size = New System.Drawing.Size(66, 59)
        Me.btnCalificaciones.TabIndex = 25
        Me.btnCalificaciones.UseVisualStyleBackColor = True
        '
        'btnAsistencia
        '
        Me.btnAsistencia.BackgroundImage = Global.Formacion.My.Resources.Resources.Asistencia
        Me.btnAsistencia.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnAsistencia.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAsistencia.Location = New System.Drawing.Point(583, 259)
        Me.btnAsistencia.Name = "btnAsistencia"
        Me.btnAsistencia.Size = New System.Drawing.Size(66, 61)
        Me.btnAsistencia.TabIndex = 24
        Me.btnAsistencia.UseVisualStyleBackColor = True
        '
        'btnMatricularse
        '
        Me.btnMatricularse.BackgroundImage = Global.Formacion.My.Resources.Resources.Matricularse
        Me.btnMatricularse.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnMatricularse.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnMatricularse.Location = New System.Drawing.Point(583, 85)
        Me.btnMatricularse.Name = "btnMatricularse"
        Me.btnMatricularse.Size = New System.Drawing.Size(66, 58)
        Me.btnMatricularse.TabIndex = 23
        Me.btnMatricularse.UseVisualStyleBackColor = True
        '
        'lblMatricularse
        '
        Me.lblMatricularse.AutoSize = True
        Me.lblMatricularse.Font = New System.Drawing.Font("MS Reference Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMatricularse.ForeColor = System.Drawing.Color.Gold
        Me.lblMatricularse.Location = New System.Drawing.Point(569, 145)
        Me.lblMatricularse.Name = "lblMatricularse"
        Me.lblMatricularse.Size = New System.Drawing.Size(98, 15)
        Me.lblMatricularse.TabIndex = 178
        Me.lblMatricularse.Text = "MATRICULARSE"
        Me.lblMatricularse.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'frmCrudPersonas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(676, 636)
        Me.Controls.Add(Me.lblMatricularse)
        Me.Controls.Add(Me.lblInfoLogin)
        Me.Controls.Add(Me.btnConsultas)
        Me.Controls.Add(Me.lblCalificaciones)
        Me.Controls.Add(Me.lblAsistencia)
        Me.Controls.Add(Me.lblCursos)
        Me.Controls.Add(Me.lblConsultas)
        Me.Controls.Add(Me.lblInformes)
        Me.Controls.Add(Me.btnBuscarNIF)
        Me.Controls.Add(Me.mskFechaNacimiento)
        Me.Controls.Add(Me.mskFechaAlta)
        Me.Controls.Add(Me.dgvListadoPersonas)
        Me.Controls.Add(Me.BarraHerramientas)
        Me.Controls.Add(Me.btnInformes)
        Me.Controls.Add(Me.btnCursos)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtObservaciones)
        Me.Controls.Add(Me.lblCodigoPostal)
        Me.Controls.Add(Me.cboCodigoPostal)
        Me.Controls.Add(Me.lblTipo)
        Me.Controls.Add(Me.cboTipo)
        Me.Controls.Add(Me.grpSexo)
        Me.Controls.Add(Me.btnInfoLogin)
        Me.Controls.Add(Me.btnCalificaciones)
        Me.Controls.Add(Me.btnAsistencia)
        Me.Controls.Add(Me.btnMatricularse)
        Me.Controls.Add(Me.lblLocalidad)
        Me.Controls.Add(Me.txtLocalidad)
        Me.Controls.Add(Me.lblProvincia)
        Me.Controls.Add(Me.txtProvincia)
        Me.Controls.Add(Me.lblEmail)
        Me.Controls.Add(Me.txtEmail)
        Me.Controls.Add(Me.lblMovil)
        Me.Controls.Add(Me.txtTelefonoMovil)
        Me.Controls.Add(Me.lblTelefonoFijo)
        Me.Controls.Add(Me.txtTelefonoFijo)
        Me.Controls.Add(Me.lblDireccion)
        Me.Controls.Add(Me.txtDireccion)
        Me.Controls.Add(Me.lblFechaNacimiento)
        Me.Controls.Add(Me.lblApellidos)
        Me.Controls.Add(Me.txtApellidos)
        Me.Controls.Add(Me.lblNombre)
        Me.Controls.Add(Me.txtNombre)
        Me.Controls.Add(Me.lblFechaAlta)
        Me.Controls.Add(Me.lblNif)
        Me.Controls.Add(Me.txtNif)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmCrudPersonas"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "CRUD ALUMNOS Y PROFESORES"
        Me.grpSexo.ResumeLayout(False)
        Me.grpSexo.PerformLayout()
        Me.BarraHerramientas.ResumeLayout(False)
        Me.BarraHerramientas.PerformLayout()
        CType(Me.dgvListadoPersonas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtNif As System.Windows.Forms.TextBox
    Friend WithEvents lblNif As System.Windows.Forms.Label
    Friend WithEvents lblFechaAlta As System.Windows.Forms.Label
    Friend WithEvents lblNombre As System.Windows.Forms.Label
    Friend WithEvents txtNombre As System.Windows.Forms.TextBox
    Friend WithEvents lblApellidos As System.Windows.Forms.Label
    Friend WithEvents txtApellidos As System.Windows.Forms.TextBox
    Friend WithEvents lblFechaNacimiento As System.Windows.Forms.Label
    Friend WithEvents lblDireccion As System.Windows.Forms.Label
    Friend WithEvents txtDireccion As System.Windows.Forms.TextBox
    Friend WithEvents lblTelefonoFijo As System.Windows.Forms.Label
    Friend WithEvents txtTelefonoFijo As System.Windows.Forms.TextBox
    Friend WithEvents lblMovil As System.Windows.Forms.Label
    Friend WithEvents txtTelefonoMovil As System.Windows.Forms.TextBox
    Friend WithEvents lblEmail As System.Windows.Forms.Label
    Friend WithEvents txtEmail As System.Windows.Forms.TextBox
    Friend WithEvents lblProvincia As System.Windows.Forms.Label
    Friend WithEvents txtProvincia As System.Windows.Forms.TextBox
    Friend WithEvents lblLocalidad As System.Windows.Forms.Label
    Friend WithEvents txtLocalidad As System.Windows.Forms.TextBox
    Friend WithEvents btnMatricularse As System.Windows.Forms.Button
    Friend WithEvents btnAsistencia As System.Windows.Forms.Button
    Friend WithEvents btnCalificaciones As System.Windows.Forms.Button
    Friend WithEvents btnInfoLogin As System.Windows.Forms.Button
    Friend WithEvents grpSexo As System.Windows.Forms.GroupBox
    Friend WithEvents rbtHombre As System.Windows.Forms.RadioButton
    Friend WithEvents rbtMujer As System.Windows.Forms.RadioButton
    Friend WithEvents cboTipo As System.Windows.Forms.ComboBox
    Friend WithEvents lblTipo As System.Windows.Forms.Label
    Friend WithEvents lblCodigoPostal As System.Windows.Forms.Label
    Friend WithEvents cboCodigoPostal As System.Windows.Forms.ComboBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtObservaciones As System.Windows.Forms.TextBox
    Friend WithEvents btnCursos As System.Windows.Forms.Button
    Friend WithEvents btnConsultas As System.Windows.Forms.Button
    Friend WithEvents btnInformes As System.Windows.Forms.Button
    Friend WithEvents BarraHerramientas As System.Windows.Forms.ToolStrip
    Friend WithEvents tlbNuevo As System.Windows.Forms.ToolStripButton
    Friend WithEvents tlbEditar As System.Windows.Forms.ToolStripButton
    Friend WithEvents tlbBorrar As System.Windows.Forms.ToolStripButton
    Friend WithEvents tlbBuscar As System.Windows.Forms.ToolStripButton
    Friend WithEvents tlbGuardar As System.Windows.Forms.ToolStripButton
    Friend WithEvents tlbActualizar As System.Windows.Forms.ToolStripButton
    Friend WithEvents tlbCancelar As System.Windows.Forms.ToolStripButton
    Private WithEvents dgvListadoPersonas As System.Windows.Forms.DataGridView
    Friend WithEvents mskFechaAlta As System.Windows.Forms.MaskedTextBox
    Friend WithEvents mskFechaNacimiento As System.Windows.Forms.MaskedTextBox
    Friend WithEvents btnBuscarNIF As System.Windows.Forms.Button
    Friend WithEvents clnNIF As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents clnNombre As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents clnApellidos As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents clnFechaAlta As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents clnFechaNacimiento As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents clnTelefonoFijo As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents clnTelefonoMovil As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents clnRol As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents clnEmail As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents clnDireccion As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents clnSexo As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents clnCodigoPostal As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents clnObservaciones As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents lblInformes As System.Windows.Forms.Label
    Friend WithEvents lblConsultas As System.Windows.Forms.Label
    Friend WithEvents lblCursos As System.Windows.Forms.Label
    Friend WithEvents lblAsistencia As System.Windows.Forms.Label
    Friend WithEvents lblCalificaciones As System.Windows.Forms.Label
    Friend WithEvents lblInfoLogin As System.Windows.Forms.Label
    Friend WithEvents lblMatricularse As System.Windows.Forms.Label
End Class
