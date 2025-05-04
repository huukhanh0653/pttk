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
    internal class ChungChiThiSinhDAO
    {
        public ChungChiThiSinhDAO()
        {
        }
        public DataTable getAllChungChiThiSinh()
        {
            string query = "SELECT * FROM chung_chi_thi_sinh";
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
                Debug.WriteLine(ex.Message);
            }
            return dataTable;
        }

        public void addChungChiThiSinh(string maChungChi, string maThiSinh)
        {
            string query = "INSERT INTO chung_chi_thi_sinh (ma_chung_chi, ma_thi_sinh) VALUES (@MaChungChi, @MaThiSinh)";
            try
            {
                
                // Insert new record
                AppConfig.Command.CommandText = query;
                AppConfig.Command.Parameters.Clear();
                AppConfig.Command.Parameters.AddWithValue("@MaChungChi", maChungChi);
                AppConfig.Command.Parameters.AddWithValue("@MaThiSinh", maThiSinh);
                AppConfig.Command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                // Handle exceptions
                Debug.WriteLine(ex.Message);
            }
        }

        public DataTable getChungChiThiSinhByMaThiSinh(string maThiSinh)
        {
            string query = "SELECT * FROM chung_chi_thi_sinh WHERE ma_thi_sinh = @MaThiSinh";
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

        public DataRow getChungChiThiSinhByMaTSAndMaCC(string maThiSinh, string maChungChi)
        {
            string query = "SELECT * FROM chung_chi_thi_sinh WHERE ma_thi_sinh = @MaThiSinh AND ma_chung_chi = @MaChungChi";
            DataTable dataTable = new DataTable();
            try
            {
                
                AppConfig.Command.CommandText = query;
                AppConfig.Command.Parameters.Clear();
                AppConfig.Command.Parameters.AddWithValue("@MaThiSinh", maThiSinh);
                AppConfig.Command.Parameters.AddWithValue("@MaChungChi", maChungChi);
                AppConfig.Adapter.SelectCommand = AppConfig.Command;
                AppConfig.Adapter.Fill(dataTable);
            }
            catch (Exception ex)
            {
                // Handle exceptions
                Debug.WriteLine(ex.Message);
            }

            return dataTable.Rows.Count > 0 ? dataTable.Rows[0] : null;
        }

        public DataTable searchChungChiThiSinh(string timKiem)
        {
            string query = "SELECT * FROM chung_chi_thi_sinh WHERE ma_thi_sinh LIKE @TimKiem OR ma_chung_chi LIKE @TimKiem";
            DataTable dataTable = new DataTable();
            try
            {
                AppConfig.Command.CommandText = query;
                AppConfig.Command.Parameters.Clear();
                AppConfig.Command.Parameters.AddWithValue("@TimKiem", "%" + timKiem + "%");
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

        public void capPhatChungChi(int maChungChi, int maThiSinh, DateOnly ngayCap)
        {
            string query = "UPDATE chung_chi_thi_sinh set da_cap_phat = 1 WHERE ma_chung_chi = @MaChungChi AND ma_thi_sinh = @MaThiSinh AND ngay_cap = @NgayCap";
            try
            {
                AppConfig.Command.CommandText = query;
                AppConfig.Command.Parameters.Clear();
                AppConfig.Command.Parameters.AddWithValue("@MaChungChi", maChungChi);
                AppConfig.Command.Parameters.AddWithValue("@MaThiSinh", maThiSinh);
                AppConfig.Command.Parameters.AddWithValue("@NgayCap", ngayCap);
                AppConfig.Adapter.SelectCommand = AppConfig.Command;
                AppConfig.Command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                // Handle exceptions
                Debug.WriteLine("capPhatChungChi" + ex.Message);
            }
        }
    }
}
