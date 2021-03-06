USE [FORMACION]
GO
/****** Object:  StoredProcedure [dbo].[PROC_CURSOS_CargarTodosEnDatatable]    Script Date: 01/02/2011 23:28:21 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
ALTER PROCEDURE [dbo].[PROC_CURSOS_CargarTodosEnDatatable]
	
AS
	SELECT CodigoCurso, Nombre,
           FechaInicio,FechaFin,Duracion,
           (Codigocurso + ' - ' + Nombre + ' - Inicio: ' 
            + convert(char(10), FechaInicio , 103)+ ' - Fin: ' 
            + convert(char(10), FechaFin , 103)+ ' - ' 
            + convert(varchar(10),Duracion) + ' horas.'
            )   AS INFO
    FROM CURSOS
    ORDER BY CodigoCurso