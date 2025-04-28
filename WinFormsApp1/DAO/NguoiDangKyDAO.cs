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
    internal class NguoiDangKyDAO
    {
        private SqlCommand command;
        private SqlConnection connection;
        private SqlDataAdapter adapter;
        public NguoiDangKyDAO()
        {
            connection = new SqlConnection(AppConfig.ConnectionString);
            command = new SqlCommand();
            command.Connection = connection;
            adapter = new SqlDataAdapter(); // Initialize the adapter to avoid CS8618 warning
        }
        public DataTable getAllNguoiDangKy()
        {
            string query = "SELECT * FROM nguoi_dang_ky";

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
        public void addNguoiDangKy(string HoTen, DateOnly NgaySinh, string SoDienThoai, string Email, bool DonVi)
        {
            string query = "INSERT INTO nguoi_dang_ky (ma_nguoi_dang_ky, ho_ten, ngay_sinh, so_dien_thoai, email, don_vi) VALUES (@HoTen, @NgaySinh, @SoDienThoai, @Email, @DonVi)";
            try
            {
                connection.Open();

                // Create ID for new record
                command.CommandText = "SELECT COUNT(*) FROM nguoi_dang_ky";
                Int64 count = (Int64) command.ExecuteScalar() + 1;

                // Insert new record
                command.CommandText = query;
                command.Parameters.Clear();
                command.Parameters.AddWithValue("@ma_nguoi_dang_ky", count);
                command.Parameters.AddWithValue("@HoTen", HoTen);
                command.Parameters.AddWithValue("@NgaySinh", NgaySinh);
                command.Parameters.AddWithValue("@SoDienThoai", SoDienThoai);
                command.Parameters.AddWithValue("@Email", Email);
                command.Parameters.AddWithValue("@DonVi", DonVi);
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

        public DataRow findNguoiDangKyById(Int64 id)
        {
            string query = "SELECT * FROM nguoi_dang_ky WHERE ma_nguoi_dang_ky = @id";
            DataTable dataTable = new DataTable();
            try
            {
                connection.Open();
                command.CommandText = query;
                command.Parameters.Clear();
                command.Parameters.AddWithValue("@id", id);
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
            return null;
        }

        public void updateNguoiDangKy(Int64 id, string HoTen, DateOnly NgaySinh, string SoDienThoai, string Email, bool DonVi)
        {
            string query = "UPDATE nguoi_dang_ky SET ho_ten = @HoTen, ngay_sinh = @NgaySinh, so_dien_thoai = @SoDienThoai, email = @Email, don_vi = @DonVi WHERE ma_nguoi_dang_ky = @id";
            try
            {
                connection.Open();
                command.CommandText = query;
                command.Parameters.Clear();
                command.Parameters.AddWithValue("@id", id);
                command.Parameters.AddWithValue("@HoTen", HoTen);
                command.Parameters.AddWithValue("@NgaySinh", NgaySinh);
                command.Parameters.AddWithValue("@SoDienThoai", SoDienThoai);
                command.Parameters.AddWithValue("@Email", Email);
                command.Parameters.AddWithValue("@DonVi", DonVi);
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

        public void deleteNguoiDangKy(Int64 id)
        {
            string query = "DELETE FROM nguoi_dang_ky WHERE ma_nguoi_dang_ky = @id";
            try
            {
                connection.Open();
                command.CommandText = query;
                command.Parameters.Clear();
                command.Parameters.AddWithValue("@id", id);
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

        public DataTable searchNguoiDangKy(string keyword)
        {
            string query = "SELECT * FROM nguoi_dang_ky WHERE ho_ten LIKE @keyword OR so_dien_thoai LIKE @keyword OR email LIKE @keyword";
            DataTable dataTable = new DataTable();
            try
            {
                connection.Open();
                command.CommandText = query;
                command.Parameters.Clear();
                command.Parameters.AddWithValue("@keyword", "%" + keyword + "%");
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
