CREATE PROCEDURE PROC_CODIGOSPOSTALES_CargarCodigosPostales

AS
	SELECT CodigoPostal,Provincia,Localidad 
	FROM CODIGOSPOSTALES 
	ORDER BY CodigoPostal
GO
