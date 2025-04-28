using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WinFormsApp1.DAO;
using WinFormsApp1.DAO.Database;

namespace WinFormsApp1.Business
{
    internal class DangNhapBUS
    {
        #region entity_prop    
        private string ten_dang_nhap;
        private string mat_khau;
        private int ma_chuc_vu;
        public DangNhapBUS() { }
        public string TenDangNhap
        {
            get { return this.ten_dang_nhap; }
            set { this.ten_dang_nhap = value; }
        }
        public string MatKhau
        {
            get { return this.mat_khau; }
            set { this.mat_khau = value; }
        }
        public int MaNguoiDangKy
        {
            get { return this.ma_chuc_vu; }
            set { this.ma_chuc_vu = value; }
        }
        #endregion

        #region DAO
        private TaiKhoanDAO taiKhoanDAO = new TaiKhoanDAO();
        private NhanVienDAO nhanVienDAO = new NhanVienDAO();
        #endregion

        public int dangNhap(string tenDangNhap, string matKhau)
        {
            
            if (taiKhoanDAO.authenticate(tenDangNhap, matKhau))
            {
                this.ma_chuc_vu = nhanVienDAO.getChucVuByMaNV(Convert.ToInt32(tenDangNhap));
                this.ten_dang_nhap = tenDangNhap;
                Debug.WriteLine($"Login successful for user: {tenDangNhap}");
                this.mat_khau = matKhau;
                return ma_chuc_vu;
            } else return -1; // Invalid login
            
        }

        public void dangXuat()
        {
            this.ten_dang_nhap = null;
            this.mat_khau = null;
            this.ma_chuc_vu = -1; // Reset to an invalid state
        }

        private static DangNhapBUS instance;

        public static DangNhapBUS Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new DangNhapBUS();
                }
                return instance;
            }
        }
    }
}
