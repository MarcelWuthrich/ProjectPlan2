USE [ProjectPlan]
GO

/****** Object: Table [dbo].[ExecutedResources] Script Date: 14.11.2020 14:32:10 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[ExecutedResources] (
    [ID_Resource]         INT      NOT NULL,
    [CE_ID_ProjectMember] INT      NULL,
    [CE_ID_Project]       INT      NULL,
    [CE_ID_AdminResource] INT      NULL,
    [PlanDate]            DATE     NULL,
    [HalfDay]             INT      NULL,
    [Timestamp]           DATETIME NULL
);


