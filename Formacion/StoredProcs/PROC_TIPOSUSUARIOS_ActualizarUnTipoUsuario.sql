USE [FORMACION]
GO
/****** Object:  StoredProcedure [dbo].[PROC_TIPOSUSUARIOS_ActualizarTipoUsuario]    Script Date: 12/11/2010 02:30:13 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
ALTER PROCEDURE [dbo].[PROC_TIPOSUSUARIOS_ActualizarTipoUsuario] 
    
    @Codigo varchar(2), 
    @Tipo varchar(50)
    
AS 

	UPDATE TIPOSUSUARIOS SET
	Tipo = @Tipo 

	WHERE Codigo = @Codigo


