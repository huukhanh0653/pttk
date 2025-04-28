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
    internal class ChucVuNhanVienDAO
    {
        private SqlCommand command;
        private SqlConnection connection;
        private SqlDataAdapter adapter;
        public ChucVuNhanVienDAO()
        {
            connection = new SqlConnection(AppConfig.ConnectionString);
            command = new SqlCommand();
            command.Connection = connection;
            adapter = new SqlDataAdapter(); // Initialize the adapter to avoid CS8618 warning
        }
        public void addChucVu(string maChucVu, string tenChucVu)
        {
            string query = "INSERT INTO chuc_vu (ma_chuc_vu, ten_chuc_vu) VALUES (@MaChucVu, @TenChucVu)";
            try
            {
                connection.Open();
                // Insert new record
                command.CommandText = query;
                command.Parameters.AddWithValue("@MaChucVu", maChucVu);
                command.Parameters.AddWithValue("@TenChucVu", tenChucVu);
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
        public DataTable getAllChucVu()
        {
            string query = "SELECT * FROM chuc_vu";
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

        public DataRow getChucVuByMaCV(string maCV)
        {
            string query = "SELECT * FROM chuc_vu WHERE ma_chuc_vu = @MaCV";
            DataTable dataTable = new DataTable();
            try
            {
                connection.Open();
                command.CommandText = query;
                command.Parameters.AddWithValue("@MaCV", maCV);
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
            return dataTable.Rows.Count > 0 ? dataTable.Rows[0] : null;
        }
    }
}
