USE [FORMACION]
GO
/****** Object:  StoredProcedure [dbo].[PROC_PERSONAS_CargarTodosEnDatatable]    Script Date: 12/10/2010 18:25:54 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
ALTER PROCEDURE [dbo].[PROC_PERSONAS_CargarTodosEnDatatable]
    @Rol char(3)= NULL
    
AS 
  SELECT (NIF+' - '+Nombre+' '+Apellidos) As INFO, 
		Nif, Nombre,Apellidos, Sexo, FechaNacimiento,
		 Direccion, CodigoPostal, Email, TelefonoFijo,
		 TelefonoMovil, ROL, FechaAlta, FechaBaja,
		 Observaciones
   FROM PERSONAS
   WHERE ((@Rol IS NULL) OR Rol=@Rol)   



   