USE [QLTV]
GO
/****** Object:  Table [dbo].[CTHoaDon]    Script Date: 12/16/2024 11:08:56 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CTHoaDon](
	[MaHoaDon] [nvarchar](50) NULL,
	[TenSach] [nvarchar](50) NULL,
	[SoLuong] [int] NULL,
	[DonGia] [money] NULL,
	[ThanhTien] [int] NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[DangNhap]    Script Date: 12/16/2024 11:08:56 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DangNhap](
	[username] [nchar](10) NOT NULL,
	[password] [nchar](10) NULL,
	[role] [nchar](10) NULL,
 CONSTRAINT [PK_DangNhap] PRIMARY KEY CLUSTERED 
(
	[username] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[HoaDon]    Script Date: 12/16/2024 11:08:56 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[HoaDon](
	[MaHoaDon] [nvarchar](50) NULL,
	[MaThanhVien] [nvarchar](50) NULL,
	[MaNhanVien] [nvarchar](50) NULL,
	[TongTien] [int] NULL,
	[NgayLap] [date] NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[NhanVien]    Script Date: 12/16/2024 11:08:56 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[NhanVien](
	[MaNhanVien] [nvarchar](50) NULL,
	[TenNhanVien] [nvarchar](50) NULL,
	[ChucVu] [nvarchar](50) NULL,
	[DiaChi] [nvarchar](50) NULL,
	[DienThoai] [int] NULL,
	[Email] [nvarchar](50) NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Sach]    Script Date: 12/16/2024 11:08:56 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Sach](
	[MaSach] [nchar](10) NULL,
	[TenSach] [nvarchar](50) NULL,
	[TacGia] [nvarchar](50) NULL,
	[NhaXuatBan] [nvarchar](50) NULL,
	[NgayXuatBan] [date] NULL,
	[Gia] [int] NULL,
	[SoLuong] [int] NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TacGia]    Script Date: 12/16/2024 11:08:56 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TacGia](
	[MaTacGia] [int] NOT NULL,
	[TenTacGia] [nvarchar](50) NULL,
	[GioiThieu] [nvarchar](50) NULL,
	[DiaChi] [nvarchar](50) NULL,
	[DienThoai] [nvarchar](50) NULL,
	[Email] [nvarchar](50) NULL,
 CONSTRAINT [PK_TacGia] PRIMARY KEY CLUSTERED 
(
	[MaTacGia] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ThanhVien]    Script Date: 12/16/2024 11:08:56 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ThanhVien](
	[MaThanhVien] [nvarchar](50) NULL,
	[TenThanhVien] [nvarchar](50) NULL,
	[DienThoai] [nchar](10) NULL,
	[Email] [nvarchar](50) NULL
) ON [PRIMARY]
GO
INSERT [dbo].[CTHoaDon] ([MaHoaDon], [TenSach], [SoLuong], [DonGia], [ThanhTien]) VALUES (N'HD01', N'Định Mệnh', 2, 10.0000, 20)
INSERT [dbo].[CTHoaDon] ([MaHoaDon], [TenSach], [SoLuong], [DonGia], [ThanhTien]) VALUES (N'HD01', N'Mất', 1, 20.0000, 20)
INSERT [dbo].[CTHoaDon] ([MaHoaDon], [TenSach], [SoLuong], [DonGia], [ThanhTien]) VALUES (N'HD02', N'Định Mệnh', 2, 10.0000, 20)
INSERT [dbo].[CTHoaDon] ([MaHoaDon], [TenSach], [SoLuong], [DonGia], [ThanhTien]) VALUES (N'HD02', N'Địa Đàng', 2, 100.0000, 200)
INSERT [dbo].[CTHoaDon] ([MaHoaDon], [TenSach], [SoLuong], [DonGia], [ThanhTien]) VALUES (N'HD03', N'Định Mệnh', 2, 10.0000, 20)
INSERT [dbo].[CTHoaDon] ([MaHoaDon], [TenSach], [SoLuong], [DonGia], [ThanhTien]) VALUES (N'HD04', N'Biển', 1, 400.0000, 400)
INSERT [dbo].[CTHoaDon] ([MaHoaDon], [TenSach], [SoLuong], [DonGia], [ThanhTien]) VALUES (N'HD07', N'Định Mệnh', 2, 10.0000, 20)
INSERT [dbo].[CTHoaDon] ([MaHoaDon], [TenSach], [SoLuong], [DonGia], [ThanhTien]) VALUES (N'HD07', N'Mắt Đen', 2, 200.0000, 400)
INSERT [dbo].[CTHoaDon] ([MaHoaDon], [TenSach], [SoLuong], [DonGia], [ThanhTien]) VALUES (N'HD07', N'Biển', 1, 400.0000, 400)
INSERT [dbo].[CTHoaDon] ([MaHoaDon], [TenSach], [SoLuong], [DonGia], [ThanhTien]) VALUES (N'HD09', N'Định Mệnh', 2, 10.0000, 20)
INSERT [dbo].[CTHoaDon] ([MaHoaDon], [TenSach], [SoLuong], [DonGia], [ThanhTien]) VALUES (N'HD09', N'Mắt Đen', 2, 200.0000, 400)
INSERT [dbo].[CTHoaDon] ([MaHoaDon], [TenSach], [SoLuong], [DonGia], [ThanhTien]) VALUES (N'HD10', N'Định Mệnh', 2, 10.0000, 20)
INSERT [dbo].[CTHoaDon] ([MaHoaDon], [TenSach], [SoLuong], [DonGia], [ThanhTien]) VALUES (N'HD10', N'Địa Đàng', 2, 100.0000, 200)
INSERT [dbo].[CTHoaDon] ([MaHoaDon], [TenSach], [SoLuong], [DonGia], [ThanhTien]) VALUES (N'HD06', N'Định Mệnh', 2, 10.0000, 20)
INSERT [dbo].[CTHoaDon] ([MaHoaDon], [TenSach], [SoLuong], [DonGia], [ThanhTien]) VALUES (N'HD05', N'Định Mệnh', 2, 10.0000, 20)
INSERT [dbo].[CTHoaDon] ([MaHoaDon], [TenSach], [SoLuong], [DonGia], [ThanhTien]) VALUES (N'HD05', N'Địa Đàng', 2, 100.0000, 200)
INSERT [dbo].[CTHoaDon] ([MaHoaDon], [TenSach], [SoLuong], [DonGia], [ThanhTien]) VALUES (N'HD06', N'Mắt Đen', 1, 200.0000, 200)
INSERT [dbo].[CTHoaDon] ([MaHoaDon], [TenSach], [SoLuong], [DonGia], [ThanhTien]) VALUES (N'HD08', N'Địa Đàng', 2, 100.0000, 200)
INSERT [dbo].[CTHoaDon] ([MaHoaDon], [TenSach], [SoLuong], [DonGia], [ThanhTien]) VALUES (N'HD08', N'Biển', 2, 400.0000, 800)
INSERT [dbo].[CTHoaDon] ([MaHoaDon], [TenSach], [SoLuong], [DonGia], [ThanhTien]) VALUES (N'HD08', N'Mất', 2, 20.0000, 40)
GO
INSERT [dbo].[DangNhap] ([username], [password], [role]) VALUES (N'1         ', N'1         ', N'guess     ')
INSERT [dbo].[DangNhap] ([username], [password], [role]) VALUES (N'chien22   ', N'Jigoku123!', N'guess     ')
INSERT [dbo].[DangNhap] ([username], [password], [role]) VALUES (N'DucHuy    ', N'456       ', N'Guess     ')
INSERT [dbo].[DangNhap] ([username], [password], [role]) VALUES (N'HoangChien', N'123       ', N'admin     ')
GO
INSERT [dbo].[HoaDon] ([MaHoaDon], [MaThanhVien], [MaNhanVien], [TongTien], [NgayLap]) VALUES (N'HD01', N'TV02', N'NV01', 40, CAST(N'2024-12-12' AS Date))
INSERT [dbo].[HoaDon] ([MaHoaDon], [MaThanhVien], [MaNhanVien], [TongTien], [NgayLap]) VALUES (N'HD02', N'TV01', N'NV03', 220, CAST(N'2024-12-14' AS Date))
INSERT [dbo].[HoaDon] ([MaHoaDon], [MaThanhVien], [MaNhanVien], [TongTien], [NgayLap]) VALUES (N'HD03', N'TV03', N'NV01', 20, CAST(N'2024-12-15' AS Date))
INSERT [dbo].[HoaDon] ([MaHoaDon], [MaThanhVien], [MaNhanVien], [TongTien], [NgayLap]) VALUES (N'HD04', N'TV01', N'NV02', 400, CAST(N'2024-12-15' AS Date))
INSERT [dbo].[HoaDon] ([MaHoaDon], [MaThanhVien], [MaNhanVien], [TongTien], [NgayLap]) VALUES (N'HD07', N'TV03', N'NV04', 820, CAST(N'2024-12-15' AS Date))
INSERT [dbo].[HoaDon] ([MaHoaDon], [MaThanhVien], [MaNhanVien], [TongTien], [NgayLap]) VALUES (N'HD09', N'TV02', N'NV01', 420, CAST(N'2024-12-15' AS Date))
INSERT [dbo].[HoaDon] ([MaHoaDon], [MaThanhVien], [MaNhanVien], [TongTien], [NgayLap]) VALUES (N'HD10', N'TV02', N'NV03', 220, CAST(N'2024-12-16' AS Date))
INSERT [dbo].[HoaDon] ([MaHoaDon], [MaThanhVien], [MaNhanVien], [TongTien], [NgayLap]) VALUES (N'HD06', N'TV02', N'NV01', 220, CAST(N'2024-12-15' AS Date))
INSERT [dbo].[HoaDon] ([MaHoaDon], [MaThanhVien], [MaNhanVien], [TongTien], [NgayLap]) VALUES (N'HD05', N'TV01', N'NV09', 220, CAST(N'2024-12-15' AS Date))
GO
INSERT [dbo].[NhanVien] ([MaNhanVien], [TenNhanVien], [ChucVu], [DiaChi], [DienThoai], [Email]) VALUES (N'NV01', N'Nguyễn Văn Tinh', N'Thủ Thư', N'Hải Dương', 342656390, N'ThuThu@gmail.com')
INSERT [dbo].[NhanVien] ([MaNhanVien], [TenNhanVien], [ChucVu], [DiaChi], [DienThoai], [Email]) VALUES (N'NV02', N'Nguyễn Thị Phượng', N'Thủ Thư', N'Hải Phòng', 312312133, N'Phuong21@gmail.com')
INSERT [dbo].[NhanVien] ([MaNhanVien], [TenNhanVien], [ChucVu], [DiaChi], [DienThoai], [Email]) VALUES (N'NV03', N'Nguyễn Tinh Cao', N'Bảo Vệ', N'Hà Nội', 141241241, N'Cao33@gmail.com')
INSERT [dbo].[NhanVien] ([MaNhanVien], [TenNhanVien], [ChucVu], [DiaChi], [DienThoai], [Email]) VALUES (N'NV04', N'Đinh Văn Cứ', N'Quản Trị Viên ', N'Hà Nội', 412412412, N'AC@gmail.com')
GO
INSERT [dbo].[Sach] ([MaSach], [TenSach], [TacGia], [NhaXuatBan], [NgayXuatBan], [Gia], [SoLuong]) VALUES (N'S01       ', N'Định Mệnh', N'Vũ Đức Huy', N'HDC', CAST(N'2004-10-22' AS Date), 10, 16)
INSERT [dbo].[Sach] ([MaSach], [TenSach], [TacGia], [NhaXuatBan], [NgayXuatBan], [Gia], [SoLuong]) VALUES (N'S02       ', N'Mắt Đen', N'Vũ Kim Phúc Dương', N'ABC', CAST(N'2010-02-20' AS Date), 200, 48)
INSERT [dbo].[Sach] ([MaSach], [TenSach], [TacGia], [NhaXuatBan], [NgayXuatBan], [Gia], [SoLuong]) VALUES (N'S03       ', N'Địa Đàng', N'Nguyễn Thành Vinh', N'HDC', CAST(N'2024-01-11' AS Date), 100, 14)
INSERT [dbo].[Sach] ([MaSach], [TenSach], [TacGia], [NhaXuatBan], [NgayXuatBan], [Gia], [SoLuong]) VALUES (N'S04       ', N'Núi', N'Nguyễn Thị Mai', N'ABC', CAST(N'2022-10-10' AS Date), 350, 30)
INSERT [dbo].[Sach] ([MaSach], [TenSach], [TacGia], [NhaXuatBan], [NgayXuatBan], [Gia], [SoLuong]) VALUES (N'S05       ', N'Biển', N'Nguyễn Thị Mai', N'ABC', CAST(N'2024-10-10' AS Date), 400, 34)
INSERT [dbo].[Sach] ([MaSach], [TenSach], [TacGia], [NhaXuatBan], [NgayXuatBan], [Gia], [SoLuong]) VALUES (N'S06       ', N'Mất', N'Vũ Đức Huy', N'HDC', CAST(N'2000-10-10' AS Date), 20, 9)
INSERT [dbo].[Sach] ([MaSach], [TenSach], [TacGia], [NhaXuatBan], [NgayXuatBan], [Gia], [SoLuong]) VALUES (N'S07       ', N'Đôi Mắt', N'Vũ Kim Phúc Dương', N'ABC', CAST(N'2010-10-10' AS Date), 22, 44)
INSERT [dbo].[Sach] ([MaSach], [TenSach], [TacGia], [NhaXuatBan], [NgayXuatBan], [Gia], [SoLuong]) VALUES (N'S08       ', N'Chiến Thắng ', N'Hoàng Đức Chiến', N'BCD', CAST(N'2004-10-22' AS Date), 500, 23)
INSERT [dbo].[Sach] ([MaSach], [TenSach], [TacGia], [NhaXuatBan], [NgayXuatBan], [Gia], [SoLuong]) VALUES (N'S09       ', N'Đạt Được', N'Minh Hoàng Vũ', N'HDC', CAST(N'2002-12-01' AS Date), 100, 23)
INSERT [dbo].[Sach] ([MaSach], [TenSach], [TacGia], [NhaXuatBan], [NgayXuatBan], [Gia], [SoLuong]) VALUES (N'S10       ', N'Mai', N'Nguyễn Thành Vinh', N'HDC', CAST(N'2023-10-10' AS Date), 100, 43)
INSERT [dbo].[Sach] ([MaSach], [TenSach], [TacGia], [NhaXuatBan], [NgayXuatBan], [Gia], [SoLuong]) VALUES (N'S11       ', N'Vạn Nhất', N'Đinh Anh', N'HDC', CAST(N'2010-02-10' AS Date), 22, 35)
GO
INSERT [dbo].[TacGia] ([MaTacGia], [TenTacGia], [GioiThieu], [DiaChi], [DienThoai], [Email]) VALUES (1, N'Vũ Đức Huy', N'GT 1', N'HaNoi', N'032456', N'A@gmail.com')
INSERT [dbo].[TacGia] ([MaTacGia], [TenTacGia], [GioiThieu], [DiaChi], [DienThoai], [Email]) VALUES (2, N'Vũ Kim Phúc Dương', N'GT 2', N'HaiPhong', N'064446', N'B@gmail.com')
INSERT [dbo].[TacGia] ([MaTacGia], [TenTacGia], [GioiThieu], [DiaChi], [DienThoai], [Email]) VALUES (3, N'Nguyễn Thị Mai', N'GT3', N'NamDinh', N'042445', N'C@gmail.com')
INSERT [dbo].[TacGia] ([MaTacGia], [TenTacGia], [GioiThieu], [DiaChi], [DienThoai], [Email]) VALUES (4, N'Nguyễn Thành Vinh', N'GT4', N'ThanhHoa', N'034545', N'D@gmail.com')
INSERT [dbo].[TacGia] ([MaTacGia], [TenTacGia], [GioiThieu], [DiaChi], [DienThoai], [Email]) VALUES (5, N'Hoàng Đức Chiến', N'GT5', N'HaNoi', N'025484', N'E@gmail.com')
INSERT [dbo].[TacGia] ([MaTacGia], [TenTacGia], [GioiThieu], [DiaChi], [DienThoai], [Email]) VALUES (6, N'Minh Hoàng Vũ', N'GT6', N'HaNoi', N'021545', N'V@gmail.com')
GO
INSERT [dbo].[ThanhVien] ([MaThanhVien], [TenThanhVien], [DienThoai], [Email]) VALUES (N'TV09', N'Định Thị J', N'026156165 ', N'J@gmail.com')
INSERT [dbo].[ThanhVien] ([MaThanhVien], [TenThanhVien], [DienThoai], [Email]) VALUES (N'TV02', N'Vũ Đức Huy', N'0123456789', N'Huy@gmail.com')
INSERT [dbo].[ThanhVien] ([MaThanhVien], [TenThanhVien], [DienThoai], [Email]) VALUES (N'TV03', N'Nguyễn Thị A', N'0987654321', N'A@gmail.com')
INSERT [dbo].[ThanhVien] ([MaThanhVien], [TenThanhVien], [DienThoai], [Email]) VALUES (N'TV04', N'Nguyễn Văn B', N'0753951456', N'B@gmail.com')
INSERT [dbo].[ThanhVien] ([MaThanhVien], [TenThanhVien], [DienThoai], [Email]) VALUES (N'TV05', N'Nguyễn Thị C', N'0546465165', N'C@gmail.com')
INSERT [dbo].[ThanhVien] ([MaThanhVien], [TenThanhVien], [DienThoai], [Email]) VALUES (N'TV06', N'Nguyễn Thị D', N'0645465465', N'D@gmail.com')
INSERT [dbo].[ThanhVien] ([MaThanhVien], [TenThanhVien], [DienThoai], [Email]) VALUES (N'TV07', N'Nguyễn Đinh E', N'0564651166', N'E@gmail.com')
INSERT [dbo].[ThanhVien] ([MaThanhVien], [TenThanhVien], [DienThoai], [Email]) VALUES (N'TV08', N'Nguyễn Đích F', N'0564654656', N'F@gmail.com')
INSERT [dbo].[ThanhVien] ([MaThanhVien], [TenThanhVien], [DienThoai], [Email]) VALUES (N'TV01', N'Hoàng Đức Chiến', N'0615615616', N'Chien@gmail.com')
GO
