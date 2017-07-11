CREATE PROCEDURE PROC_LOGIN_CrearLogin
	@Nif varchar(9),
	@usuario varchar(50),
	@pass varchar(50),
	@TipoUsuario varchar(2)
AS
	INSERT INTO LOGIN(NIF,Usuario,Contraseña,TipoUsuario)
	VALUES (@Nif,@usuario,@pass,@TipoUsuario)	
GO
