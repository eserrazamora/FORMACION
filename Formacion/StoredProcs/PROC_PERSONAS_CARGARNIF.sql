USE [FORMACION]
GO
/****** Object:  StoredProcedure [dbo].[PROC_PERSONAS_CargarNif]    Script Date: 12/09/2010 01:51:53 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
ALTER PROCEDURE [dbo].[PROC_PERSONAS_CargarNif]
   
    @NIF varchar(9)
 
AS 
    
   SELECT Nif,Nombre,Apellidos, Sexo, FechaNacimiento,
		  Direccion, CodigoPostal, Email, TelefonoFijo,
		  TelefonoMovil, ROL, FechaAlta, FechaBaja,
		  Observaciones
   FROM PERSONAS
   WHERE Nif=@NIF
