USE [FORMACION]
GO
/****** Object:  StoredProcedure [dbo].[PROC_PERSONAS_Existe]    Script Date: 12/09/2010 01:51:24 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

ALTER PROCEDURE [dbo].[PROC_PERSONAS_Existe]
   
    @NIF varchar(9)
 
AS 
    
   SELECT COUNT(*)
   FROM PERSONAS
   WHERE Nif=@NIF
