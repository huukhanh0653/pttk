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
    internal class DanhSachChungChiDAO
    {
       
        public DanhSachChungChiDAO()
        {
        }
        public void addChungChi(string maChungChi, string tenChungChi)
        {
            string query = "INSERT INTO danh_sach_chung_chi (ma_chung_chi, ten_chung_chi) VALUES (@MaChungChi, @TenChungChi)";
            try
            {
                
                // Insert new record
                AppConfig.Command.CommandText = query;
                AppConfig.Command.Parameters.AddWithValue("@MaChungChi", maChungChi);
                AppConfig.Command.Parameters.AddWithValue("@TenChungChi", tenChungChi);
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
        public DataTable getAllChungChi()
        {
            string query = "SELECT * FROM danh_sach_chung_chi";
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

        public DataRow getChungChiByMaChungChi(int MaChungChi)
        {
            string query = "SELECT * FROM danh_sach_chung_chi WHERE ma_chung_chi = @MaChungChi";
            DataTable dataTable = new DataTable();
            try
            {
                
                AppConfig.Command.CommandText = query;
                AppConfig.Command.Parameters.AddWithValue("@MaChungChi", MaChungChi);
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

        public DataTable searchChungChi(string searchTerm)
        {
            string query = "SELECT * FROM danh_sach_chung_chi WHERE ma_chung_chi LIKE @SearchTerm OR ten_chung_chi LIKE @SearchTerm " +
                "OR don_vi_cap LIKE @SearchTerm OR gia_tien LIKE @SearchTerm";
            DataTable dataTable = new DataTable();
            try
            {
                
                AppConfig.Command.CommandText = query;
                AppConfig.Command.Parameters.AddWithValue("@SearchTerm", "%" + searchTerm + "%");
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
    }
}
