using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WinFormsApp1.DAO;

namespace WinFormsApp1.Business
{
    internal class PhieuDuThiBUS
    {
        private PhieuDuThiDAO phieuDuThiDAO = new PhieuDuThiDAO();

        public PhieuDuThiBUS() { }

        public DataTable dtbGetPhieuDuThiByMaThiSinh(string maThiSinh)
        {
            DataTable dataTable = phieuDuThiDAO.getPhieuDuThiByMaThiSinh(maThiSinh);
            dataTable.Columns.Add("thoi_gian_bat_dau", typeof(string));
            dataTable.Columns.Add("ma_chung_chi", typeof(string));
            DateTime now = DateTime.Now;

            for (int i = 0; i < dataTable.Rows.Count; i++)
            {
                DataRow kythi = new KyThiBUS().getKyThiByMaKyThi(int.Parse(dataTable.Rows[i]["ma_ky_thi"].ToString()));

                // Xóa những phiếu đã thi rồi (có điểm) hoặc cách ngày thi không quá 24 tiếng (now sớm hơn thoi_gian_bat_dau)    
                if (dataTable.Rows[i]["diem"] != DBNull.Value ||
                    DateTime.Parse(kythi["thoi_gian_bat_dau"].ToString()) - now < TimeSpan.FromHours(24))
                {
                    dataTable.Rows[i].Delete();
                }
                else
                {
                    dataTable.Rows[i]["thoi_gian_bat_dau"] = kythi["thoi_gian_bat_dau"].ToString();
                    dataTable.Rows[i]["ma_chung_chi"] = kythi["ma_chung_chi"].ToString();
                }
            }

            dataTable.AcceptChanges(); // Ensure deleted rows are removed  
            dataTable.Columns.Remove("diem");


            return dataTable;
        }

        public void updateMaKyThi(string maPhieuDuThi, string maKyThi)
        {
            phieuDuThiDAO.updateMaKyThi(maPhieuDuThi, maKyThi);
        }

        
    }
}
