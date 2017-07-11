USE [FORMACION]
GO
/****** Object:  StoredProcedure [dbo].[PROC_TIPOSUSUARIOS_ComprobarDependencias]    Script Date: 01/08/2011 00:44:37 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
ALTER PROCEDURE [dbo].[PROC_TIPOSUSUARIOS_ComprobarDependencias]
   @indicador int OUTPUT,
   @Codigo varchar(2)
AS

	SET @indicador=0;
	
	If Exists
		(
			Select *
			From LOGIN L
			Where L.TipoUsuario = @Codigo
		) 

	Begin
   	    Set @indicador = 1;
	End
		
	SELECT @indicador