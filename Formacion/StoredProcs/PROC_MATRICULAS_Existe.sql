CREATE PROCEDURE PROC_MATRICULAS_Existe
    @CodigoMatricula varchar(10)  
AS 
	SELECT COUNT(*)
	FROM MATRICULAS
	WHERE CodigoMatricula=@CodigoMatricula
GO