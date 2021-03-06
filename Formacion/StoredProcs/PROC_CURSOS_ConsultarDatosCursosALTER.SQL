USE [FORMACION]
GO
/****** Object:  StoredProcedure [dbo].[PROC_CURSOS_ConsultarDatosCursos]    Script Date: 01/11/2011 19:32:23 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
	ALTER PROCEDURE [dbo].[PROC_CURSOS_ConsultarDatosCursos]
	   @CodigoCurso varchar(7)= NULL,
	   @NombreCurso varchar(50)= NULL,
	   @FechaInicio Date= NULL,
	   @FechaFin Date= NULL,
	   @Duracion int= NULL
	AS 
		
		SELECT DISTINCT C.CodigoCurso,C.Nombre,C.FechaInicio,
			   C.FechaFin,C.Duracion
		
		FROM CURSOS C 
		
		WHERE
			C.CodigoCurso LIKE '%'+coalesce(@CodigoCurso,'') + '%'
			AND C.Nombre LIKE '%'+coalesce(@NombreCurso,'') + '%'
			AND C.FechaInicio = coalesce(@FechaInicio,C.FechaInicio)
			AND C.FechaFin = coalesce(@FechaFin,C.FechaFin)
			AND C.Duracion = coalesce(@Duracion,C.Duracion)
OPTION (RECOMPILE);
