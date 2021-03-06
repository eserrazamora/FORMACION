USE [FORMACION]
GO
/****** Object:  StoredProcedure [dbo].[PROC_AULAS_CargarUnAula]    Script Date: 01/02/2011 10:57:53 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
ALTER PROCEDURE [dbo].[PROC_AULAS_CargarUnAula]
	@Codigo varchar(4)
AS
	SELECT AULAS.Codigo,
		   AULAS.Nombre,AULAS.Tipo,
		   TIPOSAULAS.Tipo AS TipoAula,
		   AULAS.Observaciones
	FROM AULAS
	LEFT JOIN TIPOSAULAS ON AULAS.Tipo=TIPOSAULAS.Codigo
	WHERE TIPOSAULAS.Codigo = @Codigo
	ORDER BY AULAS.Codigo
