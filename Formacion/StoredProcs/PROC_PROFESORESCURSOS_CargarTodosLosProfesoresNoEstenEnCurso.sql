CREATE PROCEDURE PROC_PROFESORESCURSOS_CargarTodosLosProfesoresNoEstenEnCurso
   @CodigoCurso varchar(7)
AS 
  
  SELECT P.NIF, P.Nombre, P.Apellidos, P.Direccion, P.Email,
	  (P.NIF+' - ' + P.Nombre+ ' '+ P.Apellidos) AS INFO	

  FROM PERSONAS P
  
  WHERE ROL ='PRF' 
    AND P.NIF NOT IN (SELECT P.NIF
					  FROM PERSONAS P
						JOIN PROFESORESCURSOS PC ON P.NIF=PC.NifProfesor
						  AND PC.CodigoCurso=@CodigoCurso
					  WHERE P.Rol = 'PRF'
					 )
 
GO
