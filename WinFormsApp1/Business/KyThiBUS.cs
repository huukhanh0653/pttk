using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WinFormsApp1.DAO;

namespace WinFormsApp1.Business
{
    internal class KyThiBUS
    {
        private int maKyThi;
        private int maChungChi;
        private int soPhong;
        private string diaDiem;
        private string tenKyThi;
        private string moTa;
        private DateTime thoiGianBatDau;
        private int soLuongToiDa;
        private int soLuongDangKyHienTai;

        public KyThiBUS(int maKyThi, int maChungChi, int soPhong, string diaDiem, string tenKyThi, string moTa, DateTime thoiGianBatDau,
            int soLuongToiDa, int soLuongDangKyHienTai)
        {
            this.maKyThi = maKyThi;
            this.maChungChi = maChungChi;
            this.soPhong = soPhong;
            this.diaDiem = diaDiem;
            this.tenKyThi = tenKyThi;
            this.moTa = moTa;
            this.thoiGianBatDau = thoiGianBatDau;
            this.soLuongToiDa = soLuongToiDa;
            this.soLuongDangKyHienTai = soLuongDangKyHienTai;
        }

        public KyThiBUS() { }


        private KyThiDAO kyThiDAO = new KyThiDAO();

        public KyThiBUS(string maKyThi)
        {
            DataRow row = this.kyThiDAO.getKyThiByMaKyThi(Convert.ToInt32(maKyThi));

            this.maKyThi = int.Parse(row["ma_ky_thi"].ToString());
            this.maChungChi = int.Parse(row["ma_chung_chi"].ToString());
            this.soLuongToiDa = int.Parse(row["so_luong_toi_da"].ToString());
            this.soLuongDangKyHienTai = int.Parse(row["so_luong_dang_ky_hien_tai"].ToString());
            this.thoiGianBatDau = DateTime.Parse(row["thoi_gian_bat_dau"].ToString());

        }

        public DataTable dtbCungCapLichThi(string maKythi)
        {
            // Dựa vào maKythi để lấy thông tin kỳ thi            // Lấy thông tin kỳ thi hiện tại
            DataRow kyThiHienTai = kyThiDAO.getKyThiByMaKyThi(Convert.ToInt32(maKythi));
            // Lấy danh sách kỳ thi cùng chứng chỉ
            DataTable dataTable = kyThiDAO.getAllKyThiByMaChungChi(Convert.ToInt32(kyThiHienTai["ma_chung_chi"].ToString()));
            return dataTable;
        }

        public DataTable getKyThiByMaChungChi(string maChungChi)
        {
            DataTable dataTable = kyThiDAO.getAllKyThiByMaChungChi(Convert.ToInt32(maChungChi));
            return dataTable;
        }

        public DataTable getKyThiByMaChungChiLater(string maChungChi)
        {
            Debug.WriteLine("getKyThiByMaChungChiLater");
            DataTable dataTable = kyThiDAO.getAllKyThiByMaChungChi(Convert.ToInt32(maChungChi));

            for (int i = 0; i < dataTable.Rows.Count; i++)
            {
                if (DateTime.Parse(dataTable.Rows[i]["thoi_gian_bat_dau"].ToString()) < DateTime.Now)
                {
                    dataTable.Rows.RemoveAt(i);
                    i--;
                }
            }

            return dataTable;
        }

        public DataTable dtbGetAllKyThi()
        {
            Debug.WriteLine("dtbGetAllKyThi");
            return kyThiDAO.getAllKyThi();
        }

        public bool isFull()
        {
            Debug.WriteLine("isFull");
            return soLuongDangKyHienTai >= soLuongToiDa;
        }

        public bool isEarlyAtLeast24h()
        {
            Debug.WriteLine("isEarlyAtLeast24h");
            return thoiGianBatDau - DateTime.Now > TimeSpan.FromHours(24);

        }

        public DataRow getKyThiByMaKyThi(int maKyThi)
        {
            Debug.WriteLine("getKyThiByMaKyThi");
            return kyThiDAO.getKyThiByMaKyThi(maKyThi);
        }

        //public Data
    }
}
