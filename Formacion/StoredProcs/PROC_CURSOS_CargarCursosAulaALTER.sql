USE [FORMACION]
GO
/****** Object:  StoredProcedure [dbo].[PROC_CURSOS_CargarCursosAula]    Script Date: 01/02/2011 21:07:02 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
ALTER PROCEDURE [dbo].[PROC_CURSOS_CargarCursosAula]
	@aula varchar(4)
AS
	SELECT C.CodigoCurso,C.Nombre,
           C.Tipo,TC.Tipo AS TipoNombre,
           C.Duracion,C.FechaInicio,
           C.FechaFin,C.Coste,
           C.Aula,TA.Tipo AS AulaNombre,
           C.Observaciones
    
    FROM CURSOS C
		LEFT JOIN TIPOSCURSOS TC ON C.Tipo=TC.Codigo 
		LEFT JOIN TIPOSAULAS TA ON C.Aula=TA.Codigo
	WHERE C.Aula=@aula     
    ORDER BY CodigoCurso
