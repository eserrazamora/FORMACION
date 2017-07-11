CREATE PROCEDURE PROC_PERSONAS_ConsultarDatosProfesores
  	@NIF varchar(9) = NULL,
	@Nombre varchar(30) = NULL,
	@Apellidos varchar(50) = NULL,
	@Email varchar(80) = NULL,
	@TelefonoFijo varchar(20) = NULL,
	@TelefonoMovil varchar(20) = NULL
	
AS 
   SELECT Nif, Nombre,Apellidos, Sexo, FechaNacimiento,
		  Direccion, CodigoPostal, Email, TelefonoFijo,
		  TelefonoMovil, ROL, FechaAlta, FechaBaja,
		  Observaciones
   FROM PERSONAS P
   WHERE ROL='PRF' 
	AND P.NIF LIKE '%'+coalesce(@NIF,'')+'%'
	AND P.Nombre LIKE '%'+coalesce(@NOMBRE,'')+'%'
	AND P.Apellidos LIKE '%'+coalesce(@APELLIDOS,'')+'%'
    AND P.Email LIKE '%'+coalesce(@EMAIL,'')+'%'
	AND P.TelefonoFijo  LIKE '%'+coalesce(@TelefonoFijo,'')+'%'
	AND P.TelefonoMovil LIKE '%'+coalesce(@telefonoMovil,'')+'%'
OPTION (RECOMPILE);	
GO