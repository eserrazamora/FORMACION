USE [FORMACION]
GO
/****** Object:  StoredProcedure [dbo].[PROC_MATRICULAS_BorrarMatricula]    Script Date: 12/28/2010 15:24:52 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
ALTER PROCEDURE [dbo].[PROC_MATRICULAS_BorrarMatricula]
	@Codigo varchar(13)
AS
	DELETE FROM MATRICULAS
	WHERE CodigoMatricula=@Codigo
