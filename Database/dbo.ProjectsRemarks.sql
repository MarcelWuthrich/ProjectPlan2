USE [ProjectPlan]
GO

/****** Object: Table [dbo].[ProjectsRemarks] Script Date: 14.11.2020 14:32:53 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[ProjectsRemarks] (
    [ID_Remark]      INT           NOT NULL,
    [CE_ID_Project]  INT           NULL,
    [CreationDate]   DATETIME      NULL,
    [LastModifyDate] DATETIME      NULL,
    [Remark]         VARCHAR (MAX) NULL
);


