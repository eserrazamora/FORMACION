USE [FORMACION]
GO
/****** Object:  StoredProcedure [dbo].[PROC_TIPOSUSUARIOS_BorrarTipoUsuario]    Script Date: 12/24/2010 02:45:16 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
ALTER PROCEDURE [dbo].[PROC_TIPOSUSUARIOS_BorrarTipoUsuario]
	@Codigo varchar(2)
AS
	DELETE FROM TIPOSUSUARIOS
	WHERE Codigo=@Codigo

