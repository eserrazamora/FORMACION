USE [FORMACION]
GO
/****** Object:  StoredProcedure [dbo].[PROC_TIPOSUSUARIOS_CrearTipoUsuario]    Script Date: 12/11/2010 02:28:38 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
ALTER PROCEDURE [dbo].[PROC_TIPOSUSUARIOS_CrearTipoUsuario] 
    
    @Codigo varchar(2), 
    @Tipo varchar(50)
    
AS 

	INSERT INTO TIPOSUSUARIOS(Codigo,Tipo) 
	VALUES (@Codigo,@Tipo)
   
