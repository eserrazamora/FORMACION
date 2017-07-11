CREATE PROCEDURE PROC_CURSOS_ConsultarDatosCursos
   @CodigoCurso varchar(7)= NULL,
   @NifProfesor varchar(9)= NULL,
   @NombreCurso varchar(50)= NULL,
   @FechaInicio Date= NULL,
   @FechaFin Date= NULL,
   @Duracion int= NULL
AS 
    SELECT CURSOS.CodigoCurso,CURSOS.Nombre,
		   CURSOS.FechaInicio,CURSOS.FechaFin,
		   CURSOS.Duracion
	FROM CURSOS,PROFESORESCURSOS
	WHERE ((@CodigoCurso IS NULL) OR (CURSOS.CodigoCurso LIKE '%'+@CodigoCurso+'%'))
	AND	 ((@NifProfesor IS NULL) OR (PROFESORESCURSOS.NifProfesor LIKE '%'+@NifProfesor+'%'))
	AND	 ((@NifProfesor IS NULL) OR (PROFESORESCURSOS.CodigoCurso=cursos.CodigoCurso))
	AND	 ((@NombreCurso IS NULL) OR (CURSOS.Nombre LIKE '%'+@NombreCurso+'%'))
	AND	 ((@FechaInicio IS NULL) OR (CURSOS.FechaInicio=@FechaInicio))
	AND	 ((@FechaFin IS NULL) OR (CURSOS.FechaFin=@FechaFin))
	AND	 ((@Duracion IS NULL) OR (CURSOS.Duracion LIKE '%'+@Duracion+'%'))
   
GO