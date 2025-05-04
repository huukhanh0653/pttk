using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using WinFormsApp1.DAO;
using System.Diagnostics;

namespace WinFormsApp1.Business
{
    internal class DanhSachChungChiBUS
    {
        private DanhSachChungChiDAO danhSachChungChiDAO = new DanhSachChungChiDAO();
        public DanhSachChungChiBUS() { }
        public DataTable GetAllDanhSachChungChi()
        {
            DataTable dataTable = danhSachChungChiDAO.getAllChungChi();
            return dataTable;
        }
        
        public DataRow getChungChiByMaChungChi(int maChungChi)
        {
            DataRow dataRow = danhSachChungChiDAO.getChungChiByMaChungChi(maChungChi);
            Debug.WriteLine("Ma Chung Chi tim kiem: " + maChungChi);
            //Debug.WriteLine("getChungChiByMaChungChi" + (dataRow.? "row is null" : "row not null"));
            return dataRow;
        }

        public void CapPhatChungChi(int maChungChi)
        {

        }
    }
}
