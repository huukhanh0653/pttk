using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinFormsApp1.Business;
namespace WinFormsApp1
{
    public partial class ChiTietPhieuDangKy : UserControl
    {
        private DataGridViewRow phieuDangKy;
        private ChiTietPhieuDKBUS chiTietPhieuDangKyBUS = new ChiTietPhieuDKBUS();
        private ThiSinhBUS thiSinhBUS = new ThiSinhBUS();
        private KyThiBUS kyThiBUS = new KyThiBUS();
        public UserControl PreviousControl { get; set; }

        public ChiTietPhieuDangKy(DataGridViewRow phieuDangKy)
        {
            InitializeComponent();
            this.phieuDangKy = phieuDangKy;
            MH_ChiTietPhieuDangKy_Load();
            this.Dock = DockStyle.Fill;
        }

        public void MH_ChiTietPhieuDangKy_Load()
        {
            txtboxMaPhieuDk.Text = phieuDangKy.Cells[0].Value.ToString();
            txtboxHoTen.Text = phieuDangKy.Cells[3].Value.ToString();
            txtboxSDT.Text = phieuDangKy.Cells[4].Value.ToString();
            txtboxEmail.Text = phieuDangKy.Cells[5].Value.ToString();
            txtboxNgayDK.Text = phieuDangKy.Cells[1].Value.ToString();
            txtboxTongTien.Text = phieuDangKy.Cells[2].Value.ToString();
            txtboxLoaiDK.Text = phieuDangKy.Cells[6].Value.ToString();

            DataTable chiTietPhieuDK = chiTietPhieuDangKyBUS.LayDSChiTietPhieuDK(phieuDangKy.Cells[0].Value.ToString());
            DataTable thiSinh = new DataTable();
            thiSinh.Columns.Add("ho_ten");
            thiSinh.Columns.Add("so_dien_thoai");
            thiSinh.Columns.Add("email");
            thiSinh.Columns.Add("ngay_sinh");
            thiSinh.Columns.Add("ten_ky_thi");
            thiSinh.Columns.Add("ngay_thi");
            thiSinh.Columns.Add("dia_diem");

            foreach (DataRow row in chiTietPhieuDK.Rows)
            {
                DataRow ttThiSinh = thiSinhBUS.getThiSinhByMaThiSinh(int.Parse(row["ma_thi_sinh"].ToString()));
                DataRow kyThi = kyThiBUS.getKyThiByMaKyThi(int.Parse(row["ma_ky_thi"].ToString()));

                thiSinh.Rows.Add(ttThiSinh["ho_ten"].ToString(), ttThiSinh["so_dien_thoai"].ToString(), ttThiSinh["email"].ToString(), ttThiSinh["ngay_sinh"].ToString(), kyThi["ten_ky_thi"].ToString(), kyThi["thoi_gian_bat_dau"].ToString(), kyThi["dia_diem"].ToString());
            }

            dgvThiSinh.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Họ tên", DataPropertyName = "ho_ten", AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill });
            dgvThiSinh.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "SĐT", DataPropertyName = "so_dien_thoai", AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill });
            dgvThiSinh.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Email", DataPropertyName = "email", AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill });
            dgvThiSinh.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Ngày sinh", DataPropertyName = "ngay_sinh", AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill });
            dgvThiSinh.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Tên kỳ thi", DataPropertyName = "ten_ky_thi", AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill });
            dgvThiSinh.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Ngày thi", DataPropertyName = "ngay_thi", AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill });
            dgvThiSinh.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Địa điểm", DataPropertyName = "dia_diem", AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill });

            dgvThiSinh.DataSource = thiSinh;
        }


        private void btnTroVe_Click(object sender, EventArgs e)
        {
            // Show the previous control
            if (PreviousControl != null)
            {
                PreviousControl.Show();
                // Remove this control from parent
                this.Parent.Controls.Remove(this);
            }
        }

        private void btnThanhToan_Click(object sender, EventArgs e)
        {
            // Handle payment continuation
            XacNhanThanhToan xacNhanThanhToan = new XacNhanThanhToan(txtboxMaPhieuDk.Text, "Thanh toán phiếu đăng ký", txtboxTongTien.Text, txtboxLoaiDK.Text, dgvThiSinh.Rows.Count.ToString());
            this.Parent.Controls.Add(xacNhanThanhToan);
            xacNhanThanhToan.PreviousControl = this;
            this.Hide();
            xacNhanThanhToan.Dock = DockStyle.Fill;
        }

    }
}

