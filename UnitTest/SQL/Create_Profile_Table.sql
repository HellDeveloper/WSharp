USE [UnitTest]
GO

/****** Object:  Table [dbo].[Profile]    Script Date: 04/17/2015 22:32:09 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Profile]') AND type in (N'U'))
DROP TABLE [dbo].[Profile]
GO

USE [UnitTest]
GO

/****** Object:  Table [dbo].[Profile]    Script Date: 04/17/2015 22:32:09 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Profile](
	[ID] [nvarchar](25) NOT NULL,
	[CardNumber] [nvarchar](25) NULL,
	[Name] [nvarchar](50) NULL,
	[Sex] [bit] NULL,
	[Nation] [nvarchar](50) NULL,
	[BornDate] [date] NULL,
	[Address] [nvarchar](255) NULL,
 CONSTRAINT [PK_Profile] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [Profile]

GO


