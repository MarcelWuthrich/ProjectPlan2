USE [ProjectPlan]
GO

/****** Object: Table [dbo].[ProjectsMembers] Script Date: 14.11.2020 14:32:47 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[ProjectsMembers] (
    [ID_ProjectMember] INT  NOT NULL,
    [CE_ID_Task]       INT  NULL,
    [FirstName]        TEXT NULL,
    [LastName]         TEXT NULL,
    [Enable]           BIT  NULL,
    [IsDeleted]        BIT  NULL
);


