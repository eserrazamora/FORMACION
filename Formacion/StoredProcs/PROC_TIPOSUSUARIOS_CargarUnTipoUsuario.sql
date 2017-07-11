CREATE PROCEDURE PROC_TIPOSUSUARIOS_CargarUnTipoUsuario
	@Codigo varchar(2)
AS 
   
	SELECT Codigo,Tipo 
	FROM TIPOSUSUARIOS 
	WHERE Codigo=@codigo
	ORDER BY Codigo
	
GO

