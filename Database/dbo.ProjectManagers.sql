USE [ProjectPlan]
GO

/****** Object: Table [dbo].[ProjectManagers] Script Date: 14.11.2020 14:32:26 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[ProjectManagers] (
    [ID_ProjectManager] INT  NOT NULL,
    [FirstName]         TEXT NULL,
    [LastName]          TEXT NULL,
    [Enable]            BIT  NOT NULL
);


