
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE PROC_PERSONAS_ComprobarDependencias
	@indicador int OUTPUT,
	@NIF varchar(13)

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
