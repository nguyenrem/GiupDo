BEGIN TRANSACTION;
GO

ALTER TABLE [AppProducts] ADD [CreategoryName] nvarchar(250) NULL;
GO

ALTER TABLE [AppProducts] ADD [CreategorySlug] nvarchar(250) NULL;
GO

INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
VALUES (N'20221212111933_AddCategoryFieldInProduct', N'6.0.5');
GO

COMMIT;
GO

