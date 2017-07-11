CREATE PROCEDURE PROC_TIPOSCURSOS_CargarTodosEnDataTable 
  
AS 
    
  SELECT Codigo + ' - '+ Tipo AS CodigoyTipo,
		 Codigo, Tipo 
  FROM TIPOSCURSOS ORDER BY Codigo

GO
