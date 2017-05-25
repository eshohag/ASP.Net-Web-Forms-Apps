USE [master]
GO
/****** Object:  Database [BookInfoDB]    Script Date: 17-Jun-16 4:09:58 PM ******/
CREATE DATABASE [BookInfoDB]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'BookInfoDB', FILENAME = N'c:\Program Files\Microsoft SQL Server\MSSQL11.MSSQLSERVER\MSSQL\DATA\BookInfoDB.mdf' , SIZE = 4096KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'BookInfoDB_log', FILENAME = N'c:\Program Files\Microsoft SQL Server\MSSQL11.MSSQLSERVER\MSSQL\DATA\BookInfoDB_log.ldf' , SIZE = 1024KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [BookInfoDB] SET COMPATIBILITY_LEVEL = 110
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [BookInfoDB].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [BookInfoDB] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [BookInfoDB] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [BookInfoDB] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [BookInfoDB] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [BookInfoDB] SET ARITHABORT OFF 
GO
ALTER DATABASE [BookInfoDB] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [BookInfoDB] SET AUTO_CREATE_STATISTICS ON 
GO
ALTER DATABASE [BookInfoDB] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [BookInfoDB] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [BookInfoDB] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [BookInfoDB] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [BookInfoDB] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [BookInfoDB] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [BookInfoDB] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [BookInfoDB] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [BookInfoDB] SET  DISABLE_BROKER 
GO
ALTER DATABASE [BookInfoDB] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [BookInfoDB] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [BookInfoDB] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [BookInfoDB] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [BookInfoDB] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [BookInfoDB] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [BookInfoDB] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [BookInfoDB] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [BookInfoDB] SET  MULTI_USER 
GO
ALTER DATABASE [BookInfoDB] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [BookInfoDB] SET DB_CHAINING OFF 
GO
ALTER DATABASE [BookInfoDB] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [BookInfoDB] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO
USE [BookInfoDB]
GO
/****** Object:  Table [dbo].[Book]    Script Date: 17-Jun-16 4:09:58 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Book](
	[Id] [int] IDENTITY(1000,1) NOT NULL,
	[Name] [varchar](50) NOT NULL,
	[ISBN] [varchar](13) NOT NULL,
	[Author] [varchar](100) NOT NULL,
 CONSTRAINT [PK_Book_1] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
SET IDENTITY_INSERT [dbo].[Book] ON 

INSERT [dbo].[Book] ([Id], [Name], [ISBN], [Author]) VALUES (1005, N'The Hobbit', N'1234567543123', N'J R R Tolkien')
INSERT [dbo].[Book] ([Id], [Name], [ISBN], [Author]) VALUES (1006, N'Harry Potter and the Goblet of Fire', N'1234567543124', N'JK Rowling')
INSERT [dbo].[Book] ([Id], [Name], [ISBN], [Author]) VALUES (1007, N'Pride and Prejudice', N'1234567543125', N'Jane Austen')
INSERT [dbo].[Book] ([Id], [Name], [ISBN], [Author]) VALUES (1008, N'Romeo and Juliet', N'1234567543126', N'William Shakespeare')
INSERT [dbo].[Book] ([Id], [Name], [ISBN], [Author]) VALUES (1019, N'Object Oriented Programing ', N'1232112345678', N'Balagurushami')
INSERT [dbo].[Book] ([Id], [Name], [ISBN], [Author]) VALUES (1020, N'C++', N'1232123432123', N'Schield')
INSERT [dbo].[Book] ([Id], [Name], [ISBN], [Author]) VALUES (1021, N'Intel-Microprocessor', N'1234567987654', N'Brey')
INSERT [dbo].[Book] ([Id], [Name], [ISBN], [Author]) VALUES (1022, N'Programing with Go Language', N'1234567543165', N'Google')
INSERT [dbo].[Book] ([Id], [Name], [ISBN], [Author]) VALUES (1023, N'Software Engineering', N'1234565432123', N'Somerville')
SET IDENTITY_INSERT [dbo].[Book] OFF
SET ANSI_PADDING ON

GO
/****** Object:  Index [IX_Book]    Script Date: 17-Jun-16 4:09:58 PM ******/
CREATE UNIQUE NONCLUSTERED INDEX [IX_Book] ON [dbo].[Book]
(
	[ISBN] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
USE [master]
GO
ALTER DATABASE [BookInfoDB] SET  READ_WRITE 
GO
