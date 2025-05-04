using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinFormsApp1.Business;

namespace WinFormsApp1.Screen
{
    public partial class CapPhatChungChi : UserControl
    {
        private ChungChiThiSinhBUS chungChiThiSinhBUS = new ChungChiThiSinhBUS();
        private DataRow selectedRow = null;
        public CapPhatChungChi()
        {
            InitializeComponent();
            LoadDSThiSinh();
        }

        private void LoadDSThiSinh()
        {
            //this.dgvDSChungChi.Rows.Clear();

            this.dgvDSChungChi.DataSource = chungChiThiSinhBUS.getAllChungChiThiSinh();
            this.dgvDSChungChi.Columns["ma_thi_sinh"].HeaderText = "Mã thí sinh";
            this.dgvDSChungChi.Columns["ma_chung_chi"].HeaderText = "Mã chứng chỉ";
            this.dgvDSChungChi.Columns["ngay_cap"].HeaderText = "Ngày cấp";
            this.dgvDSChungChi.Columns["ngay_het_han"].HeaderText = "Ngày hết hạn";
            this.dgvDSChungChi.Columns["da_cap_phat"].HeaderText = "Đã cấp phát";
            this.dgvDSChungChi.Columns["ngay_cap"].HeaderText = "Ngày cấp";
            this.dgvDSChungChi.Columns["ho_ten"].HeaderText = "Họ tên";
            this.dgvDSChungChi.Columns["ngay_sinh"].HeaderText = "Ngày sinh";
            this.dgvDSChungChi.Columns["ngay_sinh"].DefaultCellStyle.Format = "dd/MM/yyyy";
            this.dgvDSChungChi.Columns["so_dien_thoai"].HeaderText = "Số điện thoại";
            this.dgvDSChungChi.Columns["email"].HeaderText = "Email";
            this.dgvDSChungChi.Columns["ho_ten"].Width = 150;
            this.dgvDSChungChi.Columns["ngay_sinh"].Width = 100;
            this.dgvDSChungChi.Columns["so_dien_thoai"].Width = 100;
            this.dgvDSChungChi.Columns["email"].Width = 250;
            this.dgvDSChungChi.Columns["ngay_cap"].Width = 100;
            this.dgvDSChungChi.Columns["ma_thi_sinh"].Width = 100;
        }

        private void dgvDSChungChi_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var dataRowView = this.dgvDSChungChi.Rows[e.RowIndex].DataBoundItem as DataRowView;
            if (dataRowView != null)
            {
                var selectedRow = dataRowView.Row;
                Debug.WriteLine("Selected Row: " + selectedRow["ma_thi_sinh"].ToString());
            }
        }

        private void dgvDSChungChi_CellClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex >= 0 && this.dgvDSChungChi.Rows[e.RowIndex].DataBoundItem is DataRowView dataRowView)
            {
                this.selectedRow = dataRowView.Row;
                Debug.WriteLine("Selected Row: " + selectedRow["ma_thi_sinh"].ToString());
            }
            else
            {
                Debug.WriteLine("No valid row selected.");
            }
        }

        private void txtSearchChungChi_TextChanged(object sender, EventArgs e)
        {
            this.dgvDSChungChi.DataSource = chungChiThiSinhBUS.searchChungChiThiSinh(txtSearchChungChi.Text);
            this.dgvDSChungChi.Columns["ma_thi_sinh"].HeaderText = "Mã thí sinh";
            this.dgvDSChungChi.Columns["ma_chung_chi"].HeaderText = "Mã chứng chỉ";
            this.dgvDSChungChi.Columns["ngay_cap"].HeaderText = "Ngày cấp";
            this.dgvDSChungChi.Columns["ho_ten"].HeaderText = "Họ tên";
            this.dgvDSChungChi.Columns["ngay_sinh"].HeaderText = "Ngày sinh";
            this.dgvDSChungChi.Columns["ngay_sinh"].DefaultCellStyle.Format = "dd/MM/yyyy"; 
            this.dgvDSChungChi.Columns["so_dien_thoai"].HeaderText = "Số điện thoại";
            this.dgvDSChungChi.Columns["email"].HeaderText = "Email";
            this.dgvDSChungChi.Columns["ho_ten"].Width = 150;
            this.dgvDSChungChi.Columns["ngay_sinh"].Width = 100;
            this.dgvDSChungChi.Columns["so_dien_thoai"].Width = 150;
            this.dgvDSChungChi.Columns["email"].Width = 170;
            this.dgvDSChungChi.Columns["ngay_cap"].Width = 100;
            this.dgvDSChungChi.Columns["ma_thi_sinh"].Width = 100;
        }

        private void btnCapPhatChungChi_Click(object sender, EventArgs e)
        {
            chungChiThiSinhBUS.capPhatChungChi(selectedRow["ma_chung_chi"].ToString(), selectedRow["ma_thi_sinh"].ToString(), selectedRow["ngay_cap"].ToString());
            MessageBox.Show("Cập nhật thành công");
            LoadDSThiSinh();
        }
    }
}
