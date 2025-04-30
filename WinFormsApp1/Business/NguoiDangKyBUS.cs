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
        private KyThiDAO kyThiDAO = new KyThiDAO();
        public NguoiDangKyBUS() { }

        public DataTable dtbGetNguoiDangKyByMaThiSinh(string maThiSinh)
        {
            DataTable dataTable = nguoiDangKyDAO.getNguoiDangKyByMaThiSinh(maThiSinh);
            dataTable.Columns.Add("thoi_gian_bat_dau", typeof(string));
            DateTime now = DateTime.Now;

            for (int i = 0; i < dataTable.Rows.Count; i++)
            {
                DataRow kythi = kyThiDAO.getKyThiByMaKyThi(int.Parse(dataTable.Rows[i]["ma_ky_thi"].ToString()));

                // Xóa những phiếu đã thi rồi (có điểm) hoặc cách ngày thi không quá 24 tiếng (now sớm hơn thoi_gian_bat_dau)    
                if (dataTable.Rows[i]["diem"] != DBNull.Value ||
                    DateTime.Parse(kythi["thoi_gian_bat_dau"].ToString()) - now < TimeSpan.FromHours(24))
                {
                    dataTable.Rows[i].Delete();
                } else
                {
                    dataTable.Rows[i]["thoi_gian_bat_dau"] = kythi["thoi_gian_bat_dau"].ToString();
                }
            }

            dataTable.AcceptChanges(); // Ensure deleted rows are removed  
            dataTable.Columns.Remove("diem");
            

            return dataTable;
        }

        public DataRow getTTNguoiDangKyByMaNguoiDangKy(string maNguoiDangKy)
        {
            return nguoiDangKyDAO.findNguoiDangKyById(int.Parse(maNguoiDangKy));
        }
        

        //public DataTable dtbCungCapLichThi()
    }
}