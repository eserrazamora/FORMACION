CREATE PROCEDURE PROC_LOGIN_CargarCursosUsuario
	@Usuario varchar(50)
AS
	SELECT	P.NIF,
			(P.Nombre + ' ' + P.Apellidos) AS INFO,
			L.Usuario,C.CodigoCurso,C.Nombre,
			C.FechaInicio,C.FechaFin,C.Duracion,
			A.Codigo,A.Nombre
			
	FROM LOGIN L
	LEFT JOIN PERSONAS P ON P.NIF=L.NIF
	LEFT JOIN PROFESORESCURSOS PC ON P.NIF=PC.NifProfesor
	LEFT JOIN CURSOS C ON C.CodigoCurso=PC.CodigoCurso
	LEFT JOIN TIPOSUSUARIOS T ON T.Codigo=L.TipoUsuario
	LEFT JOIN AULAS A ON A.Codigo=C.Aula
	WHERE L.Usuario = @Usuario
GO