USE [pttk] -- Or replace with your actual database name if different
GO

-- Clear existing data (Optional - Use with caution on non-empty databases)
/*
DELETE FROM [dbo].[gac_thi];
DELETE FROM [dbo].[phieu_gia_han];
DELETE FROM [dbo].[hoa_don_thanh_toan];
DELETE FROM [dbo].[chung_chi_thi_sinh];
DELETE FROM [dbo].[phieu_du_thi];
DELETE FROM [dbo].[chi_tiet_phieu_dang_ky];
DELETE FROM [dbo].[phieu_dang_ky];
DELETE FROM [dbo].[ky_thi];
DELETE FROM [dbo].[ky_thi_du_tinh];
DELETE FROM [dbo].[phong];
DELETE FROM [dbo].[nhan_vien];
DELETE FROM [dbo].[chuc_vu_nhan_vien];
DELETE FROM [dbo].[thi_sinh];
DELETE FROM [dbo].[nguoi_dang_ky];
DELETE FROM [dbo].[danh_sach_chung_chi];
DELETE FROM [dbo].[tai_khoan];
GO
*/
-- 1. Populate [dbo].[chuc_vu_nhan_vien] (Staff Roles)
PRINT 'Populating [dbo].[chuc_vu_nhan_vien]...';
INSERT INTO [dbo].[chuc_vu_nhan_vien] ([ma_chuc_vu], [ten_chuc_vu]) VALUES
(1, N'quan_ly'),
(2, N'tiep_nhan'),
(3, N'ke_toan'),
(4, N'nhap_lieu'),
(5, N'giam_thi');
GO

-- 2. Populate [dbo].[danh_sach_chung_chi] (Certificate List)
PRINT 'Populating [dbo].[danh_sach_chung_chi]...';
INSERT INTO [dbo].[danh_sach_chung_chi] ([ma_chung_chi], [ten_chung_chi], [don_vi_cap], [gia_tien]) VALUES
(101, N'TOEIC Listening & Reading', N'ETS', 15000),
(102, N'IELTS Academic', N'British Council / IDP', 47500),
(103, N'MOS Word 2019 Expert', N'Certiport', 9000),
(104, N'MOS Excel 2019 Expert', N'Certiport', 9000),
(105, N'IC3 GS6 Level 1', N'Certiport', 8500),
(106, N'Cambridge B1 Preliminary (PET)', N'Cambridge Assessment English', 18000);
GO

-- 3. Populate [dbo].[phong] (Rooms)
PRINT 'Populating [dbo].[phong]...';
INSERT INTO [dbo].[phong] ([so_phong], [dia_diem], [loai_phong]) VALUES
(101, N'Tòa nhà A, 227 Nguyễn Văn Cừ, P4, Q5, TP.HCM', N'Phòng thi lý thuyết'),
(102, N'Tòa nhà A, 227 Nguyễn Văn Cừ, P4, Q5, TP.HCM', N'Phòng thi lý thuyết'),
(201, N'Tòa nhà B, 227 Nguyễn Văn Cừ, P4, Q5, TP.HCM', N'Phòng thi máy tính'),
(202, N'Tòa nhà B, 227 Nguyễn Văn Cừ, P4, Q5, TP.HCM', N'Phòng thi máy tính'),
(305, N'Cơ sở Thủ Đức, Khu phố 6, Linh Trung, Thủ Đức, TP.HCM', N'Phòng thi lý thuyết');
GO

-- 4. Populate [dbo].[tai_khoan] (Accounts - Example Accounts)
PRINT 'Populating [dbo].[tai_khoan]...';
INSERT INTO [dbo].[tai_khoan] ([tai_khoan], [mat_khau]) VALUES
('1', '12345' ), -- Store hashed passwords in practice
('2', '12345' ),
('3', '12345' ),
('4', '12345' ),
('5', '12345');
GO

-- 5. Populate [dbo].[nhan_vien] (Staff)
PRINT 'Populating [dbo].[nhan_vien]...';
INSERT INTO [dbo].[nhan_vien] ([ma_nhan_vien], [ho_ten], [ngay_sinh], [so_dien_thoai], [email], [chuc_vu]) VALUES
(1, N'Nguyễn Văn An', '1985-03-15', '0901234567', 'an.nv@acci.edu.vn', 1),  -- Quản lý
(2, N'Trần Thị Bình', '1992-07-20', '0912345678', 'binh.tt@acci.edu.vn', 2),  -- Tiếp nhận
(3, N'Lê Minh Cường', '1990-11-01', '0987654321', 'cuong.lm@acci.edu.vn', 3),  -- Kế toán
(4, N'Phạm Thị Dung', '1995-01-25', '0978123456', 'dung.pt@acci.edu.vn', 4),  -- Nhập liệu
(5, N'Hoàng Văn Em', '1988-09-10', '0965432109', 'em.hv@acci.edu.vn', 5),    -- Giám thị
(6, N'Võ Thị Giang', '1993-05-18', '0932109876', 'giang.vt@acci.edu.vn', 2),  -- Tiếp nhận
(7, N'Đỗ Hùng', '1991-12-30', '0945678901', 'hung.d@acci.edu.vn', 5);      -- Giám thị
GO

-- 6. Populate [dbo].[nguoi_dang_ky] (Registrants - Individuals and Organizations)
PRINT 'Populating [dbo].[nguoi_dang_ky]...';
INSERT INTO [dbo].[nguoi_dang_ky] ([ma_nguoi_dang_ky], [ho_ten], [ngay_sinh], [so_dien_thoai], [email], [don_vi]) VALUES
(1001, N'Nguyễn Thu Hà', '1998-06-12', '0911223344', 'ha.nguyen@email.com', NULL), -- Khách tự do
(1002, N'Trần Văn Nam', '1999-02-28', '0922334455', 'nam.tran@email.com', NULL),   -- Khách tự do
(1003, N'Phòng Đào Tạo - Trường THPT Chuyên XYZ', NULL, '0283111222', 'daotao@thptchuyenxyz.edu.vn', N'Trường THPT Chuyên XYZ'), -- Đơn vị
(1004, N'Giáo vụ - Trung tâm Anh ngữ ABC', NULL, '0283999888', 'giaovu@anhnguabc.com', N'Trung tâm Anh ngữ ABC'), -- Đơn vị
(1005, N'Lê Thị Mai', '2001-11-05', '0933445566', 'mai.le@email.com', NULL);       -- Khách tự do
GO

-- 7. Populate [dbo].[thi_sinh] (Candidates)
PRINT 'Populating [dbo].[thi_sinh]...';
INSERT INTO [dbo].[thi_sinh] ([ma_thi_sinh], [ho_ten], [ngay_sinh], [so_dien_thoai], [email], [created_at]) VALUES
(2001, N'Nguyễn Thu Hà', '1998-06-12', '0911223344', 'ha.nguyen@email.com', GETDATE()), -- Cùng người đăng ký
(2002, N'Trần Văn Nam', '1999-02-28', '0922334455', 'nam.tran@email.com', GETDATE()),   -- Cùng người đăng ký
(2003, N'Phạm Hoàng Anh', '2006-01-15', '0944556677', 'anh.pham@student.xyz.edu.vn', GETDATE()), -- Thuộc THPT XYZ
(2004, N'Vũ Ngọc Bích', '2006-03-22', '0955667788', 'bich.vu@student.xyz.edu.vn', GETDATE()),   -- Thuộc THPT XYZ
(2005, N'Đinh Công Danh', '2005-07-30', '0966778899', 'danh.dinh@student.xyz.edu.vn', GETDATE()), -- Thuộc THPT XYZ
(2006, N'Hoàng Mỹ Linh', '2002-09-10', '0977889900', 'linh.hm@anhnguabc.com', GETDATE()),       -- Thuộc TT ABC
(2007, N'Lê Quang Minh', '2003-12-05', '0988990011', 'minh.lq@anhnguabc.com', GETDATE()),       -- Thuộc TT ABC
(2008, N'Ngô Thanh Tâm', '2000-04-18', '0999001122', 'tam.nt@email.com', GETDATE()),         -- Thí sinh khác do Mai đăng ký
(2009, N'Mai Văn Sơn', '2004-08-21', '0919876543', 'son.mv@email.com', GETDATE()),         -- Thí sinh tự do mới
(2010, N'Hà Thị Thu Thủy', '2006-05-11', '0928765432', 'thuy.htt@student.xyz.edu.vn', GETDATE());-- Thuộc THPT XYZ
GO

-- 8. Populate [dbo].[ky_thi_du_tinh] (Planned Exams - Optional, for future planning)
PRINT 'Populating [dbo].[ky_thi_du_tinh]...';
INSERT INTO [dbo].[ky_thi_du_tinh] ([ma_ky_thi_du_tinh], [ma_chung_chi], [thoi_gian_bat_dau], [so_luong_dang_ky_hien_tai]) VALUES
(301, 101, '2025-08-15 08:00:00', 0), -- TOEIC dự kiến tháng 8
(302, 102, '2025-09-10 09:00:00', 0), -- IELTS dự kiến tháng 9
(303, 103, '2025-08-20 14:00:00', 0); -- MOS Word dự kiến tháng 8
GO

-- 9. Populate [dbo].[ky_thi] (Actual Exams)
PRINT 'Populating [dbo].[ky_thi]...';
INSERT INTO [dbo].[ky_thi] ([ma_ky_thi], [ma_chung_chi], [so_phong], [dia_diem], [ten_ky_thi], [mo_ta], [thoi_gian_bat_dau], [thoi_luong_thi], [so_luong_dang_ky_hien_tai], [so_luong_toi_da]) VALUES
(501, 101, 101, N'Tòa nhà A, 227 Nguyễn Văn Cừ, P4, Q5, TP.HCM', N'Kỳ thi TOEIC L&R 2025-06-15 Sáng', N'Kỳ thi cấp chứng chỉ TOEIC Listening & Reading', '2025-06-15 08:30:00', 120, 0, 50),
(502, 102, 102, N'Tòa nhà A, 227 Nguyễn Văn Cừ, P4, Q5, TP.HCM', N'Kỳ thi IELTS Academic 2025-06-22', N'Kỳ thi cấp chứng chỉ IELTS Academic', '2025-06-22 09:00:00', 165, 0, 40),
(503, 103, 201, N'Tòa nhà B, 227 Nguyễn Văn Cừ, P4, Q5, TP.HCM', N'Kỳ thi MOS Word Expert 2025-06-25', N'Kỳ thi cấp chứng chỉ MOS Word 2019 Expert', '2025-06-25 14:00:00', 50, 0, 30),
(504, 105, 202, N'Tòa nhà B, 227 Nguyễn Văn Cừ, P4, Q5, TP.HCM', N'Kỳ thi IC3 GS6 Level 1 2025-06-28', N'Kỳ thi cấp chứng chỉ IC3 GS6 Level 1', '2025-06-28 09:00:00', 150, 0, 30),
(505, 101, 305, N'Cơ sở Thủ Đức, Khu phố 6, Linh Trung, Thủ Đức, TP.HCM', N'Kỳ thi TOEIC L&R 2025-07-05 Chiều', N'Kỳ thi cấp chứng chỉ TOEIC Listening & Reading tại Thủ Đức', '2025-07-05 13:30:00', 120, 0, 60),
(506, 106, 101, N'Tòa nhà A, 227 Nguyễn Văn Cừ, P4, Q5, TP.HCM', N'Kỳ thi Cambridge PET 2025-07-12', N'Kỳ thi cấp chứng chỉ Cambridge B1 Preliminary', '2025-07-12 08:00:00', 140, 0, 40),
(507, 101, 101, N'Tòa nhà A, 227 Nguyễn Văn Cừ, P4, Q5, TP.HCM', N'Kỳ thi TOEIC L&R 2025-08-15 Sáng', N'Kỳ thi cấp chứng chỉ TOEIC Listening & Reading', '2025-08-15 08:00:00', 120, 0, 50);
GO

-- 10. Populate [dbo].[phieu_dang_ky] (Registration Forms)
-- Note: tong_tien will be updated later after chi_tiet_phieu_dang_ky inserts.
-- trang_thai_thanh_toan: 0 = Chưa thanh toán, 1 = Đã thanh toán, 2 = Đã hủy/Quá hạn
PRINT 'Populating [dbo].[phieu_dang_ky]...';
INSERT INTO [dbo].[phieu_dang_ky] ([ma_phieu_dang_ky], [ngay_dang_ky], [trang_thai_thanh_toan], [tong_tien], [nguoi_tiep_nhan], [ma_nguoi_dang_ky]) VALUES
(10001, '2025-05-10 09:15:00', 0, NULL, 2, 1001), -- Hà đăng ký, chưa thanh toán
(10002, '2025-05-11 14:30:00', 0, NULL, 6, 1002), -- Nam đăng ký, chưa thanh toán
(10003, '2025-05-15 10:00:00', 0, NULL, 2, 1003), -- THPT XYZ đăng ký (đơn vị), chưa thanh toán
(10004, '2025-05-20 11:00:00', 0, NULL, 6, 1004), -- TT Anh ngữ ABC đăng ký, chưa thanh toán
(10005, '2025-05-21 08:45:00', 0, NULL, 2, 1005); -- Mai đăng ký, chưa thanh toán
GO

-- 11. Populate [dbo].[chi_tiet_phieu_dang_ky] (Registration Details)
-- This links registrations, exams, and candidates. Update ky_thi counts and phieu_dang_ky totals here.
PRINT 'Populating [dbo].[chi_tiet_phieu_dang_ky] and updating related tables...';

-- Phiếu 10001: Hà đăng ký thi TOEIC
INSERT INTO [dbo].[chi_tiet_phieu_dang_ky] ([ma_phieu_dang_ky], [ma_ky_thi], [ma_thi_sinh]) VALUES (10001, 501, 2001);
UPDATE [dbo].[ky_thi] SET [so_luong_dang_ky_hien_tai] = [so_luong_dang_ky_hien_tai] + 1 WHERE [ma_ky_thi] = 501;
UPDATE [dbo].[phieu_dang_ky] SET [tong_tien] = (SELECT SUM(dscc.gia_tien) FROM [dbo].[chi_tiet_phieu_dang_ky] ctpdk JOIN [dbo].[ky_thi] kt ON ctpdk.ma_ky_thi = kt.ma_ky_thi JOIN [dbo].[danh_sach_chung_chi] dscc ON kt.ma_chung_chi = dscc.ma_chung_chi WHERE ctpdk.ma_phieu_dang_ky = 10001) WHERE [ma_phieu_dang_ky] = 10001;

-- Phiếu 10002: Nam đăng ký thi IELTS
INSERT INTO [dbo].[chi_tiet_phieu_dang_ky] ([ma_phieu_dang_ky], [ma_ky_thi], [ma_thi_sinh]) VALUES (10002, 502, 2002);
UPDATE [dbo].[ky_thi] SET [so_luong_dang_ky_hien_tai] = [so_luong_dang_ky_hien_tai] + 1 WHERE [ma_ky_thi] = 502;
UPDATE [dbo].[phieu_dang_ky] SET [tong_tien] = (SELECT SUM(dscc.gia_tien) FROM [dbo].[chi_tiet_phieu_dang_ky] ctpdk JOIN [dbo].[ky_thi] kt ON ctpdk.ma_ky_thi = kt.ma_ky_thi JOIN [dbo].[danh_sach_chung_chi] dscc ON kt.ma_chung_chi = dscc.ma_chung_chi WHERE ctpdk.ma_phieu_dang_ky = 10002) WHERE [ma_phieu_dang_ky] = 10002;

-- Phiếu 10003: THPT XYZ đăng ký cho 4 học sinh thi IC3 GS6
INSERT INTO [dbo].[chi_tiet_phieu_dang_ky] ([ma_phieu_dang_ky], [ma_ky_thi], [ma_thi_sinh]) VALUES
(10003, 504, 2003),
(10003, 504, 2004),
(10003, 504, 2005),
(10003, 504, 2010);
UPDATE [dbo].[ky_thi] SET [so_luong_dang_ky_hien_tai] = [so_luong_dang_ky_hien_tai] + 4 WHERE [ma_ky_thi] = 504;
UPDATE [dbo].[phieu_dang_ky] SET [tong_tien] = (SELECT SUM(dscc.gia_tien) FROM [dbo].[chi_tiet_phieu_dang_ky] ctpdk JOIN [dbo].[ky_thi] kt ON ctpdk.ma_ky_thi = kt.ma_ky_thi JOIN [dbo].[danh_sach_chung_chi] dscc ON kt.ma_chung_chi = dscc.ma_chung_chi WHERE ctpdk.ma_phieu_dang_ky = 10003) WHERE [ma_phieu_dang_ky] = 10003;

-- Phiếu 10004: TT Anh ngữ ABC đăng ký cho 2 học viên thi PET
INSERT INTO [dbo].[chi_tiet_phieu_dang_ky] ([ma_phieu_dang_ky], [ma_ky_thi], [ma_thi_sinh]) VALUES
(10004, 506, 2006),
(10004, 506, 2007);
UPDATE [dbo].[ky_thi] SET [so_luong_dang_ky_hien_tai] = [so_luong_dang_ky_hien_tai] + 2 WHERE [ma_ky_thi] = 506;
UPDATE [dbo].[phieu_dang_ky] SET [tong_tien] = (SELECT SUM(dscc.gia_tien) FROM [dbo].[chi_tiet_phieu_dang_ky] ctpdk JOIN [dbo].[ky_thi] kt ON ctpdk.ma_ky_thi = kt.ma_ky_thi JOIN [dbo].[danh_sach_chung_chi] dscc ON kt.ma_chung_chi = dscc.ma_chung_chi WHERE ctpdk.ma_phieu_dang_ky = 10004) WHERE [ma_phieu_dang_ky] = 10004;

-- Phiếu 10005: Mai đăng ký cho Tâm thi MOS Word và Sơn thi TOEIC
INSERT INTO [dbo].[chi_tiet_phieu_dang_ky] ([ma_phieu_dang_ky], [ma_ky_thi], [ma_thi_sinh]) VALUES
(10005, 503, 2008), -- Tâm thi MOS
(10005, 505, 2009); -- Sơn thi TOEIC
UPDATE [dbo].[ky_thi] SET [so_luong_dang_ky_hien_tai] = [so_luong_dang_ky_hien_tai] + 1 WHERE [ma_ky_thi] = 503;
UPDATE [dbo].[ky_thi] SET [so_luong_dang_ky_hien_tai] = [so_luong_dang_ky_hien_tai] + 1 WHERE [ma_ky_thi] = 505;
UPDATE [dbo].[phieu_dang_ky] SET [tong_tien] = (SELECT SUM(dscc.gia_tien) FROM [dbo].[chi_tiet_phieu_dang_ky] ctpdk JOIN [dbo].[ky_thi] kt ON ctpdk.ma_ky_thi = kt.ma_ky_thi JOIN [dbo].[danh_sach_chung_chi] dscc ON kt.ma_chung_chi = dscc.ma_chung_chi WHERE ctpdk.ma_phieu_dang_ky = 10005) WHERE [ma_phieu_dang_ky] = 10005;

GO

-- 12. Populate [dbo].[hoa_don_thanh_toan] (Payment Invoices)
-- Simulate some payments and update phieu_dang_ky status.
PRINT 'Populating [dbo].[hoa_don_thanh_toan] and updating payment status...';

-- Thanh toán cho phiếu 10001 (Hà) - Tiền mặt
INSERT INTO [dbo].[hoa_don_thanh_toan] ([ma_thanh_toan], [loai_thanh_toan], [hinh_thuc_thanh_toan], [so_tien], [giam_gia], [ngay_thanh_toan], [ma_giao_dich], [ma_nhan_vien])
VALUES (20001, 'dang_ky', 'tien_mat', (SELECT tong_tien FROM phieu_dang_ky WHERE ma_phieu_dang_ky = 10001), 0.00, '2025-05-12 10:00:00', 'TM20250512001', 3);
UPDATE [dbo].[phieu_dang_ky] SET [trang_thai_thanh_toan] = 1 WHERE [ma_phieu_dang_ky] = 10001;

-- Thanh toán cho phiếu 10003 (THPT XYZ) - Chuyển khoản, có giảm giá (4 thí sinh -> 0%)
-- Recalculate tong_tien needed for invoice based on potential discount rule (rule: >20 = 10%, >20?? mistake? assume > 20 = 10%, >=50=15%)
-- Let's assume the discount rule is: >= 20 gets 10%, >= 50 gets 15%
DECLARE @TongTien10003 DECIMAL(10, 2) = (SELECT tong_tien FROM phieu_dang_ky WHERE ma_phieu_dang_ky = 10003);
DECLARE @GiamGia10003 DECIMAL(4, 2) = 0.00; -- 4 candidates, no discount yet based on ">20" rule
INSERT INTO [dbo].[hoa_don_thanh_toan] ([ma_thanh_toan], [loai_thanh_toan], [hinh_thuc_thanh_toan], [so_tien], [giam_gia], [ngay_thanh_toan], [ma_giao_dich], [ma_nhan_vien])
VALUES (20002, N'dang_ky', N'chuyen_khoan', @TongTien10003 * (1 - @GiamGia10003), @GiamGia10003, '2025-05-17 15:00:00', 'CKXYZ250517', 3);
UPDATE [dbo].[phieu_dang_ky] SET [trang_thai_thanh_toan] = 1 WHERE [ma_phieu_dang_ky] = 10003;

-- Thanh toán cho phiếu 10005 (Mai) - Tiền mặt
DECLARE @TongTien10005 DECIMAL(10, 2) = (SELECT tong_tien FROM phieu_dang_ky WHERE ma_phieu_dang_ky = 10005);
INSERT INTO [dbo].[hoa_don_thanh_toan] ([ma_thanh_toan], [loai_thanh_toan], [hinh_thuc_thanh_toan], [so_tien], [giam_gia], [ngay_thanh_toan], [ma_giao_dich], [ma_nhan_vien])
VALUES (20003, 'dang_ky', 'tien_mat', @TongTien10005, 0.00, '2025-05-21 09:00:00', 'TM20250521001', 3);
UPDATE [dbo].[phieu_dang_ky] SET [trang_thai_thanh_toan] = 1 WHERE [ma_phieu_dang_ky] = 10005;

-- Phiếu 10002 (Nam) - Quá hạn thanh toán (Giả sử hôm nay > ngày đăng ký + 3 ngày)
-- UPDATE [dbo].[phieu_dang_ky] SET [trang_thai_thanh_toan] = 2 WHERE [ma_phieu_dang_ky] = 10002;
-- Remove candidate from exam count if cancelled
-- UPDATE [dbo].[ky_thi] SET [so_luong_dang_ky_hien_tai] = [so_luong_dang_ky_hien_tai] - 1 WHERE [ma_ky_thi] = 502 AND EXISTS (SELECT 1 FROM chi_tiet_phieu_dang_ky WHERE ma_phieu_dang_ky = 10002 AND ma_ky_thi = 502);
-- For simplicity in mock data, let's assume Nam paid late
INSERT INTO [dbo].[hoa_don_thanh_toan] ([ma_thanh_toan], [loai_thanh_toan], [hinh_thuc_thanh_toan], [so_tien], [giam_gia], [ngay_thanh_toan], [ma_giao_dich], [ma_nhan_vien])
VALUES (20004, 'dang_ky', 'tien_mat', (SELECT tong_tien FROM phieu_dang_ky WHERE ma_phieu_dang_ky = 10002), 0.00, '2025-05-15 16:00:00', 'TM20250515002', 3);
UPDATE [dbo].[phieu_dang_ky] SET [trang_thai_thanh_toan] = 1 WHERE [ma_phieu_dang_ky] = 10002;

-- Thanh toán cho phiếu 10004 (TT ABC) - Chuyển khoản
DECLARE @TongTien10004 DECIMAL(10, 2) = (SELECT tong_tien FROM phieu_dang_ky WHERE ma_phieu_dang_ky = 10004);
DECLARE @GiamGia10004 DECIMAL(4, 2) = 0.00; -- 2 candidates, no discount
INSERT INTO [dbo].[hoa_don_thanh_toan] ([ma_thanh_toan], [loai_thanh_toan], [hinh_thuc_thanh_toan], [so_tien], [giam_gia], [ngay_thanh_toan], [ma_giao_dich], [ma_nhan_vien])
VALUES (20005, N'dang_ky', N'chuyen_khoan', @TongTien10004 * (1 - @GiamGia10004), @GiamGia10004, '2025-05-22 11:30:00', 'CKABC250522', 3);
UPDATE [dbo].[phieu_dang_ky] SET [trang_thai_thanh_toan] = 1 WHERE [ma_phieu_dang_ky] = 10004;

GO

-- 13. Populate [dbo].[phieu_du_thi] (Exam Admission Tickets)
-- Generate for paid registrations. Diem is initially NULL.
PRINT 'Populating [dbo].[phieu_du_thi]...';
INSERT INTO [dbo].[phieu_du_thi] ([ma_phieu_du_thi], [ma_thi_sinh], [ma_ky_thi], [so_bao_danh], [diem])
SELECT
    ROW_NUMBER() OVER (ORDER BY ctpdk.ma_thi_sinh) + 30000, -- Starting ID for admission tickets
    ctpdk.ma_thi_sinh,
    ctpdk.ma_ky_thi,
    -- Generate SBD: CertTypeInitial + YYMM + SeqNum
    UPPER(LEFT(dscc.ten_chung_chi, 1)) + FORMAT(kt.thoi_gian_bat_dau, 'yyMM') + RIGHT('000' + CAST(ROW_NUMBER() OVER (PARTITION BY ctpdk.ma_ky_thi ORDER BY ctpdk.ma_thi_sinh) AS VARCHAR(3)), 3),
    NULL -- Diem is NULL initially
FROM [dbo].[chi_tiet_phieu_dang_ky] ctpdk
JOIN [dbo].[phieu_dang_ky] pdk ON ctpdk.ma_phieu_dang_ky = pdk.ma_phieu_dang_ky
JOIN [dbo].[ky_thi] kt ON ctpdk.ma_ky_thi = kt.ma_ky_thi
JOIN [dbo].[danh_sach_chung_chi] dscc ON kt.ma_chung_chi = dscc.ma_chung_chi
WHERE pdk.trang_thai_thanh_toan = 1; -- Only generate for paid registrations
GO

-- Simulate some exam results by updating Diem
PRINT 'Updating some exam scores...';
UPDATE [dbo].[phieu_du_thi] SET [diem] = 750 WHERE [ma_thi_sinh] = 2001 AND [ma_ky_thi] = 501; -- Hà thi TOEIC
UPDATE [dbo].[phieu_du_thi] SET [diem] = 6.5 WHERE [ma_thi_sinh] = 2002 AND [ma_ky_thi] = 502; -- Nam thi IELTS
UPDATE [dbo].[phieu_du_thi] SET [diem] = 920 WHERE [ma_thi_sinh] = 2008 AND [ma_ky_thi] = 503; -- Tâm thi MOS
UPDATE [dbo].[phieu_du_thi] SET [diem] = 880 WHERE [ma_thi_sinh] = 2003 AND [ma_ky_thi] = 504; -- Anh thi IC3
UPDATE [dbo].[phieu_du_thi] SET [diem] = 850 WHERE [ma_thi_sinh] = 2004 AND [ma_ky_thi] = 504; -- Bích thi IC3
UPDATE [dbo].[phieu_du_thi] SET [diem] = 450 WHERE [ma_thi_sinh] = 2005 AND [ma_ky_thi] = 504; -- Danh thi IC3 (Failed)
GO

-- 14. Populate [dbo].[phieu_gia_han] (Reschedule Forms)
PRINT 'Populating [dbo].[phieu_gia_han]...';

-- Case 1: Special case - Free reschedule (Hà - 2001 from exam 501)
-- Assuming Phieu Du Thi ID for Hà (2001, 501) is 30001 (check your generated ID)
DECLARE @MaPhieuDuThiHa INT = (SELECT ma_phieu_du_thi FROM phieu_du_thi WHERE ma_thi_sinh = 2001 AND ma_ky_thi = 501);
IF @MaPhieuDuThiHa IS NOT NULL
BEGIN
    INSERT INTO [dbo].[phieu_gia_han] ([ma_phieu_gia_han], [ma_thanh_toan], [ma_ky_thi_cu], [phieu_du_thi], [so_lan], [ngay_gia_han], [phi_gia_han], [trang_thai_thanh_toan], [ly_do], [truong_hop_dac_biet], [thoi_gian_thi_moi], [ma_nhan_vien], [ma_ky_thi_moi])
    VALUES (40001, NULL, 501, @MaPhieuDuThiHa, 1, '2025-06-13 10:00:00', 0.00, 1, N'Ốm nặng, có giấy xác nhận của bác sĩ', 1, '2025-07-05 13:30:00', 2 ,505);
    
    -- Update original phieu_du_thi maybe? Or handle logic in application layer.
    -- For simplicity, we assume this cancels the original slot participation but keeps score NULL if not taken.
    -- Or potentially delete/update the original phieu_du_thi and create a new one.
    UPDATE [dbo].[phieu_du_thi] SET ma_ky_thi = 505
    WHERE ma_phieu_du_thi = @MaPhieuDuThiHa;

    UPDATE [dbo].[ky_thi] SET [so_luong_dang_ky_hien_tai] = [so_luong_dang_ky_hien_tai] + 1 WHERE [ma_ky_thi] = 505; -- Add to new exam count
    UPDATE [dbo].[ky_thi] SET [so_luong_dang_ky_hien_tai] = [so_luong_dang_ky_hien_tai] - 1 WHERE [ma_ky_thi] = 501; -- Remove from old exam count

END

-- Case 2: Normal case - Paid reschedule (Sơn - 2009 from exam 505)
DECLARE @MaPhieuDuThiSon INT = (SELECT ma_phieu_du_thi FROM phieu_du_thi WHERE ma_thi_sinh = 2009 AND ma_ky_thi = 505);
DECLARE @PhiGiaHan DECIMAL(10,2) = 200000.00; -- Example reschedule fee
IF @MaPhieuDuThiSon IS NOT NULL
BEGIN
    -- Create payment record for the fee
    INSERT INTO [dbo].[hoa_don_thanh_toan] ([ma_thanh_toan], [loai_thanh_toan], [hinh_thuc_thanh_toan], [so_tien], [giam_gia], [ngay_thanh_toan], [ma_giao_dich], [ma_nhan_vien])
    VALUES (20006, N'gia_han', N'tien_mat', @PhiGiaHan, 0.00, '2025-07-03 11:00:00', 'TMGH250703001', 3);
    DECLARE @MaThanhToanGiaHan INT = SCOPE_IDENTITY(); -- Get the ID of the inserted payment
    
    -- Create reschedule record
    INSERT INTO [dbo].[phieu_gia_han] ([ma_phieu_gia_han], [ma_thanh_toan], [ma_ky_thi_cu], [phieu_du_thi], [so_lan], [ngay_gia_han], [phi_gia_han], [trang_thai_thanh_toan], [ly_do], [truong_hop_dac_biet], [thoi_gian_thi_moi], [ma_nhan_vien], [ma_ky_thi_moi])
    VALUES (40002, @MaThanhToanGiaHan, 505, @MaPhieuDuThiSon, 1, '2025-07-03 10:45:00', @PhiGiaHan, 1, N'Trùng lịch công tác đột xuất', 0, '2025-08-15 08:00:00', 6, 507);
    
    -- Update original phieu_du_thi status
    UPDATE [dbo].[phieu_du_thi] SET ma_ky_thi = 507 
    WHERE ma_phieu_du_thi = @MaPhieuDuThiSon;
    UPDATE [dbo].[ky_thi] 
    SET [so_luong_dang_ky_hien_tai] = [so_luong_dang_ky_hien_tai] - 1 
    WHERE [ma_ky_thi] = 505; -- Remove from old exam count
    UPDATE [dbo].[ky_thi] SET [so_luong_dang_ky_hien_tai] = [so_luong_dang_ky_hien_tai] + 1 WHERE [ma_ky_thi] = 507; -- Add to new exam count
END
GO

-- 15. Populate [dbo].[gac_thi] (Proctor Assignments)
PRINT 'Populating [dbo].[gac_thi]...';
-- Assign proctors (nhan_vien with chuc_vu=5) to exams
INSERT INTO [dbo].[gac_thi] ([ma_ky_thi], [ma_nhan_vien], [thoi_gian_bat_dau])
SELECT kt.ma_ky_thi, nv.ma_nhan_vien, kt.thoi_gian_bat_dau
FROM [dbo].[ky_thi] kt
CROSS JOIN (SELECT TOP 1 ma_nhan_vien FROM [dbo].[nhan_vien] WHERE chuc_vu = 5 ORDER BY NEWID()) nv
WHERE kt.ma_ky_thi IN (501, 502, 503, 504, 506, 507); -- Include new exam 507

-- Assign another proctor to some exams if needed
INSERT INTO [dbo].[gac_thi] ([ma_ky_thi], [ma_nhan_vien], [thoi_gian_bat_dau])
SELECT kt.ma_ky_thi, nv.ma_nhan_vien, kt.thoi_gian_bat_dau
FROM [dbo].[ky_thi] kt
CROSS JOIN (SELECT TOP 1 ma_nhan_vien FROM [dbo].[nhan_vien] WHERE chuc_vu = 5 ORDER BY NEWID()) nv
WHERE kt.ma_ky_thi IN (501, 502); -- Assign a second proctor to larger exams
GO

-- 16. Populate [dbo].[chung_chi_thi_sinh] (Issued Certificates)
-- Issue certificates for candidates who passed (Diem > threshold - thresholds are assumed here)
PRINT 'Populating [dbo].[chung_chi_thi_sinh]...';

-- Hà passed TOEIC (Score 750)
DECLARE @MaChungChiTOEIC INT = (SELECT ma_chung_chi FROM danh_sach_chung_chi WHERE ten_chung_chi LIKE 'TOEIC%');
IF EXISTS (SELECT 1 FROM phieu_du_thi WHERE ma_thi_sinh = 2001 AND ma_ky_thi = 501 AND diem >= 450)
BEGIN
    INSERT INTO [dbo].[chung_chi_thi_sinh] ([ma_chung_chi], [ma_thi_sinh], [ngay_cap], [ngay_het_han])
    VALUES (@MaChungChiTOEIC, 2001, DATEADD(day, 14, (SELECT thoi_gian_bat_dau FROM ky_thi WHERE ma_ky_thi = 501)), DATEADD(year, 2, DATEADD(day, 14, (SELECT thoi_gian_bat_dau FROM ky_thi WHERE ma_ky_thi = 501))));
END

-- Nam passed IELTS (Score 6.5)
DECLARE @MaChungChiIELTS INT = (SELECT ma_chung_chi FROM danh_sach_chung_chi WHERE ten_chung_chi LIKE 'IELTS%');
IF EXISTS (SELECT 1 FROM phieu_du_thi WHERE ma_thi_sinh = 2002 AND ma_ky_thi = 502 AND diem >= 5.0)
BEGIN
    INSERT INTO [dbo].[chung_chi_thi_sinh] ([ma_chung_chi], [ma_thi_sinh], [ngay_cap], [ngay_het_han])
    VALUES (@MaChungChiIELTS, 2002, DATEADD(day, 14, (SELECT thoi_gian_bat_dau FROM ky_thi WHERE ma_ky_thi = 502)), DATEADD(year, 2, DATEADD(day, 14, (SELECT thoi_gian_bat_dau FROM ky_thi WHERE ma_ky_thi = 502))));
END

-- Tâm passed MOS Word (Score 920)
DECLARE @MaChungChiMOSW INT = (SELECT ma_chung_chi FROM danh_sach_chung_chi WHERE ten_chung_chi LIKE 'MOS Word%');
IF EXISTS (SELECT 1 FROM phieu_du_thi WHERE ma_thi_sinh = 2008 AND ma_ky_thi = 503 AND diem >= 700)
BEGIN
    INSERT INTO [dbo].[chung_chi_thi_sinh] ([ma_chung_chi], [ma_thi_sinh], [ngay_cap], [ngay_het_han])
    VALUES (@MaChungChiMOSW, 2008, DATEADD(day, 7, (SELECT thoi_gian_bat_dau FROM ky_thi WHERE ma_ky_thi = 503)), NULL);
END

-- Anh passed IC3 (Score 880)
DECLARE @MaChungChiIC3 INT = (SELECT ma_chung_chi FROM danh_sach_chung_chi WHERE ten_chung_chi LIKE 'IC3%');
IF EXISTS (SELECT 1 FROM phieu_du_thi WHERE ma_thi_sinh = 2003 AND ma_ky_thi = 504 AND diem >= 700)
BEGIN
    INSERT INTO [dbo].[chung_chi_thi_sinh] ([ma_chung_chi], [ma_thi_sinh], [ngay_cap], [ngay_het_han])
    VALUES (@MaChungChiIC3, 2003, DATEADD(day, 7, (SELECT thoi_gian_bat_dau FROM ky_thi WHERE ma_ky_thi = 504)), NULL);
END

-- Bích passed IC3 (Score 850)
IF EXISTS (SELECT 1 FROM phieu_du_thi WHERE ma_thi_sinh = 2004 AND ma_ky_thi = 504 AND diem >= 700)
BEGIN
    INSERT INTO [dbo].[chung_chi_thi_sinh] ([ma_chung_chi], [ma_thi_sinh], [ngay_cap], [ngay_het_han])
    VALUES (@MaChungChiIC3, 2004, DATEADD(day, 7, (SELECT thoi_gian_bat_dau FROM ky_thi WHERE ma_ky_thi = 504)), NULL);
END

-- Danh failed IC3 (Score 450), no certificate issued.

GO

PRINT 'Mock data generation complete.';
GO