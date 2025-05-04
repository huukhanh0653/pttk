using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WinFormsApp1.DAO;

namespace WinFormsApp1.Business
{
    internal class ChungChiThiSinhBUS
    {
        ChungChiThiSinhDAO chungChiThiSinhDAO = new ChungChiThiSinhDAO();
        ThiSinhDAO ThiSinhDAO = new ThiSinhDAO();

        public ChungChiThiSinhBUS() { }

        public DataTable getAllChungChiThiSinh()
        {
            DataTable chungchi = chungChiThiSinhDAO.getAllChungChiThiSinh();
            DataTable thisinhs = ThiSinhDAO.getAllThiSinh();

            // Ensure "ma_thi_sinh" column exists in both tables
            if (!chungchi.Columns.Contains("ma_thi_sinh") || !thisinhs.Columns.Contains("ma_thi_sinh"))
            {
                throw new InvalidOperationException("The required column 'ma_thi_sinh' is missing in one of the tables.");
            }

            // Add additional columns to the cloned DataTable
            DataTable joined = chungchi.Clone();
            joined.Columns.Add("ho_ten");
            joined.Columns.Add("ngay_sinh");
            joined.Columns.Add("so_dien_thoai");
            joined.Columns.Add("email");

            // Create a dictionary for quick lookup of ThiSinh rows by "ma_thi_sinh"
            var thiSinhLookup = thisinhs.AsEnumerable()
                .ToDictionary(row => row["ma_thi_sinh"].ToString(), row => row);

            // Perform the join operation
            foreach (DataRow chungchiRow in chungchi.Rows)
            {
                DataRow joinedRow = joined.NewRow();
                joinedRow.ItemArray = chungchiRow.ItemArray;

                string maThiSinh = chungchiRow["ma_thi_sinh"]?.ToString();
                if (!string.IsNullOrEmpty(maThiSinh) && thiSinhLookup.TryGetValue(maThiSinh, out DataRow thisinhRow))
                {
                    joinedRow["ho_ten"] = thisinhRow["ho_ten"];
                    joinedRow["ngay_sinh"] = thisinhRow["ngay_sinh"];
                    joinedRow["so_dien_thoai"] = thisinhRow["so_dien_thoai"];
                    joinedRow["email"] = thisinhRow["email"];
                }

                joined.Rows.Add(joinedRow);
            }

            return joined;
        }

        public DataTable searchChungChiThiSinh(string searchText)
        {
            DataTable Allchungchi = chungChiThiSinhDAO.getAllChungChiThiSinh();
            DataTable Allthisinhs = ThiSinhDAO.getAllThiSinh();

            DataTable searchChungChi = chungChiThiSinhDAO.searchChungChiThiSinh(searchText);
            DataTable searchThiSinh = ThiSinhDAO.searchThiSinh(searchText);

            // Ensure "ma_thi_sinh" column exists in both tables
            if (!Allchungchi.Columns.Contains("ma_thi_sinh") || !Allthisinhs.Columns.Contains("ma_thi_sinh"))
            {
                throw new InvalidOperationException("The required column 'ma_thi_sinh' is missing in one of the tables.");
            }

            // Add additional columns to the cloned DataTable
            DataTable joined = Allchungchi.Clone();
            joined.Columns.Add("ho_ten");
            joined.Columns.Add("ngay_sinh");
            joined.Columns.Add("so_dien_thoai");
            joined.Columns.Add("email");
            joined.Rows.Clear();

            // Create a dictionary for quick lookup of ThiSinh rows by "ma_thi_sinh"
            var thiSinhLookup = Allthisinhs.AsEnumerable()
                .ToDictionary(row => row["ma_thi_sinh"].ToString(), row => row);
            // Perform the join operation
            foreach (DataRow chungchiRow in Allchungchi.Rows)
            {
                DataRow joinedRow = joined.NewRow();
                joinedRow.ItemArray = chungchiRow.ItemArray;
                string maThiSinh = chungchiRow["ma_thi_sinh"]?.ToString();
                if (!string.IsNullOrEmpty(maThiSinh) && thiSinhLookup.TryGetValue(maThiSinh, out DataRow thisinhRow))
                {
                    joinedRow["ho_ten"] = thisinhRow["ho_ten"];
                    joinedRow["ngay_sinh"] = thisinhRow["ngay_sinh"];
                    joinedRow["so_dien_thoai"] = thisinhRow["so_dien_thoai"];
                    joinedRow["email"] = thisinhRow["email"];
                }
                if (joinedRow.ItemArray.Any(item => item.ToString().Contains(searchText)))
                {
                    joined.Rows.Add(joinedRow);
                }
            }
            return joined;
        }

        public void capPhatChungChi(string maChungChi, string maThiSinh, string ngayCap)
        {
            chungChiThiSinhDAO.capPhatChungChi(Convert.ToInt32(maChungChi), Convert.ToInt32(maThiSinh), DateOnly.Parse(ngayCap.Split(' ')[0]));
        }
    }
}
