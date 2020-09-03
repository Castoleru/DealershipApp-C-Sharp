USE [PCDB]
GO
/****** Object:  Table [dbo].[Admin]    Script Date: 12.05.2020 21:54:30 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Admin](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[FirstName] [varchar](50) NOT NULL,
	[LastName] [varchar](50) NOT NULL,
	[IsAdmin] [bit] NULL,
	[Email] [varchar](50) NOT NULL,
	[Password] [varchar](50) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[Email] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Dealer]    Script Date: 12.05.2020 21:54:30 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Dealer](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[FirstName] [varchar](50) NOT NULL,
	[LastName] [varchar](50) NOT NULL,
	[IsAdmin] [bit] NULL,
	[SalesNumber] [int] NULL,
	[Email] [varchar](50) NOT NULL,
	[Password] [varchar](50) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[Email] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[user]    Script Date: 12.05.2020 21:54:30 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[user](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[Email] [varchar](50) NOT NULL,
	[Password] [varchar](50) NOT NULL,
	[IsAdmin] [bit] NULL,
PRIMARY KEY CLUSTERED 
(
	[Email] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Admin] ON 

INSERT [dbo].[Admin] ([id], [FirstName], [LastName], [IsAdmin]) VALUES (1, N'Dan', N'Miron', 1,'mail1@yahoo.com','papa')
SET IDENTITY_INSERT [dbo].[Admin] OFF
GO
SET IDENTITY_INSERT [dbo].[Dealer] ON 

INSERT [dbo].[Dealer] ([id], [FirstName], [LastName], [IsAdmin], [SalesNumber]) VALUES (1, N'Denis', N'Pop', 0, 123,'mail@yahoo.com','papa')
INSERT [dbo].[Dealer] ([id], [FirstName], [LastName], [IsAdmin], [SalesNumber]) VALUES (2, N'Dan', N'Pop', 0, 312,'mail@yahoo.com','papa')
SET IDENTITY_INSERT [dbo].[Dealer] OFF
GO
SET IDENTITY_INSERT [dbo].[user] ON 

INSERT [dbo].[user] ([id], [Email], [Password], [IsAdmin]) VALUES (1, N'danmiron98@yahoo.com', N'pass', 1)
INSERT [dbo].[user] ([id], [Email], [Password], [IsAdmin]) VALUES (2, N'denispop98@yahoo.com', N'pass', 0)
INSERT [dbo].[user] ([id], [Email], [Password], [IsAdmin]) VALUES (3, N'danpop98@yahoo.com', N'pass', 0)
SET IDENTITY_INSERT [dbo].[user] OFF
GO