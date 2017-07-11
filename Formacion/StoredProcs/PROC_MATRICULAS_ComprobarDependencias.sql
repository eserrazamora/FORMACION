CREATE PROCEDURE PROC_MATRICULAS_ComprobarDependencias
	@CodigoCurso varchar(7)
AS
	SELECT COUNT(*)
	FROM MATRICULAS M
	LEFT JOIN CALIFICACIONES C ON M.CodigoMatricula=C.CodigoMatricula
	WHERE M.CodigoCurso=@CodigoCurso

	UNION

	SELECT COUNT(*)
	FROM MATRICULAS M
	LEFT JOIN ASISTENCIAS A ON M.CodigoCurso = A.CodigoMatricula
	WHERE M.CodigoCurso=@CodigoCurso
GO
