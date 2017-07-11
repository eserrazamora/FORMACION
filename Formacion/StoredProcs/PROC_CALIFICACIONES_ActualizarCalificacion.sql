-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE PROC_CALIFICACIONES_ActualizarCalificacion
	@CodigoMatricula varchar(13),
	@Calificacion decimal,
	@Observaciones text
AS
	UPDATE CALIFICACIONES SET 
		   Calificacion = @Calificacion,
		   Observaciones = @Observaciones
	WHERE  CodigoMatricula=@CodigoMatricula
GO
