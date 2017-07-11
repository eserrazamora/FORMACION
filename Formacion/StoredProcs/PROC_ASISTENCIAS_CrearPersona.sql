CREATE PROCEDURE PROC_ASISTENCIAS_CrearAsistencia
    @CodigoMatricula varchar(10),
    @Fecha Date,
    @Asistio char(1)
AS 

	INSERT INTO ASISTENCIAS(CodigoMatricula,Fecha,Asistio)
	VALUES (@CodigoMatricula,@Fecha,@Asistio)
	
