
CREATE PROCEDURE PROC_PERSONAS_BorrarPersona

	@NifAlumno varchar(9)
AS
	DELETE FROM PERSONAS
	WHERE NIF=@NifAlumno
