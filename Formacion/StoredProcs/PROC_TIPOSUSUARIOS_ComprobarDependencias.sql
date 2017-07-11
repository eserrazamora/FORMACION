CREATE PROCEDURE PROC_TIPOSUSUARIOS_ComprobarDependencias
   @Codigo varchar(2)
AS
	SELECT COUNT(*)
	FROM LOGIN
	WHERE TipoUsuario=@Codigo
GO

