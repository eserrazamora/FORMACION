
CREATE PROCEDURE PROC_TIPOSAULAS_ActualizarTipoAula
   @Codigo varchar(4),
   @Tipo varchar(30)
AS 
	UPDATE TIPOSAULAS 
	SET  Tipo= @tipo 
	WHERE Codigo = @Codigo
   
GO
