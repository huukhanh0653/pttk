using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data;
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
                AppConfig.Adapter.SelectCommand = AppConfig.Command;
                AppConfig.Adapter.Fill(dataTable);
            }
            catch (Exception ex)
            {
                // Handle exceptions
                Console.WriteLine(ex.Message);
            }
            finally
            {
                
            }
            return dataTable;
        }

        public void addThiSinh(int MaThiSinh, string HoTen, DateOnly NgaySinh, string SoDienThoai, string Email, DateTime CreatedAt)
        {
            string query = "INSERT INTO thi_sinh (ma_thi_sinh, ho_ten, ngay_sinh, so_dien_thoai, email, created_at) " +
                "VALUES (@MaThiSinh, @HoTen, @NgaySinh, @SoDienThoai, @Email, @CreatedAt)";
            try
            {
                
                AppConfig.Command.CommandText = query;
                AppConfig.Command.Parameters.AddWithValue("@MaThiSinh", MaThiSinh);
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
                Console.WriteLine(ex.Message);
            }

            finally
            {
                
            }
        }

        public DataRow getThiSinhById(Int64 maThiSinh)
        {
            string query = "SELECT * FROM thi_sinh WHERE ma_thi_sinh = @MaThiSinh";
            DataTable dataTable = new DataTable();

            try
            {
                
                AppConfig.Command.CommandText = query;
                AppConfig.Command.Parameters.AddWithValue("@MaThiSinh", maThiSinh);
                AppConfig.Adapter.SelectCommand = AppConfig.Command;
                AppConfig.Adapter.Fill(dataTable);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                
            }

            if (dataTable.Rows.Count > 0)
            {
                DataRow row = dataTable.Rows[0];
                return row;
            }
            return null;
        }

        public DataRow searchThiSinh(String keyWord)
        {
            string query = "SELECT * FROM thi_sinh WHERE ho_ten LIKE @KeyWord OR so_dien_thoai LIKE @KeyWord OR email LIKE @KeyWord";
            DataTable dataTable = new DataTable();
            try
            {
                
                AppConfig.Command.CommandText = query;
                AppConfig.Command.Parameters.AddWithValue("@KeyWord", "%" + keyWord + "%");
                AppConfig.Adapter.SelectCommand = AppConfig.Command;
                AppConfig.Adapter.Fill(dataTable);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                
            }
            if (dataTable.Rows.Count > 0)
            {
                DataRow row = dataTable.Rows[0];
                return row;
            }
            return null;

        }
    }
}

