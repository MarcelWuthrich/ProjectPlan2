USE [ProjectPlan]
GO

/****** Object: Table [dbo].[Projects] Script Date: 14.11.2020 14:32:37 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Projects] (
    [ID_Project]                 INT           NOT NULL,
    [CE_ID_Status]               INT           NULL,
    [CE_ID_ProjectManager]       INT           NULL,
    [CE_ID_Priority]             INT           NULL,
    [CE_ID_Category]             INT           NULL,
    [CE_ID_Customer]             INT           NULL,
    [CE_ID_Urgency]              INT           NULL,
    [Title]                      VARCHAR (MAX) NULL,
    [Description]                VARCHAR (MAX) NULL,
    [BeginDate]                  DATE          NULL,
    [Deadline]                   DATE          NULL,
    [EstimatedResources]         INT           NULL,
    [EstimatedResourcesInfra]    INT           NULL,
    [EstimatedResourcesSAP]      INT           NULL,
    [EstimatedResourcesHelpdesk] INT           NULL,
    [EstimatedResourcesPlaning]  INT           NULL,
    [ImplementationRate]         INT           NULL,
    [EffectiveResources]         REAL          NULL,
    [HideInWebPage]              BIT           NULL,
    [Text_IT_Board]              VARCHAR (MAX) NULL
);


