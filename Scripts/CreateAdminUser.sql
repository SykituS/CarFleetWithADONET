--Insert new admin user for person: mlytton0@globo.com with password: admin

USE [CarFleetDB]
GO

INSERT INTO [dbo].[Users]
           ([UserName]
           ,[PasswordHash]
           ,[PersonID]
           ,[RoleID])
     VALUES
           ('admin'
           ,'dSPGKr23Yoxana2Pl9jYxcBA7eNlNeUxqKN0i2yufgA='
           ,1
           ,1)
GO


