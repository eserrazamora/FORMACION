CREATE PROCEDURE PROC_AULAS_CrearAula
	@Codigo varchar(4),
	@Nombre varchar(40),
	@Tipo varchar(4),
	@Observaciones text
AS
	INSERT INTO AULAS(Codigo,Nombre,Tipo,Observaciones)
	VALUES (@Codigo,@Nombre,@Tipo,@Observaciones)
GO
