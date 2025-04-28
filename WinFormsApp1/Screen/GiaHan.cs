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
    public partial class GiaHan : UserControl
    {
        private string selectedCustomerId = string.Empty;
        private string selectedExamSchedule = string.Empty;
        private bool chkTruongHopDBChecked = false;
        private ThiSinhBUS thiSinhBUS = new ThiSinhBUS();
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

                    LoadDSPhieuDuThiCuaThiSinh(selectedCustomerId);

                    dgvDSPhieuDuThi.Visible = true;
                    btnKTPhieuDuThiHopLe.Visible = true;

                    HideAllUIElements();
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

        private void LoadDSPhieuDuThiCuaThiSinh(string customerId)
        {
            //string query = "SELECT * FROM PHIEU_DU_THI WHERE ma_thi_sinh = :customerId";
            //var parameters = new Dictionary<string, object>
            //{
            //    { "customerId", customerId }
            //};

            //DataTable examTable = ExecuteCommand(query, CommandType.Text, parameters);

            //if (examTable.Rows.Count > 0)
            //{
            //    dgvDSPhieuDuThi.DataSource = examTable;
            //}
            //else
            //{
            //    dgvDSPhieuDuThi.DataSource = null;
            //    MessageBox.Show("Không có phiếu dự thi cho thí sinh này.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            //}
        }



        private void dgvDSPhieuDuThi_SelectionChanged(object? sender, EventArgs e)
        {
            HideAllUIElements();
        }

        private void HideAllUIElements()
        {
            txtLyDo.Visible = false;
            chkTruongHopDB.Visible = false;
            btnCungCapLichThi.Visible = false;
            lblLichThiDaChon.Visible = false;
            btnXoaLichThiDaChon.Visible = false;
            btnThanhToan.Visible = false;
            btnLuuThongTin.Visible = false;
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

            return true;
        }

        private void btnCungCapLichThi_Click(object sender, EventArgs e)
        {
            //// Open the MHCungCapLichThi form
            //using (var MHCungCapLichThi = new MHCungCapLichThi())
            //{
            //    if (MHCungCapLichThi.ShowDialog() == DialogResult.OK)
            //    {
            //        // Get the selected exam schedule from the other form
            //        selectedExamSchedule = MHCungCapLichThi.LuaChonLichThi();

            //        // Display the selected schedule below the text input
            //        lblLichThiDaChon.Text = $"Lịch thi đã chọn: {selectedExamSchedule}";
            //        lblLichThiDaChon.Visible = true;

            //        // Show the "Xóa Lịch Thi" and "Thanh toán" buttons
            //        btnXoaLichThiDaChon.Visible = true;
            //        if (!chkTruongHopDBChecked)
            //        {
            //            btnThanhToan.Visible = true;
            //        }
            //        btnLuuThongTin.Visible = true;

            //        // Disable both tables
            //        dgvDSThiSinh.Enabled = false;
            //        dgvDSPhieuDuThi.Enabled = false;
            //    }
            //}
        }

        private void btnXoaLichThiDaChon_Click(object sender, EventArgs e)
        {
            //// Clear the selected schedule
            //selectedExamSchedule = string.Empty;
            //lblLichThiDaChon.Text = "Lịch thi đã chọn:";
            //lblLichThiDaChon.Visible = false;

            //// Hide related buttons
            //btnXoaLichThiDaChon.Visible = false;
            //btnThanhToan.Visible = false;
            //btnLuuThongTin.Visible = false;

            //// Re-enable both tables
            //dgvDSThiSinh.Enabled = true;
            //dgvDSPhieuDuThi.Enabled = true;
        }

        private void btnThanhToan_Click(object sender, EventArgs e)
        {
            // Show the "Gia Hạn" button
            btnLuuThongTin.Visible = true;
        }

        private void btnLuuThongTin_Click(object sender, EventArgs e)
        {
            //// Show success message
            //MessageBox.Show("lưu thông tin thành công!");

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

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        //private DataTable ExecuteCommand(string commandText, CommandType commandType, Dictionary<string, object>? parameters = null)
        //{
        //    //string connectionString = "User Id=ADMIN;Password=122712;Data Source=localhost:1521/PDB;";
        //    //DataTable resultTable = new DataTable();

        //    //try
        //    //{
        //    //    using (OracleConnection connection = new OracleConnection(connectionString))
        //    //    {
        //    //        connection.Open();
        //    //        using (OracleCommand command = new OracleCommand(commandText, connection))
        //    //        {
        //    //            command.CommandType = commandType;

        //    //            // Nếu có tham số, thêm chúng vào command
        //    //            if (parameters != null)
        //    //            {
        //    //                foreach (var param in parameters)
        //    //                {
        //    //                    command.Parameters.Add(new OracleParameter(param.Key, param.Value));
        //    //                }
        //    //            }

        //    //            using (OracleDataAdapter adapter = new OracleDataAdapter(command))
        //    //            {
        //    //                adapter.Fill(resultTable);
        //    //            }
        //    //        }
        //    //    }
        //    //}
        //    //catch (Exception ex)
        //    //{
        //    //    MessageBox.Show($"Error executing command: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //    //}

        //    //return resultTable;
        //}
    }
}
