USE [ProjectPlan]
GO

/****** Object: Table [dbo].[ProjectCategories] Script Date: 14.11.2020 14:32:21 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[ProjectCategories] (
    [ID_Category]  INT  NOT NULL,
    [Category]     TEXT NULL,
    [Enable]       BIT  NULL,
    [DisplayOrder] INT  NULL
);


