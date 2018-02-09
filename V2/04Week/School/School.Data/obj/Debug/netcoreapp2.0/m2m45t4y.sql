IF OBJECT_ID(N'__EFMigrationsHistory') IS NULL
BEGIN
    CREATE TABLE [__EFMigrationsHistory] (
        [MigrationId] nvarchar(150) NOT NULL,
        [ProductVersion] nvarchar(32) NOT NULL,
        CONSTRAINT [PK___EFMigrationsHistory] PRIMARY KEY ([MigrationId])
    );
END;

GO

CREATE TABLE [Sessions] (
    [Id] int NOT NULL IDENTITY,
    [Name] nvarchar(max) NULL,
    CONSTRAINT [PK_Sessions] PRIMARY KEY ([Id])
);

GO

CREATE TABLE [Students] (
    [Id] int NOT NULL IDENTITY,
    [LastName] nvarchar(max) NULL,
    [Name] nvarchar(max) NULL,
    [SessionId] int NOT NULL,
    CONSTRAINT [PK_Students] PRIMARY KEY ([Id])
);

GO

INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
VALUES (N'20180209015521_init', N'2.0.1-rtm-125');

GO

