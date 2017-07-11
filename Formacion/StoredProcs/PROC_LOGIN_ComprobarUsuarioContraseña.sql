
CREATE PROCEDURE PROC_LOGIN_ComprobarUsuarioContrase�a
	@usuario varchar(50),
	@pass varchar(50)
	
AS
	SELECT COUNT(*) AS Result, usuario AS usuarioinput, contrase�a AS contrainput
	FROM LOGIN
	GROUP BY usuario, contrase�a
	HAVING (COUNT(*) = 1) AND (usuario = @usuario) AND (contrase�a = @pass)
GO
