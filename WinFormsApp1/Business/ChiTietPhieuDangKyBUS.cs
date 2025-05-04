using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WinFormsApp1.DAO;

namespace WinFormsApp1.Business
{
    internal class ChiTietPhieuDangKyBUS
    {
        private ChiTietPhieuDangKyDAO chiTietPhieuDangKyDAO;
        public ChiTietPhieuDangKyBUS()
        {
            chiTietPhieuDangKyDAO = new ChiTietPhieuDangKyDAO();
        }

        public void AddChiTietPhieuDangKy(string maPhieuDangKy, string maKyThi, string maThiSinh)
        {
            chiTietPhieuDangKyDAO.addChiTietPhieuDangKy(Convert.ToInt32(maPhieuDangKy), Convert.ToInt32(maKyThi), Convert.ToInt32(maThiSinh));
        }

        public DataTable GetAllChiTietPhieuDangKy()
        {
            return chiTietPhieuDangKyDAO.getAllChiTietPhieuDangKy();
        }

        public DataTable LayDSChiTietPhieuDK(string maPhieuDK)
        {
            return chiTietPhieuDangKyDAO.getChiTietPhieuDKByMaPhieuDK(maPhieuDK);
        }



    }
}
