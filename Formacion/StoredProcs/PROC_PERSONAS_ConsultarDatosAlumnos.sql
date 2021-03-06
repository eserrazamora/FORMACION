USE [FORMACION]
GO
/****** Object:  StoredProcedure [dbo].[PROC_PERSONAS_ConsultarDatosAlumnos]    Script Date: 12/16/2010 23:20:10 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
ALTER PROCEDURE [dbo].[PROC_PERSONAS_ConsultarDatosAlumnos] 
  	@NIF varchar(9) = NULL,
	@Nombre varchar(30) = NULL,
	@Apellidos varchar(50) = NULL,
	@Email varchar(80) = NULL,
	@TelefonoFijo varchar(20) = NULL,
	@TelefonoMovil varchar(20) = NULL
AS 
   SELECT Nif, Nombre,Apellidos, Sexo, FechaNacimiento,
		  Direccion, CodigoPostal, Email, TelefonoFijo,
		  TelefonoMovil, ROL, FechaAlta, FechaBaja,
		  Observaciones
   FROM PERSONAS
   WHERE ROL='ALM' 
	AND	 ((@NIF IS NULL) OR (PERSONAS.NIF LIKE '%'+@NIF+'%'))
	AND	 ((@Nombre IS NULL) OR (PERSONAS.Nombre LIKE '%'+@Nombre+'%')) 
    AND	 ((@Apellidos IS NULL) OR (PERSONAS.Apellidos LIKE '%'+@Apellidos+'%'))
	AND	 ((@Email IS NULL) OR (PERSONAS.Email LIKE '%'+@Email+'%'))
	AND	 ((@TelefonoFijo IS NULL) OR (PERSONAS.TelefonoFijo LIKE '%'+@TelefonoFijo+'%'))
	AND	 ((@TelefonoMovil IS NULL) OR (PERSONAS.TelefonoMovil LIKE '%'+@TelefonoMovil+'%'))
