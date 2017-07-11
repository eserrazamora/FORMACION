
CREATE PROCEDURE PROC_TIPOSAULAS_CargarTodosEnDataTable
   
AS 
    SELECT Codigo,Tipo 
    FROM TIPOSAULAS 
    ORDER BY Codigo
GO