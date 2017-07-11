CREATE PROCEDURE PROC_CALIFICACIONES_Alumnos
       @CodigoCurso CHAR(7)       
AS 
	SELECT (P.NIF+' - '+P.NOMBRE+' '+P.APELLIDOS) AS NOMBREALUMNO,
		  (P1.NIF+' - '+P1.NOMBRE+' '+P1.APELLIDOS) AS NOMBREPROFESOR,
		
		M.CodigoMatricula,C.Calificacion, C.Observaciones
		
	FROM MATRICULAS M
		LEFT JOIN CALIFICACIONES C ON M.CodigoMatricula=C.CodigoMatricula
		JOIN PERSONAS P ON P.NIF=M.NifAlumno
		LEFT JOIN PERSONAS P1 ON C.NifProfesor = P1.NIF
		
	WHERE M.CodigoCurso=@CodigoCurso
GO