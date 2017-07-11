USE [FORMACION]
GO
/****** Object:  StoredProcedure [dbo].[PROC_ASISTENCIAS_Existe]    Script Date: 12/20/2010 18:21:15 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
ALTER PROCEDURE [dbo].[PROC_ASISTENCIAS_Existe] 
    @CodigoMatricula varchar(13),
    @Fecha Date
  
AS 

	SELECT COUNT(*)
	FROM ASISTENCIAS
	WHERE CodigoMatricula=@CodigoMatricula
	AND	 Fecha=@Fecha
	
