USE [remproject]
GO

INSERT INTO [dbo].[AppManufacturers]
           ([Id]
           ,[Name]
           ,[Code]
           ,[Slug]
           ,[CoverPicture]
           ,[Visibility]
           ,[IsActive]
           ,[Country]
           ,[ExtraProperties]
           ,[ConcurrencyStamp]
           ,[CreationTime]
           ,[CreatorId])
     VALUES
           (newid()
		   ,N'Apple'
		   ,'M01'
		   ,'apple'
		   ,null
		   ,1
		   ,1
		   ,'US'
		   ,null
		   ,null
		   ,getdate()
		   ,null)
GO
USE [remproject]
GO

INSERT INTO [dbo].[AppManufacturers]
           ([Id]
           ,[Name]
           ,[Code]
           ,[Slug]
           ,[CoverPicture]
           ,[Visibility]
           ,[IsActive]
           ,[Country]
           ,[ExtraProperties]
           ,[ConcurrencyStamp]
           ,[CreationTime]
           ,[CreatorId])
     VALUES
           (newid()
		   ,N'Microsoft'
		   ,'M02'
		   ,'microsoft'
		   ,null
		   ,1
		   ,1
		   ,'US'
		   ,null
		   ,null
		   ,getdate()
		   ,null)
GO



