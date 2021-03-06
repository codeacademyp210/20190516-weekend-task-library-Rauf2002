USE [master]
GO
/****** Object:  Database [Library]    Script Date: 19.05.2019 14:51:42 ******/
CREATE DATABASE [Library]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'Library', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL14.MSSQLSERVER\MSSQL\DATA\Library.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'Library_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL14.MSSQLSERVER\MSSQL\DATA\Library_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
GO
ALTER DATABASE [Library] SET COMPATIBILITY_LEVEL = 140
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [Library].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [Library] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [Library] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [Library] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [Library] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [Library] SET ARITHABORT OFF 
GO
ALTER DATABASE [Library] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [Library] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [Library] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [Library] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [Library] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [Library] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [Library] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [Library] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [Library] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [Library] SET  ENABLE_BROKER 
GO
ALTER DATABASE [Library] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [Library] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [Library] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [Library] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [Library] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [Library] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [Library] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [Library] SET RECOVERY FULL 
GO
ALTER DATABASE [Library] SET  MULTI_USER 
GO
ALTER DATABASE [Library] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [Library] SET DB_CHAINING OFF 
GO
ALTER DATABASE [Library] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [Library] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [Library] SET DELAYED_DURABILITY = DISABLED 
GO
EXEC sys.sp_db_vardecimal_storage_format N'Library', N'ON'
GO
ALTER DATABASE [Library] SET QUERY_STORE = OFF
GO
USE [Library]
GO
/****** Object:  Table [dbo].[Authors]    Script Date: 19.05.2019 14:51:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Authors](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](50) NOT NULL,
	[Surname] [nvarchar](50) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[AuthorsBooks]    Script Date: 19.05.2019 14:51:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AuthorsBooks](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[AuthorId] [int] NOT NULL,
	[BookId] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Books]    Script Date: 19.05.2019 14:51:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Books](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](50) NOT NULL,
	[Price] [decimal](18, 0) NOT NULL,
	[CategoryId] [int] NOT NULL,
	[Quantity] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Categories]    Script Date: 19.05.2019 14:51:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Categories](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](100) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Clients]    Script Date: 19.05.2019 14:51:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Clients](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](100) NOT NULL,
	[Surname] [nvarchar](50) NOT NULL,
	[Phone] [nvarchar](50) NOT NULL,
	[Email] [nvarchar](50) NOT NULL,
	[Status] [bit] NULL,
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Orders]    Script Date: 19.05.2019 14:51:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Orders](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[ClientId] [int] NOT NULL,
	[BookId] [int] NOT NULL,
	[OrderDate] [datetime] NOT NULL,
	[ReturnDate] [datetime] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Authors] ON 

INSERT [dbo].[Authors] ([Id], [Name], [Surname]) VALUES (14, N'Mark', N'Twain')
INSERT [dbo].[Authors] ([Id], [Name], [Surname]) VALUES (15, N'Ozdemir', N'Asaf')
INSERT [dbo].[Authors] ([Id], [Name], [Surname]) VALUES (16, N'Gabriel', N'Garcia Marquez')
INSERT [dbo].[Authors] ([Id], [Name], [Surname]) VALUES (17, N'Arthur', N'Conan Doyle')
INSERT [dbo].[Authors] ([Id], [Name], [Surname]) VALUES (18, N'Dan', N'Brown')
INSERT [dbo].[Authors] ([Id], [Name], [Surname]) VALUES (19, N'Agatha', N'Christie')
INSERT [dbo].[Authors] ([Id], [Name], [Surname]) VALUES (20, N'Jo', N'Nesbo')
SET IDENTITY_INSERT [dbo].[Authors] OFF
SET IDENTITY_INSERT [dbo].[AuthorsBooks] ON 

INSERT [dbo].[AuthorsBooks] ([Id], [AuthorId], [BookId]) VALUES (1, 20, 8)
INSERT [dbo].[AuthorsBooks] ([Id], [AuthorId], [BookId]) VALUES (2, 15, 9)
INSERT [dbo].[AuthorsBooks] ([Id], [AuthorId], [BookId]) VALUES (3, 16, 10)
SET IDENTITY_INSERT [dbo].[AuthorsBooks] OFF
SET IDENTITY_INSERT [dbo].[Books] ON 

INSERT [dbo].[Books] ([Id], [Name], [Price], [CategoryId], [Quantity]) VALUES (1, N'Romeo and Juliet', CAST(16 AS Decimal(18, 0)), 3, 30)
INSERT [dbo].[Books] ([Id], [Name], [Price], [CategoryId], [Quantity]) VALUES (2, N'1984', CAST(18 AS Decimal(18, 0)), 2, 45)
INSERT [dbo].[Books] ([Id], [Name], [Price], [CategoryId], [Quantity]) VALUES (3, N'Da Vinchi Code', CAST(12 AS Decimal(18, 0)), 13, 10)
INSERT [dbo].[Books] ([Id], [Name], [Price], [CategoryId], [Quantity]) VALUES (4, N'Snowman', CAST(10 AS Decimal(18, 0)), 13, 15)
INSERT [dbo].[Books] ([Id], [Name], [Price], [CategoryId], [Quantity]) VALUES (5, N'asd', CAST(213 AS Decimal(18, 0)), 11, 123)
INSERT [dbo].[Books] ([Id], [Name], [Price], [CategoryId], [Quantity]) VALUES (6, N'Bassiz atli', CAST(12 AS Decimal(18, 0)), 11, 12)
INSERT [dbo].[Books] ([Id], [Name], [Price], [CategoryId], [Quantity]) VALUES (7, N'Boyuk Dordluk', CAST(12 AS Decimal(18, 0)), 12, 12)
INSERT [dbo].[Books] ([Id], [Name], [Price], [CategoryId], [Quantity]) VALUES (8, N'Nemesis', CAST(15 AS Decimal(18, 0)), 12, 20)
INSERT [dbo].[Books] ([Id], [Name], [Price], [CategoryId], [Quantity]) VALUES (9, N'asf', CAST(234 AS Decimal(18, 0)), 3, 324)
INSERT [dbo].[Books] ([Id], [Name], [Price], [CategoryId], [Quantity]) VALUES (10, N'ABC', CAST(100 AS Decimal(18, 0)), 2, 100)
SET IDENTITY_INSERT [dbo].[Books] OFF
SET IDENTITY_INSERT [dbo].[Categories] ON 

INSERT [dbo].[Categories] ([Id], [Name]) VALUES (2, N'Detective Story')
INSERT [dbo].[Categories] ([Id], [Name]) VALUES (3, N'Romance')
INSERT [dbo].[Categories] ([Id], [Name]) VALUES (11, N'Mystery')
INSERT [dbo].[Categories] ([Id], [Name]) VALUES (12, N'Detective Story')
INSERT [dbo].[Categories] ([Id], [Name]) VALUES (13, N'Mystery')
SET IDENTITY_INSERT [dbo].[Categories] OFF
SET IDENTITY_INSERT [dbo].[Clients] ON 

INSERT [dbo].[Clients] ([Id], [Name], [Surname], [Phone], [Email], [Status]) VALUES (1, N'Rauf', N'Allahverdiyev', N'+994508507575', N'raufsa@code.edu.az', NULL)
INSERT [dbo].[Clients] ([Id], [Name], [Surname], [Phone], [Email], [Status]) VALUES (2, N'Zaur', N'Allahverdiyev', N'+994504530100', N'zaursa@code.edu.az', NULL)
INSERT [dbo].[Clients] ([Id], [Name], [Surname], [Phone], [Email], [Status]) VALUES (3, N'Togrul', N'Rzayev', N'+994559491917', N'togrul@code.edu.az', NULL)
SET IDENTITY_INSERT [dbo].[Clients] OFF
SET IDENTITY_INSERT [dbo].[Orders] ON 

INSERT [dbo].[Orders] ([Id], [ClientId], [BookId], [OrderDate], [ReturnDate]) VALUES (1, 2, 2, CAST(N'2019-05-17T17:33:25.313' AS DateTime), CAST(N'2019-06-17T17:33:25.313' AS DateTime))
INSERT [dbo].[Orders] ([Id], [ClientId], [BookId], [OrderDate], [ReturnDate]) VALUES (2, 2, 1, CAST(N'2019-05-17T17:59:02.447' AS DateTime), CAST(N'2019-06-17T17:59:02.447' AS DateTime))
INSERT [dbo].[Orders] ([Id], [ClientId], [BookId], [OrderDate], [ReturnDate]) VALUES (3, 1, 2, CAST(N'2019-05-17T17:59:49.137' AS DateTime), CAST(N'2019-06-17T17:59:49.137' AS DateTime))
INSERT [dbo].[Orders] ([Id], [ClientId], [BookId], [OrderDate], [ReturnDate]) VALUES (4, 1, 1, CAST(N'2019-05-18T20:55:26.373' AS DateTime), CAST(N'2019-05-18T20:55:26.377' AS DateTime))
SET IDENTITY_INSERT [dbo].[Orders] OFF
ALTER TABLE [dbo].[AuthorsBooks]  WITH CHECK ADD FOREIGN KEY([AuthorId])
REFERENCES [dbo].[Authors] ([Id])
GO
ALTER TABLE [dbo].[AuthorsBooks]  WITH CHECK ADD FOREIGN KEY([BookId])
REFERENCES [dbo].[Books] ([Id])
GO
ALTER TABLE [dbo].[Books]  WITH CHECK ADD FOREIGN KEY([CategoryId])
REFERENCES [dbo].[Categories] ([Id])
GO
ALTER TABLE [dbo].[Orders]  WITH CHECK ADD FOREIGN KEY([BookId])
REFERENCES [dbo].[Books] ([Id])
GO
ALTER TABLE [dbo].[Orders]  WITH CHECK ADD FOREIGN KEY([ClientId])
REFERENCES [dbo].[Clients] ([Id])
GO
USE [master]
GO
ALTER DATABASE [Library] SET  READ_WRITE 
GO
