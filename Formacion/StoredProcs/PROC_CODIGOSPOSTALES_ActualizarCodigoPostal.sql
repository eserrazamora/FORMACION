CREATE PROCEDURE PROC_CODIGOSPOSTALES_ActualizarCodigoPostal
   @CodigoPostal varchar(5),
   @Provincia varchar(50),
   @Localidad varchar(50)
AS
	UPDATE CODIGOSPOSTALES SET  
		Provincia = @Provincia, 
		Localidad = @Localidad 
	WHERE CodigoPostal = @CodigoPostal                               
GO                            