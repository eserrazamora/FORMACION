<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmConsultaCursos
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmConsultaCursos))
        Me.lblFechaFin = New System.Windows.Forms.Label()
        Me.lblFechaInicio = New System.Windows.Forms.Label()
        Me.lblDuracion = New System.Windows.Forms.Label()
        Me.txtDuracion = New System.Windows.Forms.TextBox()
        Me.lblNombreCurso = New System.Windows.Forms.Label()
        Me.txtNombreCurso = New System.Windows.Forms.TextBox()
        Me.lblCodigo = New System.Windows.Forms.Label()
        Me.txtCodigo = New System.Windows.Forms.TextBox()
        Me.dgvListadoCursos = New System.Windows.Forms.DataGridView()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtFechaInicio = New System.Windows.Forms.MaskedTextBox()
        Me.txtFechaFin = New System.Windows.Forms.MaskedTextBox()
        Me.lblConsultar = New System.Windows.Forms.Label()
        Me.lblLimpiar = New System.Windows.Forms.Label()
        Me.btnBorrar = New System.Windows.Forms.Button()
        Me.btnBuscar = New System.Windows.Forms.Button()
        Me.clnCodigo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.clnNombre = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.clnFechaInicio = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.clnFechaFin = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.clnDuracion = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.dgvListadoCursos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblFechaFin
        '
        Me.lblFechaFin.AutoSize = True
        Me.lblFechaFin.Location = New System.Drawing.Point(238, 148)
        Me.lblFechaFin.Name = "lblFechaFin"
        Me.lblFechaFin.Size = New System.Drawing.Size(83, 15)
        Me.lblFechaFin.TabIndex = 84
        Me.lblFechaFin.Text = "Fecha de Fin:"
        '
        'lblFechaInicio
        '
        Me.lblFechaInicio.AutoSize = True
        Me.lblFechaInicio.Location = New System.Drawing.Point(14, 148)
        Me.lblFechaInicio.Name = "lblFechaInicio"
        Me.lblFechaInicio.Size = New System.Drawing.Size(98, 15)
        Me.lblFechaInicio.TabIndex = 82
        Me.lblFechaInicio.Text = "Fecha de Inicio:"
        '
        'lblDuracion
        '
        Me.lblDuracion.AutoSize = True
        Me.lblDuracion.Location = New System.Drawing.Point(474, 148)
        Me.lblDuracion.Name = "lblDuracion"
        Me.lblDuracion.Size = New System.Drawing.Size(63, 15)
        Me.lblDuracion.TabIndex = 80
        Me.lblDuracion.Text = "Duración:"
        '
        'txtDuracion
        '
        Me.txtDuracion.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txtDuracion.ForeColor = System.Drawing.Color.White
        Me.txtDuracion.Location = New System.Drawing.Point(477, 165)
        Me.txtDuracion.Name = "txtDuracion"
        Me.txtDuracion.Size = New System.Drawing.Size(132, 21)
        Me.txtDuracion.TabIndex = 79
        '
        'lblNombreCurso
        '
        Me.lblNombreCurso.AutoSize = True
        Me.lblNombreCurso.Location = New System.Drawing.Point(14, 90)
        Me.lblNombreCurso.Name = "lblNombreCurso"
        Me.lblNombreCurso.Size = New System.Drawing.Size(116, 15)
        Me.lblNombreCurso.TabIndex = 78
        Me.lblNombreCurso.Text = "Nombre del Curso:"
        '
        'txtNombreCurso
        '
        Me.txtNombreCurso.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txtNombreCurso.ForeColor = System.Drawing.Color.White
        Me.txtNombreCurso.Location = New System.Drawing.Point(14, 107)
        Me.txtNombreCurso.MaxLength = 50
        Me.txtNombreCurso.Name = "txtNombreCurso"
        Me.txtNombreCurso.Size = New System.Drawing.Size(595, 21)
        Me.txtNombreCurso.TabIndex = 77
        '
        'lblCodigo
        '
        Me.lblCodigo.AutoSize = True
        Me.lblCodigo.Location = New System.Drawing.Point(14, 30)
        Me.lblCodigo.Name = "lblCodigo"
        Me.lblCodigo.Size = New System.Drawing.Size(52, 15)
        Me.lblCodigo.TabIndex = 76
        Me.lblCodigo.Text = "Código:"
        '
        'txtCodigo
        '
        Me.txtCodigo.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txtCodigo.ForeColor = System.Drawing.Color.White
        Me.txtCodigo.Location = New System.Drawing.Point(14, 47)
        Me.txtCodigo.MaxLength = 7
        Me.txtCodigo.Name = "txtCodigo"
        Me.txtCodigo.Size = New System.Drawing.Size(132, 21)
        Me.txtCodigo.TabIndex = 75
        '
        'dgvListadoCursos
        '
        Me.dgvListadoCursos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvListadoCursos.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.clnCodigo, Me.clnNombre, Me.clnFechaInicio, Me.clnFechaFin, Me.clnDuracion})
        Me.dgvListadoCursos.Location = New System.Drawing.Point(14, 214)
        Me.dgvListadoCursos.Name = "dgvListadoCursos"
        Me.dgvListadoCursos.RowHeadersVisible = False
        Me.dgvListadoCursos.Size = New System.Drawing.Size(752, 215)
        Me.dgvListadoCursos.TabIndex = 127
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(65, 442)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(256, 13)
        Me.Label2.TabIndex = 128
        Me.Label2.Text = "Doble Clic en el Codigo para Editar el Curso"
        '
        'txtFechaInicio
        '
        Me.txtFechaInicio.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txtFechaInicio.Font = New System.Drawing.Font("MS Reference Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFechaInicio.ForeColor = System.Drawing.Color.White
        Me.txtFechaInicio.Location = New System.Drawing.Point(17, 166)
        Me.txtFechaInicio.Mask = "00/00/0000"
        Me.txtFechaInicio.Name = "txtFechaInicio"
        Me.txtFechaInicio.Size = New System.Drawing.Size(93, 21)
        Me.txtFechaInicio.TabIndex = 139
        Me.txtFechaInicio.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.txtFechaInicio.ValidatingType = GetType(Date)
        '
        'txtFechaFin
        '
        Me.txtFechaFin.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txtFechaFin.Font = New System.Drawing.Font("MS Reference Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFechaFin.ForeColor = System.Drawing.Color.White
        Me.txtFechaFin.Location = New System.Drawing.Point(241, 166)
        Me.txtFechaFin.Mask = "00/00/0000"
        Me.txtFechaFin.Name = "txtFechaFin"
        Me.txtFechaFin.Size = New System.Drawing.Size(93, 21)
        Me.txtFechaFin.TabIndex = 140
        Me.txtFechaFin.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.txtFechaFin.ValidatingType = GetType(Date)
        '
        'lblConsultar
        '
        Me.lblConsultar.AutoSize = True
        Me.lblConsultar.Font = New System.Drawing.Font("MS Reference Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblConsultar.ForeColor = System.Drawing.Color.Gold
        Me.lblConsultar.Location = New System.Drawing.Point(668, 97)
        Me.lblConsultar.Name = "lblConsultar"
        Me.lblConsultar.Size = New System.Drawing.Size(78, 15)
        Me.lblConsultar.TabIndex = 177
        Me.lblConsultar.Text = "CONSULTAR"
        Me.lblConsultar.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'lblLimpiar
        '
        Me.lblLimpiar.AutoSize = True
        Me.lblLimpiar.Font = New System.Drawing.Font("MS Reference Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLimpiar.ForeColor = System.Drawing.Color.Gold
        Me.lblLimpiar.Location = New System.Drawing.Point(677, 190)
        Me.lblLimpiar.Name = "lblLimpiar"
        Me.lblLimpiar.Size = New System.Drawing.Size(55, 15)
        Me.lblLimpiar.TabIndex = 176
        Me.lblLimpiar.Text = "LIMPIAR"
        Me.lblLimpiar.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'btnBorrar
        '
        Me.btnBorrar.BackgroundImage = Global.Formacion.My.Resources.Resources.LimpiarCajas
        Me.btnBorrar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnBorrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBorrar.ForeColor = System.Drawing.Color.Transparent
        Me.btnBorrar.Location = New System.Drawing.Point(667, 122)
        Me.btnBorrar.Name = "btnBorrar"
        Me.btnBorrar.Size = New System.Drawing.Size(80, 64)
        Me.btnBorrar.TabIndex = 175
        Me.btnBorrar.UseVisualStyleBackColor = True
        '
        'btnBuscar
        '
        Me.btnBuscar.BackgroundImage = Global.Formacion.My.Resources.Resources.Filtrar
        Me.btnBuscar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBuscar.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBuscar.ForeColor = System.Drawing.Color.Transparent
        Me.btnBuscar.Location = New System.Drawing.Point(667, 30)
        Me.btnBuscar.Name = "btnBuscar"
        Me.btnBuscar.Size = New System.Drawing.Size(79, 64)
        Me.btnBuscar.TabIndex = 174
        Me.btnBuscar.UseVisualStyleBackColor = True
        '
        'clnCodigo
        '
        Me.clnCodigo.DataPropertyName = "CodigoCurso"
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.clnCodigo.DefaultCellStyle = DataGridViewCellStyle1
        Me.clnCodigo.HeaderText = "CODIGO"
        Me.clnCodigo.Name = "clnCodigo"
        Me.clnCodigo.Width = 75
        '
        'clnNombre
        '
        Me.clnNombre.DataPropertyName = "Nombre"
        Me.clnNombre.HeaderText = "NOMBRE"
        Me.clnNombre.Name = "clnNombre"
        Me.clnNombre.Width = 330
        '
        'clnFechaInicio
        '
        Me.clnFechaInicio.DataPropertyName = "FechaInicio"
        Me.clnFechaInicio.HeaderText = "FECHA INICIO"
        Me.clnFechaInicio.Name = "clnFechaInicio"
        Me.clnFechaInicio.Width = 125
        '
        'clnFechaFin
        '
        Me.clnFechaFin.DataPropertyName = "FechaFin"
        Me.clnFechaFin.HeaderText = "FECHA FIN"
        Me.clnFechaFin.Name = "clnFechaFin"
        Me.clnFechaFin.Width = 125
        '
        'clnDuracion
        '
        Me.clnDuracion.DataPropertyName = "Duracion"
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.clnDuracion.DefaultCellStyle = DataGridViewCellStyle2
        Me.clnDuracion.HeaderText = "HORAS"
        Me.clnDuracion.Name = "clnDuracion"
        Me.clnDuracion.Width = 80
        '
        'frmConsultaCursos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(778, 441)
        Me.Controls.Add(Me.lblConsultar)
        Me.Controls.Add(Me.lblLimpiar)
        Me.Controls.Add(Me.btnBorrar)
        Me.Controls.Add(Me.btnBuscar)
        Me.Controls.Add(Me.txtFechaFin)
        Me.Controls.Add(Me.txtFechaInicio)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.dgvListadoCursos)
        Me.Controls.Add(Me.lblFechaFin)
        Me.Controls.Add(Me.lblFechaInicio)
        Me.Controls.Add(Me.lblDuracion)
        Me.Controls.Add(Me.txtDuracion)
        Me.Controls.Add(Me.lblNombreCurso)
        Me.Controls.Add(Me.txtNombreCurso)
        Me.Controls.Add(Me.lblCodigo)
        Me.Controls.Add(Me.txtCodigo)
        Me.Font = New System.Drawing.Font("MS Reference Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.Color.Gold
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmConsultaCursos"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "CONSULTA DE CURSOS"
        CType(Me.dgvListadoCursos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblFechaFin As System.Windows.Forms.Label
    Friend WithEvents lblFechaInicio As System.Windows.Forms.Label
    Friend WithEvents lblDuracion As System.Windows.Forms.Label
    Friend WithEvents txtDuracion As System.Windows.Forms.TextBox
    Friend WithEvents lblNombreCurso As System.Windows.Forms.Label
    Friend WithEvents txtNombreCurso As System.Windows.Forms.TextBox
    Friend WithEvents lblCodigo As System.Windows.Forms.Label
    Friend WithEvents txtCodigo As System.Windows.Forms.TextBox
    Friend WithEvents dgvListadoCursos As System.Windows.Forms.DataGridView
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtNifProfesor As System.Windows.Forms.TextBox
    Friend WithEvents lblNif As System.Windows.Forms.Label
    Friend WithEvents txtFechaInicio As System.Windows.Forms.MaskedTextBox
    Friend WithEvents txtFechaFin As System.Windows.Forms.MaskedTextBox
    Friend WithEvents lblConsultar As System.Windows.Forms.Label
    Friend WithEvents lblLimpiar As System.Windows.Forms.Label
    Friend WithEvents btnBorrar As System.Windows.Forms.Button
    Friend WithEvents btnBuscar As System.Windows.Forms.Button
    Friend WithEvents clnCodigo As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents clnNombre As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents clnFechaInicio As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents clnFechaFin As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents clnDuracion As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
