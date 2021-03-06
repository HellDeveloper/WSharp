﻿USE [master]
GO

/****** Object:  Database [UnitTest]    Script Date: 03/22/2015 14:27:14 ******/
CREATE DATABASE [UnitTest] ON  PRIMARY 
( NAME = N'UnitTest', FILENAME = N'E:\workspace\SqlServer\UnitTest.mdf' , SIZE = 3072KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'UnitTest_log', FILENAME = N'E:\workspace\SqlServer\UnitTest_log.ldf' , SIZE = 1024KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO

ALTER DATABASE [UnitTest] SET COMPATIBILITY_LEVEL = 100
GO

IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [UnitTest].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO

ALTER DATABASE [UnitTest] SET ANSI_NULL_DEFAULT OFF 
GO

ALTER DATABASE [UnitTest] SET ANSI_NULLS OFF 
GO

ALTER DATABASE [UnitTest] SET ANSI_PADDING OFF 
GO

ALTER DATABASE [UnitTest] SET ANSI_WARNINGS OFF 
GO

ALTER DATABASE [UnitTest] SET ARITHABORT OFF 
GO

ALTER DATABASE [UnitTest] SET AUTO_CLOSE OFF 
GO

ALTER DATABASE [UnitTest] SET AUTO_CREATE_STATISTICS ON 
GO

ALTER DATABASE [UnitTest] SET AUTO_SHRINK OFF 
GO

ALTER DATABASE [UnitTest] SET AUTO_UPDATE_STATISTICS ON 
GO

ALTER DATABASE [UnitTest] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO

ALTER DATABASE [UnitTest] SET CURSOR_DEFAULT  GLOBAL 
GO

ALTER DATABASE [UnitTest] SET CONCAT_NULL_YIELDS_NULL OFF 
GO

ALTER DATABASE [UnitTest] SET NUMERIC_ROUNDABORT OFF 
GO

ALTER DATABASE [UnitTest] SET QUOTED_IDENTIFIER OFF 
GO

ALTER DATABASE [UnitTest] SET RECURSIVE_TRIGGERS OFF 
GO

ALTER DATABASE [UnitTest] SET  DISABLE_BROKER 
GO

ALTER DATABASE [UnitTest] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO

ALTER DATABASE [UnitTest] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO

ALTER DATABASE [UnitTest] SET TRUSTWORTHY OFF 
GO

ALTER DATABASE [UnitTest] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO

ALTER DATABASE [UnitTest] SET PARAMETERIZATION SIMPLE 
GO

ALTER DATABASE [UnitTest] SET READ_COMMITTED_SNAPSHOT OFF 
GO

ALTER DATABASE [UnitTest] SET HONOR_BROKER_PRIORITY OFF 
GO

ALTER DATABASE [UnitTest] SET  READ_WRITE 
GO

ALTER DATABASE [UnitTest] SET RECOVERY FULL 
GO

ALTER DATABASE [UnitTest] SET  MULTI_USER 
GO

ALTER DATABASE [UnitTest] SET PAGE_VERIFY CHECKSUM  
GO

ALTER DATABASE [UnitTest] SET DB_CHAINING OFF 
GO


