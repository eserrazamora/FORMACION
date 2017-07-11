CREATE PROCEDURE PROC_PROFESORESCURSOS_CargarProfesoresCurso
    @NifProfesor varchar(9)
AS
	SELECT PC.CodigoCurso 
	FROM PROFESORESCURSOS PC
	JOIN CURSOS C ON PC.CodigoCurso=C.CodigoCurso
	WHERE PC.NifProfesor=@NifProfesor
GO
