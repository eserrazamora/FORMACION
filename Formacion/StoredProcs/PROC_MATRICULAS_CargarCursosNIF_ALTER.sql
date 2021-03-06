USE [FORMACION]
GO
/****** Object:  StoredProcedure [dbo].[PROC_MATRICULAS_CargarCursosNif]    Script Date: 12/20/2010 01:08:36 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
ALTER PROCEDURE [dbo].[PROC_MATRICULAS_CargarCursosNif] 
     @NIF varchar(9)=NULL
AS 
    SELECT DISTINCT CURSOS.CodigoCurso,CURSOS.NOMBRE,
					CURSOS.FechaInicio,CURSOS.FechaFin,
					(CURSOS.CodigoCurso+' - '
					 +CURSOS.NOMBRE+' - '
					 +CONVERT(nvarchar,CURSOS.FechaInicio,103)+' - '
					 +CONVERT(nvarchar,CURSOS.FechaFin,103)
					) AS INFOCURSO,
					MATRICULAS.CodigoMatricula,MATRICULAS.Pagado,
					(PERSONAS.Nombre+' '+PERSONAS.Apellidos) As INFO,
					PERSONAS.TelefonoFijo,PERSONAS.TelefonoMovil,
					PERSONAS.Email					
				
   FROM PERSONAS,MATRICULAS,CURSOS
   WHERE (PERSONAS.NIF=MATRICULAS.NifAlumno)
	AND	 (MATRICULAS.CodigoCurso=CURSOS.CodigoCurso)
	AND	 ((@NIF IS NULL) OR (PERSONAS.NIF=@NIF))
	AND  PERSONAS.ROL='ALM'
  ORDER BY CURSOS.CodigoCurso
