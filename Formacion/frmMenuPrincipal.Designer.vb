<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMenuPrincipal
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMenuPrincipal))
        Me.btnMatriculacion = New System.Windows.Forms.Button()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.ALUMNOSToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AlumnosMantenimiento = New System.Windows.Forms.ToolStripMenuItem()
        Me.AlumnosConsulta = New System.Windows.Forms.ToolStripMenuItem()
        Me.AlumnosMatriculacion = New System.Windows.Forms.ToolStripMenuItem()
        Me.AlumnosAsistencia = New System.Windows.Forms.ToolStripMenuItem()
        Me.AlumnosCalificaciones = New System.Windows.Forms.ToolStripMenuItem()
        Me.PROFESORESToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ProfesoresMantenimiento = New System.Windows.Forms.ToolStripMenuItem()
        Me.ProfesoresConsulta = New System.Windows.Forms.ToolStripMenuItem()
        Me.ProfesoresAsignaciónACursos = New System.Windows.Forms.ToolStripMenuItem()
        Me.ProfesoresControlDeAsistencia = New System.Windows.Forms.ToolStripMenuItem()
        Me.ProfesoresControlDeCalificaciones = New System.Windows.Forms.ToolStripMenuItem()
        Me.AULASToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AulasMantenimiento = New System.Windows.Forms.ToolStripMenuItem()
        Me.CURSOSToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CursosMantenimiento = New System.Windows.Forms.ToolStripMenuItem()
        Me.CursosConsulta = New System.Windows.Forms.ToolStripMenuItem()
        Me.TABLASAUXILIARESToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TablasCodigosPostales = New System.Windows.Forms.ToolStripMenuItem()
        Me.TablasInformaciónDeLogin = New System.Windows.Forms.ToolStripMenuItem()
        Me.TablasTiposAulas = New System.Windows.Forms.ToolStripMenuItem()
        Me.TablasTiposDeCursos = New System.Windows.Forms.ToolStripMenuItem()
        Me.TablasTiposDeUsuarios = New System.Windows.Forms.ToolStripMenuItem()
        Me.CONSULTASToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ConsultasAlumnos = New System.Windows.Forms.ToolStripMenuItem()
        Me.ConsultasProfesores = New System.Windows.Forms.ToolStripMenuItem()
        Me.ConsultasCursos = New System.Windows.Forms.ToolStripMenuItem()
        Me.INFORMESToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.InformesListadoDeAlumnos = New System.Windows.Forms.ToolStripMenuItem()
        Me.InformesListadoDeProfesores = New System.Windows.Forms.ToolStripMenuItem()
        Me.InformesListadoDeAulas = New System.Windows.Forms.ToolStripMenuItem()
        Me.InformesListadoDeCursos = New System.Windows.Forms.ToolStripMenuItem()
        Me.InformesInformeDeIndividualDeUnAlumno = New System.Windows.Forms.ToolStripMenuItem()
        Me.InformesInformacionPorCurso = New System.Windows.Forms.ToolStripMenuItem()
        Me.InformesInformeDeUnCurso = New System.Windows.Forms.ToolStripMenuItem()
        Me.btnAsistencia = New System.Windows.Forms.Button()
        Me.btnCalificaciones = New System.Windows.Forms.Button()
        Me.btnCrudAulas = New System.Windows.Forms.Button()
        Me.btnCrudProfesores = New System.Windows.Forms.Button()
        Me.btnCrudCursos = New System.Windows.Forms.Button()
        Me.btnCrudAlumnos = New System.Windows.Forms.Button()
        Me.lblAulas = New System.Windows.Forms.Label()
        Me.lblCursos = New System.Windows.Forms.Label()
        Me.lblAlumnos = New System.Windows.Forms.Label()
        Me.lblProfesores = New System.Windows.Forms.Label()
        Me.lblCalificaciones = New System.Windows.Forms.Label()
        Me.lblAsistencias = New System.Windows.Forms.Label()
        Me.lblMatriculacion = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnMatriculacion
        '
        Me.btnMatriculacion.BackgroundImage = Global.Formacion.My.Resources.Resources.Matricularse
        Me.btnMatriculacion.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnMatriculacion.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnMatriculacion.Location = New System.Drawing.Point(469, 200)
        Me.btnMatriculacion.Name = "btnMatriculacion"
        Me.btnMatriculacion.Size = New System.Drawing.Size(74, 70)
        Me.btnMatriculacion.TabIndex = 4
        Me.btnMatriculacion.UseVisualStyleBackColor = True
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ALUMNOSToolStripMenuItem, Me.PROFESORESToolStripMenuItem, Me.AULASToolStripMenuItem, Me.CURSOSToolStripMenuItem, Me.TABLASAUXILIARESToolStripMenuItem, Me.CONSULTASToolStripMenuItem, Me.INFORMESToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(628, 24)
        Me.MenuStrip1.TabIndex = 17
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'ALUMNOSToolStripMenuItem
        '
        Me.ALUMNOSToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AlumnosMantenimiento, Me.AlumnosConsulta, Me.AlumnosMatriculacion, Me.AlumnosAsistencia, Me.AlumnosCalificaciones})
        Me.ALUMNOSToolStripMenuItem.Name = "ALUMNOSToolStripMenuItem"
        Me.ALUMNOSToolStripMenuItem.Size = New System.Drawing.Size(76, 20)
        Me.ALUMNOSToolStripMenuItem.Text = "ALUMNOS"
        '
        'AlumnosMantenimiento
        '
        Me.AlumnosMantenimiento.Name = "AlumnosMantenimiento"
        Me.AlumnosMantenimiento.Size = New System.Drawing.Size(156, 22)
        Me.AlumnosMantenimiento.Text = "Mantenimiento"
        '
        'AlumnosConsulta
        '
        Me.AlumnosConsulta.Name = "AlumnosConsulta"
        Me.AlumnosConsulta.Size = New System.Drawing.Size(156, 22)
        Me.AlumnosConsulta.Text = "Consulta"
        '
        'AlumnosMatriculacion
        '
        Me.AlumnosMatriculacion.Name = "AlumnosMatriculacion"
        Me.AlumnosMatriculacion.Size = New System.Drawing.Size(156, 22)
        Me.AlumnosMatriculacion.Text = "Matriculacion"
        '
        'AlumnosAsistencia
        '
        Me.AlumnosAsistencia.Name = "AlumnosAsistencia"
        Me.AlumnosAsistencia.Size = New System.Drawing.Size(156, 22)
        Me.AlumnosAsistencia.Text = "Asistencia"
        '
        'AlumnosCalificaciones
        '
        Me.AlumnosCalificaciones.Name = "AlumnosCalificaciones"
        Me.AlumnosCalificaciones.Size = New System.Drawing.Size(156, 22)
        Me.AlumnosCalificaciones.Text = "Calificaciones"
        '
        'PROFESORESToolStripMenuItem
        '
        Me.PROFESORESToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ProfesoresMantenimiento, Me.ProfesoresConsulta, Me.ProfesoresAsignaciónACursos, Me.ProfesoresControlDeAsistencia, Me.ProfesoresControlDeCalificaciones})
        Me.PROFESORESToolStripMenuItem.Name = "PROFESORESToolStripMenuItem"
        Me.PROFESORESToolStripMenuItem.Size = New System.Drawing.Size(88, 20)
        Me.PROFESORESToolStripMenuItem.Text = "PROFESORES"
        '
        'ProfesoresMantenimiento
        '
        Me.ProfesoresMantenimiento.Name = "ProfesoresMantenimiento"
        Me.ProfesoresMantenimiento.Size = New System.Drawing.Size(206, 22)
        Me.ProfesoresMantenimiento.Text = "Mantenimiento"
        '
        'ProfesoresConsulta
        '
        Me.ProfesoresConsulta.Name = "ProfesoresConsulta"
        Me.ProfesoresConsulta.Size = New System.Drawing.Size(206, 22)
        Me.ProfesoresConsulta.Text = "Consulta"
        '
        'ProfesoresAsignaciónACursos
        '
        Me.ProfesoresAsignaciónACursos.Name = "ProfesoresAsignaciónACursos"
        Me.ProfesoresAsignaciónACursos.Size = New System.Drawing.Size(206, 22)
        Me.ProfesoresAsignaciónACursos.Text = "Asignación a Cursos"
        '
        'ProfesoresControlDeAsistencia
        '
        Me.ProfesoresControlDeAsistencia.Name = "ProfesoresControlDeAsistencia"
        Me.ProfesoresControlDeAsistencia.Size = New System.Drawing.Size(206, 22)
        Me.ProfesoresControlDeAsistencia.Text = "Control de Asistencia"
        '
        'ProfesoresControlDeCalificaciones
        '
        Me.ProfesoresControlDeCalificaciones.Name = "ProfesoresControlDeCalificaciones"
        Me.ProfesoresControlDeCalificaciones.Size = New System.Drawing.Size(206, 22)
        Me.ProfesoresControlDeCalificaciones.Text = "Control de Calificaciones"
        '
        'AULASToolStripMenuItem
        '
        Me.AULASToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AulasMantenimiento})
        Me.AULASToolStripMenuItem.Name = "AULASToolStripMenuItem"
        Me.AULASToolStripMenuItem.Size = New System.Drawing.Size(55, 20)
        Me.AULASToolStripMenuItem.Text = "AULAS"
        '
        'AulasMantenimiento
        '
        Me.AulasMantenimiento.Name = "AulasMantenimiento"
        Me.AulasMantenimiento.Size = New System.Drawing.Size(156, 22)
        Me.AulasMantenimiento.Text = "Mantenimiento"
        '
        'CURSOSToolStripMenuItem
        '
        Me.CURSOSToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CursosMantenimiento, Me.CursosConsulta})
        Me.CURSOSToolStripMenuItem.Name = "CURSOSToolStripMenuItem"
        Me.CURSOSToolStripMenuItem.Size = New System.Drawing.Size(63, 20)
        Me.CURSOSToolStripMenuItem.Text = "CURSOS"
        '
        'CursosMantenimiento
        '
        Me.CursosMantenimiento.Name = "CursosMantenimiento"
        Me.CursosMantenimiento.Size = New System.Drawing.Size(156, 22)
        Me.CursosMantenimiento.Text = "Mantenimiento"
        '
        'CursosConsulta
        '
        Me.CursosConsulta.Name = "CursosConsulta"
        Me.CursosConsulta.Size = New System.Drawing.Size(156, 22)
        Me.CursosConsulta.Text = "Consulta"
        '
        'TABLASAUXILIARESToolStripMenuItem
        '
        Me.TABLASAUXILIARESToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.TablasCodigosPostales, Me.TablasInformaciónDeLogin, Me.TablasTiposAulas, Me.TablasTiposDeCursos, Me.TablasTiposDeUsuarios})
        Me.TABLASAUXILIARESToolStripMenuItem.Name = "TABLASAUXILIARESToolStripMenuItem"
        Me.TABLASAUXILIARESToolStripMenuItem.Size = New System.Drawing.Size(125, 20)
        Me.TABLASAUXILIARESToolStripMenuItem.Text = "TABLAS AUXILIARES"
        '
        'TablasCodigosPostales
        '
        Me.TablasCodigosPostales.Name = "TablasCodigosPostales"
        Me.TablasCodigosPostales.Size = New System.Drawing.Size(188, 22)
        Me.TablasCodigosPostales.Text = "Códigos Postales"
        '
        'TablasInformaciónDeLogin
        '
        Me.TablasInformaciónDeLogin.Name = "TablasInformaciónDeLogin"
        Me.TablasInformaciónDeLogin.Size = New System.Drawing.Size(188, 22)
        Me.TablasInformaciónDeLogin.Text = "Información de Login"
        '
        'TablasTiposAulas
        '
        Me.TablasTiposAulas.Name = "TablasTiposAulas"
        Me.TablasTiposAulas.Size = New System.Drawing.Size(188, 22)
        Me.TablasTiposAulas.Text = "Tipos de Aulas"
        '
        'TablasTiposDeCursos
        '
        Me.TablasTiposDeCursos.Name = "TablasTiposDeCursos"
        Me.TablasTiposDeCursos.Size = New System.Drawing.Size(188, 22)
        Me.TablasTiposDeCursos.Text = "Tipos de Cursos"
        '
        'TablasTiposDeUsuarios
        '
        Me.TablasTiposDeUsuarios.Name = "TablasTiposDeUsuarios"
        Me.TablasTiposDeUsuarios.Size = New System.Drawing.Size(188, 22)
        Me.TablasTiposDeUsuarios.Text = "Tipos de Usuarios"
        '
        'CONSULTASToolStripMenuItem
        '
        Me.CONSULTASToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ConsultasAlumnos, Me.ConsultasProfesores, Me.ConsultasCursos})
        Me.CONSULTASToolStripMenuItem.Name = "CONSULTASToolStripMenuItem"
        Me.CONSULTASToolStripMenuItem.Size = New System.Drawing.Size(84, 20)
        Me.CONSULTASToolStripMenuItem.Text = "CONSULTAS"
        '
        'ConsultasAlumnos
        '
        Me.ConsultasAlumnos.Name = "ConsultasAlumnos"
        Me.ConsultasAlumnos.Size = New System.Drawing.Size(129, 22)
        Me.ConsultasAlumnos.Text = "Alumnos"
        '
        'ConsultasProfesores
        '
        Me.ConsultasProfesores.Name = "ConsultasProfesores"
        Me.ConsultasProfesores.Size = New System.Drawing.Size(129, 22)
        Me.ConsultasProfesores.Text = "Profesores"
        '
        'ConsultasCursos
        '
        Me.ConsultasCursos.Name = "ConsultasCursos"
        Me.ConsultasCursos.Size = New System.Drawing.Size(129, 22)
        Me.ConsultasCursos.Text = "Cursos"
        '
        'INFORMESToolStripMenuItem
        '
        Me.INFORMESToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.InformesListadoDeAlumnos, Me.InformesListadoDeProfesores, Me.InformesListadoDeAulas, Me.InformesListadoDeCursos, Me.InformesInformeDeIndividualDeUnAlumno, Me.InformesInformacionPorCurso, Me.InformesInformeDeUnCurso})
        Me.INFORMESToolStripMenuItem.Name = "INFORMESToolStripMenuItem"
        Me.INFORMESToolStripMenuItem.Size = New System.Drawing.Size(76, 20)
        Me.INFORMESToolStripMenuItem.Text = "INFORMES"
        '
        'InformesListadoDeAlumnos
        '
        Me.InformesListadoDeAlumnos.Name = "InformesListadoDeAlumnos"
        Me.InformesListadoDeAlumnos.Size = New System.Drawing.Size(266, 22)
        Me.InformesListadoDeAlumnos.Text = "Listado de Alumnos"
        '
        'InformesListadoDeProfesores
        '
        Me.InformesListadoDeProfesores.Name = "InformesListadoDeProfesores"
        Me.InformesListadoDeProfesores.Size = New System.Drawing.Size(266, 22)
        Me.InformesListadoDeProfesores.Text = "Listado de Profesores"
        '
        'InformesListadoDeAulas
        '
        Me.InformesListadoDeAulas.Name = "InformesListadoDeAulas"
        Me.InformesListadoDeAulas.Size = New System.Drawing.Size(266, 22)
        Me.InformesListadoDeAulas.Text = "Listado de Aulas"
        '
        'InformesListadoDeCursos
        '
        Me.InformesListadoDeCursos.Name = "InformesListadoDeCursos"
        Me.InformesListadoDeCursos.Size = New System.Drawing.Size(266, 22)
        Me.InformesListadoDeCursos.Text = "Listado de Cursos"
        '
        'InformesInformeDeIndividualDeUnAlumno
        '
        Me.InformesInformeDeIndividualDeUnAlumno.Name = "InformesInformeDeIndividualDeUnAlumno"
        Me.InformesInformeDeIndividualDeUnAlumno.Size = New System.Drawing.Size(266, 22)
        Me.InformesInformeDeIndividualDeUnAlumno.Text = "Informe de Individual de un Alumno"
        '
        'InformesInformacionPorCurso
        '
        Me.InformesInformacionPorCurso.Name = "InformesInformacionPorCurso"
        Me.InformesInformacionPorCurso.Size = New System.Drawing.Size(266, 22)
        Me.InformesInformacionPorCurso.Text = "Informacion por Curso"
        '
        'InformesInformeDeUnCurso
        '
        Me.InformesInformeDeUnCurso.Name = "InformesInformeDeUnCurso"
        Me.InformesInformeDeUnCurso.Size = New System.Drawing.Size(266, 22)
        Me.InformesInformeDeUnCurso.Text = "Informe de un Curso"
        '
        'btnAsistencia
        '
        Me.btnAsistencia.BackgroundImage = Global.Formacion.My.Resources.Resources.Asistencia
        Me.btnAsistencia.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnAsistencia.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAsistencia.Location = New System.Drawing.Point(352, 200)
        Me.btnAsistencia.Name = "btnAsistencia"
        Me.btnAsistencia.Size = New System.Drawing.Size(74, 70)
        Me.btnAsistencia.TabIndex = 7
        Me.btnAsistencia.UseVisualStyleBackColor = True
        '
        'btnCalificaciones
        '
        Me.btnCalificaciones.BackgroundImage = Global.Formacion.My.Resources.Resources.calificacionesAMARILLO
        Me.btnCalificaciones.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnCalificaciones.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCalificaciones.Location = New System.Drawing.Point(225, 200)
        Me.btnCalificaciones.Name = "btnCalificaciones"
        Me.btnCalificaciones.Size = New System.Drawing.Size(74, 70)
        Me.btnCalificaciones.TabIndex = 6
        Me.btnCalificaciones.UseVisualStyleBackColor = True
        '
        'btnCrudAulas
        '
        Me.btnCrudAulas.BackgroundImage = Global.Formacion.My.Resources.Resources.Aula
        Me.btnCrudAulas.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnCrudAulas.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCrudAulas.Location = New System.Drawing.Point(127, 83)
        Me.btnCrudAulas.Name = "btnCrudAulas"
        Me.btnCrudAulas.Size = New System.Drawing.Size(74, 72)
        Me.btnCrudAulas.TabIndex = 3
        Me.btnCrudAulas.UseVisualStyleBackColor = True
        '
        'btnCrudProfesores
        '
        Me.btnCrudProfesores.BackgroundImage = Global.Formacion.My.Resources.Resources.Profesor
        Me.btnCrudProfesores.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnCrudProfesores.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCrudProfesores.Location = New System.Drawing.Point(450, 83)
        Me.btnCrudProfesores.Name = "btnCrudProfesores"
        Me.btnCrudProfesores.Size = New System.Drawing.Size(74, 72)
        Me.btnCrudProfesores.TabIndex = 2
        Me.btnCrudProfesores.UseVisualStyleBackColor = True
        '
        'btnCrudCursos
        '
        Me.btnCrudCursos.BackgroundImage = Global.Formacion.My.Resources.Resources.cursos
        Me.btnCrudCursos.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnCrudCursos.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCrudCursos.Location = New System.Drawing.Point(222, 83)
        Me.btnCrudCursos.Name = "btnCrudCursos"
        Me.btnCrudCursos.Size = New System.Drawing.Size(107, 72)
        Me.btnCrudCursos.TabIndex = 1
        Me.btnCrudCursos.UseVisualStyleBackColor = True
        '
        'btnCrudAlumnos
        '
        Me.btnCrudAlumnos.BackgroundImage = Global.Formacion.My.Resources.Resources.Alumnos
        Me.btnCrudAlumnos.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnCrudAlumnos.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCrudAlumnos.Location = New System.Drawing.Point(352, 83)
        Me.btnCrudAlumnos.Name = "btnCrudAlumnos"
        Me.btnCrudAlumnos.Size = New System.Drawing.Size(74, 72)
        Me.btnCrudAlumnos.TabIndex = 0
        Me.btnCrudAlumnos.UseVisualStyleBackColor = True
        '
        'lblAulas
        '
        Me.lblAulas.AutoSize = True
        Me.lblAulas.Font = New System.Drawing.Font("MS Reference Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAulas.ForeColor = System.Drawing.Color.Gold
        Me.lblAulas.Location = New System.Drawing.Point(138, 158)
        Me.lblAulas.Name = "lblAulas"
        Me.lblAulas.Size = New System.Drawing.Size(45, 15)
        Me.lblAulas.TabIndex = 177
        Me.lblAulas.Text = "AULAS"
        Me.lblAulas.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'lblCursos
        '
        Me.lblCursos.AutoSize = True
        Me.lblCursos.Font = New System.Drawing.Font("MS Reference Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCursos.ForeColor = System.Drawing.Color.Gold
        Me.lblCursos.Location = New System.Drawing.Point(247, 158)
        Me.lblCursos.Name = "lblCursos"
        Me.lblCursos.Size = New System.Drawing.Size(57, 15)
        Me.lblCursos.TabIndex = 178
        Me.lblCursos.Text = "CURSOS"
        Me.lblCursos.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'lblAlumnos
        '
        Me.lblAlumnos.AutoSize = True
        Me.lblAlumnos.Font = New System.Drawing.Font("MS Reference Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAlumnos.ForeColor = System.Drawing.Color.Gold
        Me.lblAlumnos.Location = New System.Drawing.Point(356, 158)
        Me.lblAlumnos.Name = "lblAlumnos"
        Me.lblAlumnos.Size = New System.Drawing.Size(63, 15)
        Me.lblAlumnos.TabIndex = 179
        Me.lblAlumnos.Text = "ALUMNOS"
        Me.lblAlumnos.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'lblProfesores
        '
        Me.lblProfesores.AutoSize = True
        Me.lblProfesores.Font = New System.Drawing.Font("MS Reference Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblProfesores.ForeColor = System.Drawing.Color.Gold
        Me.lblProfesores.Location = New System.Drawing.Point(447, 158)
        Me.lblProfesores.Name = "lblProfesores"
        Me.lblProfesores.Size = New System.Drawing.Size(84, 15)
        Me.lblProfesores.TabIndex = 180
        Me.lblProfesores.Text = "PROFESORES"
        Me.lblProfesores.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'lblCalificaciones
        '
        Me.lblCalificaciones.AutoSize = True
        Me.lblCalificaciones.Font = New System.Drawing.Font("MS Reference Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCalificaciones.ForeColor = System.Drawing.Color.Gold
        Me.lblCalificaciones.Location = New System.Drawing.Point(208, 273)
        Me.lblCalificaciones.Name = "lblCalificaciones"
        Me.lblCalificaciones.Size = New System.Drawing.Size(109, 15)
        Me.lblCalificaciones.TabIndex = 181
        Me.lblCalificaciones.Text = "CALIFICACIONES"
        Me.lblCalificaciones.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'lblAsistencias
        '
        Me.lblAsistencias.AutoSize = True
        Me.lblAsistencias.Font = New System.Drawing.Font("MS Reference Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAsistencias.ForeColor = System.Drawing.Color.Gold
        Me.lblAsistencias.Location = New System.Drawing.Point(344, 273)
        Me.lblAsistencias.Name = "lblAsistencias"
        Me.lblAsistencias.Size = New System.Drawing.Size(88, 15)
        Me.lblAsistencias.TabIndex = 182
        Me.lblAsistencias.Text = "ASISTENCIAS"
        Me.lblAsistencias.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'lblMatriculacion
        '
        Me.lblMatriculacion.AutoSize = True
        Me.lblMatriculacion.Font = New System.Drawing.Font("MS Reference Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMatriculacion.ForeColor = System.Drawing.Color.Gold
        Me.lblMatriculacion.Location = New System.Drawing.Point(453, 273)
        Me.lblMatriculacion.Name = "lblMatriculacion"
        Me.lblMatriculacion.Size = New System.Drawing.Size(106, 15)
        Me.lblMatriculacion.TabIndex = 183
        Me.lblMatriculacion.Text = "MATRICULACION"
        Me.lblMatriculacion.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Button1
        '
        Me.Button1.BackgroundImage = CType(resources.GetObject("Button1.BackgroundImage"), System.Drawing.Image)
        Me.Button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button1.Location = New System.Drawing.Point(103, 200)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 70)
        Me.Button1.TabIndex = 184
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("MS Reference Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Gold
        Me.Label1.Location = New System.Drawing.Point(107, 273)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(67, 15)
        Me.Label1.TabIndex = 185
        Me.Label1.Text = "INFORMES"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'frmMenuPrincipal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(628, 340)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.lblMatriculacion)
        Me.Controls.Add(Me.lblAsistencias)
        Me.Controls.Add(Me.lblCalificaciones)
        Me.Controls.Add(Me.lblProfesores)
        Me.Controls.Add(Me.lblAlumnos)
        Me.Controls.Add(Me.lblCursos)
        Me.Controls.Add(Me.lblAulas)
        Me.Controls.Add(Me.btnAsistencia)
        Me.Controls.Add(Me.btnCalificaciones)
        Me.Controls.Add(Me.btnMatriculacion)
        Me.Controls.Add(Me.btnCrudAulas)
        Me.Controls.Add(Me.btnCrudProfesores)
        Me.Controls.Add(Me.btnCrudCursos)
        Me.Controls.Add(Me.btnCrudAlumnos)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "frmMenuPrincipal"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "MENU PRINCIPAL"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnCrudAlumnos As System.Windows.Forms.Button
    Friend WithEvents btnCrudCursos As System.Windows.Forms.Button
    Friend WithEvents btnCrudProfesores As System.Windows.Forms.Button
    Friend WithEvents btnCrudAulas As System.Windows.Forms.Button
    Friend WithEvents btnMatriculacion As System.Windows.Forms.Button
    Friend WithEvents btnCalificaciones As System.Windows.Forms.Button
    Friend WithEvents btnAsistencia As System.Windows.Forms.Button
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents ALUMNOSToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AlumnosMantenimiento As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AlumnosConsulta As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AlumnosMatriculacion As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AlumnosAsistencia As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AlumnosCalificaciones As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PROFESORESToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ProfesoresMantenimiento As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ProfesoresConsulta As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ProfesoresAsignaciónACursos As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ProfesoresControlDeAsistencia As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ProfesoresControlDeCalificaciones As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AULASToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AulasMantenimiento As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CURSOSToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CursosMantenimiento As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CursosConsulta As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TABLASAUXILIARESToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CONSULTASToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents INFORMESToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TablasCodigosPostales As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TablasInformaciónDeLogin As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TablasTiposAulas As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TablasTiposDeCursos As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TablasTiposDeUsuarios As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ConsultasAlumnos As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ConsultasProfesores As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ConsultasCursos As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents InformesListadoDeAlumnos As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents InformesListadoDeProfesores As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents InformesListadoDeAulas As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents InformesListadoDeCursos As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents InformesInformeDeIndividualDeUnAlumno As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents InformesInformacionPorCurso As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents InformesInformeDeUnCurso As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents lblAulas As System.Windows.Forms.Label
    Friend WithEvents lblCursos As System.Windows.Forms.Label
    Friend WithEvents lblAlumnos As System.Windows.Forms.Label
    Friend WithEvents lblProfesores As System.Windows.Forms.Label
    Friend WithEvents lblCalificaciones As System.Windows.Forms.Label
    Friend WithEvents lblAsistencias As System.Windows.Forms.Label
    Friend WithEvents lblMatriculacion As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Label1 As Label
End Class
