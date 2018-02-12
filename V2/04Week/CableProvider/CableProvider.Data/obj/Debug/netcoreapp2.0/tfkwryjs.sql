IF OBJECT_ID(N'__EFMigrationsHistory') IS NULL
BEGIN
    CREATE TABLE [__EFMigrationsHistory] (
        [MigrationId] nvarchar(150) NOT NULL,
        [ProductVersion] nvarchar(32) NOT NULL,
        CONSTRAINT [PK___EFMigrationsHistory] PRIMARY KEY ([MigrationId])
    );
END;

GO

CREATE TABLE [Locations] (
    [Id] int NOT NULL IDENTITY,
    [Name] nvarchar(max) NULL,
    CONSTRAINT [PK_Locations] PRIMARY KEY ([Id])
);

GO

CREATE TABLE [Providers] (
    [Id] int NOT NULL IDENTITY,
    [InternetSpeed] int NOT NULL,
    [Name] nvarchar(max) NULL,
    [Price] int NOT NULL,
    CONSTRAINT [PK_Providers] PRIMARY KEY ([Id])
);

GO

INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
VALUES (N'20180212191638_init', N'2.0.1-rtm-125');

GO

