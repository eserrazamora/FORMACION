CREATE PROCEDURE PROC_MATRICULAS_ObtenerNumeroCursosMatriculadosNIF
	@NIF varchar(9)
AS 
	SELECT COUNT(*)
	FROM MATRICULAS
	WHERE NifAlumno=@NIF
GO