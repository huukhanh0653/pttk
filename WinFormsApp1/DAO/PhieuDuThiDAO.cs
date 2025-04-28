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
    internal class PhieuDuThiDAO
    {
        private SqlCommand command;
        private SqlConnection connection;
        private SqlDataAdapter adapter;
        public PhieuDuThiDAO()
        {
            connection = new SqlConnection(AppConfig.ConnectionString);
            command = new SqlCommand();
            command.Connection = connection;
            adapter = new SqlDataAdapter(); // Initialize the adapter to avoid CS8618 warning
        }
        public void addPhieuDuThi(string maPhieu, string maKyThi, string maPhong, string maThiSinh)
        {
            string query = "INSERT INTO phieu_du_thi (ma_phieu_du_thi, ma_ky_thi, so_phong, ma_thi_sinh) VALUES (@MaPhieu, @MaKyThi, @MaPhong, @MaThiSinh)";
            try
            {
                connection.Open();
                // Insert new record
                command.CommandText = query;
                command.Parameters.AddWithValue("@MaPhieu", maPhieu);
                command.Parameters.AddWithValue("@MaKyThi", maKyThi);
                command.Parameters.AddWithValue("@MaPhong", maPhong);
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
        public DataTable getAllPhieuDuThi()
        {
            string query = "SELECT * FROM phieu_du_thi";
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

        public DataTable getPhieuDuThiByMaThiSinh(string maThiSinh)
        {
            string query = "SELECT * FROM phieu_du_thi WHERE ma_thi_sinh = @MaThiSinh";
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

        public void deletePhieuDuThi(string maPhieu)
        {
            string query = "DELETE FROM phieu_du_thi WHERE ma_phieu_du_thi = @MaPhieu";
            try
            {
                connection.Open();
                // Delete record
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

        public DataTable getPhieuDuThiByMaKyThi(string maKyThi)
        {
            string query = "SELECT * FROM phieu_du_thi WHERE ma_ky_thi = @MaKyThi";
            DataTable dataTable = new DataTable();
            try
            {
                connection.Open();
                command.CommandText = query;
                command.Parameters.AddWithValue("@MaKyThi", maKyThi);
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

        public DataRow getPhieuDuThiByMaPhieu(string maPhieu)
        {
            string query = "SELECT * FROM phieu_du_thi WHERE ma_phieu_du_thi = @MaPhieu";
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
            return dataTable.Rows.Count > 0 ? dataTable.Rows[0] : null;
        }

    }
}
