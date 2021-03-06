USE [FORMACION]
GO
/****** Object:  StoredProcedure [dbo].[PROC_CURSOS_InformeDatosUnCurso]    Script Date: 12/20/2010 00:52:21 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
ALTER PROCEDURE [dbo].[PROC_CURSOS_InformeDatosUnCurso]
	   @CodigoCurso varchar(7) 
AS 
	SELECT  C.CodigoCurso,C.Nombre,C.Tipo AS CodigoTipo,
			TP.Tipo AS NombreTipo,C.Duracion,
			C.FechaInicio,C.FechaFin,C.Coste,
			C.Aula AS CodigoAula,A.Nombre AS NombreAula,
			C.Observaciones
	FROM CURSOS C
		 JOIN TIPOSCURSOS TP ON  C.Tipo=TP.Codigo
		 JOIN AULAS A ON C.Aula=A.Codigo
	WHERE C.CodigoCurso = @CodigoCurso

