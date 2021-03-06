USE [FORMACION]
GO
/****** Object:  StoredProcedure [dbo].[PROC_MATRICULAS_ComprobarDependencias]    Script Date: 01/02/2011 21:40:00 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
ALTER PROCEDURE [dbo].[PROC_MATRICULAS_ComprobarDependencias]
	@indicador int OUTPUT,
	@CodigoMatricula varchar(13)

AS
	SET @indicador=0;

	If Exists
		(
			Select *
			From CALIFICACIONES C 
			Where C.CodigoMatricula = @CodigoMatricula
		) 

	Begin
   	    Set @indicador = 1;
	End
	
	If Exists
		(
			Select *
			From ASISTENCIAS A
			Where A.CodigoMatricula = @CodigoMatricula
		) 

	Begin
   	    Set @indicador = 1;
	End
	
	SELECT @indicador
GO