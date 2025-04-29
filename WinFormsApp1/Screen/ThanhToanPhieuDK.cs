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

namespace WinFormsApp1
{
    public partial class ThanhToanPhieuDK : UserControl
    {
        private PhieuDangKyBUS phieuDangKyBUS = new PhieuDangKyBUS();
        private NguoiDangKyBUS nguoiDangKyBUS = new NguoiDangKyBUS();
        private DataGridViewRow phieuDangKy;

        public ThanhToanPhieuDK()
        {
            MH_ThanhToanPhieuDK_Load();
        }

        public DataTable DgvDSPhieuDK_Load()
        {
            DataTable DsPhieuDK = phieuDangKyBUS.LayDSPhieuDKChuaThanhToan();
            DataTable dgvDSPhieuDK = new DataTable();
            dgvDSPhieuDK.Columns.Add("ma_phieu_dk");
            dgvDSPhieuDK.Columns.Add("ngay_dk");
            dgvDSPhieuDK.Columns.Add("tong_tien");
            dgvDSPhieuDK.Columns.Add("ho_ten");
            dgvDSPhieuDK.Columns.Add("sdt");
            dgvDSPhieuDK.Columns.Add("email");
            dgvDSPhieuDK.Columns.Add("loai_dk");
            dgvDSPhieuDK.Columns.Add("ma_thanh_toan");

            foreach (DataRow row in DsPhieuDK.Rows)
            {
                DataRow nguoiDangKy = nguoiDangKyBUS.getTTNguoiDangKyByMaNguoiDangKy(row["ma_nguoi_dang_ky"].ToString());
                string loaiDangKy = nguoiDangKy["don_vi"].ToString() != "" ? "Đơn vị" : "Cá nhân";
                string maThanhToan = row["ma_thanh_toan"].ToString();
                dgvDSPhieuDK.Rows.Add(row["ma_phieu_dang_ky"].ToString(), row["ngay_dang_ky"].ToString(), row["tong_tien"].ToString(), nguoiDangKy["ho_ten"].ToString(), nguoiDangKy["so_dien_thoai"].ToString(), nguoiDangKy["email"].ToString(), loaiDangKy, maThanhToan);

            }
            Debug.WriteLine(dgvDSPhieuDK.Rows.Count);
            return dgvDSPhieuDK;
        }

        private void MH_ThanhToanPhieuDK_Load()
        {
            InitializeComponent();
            DataTable dt = DgvDSPhieuDK_Load();

            // Add Columns
            dgvDSPhieuDK.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Mã phiếu", DataPropertyName = "ma_phieu_dk" });
            dgvDSPhieuDK.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Ngày đăng ký", DataPropertyName = "ngay_dk" , Width = 150});
            dgvDSPhieuDK.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Tổng tiền", DataPropertyName = "tong_tien" });
            dgvDSPhieuDK.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Tên người đăng ký", DataPropertyName = "ho_ten" , Width = 140});
            dgvDSPhieuDK.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "SĐT", DataPropertyName = "sdt" });
            dgvDSPhieuDK.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Email", DataPropertyName = "email" });
            dgvDSPhieuDK.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Loại đăng ký", DataPropertyName = "loai_dk" });
            dgvDSPhieuDK.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Mã thanh toán", DataPropertyName = "ma_thanh_toan" });

            dgvDSPhieuDK.DataSource = dt;
        }

        private void btnThanhToan_Click(object sender, EventArgs e)
        {
            if (phieuDangKy == null)
            {
                MessageBox.Show("Vui lòng chọn phiếu đăng ký để thanh toán.");
                return;
            }
            ChiTietPhieuDangKy chiTietPhieuDK = new ChiTietPhieuDangKy(phieuDangKy);
            
            // Store reference to this control in the new control
            chiTietPhieuDK.PreviousControl = this;
            
            // Hide the current control
            this.Hide();
            
            // Add to parent container
            this.Parent.Controls.Add(chiTietPhieuDK);
            chiTietPhieuDK.Dock = DockStyle.Fill;
        }

        private void btnKiemTra_Click(object sender, EventArgs e)
        {
            string keyword = txtboxTimKiem.Text.Trim();
            dgvDSPhieuDK.DataSource = DgvDSPhieuDK_TimKiem(keyword);
            dgvDSPhieuDK.Refresh();
            dgvDSPhieuDK.Update();
        }

        private DataTable DgvDSPhieuDK_TimKiem(string keyword)
        {
            DataTable DsPhieuDK = DgvDSPhieuDK_Load();
            DsPhieuDK.DefaultView.RowFilter = string.Format("sdt LIKE '%{0}%' OR ma_phieu_dk LIKE '%{0}%'", keyword);
            return DsPhieuDK.DefaultView.ToTable();
        }

        private void dgvDSPhieuDK_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < dgvDSPhieuDK.Rows.Count)
            {
                var cellValue = dgvDSPhieuDK.Rows[e.RowIndex].Cells[0].Value;
                if (cellValue != null)
                {
                    phieuDangKy = dgvDSPhieuDK.Rows[e.RowIndex];
                }
            }
        }
    }
}
