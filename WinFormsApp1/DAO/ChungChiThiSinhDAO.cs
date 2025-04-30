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
        public void addChungChiThiSinh(string maChungChi, string maThiSinh)
        {
            string query = "INSERT INTO chung_chi_thi_sinh (ma_chung_chi, ma_thi_sinh) VALUES (@MaChungChi, @MaThiSinh)";
            try
            {
                
                // Insert new record
                AppConfig.Command.CommandText = query;
                AppConfig.Command.Parameters.AddWithValue("@MaChungChi", maChungChi);
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

        public DataTable getChungChiThiSinhByMaThiSinh(string maThiSinh)
        {
            string query = "SELECT * FROM chung_chi_thi_sinh WHERE ma_thi_sinh = @MaThiSinh";
            DataTable dataTable = new DataTable();
            try
            {
                
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
            finally
            {
                
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
                AppConfig.Command.Parameters.AddWithValue("@MaThiSinh", maThiSinh);
                AppConfig.Command.Parameters.AddWithValue("@MaChungChi", maChungChi);
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
            return dataTable.Rows.Count > 0 ? dataTable.Rows[0] : null;
        }
    }
}
