<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmLogin
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmLogin))
        Me.txtUsuario = New System.Windows.Forms.TextBox()
        Me.txtContraseña = New System.Windows.Forms.TextBox()
        Me.lblUsuario = New System.Windows.Forms.Label()
        Me.lblContraseña = New System.Windows.Forms.Label()
        Me.btnBorrar = New System.Windows.Forms.Button()
        Me.btnLogin = New System.Windows.Forms.Button()
        Me.imgLogin = New System.Windows.Forms.PictureBox()
        Me.tooltip = New System.Windows.Forms.ToolTip(Me.components)
        CType(Me.imgLogin, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtUsuario
        '
        Me.txtUsuario.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txtUsuario.ForeColor = System.Drawing.Color.White
        Me.txtUsuario.Location = New System.Drawing.Point(176, 40)
        Me.txtUsuario.Name = "txtUsuario"
        Me.txtUsuario.Size = New System.Drawing.Size(182, 21)
        Me.txtUsuario.TabIndex = 0
        '
        'txtContraseña
        '
        Me.txtContraseña.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txtContraseña.ForeColor = System.Drawing.Color.White
        Me.txtContraseña.Location = New System.Drawing.Point(176, 104)
        Me.txtContraseña.Name = "txtContraseña"
        Me.txtContraseña.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtContraseña.Size = New System.Drawing.Size(182, 21)
        Me.txtContraseña.TabIndex = 1
        '
        'lblUsuario
        '
        Me.lblUsuario.AutoSize = True
        Me.lblUsuario.Location = New System.Drawing.Point(173, 21)
        Me.lblUsuario.Name = "lblUsuario"
        Me.lblUsuario.Size = New System.Drawing.Size(50, 15)
        Me.lblUsuario.TabIndex = 1
        Me.lblUsuario.Text = "Usuario"
        '
        'lblContraseña
        '
        Me.lblContraseña.AutoSize = True
        Me.lblContraseña.Location = New System.Drawing.Point(173, 86)
        Me.lblContraseña.Name = "lblContraseña"
        Me.lblContraseña.Size = New System.Drawing.Size(73, 15)
        Me.lblContraseña.TabIndex = 3
        Me.lblContraseña.Text = "Contraseña"
        '
        'btnBorrar
        '
        Me.btnBorrar.BackgroundImage = Global.Formacion.My.Resources.Resources.LimpiarCajas
        Me.btnBorrar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnBorrar.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnBorrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBorrar.ForeColor = System.Drawing.Color.White
        Me.btnBorrar.Location = New System.Drawing.Point(283, 158)
        Me.btnBorrar.Name = "btnBorrar"
        Me.btnBorrar.Size = New System.Drawing.Size(52, 47)
        Me.btnBorrar.TabIndex = 5
        Me.btnBorrar.UseVisualStyleBackColor = True
        '
        'btnLogin
        '
        Me.btnLogin.BackgroundImage = Global.Formacion.My.Resources.Resources.Login1
        Me.btnLogin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnLogin.ForeColor = System.Drawing.Color.White
        Me.btnLogin.Location = New System.Drawing.Point(194, 158)
        Me.btnLogin.Name = "btnLogin"
        Me.btnLogin.Size = New System.Drawing.Size(52, 47)
        Me.btnLogin.TabIndex = 4
        Me.btnLogin.UseVisualStyleBackColor = True
        '
        'imgLogin
        '
        Me.imgLogin.Image = CType(resources.GetObject("imgLogin.Image"), System.Drawing.Image)
        Me.imgLogin.Location = New System.Drawing.Point(14, 17)
        Me.imgLogin.Name = "imgLogin"
        Me.imgLogin.Size = New System.Drawing.Size(146, 188)
        Me.imgLogin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.imgLogin.TabIndex = 6
        Me.imgLogin.TabStop = False
        '
        'frmLogin
        '
        Me.AcceptButton = Me.btnLogin
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.CancelButton = Me.btnBorrar
        Me.ClientSize = New System.Drawing.Size(379, 228)
        Me.Controls.Add(Me.imgLogin)
        Me.Controls.Add(Me.btnBorrar)
        Me.Controls.Add(Me.btnLogin)
        Me.Controls.Add(Me.lblContraseña)
        Me.Controls.Add(Me.lblUsuario)
        Me.Controls.Add(Me.txtContraseña)
        Me.Controls.Add(Me.txtUsuario)
        Me.Font = New System.Drawing.Font("MS Reference Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.Color.Gold
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmLogin"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "AUTENTICACION EN EL SISTEMA"
        CType(Me.imgLogin, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtUsuario As System.Windows.Forms.TextBox
    Friend WithEvents txtContraseña As System.Windows.Forms.TextBox
    Friend WithEvents lblUsuario As System.Windows.Forms.Label
    Friend WithEvents lblContraseña As System.Windows.Forms.Label
    Friend WithEvents imgLogin As System.Windows.Forms.PictureBox
    Friend WithEvents btnBorrar As System.Windows.Forms.Button
    Friend WithEvents btnLogin As System.Windows.Forms.Button
    Friend WithEvents tooltip As System.Windows.Forms.ToolTip

End Class
