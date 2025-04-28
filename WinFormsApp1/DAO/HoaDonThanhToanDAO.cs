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
    internal class HoaDonThanhToanDAO
    {
        private SqlCommand command;
        private SqlConnection connection;
        private SqlDataAdapter adapter;

        public HoaDonThanhToanDAO()
        {
            connection = new SqlConnection(AppConfig.ConnectionString);
            command = new SqlCommand();
            command.Connection = connection;
            adapter = new SqlDataAdapter(); // Initialize the adapter to avoid CS8618 warning
        }

        public void addHoaDonThanhToan(string maThanhToan, string loaiThanhToan, double soTien, float giamGia, DateTime ngayThanhToan,
            string hinhThuc, string maGiaoDich)
        {
            string query = "INSERT INTO hoa_don_thanh_toan (ma_thanh_toan, loai_thanh_toan, so_tien, giam_gia, ngay_thanh_toan, hinh_thuc, ma_giao_dich) " +
                "VALUES (@MaThanhToan, @LoaiThanhToan, @SoTien, @GiamGia, @NgayThanhToan, @HinhThuc, @MaGiaoDich)";
            try
            {
                connection.Open();
                // Update record
                command.CommandText = query;
                command.Parameters.AddWithValue("@MaThanhToan", maThanhToan);
                command.Parameters.AddWithValue("@LoaiThanhToan", loaiThanhToan);
                command.Parameters.AddWithValue("@SoTien", soTien);
                command.Parameters.AddWithValue("@GiamGia", giamGia);
                command.Parameters.AddWithValue("@NgayThanhToan", ngayThanhToan);
                command.Parameters.AddWithValue("@HinhThuc", hinhThuc);
                command.Parameters.AddWithValue("@MaGiaoDich", maGiaoDich);
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

        public DataTable getAllHoaDonThanhToan()
        {
            string query = "SELECT * FROM hoa_don_thanh_toan";
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

        public void updateHoaDonThanhToan(string maThanhToan, string loaiThanhToan, double soTien, float giamGia, DateTime ngayThanhToan,
            string hinhThuc, string maGiaoDich)
        {
           string query = "UPDATE hoa_don_thanh_toan SET loai_thanh_toan = @LoaiThanhToan, so_tien = @SoTien, giam_gia = @GiamGia, " +
                "ngay_thanh_toan = @NgayThanhToan, hinh_thuc = @HinhThuc, ma_giao_dich = @MaGiaoDich WHERE ma_thanh_toan = @MaThanhToan";
            try
            {
                connection.Open();
                // Update record
                command.CommandText = query;
                command.Parameters.AddWithValue("@MaThanhToan", maThanhToan);
                command.Parameters.AddWithValue("@LoaiThanhToan", loaiThanhToan);
                command.Parameters.AddWithValue("@SoTien", soTien);
                command.Parameters.AddWithValue("@GiamGia", giamGia);
                command.Parameters.AddWithValue("@NgayThanhToan", ngayThanhToan);
                command.Parameters.AddWithValue("@HinhThuc", hinhThuc);
                command.Parameters.AddWithValue("@MaGiaoDich", maGiaoDich);
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

        public void deleteHoaDonThanhToan(string maHoaDon)
        {
            string query = "DELETE FROM hoa_don_thanh_toan WHERE ma_hoa_don = @MaHoaDon";
            try
            {
                connection.Open();
                // Delete record
                command.CommandText = query;
                command.Parameters.AddWithValue("@MaHoaDon", maHoaDon);
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

        public DataTable getHoaDonThanhToanByMaPhieu(string maPhieu)
        {
            string query = "SELECT * FROM hoa_don_thanh_toan WHERE ma_phieu = @MaPhieu";
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

        public DataTable getHoaDonThanhToanByMaKyThi(string maKyThi)
        {
            string query = "SELECT * FROM hoa_don_thanh_toan WHERE ma_ky_thi = @MaKyThi";
            DataTable dataTable = new DataTable();
            try
            {
                connection.Open();
                command.CommandText = query;
                command.Parameters.AddWithValue("@MaKyThi", maKyThi);
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

        public DataTable getHoaDonThanhToanByMaHoaDon(string maHoaDon)
        {
            string query = "SELECT * FROM hoa_don_thanh_toan WHERE ma_hoa_don = @MaHoaDon";
            DataTable dataTable = new DataTable();
            try
            {
                connection.Open();
                command.CommandText = query;
                command.Parameters.AddWithValue("@MaHoaDon", maHoaDon);
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

        public DataTable getHoaDonThanhToanByTrangThai(bool trangThai)
        {
            string query = "SELECT * FROM hoa_don_thanh_toan WHERE trang_thai = @TrangThai";
            DataTable dataTable = new DataTable();
            try
            {
                connection.Open();
                command.CommandText = query;
                command.Parameters.AddWithValue("@TrangThai", trangThai);
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

        public DataTable getHoaDonThanhToanByThoiGianLap(DateTime thoiGianLap)
        {
            string query = "SELECT * FROM hoa_don_thanh_toan WHERE thoi_gian_lap = @ThoiGianLap";
            DataTable dataTable = new DataTable();
            try
            {
                connection.Open();
                command.CommandText = query;
                command.Parameters.AddWithValue("@ThoiGianLap", thoiGianLap);
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

        public DataTable getHoaDonThanhToanByLoaiThanhToan(string loaiThanhToan)
        {
            string query = "SELECT * FROM hoa_don_thanh_toan WHERE loai_thanh_toan = @LoaiThanhToan";
            DataTable dataTable = new DataTable();
            try
            {
                connection.Open();
                command.CommandText = query;
                command.Parameters.AddWithValue("@LoaiThanhToan", loaiThanhToan);
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
