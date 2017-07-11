<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSeleccionCurso
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
        Me.lblCurso = New System.Windows.Forms.Label()
        Me.cboCursos = New System.Windows.Forms.ComboBox()
        Me.btnInformeUnCurso = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblCurso
        '
        Me.lblCurso.AutoSize = True
        Me.lblCurso.Font = New System.Drawing.Font("MS Reference Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCurso.ForeColor = System.Drawing.Color.Gold
        Me.lblCurso.Location = New System.Drawing.Point(37, 39)
        Me.lblCurso.Name = "lblCurso"
        Me.lblCurso.Size = New System.Drawing.Size(41, 15)
        Me.lblCurso.TabIndex = 41
        Me.lblCurso.Text = "Curso"
        Me.lblCurso.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'cboCursos
        '
        Me.cboCursos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboCursos.FormattingEnabled = True
        Me.cboCursos.Location = New System.Drawing.Point(40, 57)
        Me.cboCursos.Name = "cboCursos"
        Me.cboCursos.Size = New System.Drawing.Size(525, 21)
        Me.cboCursos.TabIndex = 40
        '
        'btnInformeUnCurso
        '
        Me.btnInformeUnCurso.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnInformeUnCurso.Font = New System.Drawing.Font("MS Reference Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnInformeUnCurso.ForeColor = System.Drawing.Color.Gold
        Me.btnInformeUnCurso.Location = New System.Drawing.Point(192, 108)
        Me.btnInformeUnCurso.Name = "btnInformeUnCurso"
        Me.btnInformeUnCurso.Size = New System.Drawing.Size(180, 44)
        Me.btnInformeUnCurso.TabIndex = 42
        Me.btnInformeUnCurso.Text = "Informe de un Curso"
        Me.btnInformeUnCurso.UseVisualStyleBackColor = True
        '
        'frmSeleccionCurso
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(616, 190)
        Me.Controls.Add(Me.btnInformeUnCurso)
        Me.Controls.Add(Me.lblCurso)
        Me.Controls.Add(Me.cboCursos)
        Me.Name = "frmSeleccionCurso"
        Me.Text = "INFORME DE UN CURSO"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblCurso As System.Windows.Forms.Label
    Friend WithEvents cboCursos As System.Windows.Forms.ComboBox
    Friend WithEvents btnInformeUnCurso As System.Windows.Forms.Button
End Class
