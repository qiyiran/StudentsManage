USE [master]
GO
/****** Object:  Database [Test]    Script Date: 2018/6/26 14:43:45 ******/
CREATE DATABASE [Test]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'Test', FILENAME = N'c:\Program Files\Microsoft SQL Server\MSSQL11.SQLEXPRESS\MSSQL\DATA\Test.mdf' , SIZE = 5120KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'Test_log', FILENAME = N'c:\Program Files\Microsoft SQL Server\MSSQL11.SQLEXPRESS\MSSQL\DATA\Test_log.ldf' , SIZE = 2048KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [Test] SET COMPATIBILITY_LEVEL = 110
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [Test].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [Test] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [Test] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [Test] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [Test] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [Test] SET ARITHABORT OFF 
GO
ALTER DATABASE [Test] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [Test] SET AUTO_CREATE_STATISTICS ON 
GO
ALTER DATABASE [Test] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [Test] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [Test] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [Test] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [Test] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [Test] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [Test] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [Test] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [Test] SET  DISABLE_BROKER 
GO
ALTER DATABASE [Test] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [Test] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [Test] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [Test] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [Test] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [Test] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [Test] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [Test] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [Test] SET  MULTI_USER 
GO
ALTER DATABASE [Test] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [Test] SET DB_CHAINING OFF 
GO
ALTER DATABASE [Test] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [Test] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO
USE [Test]
GO
/****** Object:  Table [dbo].[Book]    Script Date: 2018/6/26 14:43:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Book](
	[BookID] [nvarchar](50) NOT NULL,
	[BookName] [nvarchar](50) NOT NULL,
	[BookAuthor] [nvarchar](50) NOT NULL,
	[BookPublishTime] [datetime] NULL,
	[BookPublisher] [nvarchar](50) NULL,
	[BookPrice] [float] NOT NULL,
	[BookCategory] [nchar](10) NULL,
	[BookDescription] [nvarchar](max) NULL,
	[BookResources] [bit] NOT NULL,
	[BookImage] [nvarchar](max) NULL,
 CONSTRAINT [PK_Book] PRIMARY KEY CLUSTERED 
(
	[BookID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Student]    Script Date: 2018/6/26 14:43:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Student](
	[StuID] [nvarchar](50) NOT NULL,
	[StuName] [nvarchar](50) NOT NULL,
	[StuClassID] [nvarchar](50) NOT NULL,
	[StuClassName] [nchar](10) NOT NULL,
	[StuClassTeacher] [nvarchar](50) NOT NULL,
	[StuSex] [bit] NOT NULL,
	[StuAge] [int] NOT NULL,
	[StuHeight] [float] NOT NULL,
	[StuWeight] [float] NOT NULL,
	[StuAddress] [nvarchar](max) NULL,
 CONSTRAINT [PK_Student] PRIMARY KEY CLUSTERED 
(
	[StuID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
INSERT [dbo].[Book] ([BookID], [BookName], [BookAuthor], [BookPublishTime], [BookPublisher], [BookPrice], [BookCategory], [BookDescription], [BookResources], [BookImage]) VALUES (N'1001', N'三体', N'刘慈欣', CAST(0x0000981700000000 AS DateTime), N'宇宙出版社', 45.5, N'科幻        ', N'好看的', 0, N'D:\Visual Studio 2013 Projects\study and practice\事件\Experiment\Experiment\bin\Debug\图书封面照片\三体.jpg')
INSERT [dbo].[Book] ([BookID], [BookName], [BookAuthor], [BookPublishTime], [BookPublisher], [BookPrice], [BookCategory], [BookDescription], [BookResources], [BookImage]) VALUES (N'1002', N'西游记', N'吴承恩', CAST(0xFFFF649D00000000 AS DateTime), N'宇宙出版社', 45.5, N'科幻        ', N'好看的', 0, N'D:\Visual Studio 2013 Projects\study and practice\事件\Experiment\Experiment\bin\Debug\图书封面照片\西游记.jpg')
INSERT [dbo].[Student] ([StuID], [StuName], [StuClassID], [StuClassName], [StuClassTeacher], [StuSex], [StuAge], [StuHeight], [StuWeight], [StuAddress]) VALUES (N'1001', N'王五', N'101', N'网络工程      ', N'李开复', 0, 22, 175, 65, N'')
INSERT [dbo].[Student] ([StuID], [StuName], [StuClassID], [StuClassName], [StuClassTeacher], [StuSex], [StuAge], [StuHeight], [StuWeight], [StuAddress]) VALUES (N'102', N'张三', N'101', N'网络工程      ', N'李开复', 0, 22, 175, 65, N'')
USE [master]
GO
ALTER DATABASE [Test] SET  READ_WRITE 
GO
