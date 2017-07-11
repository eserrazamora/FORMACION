USE [FORMACION]
GO
/****** Object:  StoredProcedure [dbo].[PROC_ASISTENCIAS_CrearAsistencia]    Script Date: 12/20/2010 18:20:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
ALTER PROCEDURE [dbo].[PROC_ASISTENCIAS_CrearAsistencia]
    @CodigoMatricula varchar(13),
    @Fecha Date,
    @Asistio char(1)
AS 

	INSERT INTO ASISTENCIAS(CodigoMatricula,Fecha,Asistio)
	VALUES (@CodigoMatricula,@Fecha,@Asistio)
	
