CREATE PROCEDURE PROC_CODIGOSPOSTALES_ComprobarDependencias
	@CodigoPostal varchar(5)
AS
	SELECT COUNT(*)
	FROM PERSONAS 
	WHERE CodigoPostal=@CodigoPostal

GO
