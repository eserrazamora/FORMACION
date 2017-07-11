CREATE PROCEDURE PROC_TIPOSCURSOS_CrearTipoCurso
    @Codigo varchar(4),
    @Tipo varchar(50)
 
AS 
	INSERT INTO TIPOSCURSOS(Codigo,Tipo)
	VALUES (@Codigo,@Tipo) 