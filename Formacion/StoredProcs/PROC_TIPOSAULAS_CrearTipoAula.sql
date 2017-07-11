
CREATE PROCEDURE PROC_TIPOSAULAS_CrearTipoAula
   @Codigo varchar(4),
   @Tipo varchar(30)
AS 
   INSERT INTO TIPOSAULAS(Codigo,Tipo) 
   VALUES (@Codigo,@Tipo) 

   
GO

