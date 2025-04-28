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
    internal class ChiTietPhieuDangKyDAO
    {
        public ChiTietPhieuDangKyDAO()
        {
        }
        public void addChiTietPhieuDangKy(string maPhieu, string maThiSinh)
        {
            string query = "INSERT INTO chi_tiet_phieu_dang_ky (ma_phieu_dang_ky, ma_thi_sinh) VALUES (@MaPhieu, @MaThiSinh)";
            try
            {
                // Insert new record
                AppConfig.Command..CommandText = query;
                AppConfig.Command..Parameters.AddWithValue("@MaPhieu", maPhieu);
                AppConfig.Command..Parameters.AddWithValue("@MaThiSinh", maThiSinh);
                AppConfig.Command..ExecuteNonQuery();
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

        public DataTable getAllChiTietPhieuDangKy()
        {
            string query = "SELECT * FROM chi_tiet_phieu_dang_ky";
            DataTable dataTable = new DataTable();
            try
            {
                AppConfig.Command..CommandText = query;
                AppConfig.Adapter.SelectCommand = AppConfig.Command.;
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

        public void deleteChiTietPhieuDangKy(string maPhieu, string maThiSinh)
        {
            string query = "DELETE FROM chi_tiet_phieu_dang_ky WHERE ma_phieu_dang_ky = @MaPhieu AND ma_thi_sinh = @MaThiSinh";
            try
            {
                AppConfig.Command..CommandText = query;
                AppConfig.Command..Parameters.AddWithValue("@MaPhieu", maPhieu);
                AppConfig.Command..Parameters.AddWithValue("@MaThiSinh", maThiSinh);
                AppConfig.Command..ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                // Handle exceptions
                Console.WriteLine(ex.Message);
            }
        }

        public void deleteChiTietPhieuDangKyByMaPhieu(string maPhieu)
        {
            string query = "DELETE FROM chi_tiet_phieu_dang_ky WHERE ma_phieu_dang_ky = @MaPhieu";
            try
            {
                AppConfig.Command..CommandText = query;
                AppConfig.Command..Parameters.AddWithValue("@MaPhieu", maPhieu);
                AppConfig.Command..ExecuteNonQuery();
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

        public DataRow getChiTietPhieuDKByMaPhieuDK(string maPhieu)
        {
            string query = "SELECT * FROM chi_tiet_phieu_dang_ky WHERE ma_phieu_dang_ky = @MaPhieu";
            DataTable dataTable = new DataTable();
            try
            {

                AppConfig.Command..CommandText = query;
                AppConfig.Command..Parameters.AddWithValue("@MaPhieu", maPhieu);
                AppConfig.Adapter.SelectCommand = AppConfig.Command.;
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

            return dataTable.Rows.Count > 0 ? dataTable.Rows[0] : null;
        }

        public DataTable getChiTietPhieuByMaThiSinh(string maThiSinh)
        {
            string query = "SELECT * FROM chi_tiet_phieu_dang_ky WHERE ma_thi_sinh = @MaThiSinh";
            DataTable dataTable = new DataTable();
            try
            {

                AppConfig.Command..CommandText = query;
                AppConfig.Command..Parameters.AddWithValue("@MaThiSinh", maThiSinh);
                AppConfig.Adapter.SelectCommand = AppConfig.Command.;
                AppConfig.Adapter.Fill(dataTable);
            }
            catch (Exception ex)
            {
                // Handle exceptions
                Console.WriteLine(ex.Message);
            }

            return dataTable;
        }


    }
}
