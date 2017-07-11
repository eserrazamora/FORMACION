USE [FORMACION]
GO
/****** Object:  StoredProcedure [dbo].[PROC_TIPOSAULAS_CargarUnTipoAula]    Script Date: 01/12/2011 12:44:14 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

ALTER PROCEDURE [dbo].[PROC_TIPOSAULAS_CargarUnTipoAula]
   @Codigo varchar(4)
AS 
    SELECT Codigo,Tipo 
    FROM TIPOSAULAS 
    WHERE Codigo=@Codigo
    ORDER BY Codigo
   
