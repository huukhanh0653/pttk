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
    internal class PhieuDuThiDAO
    {
       
        public PhieuDuThiDAO()
        {
           
        }
        public void addPhieuDuThi(string maPhieu, string maKyThi, string maPhong, string maThiSinh)
        {
            string query = "INSERT INTO phieu_du_thi (ma_phieu_du_thi, ma_ky_thi, so_phong, ma_thi_sinh) VALUES (@MaPhieu, @MaKyThi, @MaPhong, @MaThiSinh)";
            try
            {

                // Insert new record
                AppConfig.Command.Parameters.Clear();
                AppConfig.Command.CommandText = query;
                AppConfig.Command.Parameters.AddWithValue("@MaPhieu", maPhieu);
                AppConfig.Command.Parameters.AddWithValue("@MaKyThi", maKyThi);
                AppConfig.Command.Parameters.AddWithValue("@MaPhong", maPhong);
                AppConfig.Command.Parameters.AddWithValue("@MaThiSinh", maThiSinh);
                AppConfig.Command.ExecuteNonQuery();
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
        public DataTable getAllPhieuDuThi()
        {
            string query = "SELECT * FROM phieu_du_thi";
            DataTable dataTable = new DataTable();
            try
            {
                AppConfig.Command.Parameters.Clear();
                AppConfig.Command.CommandText = query;
                AppConfig.Adapter.SelectCommand = AppConfig.Command;
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

        public DataTable getPhieuDuThiByMaThiSinh(string maThiSinh)
        {
            string query = "SELECT * FROM phieu_du_thi WHERE ma_thi_sinh = @MaThiSinh";
            DataTable dataTable = new DataTable();
            try
            {
                AppConfig.Command.Parameters.Clear();
                AppConfig.Command.CommandText = query;
                AppConfig.Command.Parameters.AddWithValue("@MaThiSinh", maThiSinh);
                AppConfig.Adapter.SelectCommand = AppConfig.Command;
                AppConfig.Adapter.Fill(dataTable);
            }
            catch (Exception ex)
            {
                // Handle exceptions
                Console.WriteLine(ex.Message);
            }

            return dataTable;
        }

        public void deletePhieuDuThi(string maPhieu)
        {
            string query = "DELETE FROM phieu_du_thi WHERE ma_phieu_du_thi = @MaPhieu";
            try
            {

                // Delete record
                AppConfig.Command.Parameters.Clear();
                AppConfig.Command.CommandText = query;
                AppConfig.Command.Parameters.AddWithValue("@MaPhieu", maPhieu);
                AppConfig.Command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                // Handle exceptions
                Console.WriteLine(ex.Message);
            }

        }

        public DataTable getPhieuDuThiByMaKyThi(string maKyThi)
        {
            string query = "SELECT * FROM phieu_du_thi WHERE ma_ky_thi = @MaKyThi";
            DataTable dataTable = new DataTable();
            try
            {
                AppConfig.Command.Parameters.Clear();
                AppConfig.Command.CommandText = query;
                AppConfig.Command.Parameters.AddWithValue("@MaKyThi", maKyThi);
                AppConfig.Adapter.SelectCommand = AppConfig.Command;
                AppConfig.Adapter.Fill(dataTable);
            }
            catch (Exception ex)
            {
                // Handle exceptions
                Console.WriteLine(ex.Message);
            }

            return dataTable;
        }

        public DataRow getPhieuDuThiByMaPhieu(string maPhieu)
        {
            string query = "SELECT * FROM phieu_du_thi WHERE ma_phieu_du_thi = @MaPhieu";
            DataTable dataTable = new DataTable();
            try
            {
                AppConfig.Command.Parameters.Clear();
                AppConfig.Command.CommandText = query;
                AppConfig.Command.Parameters.AddWithValue("@MaPhieu", maPhieu);
                AppConfig.Adapter.SelectCommand = AppConfig.Command;
                AppConfig.Adapter.Fill(dataTable);
            }
            catch (Exception ex)
            {
                // Handle exceptions
                Console.WriteLine(ex.Message);
            }

            return dataTable.Rows.Count > 0 ? dataTable.Rows[0] : null;
        }

    }
}
