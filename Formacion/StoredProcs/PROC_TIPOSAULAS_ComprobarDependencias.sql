CREATE PROCEDURE PROC_TIPOSAULAS_ComprobarDependencias
	@Codigo varchar(4)
AS
	SELECT COUNT(*)
	FROM AULAS
	WHERE Tipo=@Codigo
GO
