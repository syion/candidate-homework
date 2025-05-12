-- Database Schema for Owners and Pets

-- Drop existing tables if they exist (for clean setup)
IF OBJECT_ID('dbo.Pets', 'U') IS NOT NULL
    DROP TABLE dbo.Pets;
IF OBJECT_ID('dbo.Owners', 'U') IS NOT NULL
    DROP TABLE dbo.Owners;

-- Create Owners table
CREATE TABLE dbo.Owners (
    Id INT IDENTITY(1,1) PRIMARY KEY,
    Email NVARCHAR(100) NOT NULL,
    FirstName NVARCHAR(50) NOT NULL,
    LastName NVARCHAR(50) NOT NULL,
    ApiKey UNIQUEIDENTIFIER NOT NULL DEFAULT NEWID(),
    CreatedAt DATETIME2 NOT NULL DEFAULT GETUTCDATE()
);

-- Create unique index on Email to enforce uniqueness
CREATE UNIQUE INDEX IX_Owners_Email ON dbo.Owners(Email);

-- Create Pets table
CREATE TABLE dbo.Pets (
    Id INT IDENTITY(1,1) PRIMARY KEY,
    Name NVARCHAR(50) NOT NULL,
    OwnerId INT NOT NULL,
    Species NVARCHAR(50) NULL,
    Description NVARCHAR(200) NULL,
    Color NVARCHAR(20) NULL,
    Age INT NULL,
    CreatedAt DATETIME2 NOT NULL DEFAULT GETUTCDATE(),
    CONSTRAINT FK_Pets_Owners FOREIGN KEY (OwnerId) REFERENCES dbo.Owners(Id) ON DELETE CASCADE
);

-- Create unique index on Name + OwnerId to enforce uniqueness
CREATE UNIQUE INDEX IX_Pets_Name_OwnerId ON dbo.Pets(Name, OwnerId);
