CREATE PROCEDURE PROC_TIPOSAULAS_Existe
   @Codigo varchar(4)
AS 
    SELECT Count(*) 
    FROM TIPOSAULAS 
    WHERE Codigo=@codigo
   
GO

