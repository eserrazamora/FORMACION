-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE PROC_CODIGOSPOSTALES_BorrarAula
	@Codigo varchar(4)
AS
	DELETE FROM AULAS
	WHERE Codigo=@Codigo
GO