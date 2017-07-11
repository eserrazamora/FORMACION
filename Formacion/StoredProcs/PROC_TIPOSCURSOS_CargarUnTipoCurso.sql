CREATE PROCEDURE PROC_TIPOSCURSOS_CargarUnTipoCurso
     @Codigo varchar(4)
AS 
    
   SELECT  Codigo,Tipo
   FROM TIPOSCURSOS
   WHERE Codigo=@codigo

GO

