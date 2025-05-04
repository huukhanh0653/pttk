using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using WinFormsApp1.DAO;

namespace WinFormsApp1.Business
{
    internal class ThiSinhBUS
    {
        #region entity_prop    
        private int ma_thi_sinh;
        private string ho_ten;
        private DateOnly ngay_sinh;
        private string so_dien_thoai;
        private string email;
        private DateTime created_at;

        public ThiSinhBUS(int ma_thi_sinh, string ho_ten, DateOnly ngay_sinh, string so_dien_thoai, string email, DateTime created_at)
        {
            this.ma_thi_sinh = ma_thi_sinh;
            this.ho_ten = ho_ten;
            this.ngay_sinh = ngay_sinh;
            this.so_dien_thoai = so_dien_thoai;
            this.email = email;
            this.created_at = created_at;
        }

        public ThiSinhBUS() { }

        public int MaThiSinh
        {
            get { return this.ma_thi_sinh; }
            set { this.ma_thi_sinh = value; }
        }
        public string HoTen
        {
            get { return this.ho_ten; }
            set { this.ho_ten = value; }
        }
        public string SoDienThoai
        {
            get { return this.so_dien_thoai; }
            set { this.so_dien_thoai = value; }
        }
        public string Email
        {
            get { return this.email; }
            set { this.email = value; }
        }
        public DateOnly NgaySinh
        {
            get { return this.ngay_sinh; }
            set { this.ngay_sinh = value; }
        }

        public DateTime CreatedAt
        {
            get { return this.created_at; }
            set { this.created_at = value; }
        }

        #endregion

        #region DAO    
        private ThiSinhDAO thiSinhDAO = new ThiSinhDAO();
        #endregion

        public DataTable dtbGetAllThiSinh()
        {
            return thiSinhDAO.getAllThiSinh();
        }

       public int addThiSinh(string HoTen, DateOnly NgaySinh, string SoDienThoai, string Email, DateTime CreatedAt)
        {
            return thiSinhDAO.addThiSinh(HoTen, NgaySinh, SoDienThoai, Email, CreatedAt);
        }

        public void updateThiSinh(int MaThiSinh, string HoTen, DateOnly NgaySinh, string SoDienThoai, string Email)
        {
            thiSinhDAO.updateThiSinh(MaThiSinh, HoTen, NgaySinh, SoDienThoai, Email);
        }
        
        public DataTable searchThiSinh(string searchTerm)
        {
            return thiSinhDAO.searchThiSinh(searchTerm);
        }

        public DataRow getThiSinhByMaThiSinh(int maThiSinh)
        {
            return thiSinhDAO.getThiSinhById(maThiSinh);

        }

    }
}
