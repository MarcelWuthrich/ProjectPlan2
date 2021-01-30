USE [ProjectPlan]
GO

/****** Object: Table [dbo].[AdminResources] Script Date: 14.11.2020 14:31:52 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[AdminResources] (
    [ID_AdminResource] INT         NOT NULL,
    [AdminResource]    TEXT        NULL,
    [Enable]           BIT         NULL,
    [Symbol]           VARCHAR (5) NULL,
    [DisplayOrder]     INT         NULL
);


