CREATE PROCEDURE PROC_CURSOS_CargarCursosSinAulaEnDatatable
	
AS
	SELECT CodigoCurso, Nombre,
           FechaInicio,FechaFin,Duracion,
           (Codigocurso + ' - ' + Nombre + ' - Inicio: ' 
            + convert(char(10), FechaInicio , 103)+ ' - Fin: ' 
            + convert(char(10), FechaFin , 103)+ ' - ' 
            + convert(varchar(MAX),Duracion) + ' horas.'
            )   AS INFO
    FROM CURSOS
    WHERE Aula IS NULL
    ORDER BY CodigoCurso
GO
