
CREATE PROCEDURE PROC_LOGIN_CargarDatosLoginNIF
	@NIF varchar(9)
AS
	SELECT P.NIF,(P.Nombre + ' ' + P.Apellidos) AS INFO,
			L.Usuario,L.Contraseña,L.TipoUsuario
	FROM LOGIN L
	RIGHT JOIN PERSONAS P ON P.NIF=L.NIF
	LEFT JOIN TIPOSUSUARIOS T ON T.Codigo=L.TipoUsuario
	WHERE P.NIF = @NIF 
GO
