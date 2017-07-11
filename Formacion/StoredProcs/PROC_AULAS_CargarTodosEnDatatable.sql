
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE PROC_AULAS_CargarTodosEnDatatable
AS
	SELECT Codigo + ' - ' + Nombre AS CodigoyNombre,
		   Codigo,Nombre,Tipo 
	FROM AULAS ORDER BY Codigo
GO