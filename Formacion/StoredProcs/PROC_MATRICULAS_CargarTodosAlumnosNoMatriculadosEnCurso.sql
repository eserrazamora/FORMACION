CREATE PROCEDURE PROC_MATRICULAS_CargarTodosAlumnosNoMatriculadosEnCurso
   @CodigoCurso varchar(7)
AS 
  
  SELECT P.NIF, P.Nombre, P.Apellidos, P.Direccion, P.Email,
	  (P.NIF+' - ' + P.Nombre+ ' '+ P.Apellidos) AS INFO	

  FROM PERSONAS P
  
  WHERE P.NIF NOT IN (SELECT P.NIF
					  FROM PERSONAS P
						JOIN MATRICULAS M ON P.NIF=M.NifAlumno
						  AND M.CodigoCurso=@CodigoCurso
					 )

GO