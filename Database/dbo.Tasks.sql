USE [ProjectPlan]
GO

/****** Object: Table [dbo].[Tasks] Script Date: 14.11.2020 14:33:03 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Tasks] (
    [ID_Task]      INT           NOT NULL,
    [Task]         VARCHAR (MAX) NOT NULL,
    [Enable]       BIT           NULL,
    [DisplayOrder] INT           NULL
);


