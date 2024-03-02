USE [TasksDb]
GO

/****** Table [dbo].[RefreshToken] ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[RefreshToken](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[UserId] [int] NOT NULL,
	[TokenHash] [nvarchar](1000) NOT NULL,
	[TokenSalt] [nvarchar](50) NOT NULL,
	[TS] [smalldatetime] NOT NULL,
	[ExpiryDate] [smalldatetime] NOT NULL,
 CONSTRAINT [PK_RefreshToken] PRIMARY KEY CLUSTERED ([Id] ASC) WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO

/****** Table [dbo].[Task] ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Task](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[UserId] [int] NOT NULL,
	[Name] [nvarchar](100) NOT NULL,
	[IsCompleted] [bit] NOT NULL,
	[TS] [smalldatetime] NOT NULL,
 CONSTRAINT [PK_Task] PRIMARY KEY CLUSTERED ([Id] ASC) WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO

/****** Table [dbo].[User] ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[User](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Email] [nvarchar](50) NOT NULL,
	[Password] [nvarchar](255) NOT NULL,
	[PasswordSalt] [nvarchar](255) NOT NULL,
	[FirstName] [nvarchar](255) NOT NULL,
	[LastName] [nvarchar](255) NOT NULL,
	[TS] [smalldatetime] NOT NULL,
	[Active] [bit] NOT NULL,
 CONSTRAINT [PK_User] PRIMARY KEY CLUSTERED ([Id] ASC) WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO

/***** Populate Tables with initial Values *****/
/***** IDENTITY_INSERT - Insert Identity values on table. Can only be active once per DB *****/ 

/***** Populate Tasks *****/
SET IDENTITY_INSERT [dbo].[Task] ON 
GO

INSERT INTO [dbo].[Task] ([Id], [UserId], [Name], [IsCompleted], [TS]) VALUES (1, 1, N'Blog about Access Token and Refresh Token Authentication', 1, CAST(N'2022-01-14T00:00:00' AS SmallDateTime))
GO

INSERT INTO [dbo].[Task] ([Id], [UserId], [Name], [IsCompleted], [TS]) VALUES (3, 1, N'Vaccum the House', 0, CAST(N'2022-01-14T00:00:00' AS SmallDateTime))
GO

INSERT INTO [dbo].[Task] ([Id], [UserId], [Name], [IsCompleted], [TS]) VALUES (4, 1, N'Farmers Market Shopping', 0, CAST(N'2022-01-14T00:00:00' AS SmallDateTime))
GO

INSERT INTO [dbo].[Task] ([Id], [UserId], [Name], [IsCompleted], [TS]) VALUES (5, 1, N'Practice Juggling', 0, CAST(N'2022-01-15T00:00:00' AS SmallDateTime))
GO

SET IDENTITY_INSERT [dbo].[Task] OFF
GO

/***** Populate Users *****/
SET IDENTITY_INSERT [dbo].[User] ON 
GO

INSERT INTO [dbo].[User] ([Id], [Email], [Password], [PasswordSalt], [FirstName], [LastName], [TS], [Active]) VALUES (1, N'coding@codingsonata.com', N'miLgvYoSVrotOON6/lRp8ACrrbAxCPCmsrsy355x/DI=', N'L5hziA8V93SNGTlYdz+meS0B6DPzB3IwsRhDf1vO1GM=', N'Coding', N'Sonata', CAST(N'2024-03-02T00:00:00' AS SmallDateTime), 1)
GO

INSERT INTO [dbo].[User] ([Id], [Email], [Password], [PasswordSalt], [FirstName], [LastName], [TS], [Active]) VALUES (2, N'test@codingsonata.com', N'Fm7/SI9lYAFglzWXLD5oLz0cuq00MQmPkzDZ+nDZNmc=', N'kjgIDmRKgUbbWypCOOUHuxlQzZAszdEKw358ds4Xyc4=', N'test', N'postman', CAST(N'2024-03-02T14:23:00' AS SmallDateTime), 1)
GO

SET IDENTITY_INSERT [dbo].[User] OFF
GO

/***** Create and check Foreign keys *****/

ALTER TABLE [dbo].[RefreshToken] WITH CHECK 
	ADD CONSTRAINT [FK_RefreshToken_User] 
	FOREIGN KEY([UserId])
	REFERENCES [dbo].[User] ([Id])
GO

ALTER TABLE [dbo].[RefreshToken] 
	CHECK CONSTRAINT [FK_RefreshToken_User]
GO

ALTER TABLE [dbo].[Task]  WITH CHECK 
	ADD CONSTRAINT [FK_Task_User] 
	FOREIGN KEY([UserId])
	REFERENCES [dbo].[User] ([Id])
GO

ALTER TABLE [dbo].[Task] 
	CHECK CONSTRAINT [FK_Task_User]
GO
