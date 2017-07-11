CREATE PROCEDURE PROC_CURSOS_ActualizarCurso
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
	UPDATE CURSOS SET 
		 CodigoCurso=@CodigoCurso,
		 Nombre=@Nombre,
		 Tipo=@Tipo,
		 Duracion=@Duracion,
		 FechaInicio=@FechaInicio,
		 FechaFin=@FechaFin,
		 Coste=@Coste,
		 Aula=@Aula,
		 Observaciones=@Observaciones
	WHERE CodigoCurso = @CodigoCurso
GO
