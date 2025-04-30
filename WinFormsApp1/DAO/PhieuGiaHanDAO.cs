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
    internal class PhieuGiaHanDAO
    {
        public PhieuGiaHanDAO()
        { }

        public int getNextMaPhieuGiaHan()
        {
            string query = "SELECT MAX(ma_phieu_gia_han) FROM phieu_gia_han";
            int nextMaPhieuGiaHan = 0;
            try
            {
                AppConfig.Command.CommandText = query;
                AppConfig.Command.Parameters.Clear();
                object result = AppConfig.Command.ExecuteScalar();
                if (result != DBNull.Value)
                {
                    nextMaPhieuGiaHan = Convert.ToInt32(result);
                }
}
            catch (Exception ex)
            {
                // Handle exceptions
                Debug.WriteLine("error in getNextMaPhieuGiaHan " + ex.Message);
            }
            return nextMaPhieuGiaHan + 1;
        }

        public int getSoLan(string maPhieuDuThi)
        {
            string query = "SELECT so_lan FROM phieu_gia_han WHERE ma_phieu_du_thi = @MaPhieuDuThi";
            int soLan = 0;
            try
            {
                AppConfig.Command.CommandText = query;
                AppConfig.Command.Parameters.Clear();
                AppConfig.Command.Parameters.AddWithValue("@MaPhieuDuThi", maPhieuDuThi);
                object result = AppConfig.Command.ExecuteScalar();
                if (result != DBNull.Value)
                {
                    soLan = Convert.ToInt32(result);
                }
            }
            catch (Exception ex)
            {
                // Handle exceptions
                Debug.WriteLine("error in getSoLan" + ex.Message);
            }
            return soLan;
        }
        public void addPhieuGiaHan(string maPhieu, string maPhieuDuThi, int soLan, int maKyThiCu, int maKyThiMoi,
            DateTime thoiGianGiahHan, Double PhiGiaHan, bool trangThai, string lyDo, bool THDacBiet, DateTime TGThiMoi, int MaNV)
        {
            string query = "INSERT INTO phieu_gia_han (ma_phieu_gia_han, phieu_du_thi, so_lan, ma_ky_thi_cu, ma_ky_thi_moi, ngay_gia_han, phi_gia_han, trang_thai_thanh_toan, " +
                "ly_do, truong_hop_dac_biet, thoi_gian_thi_moi, ma_nhan_vien) " +
                "VALUES (@MaPhieu, @MaPhieuDuThi, @SoLan, @MaKyThiCu, @MaKyThiMoi, @ThoiGianGiaHan, @PhiGiaHan, @TrangThai, @LyDo, @THDacBiet, @TGThiMoi, @MaNV)";
            try
            {

                // Insert new record
                AppConfig.Command.CommandText = query;
                AppConfig.Command.Parameters.Clear();
                AppConfig.Command.Parameters.AddWithValue("@MaPhieu", maPhieu);
                
                AppConfig.Command.Parameters.AddWithValue("@MaPhieuDuThi", maPhieuDuThi);
                AppConfig.Command.Parameters.AddWithValue("@SoLan", soLan);
                AppConfig.Command.Parameters.AddWithValue("@MaKyThiCu", maKyThiCu);
                AppConfig.Command.Parameters.AddWithValue("@MaKyThiMoi", maKyThiMoi);
                AppConfig.Command.Parameters.AddWithValue("@ThoiGianGiaHan", thoiGianGiahHan);
                AppConfig.Command.Parameters.AddWithValue("@PhiGiaHan", PhiGiaHan);
                AppConfig.Command.Parameters.AddWithValue("@TrangThai", trangThai);
                AppConfig.Command.Parameters.AddWithValue("@LyDo", lyDo);
                AppConfig.Command.Parameters.AddWithValue("@THDacBiet", THDacBiet);
                AppConfig.Command.Parameters.AddWithValue("@TGThiMoi", TGThiMoi);
                AppConfig.Command.Parameters.AddWithValue("@MaNV", MaNV);
                AppConfig.Command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                // Handle exceptions
                Debug.WriteLine("addPhieuGiaHan catched an exception");
                Debug.WriteLine(ex.Message);
            }
        }
        public DataTable getAllPhieuGiaHan()
        {
            string query = "SELECT * FROM phieu_gia_han";
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
                Debug.WriteLine("error in getAllPhieuGiaHan" + ex.Message);
            }
            return dataTable;
        }

        public DataTable getPhieuGiaHanByMaPhieu(string maPhieu)
        {
            string query = "SELECT * FROM phieu_gia_han WHERE ma_phieu_gia_han = @MaPhieu";
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
                Debug.WriteLine("error in getPhieuGiaHanByMaPhieu: " + ex.Message);
            }
            return dataTable;
        }

        public DataTable getPhieuGiaHanByMaPhieuDuThi(int maPhieuDuThi)
        {
            string query = "SELECT * FROM phieu_gia_han WHERE phieu_du_thi = @MaPhieuDuThi";
            DataTable dataTable = new DataTable();
            try
            {
                AppConfig.Command.CommandText = query;
                AppConfig.Command.Parameters.Clear();
                AppConfig.Command.Parameters.AddWithValue("@MaPhieuDuThi", maPhieuDuThi);
                AppConfig.Adapter.SelectCommand = AppConfig.Command;
                AppConfig.Adapter.Fill(dataTable);
            }
            catch (Exception ex)
            {
                // Handle exceptions
                Debug.WriteLine("Error in getPhieuGiaHanByMaPhieuDuThi: " + ex.Message);
            }
            return dataTable;
        }

        public void updatePhieuGiaHan(string maPhieu, string maThanhToan, string maPhieuDuThi, int soLan, int maKyThiCu, int maKyThiMoi,
            DateTime thoiGianGiahHan, Double PhiGiaHan, bool trangThai, string lyDo, bool THDacBiet, DateTime TGThiMoi, int v)
        {
            string query = "UPDATE phieu_gia_han SET ma_thanh_toan = @MaThanhToan, ma_phieu_du_thi = @MaPhieuDuThi, so_lan = @SoLan, ma_ky_thi_cu = @MaKyThiCu, ma_ky_thi_moi = @MaKyThiMoi, thoi_gian_gia_han = @ThoiGianGiaHan, phi_gia_han = @PhiGiaHan, trang_thai = @TrangThai, ly_do = @LyDo, th_dac_biet = @THDacBiet, tg_thi_moi = @TGThiMoi WHERE ma_phieu_gia_han = @MaPhieu";
            try
            {
                AppConfig.Command.CommandText = query;
                AppConfig.Command.Parameters.Clear();
                AppConfig.Command.Parameters.AddWithValue("@MaPhieu", maPhieu);
                AppConfig.Command.Parameters.AddWithValue("@MaThanhToan", maThanhToan);
                AppConfig.Command.Parameters.AddWithValue("@MaPhieuDuThi", maPhieuDuThi);
                AppConfig.Command.Parameters.AddWithValue("@SoLan", soLan);
                AppConfig.Command.Parameters.AddWithValue("@MaKyThiCu", maKyThiCu);
                AppConfig.Command.Parameters.AddWithValue("@MaKyThiMoi", maKyThiMoi);
                AppConfig.Command.Parameters.AddWithValue("@ThoiGianGiaHan", thoiGianGiahHan);
                AppConfig.Command.Parameters.AddWithValue("@PhiGiaHan", PhiGiaHan);
                AppConfig.Command.Parameters.AddWithValue("@TrangThai", trangThai);
                AppConfig.Command.Parameters.AddWithValue("@LyDo", lyDo);
                AppConfig.Command.Parameters.AddWithValue("@THDacBiet", THDacBiet);
                AppConfig.Command.Parameters.AddWithValue("@TGThiMoi", TGThiMoi);
                AppConfig.Command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                // Handle exceptions
                Debug.WriteLine("error in updatePhieuGiaHan: " + ex.Message);
            }
        }


    }
}
