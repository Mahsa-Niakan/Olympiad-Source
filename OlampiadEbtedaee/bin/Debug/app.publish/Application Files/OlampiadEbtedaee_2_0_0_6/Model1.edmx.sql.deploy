
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, 2012 and Azure
-- --------------------------------------------------
-- Date Created: 03/31/2016 21:35:48
-- Generated from EDMX file: C:\Users\pink\Desktop\OlampiadEbtedaee - Copy\OlampiadEbtedaee\OlampiadEbtedaee\Model1.edmx
-- --------------------------------------------------

SET QUOTED_IDENTIFIER OFF;
GO
USE [OlampiadDB];
GO
IF SCHEMA_ID(N'dbo') IS NULL EXECUTE(N'CREATE SCHEMA [dbo]');
GO

-- --------------------------------------------------
-- Dropping existing FOREIGN KEY constraints
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[FK_UserExam]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[ExamSet] DROP CONSTRAINT [FK_UserExam];
GO
IF OBJECT_ID(N'[dbo].[FK_UserGroup]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[UserSet] DROP CONSTRAINT [FK_UserGroup];
GO

-- --------------------------------------------------
-- Dropping existing tables
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[UserSet]', 'U') IS NOT NULL
    DROP TABLE [dbo].[UserSet];
GO
IF OBJECT_ID(N'[dbo].[GroupSet]', 'U') IS NOT NULL
    DROP TABLE [dbo].[GroupSet];
GO
IF OBJECT_ID(N'[dbo].[ExamSet]', 'U') IS NOT NULL
    DROP TABLE [dbo].[ExamSet];
GO
IF OBJECT_ID(N'[dbo].[WinQuestionSet]', 'U') IS NOT NULL
    DROP TABLE [dbo].[WinQuestionSet];
GO
IF OBJECT_ID(N'[dbo].[WordQuestionSet]', 'U') IS NOT NULL
    DROP TABLE [dbo].[WordQuestionSet];
GO
IF OBJECT_ID(N'[dbo].[ExcelQuestionSet]', 'U') IS NOT NULL
    DROP TABLE [dbo].[ExcelQuestionSet];
GO
IF OBJECT_ID(N'[dbo].[PowerPointQuestionSet]', 'U') IS NOT NULL
    DROP TABLE [dbo].[PowerPointQuestionSet];
GO
IF OBJECT_ID(N'[dbo].[WindowsTheorySet]', 'U') IS NOT NULL
    DROP TABLE [dbo].[WindowsTheorySet];
GO
IF OBJECT_ID(N'[dbo].[WordTheorySet]', 'U') IS NOT NULL
    DROP TABLE [dbo].[WordTheorySet];
GO
IF OBJECT_ID(N'[dbo].[ExcelTheorySet]', 'U') IS NOT NULL
    DROP TABLE [dbo].[ExcelTheorySet];
GO
IF OBJECT_ID(N'[dbo].[PowerPointTheorySet]', 'U') IS NOT NULL
    DROP TABLE [dbo].[PowerPointTheorySet];
GO
IF OBJECT_ID(N'[dbo].[HardwareQuestionSet]', 'U') IS NOT NULL
    DROP TABLE [dbo].[HardwareQuestionSet];
GO

-- --------------------------------------------------
-- Creating all tables
-- --------------------------------------------------

-- Creating table 'UserSet'
CREATE TABLE [dbo].[UserSet] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Name] nvarchar(max)  NOT NULL,
    [LastName] nvarchar(max)  NOT NULL,
    [NCode] nvarchar(max)  NOT NULL,
    [Father] nvarchar(max)  NOT NULL,
    [SchoolName] nvarchar(max)  NOT NULL,
    [ClassName] nvarchar(max)  NOT NULL,
    [TotalTime] int  NOT NULL,
    [TotalMark] int  NOT NULL,
    [ExamDate] datetime  NOT NULL,
    [Gender] nvarchar(max)  NOT NULL,
    [GroupId] int  NOT NULL,
    [ScorePercentage] int  NOT NULL
);
GO

-- Creating table 'GroupSet'
CREATE TABLE [dbo].[GroupSet] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Name] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'ExamSet'
CREATE TABLE [dbo].[ExamSet] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [QId] int  NOT NULL,
    [QNumber] int  NOT NULL,
    [Mark] int  NOT NULL,
    [Time] int  NOT NULL,
    [UserId] int  NOT NULL
);
GO

-- Creating table 'WinQuestionSet'
CREATE TABLE [dbo].[WinQuestionSet] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Text] nvarchar(max)  NOT NULL,
    [Time] int  NOT NULL,
    [Voice] nvarchar(max)  NOT NULL,
    [Level] nvarchar(max)  NOT NULL,
    [Grade] int  NOT NULL,
    [Repeatitive] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'WordQuestionSet'
CREATE TABLE [dbo].[WordQuestionSet] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Text] nvarchar(max)  NOT NULL,
    [Time] int  NOT NULL,
    [Voice] nvarchar(max)  NOT NULL,
    [Level] nvarchar(max)  NOT NULL,
    [Grade] int  NOT NULL,
    [Repeatitive] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'ExcelQuestionSet'
CREATE TABLE [dbo].[ExcelQuestionSet] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Text] nvarchar(max)  NOT NULL,
    [Time] int  NOT NULL,
    [Voice] nvarchar(max)  NOT NULL,
    [Level] nvarchar(max)  NOT NULL,
    [Grade] int  NOT NULL,
    [Repeatitive] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'PowerPointQuestionSet'
CREATE TABLE [dbo].[PowerPointQuestionSet] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Text] nvarchar(max)  NOT NULL,
    [Time] int  NOT NULL,
    [Voice] nvarchar(max)  NOT NULL,
    [Level] nvarchar(max)  NOT NULL,
    [Grade] int  NOT NULL,
    [Repeatitive] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'WindowsTheorySet'
CREATE TABLE [dbo].[WindowsTheorySet] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Text] nvarchar(max)  NOT NULL,
    [ChoiceOne] nvarchar(max)  NOT NULL,
    [PicOne] nvarchar(max)  NOT NULL,
    [ChoiceTwo] nvarchar(max)  NOT NULL,
    [PicTwo] nvarchar(max)  NOT NULL,
    [ChoiceThree] nvarchar(max)  NOT NULL,
    [PicThree] nvarchar(max)  NOT NULL,
    [ChoiceFour] nvarchar(max)  NOT NULL,
    [PicFour] nvarchar(max)  NOT NULL,
    [Voice] nvarchar(max)  NOT NULL,
    [Level] nvarchar(max)  NOT NULL,
    [Grade] int  NOT NULL,
    [Correct] nvarchar(max)  NOT NULL,
    [Repeatitive] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'WordTheorySet'
CREATE TABLE [dbo].[WordTheorySet] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Text] nvarchar(max)  NOT NULL,
    [ChoiceOne] nvarchar(max)  NOT NULL,
    [PicOne] nvarchar(max)  NOT NULL,
    [ChoiceTwo] nvarchar(max)  NOT NULL,
    [PicTwo] nvarchar(max)  NOT NULL,
    [ChoiceThree] nvarchar(max)  NOT NULL,
    [PicThree] nvarchar(max)  NOT NULL,
    [ChoiceFour] nvarchar(max)  NOT NULL,
    [PicFour] nvarchar(max)  NOT NULL,
    [Voice] nvarchar(max)  NOT NULL,
    [Level] nvarchar(max)  NOT NULL,
    [Grade] int  NOT NULL,
    [Correct] nvarchar(max)  NOT NULL,
    [Repeatitive] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'ExcelTheorySet'
CREATE TABLE [dbo].[ExcelTheorySet] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Text] nvarchar(max)  NOT NULL,
    [ChoiceOne] nvarchar(max)  NOT NULL,
    [PicOne] nvarchar(max)  NOT NULL,
    [ChoiceTwo] nvarchar(max)  NOT NULL,
    [PicTwo] nvarchar(max)  NOT NULL,
    [ChoiceThree] nvarchar(max)  NOT NULL,
    [PicThree] nvarchar(max)  NOT NULL,
    [ChoiceFour] nvarchar(max)  NOT NULL,
    [PicFour] nvarchar(max)  NOT NULL,
    [Voice] nvarchar(max)  NOT NULL,
    [Level] nvarchar(max)  NOT NULL,
    [Grade] int  NOT NULL,
    [Correct] nvarchar(max)  NOT NULL,
    [Repeatitive] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'PowerPointTheorySet'
CREATE TABLE [dbo].[PowerPointTheorySet] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Text] nvarchar(max)  NOT NULL,
    [ChoiceOne] nvarchar(max)  NOT NULL,
    [PicOne] nvarchar(max)  NOT NULL,
    [ChoiceTwo] nvarchar(max)  NOT NULL,
    [PicTwo] nvarchar(max)  NOT NULL,
    [ChoiceThree] nvarchar(max)  NOT NULL,
    [PicThree] nvarchar(max)  NOT NULL,
    [ChoiceFour] nvarchar(max)  NOT NULL,
    [PicFour] nvarchar(max)  NOT NULL,
    [Voice] nvarchar(max)  NOT NULL,
    [Level] nvarchar(max)  NOT NULL,
    [Grade] int  NOT NULL,
    [Correct] nvarchar(max)  NOT NULL,
    [Repeatitive] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'HardwareQuestionSet'
CREATE TABLE [dbo].[HardwareQuestionSet] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Text] nvarchar(max)  NOT NULL,
    [ChoiceOne] nvarchar(max)  NOT NULL,
    [PicOne] nvarchar(max)  NOT NULL,
    [ChoiceTwo] nvarchar(max)  NOT NULL,
    [PicTwo] nvarchar(max)  NOT NULL,
    [ChoiceThree] nvarchar(max)  NOT NULL,
    [PicThree] nvarchar(max)  NOT NULL,
    [Voice] nvarchar(max)  NOT NULL,
    [Level] nvarchar(max)  NOT NULL,
    [Grade] int  NOT NULL,
    [ChoiceFour] nvarchar(max)  NOT NULL,
    [PicFour] nvarchar(max)  NOT NULL,
    [Correct] nvarchar(max)  NOT NULL,
    [Repeatitive] nvarchar(max)  NOT NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [Id] in table 'UserSet'
ALTER TABLE [dbo].[UserSet]
ADD CONSTRAINT [PK_UserSet]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'GroupSet'
ALTER TABLE [dbo].[GroupSet]
ADD CONSTRAINT [PK_GroupSet]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'ExamSet'
ALTER TABLE [dbo].[ExamSet]
ADD CONSTRAINT [PK_ExamSet]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'WinQuestionSet'
ALTER TABLE [dbo].[WinQuestionSet]
ADD CONSTRAINT [PK_WinQuestionSet]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'WordQuestionSet'
ALTER TABLE [dbo].[WordQuestionSet]
ADD CONSTRAINT [PK_WordQuestionSet]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'ExcelQuestionSet'
ALTER TABLE [dbo].[ExcelQuestionSet]
ADD CONSTRAINT [PK_ExcelQuestionSet]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'PowerPointQuestionSet'
ALTER TABLE [dbo].[PowerPointQuestionSet]
ADD CONSTRAINT [PK_PowerPointQuestionSet]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'WindowsTheorySet'
ALTER TABLE [dbo].[WindowsTheorySet]
ADD CONSTRAINT [PK_WindowsTheorySet]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'WordTheorySet'
ALTER TABLE [dbo].[WordTheorySet]
ADD CONSTRAINT [PK_WordTheorySet]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'ExcelTheorySet'
ALTER TABLE [dbo].[ExcelTheorySet]
ADD CONSTRAINT [PK_ExcelTheorySet]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'PowerPointTheorySet'
ALTER TABLE [dbo].[PowerPointTheorySet]
ADD CONSTRAINT [PK_PowerPointTheorySet]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'HardwareQuestionSet'
ALTER TABLE [dbo].[HardwareQuestionSet]
ADD CONSTRAINT [PK_HardwareQuestionSet]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- Creating foreign key on [UserId] in table 'ExamSet'
ALTER TABLE [dbo].[ExamSet]
ADD CONSTRAINT [FK_UserExam]
    FOREIGN KEY ([UserId])
    REFERENCES [dbo].[UserSet]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_UserExam'
CREATE INDEX [IX_FK_UserExam]
ON [dbo].[ExamSet]
    ([UserId]);
GO

-- Creating foreign key on [GroupId] in table 'UserSet'
ALTER TABLE [dbo].[UserSet]
ADD CONSTRAINT [FK_UserGroup]
    FOREIGN KEY ([GroupId])
    REFERENCES [dbo].[GroupSet]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_UserGroup'
CREATE INDEX [IX_FK_UserGroup]
ON [dbo].[UserSet]
    ([GroupId]);
GO

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------