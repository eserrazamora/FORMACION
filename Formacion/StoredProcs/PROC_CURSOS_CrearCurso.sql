CREATE PROCEDURE PROC_CURSOS_CrearCurso
	@CodigoCurso varchar(7),
	@Nombre varchar(50),
	@Tipo varchar(4),
	@Duracion int,
	@FechaInicio datetime,
	@FechaFin datetime,
	@Coste smallmoney,
	@Aula  varchar(4),
	@Observaciones text
AS
	INSERT INTO CURSOS(CodigoCurso,Nombre,Tipo,Duracion,FechaInicio,
					   FechaFin,Coste,Aula,Observaciones) 
	VALUES (@CodigoCurso,@Nombre,@Tipo,@Duracion,@FechaInicio, 
			@FechaFin,@Coste,@Aula,@Observaciones)

GO
