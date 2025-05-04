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
    internal class PhieuDangKyDAO
    {

        public PhieuDangKyDAO()
        {
        }
        public int addPhieuDangKy(string maNguoiDangKy, DateOnly ngayDangKy, int nguoiTiepNhan, double tongTien)
        {
            string query = "INSERT INTO phieu_dang_ky (ma_phieu_dang_ky, ma_nguoi_dang_ky, ngay_dang_ky, nguoi_tiep_nhan, tong_tien) VALUES (@MaPhieu, @MaNguoiDangKy, @NgayDangKy, @NguoiTiepNhan, @TongTien)";

            try
            {
                // Create ID for new record
                AppConfig.Command.CommandText = "SELECT COUNT(*) FROM phieu_dang_ky";
                Int32 count = (Int32)AppConfig.Command.ExecuteScalar() + 1;

                // Insert new record
                AppConfig.Command.CommandText = query;
                AppConfig.Command.Parameters.Clear();
                AppConfig.Command.Parameters.AddWithValue("@MaPhieu", count);
                AppConfig.Command.Parameters.AddWithValue("@MaNguoiDangKy", maNguoiDangKy);
                AppConfig.Command.Parameters.AddWithValue("@NgayDangKy", ngayDangKy);
                AppConfig.Command.Parameters.AddWithValue("@NguoiTiepNhan", nguoiTiepNhan);
                AppConfig.Command.Parameters.AddWithValue("@TongTien", tongTien);
                AppConfig.Command.ExecuteNonQuery();

                return count;
            }
            catch (Exception ex)
            {
                // Handle exceptions
                Debug.WriteLine("addPhieuDangKy" + ex.Message);
                return -1; // or throw an exception
            }
        }

        public DataTable getAllPhieuDangKy()
        {
            string query = "SELECT * FROM phieu_dang_ky";
            DataTable dataTable = new DataTable();
            try
            {
                
                AppConfig.Command.CommandText = query;
                AppConfig.Command.Parameters.Clear();
                AppConfig.Adapter.SelectCommand = AppConfig.Command;
                AppConfig.Command.ExecuteNonQuery();
                AppConfig.Adapter.Fill(dataTable);
            }
            catch (Exception ex)
            {
                // Handle exceptions
                Debug.WriteLine("getAllPhieuDangKy" + ex.Message);
            }

            return dataTable;
        }

        public void deletePhieuDangKy(string maPhieu)
        {
            string query = "DELETE FROM phieu_dang_ky WHERE ma_phieu_dang_ky = @MaPhieu";
            try
            {
                
                AppConfig.Command.CommandText = query;
                AppConfig.Command.Parameters.Clear();
                AppConfig.Command.Parameters.AddWithValue("@MaPhieu", maPhieu);
                AppConfig.Command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                // Handle exceptions
                Debug.WriteLine("deletePhieuDangKy: " + ex.Message);
            }
        }

        public void updatePhieuDangKy(string maPhieu, string maNguoiDangKy, DateOnly ngayDangKy)
        {
            string query = "UPDATE PhieuDangKy SET ma_nguoi_dang_ky = @MaNguoiDangKy, ngay_dang_ky = @NgayDangKy WHERE ma_phieu_dang_ky = @MaPhieu";
            try
            {
                
                AppConfig.Command.CommandText = query;
                AppConfig.Command.Parameters.Clear();
                AppConfig.Command.Parameters.AddWithValue("@MaPhieu", maPhieu);
                AppConfig.Command.Parameters.AddWithValue("@MaNguoiDangKy", maNguoiDangKy);
                AppConfig.Command.Parameters.AddWithValue("@NgayDangKy", ngayDangKy);
                AppConfig.Command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                // Handle exceptions
                Debug.WriteLine("updatePhieuDangKy: " + ex.Message);
            }
        }

        public DataTable getTTPhieuDangKyByNguoiDangKy(string maNguoiDangKy)
        {
            string query = "SELECT * FROM phieu_dang_ky WHERE ma_nguoi_dang_ky = @MaNguoiDangKy";
            DataTable dataTable = new DataTable();
            try
            {
                
                AppConfig.Command.CommandText = query;
                AppConfig.Command.Parameters.Clear();
                AppConfig.Command.Parameters.AddWithValue("@MaNguoiDangKy", maNguoiDangKy);
                AppConfig.Adapter.SelectCommand = AppConfig.Command;
                AppConfig.Adapter.Fill(dataTable);
            }
            catch (Exception ex)
            {
                // Handle exceptions
                Debug.WriteLine("getPhieuDangKyByNguoiDangKy: " + ex.Message);
            }
            finally
            {
                
            }
            return dataTable;
        }

        public DataTable searchTTPhieuDangKyByMaPhieu(string maPhieu)
        {
            string query = "SELECT * FROM phieu_dang_ky WHERE ma_phieu_dang_ky like @MaPhieu";
            DataTable dataTable = new DataTable();
            try
            {
                
                AppConfig.Command.CommandText = query;
                AppConfig.Command.Parameters.AddWithValue("@MaPhieu", '%' + maPhieu + '%');
                AppConfig.Adapter.SelectCommand = AppConfig.Command;
                AppConfig.Adapter.Fill(dataTable);
            }
            catch (Exception ex)
            {
                // Handle exceptions
                Debug.WriteLine("searchTTPhieuDangKyByMaPhieu: " + ex.Message);
            }
            finally
            {
                
            }
            return dataTable;
        }
            

        public DataRow getTTPhieuDangKyByMaPhieu(string maPhieu)
        {
            string query = "SELECT * FROM phieu_dang_ky WHERE ma_phieu_dang_ky = @MaPhieu";
            DataTable dataTable = new DataTable();
            try
            {
                
                AppConfig.Command.CommandText = query;
                AppConfig.Command.Parameters.Clear();
                AppConfig.Command.Parameters.AddWithValue("@MaPhieu", maPhieu);
                AppConfig.Adapter.SelectCommand = AppConfig.Command;
                AppConfig.Adapter.Fill(dataTable);
            }
            catch (Exception ex)
            {
                // Handle exceptions
                Debug.WriteLine(" error in getPhieuDangKyByMaPhieu: " + ex.Message);
            }

            if (dataTable.Rows.Count > 0)
            {
                return dataTable.Rows[0];
            }
            else
            {
                return null; // or throw an exception
            }
        }

        public void deletePhieuDangKyByNguoiDangKy(string maNguoiDangKy)
        {
            string query = "DELETE FROM phieu_dang_ky WHERE ma_nguoi_dang_ky = @MaNguoiDangKy";
            try
            {
                
                AppConfig.Command.CommandText = query;
                AppConfig.Command.Parameters.Clear();
                AppConfig.Command.Parameters.AddWithValue("@MaNguoiDangKy", maNguoiDangKy);
                AppConfig.Command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                // Handle exceptions
                Debug.WriteLine(" error in deletePhieuDangKyByNguoiDangKy: " + ex.Message);
            }
            finally
            {
                
            }
        }

        

        public DataTable searchNguoiDangKy(string searchTerm)
        {
            string query = "SELECT * FROM phieu_dang_ky WHERE ma_nguoi_dang_ky LIKE @SearchTerm OR ho_ten LIKE @SearchTerm OR so_dien_thoai LIKE @SearchTerm " +
                "OR email LIKE @SearchTerm";
            DataTable dataTable = new DataTable();
            try
            {
                
                AppConfig.Command.CommandText = query;
                AppConfig.Command.Parameters.Clear();
                AppConfig.Command.Parameters.AddWithValue("@SearchTerm", "%" + searchTerm + "%");
                AppConfig.Adapter.SelectCommand = AppConfig.Command;
                AppConfig.Adapter.Fill(dataTable);
            }
            catch (Exception ex)
            {
                // Handle exceptions
                Debug.WriteLine(" error in searchNguoiDangKy: " + ex.Message);
            }
            return dataTable;
        }

        public DataTable getAllPhieuDK()
        {
            string query = "SELECT * FROM phieu_dang_ky";
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
                Debug.WriteLine(" error in getAllPhieuDK: " + ex.Message);
            }
            finally
            {

            }
            return dataTable;
        }

        public DataTable getDSPhieuDangKyByMaNguoiDangKy(string maNguoiDangKy)
        {
            string query = "SELECT * FROM phieu_dang_ky WHERE ma_nguoi_dang_ky = @MaNguoiDangKy";
            DataTable dataTable = new DataTable();
            try
            {
                AppConfig.Command.CommandText = query;
                AppConfig.Command.Parameters.AddWithValue("@MaNguoiDangKy", maNguoiDangKy);
                AppConfig.Adapter.SelectCommand = AppConfig.Command;
                AppConfig.Adapter.Fill(dataTable);
            }
            catch (Exception ex)
            {
                // Handle exceptions
                Debug.WriteLine(" error in getTTPhieuDangKyByMaNguoiDangKy: " + ex.Message);
            }
            finally
            {

            }
            return dataTable;
        }

        public void updateTrangThaiPhieuDangKy(string maPhieuDK, int maHoaDonThanhToan, int trangThai)
        {
            string query = "UPDATE phieu_dang_ky SET ma_thanh_toan = @MaHoaDonThanhToan, trang_thai_thanh_toan = @TrangThai WHERE ma_phieu_dang_ky = @MaPhieuDK";
            try
            {
                AppConfig.Command.CommandText = query;  
                AppConfig.Command.Parameters.Clear();
                AppConfig.Command.Parameters.AddWithValue("@MaHoaDonThanhToan", maHoaDonThanhToan);
                AppConfig.Command.Parameters.AddWithValue("@MaPhieuDK", maPhieuDK);
                AppConfig.Command.Parameters.AddWithValue("@TrangThai", trangThai);
                AppConfig.Command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                Debug.WriteLine(" error in updateTrangThaiPhieuDangKy: " + ex.Message); 
            }
            finally
            {

            }
        }   
    }
}
