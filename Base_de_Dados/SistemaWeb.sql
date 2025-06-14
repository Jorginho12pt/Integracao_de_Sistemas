USE [master]
GO
/****** Object:  Database [SistemaWeb]    Script Date: 02/04/2025 23:11:30 ******/
CREATE DATABASE [SistemaWeb]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'SistemaWeb', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL16.SQLEXPRESS\MSSQL\DATA\SistemaWeb.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'SistemaWeb_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL16.SQLEXPRESS\MSSQL\DATA\SistemaWeb_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT, LEDGER = OFF
GO
ALTER DATABASE [SistemaWeb] SET COMPATIBILITY_LEVEL = 160
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [SistemaWeb].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [SistemaWeb] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [SistemaWeb] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [SistemaWeb] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [SistemaWeb] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [SistemaWeb] SET ARITHABORT OFF 
GO
ALTER DATABASE [SistemaWeb] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [SistemaWeb] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [SistemaWeb] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [SistemaWeb] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [SistemaWeb] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [SistemaWeb] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [SistemaWeb] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [SistemaWeb] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [SistemaWeb] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [SistemaWeb] SET  DISABLE_BROKER 
GO
ALTER DATABASE [SistemaWeb] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [SistemaWeb] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [SistemaWeb] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [SistemaWeb] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [SistemaWeb] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [SistemaWeb] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [SistemaWeb] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [SistemaWeb] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [SistemaWeb] SET  MULTI_USER 
GO
ALTER DATABASE [SistemaWeb] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [SistemaWeb] SET DB_CHAINING OFF 
GO
ALTER DATABASE [SistemaWeb] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [SistemaWeb] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [SistemaWeb] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [SistemaWeb] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
ALTER DATABASE [SistemaWeb] SET QUERY_STORE = ON
GO
ALTER DATABASE [SistemaWeb] SET QUERY_STORE (OPERATION_MODE = READ_WRITE, CLEANUP_POLICY = (STALE_QUERY_THRESHOLD_DAYS = 30), DATA_FLUSH_INTERVAL_SECONDS = 900, INTERVAL_LENGTH_MINUTES = 60, MAX_STORAGE_SIZE_MB = 1000, QUERY_CAPTURE_MODE = AUTO, SIZE_BASED_CLEANUP_MODE = AUTO, MAX_PLANS_PER_QUERY = 200, WAIT_STATS_CAPTURE_MODE = ON)
GO
USE [SistemaWeb]
GO
/****** Object:  Table [dbo].[CodigoResultadosDescricao]    Script Date: 02/04/2025 23:11:30 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CodigoResultadosDescricao](
	[IdCodigoResultado] [int] IDENTITY(1,1) NOT NULL,
	[Descricao] [char](50) NULL,
 CONSTRAINT [PK_CodigoResultadosDescricao] PRIMARY KEY CLUSTERED 
(
	[IdCodigoResultado] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Produto]    Script Date: 02/04/2025 23:11:30 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Produto](
	[IdProduto] [int] IDENTITY(1,1) NOT NULL,
	[CodigoPeca] [char](8) NULL,
	[DataHoraProducao] [datetime2](0) NULL,
	[TempoProducao] [int] NULL,
 CONSTRAINT [PK_Produto] PRIMARY KEY CLUSTERED 
(
	[IdProduto] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Testes]    Script Date: 02/04/2025 23:11:30 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Testes](
	[IdTeste] [int] IDENTITY(1,1) NOT NULL,
	[IdProduto] [int] NULL,
	[CodigoResultado] [int] NULL,
	[DataTeste] [datetime2](0) NULL,
 CONSTRAINT [PK_Testes] PRIMARY KEY CLUSTERED 
(
	[IdTeste] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[CodigoResultadosDescricao] ON 

INSERT [dbo].[CodigoResultadosDescricao] ([IdCodigoResultado], [Descricao]) VALUES (1, N'Ok                                                ')
INSERT [dbo].[CodigoResultadosDescricao] ([IdCodigoResultado], [Descricao]) VALUES (2, N'Falha na inspeção visual                          ')
INSERT [dbo].[CodigoResultadosDescricao] ([IdCodigoResultado], [Descricao]) VALUES (3, N'Falha na inspeção de resistência                  ')
INSERT [dbo].[CodigoResultadosDescricao] ([IdCodigoResultado], [Descricao]) VALUES (4, N'Falha na inspeção de dimensões                    ')
INSERT [dbo].[CodigoResultadosDescricao] ([IdCodigoResultado], [Descricao]) VALUES (5, N'Falha na inspeção de estanqueidade                ')
INSERT [dbo].[CodigoResultadosDescricao] ([IdCodigoResultado], [Descricao]) VALUES (6, N'Desconhecido                                      ')
SET IDENTITY_INSERT [dbo].[CodigoResultadosDescricao] OFF
GO
SET IDENTITY_INSERT [dbo].[Produto] ON 

INSERT [dbo].[Produto] ([IdProduto], [CodigoPeca], [DataHoraProducao], [TempoProducao]) VALUES (1, N'P1234569', CAST(N'2025-03-27T14:30:00.0000000' AS DateTime2), 10)
INSERT [dbo].[Produto] ([IdProduto], [CodigoPeca], [DataHoraProducao], [TempoProducao]) VALUES (2, N'ab121212', CAST(N'2025-03-29T18:10:10.0000000' AS DateTime2), 15)
INSERT [dbo].[Produto] ([IdProduto], [CodigoPeca], [DataHoraProducao], [TempoProducao]) VALUES (3, N'bb121212', CAST(N'2025-03-29T18:15:48.0000000' AS DateTime2), 30)
INSERT [dbo].[Produto] ([IdProduto], [CodigoPeca], [DataHoraProducao], [TempoProducao]) VALUES (4, N'aa999999', CAST(N'2025-03-29T22:20:43.0000000' AS DateTime2), 10)
INSERT [dbo].[Produto] ([IdProduto], [CodigoPeca], [DataHoraProducao], [TempoProducao]) VALUES (5, N'aa888888', CAST(N'2025-03-29T22:24:40.0000000' AS DateTime2), 10)
INSERT [dbo].[Produto] ([IdProduto], [CodigoPeca], [DataHoraProducao], [TempoProducao]) VALUES (6, N'ba123123', CAST(N'2025-03-29T22:25:11.0000000' AS DateTime2), 25)
INSERT [dbo].[Produto] ([IdProduto], [CodigoPeca], [DataHoraProducao], [TempoProducao]) VALUES (7, N'ab123123', CAST(N'2025-03-30T16:56:23.0000000' AS DateTime2), 40)
INSERT [dbo].[Produto] ([IdProduto], [CodigoPeca], [DataHoraProducao], [TempoProducao]) VALUES (8, N'aa666666', CAST(N'2025-03-30T17:24:05.0000000' AS DateTime2), 10)
SET IDENTITY_INSERT [dbo].[Produto] OFF
GO
SET IDENTITY_INSERT [dbo].[Testes] ON 

INSERT [dbo].[Testes] ([IdTeste], [IdProduto], [CodigoResultado], [DataTeste]) VALUES (1, 1, 1, CAST(N'2025-03-27T14:30:00.0000000' AS DateTime2))
INSERT [dbo].[Testes] ([IdTeste], [IdProduto], [CodigoResultado], [DataTeste]) VALUES (2, 2, 1, CAST(N'2025-03-29T18:10:10.0000000' AS DateTime2))
INSERT [dbo].[Testes] ([IdTeste], [IdProduto], [CodigoResultado], [DataTeste]) VALUES (3, 3, 2, CAST(N'2025-03-29T18:15:48.0000000' AS DateTime2))
INSERT [dbo].[Testes] ([IdTeste], [IdProduto], [CodigoResultado], [DataTeste]) VALUES (4, 4, 5, CAST(N'2025-03-29T22:20:43.0000000' AS DateTime2))
INSERT [dbo].[Testes] ([IdTeste], [IdProduto], [CodigoResultado], [DataTeste]) VALUES (5, 5, 6, CAST(N'2025-03-29T22:24:40.0000000' AS DateTime2))
INSERT [dbo].[Testes] ([IdTeste], [IdProduto], [CodigoResultado], [DataTeste]) VALUES (6, 6, 1, CAST(N'2025-03-29T22:25:11.0000000' AS DateTime2))
INSERT [dbo].[Testes] ([IdTeste], [IdProduto], [CodigoResultado], [DataTeste]) VALUES (7, 7, 1, CAST(N'2025-03-30T16:56:23.0000000' AS DateTime2))
INSERT [dbo].[Testes] ([IdTeste], [IdProduto], [CodigoResultado], [DataTeste]) VALUES (8, 8, 3, CAST(N'2025-03-30T17:24:05.0000000' AS DateTime2))
SET IDENTITY_INSERT [dbo].[Testes] OFF
GO
ALTER TABLE [dbo].[Testes]  WITH CHECK ADD  CONSTRAINT [FK_Testes_CodigoResultadosDescricao] FOREIGN KEY([CodigoResultado])
REFERENCES [dbo].[CodigoResultadosDescricao] ([IdCodigoResultado])
GO
ALTER TABLE [dbo].[Testes] CHECK CONSTRAINT [FK_Testes_CodigoResultadosDescricao]
GO
ALTER TABLE [dbo].[Testes]  WITH CHECK ADD  CONSTRAINT [FK_Testes_Produto] FOREIGN KEY([IdProduto])
REFERENCES [dbo].[Produto] ([IdProduto])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Testes] CHECK CONSTRAINT [FK_Testes_Produto]
GO
/****** Object:  StoredProcedure [dbo].[AtualizacaoProduto]    Script Date: 02/04/2025 23:11:30 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[AtualizacaoProduto]
   @_IdProduto int,
   @_CodigoPeca char(8),
   @_DataHoraProducao datetime2(0),
   @_TempoProducao int
AS   
BEGIN

    SET NOCOUNT ON;

    BEGIN TRY
        BEGIN TRANSACTION;
		
--Produto--
			UPDATE Produto
			SET  DataHoraProducao = @_DataHoraProducao, TempoProducao = @_TempoProducao
			WHERE IdProduto = @_IdProduto 
				AND CodigoPeca= @_CodigoPeca;

        COMMIT TRANSACTION;
    END TRY
    BEGIN CATCH
        ROLLBACK TRANSACTION;

        DECLARE @ErrorMessage NVARCHAR(4000) = ERROR_MESSAGE();
        DECLARE @ErrorSeverity INT = ERROR_SEVERITY();
        DECLARE @ErrorState INT = ERROR_STATE();

        RAISERROR (@ErrorMessage, @ErrorSeverity, @ErrorState);
    END CATCH
END;
GO
/****** Object:  StoredProcedure [dbo].[AtualizacaoTestes]    Script Date: 02/04/2025 23:11:30 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[AtualizacaoTestes]
   @_IdTeste int,
   @_IdProduto int,
   @_CodigoResultado int,
   @_DataTeste datetime2(0)
AS   
BEGIN

    SET NOCOUNT ON;

    BEGIN TRY
        BEGIN TRANSACTION;
		
--Testes--
			UPDATE Testes
			SET IdProduto= @_IdProduto, CodigoResultado = @_CodigoResultado, DataTeste = @_DataTeste
			WHERE IdTeste = @_IdTeste;

        COMMIT TRANSACTION;
    END TRY
    BEGIN CATCH
        ROLLBACK TRANSACTION;

        DECLARE @ErrorMessage NVARCHAR(4000) = ERROR_MESSAGE();
        DECLARE @ErrorSeverity INT = ERROR_SEVERITY();
        DECLARE @ErrorState INT = ERROR_STATE();

        RAISERROR (@ErrorMessage, @ErrorSeverity, @ErrorState);
    END CATCH
END;
GO
/****** Object:  StoredProcedure [dbo].[GetProduto]    Script Date: 02/04/2025 23:11:30 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[GetProduto]
AS   
BEGIN

    SET NOCOUNT ON;

    BEGIN TRY
        BEGIN TRANSACTION;
		
--Produto--
			select top 1000 * from Produto

        COMMIT TRANSACTION;
    END TRY
    BEGIN CATCH
        ROLLBACK TRANSACTION;

        DECLARE @ErrorMessage NVARCHAR(4000) = ERROR_MESSAGE();
        DECLARE @ErrorSeverity INT = ERROR_SEVERITY();
        DECLARE @ErrorState INT = ERROR_STATE();

        RAISERROR (@ErrorMessage, @ErrorSeverity, @ErrorState);
    END CATCH
END;
GO
/****** Object:  StoredProcedure [dbo].[GetTestes]    Script Date: 02/04/2025 23:11:30 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[GetTestes]
AS   
BEGIN

    SET NOCOUNT ON;

    BEGIN TRY
        BEGIN TRANSACTION;
		
--Testes--
			select top 1000 * from Testes

        COMMIT TRANSACTION;
    END TRY
    BEGIN CATCH
        ROLLBACK TRANSACTION;

        DECLARE @ErrorMessage NVARCHAR(4000) = ERROR_MESSAGE();
        DECLARE @ErrorSeverity INT = ERROR_SEVERITY();
        DECLARE @ErrorState INT = ERROR_STATE();

        RAISERROR (@ErrorMessage, @ErrorSeverity, @ErrorState);
    END CATCH
END;
GO
/****** Object:  StoredProcedure [dbo].[Insercao]    Script Date: 02/04/2025 23:11:30 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[Insercao]
   @_DataHora datetime2(0),
   @_CodigoPeca char(8),
   @_TempoProducao int,
   @_ResultadoTeste int
AS   
BEGIN
    SET NOCOUNT ON;
    DECLARE @_IdProduto INT;
	DECLARE @_IdTeste INT;

    BEGIN TRY
        BEGIN TRANSACTION;
		
--Produto--
		SELECT @_IdProduto = IdProduto
		FROM Produto
		WHERE CodigoPeca = @_CodigoPeca;

		IF @_IdProduto IS NOT NULL
        BEGIN	
			UPDATE Produto
			SET DataHoraProducao = @_DataHora, TempoProducao = @_TempoProducao
			WHERE IdProduto = @_IdProduto;
        END
        ELSE
        BEGIN
            INSERT INTO Produto (CodigoPeca, DataHoraProducao, TempoProducao)
            VALUES (@_CodigoPeca, @_DataHora, @_TempoProducao);

            SET @_IdProduto = SCOPE_IDENTITY();
        END

--Testes--
        BEGIN
            INSERT INTO Testes (IdProduto, CodigoResultado, DataTeste)
            VALUES (@_IdProduto, @_ResultadoTeste, @_DataHora);
        END

        COMMIT TRANSACTION;
    END TRY
    BEGIN CATCH
        ROLLBACK TRANSACTION;

        DECLARE @ErrorMessage NVARCHAR(4000) = ERROR_MESSAGE();
        DECLARE @ErrorSeverity INT = ERROR_SEVERITY();
        DECLARE @ErrorState INT = ERROR_STATE();

        RAISERROR (@ErrorMessage, @ErrorSeverity, @ErrorState);
    END CATCH
END;
GO
/****** Object:  StoredProcedure [dbo].[RemocaoProduto]    Script Date: 02/04/2025 23:11:30 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[RemocaoProduto]
   @_IdProduto int,
   @_CodigoPeca char(8),
   @_DataHoraProducao datetime2(0),
   @_TempoProducao int
AS   
BEGIN

    SET NOCOUNT ON;

    BEGIN TRY
        BEGIN TRANSACTION;
		
--Produto--
			Delete
			From Produto
			WHERE IdProduto = @_IdProduto 
				AND CodigoPeca= @_CodigoPeca
				AND DataHoraProducao = @_DataHoraProducao
				AND TempoProducao = @_TempoProducao

        COMMIT TRANSACTION;
    END TRY
    BEGIN CATCH
        ROLLBACK TRANSACTION;

        DECLARE @ErrorMessage NVARCHAR(4000) = ERROR_MESSAGE();
        DECLARE @ErrorSeverity INT = ERROR_SEVERITY();
        DECLARE @ErrorState INT = ERROR_STATE();

        RAISERROR (@ErrorMessage, @ErrorSeverity, @ErrorState);
    END CATCH
END;
GO
/****** Object:  StoredProcedure [dbo].[RemocaoTestes]    Script Date: 02/04/2025 23:11:30 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[RemocaoTestes]
   @_IdTeste int,
   @_IdProduto int,
   @_CodigoResultado int,
   @_DataTeste datetime2(0)
AS   
BEGIN

    SET NOCOUNT ON;

    BEGIN TRY
        BEGIN TRANSACTION;
		
--Testes--
			DELETE 
			FROM Testes 
			WHERE IdTeste = @_IdTeste 
				AND IdProduto= @_IdProduto 
				AND CodigoResultado = @_CodigoResultado
				AND DataTeste = @_DataTeste;

        COMMIT TRANSACTION;
    END TRY
    BEGIN CATCH
        ROLLBACK TRANSACTION;

        DECLARE @ErrorMessage NVARCHAR(4000) = ERROR_MESSAGE();
        DECLARE @ErrorSeverity INT = ERROR_SEVERITY();
        DECLARE @ErrorState INT = ERROR_STATE();

        RAISERROR (@ErrorMessage, @ErrorSeverity, @ErrorState);
    END CATCH
END;
GO
/****** Object:  Trigger [dbo].[InsercaoTrigger]    Script Date: 02/04/2025 23:11:30 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TRIGGER [dbo].[InsercaoTrigger] ON [dbo].[Testes] AFTER INSERT
AS
BEGIN 
	IF @@rowcount = 0 RETURN;
	-- Precisa de optimização nas variavei, nos ifs , e @_TempoProducao
	DECLARE @_IdProduto int;
	DECLARE @_CodigoPeca char(8);
	DECLARE @_TempoProducao int;
	DECLARE @_CustoProducao float = 0;
	DECLARE @_Lucro float = 0;
	DECLARE @_Prejuizo float = 0;
	DECLARE @_CodigoResultado int;
	DECLARE @_CustoValor float;

	SELECT @_IdProduto = IdProduto
    FROM INSERTED;
	SELECT @_CodigoResultado = CodigoResultado
    FROM INSERTED;

	SET @_CodigoPeca = (SELECT CodigoPeca FROM [SistemaWeb].[dbo].[Produto] WHERE IdProduto = @_IdProduto)
	SET @_TempoProducao = (SELECT TempoProducao FROM [SistemaWeb].[dbo].[Produto] WHERE IdProduto = @_IdProduto)
	SET @_CustoValor = (SELECT CustoValor FROM [SistemaContabilidade].[dbo].[CustoTipoFalha] WHERE CustoTipo = @_CodigoResultado)

    IF @_CodigoPeca LIKE 'aa%' 
    BEGIN
        SET @_CustoProducao = @_TempoProducao * 1.9;
		SET @_Prejuizo = (@_TempoProducao * 0.9) + (@_CustoValor);
		SET @_Lucro = 120 - (@_CustoProducao + @_Prejuizo);
    END
    ELSE IF @_CodigoPeca LIKE 'ab%' 
    BEGIN
        SET @_CustoProducao = @_TempoProducao * 1.3;
		SET @_Prejuizo = (@_TempoProducao * 1.1) + (@_CustoValor);
		SET @_Lucro = 100 - (@_CustoProducao + @_Prejuizo);
    END
    ELSE IF @_CodigoPeca LIKE 'ba%' 
    BEGIN
        SET @_CustoProducao = @_TempoProducao * 1.7;
		SET @_Prejuizo = (@_TempoProducao * 1.2) + (@_CustoValor);
		SET @_Lucro = 110 - (@_CustoProducao + @_Prejuizo);
    END
    ELSE IF @_CodigoPeca LIKE 'bb%' 
    BEGIN
        SET @_CustoProducao = @_TempoProducao * 1.2;
		SET @_Prejuizo = (@_TempoProducao * 1.3) + (@_CustoValor);
		SET @_Lucro = 90 - (@_CustoProducao + @_Prejuizo);
    END
    ELSE 
    BEGIN
        RETURN;
    END

        INSERT INTO [SistemaContabilidade].[dbo].[CustosPeca] (IdProduto, CodigoPeca, TempoProducao, CustoProducao, Lucro, Prejuizo)
        VALUES (@_IdProduto,@_CodigoPeca, @_TempoProducao, @_CustoProducao, @_Lucro,@_Prejuizo);
END;
GO
ALTER TABLE [dbo].[Testes] ENABLE TRIGGER [InsercaoTrigger]
GO
USE [master]
GO
ALTER DATABASE [SistemaWeb] SET  READ_WRITE 
GO
