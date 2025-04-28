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
        private SqlCommand command;
        private SqlConnection connection;
        private SqlDataAdapter adapter;

        public ThiSinhDAO()
        {
        }

        public DataTable getAllThiSinh()
        {
            string query = "SELECT * FROM thi_sinh";
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

        public void addThiSinh(int MaThiSinh, string HoTen, DateOnly NgaySinh, string SoDienThoai, string Email, DateTime CreatedAt)
        {
            string query = "INSERT INTO thi_sinh (ma_thi_sinh, ho_ten, ngay_sinh, so_dien_thoai, email, created_at) " +
                "VALUES (@MaThiSinh, @HoTen, @NgaySinh, @SoDienThoai, @Email, @CreatedAt)";
            try
            {
                connection.Open();
                command.CommandText = query;
                command.Parameters.AddWithValue("@MaThiSinh", MaThiSinh);
                command.Parameters.AddWithValue("@HoTen", HoTen);
                command.Parameters.AddWithValue("@NgaySinh", NgaySinh);
                command.Parameters.AddWithValue("@SoDienThoai", SoDienThoai);
                command.Parameters.AddWithValue("@Email", Email);
                command.Parameters.AddWithValue("@CreatedAt", CreatedAt);
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

        public DataRow getThiSinhById(Int64 maThiSinh)
        {
            string query = "SELECT * FROM thi_sinh WHERE ma_thi_sinh = @MaThiSinh";
            DataTable dataTable = new DataTable();

            try
            {
                connection.Open();
                command.CommandText = query;
                command.Parameters.AddWithValue("@MaThiSinh", maThiSinh);
                adapter.SelectCommand = command;
                adapter.Fill(dataTable);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                connection.Close();
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
                connection.Open();
                command.CommandText = query;
                command.Parameters.AddWithValue("@KeyWord", "%" + keyWord + "%");
                adapter.SelectCommand = command;
                adapter.Fill(dataTable);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                connection.Close();
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

