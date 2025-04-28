using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
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
            LoadDSThiSinh();
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
                selectedCustomerId = string.Empty; // Reset mã thí sinh
                dgvDSPhieuDuThi.Visible = false; // Ẩn bảng phiếu dự thi
                btnKTPhieuDuThiHopLe.Visible = false; // Ẩn nút kiểm tra gia hạn

                HideAllUIElements();
            }
        }

        private void dgvDSPhieuDuThi_SelectionChanged(object? sender, EventArgs e)
        {
            //HideAllUIElements();
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

        private void HideAllUIElements()
        {
            //txtLyDo.Visible = false;
            //chkTruongHopDB.Visible = false;
            //btnCungCapLichThi.Visible = false;
            //lblLichThiDaChon.Visible = false;
            //btnXoaLichThiDaChon.Visible = false;
            //btnThanhToan.Visible = false;
            //btnLuuThongTin.Visible = false;
        }

        private void btnKTPhieuDuThiHopLe_Click(object sender, EventArgs e)
        {
            if (dgvDSPhieuDuThi.SelectedRows.Count > 0)
            {
                // Simulate a condition to check if the extension is successful
                bool isExtensionSuccessful = KiemTraDieuKienGiaHan();

                if (isExtensionSuccessful)
                {
                    MessageBox.Show("Kiểm tra gia hạn thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // Show input for reason, checkbox, and "Cung cấp lịch thi" button
                    txtLyDo.Visible = true;
                    chkTruongHopDB.Visible = true;
                    btnCungCapLichThi.Visible = true;
                }
                else
                {
                    MessageBox.Show("Kiểm tra gia hạn thất bại. Vui lòng thử lại.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn một phiếu dự thi trước.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private bool KiemTraDieuKienGiaHan()
        {
            if (selectedMaPhieuDuThi.IsNullOrEmpty() || selectedMaKyThi.IsNullOrEmpty() || selectedMaKyThiMoi.IsNullOrEmpty())
            {
                MessageBox.Show("Hãy lựa chọn một kỳ thi, một phiếu dự thi hoặc một lịch thi mới bất kỳ!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return phieuGiaHanBUS.kiemTraDieuKienGiaHan(selectedMaPhieuDuThi, selectedMaKyThi, selectedMaKyThiMoi);
        }

        private void btnCungCapLichThi_Click(object sender, EventArgs e)
        {
            // Open the MHCungCapLichThi form
            Form popup = new Form();
            popup.Size = new Size(750, 500);

            CungCapLichThi cungCapLichThi = new CungCapLichThi(selectedMaChungChi);

            cungCapLichThi.Dock = DockStyle.Fill;

            cungCapLichThi.DataSelected += (s, data) =>
            {
                selectedExamSchedule = data;
                string[] split = data.Split(" - ");
                lblLichThiDaChon.Text = $"Lịch thi đã chọn: {split[0] + " - " + split[1] + " - " + split[2] }";
                selectedMaKyThiMoi = split[0];
                Debug.WriteLine("Selected Ma Ky Thi Moi: " + selectedMaKyThiMoi);
                selectedThoiGianBatDau = split[6];
                lblLichThiDaChon.Visible = true;

                popup.Close();
                MessageBox.Show("Data received: " + data);
            };

            popup.Controls.Add(cungCapLichThi);
            // Display the selected schedule below the text input

             // Show the "Xóa Lịch Thi" and "Thanh toán" buttons
             btnXoaLichThiDaChon.Visible = true;
             if (!chkTruongHopDBChecked)
              {
                 btnThanhToan.Visible = true;
              }
              btnLuuThongTin.Visible = true;

              // Disable both tables
              dgvDSThiSinh.Enabled = false;
              dgvDSPhieuDuThi.Enabled = false;

            popup.ShowDialog();
        }

        private void btnXoaLichThiDaChon_Click(object sender, EventArgs e)
        {
            // Clear the selected schedule
            selectedExamSchedule = string.Empty;
            selectedMaKyThiMoi = string.Empty;
            lblLichThiDaChon.Text = "Lịch thi đã chọn:";

            //// Hide related buttons
            //btnXoaLichThiDaChon.Visible = false;
            btnLuuThongTin.Enabled = false;

            // Re-enable both tables
            dgvDSThiSinh.Enabled = true;
            dgvDSPhieuDuThi.Enabled = true;
        }

        private void btnThanhToan_Click(object sender, EventArgs e)
        {
            // Show the "Gia Hạn" button
            btnLuuThongTin.Visible = true;
        }

        private void btnLuuThongTin_Click(object sender, EventArgs e)
        {

            if (KiemTraDieuKienGiaHan())
            {
                phieuGiaHanBUS.addPhieuGiaHan(selectedMaPhieuDuThi, selectedMaKyThi, 
                selectedMaKyThiMoi, lyDo, selectedThoiGianBatDau, DangNhapBUS.Instance.TenDangNhap, chkTruongHopDBChecked, selectedMaChungChi);
                MessageBox.Show("Lưu thông tin gia hạn thành công!");

            }
            // Show success message
            else
            {
                MessageBox.Show("Không đủ điều kiện gia hạn.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }


            //// Reset visibility to allow re-selection
            //txtLyDo.Visible = false;
            //lblLichThiDaChon.Visible = false;
            //chkTruongHopDB.Visible = false;
            //btnCungCapLichThi.Visible = false;
            //btnXoaLichThiDaChon.Visible = false;
            //btnThanhToan.Visible = false;
            //btnLuuThongTin.Visible = false;

            //// Re-enable both tables for a new selection
            //dgvDSThiSinh.Enabled = true;
            //dgvDSPhieuDuThi.Enabled = true;
        }

        private void chkTruongHopDB_CheckedChanged(object sender, EventArgs e)
        {
            chkTruongHopDBChecked = !chkTruongHopDBChecked;
        }

        private void txtLyDo_TextChanged(object sender, EventArgs e)
        {
            lyDo = txtLyDo.Text;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

  
    }
}
