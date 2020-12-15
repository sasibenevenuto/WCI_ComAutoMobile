USE [WCI_ComAutoMobile]
GO

BEGIN IF NOT EXISTS (SELECT * FROM [dbo].[AspNetUsers] WHERE [Id] = '58fe0553-cc68-48a7-b8fe-b15e12e3941f') 
INSERT INTO [dbo].[AspNetUsers]
           ([Id]
           ,[ProfileId]
           ,[UserName]
           ,[NormalizedUserName]
           ,[Email]
           ,[NormalizedEmail]
           ,[EmailConfirmed]
           ,[PasswordHash]
           ,[SecurityStamp]
           ,[ConcurrencyStamp]
           ,[PhoneNumber]
           ,[PhoneNumberConfirmed]
           ,[TwoFactorEnabled]
           ,[LockoutEnd]
           ,[LockoutEnabled]
           ,[AccessFailedCount])
     VALUES
           ('58fe0553-cc68-48a7-b8fe-b15e12e3941f'
           ,NULL
           ,'sasibenevenuto@gmail.com'
           ,'Samuel Apolion Benevenuto'
           ,'sasibenevenuto@gmail.com'
           ,'sasibenevenuto@gmail.com'
           ,1
           ,NULL
           ,NULL
           ,NULL
           ,'11995400018'
           ,1
           ,0
           ,NULL
           ,0
           ,0)
END
GO

BEGIN IF NOT EXISTS (SELECT * FROM [dbo].[Personal_Information] WHERE [UserID] = '58fe0553-cc68-48a7-b8fe-b15e12e3941f') 
INSERT INTO [dbo].[Personal_Information]
           ([UserID]
           ,[IndividualResistration]
           ,[PhoneNumbers]
           ,[PostalCode]
           ,[Address]
           ,[AddressNumber]
           ,[AddressComplement]
           ,[Neighborhood]
           ,[CityId]
           ,[UserIDCreate]
           ,[UserIDLastUpdate]
           ,[Active]
           ,[CreateDate]
           ,[ModifieldDate])
     VALUES
           ('58fe0553-cc68-48a7-b8fe-b15e12e3941f'
           ,NULL
           ,NULL
           ,NULL
           ,NULL
           ,NULL
           ,NULL
           ,NULL
           ,NULL
           ,NULL
           ,NULL
           ,1
           ,GETDATE()
           ,GETDATE())
END
GO


BEGIN IF NOT EXISTS (SELECT * FROM [dbo].[Profile] WHERE [Description] = 'Administrador') 
INSERT INTO [dbo].[Profile]
           ([Description]
           ,[UserIDCreate]
           ,[UserIDLastUpdate]
           ,[Active]
           ,[CreateDate]
           ,[ModifieldDate])
     VALUES
           ('Administrador'
           ,1
           ,1
           ,1
           ,GETDATE()
           ,GETDATE())
END
GO

UPDATE AspNetUsers Set ProfileId = 1 WHERE Id = '58fe0553-cc68-48a7-b8fe-b15e12e3941f'



-- ESTADOS --

SET IDENTITY_INSERT dbo.State ON;  

BEGIN IF NOT EXISTS (SELECT * FROM [dbo].[State] WHERE [Name] = 'Acre') BEGIN INSERT INTO [dbo].[State]([StateId],[Name],[FederativeUnit],[ExternalCode],[Active],[UserIDCreate],[UserIDLastUpdate],[CreateDate],[ModifieldDate]) VALUES (1,'Acre','AC',' 12',1,1,1,GETDATE(),GETDATE()) END END
BEGIN IF NOT EXISTS (SELECT * FROM [dbo].[State] WHERE [Name] = 'Alagoas') BEGIN INSERT INTO [dbo].[State]([StateId],[Name],[FederativeUnit],[ExternalCode],[Active],[UserIDCreate],[UserIDLastUpdate],[CreateDate],[ModifieldDate]) VALUES (2,'Alagoas','AL',' 27',1,1,1,GETDATE(),GETDATE()) END END
BEGIN IF NOT EXISTS (SELECT * FROM [dbo].[State] WHERE [Name] = 'Amazonas') BEGIN INSERT INTO [dbo].[State]([StateId],[Name],[FederativeUnit],[ExternalCode],[Active],[UserIDCreate],[UserIDLastUpdate],[CreateDate],[ModifieldDate]) VALUES (3,'Amazonas','AM',' 13',1,1,1,GETDATE(),GETDATE()) END END
BEGIN IF NOT EXISTS (SELECT * FROM [dbo].[State] WHERE [Name] = 'Amapá') BEGIN INSERT INTO [dbo].[State]([StateId],[Name],[FederativeUnit],[ExternalCode],[Active],[UserIDCreate],[UserIDLastUpdate],[CreateDate],[ModifieldDate]) VALUES (4,'Amapá¡','AP',' 16',1,1,1,GETDATE(),GETDATE()) END END
BEGIN IF NOT EXISTS (SELECT * FROM [dbo].[State] WHERE [Name] = 'Bahia') BEGIN INSERT INTO [dbo].[State]([StateId],[Name],[FederativeUnit],[ExternalCode],[Active],[UserIDCreate],[UserIDLastUpdate],[CreateDate],[ModifieldDate]) VALUES (5,'Bahia','BA',' 29',1,1,1,GETDATE(),GETDATE()) END END
BEGIN IF NOT EXISTS (SELECT * FROM [dbo].[State] WHERE [Name] = 'Ceará') BEGIN INSERT INTO [dbo].[State]([StateId],[Name],[FederativeUnit],[ExternalCode],[Active],[UserIDCreate],[UserIDLastUpdate],[CreateDate],[ModifieldDate]) VALUES (6,'Ceará','CE',' 23',1,1,1,GETDATE(),GETDATE()) END END
BEGIN IF NOT EXISTS (SELECT * FROM [dbo].[State] WHERE [Name] = 'Distrito Federal') BEGIN INSERT INTO [dbo].[State]([StateId],[Name],[FederativeUnit],[ExternalCode],[Active],[UserIDCreate],[UserIDLastUpdate],[CreateDate],[ModifieldDate]) VALUES (7,'Distrito Federal','DF',' 53',1,1,1,GETDATE(),GETDATE()) END END
BEGIN IF NOT EXISTS (SELECT * FROM [dbo].[State] WHERE [Name] = 'Espírito Santo') BEGIN INSERT INTO [dbo].[State]([StateId],[Name],[FederativeUnit],[ExternalCode],[Active],[UserIDCreate],[UserIDLastUpdate],[CreateDate],[ModifieldDate]) VALUES (8,'Espírito Santo','ES',' 32',1,1,1,GETDATE(),GETDATE()) END END
BEGIN IF NOT EXISTS (SELECT * FROM [dbo].[State] WHERE [Name] = 'Goiás') BEGIN INSERT INTO [dbo].[State]([StateId],[Name],[FederativeUnit],[ExternalCode],[Active],[UserIDCreate],[UserIDLastUpdate],[CreateDate],[ModifieldDate]) VALUES (9,'Goiás','GO',' 52',1,1,1,GETDATE(),GETDATE()) END END
BEGIN IF NOT EXISTS (SELECT * FROM [dbo].[State] WHERE [Name] = 'Maranhão') BEGIN INSERT INTO [dbo].[State]([StateId],[Name],[FederativeUnit],[ExternalCode],[Active],[UserIDCreate],[UserIDLastUpdate],[CreateDate],[ModifieldDate]) VALUES (10,'Maranhão','MA',' 21',1,1,1,GETDATE(),GETDATE()) END END
BEGIN IF NOT EXISTS (SELECT * FROM [dbo].[State] WHERE [Name] = 'Minas Gerais') BEGIN INSERT INTO [dbo].[State]([StateId],[Name],[FederativeUnit],[ExternalCode],[Active],[UserIDCreate],[UserIDLastUpdate],[CreateDate],[ModifieldDate]) VALUES (11,'Minas Gerais','MG',' 31',1,1,1,GETDATE(),GETDATE()) END END
BEGIN IF NOT EXISTS (SELECT * FROM [dbo].[State] WHERE [Name] = 'Mato Grosso do Sul') BEGIN INSERT INTO [dbo].[State]([StateId],[Name],[FederativeUnit],[ExternalCode],[Active],[UserIDCreate],[UserIDLastUpdate],[CreateDate],[ModifieldDate]) VALUES (12,'Mato Grosso do Sul','MS',' 50',1,1,1,GETDATE(),GETDATE()) END END
BEGIN IF NOT EXISTS (SELECT * FROM [dbo].[State] WHERE [Name] = 'Mato Grosso') BEGIN INSERT INTO [dbo].[State]([StateId],[Name],[FederativeUnit],[ExternalCode],[Active],[UserIDCreate],[UserIDLastUpdate],[CreateDate],[ModifieldDate]) VALUES (13,'Mato Grosso','MT',' 51',1,1,1,GETDATE(),GETDATE()) END END
BEGIN IF NOT EXISTS (SELECT * FROM [dbo].[State] WHERE [Name] = 'Pará') BEGIN INSERT INTO [dbo].[State]([StateId],[Name],[FederativeUnit],[ExternalCode],[Active],[UserIDCreate],[UserIDLastUpdate],[CreateDate],[ModifieldDate]) VALUES (14,'Pará','PA',' 15',1,1,1,GETDATE(),GETDATE()) END END
BEGIN IF NOT EXISTS (SELECT * FROM [dbo].[State] WHERE [Name] = 'Paraíba') BEGIN INSERT INTO [dbo].[State]([StateId],[Name],[FederativeUnit],[ExternalCode],[Active],[UserIDCreate],[UserIDLastUpdate],[CreateDate],[ModifieldDate]) VALUES (15,'Paraíba','PB',' 25',1,1,1,GETDATE(),GETDATE()) END END
BEGIN IF NOT EXISTS (SELECT * FROM [dbo].[State] WHERE [Name] = 'Pernambuco') BEGIN INSERT INTO [dbo].[State]([StateId],[Name],[FederativeUnit],[ExternalCode],[Active],[UserIDCreate],[UserIDLastUpdate],[CreateDate],[ModifieldDate]) VALUES (16,'Pernambuco','PE',' 26',1,1,1,GETDATE(),GETDATE()) END END
BEGIN IF NOT EXISTS (SELECT * FROM [dbo].[State] WHERE [Name] = 'Piauí') BEGIN INSERT INTO [dbo].[State]([StateId],[Name],[FederativeUnit],[ExternalCode],[Active],[UserIDCreate],[UserIDLastUpdate],[CreateDate],[ModifieldDate]) VALUES (17,'Piauí','PI',' 22',1,1,1,GETDATE(),GETDATE()) END END
BEGIN IF NOT EXISTS (SELECT * FROM [dbo].[State] WHERE [Name] = 'Paraná') BEGIN INSERT INTO [dbo].[State]([StateId],[Name],[FederativeUnit],[ExternalCode],[Active],[UserIDCreate],[UserIDLastUpdate],[CreateDate],[ModifieldDate]) VALUES (18,'Paraná','PR',' 41',1,1,1,GETDATE(),GETDATE()) END END
BEGIN IF NOT EXISTS (SELECT * FROM [dbo].[State] WHERE [Name] = 'Rio de Janeiro') BEGIN INSERT INTO [dbo].[State]([StateId],[Name],[FederativeUnit],[ExternalCode],[Active],[UserIDCreate],[UserIDLastUpdate],[CreateDate],[ModifieldDate]) VALUES (19,'Rio de Janeiro','RJ',' 33',1,1,1,GETDATE(),GETDATE()) END END
BEGIN IF NOT EXISTS (SELECT * FROM [dbo].[State] WHERE [Name] = 'Rio Grande do Norte') BEGIN INSERT INTO [dbo].[State]([StateId],[Name],[FederativeUnit],[ExternalCode],[Active],[UserIDCreate],[UserIDLastUpdate],[CreateDate],[ModifieldDate]) VALUES (20,'Rio Grande do Norte','RN',' 24',1,1,1,GETDATE(),GETDATE()) END END
BEGIN IF NOT EXISTS (SELECT * FROM [dbo].[State] WHERE [Name] = 'Rondônia') BEGIN INSERT INTO [dbo].[State]([StateId],[Name],[FederativeUnit],[ExternalCode],[Active],[UserIDCreate],[UserIDLastUpdate],[CreateDate],[ModifieldDate]) VALUES (21,'Rondônia','RO',' 11',1,1,1,GETDATE(),GETDATE()) END END
BEGIN IF NOT EXISTS (SELECT * FROM [dbo].[State] WHERE [Name] = 'Roraima') BEGIN INSERT INTO [dbo].[State]([StateId],[Name],[FederativeUnit],[ExternalCode],[Active],[UserIDCreate],[UserIDLastUpdate],[CreateDate],[ModifieldDate]) VALUES (22,'Roraima','RR',' 14',1,1,1,GETDATE(),GETDATE()) END END
BEGIN IF NOT EXISTS (SELECT * FROM [dbo].[State] WHERE [Name] = 'Rio Grande do Sul') BEGIN INSERT INTO [dbo].[State]([StateId],[Name],[FederativeUnit],[ExternalCode],[Active],[UserIDCreate],[UserIDLastUpdate],[CreateDate],[ModifieldDate]) VALUES (23,'Rio Grande do Sul','RS',' 43',1,1,1,GETDATE(),GETDATE()) END END
BEGIN IF NOT EXISTS (SELECT * FROM [dbo].[State] WHERE [Name] = 'Santa Catarina') BEGIN INSERT INTO [dbo].[State]([StateId],[Name],[FederativeUnit],[ExternalCode],[Active],[UserIDCreate],[UserIDLastUpdate],[CreateDate],[ModifieldDate]) VALUES (24,'Santa Catarina','SC',' 42',1,1,1,GETDATE(),GETDATE()) END END
BEGIN IF NOT EXISTS (SELECT * FROM [dbo].[State] WHERE [Name] = 'Sergipe') BEGIN INSERT INTO [dbo].[State]([StateId],[Name],[FederativeUnit],[ExternalCode],[Active],[UserIDCreate],[UserIDLastUpdate],[CreateDate],[ModifieldDate]) VALUES (25,'Sergipe','SE',' 28',1,1,1,GETDATE(),GETDATE()) END END
BEGIN IF NOT EXISTS (SELECT * FROM [dbo].[State] WHERE [Name] = 'São Paulo') BEGIN INSERT INTO [dbo].[State]([StateId],[Name],[FederativeUnit],[ExternalCode],[Active],[UserIDCreate],[UserIDLastUpdate],[CreateDate],[ModifieldDate]) VALUES (26,'São Paulo','SP',' 35',1,1,1,GETDATE(),GETDATE()) END END
BEGIN IF NOT EXISTS (SELECT * FROM [dbo].[State] WHERE [Name] = 'Tocantins') BEGIN INSERT INTO [dbo].[State]([StateId],[Name],[FederativeUnit],[ExternalCode],[Active],[UserIDCreate],[UserIDLastUpdate],[CreateDate],[ModifieldDate]) VALUES (27,'Tocantins','TO',' 17',1,1,1,GETDATE(),GETDATE()) END END

SET IDENTITY_INSERT dbo.State OFF;  