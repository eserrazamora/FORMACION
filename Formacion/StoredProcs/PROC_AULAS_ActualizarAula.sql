CREATE PROCEDURE PROC_AULAS_ActualizarAula
	@Codigo varchar(4),
	@Nombre varchar(40),
	@Tipo varchar(4),
	@Observaciones text
AS
	UPDATE AULAS SET 
		Nombre = @Nombre,
		Tipo = @Tipo, 
		Observaciones = @Observaciones
	WHERE Codigo = @Codigo