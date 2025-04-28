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
    internal class KyThiDAO
    {
        private SqlCommand command;
        private SqlConnection connection;
        private SqlDataAdapter adapter;

        public KyThiDAO()
        {
            connection = new SqlConnection(AppConfig.ConnectionString);
            command = new SqlCommand();
            command.Connection = connection;
            adapter = new SqlDataAdapter(); // Initialize the adapter to avoid CS8618 warning
        }

        public static DataTable GetAllKyThi()
        {
           string query = "SELECT * FROM KyThi";
            DataTable dataTable = new DataTable();
            SqlConnection connection = new SqlConnection(AppConfig.ConnectionString);
            SqlCommand command = new SqlCommand(query, connection);
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            try
            {
                connection.Open();
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
        public static void AddKyThi(string maKyThi, string maChungChi, int maPhong, string diaDiem, string tenKyThi, 
            string moTa, DateTime TGBatDau, int soLuongToiDa, int soLuongDKHienTai)
        {
            string query = "INSERT INTO ky_thi (ma_ky_thi, ma_chung_chi, so_phong, dia_diem, ten_ky_thi, mo_ta, " +
                "thoi_gian_bat_dau, so_luong_toi_da, so_luong_dang_ky_hien_tai) " +
                "VALUES (@maKyThi, @maChungChi, @maPhong, @diaDiem, @tenKyThi, @moTa, @TGBatDau, @soLuongToiDa, @soLuongDKHienTai)";
            SqlConnection connection = new SqlConnection(AppConfig.ConnectionString);
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@maKyThi", maKyThi);
            command.Parameters.AddWithValue("@maChungChi", maChungChi);
            command.Parameters.AddWithValue("@maPhong", maPhong);
            command.Parameters.AddWithValue("@diaDiem", diaDiem);
            command.Parameters.AddWithValue("@tenKyThi", tenKyThi);
            command.Parameters.AddWithValue("@moTa", moTa);
            command.Parameters.AddWithValue("@TGBatDau", TGBatDau);
            command.Parameters.AddWithValue("@soLuongToiDa", soLuongToiDa);
            command.Parameters.AddWithValue("@soLuongDKHienTai", soLuongDKHienTai);

            try
            {
                connection.Open();
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

    }
}
