CREATE PROCEDURE PROC_TIPOSUSUARIOS_Existe
	@Codigo varchar(2)
AS 
   
	SELECT Count(*) 
	FROM TIPOSUSUARIOS
	WHERE Codigo=@codigo
GO

