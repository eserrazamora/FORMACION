USE [FORMACION]
GO
/****** Object:  StoredProcedure [dbo].[PROC_MATRICULAS_CrearMatricula]    Script Date: 12/20/2010 18:17:13 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
ALTER PROCEDURE [dbo].[PROC_MATRICULAS_CrearMatricula]
	@CodigoMatricula varchar(13),
	@NifAlumno varchar(9),
	@CodigoCurso varchar(7),
	@Pagado varchar(1)
AS 
	INSERT INTO MATRICULAS(CodigoMatricula,NifAlumno,CodigoCurso,Pagado)
	VALUES(@CodigoMatricula,@NifAlumno,@CodigoCurso,@Pagado)
