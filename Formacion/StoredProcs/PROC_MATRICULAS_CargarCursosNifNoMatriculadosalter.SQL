USE [FORMACION]
GO
/****** Object:  StoredProcedure [dbo].[PROC_MATRICULAS_CargarCursosNifNoMatriculados]    Script Date: 12/16/2010 00:23:22 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
ALTER PROCEDURE [dbo].[PROC_MATRICULAS_CargarCursosNifNoMatriculados] 
	@NIF varchar(9)
AS 
	SELECT CURSOS.CodigoCurso,CURSOS.NOMBRE,
		   CURSOS.FechaInicio,CURSOS.FechaFin,
		   CURSOS.Coste,
		   (CURSOS.CodigoCurso+' - '
		    +CURSOS.NOMBRE+' - '
	  	    +CONVERT(nvarchar,CURSOS.FechaInicio,103)+' - '
			+CONVERT(nvarchar,CURSOS.FechaFin,103) + ' - '
			+CONVERT(nvarchar,CURSOS.Coste) + '€.'
		   ) AS INFOCURSO
	FROM CURSOS	
	WHERE CURSOS.CodigoCurso 
		NOT IN  
				( SELECT MATRICULAS.CodigoCurso
				  FROM MATRICULAS
				  WHERE MATRICULAS.NifAlumno=@NIF
				 ) 

