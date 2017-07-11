
CREATE PROCEDURE PROC_PROFESORESCURSOS_CrearProfesorCurso
    @NifProfesor varchar(9),
    @CodigoCurso varchar(7)
    
AS 

	INSERT INTO PROFESORESCURSOS(NifProfesor,CodigoCurso)
	VALUES (@NifProfesor,@CodigoCurso)
	
GO
