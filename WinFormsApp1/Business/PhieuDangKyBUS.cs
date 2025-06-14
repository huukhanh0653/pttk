using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WinFormsApp1.DAO;

namespace WinFormsApp1.Business
{
    internal class PhieuDangKyBUS
    {
        private PhieuDangKyDAO phieuDangKyDAO = new PhieuDangKyDAO();
        private NguoiDangKyDAO nguoiDangKyDAO = new NguoiDangKyDAO();
        private ChiTietPhieuDangKyDAO chiTietPhieuDangKyDAO = new ChiTietPhieuDangKyDAO();

        public PhieuDangKyBUS() {}

        public DataTable GetAllPhieuDangKy()
        {
            DataTable dataTable = phieuDangKyDAO.getAllPhieuDangKy();
            return dataTable;
        }

        public DataTable GetAllPhieuDangKyAndChiTiet()
        {
            DataTable phieu = phieuDangKyDAO.getAllPhieuDangKy();
            DataTable chitiet = chiTietPhieuDangKyDAO.getAllChiTietPhieuDangKy();

            DataTable merge = phieu.Clone();

            merge.Columns.Add("ma_thi_sinh", typeof(int));
            merge.Columns.Add("ma_ky_thi", typeof(int));

            foreach (DataRow row in merge.Rows)
            {
                DataRow[] foundRows = chitiet.Select("ma_phieu_dang_ky = " + row["ma_phieu_dang_ky"]);
                if (foundRows.Length > 0)
                {
                    row["ma_thi_sinh"] = foundRows[0]["ma_thi_sinh"];
                    row["ma_ky_thi"] = foundRows[0]["ma_ky_thi"];
                }
            }

            return merge;
        }

        public int AddPhieuDangKy(string maPhieuDangKy, DateTime ngayDangKy, int maNguoiDangKy, double tongTien)
        {
            return phieuDangKyDAO.addPhieuDangKy(maPhieuDangKy, DateOnly.FromDateTime(ngayDangKy), maNguoiDangKy, tongTien);
        }
        public DataRow LayTTPhieuDangKyByMaPhieu(string maPhieu)
        {
            DataRow datarow = phieuDangKyDAO.getTTPhieuDangKyByMaPhieu(maPhieu);
            return datarow;
        }

        public DataTable LayTTPhieuDangKyByMaNguoiDangKy(string maNguoiDangKy)
        {
            DataTable dataTable = phieuDangKyDAO.getDSPhieuDangKyByMaNguoiDangKy(maNguoiDangKy);
            return dataTable;
        }

        public DataTable TimKiemTTPhieuDangKyByMaPhieu(string maPhieu)
        {
            DataTable dataTable = phieuDangKyDAO.searchTTPhieuDangKyByMaPhieu(maPhieu);
            return dataTable;
        }
        
        public DataTable LayDSPhieuDK()
        {
            DataTable dataTable = phieuDangKyDAO.getAllPhieuDangKy();


            for (int i = 0; i < dataTable.Rows.Count; i++)
            {
                DataRow row = dataTable.Rows[i];
                row["ma_phieu_dang_ky"] = row["ma_phieu_dang_ky"].ToString();
                row["ngay_dang_ky"] = row["ngay_dang_ky"].ToString();
                row["tong_tien"] = row["tong_tien"].ToString();
                row["ma_nguoi_dang_ky"] = row["ma_nguoi_dang_ky"].ToString();
                
            }
            return dataTable;
        }

        public DataTable LayDSPhieuDKChuaThanhToan()
        {
            DataTable dataTable = phieuDangKyDAO.getAllPhieuDangKy();
            dataTable.DefaultView.RowFilter = "trang_thai_thanh_toan = 0";
            return dataTable.DefaultView.ToTable();
        }

        public void CapNhatTrangThaiPhieuDangKy(string maPhieuDK, int maHoaDonThanhToan, int trangThai)
        {
            phieuDangKyDAO.updateTrangThaiPhieuDangKy(maPhieuDK, maHoaDonThanhToan, trangThai);
        }
    }
}
