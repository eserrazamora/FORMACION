CREATE PROCEDURE PROC_AULAS_Existe
	@codigo varchar(4)
AS
	SELECT Count(*)
	FROM AULAS 
	WHERE Codigo=@Codigo
GO
