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
        private PhieuDangKyDAO phieuDangKyDAO;
        private ChiTietPhieuDangKyDAO chiTietPhieuDangKyDAO;

        public PhieuDangKyBUS()
        {
            phieuDangKyDAO = new PhieuDangKyDAO();
            chiTietPhieuDangKyDAO = new ChiTietPhieuDangKyDAO();
        }

        public void AddPhieuDangKy(string maNguoiDangKy, string nguoiTiepNhan, double tongTien)
        {
            phieuDangKyDAO.addPhieuDangKy(maNguoiDangKy, DateOnly.FromDateTime(DateTime.Now), Convert.ToInt32(nguoiTiepNhan), tongTien);
        }

        public DataTable GetAllPhieuDangKy()
        {
            return phieuDangKyDAO.getAllPhieuDangKy();
        }

        public void DeletePhieuDangKy(string maPhieu)
        {
            phieuDangKyDAO.deletePhieuDangKy(maPhieu);
        }

        public DataTable GetAllPhieuDangKyAndChiTiet()
        {
            DataTable phieu = phieuDangKyDAO.getAllPhieuDangKy();
            DataTable chiTiet = chiTietPhieuDangKyDAO.getAllChiTietPhieuDangKy();
            DataTable result = phieu.Clone();

            // Add additional columns for ChiTietPhieuDangKy data  
            foreach (DataColumn column in chiTiet.Columns)
            {
                if (!result.Columns.Contains(column.ColumnName))
                {
                    result.Columns.Add(column.ColumnName, column.DataType);
                }
            }


            foreach (DataRow dr in phieu.Rows)
            {
                foreach (DataRow dr2 in chiTiet.Rows)
                {
                    if (dr["ma_phieu_dang_ky"].ToString() == dr2["ma_phieu_dang_ky"].ToString())
                    {
                        DataRow newRow = result.NewRow();
                        newRow.ItemArray = dr.ItemArray;
                        newRow["ma_ky_thi"] = dr2["ma_ky_thi"];
                        newRow["ma_thi_sinh"] = dr2["ma_thi_sinh"];
                        result.Rows.Add(newRow);
                    }
                }
            }

            return result;
        }
    }
}
