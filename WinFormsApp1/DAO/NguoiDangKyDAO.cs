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
    internal class NguoiDangKyDAO
    {
        public NguoiDangKyDAO()
        {
        }
        public DataTable getAllNguoiDangKy()
        {
            string query = "SELECT * FROM nguoi_dang_ky";

            DataTable dataTable = new DataTable();
            try
            {
                AppConfig.Command.CommandText = query;
                AppConfig.Command.Parameters.Clear();
                AppConfig.Adapter.SelectCommand = AppConfig.Command;
                AppConfig.Adapter.Fill(dataTable);
            }
            catch (Exception ex)
            {
                // Handle exceptions
                Debug.WriteLine("getAllNguoiDangKy" + ex.Message);
            }

            return dataTable;
        }
        public void addNguoiDangKy(string HoTen, DateOnly NgaySinh, string SoDienThoai, string Email, bool DonVi)
        {
            string query = "INSERT INTO nguoi_dang_ky (ma_nguoi_dang_ky, ho_ten, ngay_sinh, so_dien_thoai, email, don_vi) VALUES (@MaNguoiDangKy, @HoTen, @NgaySinh, @SoDienThoai, @Email, @DonVi)";
            try
            {
                // find if there is a record with the same phone number
                string checkQuery = "SELECT COUNT(*) FROM nguoi_dang_ky WHERE so_dien_thoai = @SoDienThoai";
                AppConfig.Command.CommandText = checkQuery;
                AppConfig.Command.Parameters.Clear();
                AppConfig.Command.Parameters.AddWithValue("@SoDienThoai", SoDienThoai);
                int count = (Int32)AppConfig.Command.ExecuteScalar();
                if (count > 0)
                {
                    // If a record with the same phone number exists, do not insert
                    Debug.WriteLine("A record with the same phone number already exists.");
                    return;
                }

                // Create ID for new record
                AppConfig.Command.CommandText = "SELECT COUNT(*) FROM nguoi_dang_ky";
                count = (Int32) AppConfig.Command.ExecuteScalar() + 1;

                // Insert new record
                AppConfig.Command.CommandText = query;
                AppConfig.Command.Parameters.Clear();
                AppConfig.Command.Parameters.AddWithValue("@MaNguoiDangKy", count);
                AppConfig.Command.Parameters.AddWithValue("@HoTen", HoTen);
                AppConfig.Command.Parameters.AddWithValue("@NgaySinh", NgaySinh);
                AppConfig.Command.Parameters.AddWithValue("@SoDienThoai", SoDienThoai);
                AppConfig.Command.Parameters.AddWithValue("@Email", Email);
                AppConfig.Command.Parameters.AddWithValue("@DonVi", DonVi);
                AppConfig.Command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                // Handle exceptions
                Debug.WriteLine("addNguoiDangKy: " + ex.Message);
            }
        }

        public DataRow findNguoiDangKyById(Int32 id)
        {
            string query = "SELECT * FROM nguoi_dang_ky WHERE ma_nguoi_dang_ky = @id";
            DataTable dataTable = new DataTable();
            try
            {
                AppConfig.Command.CommandText = query;
                AppConfig.Command.Parameters.Clear();
                AppConfig.Command.Parameters.AddWithValue("@id", id);
                AppConfig.Adapter.SelectCommand = AppConfig.Command;
                AppConfig.Adapter.Fill(dataTable);
            }
            catch (Exception ex)
            {
                // Handle exceptions
                Debug.WriteLine("findNguoiDangKyById: " + ex.Message);
            }

            return dataTable.Rows.Count > 0 ? dataTable.Rows[0] : null;
           
        }

        public void updateNguoiDangKy(Int32 id, string HoTen, DateOnly NgaySinh, string SoDienThoai, string Email, bool DonVi)
        {
            string query = "UPDATE nguoi_dang_ky SET ho_ten = @HoTen, ngay_sinh = @NgaySinh, so_dien_thoai = @SoDienThoai, email = @Email, don_vi = @DonVi WHERE ma_nguoi_dang_ky = @id";
            try
            {
                AppConfig.Command.CommandText = query;
                AppConfig.Command.Parameters.Clear();
                AppConfig.Command.Parameters.AddWithValue("@id", id);
                AppConfig.Command.Parameters.AddWithValue("@HoTen", HoTen);
                AppConfig.Command.Parameters.AddWithValue("@NgaySinh", NgaySinh);
                AppConfig.Command.Parameters.AddWithValue("@SoDienThoai", SoDienThoai);
                AppConfig.Command.Parameters.AddWithValue("@Email", Email);
                AppConfig.Command.Parameters.AddWithValue("@DonVi", DonVi);
                AppConfig.Command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                // Handle exceptions
                Debug.WriteLine(ex.Message);
            }

        }

        public void deleteNguoiDangKy(Int32 id)
        {
            string query = "DELETE FROM nguoi_dang_ky WHERE ma_nguoi_dang_ky = @id";
            try
            {
                
                AppConfig.Command.CommandText = query;
                AppConfig.Command.Parameters.Clear();
                AppConfig.Command.Parameters.AddWithValue("@id", id);
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

        public DataTable searchNguoiDangKy(string keyword)
        {
            string query = "SELECT * FROM nguoi_dang_ky WHERE ho_ten LIKE @keyword OR so_dien_thoai LIKE @keyword OR email LIKE @keyword";
            DataTable dataTable = new DataTable();
            try
            {
                AppConfig.Command.CommandText = query;
                AppConfig.Command.Parameters.Clear();
                AppConfig.Command.Parameters.AddWithValue("@keyword", "%" + keyword + "%");
                AppConfig.Adapter.SelectCommand = AppConfig.Command;
                AppConfig.Adapter.Fill(dataTable);
            }
            catch (Exception ex)
            {
                // Handle exceptions
                Debug.WriteLine("searchNguoiDangKy: " + ex.Message);
            }
            return dataTable;
        }
    }
}
