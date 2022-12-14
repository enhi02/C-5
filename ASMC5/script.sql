USE [master]
GO
/****** Object:  Database [ASM_C5]    Script Date: 6/18/2022 8:02:20 PM ******/
CREATE DATABASE [ASM_C5]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'ASM_C5', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\ASM_C5.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'ASM_C5_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\ASM_C5_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [ASM_C5] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [ASM_C5].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [ASM_C5] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [ASM_C5] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [ASM_C5] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [ASM_C5] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [ASM_C5] SET ARITHABORT OFF 
GO
ALTER DATABASE [ASM_C5] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [ASM_C5] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [ASM_C5] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [ASM_C5] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [ASM_C5] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [ASM_C5] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [ASM_C5] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [ASM_C5] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [ASM_C5] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [ASM_C5] SET  ENABLE_BROKER 
GO
ALTER DATABASE [ASM_C5] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [ASM_C5] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [ASM_C5] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [ASM_C5] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [ASM_C5] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [ASM_C5] SET READ_COMMITTED_SNAPSHOT ON 
GO
ALTER DATABASE [ASM_C5] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [ASM_C5] SET RECOVERY FULL 
GO
ALTER DATABASE [ASM_C5] SET  MULTI_USER 
GO
ALTER DATABASE [ASM_C5] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [ASM_C5] SET DB_CHAINING OFF 
GO
ALTER DATABASE [ASM_C5] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [ASM_C5] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [ASM_C5] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [ASM_C5] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
EXEC sys.sp_db_vardecimal_storage_format N'ASM_C5', N'ON'
GO
ALTER DATABASE [ASM_C5] SET QUERY_STORE = OFF
GO
USE [ASM_C5]
GO
/****** Object:  Table [dbo].[__EFMigrationsHistory]    Script Date: 6/18/2022 8:02:20 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[__EFMigrationsHistory](
	[MigrationId] [nvarchar](150) NOT NULL,
	[ProductVersion] [nvarchar](32) NOT NULL,
 CONSTRAINT [PK___EFMigrationsHistory] PRIMARY KEY CLUSTERED 
(
	[MigrationId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[CartDetails]    Script Date: 6/18/2022 8:02:20 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CartDetails](
	[CartDetailsID] [int] IDENTITY(1,1) NOT NULL,
	[CartID] [int] NOT NULL,
	[MonAnId] [int] NOT NULL,
	[GiaMonAn] [money] NOT NULL,
	[Soluong] [int] NOT NULL,
	[ThanhTien] [float] NOT NULL,
	[GhiChu] [nvarchar](250) NULL,
 CONSTRAINT [PK_CartDetails] PRIMARY KEY CLUSTERED 
(
	[CartDetailsID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Carts]    Script Date: 6/18/2022 8:02:20 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Carts](
	[CartID] [int] IDENTITY(1,1) NOT NULL,
	[UserID] [int] NOT NULL,
	[NgayDat] [datetime2](7) NOT NULL,
	[Tongtien] [float] NOT NULL,
	[TrangthaiDonhang] [int] NOT NULL,
	[GhiChu] [nvarchar](250) NULL,
 CONSTRAINT [PK_Carts] PRIMARY KEY CLUSTERED 
(
	[CartID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Food_Category]    Script Date: 6/18/2022 8:02:20 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Food_Category](
	[CategoryId] [int] IDENTITY(1,1) NOT NULL,
	[CategoryName] [nvarchar](max) NULL,
 CONSTRAINT [PK_Food_Category] PRIMARY KEY CLUSTERED 
(
	[CategoryId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Foods]    Script Date: 6/18/2022 8:02:20 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Foods](
	[MonAnId] [int] IDENTITY(1,1) NOT NULL,
	[TenMonAn] [nvarchar](50) NOT NULL,
	[GiaMonAn] [money] NOT NULL,
	[Image] [varchar](100) NULL,
	[MoTa] [nvarchar](300) NOT NULL,
	[Category] [int] NOT NULL,
	[TrangThai] [bit] NOT NULL,
	[IsDelete] [bit] NOT NULL,
	[SoLuong] [nvarchar](max) NULL,
 CONSTRAINT [PK_Foods] PRIMARY KEY CLUSTERED 
(
	[MonAnId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Roles]    Script Date: 6/18/2022 8:02:20 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Roles](
	[RoleId] [int] IDENTITY(1,1) NOT NULL,
	[RoleName] [nvarchar](max) NULL,
 CONSTRAINT [PK_Roles] PRIMARY KEY CLUSTERED 
(
	[RoleId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Users]    Script Date: 6/18/2022 8:02:20 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Users](
	[NguoiDungId] [int] IDENTITY(1,1) NOT NULL,
	[UserName] [nvarchar](100) NOT NULL,
	[FullName] [nvarchar](100) NOT NULL,
	[Email] [nvarchar](max) NOT NULL,
	[Gender] [int] NOT NULL,
	[NgaySinh] [datetime2](7) NOT NULL,
	[DiaChi] [nvarchar](200) NOT NULL,
	[DienThoai] [varchar](15) NOT NULL,
	[Role] [int] NOT NULL,
	[Status] [bit] NOT NULL,
	[Password] [varchar](50) NOT NULL,
	[ConfirmPassword] [varchar](50) NOT NULL,
	[IsDelete] [bit] NOT NULL,
 CONSTRAINT [PK_Users] PRIMARY KEY CLUSTERED 
(
	[NguoiDungId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20220609160505_ASMC501', N'5.0.16')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20220612042149_addsoluong', N'5.0.16')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20220612063553_addImage', N'5.0.16')
GO
SET IDENTITY_INSERT [dbo].[Food_Category] ON 

INSERT [dbo].[Food_Category] ([CategoryId], [CategoryName]) VALUES (1, N'1')
INSERT [dbo].[Food_Category] ([CategoryId], [CategoryName]) VALUES (2, N'2')
INSERT [dbo].[Food_Category] ([CategoryId], [CategoryName]) VALUES (3, N'3')
SET IDENTITY_INSERT [dbo].[Food_Category] OFF
GO
SET IDENTITY_INSERT [dbo].[Foods] ON 

INSERT [dbo].[Foods] ([MonAnId], [TenMonAn], [GiaMonAn], [Image], [MoTa], [Category], [TrangThai], [IsDelete], [SoLuong]) VALUES (12, N'Bạc Xĩu Đá', 30000.0000, N'BacXiuDa.png', N'Uống Đi', 1, 1, 0, NULL)
INSERT [dbo].[Foods] ([MonAnId], [TenMonAn], [GiaMonAn], [Image], [MoTa], [Category], [TrangThai], [IsDelete], [SoLuong]) VALUES (14, N'Nước Chanh', 30000.0000, N'6.jpg', N'Món ăn được làm từ hải sản sống', 2, 1, 0, NULL)
INSERT [dbo].[Foods] ([MonAnId], [TenMonAn], [GiaMonAn], [Image], [MoTa], [Category], [TrangThai], [IsDelete], [SoLuong]) VALUES (1017, N'Hamburgur', 50000.0000, N'6..jpg', N'Ngon', 1, 1, 0, NULL)
INSERT [dbo].[Foods] ([MonAnId], [TenMonAn], [GiaMonAn], [Image], [MoTa], [Category], [TrangThai], [IsDelete], [SoLuong]) VALUES (1018, N'Pizza', 150000.0000, N'9.jpg', N'Pizza', 2, 1, 0, NULL)
INSERT [dbo].[Foods] ([MonAnId], [TenMonAn], [GiaMonAn], [Image], [MoTa], [Category], [TrangThai], [IsDelete], [SoLuong]) VALUES (1019, N'Sushi', 100000.0000, N'1.jpg', N'áa', 1, 1, 0, NULL)
SET IDENTITY_INSERT [dbo].[Foods] OFF
GO
SET IDENTITY_INSERT [dbo].[Roles] ON 

INSERT [dbo].[Roles] ([RoleId], [RoleName]) VALUES (1, N'Admin')
INSERT [dbo].[Roles] ([RoleId], [RoleName]) VALUES (2, N'Nhân Viên')
INSERT [dbo].[Roles] ([RoleId], [RoleName]) VALUES (3, N'Khách Hàng')
SET IDENTITY_INSERT [dbo].[Roles] OFF
GO
SET IDENTITY_INSERT [dbo].[Users] ON 

INSERT [dbo].[Users] ([NguoiDungId], [UserName], [FullName], [Email], [Gender], [NgaySinh], [DiaChi], [DienThoai], [Role], [Status], [Password], [ConfirmPassword], [IsDelete]) VALUES (1, N'hiennn', N'thầy thanh', N'tungloli@gmail.com', 1, CAST(N'2022-06-16T13:16:00.0000000' AS DateTime2), N'quang trung', N'0831234234', 1, 1, N'202CB962AC59075B964B07152D234B70', N'123', 1)
INSERT [dbo].[Users] ([NguoiDungId], [UserName], [FullName], [Email], [Gender], [NgaySinh], [DiaChi], [DienThoai], [Role], [Status], [Password], [ConfirmPassword], [IsDelete]) VALUES (2, N'hien960', N'tấn hiển', N'tanhien@gmail.com', 1, CAST(N'2022-06-16T23:19:00.0000000' AS DateTime2), N'quang trung', N'1124567984', 3, 1, N'202CB962AC59075B964B07152D234B70', N'202CB962AC59075B964B07152D234B70', 0)
INSERT [dbo].[Users] ([NguoiDungId], [UserName], [FullName], [Email], [Gender], [NgaySinh], [DiaChi], [DienThoai], [Role], [Status], [Password], [ConfirmPassword], [IsDelete]) VALUES (5, N'Hien', N'Tấn Hiển', N'hienptps18441@fpt.edu.vn', 1, CAST(N'2022-05-02T18:43:00.0000000' AS DateTime2), N'quang trung', N'0831234234', 2, 1, N'202CB962AC59075B964B07152D234B70', N'202CB962AC59075B964B07152D234B70', 0)
SET IDENTITY_INSERT [dbo].[Users] OFF
GO
/****** Object:  Index [IX_CartDetails_CartID]    Script Date: 6/18/2022 8:02:20 PM ******/
CREATE NONCLUSTERED INDEX [IX_CartDetails_CartID] ON [dbo].[CartDetails]
(
	[CartID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [IX_CartDetails_MonAnId]    Script Date: 6/18/2022 8:02:20 PM ******/
CREATE NONCLUSTERED INDEX [IX_CartDetails_MonAnId] ON [dbo].[CartDetails]
(
	[MonAnId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [IX_Carts_UserID]    Script Date: 6/18/2022 8:02:20 PM ******/
CREATE NONCLUSTERED INDEX [IX_Carts_UserID] ON [dbo].[Carts]
(
	[UserID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [IX_Foods_Category]    Script Date: 6/18/2022 8:02:20 PM ******/
CREATE NONCLUSTERED INDEX [IX_Foods_Category] ON [dbo].[Foods]
(
	[Category] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [IX_Users_Role]    Script Date: 6/18/2022 8:02:20 PM ******/
CREATE NONCLUSTERED INDEX [IX_Users_Role] ON [dbo].[Users]
(
	[Role] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
ALTER TABLE [dbo].[CartDetails]  WITH CHECK ADD  CONSTRAINT [FK_CartDetails_Carts_CartID] FOREIGN KEY([CartID])
REFERENCES [dbo].[Carts] ([CartID])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[CartDetails] CHECK CONSTRAINT [FK_CartDetails_Carts_CartID]
GO
ALTER TABLE [dbo].[CartDetails]  WITH CHECK ADD  CONSTRAINT [FK_CartDetails_Foods_MonAnId] FOREIGN KEY([MonAnId])
REFERENCES [dbo].[Foods] ([MonAnId])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[CartDetails] CHECK CONSTRAINT [FK_CartDetails_Foods_MonAnId]
GO
ALTER TABLE [dbo].[Carts]  WITH CHECK ADD  CONSTRAINT [FK_Carts_Users_UserID] FOREIGN KEY([UserID])
REFERENCES [dbo].[Users] ([NguoiDungId])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Carts] CHECK CONSTRAINT [FK_Carts_Users_UserID]
GO
ALTER TABLE [dbo].[Foods]  WITH CHECK ADD  CONSTRAINT [FK_Foods_Food_Category_Category] FOREIGN KEY([Category])
REFERENCES [dbo].[Food_Category] ([CategoryId])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Foods] CHECK CONSTRAINT [FK_Foods_Food_Category_Category]
GO
USE [master]
GO
ALTER DATABASE [ASM_C5] SET  READ_WRITE 
GO
