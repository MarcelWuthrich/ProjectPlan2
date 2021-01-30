USE [ProjectPlan]
GO

/****** Object: Table [dbo].[Urgencies] Script Date: 14.11.2020 14:33:09 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Urgencies] (
    [ID_Urgency]   INT           NOT NULL,
    [Urgency]      VARCHAR (MAX) NULL,
    [Enable]       BIT           NULL,
    [DisplayOrder] INT           NULL
);


