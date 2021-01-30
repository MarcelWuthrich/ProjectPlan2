USE [ProjectPlan]
GO

/****** Object: Table [dbo].[Customers] Script Date: 14.11.2020 14:32:04 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Customers] (
    [ID_Customer]  INT  NOT NULL,
    [FirstName]    TEXT NULL,
    [LastName]     TEXT NULL,
    [Enable]       BIT  NULL,
    [DisplayOrder] INT  NULL
);


