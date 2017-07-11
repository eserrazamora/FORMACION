CREATE PROCEDURE PROC_PERSONAS_CrearPersona
	@NIF varchar(9),
	@Nombre varchar(30),
	@Apellidos varchar(50),
	@Sexo char(1),
	@FechaNacimiento date,
	@Direccion varchar(50),
	@CodigoPostal char(5),
	@Email varchar(80),
	@TelefonoFijo varchar(20),
	@TelefonoMovil varchar(20),
	@Rol char(3),
	@FechaAlta datetime,
	@FechaBaja datetime,
	@Observaciones text
	
AS

	INSERT INTO PERSONAS(NIF,Nombre,Apellidos,Sexo,FechaNacimiento,
						Direccion,CodigoPostal,Email,TelefonoFijo,
						TelefonoMovil,Rol,FechaAlta,FechaBaja,
						Observaciones)
	VALUES (@NIF,@Nombre,@Apellidos,@Sexo,@FechaNacimiento,@Direccion,
			@CodigoPostal,@Email,@TelefonoFijo,@TelefonoMovil,@Rol,
			@FechaAlta,@FechaBaja,@Observaciones)
		
GO
