USE [FORMACION]
GO
/****** Object:  StoredProcedure [dbo].[PROC_CODIGOSPOSTALES_BorrarCodigoPostal]    Script Date: 01/11/2011 12:49:28 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
ALTER PROCEDURE [dbo].[PROC_CODIGOSPOSTALES_BorrarCodigoPostal]
	@CodigoPostal varchar(5)
AS
	DELETE FROM CODIGOSPOSTALES
	WHERE CodigoPostal=@CodigoPostal
