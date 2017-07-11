-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE PROC_AULAS_ComprobarDependencias
	@indicador int OUTPUT,
	@CodigoAula varchar(4)
AS
	SET @indicador=0;

	If Exists
		(
			Select *
			From CURSOS
			Where Aula=@CodigoAula
		) 

	Begin
   	    Set @indicador = 1;
	End

	SELECT @indicador
GO

