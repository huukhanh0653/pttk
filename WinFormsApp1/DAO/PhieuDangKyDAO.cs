using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Microsoft.Data.SqlClient;
using WinFormsApp1.DAO.Database;

namespace WinFormsApp1.DAO
{
    internal class PhieuDangKyDAO
    {
        private SqlCommand command;
        private SqlConnection connection;
        private SqlDataAdapter adapter;
        public PhieuDangKyDAO()
        {
            connection = new SqlConnection(AppConfig.ConnectionString);
            command = new SqlCommand();
            command.Connection = connection;
            adapter = new SqlDataAdapter(); // Initialize the adapter to avoid CS8618 warning
        }
        public void addPhieuDangKy(string maPhieu, string maNguoiDangKy, DateOnly ngayDangKy)
        {
            string query = "INSERT INTO phieu_dang_ky (ma_phieu_dang_ky, ma_nguoi_dang_ky, ngay_dang_ky) VALUES (@MaPhieu, @MaNguoiDangKy, @NgayDangKy)";
            try
            {
                connection.Open();
                // Insert new record
                command.CommandText = query;
                command.Parameters.AddWithValue("@MaPhieu", maPhieu);
                command.Parameters.AddWithValue("@MaNguoiDangKy", maNguoiDangKy);
                command.Parameters.AddWithValue("@NgayDangKy", ngayDangKy);
                command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                // Handle exceptions
                Console.WriteLine(ex.Message);
            }
            finally
            {
                connection.Close();
            }
        }

        public DataTable getAllPhieuDangKy()
        {
            string query = "SELECT * FROM phieu_dang_ky";
            DataTable dataTable = new DataTable();
            try
            {
                connection.Open();
                command.CommandText = query;
                adapter.SelectCommand = command;
                adapter.Fill(dataTable);
            }
            catch (Exception ex)
            {
                // Handle exceptions
                Console.WriteLine(ex.Message);
            }
            finally
            {
                connection.Close();
            }
            return dataTable;
        }

        public void deletePhieuDangKy(string maPhieu)
        {
            string query = "DELETE FROM phieu_dang_ky WHERE ma_phieu_dang_ky = @MaPhieu";
            try
            {
                connection.Open();
                command.CommandText = query;
                command.Parameters.AddWithValue("@MaPhieu", maPhieu);
                command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                // Handle exceptions
                Console.WriteLine(ex.Message);
            }
            finally
            {
                connection.Close();
            }
        }

        public void updatePhieuDangKy(string maPhieu, string maNguoiDangKy, DateOnly ngayDangKy)
        {
            string query = "UPDATE PhieuDangKy SET ma_nguoi_dang_ky = @MaNguoiDangKy, ngay_dang_ky = @NgayDangKy WHERE ma_phieu_dang_ky = @MaPhieu";
            try
            {
                connection.Open();
                command.CommandText = query;
                command.Parameters.AddWithValue("@MaPhieu", maPhieu);
                command.Parameters.AddWithValue("@MaNguoiDangKy", maNguoiDangKy);
                command.Parameters.AddWithValue("@NgayDangKy", ngayDangKy);
                command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                // Handle exceptions
                Console.WriteLine(ex.Message);
            }
            finally
            {
                connection.Close();
            }
        }

        public DataTable getPhieuDangKyByNguoiDangKy(string maNguoiDangKy)
        {
            string query = "SELECT * FROM phieu_dang_ky WHERE ma_nguoi_dang_ky = @MaNguoiDangKy";
            DataTable dataTable = new DataTable();
            try
            {
                connection.Open();
                command.CommandText = query;
                command.Parameters.AddWithValue("@MaNguoiDangKy", maNguoiDangKy);
                adapter.SelectCommand = command;
                adapter.Fill(dataTable);
            }
            catch (Exception ex)
            {
                // Handle exceptions
                Console.WriteLine(ex.Message);
            }
            finally
            {
                connection.Close();
            }
            return dataTable;
        }

        public DataRow getPhieuDangKyByMaPhieu(string maPhieu)
        {
            string query = "SELECT * FROM phieu_dang_ky WHERE ma_phieu_dang_ky = @MaPhieu";
            DataTable dataTable = new DataTable();
            try
            {
                connection.Open();
                command.CommandText = query;
                command.Parameters.AddWithValue("@MaPhieu", maPhieu);
                adapter.SelectCommand = command;
                adapter.Fill(dataTable);
            }
            catch (Exception ex)
            {
                // Handle exceptions
                Console.WriteLine(ex.Message);
            }
            finally
            {
                connection.Close();
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
                connection.Open();
                command.CommandText = query;
                command.Parameters.AddWithValue("@MaNguoiDangKy", maNguoiDangKy);
                command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                // Handle exceptions
                Console.WriteLine(ex.Message);
            }
            finally
            {
                connection.Close();
            }
        }

        public DataTable searchNguoiDangKy(string searchTerm)
        {
            string query = "SELECT * FROM phieu_dang_ky WHERE ma_nguoi_dang_ky LIKE @SearchTerm OR ho_ten LIKE @SearchTerm OR so_dien_thoai LIKE @SearchTerm " +
                "OR email LIKE @SearchTerm";
            DataTable dataTable = new DataTable();
            try
            {
                connection.Open();
                command.CommandText = query;
                command.Parameters.AddWithValue("@SearchTerm", "%" + searchTerm + "%");
                adapter.SelectCommand = command;
                adapter.Fill(dataTable);
            }
            catch (Exception ex)
            {
                // Handle exceptions
                Console.WriteLine(ex.Message);
            }
            finally
            {
                connection.Close();
            }
            return dataTable;
        }
    }
}
