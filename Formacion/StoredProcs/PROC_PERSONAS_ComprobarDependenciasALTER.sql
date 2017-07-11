USE [FORMACION]
GO
/****** Object:  StoredProcedure [dbo].[PROC_PERSONAS_ComprobarDependencias]    Script Date: 01/10/2011 11:52:24 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
ALTER PROCEDURE [dbo].[PROC_PERSONAS_ComprobarDependencias]
	@indicador int OUTPUT,
	@NIF varchar(9)

AS
	SET @indicador=0;

	
	If Exists
		(
			Select *
			From PROFESORESCURSOS PC
			Where PC.NifProfesor = @NIF
		) 

	Begin
   	    Set @indicador = 1;
	End
	
		If Exists
		(
			Select *
			From MATRICULAS M
			Where M.NifAlumno= @NIF
		) 

	Begin
   	    Set @indicador = 1;
	End
			
	SELECT @indicador
