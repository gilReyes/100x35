﻿
USE [master]
GO

/****** Object:  Database [100x35]    Script Date: 9/28/2015 7:38:13 PM ******/
CREATE DATABASE [100x35]
GO

ALTER DATABASE [100x35] SET COMPATIBILITY_LEVEL = 120
GO

IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [100x35].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO

ALTER DATABASE [100x35] SET ANSI_NULL_DEFAULT OFF
GO

ALTER DATABASE [100x35] SET ANSI_NULLS OFF
GO

ALTER DATABASE [100x35] SET ANSI_PADDING OFF
GO

ALTER DATABASE [100x35] SET ANSI_WARNINGS OFF
GO

ALTER DATABASE [100x35] SET ARITHABORT OFF
GO

ALTER DATABASE [100x35] SET AUTO_CLOSE OFF
GO

ALTER DATABASE [100x35] SET AUTO_SHRINK OFF
GO

ALTER DATABASE [100x35] SET AUTO_UPDATE_STATISTICS ON
GO

ALTER DATABASE [100x35] SET CURSOR_CLOSE_ON_COMMIT OFF
GO

ALTER DATABASE [100x35] SET CURSOR_DEFAULT  GLOBAL
GO

ALTER DATABASE [100x35] SET CONCAT_NULL_YIELDS_NULL OFF
GO

ALTER DATABASE [100x35] SET NUMERIC_ROUNDABORT OFF
GO

ALTER DATABASE [100x35] SET QUOTED_IDENTIFIER OFF
GO

ALTER DATABASE [100x35] SET RECURSIVE_TRIGGERS OFF
GO

ALTER DATABASE [100x35] SET  ENABLE_BROKER
GO

ALTER DATABASE [100x35] SET AUTO_UPDATE_STATISTICS_ASYNC OFF
GO

ALTER DATABASE [100x35] SET DATE_CORRELATION_OPTIMIZATION OFF
GO

ALTER DATABASE [100x35] SET TRUSTWORTHY OFF
GO

ALTER DATABASE [100x35] SET ALLOW_SNAPSHOT_ISOLATION ON
GO

ALTER DATABASE [100x35] SET PARAMETERIZATION SIMPLE
GO

ALTER DATABASE [100x35] SET READ_COMMITTED_SNAPSHOT ON
GO

ALTER DATABASE [100x35] SET HONOR_BROKER_PRIORITY OFF
GO

ALTER DATABASE [100x35] SET RECOVERY FULL
GO

ALTER DATABASE [100x35] SET  MULTI_USER
GO

ALTER DATABASE [100x35] SET PAGE_VERIFY CHECKSUM
GO

ALTER DATABASE [100x35] SET DB_CHAINING OFF
GO

USE [100x35]
GO

/****** Object:  Table [dbo].[Message]    Script Date: 9/28/2015 7:38:13 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

SET ANSI_PADDING ON
GO

SET ANSI_PADDING OFF
GO

/****** Object:  Table [dbo].[Testing]    Script Date: 9/28/2015 7:38:13 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

/****** Object:  Table [dbo].[Users]    Script Date: 9/28/2015 7:38:13 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

SET ANSI_PADDING ON
GO

SET ANSI_PADDING OFF
GO

/****** Object:  StoredProcedure [dbo].[Test_SP]    Script Date: 9/28/2015 7:38:13 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

USE [master]
GO

ALTER DATABASE [100x35] SET  READ_WRITE
GO