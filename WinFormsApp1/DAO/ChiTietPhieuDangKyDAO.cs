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
    internal class ChiTietPhieuDangKyDAO
    {
        public ChiTietPhieuDangKyDAO()
        {
        }
        public void addChiTietPhieuDangKy(int maPhieuDangKy, int maKyThi, int maThiSinh)
        {
            string query = "INSERT INTO chi_tiet_phieu_dang_ky (ma_phieu_dang_ky, ma_thi_sinh, ma_ky_thi) VALUES (@MaPhieu, @MaThiSinh, @MaKyThi)";
            try
            {
                // Check if the record already exists
                string checkQuery = "SELECT COUNT(*) FROM chi_tiet_phieu_dang_ky WHERE ma_phieu_dang_ky = @MaPhieu AND ma_thi_sinh = @MaThiSinh";
                AppConfig.Command.CommandText = checkQuery;
                AppConfig.Command.Parameters.Clear();
                AppConfig.Command.Parameters.AddWithValue("@MaPhieu", maPhieuDangKy);
                AppConfig.Command.Parameters.AddWithValue("@MaThiSinh", maThiSinh);
                AppConfig.Command.Parameters.AddWithValue("@MaKyThi", maKyThi);
                Int32 count = (Int32)AppConfig.Command.ExecuteScalar();

                if (count > 0)
                {
                    // If a record with the same MaPhieu and MaThiSinh exists, do not insert
                    Debug.WriteLine("A record with the same MaPhieu and MaThiSinh already exists.");
                    return;
                }

                // Insert new record
                AppConfig.Command.CommandText = query;
                AppConfig.Command.Parameters.Clear();
                AppConfig.Command.Parameters.AddWithValue("@MaPhieu", maPhieuDangKy);
                AppConfig.Command.Parameters.AddWithValue("@MaThiSinh", maThiSinh);
                AppConfig.Command.Parameters.AddWithValue("@MaKyThi",maKyThi);
                AppConfig.Command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                // Handle exceptions
                Debug.WriteLine("addChiTietPhieuDangKy: " + ex.Message);
            }
        }

        public DataTable getAllChiTietPhieuDangKy()
        {
            string query = "SELECT * FROM chi_tiet_phieu_dang_ky";
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
                Debug.WriteLine(ex.Message);
            }
            return dataTable;
        }

        public void deleteChiTietPhieuDangKy(string maPhieu, string maThiSinh)
        {
            string query = "DELETE FROM chi_tiet_phieu_dang_ky WHERE ma_phieu_dang_ky = @MaPhieu AND ma_thi_sinh = @MaThiSinh";
            try
            {
                AppConfig.Command.CommandText = query;
                AppConfig.Command.Parameters.Clear();
                AppConfig.Command.Parameters.AddWithValue("@MaPhieu", maPhieu);
                AppConfig.Command.Parameters.AddWithValue("@MaThiSinh", maThiSinh);
                AppConfig.Command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                // Handle exceptions
                Debug.WriteLine(ex.Message);
            }
        }

        public void deleteChiTietPhieuDangKyByMaPhieu(string maPhieu)
        {
            string query = "DELETE FROM chi_tiet_phieu_dang_ky WHERE ma_phieu_dang_ky = @MaPhieu";
            try
            {
                AppConfig.Command.CommandText = query;
                AppConfig.Command.Parameters.AddWithValue("@MaPhieu", maPhieu);
                AppConfig.Command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                // Handle exceptions
                Debug.WriteLine(ex.Message);
            }
        }

        public DataTable getChiTietPhieuDKByMaPhieuDK(string maPhieu)
        {
            string query = "SELECT * FROM chi_tiet_phieu_dang_ky WHERE ma_phieu_dang_ky = @MaPhieu";
            DataTable dataTable = new DataTable();
            try
            {

                AppConfig.Command.CommandText = query;
                AppConfig.Command.Parameters.Clear();
                AppConfig.Command.Parameters.AddWithValue("@MaPhieu", maPhieu);
                AppConfig.Adapter.SelectCommand = AppConfig.Command;
                AppConfig.Adapter.Fill(dataTable);
            }
            catch (Exception ex)
            {
                // Handle exceptions
                Debug.WriteLine(ex.Message);
            }

            return dataTable;
        }

        public DataTable getChiTietPhieuByMaThiSinh(string maThiSinh)
        {
            string query = "SELECT * FROM chi_tiet_phieu_dang_ky WHERE ma_thi_sinh = @MaThiSinh";
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
                // Handle exceptions
                Debug.WriteLine(ex.Message);
            }

            return dataTable;
        }


    }
}
