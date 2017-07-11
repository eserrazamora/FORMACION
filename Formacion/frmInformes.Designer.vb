<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmInformes
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmInformes))
        Me.btnListadoInformacionCurso = New System.Windows.Forms.Button()
        Me.btnInformeAlumno = New System.Windows.Forms.Button()
        Me.btnListadoCursos = New System.Windows.Forms.Button()
        Me.btnListadoAlumnos = New System.Windows.Forms.Button()
        Me.btnListadoAulas = New System.Windows.Forms.Button()
        Me.btnListadoProfesores = New System.Windows.Forms.Button()
        Me.btnInformeUnCurso = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnListadoInformacionCurso
        '
        Me.btnListadoInformacionCurso.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnListadoInformacionCurso.Font = New System.Drawing.Font("MS Reference Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnListadoInformacionCurso.ForeColor = System.Drawing.Color.Gold
        Me.btnListadoInformacionCurso.Location = New System.Drawing.Point(172, 161)
        Me.btnListadoInformacionCurso.Name = "btnListadoInformacionCurso"
        Me.btnListadoInformacionCurso.Size = New System.Drawing.Size(123, 60)
        Me.btnListadoInformacionCurso.TabIndex = 12
        Me.btnListadoInformacionCurso.Text = "Listado de Informacion por Curso"
        Me.btnListadoInformacionCurso.UseVisualStyleBackColor = True
        '
        'btnInformeAlumno
        '
        Me.btnInformeAlumno.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnInformeAlumno.Font = New System.Drawing.Font("MS Reference Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnInformeAlumno.ForeColor = System.Drawing.Color.Gold
        Me.btnInformeAlumno.Location = New System.Drawing.Point(172, 91)
        Me.btnInformeAlumno.Name = "btnInformeAlumno"
        Me.btnInformeAlumno.Size = New System.Drawing.Size(123, 61)
        Me.btnInformeAlumno.TabIndex = 11
        Me.btnInformeAlumno.Text = "Informe Individual de un Alumno"
        Me.btnInformeAlumno.UseVisualStyleBackColor = True
        '
        'btnListadoCursos
        '
        Me.btnListadoCursos.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnListadoCursos.Font = New System.Drawing.Font("MS Reference Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnListadoCursos.ForeColor = System.Drawing.Color.Gold
        Me.btnListadoCursos.Location = New System.Drawing.Point(172, 26)
        Me.btnListadoCursos.Name = "btnListadoCursos"
        Me.btnListadoCursos.Size = New System.Drawing.Size(123, 57)
        Me.btnListadoCursos.TabIndex = 10
        Me.btnListadoCursos.Text = "Listado de Cursos"
        Me.btnListadoCursos.UseVisualStyleBackColor = True
        '
        'btnListadoAlumnos
        '
        Me.btnListadoAlumnos.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnListadoAlumnos.Font = New System.Drawing.Font("MS Reference Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnListadoAlumnos.ForeColor = System.Drawing.Color.Gold
        Me.btnListadoAlumnos.Location = New System.Drawing.Point(36, 26)
        Me.btnListadoAlumnos.Name = "btnListadoAlumnos"
        Me.btnListadoAlumnos.Size = New System.Drawing.Size(113, 57)
        Me.btnListadoAlumnos.TabIndex = 9
        Me.btnListadoAlumnos.Text = "Listado de Alumnos"
        Me.btnListadoAlumnos.UseVisualStyleBackColor = True
        '
        'btnListadoAulas
        '
        Me.btnListadoAulas.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnListadoAulas.Font = New System.Drawing.Font("MS Reference Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnListadoAulas.ForeColor = System.Drawing.Color.Gold
        Me.btnListadoAulas.Location = New System.Drawing.Point(36, 161)
        Me.btnListadoAulas.Name = "btnListadoAulas"
        Me.btnListadoAulas.Size = New System.Drawing.Size(113, 60)
        Me.btnListadoAulas.TabIndex = 8
        Me.btnListadoAulas.Text = "Listado de Aulas"
        Me.btnListadoAulas.UseVisualStyleBackColor = True
        '
        'btnListadoProfesores
        '
        Me.btnListadoProfesores.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnListadoProfesores.Font = New System.Drawing.Font("MS Reference Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnListadoProfesores.ForeColor = System.Drawing.Color.Gold
        Me.btnListadoProfesores.Location = New System.Drawing.Point(36, 91)
        Me.btnListadoProfesores.Name = "btnListadoProfesores"
        Me.btnListadoProfesores.Size = New System.Drawing.Size(113, 61)
        Me.btnListadoProfesores.TabIndex = 7
        Me.btnListadoProfesores.Text = "Listado de Profesores"
        Me.btnListadoProfesores.UseVisualStyleBackColor = True
        '
        'btnInformeUnCurso
        '
        Me.btnInformeUnCurso.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnInformeUnCurso.Font = New System.Drawing.Font("MS Reference Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnInformeUnCurso.ForeColor = System.Drawing.Color.Gold
        Me.btnInformeUnCurso.Location = New System.Drawing.Point(99, 234)
        Me.btnInformeUnCurso.Name = "btnInformeUnCurso"
        Me.btnInformeUnCurso.Size = New System.Drawing.Size(123, 60)
        Me.btnInformeUnCurso.TabIndex = 13
        Me.btnInformeUnCurso.Text = "Informe de un Curso"
        Me.btnInformeUnCurso.UseVisualStyleBackColor = True
        '
        'frmInformes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(337, 321)
        Me.Controls.Add(Me.btnInformeUnCurso)
        Me.Controls.Add(Me.btnListadoInformacionCurso)
        Me.Controls.Add(Me.btnInformeAlumno)
        Me.Controls.Add(Me.btnListadoCursos)
        Me.Controls.Add(Me.btnListadoAlumnos)
        Me.Controls.Add(Me.btnListadoAulas)
        Me.Controls.Add(Me.btnListadoProfesores)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmInformes"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "INFORMES"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnListadoInformacionCurso As System.Windows.Forms.Button
    Friend WithEvents btnInformeAlumno As System.Windows.Forms.Button
    Friend WithEvents btnListadoCursos As System.Windows.Forms.Button
    Friend WithEvents btnListadoAlumnos As System.Windows.Forms.Button
    Friend WithEvents btnListadoAulas As System.Windows.Forms.Button
    Friend WithEvents btnListadoProfesores As System.Windows.Forms.Button
    Friend WithEvents btnInformeUnCurso As System.Windows.Forms.Button
End Class
