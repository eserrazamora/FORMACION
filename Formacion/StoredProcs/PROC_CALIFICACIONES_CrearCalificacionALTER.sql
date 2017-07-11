USE [FORMACION]
GO
/****** Object:  StoredProcedure [dbo].[PROC_CALIFICACIONES_CrearCalificacion]    Script Date: 01/05/2011 17:45:08 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
ALTER PROCEDURE [dbo].[PROC_CALIFICACIONES_CrearCalificacion]
	@CodigoMatricula varchar(13),
	@Calificacion decimal(4,2),
	@Observaciones text
AS
	INSERT INTO CALIFICACIONES(CodigoMatricula,Calificacion,Observaciones)
	VALUES (@CodigoMatricula,@Calificacion,@Observaciones)
