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
    internal class NhanVienDAO
    {
        public NhanVienDAO()
        {
        }

        public void addNhanVien(string maNV, string hoTen, DateTime ngaySinh, string diaChi, string soDienThoai, string email, string chucVu)
        {
            string query = "INSERT INTO nhan_vien (ma_nv, ho_ten, ngay_sinh, dia_chi, so_dien_thoai, email, chuc_vu) " +
                "VALUES (@MaNV, @HoTen, @NgaySinh, @DiaChi, @SoDienThoai, @Email, @ChucVu)";
            try
            {
                // Insert new record
                AppConfig.Command.CommandText = query;
                AppConfig.Command.Parameters.AddWithValue("@MaNV", maNV);
                AppConfig.Command.Parameters.AddWithValue("@HoTen", hoTen);
                AppConfig.Command.Parameters.AddWithValue("@NgaySinh", ngaySinh);
                AppConfig.Command.Parameters.AddWithValue("@DiaChi", diaChi);
                AppConfig.Command.Parameters.AddWithValue("@SoDienThoai", soDienThoai);
                AppConfig.Command.Parameters.AddWithValue("@Email", email);
                AppConfig.Command.Parameters.AddWithValue("@ChucVu", chucVu);
                AppConfig.Command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                // Handle exceptions
                Debug.WriteLine(ex.Message);
            }
            finally
            {
              
            }
        }

        public DataTable getAllNhanVien()
        {
            string query = "SELECT * FROM nhan_vien";
            DataTable dataTable = new DataTable();
            try
            {

                AppConfig.Command.CommandText = query;
                AppConfig.Adapter.SelectCommand= AppConfig.Command;
                AppConfig.Adapter.Fill(dataTable);
            }
            catch (Exception ex)
            {
                // Handle exceptions
                Debug.WriteLine(ex.Message);
            }
            finally
            {
            }
            return dataTable;
        }

        public DataRow getNhanVienByMaNV(string maNV)
        {
            string query = "SELECT * FROM nhan_vien WHERE ma_nv = @MaNV";
            DataTable dataTable = new DataTable();
            try
            {
                AppConfig.Command.CommandText = query;
                AppConfig.Command.Parameters.AddWithValue("@MaNV", maNV);
                AppConfig.Adapter.SelectCommand = AppConfig.Command;
                AppConfig.Adapter.Fill(dataTable);
            }
            catch (Exception ex)
            {
                // Handle exceptions
                Debug.WriteLine(ex.Message);
            }
            finally
            {
            }
            return dataTable.Rows.Count > 0 ? dataTable.Rows[0] : null;
        }

        public int getChucVuByMaNV(int maNV)
        {
            Debug.WriteLine($"Attempting to get Chuc Vu with maNV: {maNV}");
            string query = "SELECT chuc_vu FROM nhan_vien WHERE ma_nhan_vien = @MaNV";
            try
            {
                AppConfig.Command.CommandText = query;
                AppConfig.Command.Parameters.AddWithValue("@MaNV", maNV);
                int chucVu = (int)AppConfig.Command.ExecuteScalar();
                return chucVu;
            }
            catch (Exception ex)
            {
                // Handle exceptions
                Debug.WriteLine(ex.Message);
                return -1; // Return -1 if an error occurs
            }
            finally
            {
            }
        }
    }
}
