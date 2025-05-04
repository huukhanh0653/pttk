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
    internal class ChucVuNhanVienDAO
    {
        public ChucVuNhanVienDAO()
        {
        }
        public void addChucVu(string maChucVu, string tenChucVu)
        {
            string query = "INSERT INTO chuc_vu (ma_chuc_vu, ten_chuc_vu) VALUES (@MaChucVu, @TenChucVu)";
            try
            {
                // Insert new record
                AppConfig.Command.CommandText = query;
                AppConfig.Command.Parameters.AddWithValue("@MaChucVu", maChucVu);
                AppConfig.Command.Parameters.AddWithValue("@TenChucVu", tenChucVu);
                AppConfig.Command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                // Handle exceptions
                Debug.WriteLine(ex.Message);
            }
        }
        public DataTable getAllChucVu()
        {
            string query = "SELECT * FROM chuc_vu";
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
                Debug.WriteLine(ex.Message);
            }

            return dataTable;
        }

        public DataRow getChucVuByMaCV(string maCV)
        {
            string query = "SELECT * FROM chuc_vu WHERE ma_chuc_vu = @MaCV";
            DataTable dataTable = new DataTable();
            try
            {
                
                AppConfig.Command.CommandText = query;
                AppConfig.Command.Parameters.AddWithValue("@MaCV", maCV);
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
    }
}
