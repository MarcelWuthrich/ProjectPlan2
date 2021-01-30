USE [ProjectPlan]
GO

/****** Object: Table [dbo].[Status] Script Date: 14.11.2020 14:32:58 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Status] (
    [ID_Status]    INT  NOT NULL,
    [Status]       TEXT NOT NULL,
    [Enable]       BIT  NULL,
    [DisplayOrder] INT  NULL
);


