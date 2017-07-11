<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSeleccionPersonasCurso
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmSeleccionPersonasCurso))
        Me.clbSeleccionPersonas = New System.Windows.Forms.CheckedListBox()
        Me.btnAsignar = New System.Windows.Forms.Button()
        Me.lblCodigoCurso = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'clbSeleccionPersonas
        '
        Me.clbSeleccionPersonas.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.clbSeleccionPersonas.CheckOnClick = True
        Me.clbSeleccionPersonas.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.clbSeleccionPersonas.ForeColor = System.Drawing.Color.Gold
        Me.clbSeleccionPersonas.FormattingEnabled = True
        Me.clbSeleccionPersonas.Location = New System.Drawing.Point(71, 65)
        Me.clbSeleccionPersonas.Name = "clbSeleccionPersonas"
        Me.clbSeleccionPersonas.Size = New System.Drawing.Size(322, 242)
        Me.clbSeleccionPersonas.TabIndex = 0
        '
        'btnAsignar
        '
        Me.btnAsignar.Location = New System.Drawing.Point(189, 324)
        Me.btnAsignar.Name = "btnAsignar"
        Me.btnAsignar.Size = New System.Drawing.Size(75, 23)
        Me.btnAsignar.TabIndex = 1
        Me.btnAsignar.Text = "Asignar"
        Me.btnAsignar.UseVisualStyleBackColor = True
        '
        'lblCodigoCurso
        '
        Me.lblCodigoCurso.AutoSize = True
        Me.lblCodigoCurso.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCodigoCurso.ForeColor = System.Drawing.Color.Gold
        Me.lblCodigoCurso.Location = New System.Drawing.Point(65, 19)
        Me.lblCodigoCurso.Name = "lblCodigoCurso"
        Me.lblCodigoCurso.Size = New System.Drawing.Size(214, 24)
        Me.lblCodigoCurso.TabIndex = 2
        Me.lblCodigoCurso.Text = "CodigoyNombrecurso"
        '
        'frmSeleccionPersonasCurso
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(490, 387)
        Me.Controls.Add(Me.lblCodigoCurso)
        Me.Controls.Add(Me.btnAsignar)
        Me.Controls.Add(Me.clbSeleccionPersonas)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmSeleccionPersonasCurso"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "SELECCION DE ALUMNOS PARA EL CURSO"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents clbSeleccionPersonas As System.Windows.Forms.CheckedListBox
    Friend WithEvents btnAsignar As System.Windows.Forms.Button
    Friend WithEvents lblCodigoCurso As System.Windows.Forms.Label
End Class
