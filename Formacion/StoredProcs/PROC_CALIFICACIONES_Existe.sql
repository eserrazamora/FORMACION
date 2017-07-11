-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE PROC_CALIFICACIONES_Existe
    @CodigoMatricula varchar(13)
 AS 
	SELECT COUNT(*)
	FROM MATRICULAS
	WHERE CodigoMatricula=@CodigoMatricula
GO
