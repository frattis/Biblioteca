CREATE DATABASE Biblioteca


USE [master]

-- Enable Integrated Security=False
GO
EXEC xp_instance_regwrite N'HKEY_LOCAL_MACHINE', N'Software\Microsoft\MSSQLServer\MSSQLServer', N'LoginMode', REG_DWORD, 2
GO

-- Create the 'qweasd' user
DECLARE @SID VARBINARY(85);
SELECT @SID = sid FROM dbo.syslogins WHERE name = 'bibliotecaUser'
SELECT @SID

IF @SID IS NULL
BEGIN
   CREATE LOGIN [bibliotecaUser] WITH PASSWORD=N'adm123', DEFAULT_DATABASE=[Biblioteca], CHECK_EXPIRATION=OFF, CHECK_POLICY=OFF
   EXEC master..sp_addsrvrolemember @loginame = N'bibliotecaUser', @rolename = N'sysadmin'
END