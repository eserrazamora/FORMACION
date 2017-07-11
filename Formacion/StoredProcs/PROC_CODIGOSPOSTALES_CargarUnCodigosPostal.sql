
CREATE PROCEDURE PROC_CODIGOSPOSTALES_CargarUnCodigosPostal
   @CodigoPostal varchar(5)
AS
	SELECT CodigoPostal,Provincia,Localidad 
	FROM CODIGOSPOSTALES 
	WHERE CodigoPostal=@CodigoPostal
GO
