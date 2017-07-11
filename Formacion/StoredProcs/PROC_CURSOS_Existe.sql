CREATE PROCEDURE PROC_CURSOS_Existe
	@codigo varchar(7)
AS
	SELECT Count(*)
	FROM CURSOS 
	WHERE CodigoCurso=@Codigo
