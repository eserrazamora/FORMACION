USE [FORMACION]
GO
/****** Object:  StoredProcedure [dbo].[PROC_MATRICULAS_Existe]    Script Date: 12/20/2010 18:22:03 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
ALTER PROCEDURE [dbo].[PROC_MATRICULAS_Existe]
    @CodigoMatricula varchar(13)  
AS 
	SELECT COUNT(*)
	FROM MATRICULAS
	WHERE CodigoMatricula=@CodigoMatricula
