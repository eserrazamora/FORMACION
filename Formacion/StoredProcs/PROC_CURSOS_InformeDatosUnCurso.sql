CREATE PROCEDURE PROC_CURSOS_InformeDatosUnCurso
	   @CodigoCurso varchar(7)
	   
AS 
		
	SELECT  C.CodigoCurso,C.Nombre,C.Tipo,TP.Tipo,
			C.Duracion,C.FechaInicio,C.FechaFin,
			C.Coste,C.Aula, C.Observaciones,
			(P.Nombre+' '+P.Apellidos) AS NombreCompleto,
			P.NIF
	FROM CURSOS C
		JOIN PROFESORESCURSOS PC ON (C.CodigoCurso=PC.CodigoCurso) 
		JOIN PERSONAS P ON PC.NifProfesor = P.NIF
		JOIN TIPOSCURSOS TP ON  C.Tipo=TP.Codigo
	WHERE C.CodigoCurso = @CodigoCurso

GO