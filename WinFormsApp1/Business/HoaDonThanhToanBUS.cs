using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WinFormsApp1.DAO;
using System.Data;
using System.Diagnostics;
namespace WinFormsApp1.Business
{
    internal class HoaDonThanhToanBUS
    {

        private HoaDonThanhToanDAO hoaDonThanhToanDAO = new HoaDonThanhToanDAO();

        // constructor
        public HoaDonThanhToanBUS() { }

        // create a new hoa don thanh toan
        public int taoHoaDonThanhToan(string loaiThanhToan, float soTien, float giamGia, DateTime ngayThanhToan, string hinhThuc, string maGiaoDich)
        {
            int maHoaDonThanhToan = hoaDonThanhToanDAO.addHoaDonThanhToan(loaiThanhToan, soTien, giamGia, ngayThanhToan, hinhThuc, maGiaoDich);
            Debug.WriteLine("maHoaDonThanhToan: " + maHoaDonThanhToan);
            // update trang thai phieu dang ky
            return maHoaDonThanhToan;
        }

    }
}
