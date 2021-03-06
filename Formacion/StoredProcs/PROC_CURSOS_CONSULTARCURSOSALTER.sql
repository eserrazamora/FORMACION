USE [FORMACION]
GO
/****** Object:  StoredProcedure [dbo].[PROC_CURSOS_ConsultarDatosCursos]    Script Date: 12/17/2010 18:18:39 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
	ALTER PROCEDURE [dbo].[PROC_CURSOS_ConsultarDatosCursos]
	   @CodigoCurso varchar(7)= NULL,
	   @NifProfesor varchar(9)= NULL,
	   @NombreCurso varchar(50)= NULL,
	   @FechaInicio Date= NULL,
	   @FechaFin Date= NULL,
	   @Duracion int= NULL
	AS 
		
		SELECT C.CodigoCurso,C.Nombre,C.FechaInicio,
			   C.FechaFin,C.Duracion,PC.NifProfesor
		
		FROM CURSOS C 
			LEFT JOIN PROFESORESCURSOS PC  ON C.CodigoCurso = PC.CodigoCurso
			AND PC.NifProfesor LIKE '%'+coalesce(@NifProfesor,'') + '%'
		WHERE
			C.CodigoCurso LIKE '%'+coalesce(@CodigoCurso,'') + '%'
			AND C.Nombre LIKE '%'+coalesce(@NombreCurso,'') + '%'
			AND C.FechaInicio = coalesce(@FechaInicio,C.FechaInicio)
			AND C.FechaFin = coalesce(@FechaFin,C.FechaFin)
			AND C.Duracion = coalesce(@Duracion,C.Duracion)
OPTION (RECOMPILE);
