USE [master]
GO
/****** Object:  Database [feedbackDB]    Script Date: 16-4-2023 15:26:20 ******/
CREATE DATABASE [feedbackDB]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'feedbackDB', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\feedbackDB.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'feedbackDB_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\feedbackDB_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [feedbackDB] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [feedbackDB].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [feedbackDB] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [feedbackDB] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [feedbackDB] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [feedbackDB] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [feedbackDB] SET ARITHABORT OFF 
GO
ALTER DATABASE [feedbackDB] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [feedbackDB] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [feedbackDB] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [feedbackDB] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [feedbackDB] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [feedbackDB] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [feedbackDB] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [feedbackDB] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [feedbackDB] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [feedbackDB] SET  DISABLE_BROKER 
GO
ALTER DATABASE [feedbackDB] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [feedbackDB] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [feedbackDB] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [feedbackDB] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [feedbackDB] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [feedbackDB] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [feedbackDB] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [feedbackDB] SET RECOVERY FULL 
GO
ALTER DATABASE [feedbackDB] SET  MULTI_USER 
GO
ALTER DATABASE [feedbackDB] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [feedbackDB] SET DB_CHAINING OFF 
GO
ALTER DATABASE [feedbackDB] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [feedbackDB] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [feedbackDB] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [feedbackDB] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
EXEC sys.sp_db_vardecimal_storage_format N'feedbackDB', N'ON'
GO
ALTER DATABASE [feedbackDB] SET QUERY_STORE = OFF
GO
USE [feedbackDB]
GO
/****** Object:  Table [dbo].[Feedback]    Script Date: 16-4-2023 15:26:21 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Feedback](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[teacherId] [int] NULL,
	[studentId] [int] NULL,
	[date] [date] NULL,
	[course] [varchar](50) NULL,
	[feedback] [varchar](max) NULL,
	[type] [varchar](50) NULL,
	[goalID] [int] NULL,
 CONSTRAINT [PK_Feedback] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Goal]    Script Date: 16-4-2023 15:26:21 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Goal](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[studentID] [int] NULL,
	[priority] [varchar](50) NULL,
	[goal] [varchar](max) NULL,
	[time] [float] NULL,
	[status] [varchar](50) NULL,
 CONSTRAINT [PK_Goal] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Student]    Script Date: 16-4-2023 15:26:21 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Student](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[firstName] [varchar](50) NULL,
	[lastName] [varchar](50) NULL,
	[email] [varchar](50) NULL,
	[gender] [varchar](50) NULL,
	[password] [varchar](50) NULL,
 CONSTRAINT [PK_Student] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[SubGoal]    Script Date: 16-4-2023 15:26:21 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[SubGoal](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[goalId] [int] NULL,
	[subGoal] [varchar](50) NULL,
	[status] [varchar](50) NULL,
 CONSTRAINT [PK_subGoal] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Teacher]    Script Date: 16-4-2023 15:26:21 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Teacher](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[firstName] [varchar](50) NULL,
	[lastName] [varchar](50) NULL,
	[email] [varchar](50) NULL,
	[phone] [int] NULL,
	[password] [varchar](50) NULL,
 CONSTRAINT [PK_Teacher] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Feedback] ON 

INSERT [dbo].[Feedback] ([id], [teacherId], [studentId], [date], [course], [feedback], [type], [goalID]) VALUES (12, 1, 1, CAST(N'2023-04-16' AS Date), N'', N'Je kunt om c# beter te leren, kijken bij andere projecten en aan de hand daarvan zelf proberen iets te maken. ', N'doel', 4)
INSERT [dbo].[Feedback] ([id], [teacherId], [studentId], [date], [course], [feedback], [type], [goalID]) VALUES (13, 1, 1, CAST(N'2023-04-16' AS Date), N'', N'Je leert alleen maar door te doen niet door over te nemen.', N'doel', 4)
INSERT [dbo].[Feedback] ([id], [teacherId], [studentId], [date], [course], [feedback], [type], [goalID]) VALUES (14, 1, 1, CAST(N'2023-04-16' AS Date), N'c#', N'Je hebt dit blok laten zien dat je veel vooruit bent gegaan met c# beheersing.', N'SLB', 0)
SET IDENTITY_INSERT [dbo].[Feedback] OFF
GO
SET IDENTITY_INSERT [dbo].[Goal] ON 

INSERT [dbo].[Goal] ([id], [studentID], [priority], [goal], [time], [status]) VALUES (1, 1, N'high', N'beter leren samenwerken', 3, N'afgerond')
INSERT [dbo].[Goal] ([id], [studentID], [priority], [goal], [time], [status]) VALUES (2, 1, N'Laag', N'beter plannen', 3, N'afgerond')
INSERT [dbo].[Goal] ([id], [studentID], [priority], [goal], [time], [status]) VALUES (4, 1, N'Gemiddeld', N'nieuwe c# kennis opdoen', 0.5, N'te doen')
INSERT [dbo].[Goal] ([id], [studentID], [priority], [goal], [time], [status]) VALUES (7, 6, N'Gemiddeld', N'nieuwe pagina''s maken voor feedback systeem', 5, N'bezig')
SET IDENTITY_INSERT [dbo].[Goal] OFF
GO
SET IDENTITY_INSERT [dbo].[Student] ON 

INSERT [dbo].[Student] ([id], [firstName], [lastName], [email], [gender], [password]) VALUES (1, N'Xavier', N'Prickaerts', N'x@prickaerts', N'male', N'wachtwoord')
INSERT [dbo].[Student] ([id], [firstName], [lastName], [email], [gender], [password]) VALUES (2, N'Renad', N'sh', N'rSh', N'male', N'rSh')
INSERT [dbo].[Student] ([id], [firstName], [lastName], [email], [gender], [password]) VALUES (3, N'Aimane', N'bouga', N'a@gmail', N'male', N'aBouga')
INSERT [dbo].[Student] ([id], [firstName], [lastName], [email], [gender], [password]) VALUES (4, N'jay', N'rein', N'j@solutions', N'male', N'jRein')
INSERT [dbo].[Student] ([id], [firstName], [lastName], [email], [gender], [password]) VALUES (5, N'gabriel', N'lunesu', N'g@lunesu', N'male', N'gLunesu')
INSERT [dbo].[Student] ([id], [firstName], [lastName], [email], [gender], [password]) VALUES (6, N'noa', N'heuts', N'n@heuts', N'male', N'noaHeuts')
SET IDENTITY_INSERT [dbo].[Student] OFF
GO
SET IDENTITY_INSERT [dbo].[SubGoal] ON 

INSERT [dbo].[SubGoal] ([id], [goalId], [subGoal], [status]) VALUES (1, 1, N'meer communiceren met docenten', N'afgerond')
INSERT [dbo].[SubGoal] ([id], [goalId], [subGoal], [status]) VALUES (16, 2, N'planning duidelijker maken voor anderen', N'bezig')
INSERT [dbo].[SubGoal] ([id], [goalId], [subGoal], [status]) VALUES (17, 4, N'studeren', N'bezig')
INSERT [dbo].[SubGoal] ([id], [goalId], [subGoal], [status]) VALUES (18, 4, N'w3 schools doorzoeken voor informatie over c#', N'bezig')
SET IDENTITY_INSERT [dbo].[SubGoal] OFF
GO
SET IDENTITY_INSERT [dbo].[Teacher] ON 

INSERT [dbo].[Teacher] ([id], [firstName], [lastName], [email], [phone], [password]) VALUES (1, N'rick', N'warnecke', N'testmail@kpn', 612345643, N'wachtwoord')
INSERT [dbo].[Teacher] ([id], [firstName], [lastName], [email], [phone], [password]) VALUES (2, N'miel', N'noelanders', N'testmail@gmail', 61245653, N'wachtwoord2')
SET IDENTITY_INSERT [dbo].[Teacher] OFF
GO
ALTER TABLE [dbo].[Feedback]  WITH CHECK ADD  CONSTRAINT [FK_Feedback_Student] FOREIGN KEY([studentId])
REFERENCES [dbo].[Student] ([id])
GO
ALTER TABLE [dbo].[Feedback] CHECK CONSTRAINT [FK_Feedback_Student]
GO
ALTER TABLE [dbo].[Feedback]  WITH CHECK ADD  CONSTRAINT [FK_Feedback_Teacher] FOREIGN KEY([teacherId])
REFERENCES [dbo].[Teacher] ([id])
GO
ALTER TABLE [dbo].[Feedback] CHECK CONSTRAINT [FK_Feedback_Teacher]
GO
ALTER TABLE [dbo].[Goal]  WITH CHECK ADD  CONSTRAINT [FK_Goal_Student] FOREIGN KEY([studentID])
REFERENCES [dbo].[Student] ([id])
GO
ALTER TABLE [dbo].[Goal] CHECK CONSTRAINT [FK_Goal_Student]
GO
ALTER TABLE [dbo].[SubGoal]  WITH CHECK ADD  CONSTRAINT [FK_SubGoal_Goal] FOREIGN KEY([goalId])
REFERENCES [dbo].[Goal] ([id])
GO
ALTER TABLE [dbo].[SubGoal] CHECK CONSTRAINT [FK_SubGoal_Goal]
GO
USE [master]
GO
ALTER DATABASE [feedbackDB] SET  READ_WRITE 
GO
