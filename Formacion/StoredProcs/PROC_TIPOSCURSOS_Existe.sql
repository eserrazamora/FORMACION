CREATE PROCEDURE PROC_TIPOSCURSOS_Existe
    @Codigo varchar(4)
 
AS 
	    
	SELECT Count(*) 
	FROM TIPOSCURSOS 
	WHERE Codigo=@codigo
