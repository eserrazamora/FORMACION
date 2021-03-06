USE [FORMACION]
GO
/****** Object:  StoredProcedure [dbo].[PROC_MATRICULAS_CargarTodosAlumnosNoMatriculadosEnCurso]    Script Date: 12/20/2010 18:13:29 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
ALTER PROCEDURE [dbo].[PROC_MATRICULAS_CargarTodosAlumnosNoMatriculadosEnCurso]
   @CodigoCurso varchar(7)
AS 
  
  SELECT P.NIF, P.Nombre, P.Apellidos, P.Direccion, P.Email,
	  (P.NIF+' - ' + P.Nombre+ ' '+ P.Apellidos) AS INFO	

  FROM PERSONAS P
  
  WHERE ROL ='ALM' 
    AND P.NIF NOT IN (SELECT P.NIF
					  FROM PERSONAS P
						JOIN MATRICULAS M ON P.NIF=M.NifAlumno
						  AND M.CodigoCurso=@CodigoCurso
					  WHERE P.Rol = 'ALM'
					 )

