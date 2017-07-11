USE [FORMACION]
GO
/****** Object:  StoredProcedure [dbo].[PROC_CALIFICACIONES_ActualizarCalificacion]    Script Date: 01/05/2011 17:44:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
ALTER PROCEDURE [dbo].[PROC_CALIFICACIONES_ActualizarCalificacion]
	@CodigoMatricula varchar(13),
	@Calificacion decimal(4,2),
	@Observaciones text
AS
	UPDATE CALIFICACIONES SET 
		   Calificacion = @Calificacion,
		   Observaciones = @Observaciones
	WHERE  CodigoMatricula=@CodigoMatricula
