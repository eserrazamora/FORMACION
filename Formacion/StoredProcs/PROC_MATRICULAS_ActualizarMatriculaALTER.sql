USE [FORMACION]
GO
/****** Object:  StoredProcedure [dbo].[PROC_MATRICULAS_ActualizarMatricula]    Script Date: 12/20/2010 18:18:23 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
ALTER PROCEDURE [dbo].[PROC_MATRICULAS_ActualizarMatricula]
	@CodigoMatricula varchar(13),
	@NifAlumno varchar(9),
	@CodigoCurso varchar(7),
	@Pagado varchar(1)
AS 
	UPDATE MATRICULAS
	
	SET NifAlumno=@NifAlumno,
		CodigoCurso=@CodigoCurso,
		Pagado=@Pagado
	
	WHERE CodigoMatricula=@CodigoMatricula
	 
