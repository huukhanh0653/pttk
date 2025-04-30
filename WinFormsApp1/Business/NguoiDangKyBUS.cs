using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WinFormsApp1.DAO;

namespace WinFormsApp1.Business
{
    internal class NguoiDangKyBUS
    {
        private NguoiDangKyDAO nguoiDangKyDAO = new NguoiDangKyDAO();

        public NguoiDangKyBUS() { }

        public DataTable GetAllNguoiDangKy()
        {
            return nguoiDangKyDAO.getAllNguoiDangKy();
        }

        public void AddNguoiDangKy(string hoTen, DateOnly ngaySinh, string soDienThoai, string email, bool donVi)
        {
            nguoiDangKyDAO.addNguoiDangKy(hoTen, ngaySinh, soDienThoai, email, donVi);
        }

        public void UpdateNguoiDangKy(int maNguoiDangKy, string hoTen, DateOnly ngaySinh, string soDienThoai, string email, bool donVi)
        {
            nguoiDangKyDAO.updateNguoiDangKy(maNguoiDangKy, hoTen, ngaySinh, soDienThoai, email, donVi);
        }

        public void DeleteNguoiDangKy(int maNguoiDangKy)
        {
            nguoiDangKyDAO.deleteNguoiDangKy(maNguoiDangKy);
        }

        public DataTable SearchNguoiDangKy(string searchTerm)
        {
            return nguoiDangKyDAO.searchNguoiDangKy(searchTerm);
        }

    }
}
