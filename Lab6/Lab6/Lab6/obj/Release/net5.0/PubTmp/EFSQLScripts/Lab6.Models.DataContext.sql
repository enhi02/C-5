IF OBJECT_ID(N'[__EFMigrationsHistory]') IS NULL
BEGIN
    CREATE TABLE [__EFMigrationsHistory] (
        [MigrationId] nvarchar(150) NOT NULL,
        [ProductVersion] nvarchar(32) NOT NULL,
        CONSTRAINT [PK___EFMigrationsHistory] PRIMARY KEY ([MigrationId])
    );
END;
GO

BEGIN TRANSACTION;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20220616142300_lab6')
BEGIN
    CREATE TABLE [Reservations] (
        [Id] int NOT NULL IDENTITY,
        [Name] nvarchar(150) NULL,
        [StartLocation] nvarchar(150) NULL,
        [EndLocation] nvarchar(150) NULL,
        CONSTRAINT [PK_Reservations] PRIMARY KEY ([Id])
    );
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20220616142300_lab6')
BEGIN
    INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
    VALUES (N'20220616142300_lab6', N'5.0.17');
END;
GO

COMMIT;
GO

