using Microsoft.IdentityModel.Tokens;
using System.Diagnostics;

using WinFormsApp1.Business;

namespace WinFormsApp1
{
    public partial class GiaHan : UserControl
    {
        private string selectedCustomerId = string.Empty;
        private string selectedExamSchedule = string.Empty;
        private bool chkTruongHopDBChecked = false;
        private string lyDo = string.Empty;
        private string selectedMaPhieuDuThi = string.Empty;
        private string selectedMaKyThi = string.Empty;
        private string selectedThoiGianBatDau = string.Empty;
        private string selectedMaKyThiMoi = string.Empty;
        private string selectedMaChungChi = string.Empty;

        private ThiSinhBUS thiSinhBUS = new ThiSinhBUS();
        private PhieuDuThiBUS phieuDuThiBUS = new PhieuDuThiBUS();
        private PhieuGiaHanBUS phieuGiaHanBUS = new PhieuGiaHanBUS();

        public GiaHan()
        {
            InitializeComponent();
            InitializeUI();
            LoadDSThiSinh();
        }

        private void InitializeUI()
        {
            // Disable controls initially
            txtLyDo.Enabled = false;
            chkTruongHopDB.Enabled = false;
            btnCungCapLichThi.Enabled = false;
            btnLuuThongTin.Enabled = false;
            btnXoaLichThiDaChon.Enabled = false;
            lblLichThiDaChon.Visible = false;
            dgvDSPhieuDuThi.Visible = false;
            btnKTPhieuDuThiHopLe.Visible = false;
        }

        private void ResetUI()
        {
            // Reset UI to initial state
            selectedCustomerId = string.Empty;
            selectedExamSchedule = string.Empty;
            chkTruongHopDBChecked = false;
            lyDo = string.Empty;
            selectedMaPhieuDuThi = string.Empty;
            selectedMaKyThi = string.Empty;
            selectedThoiGianBatDau = string.Empty;
            selectedMaKyThiMoi = string.Empty;
            selectedMaChungChi = string.Empty;

            txtLyDo.Text = string.Empty;
            chkTruongHopDB.Checked = false;
            lblLichThiDaChon.Text = "Lịch thi đã chọn:";
            txtLyDo.Enabled = false;
            chkTruongHopDB.Enabled = false;
            btnCungCapLichThi.Enabled = false;
            btnLuuThongTin.Enabled = false;
            btnXoaLichThiDaChon.Enabled = false;
            lblLichThiDaChon.Visible = false;
            dgvDSPhieuDuThi.Visible = false;
            btnKTPhieuDuThiHopLe.Visible = false;
            dgvDSThiSinh.Enabled = true;
            dgvDSPhieuDuThi.Enabled = true;
        }

        private void LoadDSThiSinh()
        {
            this.dgvDSThiSinh.Rows.Clear();
            this.dgvDSThiSinh.DataSource = thiSinhBUS.dtbGetAllThiSinh();
        }

        private void dgvDSThiSinh_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvDSThiSinh.SelectedRows.Count > 0)
            {
                var newSelectedCustomerId = dgvDSThiSinh.SelectedRows[0].Cells["ma_thi_sinh"].Value.ToString();

                if (newSelectedCustomerId != selectedCustomerId)
                {
                    selectedCustomerId = newSelectedCustomerId ?? string.Empty;

                    this.dgvDSPhieuDuThi.DataSource = phieuDuThiBUS.dtbGetPhieuDuThiByMaThiSinh(selectedCustomerId);

                    dgvDSPhieuDuThi.Visible = true;
                    btnKTPhieuDuThiHopLe.Visible = true;
                }
            }
            else
            {
                selectedCustomerId = string.Empty;
                dgvDSPhieuDuThi.Visible = false;
                btnKTPhieuDuThiHopLe.Visible = false;
            }
        }

        private void dgvDSPhieuDuThi_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvDSPhieuDuThi.SelectedRows.Count == 0)
            {
                return;
            }

            selectedMaPhieuDuThi = this.dgvDSPhieuDuThi.SelectedRows[0].Cells["ma_phieu_du_thi"].Value.ToString();
            selectedMaKyThi = this.dgvDSPhieuDuThi.SelectedRows[0].Cells["ma_ky_thi"].Value.ToString();
            selectedMaChungChi = this.dgvDSPhieuDuThi.SelectedRows[0].Cells["ma_chung_chi"].Value.ToString();

            Debug.WriteLine("Selected Ma Phieu Du Thi: " + selectedMaPhieuDuThi);
            Debug.WriteLine("Selected Ma Ky Thi: " + selectedMaKyThi);
            Debug.WriteLine("Selected Ma Chung Chi: " + selectedMaChungChi);
            Debug.WriteLine("Selected Ma Ky Thi Moi: " + selectedMaKyThiMoi);
        }

        private void btnKTPhieuDuThiHopLe_Click(object sender, EventArgs e)
        {
            if (dgvDSPhieuDuThi.SelectedRows.Count > 0)
            {
                if (selectedMaPhieuDuThi.IsNullOrEmpty() || selectedMaKyThi.IsNullOrEmpty())
                {
                    MessageBox.Show("Hãy lựa chọn một kỳ thi, một phiếu dự thi bất kỳ!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                KyThiBUS kyThiBUS = new KyThiBUS(selectedMaKyThi);
                bool isTimeValid = kyThiBUS.isEarlyAtLeast24h();
                bool canExtend = phieuGiaHanBUS.is2TimesAlready(selectedMaPhieuDuThi);

                if (isTimeValid && canExtend)
                {
                    MessageBox.Show("Kiểm tra gia hạn thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtLyDo.Enabled = true;
                    chkTruongHopDB.Enabled = true;
                    btnCungCapLichThi.Enabled = true;
                }
                else
                {
                    MessageBox.Show("Kiểm tra gia hạn thất bại. Kỳ thi quá gần hoặc đã gia hạn 2 lần.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn một phiếu dự thi trước.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnCungCapLichThi_Click(object sender, EventArgs e)
        {
            Form popup = new Form();
            popup.Size = new Size(750, 500);
            CungCapLichThi cungCapLichThi = new CungCapLichThi(selectedMaChungChi);

            cungCapLichThi.DataSelected += (s, data) =>
            {
                selectedExamSchedule = data;
                string[] split = data.Split(" - ");
                lblLichThiDaChon.Text = $"Lịch thi đã chọn: {split[0] + " - " + split[1] + " - " + split[2]}";
                selectedMaKyThiMoi = split[0];
                selectedThoiGianBatDau = split[6];
                lblLichThiDaChon.Visible = true;
                btnXoaLichThiDaChon.Enabled = true;
                btnLuuThongTin.Enabled = true;
                dgvDSThiSinh.Enabled = false;
                dgvDSPhieuDuThi.Enabled = false;
                popup.Close();
                MessageBox.Show("Lịch thi đã được chọn: " + data);
            };

            popup.Controls.Add(cungCapLichThi);
            popup.ShowDialog();
        }

        private void btnXoaLichThiDaChon_Click(object sender, EventArgs e)
        {
            selectedExamSchedule = string.Empty;
            selectedMaKyThiMoi = string.Empty;
            selectedThoiGianBatDau = string.Empty;
            lblLichThiDaChon.Text = "Lịch thi đã chọn:";
            lblLichThiDaChon.Visible = false;
            btnXoaLichThiDaChon.Enabled = false;
            btnLuuThongTin.Enabled = false;
            dgvDSThiSinh.Enabled = true;
            dgvDSPhieuDuThi.Enabled = true;
        }

        private void btnLuuThongTin_Click(object sender, EventArgs e)
        {
            phieuGiaHanBUS.addPhieuGiaHan(
                selectedMaPhieuDuThi,
                selectedMaKyThi,
                selectedMaKyThiMoi,
                lyDo,
                selectedThoiGianBatDau,
                DangNhapBUS.Instance.TenDangNhap,
                chkTruongHopDBChecked,
                selectedMaChungChi
            );

            if (chkTruongHopDBChecked)
            {
                phieuDuThiBUS.updateMaKyThi(selectedMaPhieuDuThi, selectedMaKyThiMoi);
            }
            MessageBox.Show("Lưu thông tin gia hạn thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            ResetUI();
        }
        private void chkTruongHopDB_CheckedChanged(object sender, EventArgs e)
        {
            chkTruongHopDBChecked = chkTruongHopDB.Checked;

        }

        private void txtLyDo_TextChanged(object sender, EventArgs e)
        {
            lyDo = txtLyDo.Text;
        }

        private void txtSearch_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                btnSearch_Click(sender, e);
                txtSearch.Clear();
                e.Handled = true;
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string searchText = txtSearch.Text;

            dgvDSThiSinh.DataSource = thiSinhBUS.searchThiSinh(searchText);

        }

        private void back_Click(object sender, EventArgs e)
        {
            MainForm.Instance.SwitchUserControl(new Main());
        }
    }
}