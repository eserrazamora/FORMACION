USE [FORMACION]
GO
/****** Object:  StoredProcedure [dbo].[PROC_TIPOSCURSOS_ComprobarDependencias]    Script Date: 01/07/2011 23:44:55 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
ALTER PROCEDURE [dbo].[PROC_TIPOSCURSOS_ComprobarDependencias]
   @indicador int OUTPUT,
   @Codigo varchar(4)
AS
	SET @indicador=0;
	
	If Exists
		(
			Select *
			From CURSOS C
			Where C.Tipo = @Codigo
		) 

	Begin
   	    Set @indicador = 1;
	End
		
	SELECT @indicador