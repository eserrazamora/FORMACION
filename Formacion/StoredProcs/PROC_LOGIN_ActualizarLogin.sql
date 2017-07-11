CREATE PROCEDURE PROC_LOGIN_ActualizarLogin
	@Nif varchar(9),
	@usuario varchar(50),
	@pass varchar(50),
	@TipoUsuario varchar(2)
AS
	UPDATE LOGIN SET
		
		Usuario=@usuario,
		Contraseña=@pass,
		TipoUsuario=@TipoUsuario
		
	WHERE nif=@Nif
GO
