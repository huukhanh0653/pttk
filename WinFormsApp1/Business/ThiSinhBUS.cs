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

        public List<ThiSinhBUS> getAllThiSinh()
        {
            DataTable dataTable = thiSinhDAO.getAllThiSinh();
            List<ThiSinhBUS> thiSinhs = new List<ThiSinhBUS>();
            if (dataTable.Rows.Count > 0)
            {
                foreach (DataRow row in dataTable.Rows)
                {
                    thiSinhs.Add(
                        new ThiSinhBUS(
                        Convert.ToInt32(row["ma_thi_sinh"]),
                        row["ho_ten"].ToString(),
                        DateOnly.Parse(row["ngay_sinh"].ToString()),
                        row["so_dien_thoai"].ToString(),
                        row["email"].ToString(),
                        Convert.ToDateTime(row["created_at"]))
                        {
                            MaThiSinh = Convert.ToInt32(row["ma_thi_sinh"]),
                            HoTen = row["ho_ten"].ToString(),
                            SoDienThoai = row["so_dien_thoai"].ToString(),
                            NgaySinh = DateOnly.Parse(row["ngay_sinh"].ToString()),
                            CreatedAt = Convert.ToDateTime(row["created_at"])
                        });
                }
            }

            return thiSinhs;
        }

        public DataTable dtbGetAllThiSinh()
        {
            return thiSinhDAO.getAllThiSinh();
        }

        public void addThiSinh()
        {
            thiSinhDAO.addThiSinh(this.ma_thi_sinh,
                this.ho_ten,
                this.ngay_sinh,
                this.so_dien_thoai,
                this.email,
                this.created_at
                );
        }

<<<<<<< HEAD
        public DataRow getThiSinhByMaThiSinh(int maThiSinh)
        {
            return thiSinhDAO.getThiSinhById(maThiSinh);
=======
        public DataTable searchThiSinh(string searchText)
        {
            return thiSinhDAO.searchThiSinh(searchText);
>>>>>>> b6ce5cd9de5ef299fdb5c8d9d519880bebd892a8
        }
    }
}
