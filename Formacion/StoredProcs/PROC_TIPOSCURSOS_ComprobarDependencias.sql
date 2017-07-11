CREATE PROCEDURE PROC_TIPOSCURSOS_ComprobarDependencias
   @Codigo varchar(4)
AS
	SELECT COUNT(*)
	FROM CURSOS
	WHERE Tipo=@Codigo
GO
