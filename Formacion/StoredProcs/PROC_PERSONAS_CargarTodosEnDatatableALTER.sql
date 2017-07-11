USE [FORMACION]
GO
/****** Object:  StoredProcedure [dbo].[PROC_PERSONAS_CargarTodosEnDatatable]    Script Date: 01/10/2011 11:50:19 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
ALTER PROCEDURE [dbo].[PROC_PERSONAS_CargarTodosEnDatatable]
    @Rol varchar(3)= NULL
    
AS 
  SELECT (NIF+' - '+Nombre+' '+Apellidos) As INFO, 
		Nif, Nombre,Apellidos, Sexo, FechaNacimiento,
		 Direccion, CodigoPostal, Email, TelefonoFijo,
		 TelefonoMovil, ROL, FechaAlta, FechaBaja,
		 Observaciones
   FROM PERSONAS
   WHERE ((@Rol IS NULL) OR Rol=@Rol)   



   