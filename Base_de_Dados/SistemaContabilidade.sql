USE [master]
GO
/****** Object:  Database [SistemaContabilidade]    Script Date: 02/04/2025 23:10:45 ******/
CREATE DATABASE [SistemaContabilidade]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'SistemaContabilidade', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL16.SQLEXPRESS\MSSQL\DATA\SistemaContabilidade.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'SistemaContabilidade_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL16.SQLEXPRESS\MSSQL\DATA\SistemaContabilidade_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT, LEDGER = OFF
GO
ALTER DATABASE [SistemaContabilidade] SET COMPATIBILITY_LEVEL = 160
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [SistemaContabilidade].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [SistemaContabilidade] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [SistemaContabilidade] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [SistemaContabilidade] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [SistemaContabilidade] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [SistemaContabilidade] SET ARITHABORT OFF 
GO
ALTER DATABASE [SistemaContabilidade] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [SistemaContabilidade] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [SistemaContabilidade] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [SistemaContabilidade] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [SistemaContabilidade] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [SistemaContabilidade] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [SistemaContabilidade] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [SistemaContabilidade] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [SistemaContabilidade] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [SistemaContabilidade] SET  DISABLE_BROKER 
GO
ALTER DATABASE [SistemaContabilidade] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [SistemaContabilidade] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [SistemaContabilidade] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [SistemaContabilidade] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [SistemaContabilidade] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [SistemaContabilidade] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [SistemaContabilidade] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [SistemaContabilidade] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [SistemaContabilidade] SET  MULTI_USER 
GO
ALTER DATABASE [SistemaContabilidade] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [SistemaContabilidade] SET DB_CHAINING OFF 
GO
ALTER DATABASE [SistemaContabilidade] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [SistemaContabilidade] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [SistemaContabilidade] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [SistemaContabilidade] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
ALTER DATABASE [SistemaContabilidade] SET QUERY_STORE = ON
GO
ALTER DATABASE [SistemaContabilidade] SET QUERY_STORE (OPERATION_MODE = READ_WRITE, CLEANUP_POLICY = (STALE_QUERY_THRESHOLD_DAYS = 30), DATA_FLUSH_INTERVAL_SECONDS = 900, INTERVAL_LENGTH_MINUTES = 60, MAX_STORAGE_SIZE_MB = 1000, QUERY_CAPTURE_MODE = AUTO, SIZE_BASED_CLEANUP_MODE = AUTO, MAX_PLANS_PER_QUERY = 200, WAIT_STATS_CAPTURE_MODE = ON)
GO
USE [SistemaContabilidade]
GO
/****** Object:  Table [dbo].[CustosPeca]    Script Date: 02/04/2025 23:10:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CustosPeca](
	[IdCusto] [int] IDENTITY(1,1) NOT NULL,
	[IdProduto] [int] NULL,
	[CodigoPeca] [char](8) NULL,
	[CustoProducao] [float] NULL,
	[Lucro] [float] NULL,
	[Prejuizo] [float] NULL,
	[TempoProducao] [int] NULL,
 CONSTRAINT [PK_CustosPeca] PRIMARY KEY CLUSTERED 
(
	[IdCusto] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[CustoTipoFalha]    Script Date: 02/04/2025 23:10:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CustoTipoFalha](
	[CustoTipo] [int] NOT NULL,
	[CustoValor] [float] NULL,
 CONSTRAINT [PK_CustoTipoFalha] PRIMARY KEY CLUSTERED 
(
	[CustoTipo] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[CustosPeca] ON 

INSERT [dbo].[CustosPeca] ([IdCusto], [IdProduto], [CodigoPeca], [CustoProducao], [Lucro], [Prejuizo], [TempoProducao]) VALUES (1, 1, N'P1234569', 0, 0, 0, 10)
SET IDENTITY_INSERT [dbo].[CustosPeca] OFF
GO
INSERT [dbo].[CustoTipoFalha] ([CustoTipo], [CustoValor]) VALUES (1, 0)
INSERT [dbo].[CustoTipoFalha] ([CustoTipo], [CustoValor]) VALUES (2, 3)
INSERT [dbo].[CustoTipoFalha] ([CustoTipo], [CustoValor]) VALUES (3, 2)
INSERT [dbo].[CustoTipoFalha] ([CustoTipo], [CustoValor]) VALUES (4, 2.4)
INSERT [dbo].[CustoTipoFalha] ([CustoTipo], [CustoValor]) VALUES (5, 1.7)
INSERT [dbo].[CustoTipoFalha] ([CustoTipo], [CustoValor]) VALUES (6, 4.5)
GO
/****** Object:  StoredProcedure [dbo].[InsercaoCustosPeca]    Script Date: 02/04/2025 23:10:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[InsercaoCustosPeca]
	@_IdProduto int,
	@_CodigoPeca char(8),
	@_TempoProducao int,
	@_CustoProducao float,
	@_Lucro float,
	@_Prejuizo float
AS
BEGIN
	 SET NOCOUNT ON;
    DECLARE @_IdCusto INT;

    BEGIN TRY
        BEGIN TRANSACTION;
	
            INSERT INTO CustosPeca (IdProduto, CodigoPeca, TempoProducao, CustoProducao, Lucro, Prejuizo)
            VALUES (@_IdProduto, @_CodigoPeca, @_TempoProducao, @_CustoProducao, @_Lucro, @_Prejuizo);

        COMMIT TRANSACTION;
    END TRY
    BEGIN CATCH
        ROLLBACK TRANSACTION;

        DECLARE @ErrorMessage NVARCHAR(4000) = ERROR_MESSAGE();
        DECLARE @ErrorSeverity INT = ERROR_SEVERITY();
        DECLARE @ErrorState INT = ERROR_STATE();

        RAISERROR (@ErrorMessage, @ErrorSeverity, @ErrorState);
    END CATCH
END
GO
USE [master]
GO
ALTER DATABASE [SistemaContabilidade] SET  READ_WRITE 
GO
