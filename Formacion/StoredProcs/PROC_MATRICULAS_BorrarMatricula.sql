CREATE PROCEDURE PROC_MATRICULAS_BorrarMatricula
	@Codigo varchar(10)
AS
	DELETE FROM MATRICULAS
	WHERE CodigoMatricula=@Codigo
GO
