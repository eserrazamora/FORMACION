CREATE PROCEDURE PROC_CURSOS_CargarUnCurso
	@codigo varchar(7)
AS

	SELECT C.CodigoCurso,C.Nombre,
           C.Tipo,TC.Tipo AS TipoNombre,
           C.Duracion,C.FechaInicio,
           C.FechaFin,C.Coste,
           C.Aula,TA.Tipo AS AulaNombre,
           C.Observaciones
        
    FROM CURSOS C
		 JOIN TIPOSCURSOS TC ON C.Tipo=TC.Codigo 
		 JOIN TIPOSAULAS TA ON C.Aula=TA.Codigo
		 AND C.CodigoCurso=@codigo     
    ORDER BY CodigoCurso
GO