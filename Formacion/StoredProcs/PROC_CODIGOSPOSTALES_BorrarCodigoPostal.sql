CREATE PROCEDURE PROC_CODIGOSPOSTALES_BorrarCodigoPostal
	@CodigoPostal varchar(5)
AS
	DELETE FROM CODIGOSPOSTALES
	WHERE CodigoPostal=@CodigoPostal

GO