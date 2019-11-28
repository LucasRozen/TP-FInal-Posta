USE [master]
GO
/****** Object:  Database [Agenda3]    Script Date: 28/11/2019 12:01:51 ******/
CREATE DATABASE [Agenda3]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'Agenda3', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL14.MSSQLSERVER\MSSQL\DATA\Agenda3.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'Agenda3_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL14.MSSQLSERVER\MSSQL\DATA\Agenda3_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
GO
ALTER DATABASE [Agenda3] SET COMPATIBILITY_LEVEL = 140
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [Agenda3].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [Agenda3] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [Agenda3] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [Agenda3] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [Agenda3] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [Agenda3] SET ARITHABORT OFF 
GO
ALTER DATABASE [Agenda3] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [Agenda3] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [Agenda3] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [Agenda3] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [Agenda3] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [Agenda3] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [Agenda3] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [Agenda3] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [Agenda3] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [Agenda3] SET  DISABLE_BROKER 
GO
ALTER DATABASE [Agenda3] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [Agenda3] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [Agenda3] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [Agenda3] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [Agenda3] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [Agenda3] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [Agenda3] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [Agenda3] SET RECOVERY FULL 
GO
ALTER DATABASE [Agenda3] SET  MULTI_USER 
GO
ALTER DATABASE [Agenda3] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [Agenda3] SET DB_CHAINING OFF 
GO
ALTER DATABASE [Agenda3] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [Agenda3] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [Agenda3] SET DELAYED_DURABILITY = DISABLED 
GO
EXEC sys.sp_db_vardecimal_storage_format N'Agenda3', N'ON'
GO
ALTER DATABASE [Agenda3] SET QUERY_STORE = OFF
GO
USE [Agenda3]
GO
ALTER DATABASE SCOPED CONFIGURATION SET IDENTITY_CACHE = ON;
GO
ALTER DATABASE SCOPED CONFIGURATION SET LEGACY_CARDINALITY_ESTIMATION = OFF;
GO
ALTER DATABASE SCOPED CONFIGURATION FOR SECONDARY SET LEGACY_CARDINALITY_ESTIMATION = PRIMARY;
GO
ALTER DATABASE SCOPED CONFIGURATION SET MAXDOP = 0;
GO
ALTER DATABASE SCOPED CONFIGURATION FOR SECONDARY SET MAXDOP = PRIMARY;
GO
ALTER DATABASE SCOPED CONFIGURATION SET PARAMETER_SNIFFING = ON;
GO
ALTER DATABASE SCOPED CONFIGURATION FOR SECONDARY SET PARAMETER_SNIFFING = PRIMARY;
GO
ALTER DATABASE SCOPED CONFIGURATION SET QUERY_OPTIMIZER_HOTFIXES = OFF;
GO
ALTER DATABASE SCOPED CONFIGURATION FOR SECONDARY SET QUERY_OPTIMIZER_HOTFIXES = PRIMARY;
GO
USE [Agenda3]
GO
/****** Object:  User [alumno]    Script Date: 28/11/2019 12:01:51 ******/
CREATE USER [alumno] FOR LOGIN [alumno] WITH DEFAULT_SCHEMA=[dbo]
GO
/****** Object:  Table [dbo].[Amigos]    Script Date: 28/11/2019 12:01:51 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Amigos](
	[IdAmigo] [int] IDENTITY(1,1) NOT NULL,
	[Nombre] [varchar](50) NOT NULL,
	[Activo] [bit] NOT NULL,
 CONSTRAINT [PK_Amigos] PRIMARY KEY CLUSTERED 
(
	[IdAmigo] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Eventos]    Script Date: 28/11/2019 12:01:51 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Eventos](
	[IdEve] [int] IDENTITY(1,1) NOT NULL,
	[Nombre] [varchar](50) NOT NULL,
	[TipoEve] [int] NOT NULL,
	[IdAmigo] [int] NULL,
	[Dia] [date] NOT NULL,
	[Descripcion] [varchar](200) NOT NULL,
	[Activo] [bit] NOT NULL,
	[Destac] [bit] NOT NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TiposEve]    Script Date: 28/11/2019 12:01:51 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TiposEve](
	[IdTipoEve] [int] IDENTITY(1,1) NOT NULL,
	[NombreT] [varchar](100) NOT NULL,
	[Activo] [bit] NULL,
 CONSTRAINT [PK_TiposEve] PRIMARY KEY CLUSTERED 
(
	[IdTipoEve] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Amigos] ON 
GO
INSERT [dbo].[Amigos] ([IdAmigo], [Nombre], [Activo]) VALUES (1, N'Juan Sator', 1)
GO
INSERT [dbo].[Amigos] ([IdAmigo], [Nombre], [Activo]) VALUES (2, N'Justin Beber', 1)
GO
INSERT [dbo].[Amigos] ([IdAmigo], [Nombre], [Activo]) VALUES (3, N'Zendaya', 0)
GO
INSERT [dbo].[Amigos] ([IdAmigo], [Nombre], [Activo]) VALUES (4, N'Esteban Quito', 1)
GO
INSERT [dbo].[Amigos] ([IdAmigo], [Nombre], [Activo]) VALUES (5, N'Elsa pato', 0)
GO
INSERT [dbo].[Amigos] ([IdAmigo], [Nombre], [Activo]) VALUES (6, N'Aquiles bailo', 1)
GO
INSERT [dbo].[Amigos] ([IdAmigo], [Nombre], [Activo]) VALUES (7, N'Aliqueles baile', 1)
GO
INSERT [dbo].[Amigos] ([IdAmigo], [Nombre], [Activo]) VALUES (8, N'Juli Capo', 0)
GO
SET IDENTITY_INSERT [dbo].[Amigos] OFF
GO
SET IDENTITY_INSERT [dbo].[Eventos] ON 
GO
INSERT [dbo].[Eventos] ([IdEve], [Nombre], [TipoEve], [IdAmigo], [Dia], [Descripcion], [Activo], [Destac]) VALUES (1, N'Prueba de EFSI', 7, NULL, CAST(N'2019-11-21' AS Date), N'Temas: desing thinking y modelos de negocio', 1, 0)
GO
INSERT [dbo].[Eventos] ([IdEve], [Nombre], [TipoEve], [IdAmigo], [Dia], [Descripcion], [Activo], [Destac]) VALUES (2, N'Estudiar historia judia', 8, NULL, CAST(N'2019-11-22' AS Date), N'Modulo 40', 1, 1)
GO
INSERT [dbo].[Eventos] ([IdEve], [Nombre], [TipoEve], [IdAmigo], [Dia], [Descripcion], [Activo], [Destac]) VALUES (3, N'Ir a verStar Wars: El Ascenso de Skywalker', 9, 5, CAST(N'2019-12-20' AS Date), N'Conseguir las entradas', 1, 0)
GO
INSERT [dbo].[Eventos] ([IdEve], [Nombre], [TipoEve], [IdAmigo], [Dia], [Descripcion], [Activo], [Destac]) VALUES (5, N'Finde en la costa', 6, 6, CAST(N'2020-01-08' AS Date), N'Cargar nafta antes de salir', 1, 0)
GO
INSERT [dbo].[Eventos] ([IdEve], [Nombre], [TipoEve], [IdAmigo], [Dia], [Descripcion], [Activo], [Destac]) VALUES (6, N'Cena en Mi barrio', 4, 1, CAST(N'2019-12-10' AS Date), N'Sacar plata', 1, 0)
GO
INSERT [dbo].[Eventos] ([IdEve], [Nombre], [TipoEve], [IdAmigo], [Dia], [Descripcion], [Activo], [Destac]) VALUES (7, N'Reunion Para el regalos de navidad', 2, 3, CAST(N'2019-12-15' AS Date), N'Averiguar que le vamos a regalar a Justin para navidad', 1, 0)
GO
SET IDENTITY_INSERT [dbo].[Eventos] OFF
GO
SET IDENTITY_INSERT [dbo].[TiposEve] ON 
GO
INSERT [dbo].[TiposEve] ([IdTipoEve], [NombreT], [Activo]) VALUES (2, N'Reunion', 1)
GO
INSERT [dbo].[TiposEve] ([IdTipoEve], [NombreT], [Activo]) VALUES (4, N'Juntada', 1)
GO
INSERT [dbo].[TiposEve] ([IdTipoEve], [NombreT], [Activo]) VALUES (6, N'Viaje', 1)
GO
INSERT [dbo].[TiposEve] ([IdTipoEve], [NombreT], [Activo]) VALUES (7, N'Examen', 1)
GO
INSERT [dbo].[TiposEve] ([IdTipoEve], [NombreT], [Activo]) VALUES (8, N'Estudiar', 1)
GO
INSERT [dbo].[TiposEve] ([IdTipoEve], [NombreT], [Activo]) VALUES (9, N'Ver', 1)
GO
INSERT [dbo].[TiposEve] ([IdTipoEve], [NombreT], [Activo]) VALUES (10, N'deportivo', 1)
GO
SET IDENTITY_INSERT [dbo].[TiposEve] OFF
GO
/****** Object:  StoredProcedure [dbo].[sp_EditarAmigo]    Script Date: 28/11/2019 12:01:51 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[sp_EditarAmigo]
	@Id int,
	@Nomb varchar(100)
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    SET NOCOUNT ON;
	UPDATE Amigos 
	SET Nombre = @Nomb 
	WHERE IdAmigo = @Id;
END
GO
/****** Object:  StoredProcedure [dbo].[sp_EditarEve]    Script Date: 28/11/2019 12:01:51 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- ================================================
-- Template generated from Template Explorer using:
-- Create Procedure (New Menu).SQL

CREATE PROCEDURE [dbo].[sp_EditarEve]
@Id int,
@nom varchar(50),
@idtipo int,
@idamigo int,
@amigo varchar(50),
@tipo varchar(50),
@dia date,
@desc varchar(200),
@destac bit
AS
BEGIN
	SET NOCOUNT ON;
	/*UPDATE Eventos inner join Amigos ON Eventos.IdAmigo = Amigos.Id
	SET Nombre = @Nom,Nombre = @nom ,Dia = @dia,Descripcion = @desc

	WHERE IdEve = @Id; */
END
GO
/****** Object:  StoredProcedure [dbo].[sp_EditarTipo]    Script Date: 28/11/2019 12:01:51 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[sp_EditarTipo] 
	
@Id int,
@nom varchar(50)
AS
BEGIN
	SET NOCOUNT ON;
	UPDATE TiposEve 
	SET NombreT = @Nom
	WHERE IdTipoEve = @Id; 
END
GO
/****** Object:  StoredProcedure [dbo].[sp_EliminarAmigo]    Script Date: 28/11/2019 12:01:51 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[sp_EliminarAmigo]
	@NomA int 
	
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;
	UPDATE Amigos 
	SET Activo = 0 
	WHERE IdAmigo = @NomA;
    
END
GO
/****** Object:  StoredProcedure [dbo].[sp_EliminarEve]    Script Date: 28/11/2019 12:01:51 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[sp_EliminarEve] 
	
@Id int

AS
BEGIN
	SET NOCOUNT ON;
	UPDATE Eventos 
	SET Activo=0
	WHERE IdEve = @Id; 
END
GO
/****** Object:  StoredProcedure [dbo].[sp_EliminarTipo]    Script Date: 28/11/2019 12:01:51 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[sp_EliminarTipo] 
	
@Id int

AS
BEGIN
	SET NOCOUNT ON;
	UPDATE TiposEve 
	SET Activo=0
	WHERE IdTipoEve = @Id; 
END
GO
/****** Object:  StoredProcedure [dbo].[sp_InsertarAmigo]    Script Date: 28/11/2019 12:01:51 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[sp_InsertarAmigo]
	@NomA varchar(100),
	@Act bit
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

   Insert into Amigos (Nombre,Activo) Values(@NomA,@Act)
END
GO
/****** Object:  StoredProcedure [dbo].[sp_InsertarEve]    Script Date: 28/11/2019 12:01:51 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[sp_InsertarEve]
	@NomE varchar(100),
	@TipoE int,
	@IdA int,
	@dia date,
	@desc varchar(200),
	@activo bit,
	@destac bit
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	Insert into Eventos(Nombre,TipoEve,IdAmigo,Dia,Descripcion,Activo,Destac) Values(@NomE, @TipoE,@IdA,@dia,@desc,@activo,@destac)
END
GO
/****** Object:  StoredProcedure [dbo].[sp_InsertarTipo]    Script Date: 28/11/2019 12:01:51 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- =============================================
CREATE PROCEDURE [dbo].[sp_InsertarTipo] 
@Nom varchar(100)
as
BEGIN
	
	Insert into TiposEve(NombreT) Values(@Nom) 
	Update  TiposEve
	SET Activo = 1 
	WHERE NombreT = @Nom;
END
GO
/****** Object:  StoredProcedure [dbo].[sp_TraerAmigos]    Script Date: 28/11/2019 12:01:51 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[sp_TraerAmigos]
	
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	SELECT* from Amigos
END
GO
/****** Object:  StoredProcedure [dbo].[sp_TraerEve]    Script Date: 28/11/2019 12:01:51 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[sp_TraerEve]
	
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	SELECT * FROM Eventos
END
GO
/****** Object:  StoredProcedure [dbo].[sp_TraerTipos]    Script Date: 28/11/2019 12:01:51 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[sp_TraerTipos]
	
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;
	SELECT * From TiposEve
END
GO
/****** Object:  StoredProcedure [dbo].[sp_TraerUnEven]    Script Date: 28/11/2019 12:01:51 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[sp_TraerUnEven]
	@id int
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	SELECT * FROM Eventos WHERE IdEve = @id
END
GO
/****** Object:  StoredProcedure [dbo].[sp_TraerxTipo]    Script Date: 28/11/2019 12:01:51 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[sp_TraerxTipo]
	@tipo int
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	SELECT * FROM Eventos WHERE TipoEve = @tipo
END
GO
USE [master]
GO
ALTER DATABASE [Agenda3] SET  READ_WRITE 
GO
