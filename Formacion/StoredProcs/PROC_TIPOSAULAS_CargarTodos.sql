CREATE PROCEDURE PROC_TIPOSAULAS_CargarTodos 
   
AS 
    SELECT Codigo,Tipo 
    FROM TIPOSAULAS 
    ORDER BY Codigo
   
GO

