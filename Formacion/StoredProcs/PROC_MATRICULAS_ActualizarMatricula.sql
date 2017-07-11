CREATE PROCEDURE PROC_MATRICULAS_ActualizarMatricula
	@CodigoMatricula varchar(10),
	@NifAlumno varchar(9),
	@CodigoCurso varchar(7),
	@Pagado varchar(1)
AS 
	UPDATE MATRICULAS
	
	SET NifAlumno=@NifAlumno,
		CodigoCurso=@CodigoCurso,
		Pagado=@Pagado
	
	WHERE CodigoMatricula=@CodigoMatricula
	 
GO