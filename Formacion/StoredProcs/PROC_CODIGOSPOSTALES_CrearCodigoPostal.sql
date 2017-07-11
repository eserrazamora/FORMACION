CREATE PROCEDURE PROC_CODIGOSPOSTALES_CrearCodigoPostal
   @CodigoPostal varchar(5),
   @Provincia varchar(50),
   @Localidad varchar(50)
AS
	INSERT INTO CODIGOSPOSTALES
				(CodigoPostal,Provincia,Localidad) 
	VALUES (@CodigoPostal,@Provincia,@Localidad)
                               
GO
