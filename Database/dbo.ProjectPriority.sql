USE [ProjectPlan]
GO

/****** Object: Table [dbo].[ProjectPriority] Script Date: 14.11.2020 14:32:31 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[ProjectPriority] (
    [ID_Priority]  INT  NOT NULL,
    [Priority]     TEXT NULL,
    [Enable]       BIT  NULL,
    [DisplayOrder] INT  NULL
);


