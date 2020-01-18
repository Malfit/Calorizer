USE [C:\USERS\SASHA\SOURCE\REPOS\КУРСАЧ_ПОПЫТКА1\КУРСАЧ_ПОПЫТКА1\DATABASE1.MDF]
GO

/****** Object: Table [dbo].[Dish] Script Date: 15.06.2019 14:35:53 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Dish] (
    [ID_dish]   INT          NOT NULL,
    [Name_dish] VARCHAR (50) NULL,
	[Count_dish] INT
);


