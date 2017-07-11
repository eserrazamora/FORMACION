
CREATE PROCEDURE PROC_LOGIN_CargarDatosUsuario
	@Usuario varchar(50)
AS
	SELECT P.NIF,(P.Nombre + ' ' + P.Apellidos) AS INFO,
			L.Usuario,L.Contraseña,L.TipoUsuario
	FROM LOGIN L
	RIGHT JOIN PERSONAS P ON P.NIF=L.NIF
	LEFT JOIN TIPOSUSUARIOS T ON T.Codigo=L.TipoUsuario
	WHERE L.Usuario = @Usuario 
GO