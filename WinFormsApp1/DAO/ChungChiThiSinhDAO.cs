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
    internal class ChungChiThiSinhDAO
    {
        private SqlCommand command;
        private SqlConnection connection;
        private SqlDataAdapter adapter;
        public ChungChiThiSinhDAO()
        {
            connection = new SqlConnection(AppConfig.ConnectionString);
            command = new SqlCommand();
            command.Connection = connection;
            adapter = new SqlDataAdapter(); // Initialize the adapter to avoid CS8618 warning
        }
        public DataTable getAllChungChiThiSinh()
        {
            string query = "SELECT * FROM chung_chi_thi_sinh";
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
        public void addChungChiThiSinh(string maChungChi, string maThiSinh)
        {
            string query = "INSERT INTO chung_chi_thi_sinh (ma_chung_chi, ma_thi_sinh) VALUES (@MaChungChi, @MaThiSinh)";
            try
            {
                connection.Open();
                // Insert new record
                command.CommandText = query;
                command.Parameters.AddWithValue("@MaChungChi", maChungChi);
                command.Parameters.AddWithValue("@MaThiSinh", maThiSinh);
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

        public DataTable getChungChiThiSinhByMaThiSinh(string maThiSinh)
        {
            string query = "SELECT * FROM chung_chi_thi_sinh WHERE ma_thi_sinh = @MaThiSinh";
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
                // Handle exceptions
                Console.WriteLine(ex.Message);
            }
            finally
            {
                connection.Close();
            }
            return dataTable;
        }

        public DataRow getChungChiThiSinhByMaTSAndMaCC(string maThiSinh, string maChungChi)
        {
            string query = "SELECT * FROM chung_chi_thi_sinh WHERE ma_thi_sinh = @MaThiSinh AND ma_chung_chi = @MaChungChi";
            DataTable dataTable = new DataTable();
            try
            {
                connection.Open();
                command.CommandText = query;
                command.Parameters.AddWithValue("@MaThiSinh", maThiSinh);
                command.Parameters.AddWithValue("@MaChungChi", maChungChi);
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
