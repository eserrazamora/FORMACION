CREATE PROCEDURE PROC_TIPOSUSUARIOS_BorrarTipoUsuario
	@Codigo varchar(2), 
    @Tipo varchar(50)
AS
	DELETE FROM TIPOSUSUARIOS
	WHERE Codigo=@Codigo

GO
