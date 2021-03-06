USE [FORMACION]
GO
/****** Object:  StoredProcedure [dbo].[PROC_PERSONAS_CrearPersona]    Script Date: 01/10/2011 11:54:05 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
ALTER PROCEDURE [dbo].[PROC_PERSONAS_CrearPersona]
	@NIF varchar(9),
	@Nombre varchar(30),
	@Apellidos varchar(50),
	@Sexo char(1),
	@FechaNacimiento date,
	@Direccion varchar(50),
	@CodigoPostal varchar(5),
	@Email varchar(80),
	@TelefonoFijo varchar(20),
	@TelefonoMovil varchar(20),
	@Rol varchar(3),
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
		
