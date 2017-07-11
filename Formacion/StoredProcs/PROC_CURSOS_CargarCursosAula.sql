CREATE PROCEDURE PROC_CURSOS_CargarCursosAula
	@aula varchar(4)
AS

		SELECT C.CodigoCurso,C.Nombre,
               C.Tipo,TC.Tipo AS TipoNombre,
               C.Duracion,C.FechaInicio,
               C.FechaFin,C.Coste,
               C.Aula,TA.Tipo AS AulaNombre,
               C.Observaciones
        
        FROM CURSOS C
			LEFT JOIN TIPOSCURSOS TC ON C.Tipo=TC.Codigo 
			LEFT JOIN TIPOSAULAS TA ON C.Aula=TA.Codigo
			AND C.Aula=@aula     
        ORDER BY CodigoCurso
GO

                        