USE [ProjectPlan]
GO

/****** Object: Table [dbo].[ProjectsHistory] Script Date: 14.11.2020 14:32:42 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[ProjectsHistory] (
    [ID_History]    INT      NOT NULL,
    [CE_ID_Project] INT      NULL,
    [ModifyBy]      TEXT     NULL,
    [ModifyDate]    DATETIME NULL,
    [Modification]  TEXT     NULL
);


