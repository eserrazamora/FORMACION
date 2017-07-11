
CREATE PROCEDURE PROC_PERSONAS_CargarTodosAlumnosCurso
       @CodigoCurso CHAR(7) = NULL
AS 
   SELECT (PERSONAS.Nif+' - '+ PERSONAS.Nombre+' '+PERSONAS.Apellidos) AS INFO,
	   PERSONAS.Nif, PERSONAS.Nombre,PERSONAS.Apellidos, PERSONAS.Sexo, PERSONAS.FechaNacimiento,
	   PERSONAS.Direccion, PERSONAS.CodigoPostal, PERSONAS.Email, PERSONAS.TelefonoFijo,
	   PERSONAS.TelefonoMovil, PERSONAS.ROL, PERSONAS.FechaAlta, PERSONAS.FechaBaja,
	   PERSONAS.Observaciones,CURSOS.CodigoCurso,MATRICULAS.CodigoMatricula
   FROM PERSONAS,MATRICULAS,CURSOS
   WHERE (PERSONAS.NIF=MATRICULAS.NifAlumno)
	AND	 (MATRICULAS.CodigoCurso=CURSOS.CodigoCurso)
	AND	 PERSONAS.ROL='ALM'
	AND ((@CodigoCurso IS NULL) OR (MATRICULAS.CodigoCurso=@CodigoCurso))
GO