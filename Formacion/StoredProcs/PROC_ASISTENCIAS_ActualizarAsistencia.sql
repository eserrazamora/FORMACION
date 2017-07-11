CREATE PROCEDURE PROC_ASISTENCIAS_ActualizarAsistencia
    @CodigoMatricula varchar(10),
    @Fecha Date,
    @Asistio char(1)
AS 

	UPDATE ASISTENCIAS 
	
	SET Asistio=@Asistio
	
	WHERE CodigoMatricula=@CodigoMatricula
	 AND   Fecha=@Fecha
	
	
GO
