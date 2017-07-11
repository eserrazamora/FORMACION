
CREATE PROCEDURE PROC_TIPOSAULAS_CargarUnTipoAula
   @Codigo varchar(4)
AS 
    SELECT Codigo,Tipo 
    FROM TIPOSAULAS 
    ORDER BY Codigo
   
GO
