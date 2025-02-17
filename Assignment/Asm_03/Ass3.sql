USE [master]
GO
/****** Object:  Database [Ass3]    Script Date: 3/13/2024 4:44:59 PM ******/
CREATE DATABASE [Ass3]
ALTER DATABASE [Ass3] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [Ass3].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [Ass3] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [Ass3] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [Ass3] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [Ass3] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [Ass3] SET ARITHABORT OFF 
GO
ALTER DATABASE [Ass3] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [Ass3] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [Ass3] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [Ass3] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [Ass3] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [Ass3] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [Ass3] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [Ass3] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [Ass3] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [Ass3] SET  ENABLE_BROKER 
GO
ALTER DATABASE [Ass3] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [Ass3] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [Ass3] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [Ass3] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [Ass3] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [Ass3] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [Ass3] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [Ass3] SET RECOVERY FULL 
GO
ALTER DATABASE [Ass3] SET  MULTI_USER 
GO
ALTER DATABASE [Ass3] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [Ass3] SET DB_CHAINING OFF 
GO
ALTER DATABASE [Ass3] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [Ass3] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [Ass3] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [Ass3] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
EXEC sys.sp_db_vardecimal_storage_format N'Ass3', N'ON'
GO
ALTER DATABASE [Ass3] SET QUERY_STORE = OFF
GO
USE [Ass3]
GO
/****** Object:  Table [dbo].[Member]    Script Date: 3/13/2024 4:44:59 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Member](
	[MemberId] [int] IDENTITY(1,1) NOT NULL,
	[Email] [varchar](100) NOT NULL,
	[CompanyName] [varchar](40) NOT NULL,
	[City] [varchar](15) NOT NULL,
	[Country] [varchar](15) NOT NULL,
	[Password] [varchar](100) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[MemberId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Order]    Script Date: 3/13/2024 4:44:59 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Order](
	[orderId] [int] IDENTITY(1,1) NOT NULL,
	[MemberId] [int] NOT NULL,
	[OrderDate] [datetime] NOT NULL,
	[RequiredDate] [datetime] NULL,
	[ShippedDate] [datetime] NULL,
	[Freight] [money] NULL,
PRIMARY KEY CLUSTERED 
(
	[orderId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[OrderDetail]    Script Date: 3/13/2024 4:44:59 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[OrderDetail](
	[orderId] [int] NOT NULL,
	[ProductId] [int] NOT NULL,
	[Quantity] [int] NOT NULL,
	[UnitPrice] [money] NOT NULL,
	[Discount] [float] NOT NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Product]    Script Date: 3/13/2024 4:44:59 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Product](
	[ProductId] [int] IDENTITY(1,1) NOT NULL,
	[CategoryId] [int] NOT NULL,
	[ProductName] [varchar](40) NOT NULL,
	[Weight] [varchar](20) NOT NULL,
	[UnitPrice] [money] NOT NULL,
	[UnitsInStock] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[ProductId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Member] ON 

INSERT [dbo].[Member] ([MemberId], [Email], [CompanyName], [City], [Country], [Password]) VALUES (1, N'thanhbo@gmail.com', N'FPT', N'Hanoi', N'Vietnam', N'123')
INSERT [dbo].[Member] ([MemberId], [Email], [CompanyName], [City], [Country], [Password]) VALUES (2, N'chuong@gmail.com', N'Paris Saint-Germain', N'Paris', N'France', N'123')
INSERT [dbo].[Member] ([MemberId], [Email], [CompanyName], [City], [Country], [Password]) VALUES (3, N'tai@gmail.com', N'Manchester United', N'Manchester', N'England', N'123456')
INSERT [dbo].[Member] ([MemberId], [Email], [CompanyName], [City], [Country], [Password]) VALUES (4, N'tanlnhe153509@gmail.com', N'Manchester United', N'Manchester', N'Afghanistan', N'1234567')
INSERT [dbo].[Member] ([MemberId], [Email], [CompanyName], [City], [Country], [Password]) VALUES (5, N'LongTH@gmail.com', N'Ha noi', N'Ha nôi', N'Vietnam', N'123')
INSERT [dbo].[Member] ([MemberId], [Email], [CompanyName], [City], [Country], [Password]) VALUES (6, N'Dungnv@gmail.com', N'FPT', N'HN', N'Afghanistan', N'1234')
INSERT [dbo].[Member] ([MemberId], [Email], [CompanyName], [City], [Country], [Password]) VALUES (7, N'Hieutb123@gmail.com', N'FPT', N'HN', N'Belarus', N'1234')
SET IDENTITY_INSERT [dbo].[Member] OFF
GO
SET IDENTITY_INSERT [dbo].[Order] ON 

INSERT [dbo].[Order] ([orderId], [MemberId], [OrderDate], [RequiredDate], [ShippedDate], [Freight]) VALUES (1, 1, CAST(N'2022-10-18T09:00:00.000' AS DateTime), NULL, NULL, NULL)
INSERT [dbo].[Order] ([orderId], [MemberId], [OrderDate], [RequiredDate], [ShippedDate], [Freight]) VALUES (2, 2, CAST(N'2022-12-30T10:00:00.000' AS DateTime), NULL, NULL, NULL)
SET IDENTITY_INSERT [dbo].[Order] OFF
GO
INSERT [dbo].[OrderDetail] ([orderId], [ProductId], [Quantity], [UnitPrice], [Discount]) VALUES (1, 2, 5, 200000.0000, 0)
INSERT [dbo].[OrderDetail] ([orderId], [ProductId], [Quantity], [UnitPrice], [Discount]) VALUES (1, 3, 1, 300000.0000, 0)
INSERT [dbo].[OrderDetail] ([orderId], [ProductId], [Quantity], [UnitPrice], [Discount]) VALUES (1, 4, 2, 100000.0000, 0)
INSERT [dbo].[OrderDetail] ([orderId], [ProductId], [Quantity], [UnitPrice], [Discount]) VALUES (2, 1, 2, 100000.0000, 0)
GO
SET IDENTITY_INSERT [dbo].[Product] ON 

INSERT [dbo].[Product] ([ProductId], [CategoryId], [ProductName], [Weight], [UnitPrice], [UnitsInStock]) VALUES (1, 1, N'Vodka', N'500ml', 100000.0000, 100)
INSERT [dbo].[Product] ([ProductId], [CategoryId], [ProductName], [Weight], [UnitPrice], [UnitsInStock]) VALUES (2, 1, N'Gin', N'500ml', 200000.0000, 100)
INSERT [dbo].[Product] ([ProductId], [CategoryId], [ProductName], [Weight], [UnitPrice], [UnitsInStock]) VALUES (3, 1, N'Rum', N'500ml', 300000.0000, 100)
INSERT [dbo].[Product] ([ProductId], [CategoryId], [ProductName], [Weight], [UnitPrice], [UnitsInStock]) VALUES (4, 2, N'Juice', N'500ml', 100000.0000, 50)
INSERT [dbo].[Product] ([ProductId], [CategoryId], [ProductName], [Weight], [UnitPrice], [UnitsInStock]) VALUES (5, 1, N'sweet wine', N'500ml', 30000000.0000, 100)
SET IDENTITY_INSERT [dbo].[Product] OFF
GO
ALTER TABLE [dbo].[Order]  WITH CHECK ADD FOREIGN KEY([MemberId])
REFERENCES [dbo].[Member] ([MemberId])
GO
ALTER TABLE [dbo].[OrderDetail]  WITH CHECK ADD FOREIGN KEY([orderId])
REFERENCES [dbo].[Order] ([orderId])
GO
ALTER TABLE [dbo].[OrderDetail]  WITH CHECK ADD FOREIGN KEY([ProductId])
REFERENCES [dbo].[Product] ([ProductId])
GO
USE [master]
GO
ALTER DATABASE [Ass3] SET  READ_WRITE 
GO
