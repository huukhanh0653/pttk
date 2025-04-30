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
    internal class KyThiDAO
    {


        public KyThiDAO()
        {
        }

        public DataTable getAllKyThi()
        {
            string query = "SELECT * FROM ky_thi";
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
                Debug.WriteLine("getAllKyThi: " + ex.Message);
            }
            return dataTable;
        }

        public void AddKyThi(string maKyThi, string maChungChi, int maPhong, string diaDiem, string tenKyThi,
            string moTa, DateTime TGBatDau, int soLuongToiDa, int soLuongDKHienTai)
        {
            string query = "INSERT INTO ky_thi (ma_ky_thi, ma_chung_chi, so_phong, dia_diem, ten_ky_thi, mo_ta, " +
                "thoi_gian_bat_dau, so_luong_toi_da, so_luong_dang_ky_hien_tai) " +
                "VALUES (@maKyThi, @maChungChi, @maPhong, @diaDiem, @tenKyThi, @moTa, @TGBatDau, @soLuongToiDa, @soLuongDKHienTai)";

            try
            {

                AppConfig.Command.Parameters.Clear();
                AppConfig.Command.Parameters.AddWithValue("@maKyThi", maKyThi);
                AppConfig.Command.Parameters.AddWithValue("@maChungChi", maChungChi);
                AppConfig.Command.Parameters.AddWithValue("@maPhong", maPhong);
                AppConfig.Command.Parameters.AddWithValue("@diaDiem", diaDiem);
                AppConfig.Command.Parameters.AddWithValue("@tenKyThi", tenKyThi);
                AppConfig.Command.Parameters.AddWithValue("@moTa", moTa);
                AppConfig.Command.Parameters.AddWithValue("@TGBatDau", TGBatDau);
                AppConfig.Command.Parameters.AddWithValue("@soLuongToiDa", soLuongToiDa);
                AppConfig.Command.Parameters.AddWithValue("@soLuongDKHienTai", soLuongDKHienTai);
                AppConfig.Command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                // Handle exceptions
                Debug.WriteLine("AddKyThi: " + ex.Message);
            }
        }

        public DataRow getKyThiByMaKyThi(int maKyThi)
        {
            string query = "SELECT * FROM ky_thi where ma_ky_thi = @MaKyThi";
            DataTable dataTable = new DataTable();
            try
            {
                AppConfig.Command.CommandText = query;
                AppConfig.Command.Parameters.Clear();
                AppConfig.Command.Parameters.AddWithValue("@MaKyThi", maKyThi);
                AppConfig.Adapter.SelectCommand = AppConfig.Command;
                AppConfig.Adapter.Fill(dataTable);
            }
            catch (Exception ex)
            {
                // Handle exceptions
                Debug.WriteLine($"getKyThiByMaKyThi: {ex.Message}");
            }

            return dataTable.Rows.Count > 0 ? dataTable.Rows[0] : null;

        }

        public DataTable getAllKyThiByMaChungChi(int maChungChi)
        {
            DataTable dataTable = new DataTable();
            string query = "SELECT * FROM ky_thi WHERE ma_chung_chi = @MaChungChi";
            try
            {
                AppConfig.Command.CommandText = query;
                AppConfig.Command.Parameters.Clear();
                AppConfig.Command.Parameters.AddWithValue("@MaChungChi", maChungChi);
                AppConfig.Adapter.SelectCommand = AppConfig.Command;
                AppConfig.Adapter.Fill(dataTable);
            }
            catch (Exception ex)
            {
                Debug.WriteLine("error in getAllKyThiByMaChungChi" + ex.Message);
                //Console.WriteLine(ex.Message);
            }
            return dataTable;
        }

        public DataTable searchKyThi(string query)
        {
            DataTable dataTable = new DataTable();
            string sql = "SELECT * FROM ky_thi WHERE ten_ky_thi LIKE @query OR dia_diem LIKE @query" +
                "OR ma_chung_chi LIKE @query";
            try
            {
                AppConfig.Command.CommandText = sql;
                AppConfig.Command.Parameters.Clear();
                AppConfig.Command.Parameters.AddWithValue("@query", "%" + query + "%");
                AppConfig.Adapter.SelectCommand = AppConfig.Command;
                AppConfig.Adapter.Fill(dataTable);
            }
            catch (Exception ex)
            {
                Debug.WriteLine("error in searchKyThi" + ex.Message);
            }

            return dataTable;
        }
    }
}
