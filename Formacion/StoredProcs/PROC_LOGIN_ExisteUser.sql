CREATE PROCEDURE PROC_LOGIN_ExisteUser
	@usuario varchar(50)
AS
	SELECT COUNT(*)
	FROM LOGIN 
	WHERE Usuario=@usuario

GO
