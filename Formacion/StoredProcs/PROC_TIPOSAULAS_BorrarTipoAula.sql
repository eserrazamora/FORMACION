CREATE PROCEDURE PROC_TIPOSAULAS_BorrarTipoAula
	@Codigo varchar(4)
AS
	DELETE FROM TIPOSAULAS
	WHERE Codigo=@Codigo
GO
