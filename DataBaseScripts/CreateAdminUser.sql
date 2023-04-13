--Insert new admin user for person: mlytton0@globo.com with password: admin

USE [CarFleetDB]
GO
INSERT INTO [Persons] ([FirstName], [LastName], [PhoneNumber], [Email], [Disabled]) VALUES ('admin', 'admin', '123123123', 'admin@admin.com', 0);

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


