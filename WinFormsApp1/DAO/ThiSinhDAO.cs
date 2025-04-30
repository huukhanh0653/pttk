using Microsoft.Data.SqlClient;
using Microsoft.Identity.Client;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WinFormsApp1.DAO.Database;

namespace WinFormsApp1.DAO
{
    internal class ThiSinhDAO
    {

        public ThiSinhDAO()
        {
        }

        public DataTable getAllThiSinh()
        {
            string query = "SELECT * FROM thi_sinh";
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
                Debug.WriteLine("getAllThiSinh: " + ex.Message);
            }
            finally
            {

            }
            return dataTable;
        }

        public void addThiSinh(string HoTen, DateOnly NgaySinh, string SoDienThoai, string Email, DateTime CreatedAt)
        {
            string query = "INSERT INTO thi_sinh (ma_thi_sinh, ho_ten, ngay_sinh, so_dien_thoai, email, created_at) " +
                "VALUES (@MaThiSinh, @HoTen, @NgaySinh, @SoDienThoai, @Email, @CreatedAt)";
            try
            {
                // Create ID for new record
                AppConfig.Command.CommandText = "SELECT COUNT(*) FROM thi_sinh";
                
                int count = (Int32)AppConfig.Command.ExecuteScalar() + 1;

                // Insert new record
                AppConfig.Command.Parameters.Clear();
                AppConfig.Command.CommandText = query;
                AppConfig.Command.Parameters.AddWithValue("@MaThiSinh", count);
                AppConfig.Command.Parameters.AddWithValue("@HoTen", HoTen);
                AppConfig.Command.Parameters.AddWithValue("@NgaySinh", NgaySinh);
                AppConfig.Command.Parameters.AddWithValue("@SoDienThoai", SoDienThoai);
                AppConfig.Command.Parameters.AddWithValue("@Email", Email);
                AppConfig.Command.Parameters.AddWithValue("@CreatedAt", CreatedAt);
                AppConfig.Command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                // Handle exceptions
                Debug.WriteLine("addThiSinh: " + ex.Message);
            }

        }

        public void updateThiSinh(int MaThiSinh, string HoTen, DateOnly NgaySinh, string SoDienThoai, string Email)
        {
            string query = "UPDATE thi_sinh SET ho_ten = @HoTen, ngay_sinh = @NgaySinh, so_dien_thoai = @SoDienThoai, email = @Email WHERE ma_thi_sinh = @MaThiSinh";
            try
            {
                AppConfig.Command.CommandText = query;
                AppConfig.Command.Parameters.Clear();
                AppConfig.Command.Parameters.AddWithValue("@MaThiSinh", MaThiSinh);
                AppConfig.Command.Parameters.AddWithValue("@HoTen", HoTen);
                AppConfig.Command.Parameters.AddWithValue("@NgaySinh", NgaySinh);
                AppConfig.Command.Parameters.AddWithValue("@SoDienThoai", SoDienThoai);
                AppConfig.Command.Parameters.AddWithValue("@Email", Email);
                AppConfig.Command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                // Handle exceptions
                Debug.WriteLine("updateThiSinh: " + ex.Message);
            }
        }

        public DataRow getThiSinhById(Int32 maThiSinh)
        {
            string query = "SELECT * FROM thi_sinh WHERE ma_thi_sinh = @MaThiSinh";
            DataTable dataTable = new DataTable();

            try
            {
                AppConfig.Command.CommandText = query;
                AppConfig.Command.Parameters.Clear();
                AppConfig.Command.Parameters.AddWithValue("@MaThiSinh", maThiSinh);
                AppConfig.Adapter.SelectCommand = AppConfig.Command;
                AppConfig.Adapter.Fill(dataTable);
            }
            catch (Exception ex)
            {
                Debug.WriteLine("getThiSinhById: " + ex.Message);
            }

            if (dataTable.Rows.Count > 0)
            {
                DataRow row = dataTable.Rows[0];
                return row;
            }
            return null;
        }

        public DataTable searchThiSinh(String keyWord)
        {
            string query = "SELECT * FROM thi_sinh WHERE ho_ten LIKE @KeyWord OR so_dien_thoai LIKE @KeyWord OR email LIKE @KeyWord";
            DataTable dataTable = new DataTable();
            try
            {
                AppConfig.Command.CommandText = query;
                AppConfig.Command.Parameters.Clear();
                AppConfig.Command.Parameters.AddWithValue("@KeyWord", "%" + keyWord + "%");
                AppConfig.Adapter.SelectCommand = AppConfig.Command;
                AppConfig.Adapter.Fill(dataTable);
            }
            catch (Exception ex)
            {
                Debug.WriteLine("searchThiSinh: " + ex.Message);
            }

            return dataTable;

        }
    }
}

