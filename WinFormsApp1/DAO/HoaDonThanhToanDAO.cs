using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Microsoft.Data.SqlClient;
using WinFormsApp1.DAO.Database;
using System.Diagnostics;

namespace WinFormsApp1.DAO
{
    internal class HoaDonThanhToanDAO
    {

        public HoaDonThanhToanDAO()
        {
        }

        public int addHoaDonThanhToan(string loaiThanhToan, double soTien, float giamGia, DateTime ngayThanhToan,
            string hinhThuc, string maGiaoDich)
        {
            string queryMaThanhToan = "SELECT MAX(ma_thanh_toan) FROM hoa_don_thanh_toan";
            AppConfig.Command.CommandText = queryMaThanhToan;
            object result = AppConfig.Command.ExecuteScalar();
            int maThanhToan = (result == DBNull.Value) ? 1 : Convert.ToInt32(result) + 1;

            string maNV = "1";
            Debug.WriteLine("maThanhToan: " + maThanhToan);
            Debug.WriteLine("loaiThanhToan: " + loaiThanhToan);
            Debug.WriteLine("soTien: " + soTien);
            Debug.WriteLine("giamGia: " + giamGia);
            Debug.WriteLine("ngayThanhToan: " + ngayThanhToan);
            Debug.WriteLine("hinhThuc: " + hinhThuc);
            Debug.WriteLine("maGiaoDich: " + maGiaoDich);
            Debug.WriteLine("maNV: " + maNV);
            
            string query = "INSERT INTO hoa_don_thanh_toan (ma_thanh_toan, loai_thanh_toan, so_tien, giam_gia, ngay_thanh_toan, hinh_thuc_thanh_toan, ma_giao_dich, ma_nhan_vien) " +
                "VALUES (@MaThanhToan, @LoaiThanhToan, @SoTien, @GiamGia, @NgayThanhToan, @HinhThuc, @MaGiaoDich, @MaNV)";
            try
            {
                
                // Update record
                AppConfig.Command.CommandText = query;
                AppConfig.Command.Parameters.AddWithValue("@MaThanhToan", maThanhToan);
                AppConfig.Command.Parameters.AddWithValue("@LoaiThanhToan", loaiThanhToan);
                AppConfig.Command.Parameters.AddWithValue("@SoTien", soTien);
                AppConfig.Command.Parameters.AddWithValue("@GiamGia", giamGia);
                AppConfig.Command.Parameters.AddWithValue("@NgayThanhToan", ngayThanhToan);
                AppConfig.Command.Parameters.AddWithValue("@HinhThuc", hinhThuc);
                AppConfig.Command.Parameters.AddWithValue("@MaGiaoDich", maGiaoDich);
                AppConfig.Command.Parameters.AddWithValue("@MaNV", maNV);
                AppConfig.Command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                // Handle exceptions
                Debug.WriteLine(ex.Message);
            }
            finally
            {
                
            }
            return maThanhToan;
        }

        public DataTable getAllHoaDonThanhToan()
        {
            string query = "SELECT * FROM hoa_don_thanh_toan";
            DataTable dataTable = new DataTable();
            try
            {
                
                AppConfig.Command.CommandText = query;
                AppConfig.Adapter.SelectCommand = AppConfig.Command;
                AppConfig.Adapter.Fill(dataTable);
            }
            catch (Exception ex)
            {
                // Handle exceptions
                Debug.WriteLine(ex.Message);
            }
            finally
            {
                
            }
            return dataTable;
        }

        public void updateHoaDonThanhToan(string maThanhToan, string loaiThanhToan, double soTien, float giamGia, DateTime ngayThanhToan,
            string hinhThuc, string maGiaoDich)
        {
           string query = "UPDATE hoa_don_thanh_toan SET loai_thanh_toan = @LoaiThanhToan, so_tien = @SoTien, giam_gia = @GiamGia, " +
                "ngay_thanh_toan = @NgayThanhToan, hinh_thuc = @HinhThuc, ma_giao_dich = @MaGiaoDich WHERE ma_thanh_toan = @MaThanhToan";
            try
            {
                
                // Update record
                AppConfig.Command.CommandText = query;
                AppConfig.Command.Parameters.AddWithValue("@MaThanhToan", maThanhToan);
                AppConfig.Command.Parameters.AddWithValue("@LoaiThanhToan", loaiThanhToan);
                AppConfig.Command.Parameters.AddWithValue("@SoTien", soTien);
                AppConfig.Command.Parameters.AddWithValue("@GiamGia", giamGia);
                AppConfig.Command.Parameters.AddWithValue("@NgayThanhToan", ngayThanhToan);
                AppConfig.Command.Parameters.AddWithValue("@HinhThuc", hinhThuc);
                AppConfig.Command.Parameters.AddWithValue("@MaGiaoDich", maGiaoDich);
                AppConfig.Command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                // Handle exceptions
                Debug.WriteLine(ex.Message);
            }
            finally
            {
                
            }
        }

        public void deleteHoaDonThanhToan(string maHoaDon)
        {
            string query = "DELETE FROM hoa_don_thanh_toan WHERE ma_hoa_don = @MaHoaDon";
            try
            {
                
                // Delete record
                AppConfig.Command.CommandText = query;
                AppConfig.Command.Parameters.AddWithValue("@MaHoaDon", maHoaDon);
                AppConfig.Command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                // Handle exceptions
                Debug.WriteLine(ex.Message);
            }
            finally
            {
                
            }
        }

        public DataTable getHoaDonThanhToanByMaPhieu(string maPhieu)
        {
            string query = "SELECT * FROM hoa_don_thanh_toan WHERE ma_phieu = @MaPhieu";
            DataTable dataTable = new DataTable();
            try
            {
                
                AppConfig.Command.CommandText = query;
                AppConfig.Command.Parameters.AddWithValue("@MaPhieu", maPhieu);
                AppConfig.Adapter.SelectCommand = AppConfig.Command;
                AppConfig.Adapter.Fill(dataTable);
            }
            catch (Exception ex)
            {
                // Handle exceptions
                Debug.WriteLine(ex.Message);
            }
            finally
            {
                
            }
            return dataTable;
        }

        public DataTable getHoaDonThanhToanByMaKyThi(string maKyThi)
        {
            string query = "SELECT * FROM hoa_don_thanh_toan WHERE ma_ky_thi = @MaKyThi";
            DataTable dataTable = new DataTable();
            try
            {
                
                AppConfig.Command.CommandText = query;
                AppConfig.Command.Parameters.AddWithValue("@MaKyThi", maKyThi);
                AppConfig.Adapter.SelectCommand = AppConfig.Command;
                AppConfig.Adapter.Fill(dataTable);
            }
            catch (Exception ex)
            {
                // Handle exceptions
                Debug.WriteLine(ex.Message);
            }
            finally
            {
                
            }
            return dataTable;
        }

        public DataTable getHoaDonThanhToanByMaHoaDon(string maHoaDon)
        {
            string query = "SELECT * FROM hoa_don_thanh_toan WHERE ma_hoa_don = @MaHoaDon";
            DataTable dataTable = new DataTable();
            try
            {
                
                AppConfig.Command.CommandText = query;
                AppConfig.Command.Parameters.AddWithValue("@MaHoaDon", maHoaDon);
                AppConfig.Adapter.SelectCommand = AppConfig.Command;
                AppConfig.Adapter.Fill(dataTable);
            }
            catch (Exception ex)
            {
                // Handle exceptions
                Debug.WriteLine(ex.Message);
            }
            finally
            {
                
            }
            return dataTable;
        }

        public DataTable getHoaDonThanhToanByTrangThai(bool trangThai)
        {
            string query = "SELECT * FROM hoa_don_thanh_toan WHERE trang_thai = @TrangThai";
            DataTable dataTable = new DataTable();
            try
            {
                
                AppConfig.Command.CommandText = query;
                AppConfig.Command.Parameters.AddWithValue("@TrangThai", trangThai);
                AppConfig.Adapter.SelectCommand = AppConfig.Command;
                AppConfig.Adapter.Fill(dataTable);
            }
            catch (Exception ex)
            {
                // Handle exceptions
                Debug.WriteLine(ex.Message);
            }
            finally
            {
                
            }
            return dataTable;
        }

        public DataTable getHoaDonThanhToanByThoiGianLap(DateTime thoiGianLap)
        {
            string query = "SELECT * FROM hoa_don_thanh_toan WHERE thoi_gian_lap = @ThoiGianLap";
            DataTable dataTable = new DataTable();
            try
            {
                
                AppConfig.Command.CommandText = query;
                AppConfig.Command.Parameters.AddWithValue("@ThoiGianLap", thoiGianLap);
                AppConfig.Adapter.SelectCommand = AppConfig.Command;
                AppConfig.Adapter.Fill(dataTable);
            }
            catch (Exception ex)
            {
                // Handle exceptions
                Debug.WriteLine(ex.Message);
            }
            finally
            {
                
            }
            return dataTable;
        }

        public DataTable getHoaDonThanhToanByLoaiThanhToan(string loaiThanhToan)
        {
            string query = "SELECT * FROM hoa_don_thanh_toan WHERE loai_thanh_toan = @LoaiThanhToan";
            DataTable dataTable = new DataTable();
            try
            {
                
                AppConfig.Command.CommandText = query;
                AppConfig.Command.Parameters.AddWithValue("@LoaiThanhToan", loaiThanhToan);
                AppConfig.Adapter.SelectCommand = AppConfig.Command;
                AppConfig.Adapter.Fill(dataTable);
            }
            catch (Exception ex)
            {
                // Handle exceptions
                Debug.WriteLine(ex.Message);
            }
            finally
            {
                
            }
            return dataTable;
        }
    }
}
