USE [FORMACION]
GO
/****** Object:  StoredProcedure [dbo].[PROC_ASISTENCIAS_ActualizarAsistencia]    Script Date: 12/20/2010 18:20:15 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
ALTER PROCEDURE [dbo].[PROC_ASISTENCIAS_ActualizarAsistencia]
    @CodigoMatricula varchar(13),
    @Fecha Date,
    @Asistio char(1)
AS 

	UPDATE ASISTENCIAS 
	
	SET Asistio=@Asistio
	
	WHERE CodigoMatricula=@CodigoMatricula
	 AND   Fecha=@Fecha
	
