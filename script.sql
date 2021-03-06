USE [master]
GO
/****** Object:  Database [WorkDB]    Script Date: 10.04.2021 11:49:30 ******/
CREATE DATABASE [WorkDB]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'WorkDB', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\WorkDB.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'WorkDB_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\WorkDB_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [WorkDB] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [WorkDB].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [WorkDB] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [WorkDB] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [WorkDB] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [WorkDB] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [WorkDB] SET ARITHABORT OFF 
GO
ALTER DATABASE [WorkDB] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [WorkDB] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [WorkDB] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [WorkDB] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [WorkDB] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [WorkDB] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [WorkDB] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [WorkDB] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [WorkDB] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [WorkDB] SET  DISABLE_BROKER 
GO
ALTER DATABASE [WorkDB] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [WorkDB] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [WorkDB] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [WorkDB] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [WorkDB] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [WorkDB] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [WorkDB] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [WorkDB] SET RECOVERY FULL 
GO
ALTER DATABASE [WorkDB] SET  MULTI_USER 
GO
ALTER DATABASE [WorkDB] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [WorkDB] SET DB_CHAINING OFF 
GO
ALTER DATABASE [WorkDB] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [WorkDB] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [WorkDB] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [WorkDB] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
ALTER DATABASE [WorkDB] SET QUERY_STORE = OFF
GO
USE [WorkDB]
GO
/****** Object:  Table [dbo].[Comments]    Script Date: 10.04.2021 11:49:30 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Comments](
	[comment_id] [int] IDENTITY(1,1) NOT NULL,
	[news_id] [int] NULL,
	[text_comment] [nchar](255) NULL,
	[date_make] [date] NULL,
	[date_update] [date] NULL,
	[user_id] [int] NULL,
 CONSTRAINT [PK_Comments] PRIMARY KEY CLUSTERED 
(
	[comment_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Kategories]    Script Date: 10.04.2021 11:49:30 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Kategories](
	[kategory_id] [int] IDENTITY(1,1) NOT NULL,
	[name_kategory] [nchar](25) NULL,
 CONSTRAINT [PK_Kategories] PRIMARY KEY CLUSTERED 
(
	[kategory_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[News]    Script Date: 10.04.2021 11:49:30 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[News](
	[news_id] [int] IDENTITY(1,1) NOT NULL,
	[header_char] [nchar](50) NOT NULL,
	[description] [nchar](100) NULL,
	[full_text] [nchar](250) NULL,
	[date_make] [date] NULL,
	[date_update] [date] NULL,
	[kategory_id] [int] NOT NULL,
 CONSTRAINT [PK_News_1] PRIMARY KEY CLUSTERED 
(
	[news_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Users]    Script Date: 10.04.2021 11:49:30 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Users](
	[user_id] [int] IDENTITY(1,1) NOT NULL,
	[login] [nchar](25) NULL,
	[email] [nchar](25) NULL,
	[password] [nchar](25) NULL,
 CONSTRAINT [PK_users] PRIMARY KEY CLUSTERED 
(
	[user_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Comments] ON 

INSERT [dbo].[Comments] ([comment_id], [news_id], [text_comment], [date_make], [date_update], [user_id]) VALUES (18, 2, N'УРА!                                                                                                                                                                                                                                                           ', CAST(N'2020-02-02' AS Date), CAST(N'2020-02-03' AS Date), 1)
INSERT [dbo].[Comments] ([comment_id], [news_id], [text_comment], [date_make], [date_update], [user_id]) VALUES (19, 3, N'ВОТ БЛИН(!                                                                                                                                                                                                                                                     ', CAST(N'2020-02-04' AS Date), CAST(N'2020-02-06' AS Date), 1)
SET IDENTITY_INSERT [dbo].[Comments] OFF
GO
SET IDENTITY_INSERT [dbo].[Kategories] ON 

INSERT [dbo].[Kategories] ([kategory_id], [name_kategory]) VALUES (1, N'Спорт                    ')
INSERT [dbo].[Kategories] ([kategory_id], [name_kategory]) VALUES (2, N'Наука                    ')
INSERT [dbo].[Kategories] ([kategory_id], [name_kategory]) VALUES (3, N'Аниме                    ')
SET IDENTITY_INSERT [dbo].[Kategories] OFF
GO
SET IDENTITY_INSERT [dbo].[News] ON 

INSERT [dbo].[News] ([news_id], [header_char], [description], [full_text], [date_make], [date_update], [kategory_id]) VALUES (2, N'Запрет Аниме                                      ', N'Запрещают аниме навсегда                                                                            ', N'вообще навсегда                                                                                                                                                                                                                                           ', CAST(N'2021-04-10' AS Date), CAST(N'2021-04-11' AS Date), 2)
INSERT [dbo].[News] ([news_id], [header_char], [description], [full_text], [date_make], [date_update], [kategory_id]) VALUES (3, N'Разрешаем Аниме                                   ', N'Аниме вернули, ура                                                                                  ', N'всё нормально, вернули                                                                                                                                                                                                                                    ', CAST(N'2020-04-10' AS Date), CAST(N'2020-04-10' AS Date), 2)
SET IDENTITY_INSERT [dbo].[News] OFF
GO
SET IDENTITY_INSERT [dbo].[Users] ON 

INSERT [dbo].[Users] ([user_id], [login], [email], [password]) VALUES (1, N'Baba                     ', N'baba@mail.com            ', N'123123                   ')
INSERT [dbo].[Users] ([user_id], [login], [email], [password]) VALUES (2, N'Admin                    ', N'e@e.com                  ', N'123123                   ')
SET IDENTITY_INSERT [dbo].[Users] OFF
GO
ALTER TABLE [dbo].[Comments]  WITH CHECK ADD  CONSTRAINT [FK_Comments_News] FOREIGN KEY([news_id])
REFERENCES [dbo].[News] ([news_id])
GO
ALTER TABLE [dbo].[Comments] CHECK CONSTRAINT [FK_Comments_News]
GO
ALTER TABLE [dbo].[Comments]  WITH CHECK ADD  CONSTRAINT [FK_Comments_Users] FOREIGN KEY([user_id])
REFERENCES [dbo].[Users] ([user_id])
GO
ALTER TABLE [dbo].[Comments] CHECK CONSTRAINT [FK_Comments_Users]
GO
ALTER TABLE [dbo].[News]  WITH CHECK ADD  CONSTRAINT [FK_News_Kategories] FOREIGN KEY([kategory_id])
REFERENCES [dbo].[Kategories] ([kategory_id])
GO
ALTER TABLE [dbo].[News] CHECK CONSTRAINT [FK_News_Kategories]
GO
USE [master]
GO
ALTER DATABASE [WorkDB] SET  READ_WRITE 
GO
