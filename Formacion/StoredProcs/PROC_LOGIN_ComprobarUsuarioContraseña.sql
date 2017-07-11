
CREATE PROCEDURE PROC_LOGIN_ComprobarUsuarioContraseña
	@usuario varchar(50),
	@pass varchar(50)
	
AS
	SELECT COUNT(*) AS Result, usuario AS usuarioinput, contraseña AS contrainput
	FROM LOGIN
	GROUP BY usuario, contraseña
	HAVING (COUNT(*) = 1) AND (usuario = @usuario) AND (contraseña = @pass)
GO
