-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE PROC_CURSOS_BorrarCurso
	@Codigo varchar(7)
AS
	DELETE FROM CURSOS
	WHERE CodigoCurso=@Codigo
