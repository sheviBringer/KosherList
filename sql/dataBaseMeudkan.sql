USE [master]
GO
/****** Object:  Database [KosherList]    Script Date: 06/12/2020 22:49:46 ******/
CREATE DATABASE [KosherList]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'KosherList', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL14.MSSQLSERVER\MSSQL\DATA\KosherList.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'KosherList_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL14.MSSQLSERVER\MSSQL\DATA\KosherList_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
GO
ALTER DATABASE [KosherList] SET COMPATIBILITY_LEVEL = 140
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [KosherList].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [KosherList] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [KosherList] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [KosherList] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [KosherList] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [KosherList] SET ARITHABORT OFF 
GO
ALTER DATABASE [KosherList] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [KosherList] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [KosherList] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [KosherList] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [KosherList] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [KosherList] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [KosherList] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [KosherList] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [KosherList] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [KosherList] SET  DISABLE_BROKER 
GO
ALTER DATABASE [KosherList] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [KosherList] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [KosherList] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [KosherList] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [KosherList] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [KosherList] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [KosherList] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [KosherList] SET RECOVERY FULL 
GO
ALTER DATABASE [KosherList] SET  MULTI_USER 
GO
ALTER DATABASE [KosherList] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [KosherList] SET DB_CHAINING OFF 
GO
ALTER DATABASE [KosherList] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [KosherList] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [KosherList] SET DELAYED_DURABILITY = DISABLED 
GO
EXEC sys.sp_db_vardecimal_storage_format N'KosherList', N'ON'
GO
ALTER DATABASE [KosherList] SET QUERY_STORE = OFF
GO
USE [KosherList]
GO
/****** Object:  Table [dbo].[Store_tbl]    Script Date: 06/12/2020 22:49:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Store_tbl](
	[codeStore] [int] IDENTITY(1,1) NOT NULL,
	[nameStore] [varchar](25) NULL,
	[addressStore] [varchar](25) NULL,
	[clasificationStore] [int] NULL,
	[activityTimeStart] [time](7) NULL,
	[activityTimeEnd] [time](7) NULL,
PRIMARY KEY CLUSTERED 
(
	[codeStore] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Updates_tbl]    Script Date: 06/12/2020 22:49:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Updates_tbl](
	[updatesId] [int] IDENTITY(1,1) NOT NULL,
	[codeStore] [int] NOT NULL,
	[codeWorker] [int] NOT NULL,
	[dateVisit] [date] NOT NULL,
	[begginingTime] [time](7) NULL,
	[exitingTime] [time](7) NULL,
	[remarks] [varchar](200) NULL,
	[result] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[updatesId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Users_tbl]    Script Date: 06/12/2020 22:49:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Users_tbl](
	[userId] [int] IDENTITY(1,1) NOT NULL,
	[userUserName] [varchar](25) NOT NULL,
	[userPassword] [varchar](15) NOT NULL,
	[userRole] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[userId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Worker_tbl]    Script Date: 06/12/2020 22:49:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Worker_tbl](
	[codeWorker] [int] IDENTITY(1,1) NOT NULL,
	[nameWorker] [varchar](25) NULL,
	[addressWorker] [varchar](25) NULL,
	[telWorker] [varchar](25) NULL,
	[experience] [int] NULL,
	[dateStart] [date] NULL,
	[email] [varchar](50) NULL,
	[mobility] [bit] NULL,
PRIMARY KEY CLUSTERED 
(
	[codeWorker] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Store_tbl] ON 

INSERT [dbo].[Store_tbl] ([codeStore], [nameStore], [addressStore], [clasificationStore], [activityTimeStart], [activityTimeEnd]) VALUES (1, N'עוף טוב', N'ירושלים', 1, CAST(N'08:00:00' AS Time), CAST(N'20:00:00' AS Time))
SET IDENTITY_INSERT [dbo].[Store_tbl] OFF
/****** Object:  Index [UQ__Updates___D88164B8A0A23EF1]    Script Date: 06/12/2020 22:49:46 ******/
ALTER TABLE [dbo].[Updates_tbl] ADD UNIQUE NONCLUSTERED 
(
	[codeStore] ASC,
	[codeWorker] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
ALTER TABLE [dbo].[Updates_tbl] ADD  DEFAULT (getdate()) FOR [dateVisit]
GO
ALTER TABLE [dbo].[Worker_tbl] ADD  DEFAULT (getdate()) FOR [dateStart]
GO
ALTER TABLE [dbo].[Updates_tbl]  WITH CHECK ADD FOREIGN KEY([codeStore])
REFERENCES [dbo].[Store_tbl] ([codeStore])
GO
ALTER TABLE [dbo].[Updates_tbl]  WITH CHECK ADD FOREIGN KEY([codeWorker])
REFERENCES [dbo].[Worker_tbl] ([codeWorker])
GO
USE [master]
GO
ALTER DATABASE [KosherList] SET  READ_WRITE 
GO
