CREATE PROCEDURE PROC_ASISTENCIAS_Existe 
    @CodigoMatricula varchar(10)
AS 

	SELECT COUNT(*)
	FROM ASISTENCIAS
	WHERE CodigoMatricula=@CodigoMatricula
	
GO