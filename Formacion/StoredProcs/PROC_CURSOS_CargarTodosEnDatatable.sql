CREATE PROCEDURE PROC_CURSOS_CargarTodosEnDatatable
	
AS
		SELECT CodigoCurso, Nombre,
               FechaInicio,FechaFin,Duracion,
               (Codigocurso + ' - ' + Nombre + ' ' + FechaInicio + ' ' + FechaFin+ ' ' + Duracion + ' horas.')   AS INFO
               FROM CURSOS
               ORDER BY CodigoCurso
GO
