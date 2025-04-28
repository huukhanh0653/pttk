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
    internal class PhieuGiaHanDAO
    {
        private SqlCommand command;
        private SqlConnection connection;
        private SqlDataAdapter adapter;
        public PhieuGiaHanDAO()
        {
            connection = new SqlConnection(AppConfig.ConnectionString);
            command = new SqlCommand();
            command.Connection = connection;
            adapter = new SqlDataAdapter(); // Initialize the adapter to avoid CS8618 warning
        }
        public void addPhieuGiaHan(string maPhieu, string maThanhToan, string maPhieuDuThi, int soLan, int maKyThiCu, int maKyThiMoi,
            DateTime thoiGianGiahHan, Double PhiGiaHan, bool trangThai, string lyDo, bool THDacBiet, DateTime TGThiMoi, int MaNV)
        {
            string query = "INSERT INTO phieu_gia_han (ma_phieu_gia_han, ma_thanh_toan, ma_phieu_du_thi, so_lan, ma_ky_thi_cu, ma_ky_thi_moi, thoi_gian_gia_han, phi_gia_han, trang_thai, ly_do, th_dac_biet, tg_thi_moi, ma_nv) " +
                "VALUES (@MaPhieu, @MaThanhToan, @MaPhieuDuThi, @SoLan, @MaKyThiCu, @MaKyThiMoi, @ThoiGianGiaHan, @PhiGiaHan, @TrangThai, @LyDo, @THDacBiet, @TGThiMoi, @MaNV)";
            try
            {
                connection.Open();
                // Insert new record
                command.CommandText = query;
                command.Parameters.AddWithValue("@MaPhieu", maPhieu);
                command.Parameters.AddWithValue("@MaThanhToan", maThanhToan);
                command.Parameters.AddWithValue("@MaPhieuDuThi", maPhieuDuThi);
                command.Parameters.AddWithValue("@SoLan", soLan);
                command.Parameters.AddWithValue("@MaKyThiCu", maKyThiCu);
                command.Parameters.AddWithValue("@MaKyThiMoi", maKyThiMoi);
                command.Parameters.AddWithValue("@ThoiGianGiaHan", thoiGianGiahHan);
                command.Parameters.AddWithValue("@PhiGiaHan", PhiGiaHan);
                command.Parameters.AddWithValue("@TrangThai", trangThai);
                command.Parameters.AddWithValue("@LyDo", lyDo);
                command.Parameters.AddWithValue("@THDacBiet", THDacBiet);
                command.Parameters.AddWithValue("@TGThiMoi", TGThiMoi);
                command.Parameters.AddWithValue("@MaNV", MaNV);
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
        public DataTable getAllPhieuGiaHan()
        {
            string query = "SELECT * FROM phieu_gia_han";
            DataTable dataTable = new DataTable();
            try
            {
                connection.Open();
                command.CommandText = query;
                adapter.SelectCommand = command;
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

        public DataTable getPhieuGiaHanByMaPhieu(string maPhieu)
        {
            string query = "SELECT * FROM phieu_gia_han WHERE ma_phieu_gia_han = @MaPhieu";
            DataTable dataTable = new DataTable();
            try
            {
                connection.Open();
                command.CommandText = query;
                command.Parameters.AddWithValue("@MaPhieu", maPhieu);
                adapter.SelectCommand = command;
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
    }
}
