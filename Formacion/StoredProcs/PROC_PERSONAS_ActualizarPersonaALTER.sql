USE [FORMACION]
GO
/****** Object:  StoredProcedure [dbo].[PROC_PERSONAS_ActualizarPersona]    Script Date: 01/10/2011 11:48:47 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
ALTER PROCEDURE [dbo].[PROC_PERSONAS_ActualizarPersona]
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

	UPDATE PERSONAS SET 
		Nombre=@Nombre,
		Apellidos=@Apellidos,
		Sexo=@Sexo,
		FechaNacimiento=@FechaNacimiento,
		Direccion=@Direccion,
		CodigoPostal=@CodigoPostal,
		Email=@Email,
		TelefonoFijo=@TelefonoFijo,
		TelefonoMovil=@TelefonoMovil,
		Rol=@Rol,
		FechaAlta=@FechaAlta,
		FechaBaja=@FechaBaja,
		Observaciones=@Observaciones 
		
	WHERE NIF=@NIF
		
