USE [FORMACION]
GO
/****** Object:  StoredProcedure [dbo].[PROC_PERSONAS_CargarTodos]    Script Date: 12/10/2010 18:20:43 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
ALTER PROCEDURE [dbo].[PROC_PERSONAS_CargarTodos]
   
    @Rol char(3) = NULL
     
AS 
    
   SELECT Nif, Nombre,Apellidos, Sexo, FechaNacimiento,
		  Direccion, CodigoPostal, Email, TelefonoFijo,
		  TelefonoMovil, ROL, FechaAlta, FechaBaja,
		  Observaciones
   FROM PERSONAS
   WHERE ((@Rol IS NULL) OR Rol=@Rol)    
