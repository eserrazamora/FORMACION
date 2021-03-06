USE [FORMACION]
GO
/****** Object:  StoredProcedure [dbo].[PROC_PERSONAS_CargarTodasPersonasCurso]    Script Date: 12/13/2010 10:37:00 ******/
/*Este Procedimiento almacenado carga personas y profesores relacionadas con el curso*/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
ALTER PROCEDURE [dbo].[PROC_PERSONAS_CargarTodasPersonasCurso]
       @CodigoCurso CHAR(7) = NULL 
       
   AS 
  (
   SELECT (PERSONAS.Nif+' - '+ PERSONAS.Nombre+' '+PERSONAS.Apellidos) AS INFO,
	   PERSONAS.Nif, PERSONAS.Nombre,PERSONAS.Apellidos, PERSONAS.Sexo, PERSONAS.FechaNacimiento,
	   PERSONAS.Direccion, PERSONAS.CodigoPostal, PERSONAS.Email, PERSONAS.TelefonoFijo,
	   PERSONAS.TelefonoMovil, PERSONAS.ROL, PERSONAS.FechaAlta, PERSONAS.FechaBaja,
	   PERSONAS.Observaciones,CURSOS.CodigoCurso
   FROM PERSONAS,MATRICULAS,CURSOS
   WHERE (PERSONAS.NIF=MATRICULAS.NifAlumno)
	AND	 (MATRICULAS.CodigoCurso=CURSOS.CodigoCurso)
	AND	 PERSONAS.ROL='ALM'
	AND ((@CodigoCurso IS NULL) OR (MATRICULAS.CodigoCurso=@CodigoCurso))
	
)
   UNION ALL
(
   SELECT (PERSONAS.Nif+' - '+ PERSONAS.Nombre+' '+PERSONAS.Apellidos) AS INFO,
		  PERSONAS.Nif, PERSONAS.Nombre,PERSONAS.Apellidos, PERSONAS.Sexo, PERSONAS.FechaNacimiento,
	      PERSONAS.Direccion, PERSONAS.CodigoPostal, PERSONAS.Email, PERSONAS.TelefonoFijo,
	      PERSONAS.TelefonoMovil, PERSONAS.ROL, PERSONAS.FechaAlta, PERSONAS.FechaBaja,
	      PERSONAS.Observaciones,CURSOS.CodigoCurso
	   
   FROM PERSONAS,PROFESORESCURSOS,CURSOS
   WHERE (PERSONAS.NIF=PROFESORESCURSOS.NifProfesor)
	AND  (PROFESORESCURSOS.CodigoCurso=CURSOS.CodigoCurso)
	AND	 PERSONAS.ROL='PRF'
	AND ((@CodigoCurso IS NULL) OR (PROFESORESCURSOS.CodigoCurso=@CodigoCurso))	
	
)

ORDER BY PERSONAS.NIF