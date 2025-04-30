IF EXISTS (SELECT * FROM sys.databases WHERE name = N'pttk')
DROP DATABASE [pttk]
GO

CREATE DATABASE [pttk]
GO

USE [pttk]
GO

/****** Object:  Table [dbo].[chi_tiet_phieu_dang_ky]    Script Date: 05/04/2025 22:43:23 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[chi_tiet_phieu_dang_ky]
(
    [ma_phieu_dang_ky] [int] NOT NULL,
    [ma_ky_thi] [int] NOT NULL,
    [ma_thi_sinh] [int] NOT NULL,
    PRIMARY KEY CLUSTERED 
(
	[ma_phieu_dang_ky] ASC,
	[ma_ky_thi] ASC,
	[ma_thi_sinh] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[chuc_vu_nhan_vien]    Script Date: 05/04/2025 22:43:23 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[chuc_vu_nhan_vien]
(
    [ma_chuc_vu] [int] NOT NULL,
    [ten_chuc_vu] [varchar](50) NULL,
    PRIMARY KEY CLUSTERED 
(
	[ma_chuc_vu] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[chung_chi_thi_sinh]    Script Date: 05/04/2025 22:43:23 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[chung_chi_thi_sinh]
(
    [ma_chung_chi] [int] NOT NULL,
    [ma_thi_sinh] [int] NOT NULL,
    [ngay_cap] [date] NOT NULL,
    [ngay_het_han] [date] NULL,
    PRIMARY KEY CLUSTERED 
(
	[ma_chung_chi] ASC,
	[ma_thi_sinh] ASC,
	[ngay_cap] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[danh_sach_chung_chi]    Script Date: 05/04/2025 22:43:23 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[danh_sach_chung_chi]
(
    [ma_chung_chi] [int] NOT NULL,
    [ten_chung_chi] [varchar](100) NULL,
    [don_vi_cap] [varchar](100) NULL,
	[gia_tien] [decimal] (7,2) NOT NULL,
    PRIMARY KEY CLUSTERED 
(
	[ma_chung_chi] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[gac_thi]    Script Date: 05/04/2025 22:43:23 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[gac_thi]
(
    [ma_ky_thi] [int] NULL,
    [ma_nhan_vien] [int] NULL,
    [thoi_gian_bat_dau] [datetime] NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[hoa_don_thanh_toan]    Script Date: 05/04/2025 22:43:23 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[hoa_don_thanh_toan]
(
    [ma_thanh_toan] [int] NOT NULL,
    [loai_thanh_toan] [varchar](20) NULL,
    [hinh_thuc_thanh_toan] [varchar](20) NULL,
    [so_tien] [decimal](10, 2) NULL,
    [giam_gia] [decimal](4, 2) NULL,
    [ngay_thanh_toan] [datetime] NULL,
    [ma_giao_dich] [varchar](50) NULL,
    [ma_nhan_vien] [int] NULL,
    PRIMARY KEY CLUSTERED 
(
	[ma_thanh_toan] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ky_thi]    Script Date: 05/04/2025 22:43:23 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ky_thi]
(
    [ma_ky_thi] [int] NOT NULL,
    [ma_chung_chi] [int] NULL,
    [so_phong] [int] NULL,
    [dia_diem] [nvarchar](255) NULL,
    [ten_ky_thi] [nvarchar](100) NULL,
    [mo_ta] [nvarchar](255) NULL,
    [thoi_gian_bat_dau] [datetime] NULL,
    [thoi_luong_thi] [int] NULL,
    [so_luong_dang_ky_hien_tai] [int] NULL,
    [so_luong_toi_da] [int] NULL,
    PRIMARY KEY CLUSTERED 
(
	[ma_ky_thi] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ky_thi_du_tinh]    Script Date: 05/04/2025 22:43:23 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ky_thi_du_tinh]
(
    [ma_ky_thi_du_tinh] [int] NOT NULL,
    [ma_chung_chi] [int] NULL,
    [thoi_gian_bat_dau] [datetime] NULL,
    [so_luong_dang_ky_hien_tai] [int] NULL,
    PRIMARY KEY CLUSTERED 
(
	[ma_ky_thi_du_tinh] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[nguoi_dang_ky]    Script Date: 05/04/2025 22:43:23 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[nguoi_dang_ky]
(
    [ma_nguoi_dang_ky] [int] NOT NULL,
    [ho_ten] [nvarchar](50) NULL,
    [ngay_sinh] [date] NULL,
    [so_dien_thoai] [char](10) NULL,
    [email] [varchar](50) NULL,
    [don_vi] [nvarchar](100) NULL,
    PRIMARY KEY CLUSTERED 
(
	[ma_nguoi_dang_ky] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[nhan_vien]    Script Date: 05/04/2025 22:43:23 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[nhan_vien]
(
    [ma_nhan_vien] [int] NOT NULL,
    [ho_ten] [nvarchar](50) NULL,
    [ngay_sinh] [date] NULL,
    [so_dien_thoai] [char](10) NULL,
    [email] [varchar](50) NULL,
    [chuc_vu] [int] NULL,
    PRIMARY KEY CLUSTERED 
(
	[ma_nhan_vien] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[phieu_dang_ky]    Script Date: 05/04/2025 22:43:23 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[phieu_dang_ky]
(
    [ma_phieu_dang_ky] [int] NOT NULL,
    [ngay_dang_ky] [datetime] NULL,
    [ma_thanh_toan] [int] NULL,
    [tong_tien] [decimal](10, 2) NULL,
    [nguoi_tiep_nhan] [int] NULL,
    [ma_nguoi_dang_ky] [int] NULL,
    PRIMARY KEY CLUSTERED 
(
	[ma_phieu_dang_ky] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[phieu_du_thi]    Script Date: 05/04/2025 22:43:23 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[phieu_du_thi]
(
    [ma_phieu_du_thi] [int] NOT NULL,
    [ma_thi_sinh] [int] NULL,
    [ma_ky_thi] [int] NULL,
    [so_bao_danh] [varchar](20) NULL,
    [diem] [float] NULL,
    PRIMARY KEY CLUSTERED 
(
	[ma_phieu_du_thi] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[phieu_gia_han]    Script Date: 05/04/2025 22:43:23 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[phieu_gia_han]
(
    [ma_phieu_gia_han] [int] NOT NULL,
    [ma_thanh_toan] [int] NULL,
    [ma_ky_thi_cu] [int] NULL,
    [ma_ky_thi_moi] [int] NULL,
    [phieu_du_thi] [int] NULL,
    [so_lan] [int] NULL,
    [ngay_gia_han] [datetime] NULL,
    [phi_gia_han] [decimal](10, 2) NULL,
    [trang_thai_thanh_toan] [bit] NULL,
    [ly_do] [nvarchar](255) NULL,
    [truong_hop_dac_biet] [bit] NULL,
    [thoi_gian_thi_moi] [datetime] NULL,
    [ma_nhan_vien] [int] NULL,
    PRIMARY KEY CLUSTERED 
(
	[ma_phieu_gia_han] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[phong]    Script Date: 05/04/2025 22:43:23 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[phong]
(
    [so_phong] [int] NOT NULL,
    [dia_diem] [nvarchar](255) NOT NULL,
    [loai_phong] [varchar](50) NULL,
    PRIMARY KEY CLUSTERED 
(
	[so_phong] ASC,
	[dia_diem] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tai_khoan]    Script Date: 05/04/2025 22:43:23 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tai_khoan]
(
    [tai_khoan] [varchar](50) NOT NULL,
    [mat_khau] [varchar](255) NULL,
    PRIMARY KEY CLUSTERED 
(
	[tai_khoan] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[thi_sinh]    Script Date: 05/04/2025 22:43:23 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[thi_sinh]
(
    [ma_thi_sinh] [int] NOT NULL,
    [ho_ten] [nvarchar](50) NULL,
    [ngay_sinh] [date] NULL,
    [so_dien_thoai] [char](10) NULL,
    [email] [varchar](50) NULL,
    [created_at] [datetime] NULL,
    PRIMARY KEY CLUSTERED 
(
	[ma_thi_sinh] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[chi_tiet_phieu_dang_ky]  WITH CHECK ADD FOREIGN KEY([ma_ky_thi])
REFERENCES [dbo].[ky_thi] ([ma_ky_thi])
GO
ALTER TABLE [dbo].[chi_tiet_phieu_dang_ky]  WITH CHECK ADD FOREIGN KEY([ma_phieu_dang_ky])
REFERENCES [dbo].[phieu_dang_ky] ([ma_phieu_dang_ky])
GO
ALTER TABLE [dbo].[chi_tiet_phieu_dang_ky]  WITH CHECK ADD FOREIGN KEY([ma_thi_sinh])
REFERENCES [dbo].[thi_sinh] ([ma_thi_sinh])
GO
ALTER TABLE [dbo].[chung_chi_thi_sinh]  WITH CHECK ADD FOREIGN KEY([ma_chung_chi])
REFERENCES [dbo].[danh_sach_chung_chi] ([ma_chung_chi])
GO
ALTER TABLE [dbo].[chung_chi_thi_sinh]  WITH CHECK ADD FOREIGN KEY([ma_thi_sinh])
REFERENCES [dbo].[thi_sinh] ([ma_thi_sinh])
GO
ALTER TABLE [dbo].[gac_thi]  WITH CHECK ADD FOREIGN KEY([ma_ky_thi])
REFERENCES [dbo].[ky_thi] ([ma_ky_thi])
GO
ALTER TABLE [dbo].[gac_thi]  WITH CHECK ADD FOREIGN KEY([ma_nhan_vien])
REFERENCES [dbo].[nhan_vien] ([ma_nhan_vien])
GO
ALTER TABLE [dbo].[hoa_don_thanh_toan]  WITH CHECK ADD FOREIGN KEY([ma_nhan_vien])
REFERENCES [dbo].[nhan_vien] ([ma_nhan_vien])
GO
ALTER TABLE [dbo].[ky_thi]  WITH CHECK ADD FOREIGN KEY([so_phong], [dia_diem])
REFERENCES [dbo].[phong] ([so_phong], [dia_diem])
GO
ALTER TABLE [dbo].[ky_thi]  WITH CHECK ADD FOREIGN KEY([ma_chung_chi])
REFERENCES [dbo].[danh_sach_chung_chi] ([ma_chung_chi])
GO
ALTER TABLE [dbo].[ky_thi_du_tinh]  WITH CHECK ADD FOREIGN KEY([ma_chung_chi])
REFERENCES [dbo].[danh_sach_chung_chi] ([ma_chung_chi])
GO
ALTER TABLE [dbo].[nhan_vien]  WITH CHECK ADD FOREIGN KEY([chuc_vu])
REFERENCES [dbo].[chuc_vu_nhan_vien] ([ma_chuc_vu])
GO
ALTER TABLE [dbo].[phieu_dang_ky]  WITH CHECK ADD FOREIGN KEY([ma_nguoi_dang_ky])
REFERENCES [dbo].[nguoi_dang_ky] ([ma_nguoi_dang_ky])
GO
ALTER TABLE [dbo].[phieu_dang_ky]  WITH CHECK ADD FOREIGN KEY([nguoi_tiep_nhan])
REFERENCES [dbo].[nhan_vien] ([ma_nhan_vien])
GO
ALTER TABLE [dbo].[phieu_du_thi]  WITH CHECK ADD FOREIGN KEY([ma_ky_thi])
REFERENCES [dbo].[ky_thi] ([ma_ky_thi])
GO
ALTER TABLE [dbo].[phieu_du_thi]  WITH CHECK ADD FOREIGN KEY([ma_thi_sinh])
REFERENCES [dbo].[thi_sinh] ([ma_thi_sinh])
GO
ALTER TABLE [dbo].[phieu_gia_han]  WITH CHECK ADD FOREIGN KEY([ma_ky_thi_cu])
REFERENCES [dbo].[ky_thi] ([ma_ky_thi])
GO
ALTER TABLE [dbo].[phieu_gia_han]  WITH CHECK ADD FOREIGN KEY([ma_ky_thi_moi])
REFERENCES [dbo].[ky_thi] ([ma_ky_thi])
GO
ALTER TABLE [dbo].[phieu_gia_han]  WITH CHECK ADD FOREIGN KEY([ma_nhan_vien])
REFERENCES [dbo].[nhan_vien] ([ma_nhan_vien])
GO
ALTER TABLE [dbo].[phieu_gia_han]  WITH CHECK ADD FOREIGN KEY([ma_thanh_toan])
REFERENCES [dbo].[hoa_don_thanh_toan] ([ma_thanh_toan])
GO
ALTER TABLE [dbo].[phieu_gia_han]  WITH CHECK ADD FOREIGN KEY([phieu_du_thi])
REFERENCES [dbo].[phieu_du_thi] ([ma_phieu_du_thi])
GO
ALTER TABLE [dbo].[ky_thi]  WITH CHECK ADD CHECK  (([so_luong_dang_ky_hien_tai]<=[so_luong_toi_da]))
GO

ALTER TABLE [dbo].[phieu_dang_ky]  WITH CHECK ADD FOREIGN KEY([ma_thanh_toan])
REFERENCES [dbo].[hoa_don_thanh_toan] ([ma_thanh_toan])
GO