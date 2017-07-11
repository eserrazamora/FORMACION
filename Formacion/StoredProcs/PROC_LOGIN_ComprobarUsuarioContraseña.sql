
CREATE PROCEDURE PROC_LOGIN_ComprobarUsuarioContraseņa
	@usuario varchar(50),
	@pass varchar(50)
	
AS
	SELECT COUNT(*) AS Result, usuario AS usuarioinput, contraseņa AS contrainput
	FROM LOGIN
	GROUP BY usuario, contraseņa
	HAVING (COUNT(*) = 1) AND (usuario = @usuario) AND (contraseņa = @pass)
GO
