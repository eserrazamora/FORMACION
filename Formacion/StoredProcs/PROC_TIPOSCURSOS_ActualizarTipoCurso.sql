CREATE PROCEDURE PROC_TIPOSCURSOS_ActualizarTipoCurso 
  	@Codigo varchar(4),
    @Tipo varchar(50)
AS 
    
    UPDATE TIPOSCURSOS SET 
    Tipo = @Tipo 
    WHERE Codigo = @Codigo

GO
