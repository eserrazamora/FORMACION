CREATE PROCEDURE PROC_AULAS_CargarUnAula
	@codigo varchar(4)
AS
	SELECT AULAS.Codigo,
		   AULAS.Nombre,AULAS.Tipo,
		   TIPOSAULAS.Tipo AS TipoAula,
		   AULAS.Observaciones
	FROM AULAS
	LEFT JOIN TIPOSAULAS ON AULAS.Tipo=TIPOSAULAS.Codigo
	WHERE TIPOSAULAS.Codigo = @codigo
	ORDER BY AULAS.Codigo
GO

	