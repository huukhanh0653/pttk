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
    internal class DanhSachChungChiDAO
    {
        private SqlCommand command;
        private SqlConnection connection;
        private SqlDataAdapter adapter;
        public DanhSachChungChiDAO()
        {
            connection = new SqlConnection(AppConfig.ConnectionString);
            command = new SqlCommand();
            command.Connection = connection;
            adapter = new SqlDataAdapter(); // Initialize the adapter to avoid CS8618 warning
        }
        public void addChungChi(string maChungChi, string tenChungChi)
        {
            string query = "INSERT INTO danh_sach_chung_chi (ma_chung_chi, ten_chung_chi) VALUES (@MaChungChi, @TenChungChi)";
            try
            {
                connection.Open();
                // Insert new record
                command.CommandText = query;
                command.Parameters.AddWithValue("@MaChungChi", maChungChi);
                command.Parameters.AddWithValue("@TenChungChi", tenChungChi);
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
        public DataTable getAllChungChi()
        {
            string query = "SELECT * FROM danh_sach_chung_chi";
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

        public DataRow getChungChiByMaChungChi(int MaChungChi)
        {
            string query = "SELECT * FROM danh_sach_chung_chi WHERE ma_chung_chi = @MaChungChi";
            DataTable dataTable = new DataTable();
            try
            {
                connection.Open();
                command.CommandText = query;
                command.Parameters.AddWithValue("@MaChungChi", MaChungChi);
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

        public DataTable searchChungChi(string searchTerm)
        {
            string query = "SELECT * FROM danh_sach_chung_chi WHERE ma_chung_chi LIKE @SearchTerm OR ten_chung_chi LIKE @SearchTerm " +
                "OR don_vi_cap LIKE @SearchTerm OR gia_tien LIKE @SearchTerm";
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
