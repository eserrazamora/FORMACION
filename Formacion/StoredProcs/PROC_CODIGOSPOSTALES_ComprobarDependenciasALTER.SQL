USE [FORMACION]
GO
/****** Object:  StoredProcedure [dbo].[PROC_CODIGOSPOSTALES_ComprobarDependencias]    Script Date: 01/02/2011 21:51:00 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
ALTER PROCEDURE [dbo].[PROC_CODIGOSPOSTALES_ComprobarDependencias]
	@indicador int OUTPUT,
	@CodigoPostal varchar(5)
AS
	SET @indicador=0;

	If Exists
		(
			Select *
			From PERSONAS
			Where CodigoPostal=@CodigoPostal
		) 

	Begin
   	    Set @indicador = 1;
	End

	SELECT @indicador
