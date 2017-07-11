ALTER PROCEDURE [dbo].[PROC_CURSOS_ConsultarDatosCursos]
   @CodigoCurso varchar(7)= NULL,
   @NifProfesor varchar(9)= NULL,
   @NombreCurso varchar(50)= NULL,
   @FechaInicio Date= NULL,
   @FechaFin Date= NULL,
   @Duracion int= NULL
AS 
    SELECT C.CodigoCurso,C.Nombre,
		   C.FechaInicio,C.FechaFin,
		   C.Duracion,PC.NifProfesor
	FROM CURSOS C
	JOIN PROFESORESCURSOS PC ON c.CodigoCurso = pc.CodigoCurso
	WHERE C.CodigoCurso LIKE '%'+coalesce(@CodigoCurso,'') + '%'
	AND   PC.NifProfesor LIKE '%'+coalesce(@NifProfesor,'') + '%'
	AND   C.Nombre LIKE '%'+coalesce(@NombreCurso,'') + '%'
	AND   C.FechaInicio = coalesce(@FechaInicio,C.FechaInicio)
	AND   C.FechaFin = coalesce(@FechaFin,C.FechaInicio)
	AND   C.Duracion = coalesce(@Duracion,C.Duracion)
OPTION (RECOMPILE)