CREATE PROCEDURE PROC_MATRICULAS_CargarCursos 

AS 
   SELECT DISTINCT CURSOS.CodigoCurso,CURSOS.NOMBRE,
				   CURSOS.FechaInicio,CURSOS.FechaFin,
				   (CURSOS.CodigoCurso+' - '
					 +CURSOS.NOMBRE+' - '
					 +CONVERT(nvarchar,CURSOS.FechaInicio,103)+' - '
					 +CONVERT(nvarchar,CURSOS.FechaFin,103)
				   ) AS INFOCURSO
		   
   FROM CURSOS
   	
GO