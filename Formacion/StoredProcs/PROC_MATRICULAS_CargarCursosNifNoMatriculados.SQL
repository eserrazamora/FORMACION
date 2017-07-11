CREATE PROCEDURE PROC_MATRICULAS_CargarCursosNifNoMatriculados
	@NIF varchar(9)
AS
BEGIN
SELECT CURSOS.CodigoCurso,CURSOS.NOMBRE,
		   CURSOS.FechaInicio,CURSOS.FechaFin,
		   CURSOS.Coste,
		   (CURSOS.CodigoCurso+' - '
		    +CURSOS.NOMBRE+' - '
	  	    +CONVERT(nvarchar,CURSOS.FechaInicio,103)+' - '
			+CONVERT(nvarchar,CURSOS.FechaFin,103)
		   ) AS INFOCURSO
	FROM CURSOS	
	WHERE CURSOS.CodigoCurso 
		NOT IN  
				( SELECT MATRICULAS.CodigoCurso
				  FROM MATRICULAS
				  WHERE MATRICULAS.NifAlumno=@NIF
				 ) 
GO