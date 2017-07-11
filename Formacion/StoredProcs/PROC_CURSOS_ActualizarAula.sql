CREATE PROCEDURE PROC_CURSOS_ActualizarAula
	@CodigoCurso varchar(7),
	@Aula  varchar(4)
AS
	UPDATE CURSOS SET 
		 Aula=@Aula
	WHERE CodigoCurso = @CodigoCurso
GO