using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WinFormsApp1.DAO;
using System.Data;

namespace WinFormsApp1.Business
{
    internal class ChiTietPhieuDKBUS
    {
        private ChiTietPhieuDangKyDAO chiTietPhieuDangKyDAO = new ChiTietPhieuDangKyDAO();

        public DataTable LayDSChiTietPhieuDK(string maPhieuDK)
        {
            return chiTietPhieuDangKyDAO.getChiTietPhieuDKByMaPhieuDK(maPhieuDK);
        }
    }
}
