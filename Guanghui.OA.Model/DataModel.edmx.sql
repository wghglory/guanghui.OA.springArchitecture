
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, 2012 and Azure
-- --------------------------------------------------
-- Date Created: 02/22/2016 09:12:06
-- Generated from EDMX file: D:\VS projects\Guanghui.OA.SpringArchitecture\Guanghui.OA.SpringArchitecture\Guanghui.OA.Model\DataModel.edmx
-- --------------------------------------------------

SET QUOTED_IDENTIFIER OFF;
GO
USE [GuanghuiOA];
GO
IF SCHEMA_ID(N'dbo') IS NULL EXECUTE(N'CREATE SCHEMA [dbo]');
GO

-- --------------------------------------------------
-- Dropping existing FOREIGN KEY constraints
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[FK_ActionInfoR_User_ActionInfo]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[R_User_ActionInfo] DROP CONSTRAINT [FK_ActionInfoR_User_ActionInfo];
GO
IF OBJECT_ID(N'[dbo].[FK_DepartmentActionInfo_ActionInfo]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[DepartmentActionInfo] DROP CONSTRAINT [FK_DepartmentActionInfo_ActionInfo];
GO
IF OBJECT_ID(N'[dbo].[FK_DepartmentActionInfo_Department]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[DepartmentActionInfo] DROP CONSTRAINT [FK_DepartmentActionInfo_Department];
GO
IF OBJECT_ID(N'[dbo].[FK_DepartmentUser_Department]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[DepartmentUser] DROP CONSTRAINT [FK_DepartmentUser_Department];
GO
IF OBJECT_ID(N'[dbo].[FK_DepartmentUser_User]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[DepartmentUser] DROP CONSTRAINT [FK_DepartmentUser_User];
GO
IF OBJECT_ID(N'[dbo].[FK_RoleActionInfo_ActionInfo]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[RoleActionInfo] DROP CONSTRAINT [FK_RoleActionInfo_ActionInfo];
GO
IF OBJECT_ID(N'[dbo].[FK_RoleActionInfo_Role]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[RoleActionInfo] DROP CONSTRAINT [FK_RoleActionInfo_Role];
GO
IF OBJECT_ID(N'[dbo].[FK_UserOrder]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Order] DROP CONSTRAINT [FK_UserOrder];
GO
IF OBJECT_ID(N'[dbo].[FK_UserR_User_ActionInfo]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[R_User_ActionInfo] DROP CONSTRAINT [FK_UserR_User_ActionInfo];
GO
IF OBJECT_ID(N'[dbo].[FK_UserRole_Role]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[UserRole] DROP CONSTRAINT [FK_UserRole_Role];
GO
IF OBJECT_ID(N'[dbo].[FK_UserRole_User]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[UserRole] DROP CONSTRAINT [FK_UserRole_User];
GO
IF OBJECT_ID(N'[dbo].[FK_WF_InstanceWF_Step]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[WF_Step] DROP CONSTRAINT [FK_WF_InstanceWF_Step];
GO
IF OBJECT_ID(N'[dbo].[FK_WF_TempWF_Instance]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[WF_Instance] DROP CONSTRAINT [FK_WF_TempWF_Instance];
GO

-- --------------------------------------------------
-- Dropping existing tables
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[ActionInfo]', 'U') IS NOT NULL
    DROP TABLE [dbo].[ActionInfo];
GO
IF OBJECT_ID(N'[dbo].[Book]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Book];
GO
IF OBJECT_ID(N'[dbo].[Department]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Department];
GO
IF OBJECT_ID(N'[dbo].[DepartmentActionInfo]', 'U') IS NOT NULL
    DROP TABLE [dbo].[DepartmentActionInfo];
GO
IF OBJECT_ID(N'[dbo].[DepartmentUser]', 'U') IS NOT NULL
    DROP TABLE [dbo].[DepartmentUser];
GO
IF OBJECT_ID(N'[dbo].[Order]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Order];
GO
IF OBJECT_ID(N'[dbo].[R_User_ActionInfo]', 'U') IS NOT NULL
    DROP TABLE [dbo].[R_User_ActionInfo];
GO
IF OBJECT_ID(N'[dbo].[Role]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Role];
GO
IF OBJECT_ID(N'[dbo].[RoleActionInfo]', 'U') IS NOT NULL
    DROP TABLE [dbo].[RoleActionInfo];
GO
IF OBJECT_ID(N'[dbo].[SearchLog]', 'U') IS NOT NULL
    DROP TABLE [dbo].[SearchLog];
GO
IF OBJECT_ID(N'[dbo].[SearchLogGroupBy]', 'U') IS NOT NULL
    DROP TABLE [dbo].[SearchLogGroupBy];
GO
IF OBJECT_ID(N'[dbo].[User]', 'U') IS NOT NULL
    DROP TABLE [dbo].[User];
GO
IF OBJECT_ID(N'[dbo].[UserExt]', 'U') IS NOT NULL
    DROP TABLE [dbo].[UserExt];
GO
IF OBJECT_ID(N'[dbo].[UserRole]', 'U') IS NOT NULL
    DROP TABLE [dbo].[UserRole];
GO
IF OBJECT_ID(N'[dbo].[WF_Instance]', 'U') IS NOT NULL
    DROP TABLE [dbo].[WF_Instance];
GO
IF OBJECT_ID(N'[dbo].[WF_Step]', 'U') IS NOT NULL
    DROP TABLE [dbo].[WF_Step];
GO
IF OBJECT_ID(N'[dbo].[WF_Temp]', 'U') IS NOT NULL
    DROP TABLE [dbo].[WF_Temp];
GO

-- --------------------------------------------------
-- Creating all tables
-- --------------------------------------------------

-- Creating table 'ActionInfo'
CREATE TABLE [dbo].[ActionInfo] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [ActionName] nvarchar(32)  NOT NULL,
    [Url] nvarchar(512)  NULL,
    [HttpMethod] nvarchar(32)  NOT NULL,
    [SubmitTime] datetime  NOT NULL,
    [ActionInfoType] smallint  NOT NULL,
    [Remark] nvarchar(128)  NULL,
    [DelFlag] smallint  NOT NULL,
    [IconUrl] nvarchar(256)  NULL,
    [ModifiedOn] datetime  NULL,
    [IconWidth] int  NULL,
    [IconHeight] int  NULL
);
GO

-- Creating table 'Book'
CREATE TABLE [dbo].[Book] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Title] nvarchar(200)  NOT NULL,
    [Author] nvarchar(200)  NOT NULL,
    [PublisherId] int  NOT NULL,
    [PublishDate] datetime  NOT NULL,
    [ISBN] nvarchar(50)  NOT NULL,
    [WordsCount] int  NOT NULL,
    [UnitPrice] decimal(19,4)  NOT NULL,
    [ContentDescription] nvarchar(max)  NULL,
    [AuthorDescription] nvarchar(max)  NULL,
    [EditorComment] nvarchar(max)  NULL,
    [TOC] nvarchar(max)  NULL,
    [CategoryId] int  NOT NULL,
    [Clicks] int  NOT NULL
);
GO

-- Creating table 'Department'
CREATE TABLE [dbo].[Department] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [DepName] nvarchar(32)  NOT NULL,
    [ParentId] int  NOT NULL,
    [TreePath] nvarchar(128)  NOT NULL,
    [Level] int  NOT NULL,
    [IsLeaf] bit  NOT NULL
);
GO

-- Creating table 'Order'
CREATE TABLE [dbo].[Order] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Content] nvarchar(128)  NOT NULL,
    [UserId] int  NOT NULL
);
GO

-- Creating table 'R_User_ActionInfo'
CREATE TABLE [dbo].[R_User_ActionInfo] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [UserId] int  NOT NULL,
    [ActionInfoId] int  NOT NULL,
    [IsPass] bit  NOT NULL
);
GO

-- Creating table 'Role'
CREATE TABLE [dbo].[Role] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [RoleName] nvarchar(32)  NOT NULL,
    [SubmitTime] datetime  NOT NULL,
    [ModifiedOn] datetime  NOT NULL,
    [DelFlag] smallint  NOT NULL,
    [Remark] nvarchar(max)  NULL,
    [Sort] nvarchar(max)  NULL
);
GO

-- Creating table 'SearchLog'
CREATE TABLE [dbo].[SearchLog] (
    [Id] uniqueidentifier  NOT NULL,
    [Keyword] nvarchar(250)  NULL,
    [SearchDateTime] datetime  NULL
);
GO

-- Creating table 'SearchLogGroupBy'
CREATE TABLE [dbo].[SearchLogGroupBy] (
    [Id] uniqueidentifier  NOT NULL,
    [Keyword] nvarchar(250)  NULL,
    [SearchCount] int  NULL
);
GO

-- Creating table 'User'
CREATE TABLE [dbo].[User] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [UserName] nvarchar(32)  NOT NULL,
    [Pwd] nvarchar(128)  NOT NULL,
    [Email] nvarchar(64)  NOT NULL,
    [RegistTime] datetime  NOT NULL,
    [Remark] nvarchar(max)  NULL,
    [DelFlag] smallint  NOT NULL,
    [ModifiedOn] datetime  NOT NULL,
    [Sort] nvarchar(max)  NULL
);
GO

-- Creating table 'WF_Instance'
CREATE TABLE [dbo].[WF_Instance] (
    [ID] int IDENTITY(1,1) NOT NULL,
    [WF_TempID] int  NOT NULL,
    [InstanceName] nvarchar(32)  NOT NULL,
    [WFApplicationId] uniqueidentifier  NOT NULL,
    [SubmitBy] int  NOT NULL,
    [SubmitTime] datetime  NOT NULL,
    [EndTime] datetime  NOT NULL,
    [Status] smallint  NOT NULL,
    [DelFlag] smallint  NOT NULL,
    [Remark] nvarchar(512)  NULL,
    [InstanceForm] nvarchar(max)  NULL
);
GO

-- Creating table 'WF_Step'
CREATE TABLE [dbo].[WF_Step] (
    [ID] int IDENTITY(1,1) NOT NULL,
    [WF_InstanceID] int  NOT NULL,
    [StepName] nvarchar(32)  NOT NULL,
    [ProcessBy] int  NOT NULL,
    [Status] smallint  NOT NULL,
    [IsStartStep] bit  NOT NULL,
    [IsEndStep] bit  NOT NULL,
    [Result] nvarchar(32)  NOT NULL,
    [Comment] nvarchar(512)  NULL,
    [SubmitTime] datetime  NOT NULL,
    [CheckTime] datetime  NOT NULL,
    [DelFlag] smallint  NOT NULL,
    [Remark] nvarchar(512)  NULL
);
GO

-- Creating table 'WF_Temp'
CREATE TABLE [dbo].[WF_Temp] (
    [ID] int IDENTITY(1,1) NOT NULL,
    [TempName] nvarchar(32)  NOT NULL,
    [DelFlag] smallint  NOT NULL,
    [Remark] nvarchar(512)  NULL,
    [Description] nvarchar(max)  NULL,
    [TempForm] nvarchar(max)  NULL,
    [WFActivity] nvarchar(max)  NULL
);
GO

-- Creating table 'UserExt'
CREATE TABLE [dbo].[UserExt] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Address] nvarchar(128)  NULL,
    [RealName] nvarchar(32)  NULL,
    [UserId] int  NOT NULL
);
GO

-- Creating table 'DepartmentActionInfo'
CREATE TABLE [dbo].[DepartmentActionInfo] (
    [ActionInfo_Id] int  NOT NULL,
    [Department_Id] int  NOT NULL
);
GO

-- Creating table 'DepartmentUser'
CREATE TABLE [dbo].[DepartmentUser] (
    [Department_Id] int  NOT NULL,
    [User_Id] int  NOT NULL
);
GO

-- Creating table 'RoleActionInfo'
CREATE TABLE [dbo].[RoleActionInfo] (
    [ActionInfo_Id] int  NOT NULL,
    [Role_Id] int  NOT NULL
);
GO

-- Creating table 'UserRole'
CREATE TABLE [dbo].[UserRole] (
    [Role_Id] int  NOT NULL,
    [User_Id] int  NOT NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [Id] in table 'ActionInfo'
ALTER TABLE [dbo].[ActionInfo]
ADD CONSTRAINT [PK_ActionInfo]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Book'
ALTER TABLE [dbo].[Book]
ADD CONSTRAINT [PK_Book]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Department'
ALTER TABLE [dbo].[Department]
ADD CONSTRAINT [PK_Department]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Order'
ALTER TABLE [dbo].[Order]
ADD CONSTRAINT [PK_Order]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'R_User_ActionInfo'
ALTER TABLE [dbo].[R_User_ActionInfo]
ADD CONSTRAINT [PK_R_User_ActionInfo]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Role'
ALTER TABLE [dbo].[Role]
ADD CONSTRAINT [PK_Role]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'SearchLog'
ALTER TABLE [dbo].[SearchLog]
ADD CONSTRAINT [PK_SearchLog]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'SearchLogGroupBy'
ALTER TABLE [dbo].[SearchLogGroupBy]
ADD CONSTRAINT [PK_SearchLogGroupBy]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'User'
ALTER TABLE [dbo].[User]
ADD CONSTRAINT [PK_User]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [ID] in table 'WF_Instance'
ALTER TABLE [dbo].[WF_Instance]
ADD CONSTRAINT [PK_WF_Instance]
    PRIMARY KEY CLUSTERED ([ID] ASC);
GO

-- Creating primary key on [ID] in table 'WF_Step'
ALTER TABLE [dbo].[WF_Step]
ADD CONSTRAINT [PK_WF_Step]
    PRIMARY KEY CLUSTERED ([ID] ASC);
GO

-- Creating primary key on [ID] in table 'WF_Temp'
ALTER TABLE [dbo].[WF_Temp]
ADD CONSTRAINT [PK_WF_Temp]
    PRIMARY KEY CLUSTERED ([ID] ASC);
GO

-- Creating primary key on [Id] in table 'UserExt'
ALTER TABLE [dbo].[UserExt]
ADD CONSTRAINT [PK_UserExt]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [ActionInfo_Id], [Department_Id] in table 'DepartmentActionInfo'
ALTER TABLE [dbo].[DepartmentActionInfo]
ADD CONSTRAINT [PK_DepartmentActionInfo]
    PRIMARY KEY CLUSTERED ([ActionInfo_Id], [Department_Id] ASC);
GO

-- Creating primary key on [Department_Id], [User_Id] in table 'DepartmentUser'
ALTER TABLE [dbo].[DepartmentUser]
ADD CONSTRAINT [PK_DepartmentUser]
    PRIMARY KEY CLUSTERED ([Department_Id], [User_Id] ASC);
GO

-- Creating primary key on [ActionInfo_Id], [Role_Id] in table 'RoleActionInfo'
ALTER TABLE [dbo].[RoleActionInfo]
ADD CONSTRAINT [PK_RoleActionInfo]
    PRIMARY KEY CLUSTERED ([ActionInfo_Id], [Role_Id] ASC);
GO

-- Creating primary key on [Role_Id], [User_Id] in table 'UserRole'
ALTER TABLE [dbo].[UserRole]
ADD CONSTRAINT [PK_UserRole]
    PRIMARY KEY CLUSTERED ([Role_Id], [User_Id] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- Creating foreign key on [ActionInfoId] in table 'R_User_ActionInfo'
ALTER TABLE [dbo].[R_User_ActionInfo]
ADD CONSTRAINT [FK_ActionInfoR_User_ActionInfo]
    FOREIGN KEY ([ActionInfoId])
    REFERENCES [dbo].[ActionInfo]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_ActionInfoR_User_ActionInfo'
CREATE INDEX [IX_FK_ActionInfoR_User_ActionInfo]
ON [dbo].[R_User_ActionInfo]
    ([ActionInfoId]);
GO

-- Creating foreign key on [UserId] in table 'Order'
ALTER TABLE [dbo].[Order]
ADD CONSTRAINT [FK_UserOrder]
    FOREIGN KEY ([UserId])
    REFERENCES [dbo].[User]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_UserOrder'
CREATE INDEX [IX_FK_UserOrder]
ON [dbo].[Order]
    ([UserId]);
GO

-- Creating foreign key on [UserId] in table 'R_User_ActionInfo'
ALTER TABLE [dbo].[R_User_ActionInfo]
ADD CONSTRAINT [FK_UserR_User_ActionInfo]
    FOREIGN KEY ([UserId])
    REFERENCES [dbo].[User]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_UserR_User_ActionInfo'
CREATE INDEX [IX_FK_UserR_User_ActionInfo]
ON [dbo].[R_User_ActionInfo]
    ([UserId]);
GO

-- Creating foreign key on [WF_InstanceID] in table 'WF_Step'
ALTER TABLE [dbo].[WF_Step]
ADD CONSTRAINT [FK_WF_InstanceWF_Step]
    FOREIGN KEY ([WF_InstanceID])
    REFERENCES [dbo].[WF_Instance]
        ([ID])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_WF_InstanceWF_Step'
CREATE INDEX [IX_FK_WF_InstanceWF_Step]
ON [dbo].[WF_Step]
    ([WF_InstanceID]);
GO

-- Creating foreign key on [WF_TempID] in table 'WF_Instance'
ALTER TABLE [dbo].[WF_Instance]
ADD CONSTRAINT [FK_WF_TempWF_Instance]
    FOREIGN KEY ([WF_TempID])
    REFERENCES [dbo].[WF_Temp]
        ([ID])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_WF_TempWF_Instance'
CREATE INDEX [IX_FK_WF_TempWF_Instance]
ON [dbo].[WF_Instance]
    ([WF_TempID]);
GO

-- Creating foreign key on [ActionInfo_Id] in table 'DepartmentActionInfo'
ALTER TABLE [dbo].[DepartmentActionInfo]
ADD CONSTRAINT [FK_DepartmentActionInfo_ActionInfo]
    FOREIGN KEY ([ActionInfo_Id])
    REFERENCES [dbo].[ActionInfo]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating foreign key on [Department_Id] in table 'DepartmentActionInfo'
ALTER TABLE [dbo].[DepartmentActionInfo]
ADD CONSTRAINT [FK_DepartmentActionInfo_Department]
    FOREIGN KEY ([Department_Id])
    REFERENCES [dbo].[Department]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_DepartmentActionInfo_Department'
CREATE INDEX [IX_FK_DepartmentActionInfo_Department]
ON [dbo].[DepartmentActionInfo]
    ([Department_Id]);
GO

-- Creating foreign key on [Department_Id] in table 'DepartmentUser'
ALTER TABLE [dbo].[DepartmentUser]
ADD CONSTRAINT [FK_DepartmentUser_Department]
    FOREIGN KEY ([Department_Id])
    REFERENCES [dbo].[Department]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating foreign key on [User_Id] in table 'DepartmentUser'
ALTER TABLE [dbo].[DepartmentUser]
ADD CONSTRAINT [FK_DepartmentUser_User]
    FOREIGN KEY ([User_Id])
    REFERENCES [dbo].[User]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_DepartmentUser_User'
CREATE INDEX [IX_FK_DepartmentUser_User]
ON [dbo].[DepartmentUser]
    ([User_Id]);
GO

-- Creating foreign key on [ActionInfo_Id] in table 'RoleActionInfo'
ALTER TABLE [dbo].[RoleActionInfo]
ADD CONSTRAINT [FK_RoleActionInfo_ActionInfo]
    FOREIGN KEY ([ActionInfo_Id])
    REFERENCES [dbo].[ActionInfo]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating foreign key on [Role_Id] in table 'RoleActionInfo'
ALTER TABLE [dbo].[RoleActionInfo]
ADD CONSTRAINT [FK_RoleActionInfo_Role]
    FOREIGN KEY ([Role_Id])
    REFERENCES [dbo].[Role]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_RoleActionInfo_Role'
CREATE INDEX [IX_FK_RoleActionInfo_Role]
ON [dbo].[RoleActionInfo]
    ([Role_Id]);
GO

-- Creating foreign key on [Role_Id] in table 'UserRole'
ALTER TABLE [dbo].[UserRole]
ADD CONSTRAINT [FK_UserRole_Role]
    FOREIGN KEY ([Role_Id])
    REFERENCES [dbo].[Role]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating foreign key on [User_Id] in table 'UserRole'
ALTER TABLE [dbo].[UserRole]
ADD CONSTRAINT [FK_UserRole_User]
    FOREIGN KEY ([User_Id])
    REFERENCES [dbo].[User]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_UserRole_User'
CREATE INDEX [IX_FK_UserRole_User]
ON [dbo].[UserRole]
    ([User_Id]);
GO

-- Creating foreign key on [UserId] in table 'UserExt'
ALTER TABLE [dbo].[UserExt]
ADD CONSTRAINT [FK_UserUserExt]
    FOREIGN KEY ([UserId])
    REFERENCES [dbo].[User]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_UserUserExt'
CREATE INDEX [IX_FK_UserUserExt]
ON [dbo].[UserExt]
    ([UserId]);
GO

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------