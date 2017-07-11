-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE PROC_CALIFICACIONES_CrearCalificacion
	@CodigoMatricula varchar(13),
	@Calificacion decimal,
	@Observaciones text
AS
	INSERT INTO CALIFICACIONES(CodigoMatricula,Calificacion,Observaciones)
	VALUES (@CodigoMatricula,@Calificacion,@Observaciones)
GO
