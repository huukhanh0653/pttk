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
        public partial class CungCapLichThi : UserControl
        {
            private DataTable table;
            private DataTable originaltable;
            private string maChungChi;
            private string SelectedExamSchedule = string.Empty;
            private string SelectedMaKyThiMoi = string.Empty;

            public event EventHandler<string> DataSelected;
            private KyThiBUS kyThiBUS = new KyThiBUS();


        public CungCapLichThi(string maChungChi)
            {
                InitializeComponent();
                this.maChungChi = maChungChi;
                SelectedExamSchedule = string.Empty;
                LoadExamData();
                InitializeFilterOptions();
            }

            private void LoadExamData()
            {
                table = kyThiBUS.getKyThiByMaChungChiLater(maChungChi);
            // Sample data for exams
            table.Columns["ma_ky_thi"].ColumnName = "Mã Kỳ Thi";
                table.Columns["ma_chung_chi"].ColumnName = "Mã Chứng Chỉ";
                table.Columns["so_phong"].ColumnName = "Số Phòng";
                table.Columns["dia_diem"].ColumnName = "Địa Điểm";
                table.Columns["ten_ky_thi"].ColumnName = "Tên Kỳ Thi";
                table.Columns["mo_ta"].ColumnName = "Mô Tả";
                table.Columns["thoi_gian_bat_dau"].ColumnName = "Thời Gian Bắt Đầu";
                table.Columns["thoi_luong_thi"].ColumnName = "Thời Lượng Thi";
                table.Columns["so_luong_dang_ky_hien_tai"].ColumnName = "Số Lượng Đăng Ký Hiện Tại";
                table.Columns["so_luong_toi_da"].ColumnName = "Số Lượng Tối Đa";

                originaltable = table.Copy();
                dgvDSLichThi.DataSource = table;
            }

            private void InitializeFilterOptions()
            {
                cmbFilter.Items.Add("Tất cả");
                var uniqueLocations = table.AsEnumerable()
                    .Select(row => row.Field<string>("Địa Điểm"))
                    .Distinct()
                    .ToList();
                foreach (var location in uniqueLocations)
                {
                    if (location != null)
                    {
                        cmbFilter.Items.Add(location);
                    }
                }
                cmbFilter.SelectedIndex = 0;
            }

            private void txtSearch_TextChanged(object sender, EventArgs e)
            {
                ApplyFilters();
            }

            private void cmbFilter_SelectedIndexChanged(object sender, EventArgs e)
            {
                ApplyFilters();
            }

            private void btnFilterByTime_Click(object sender, EventArgs e)
            {
                // Filter by time logic
                string inputTime = Microsoft.VisualBasic.Interaction.InputBox(
                    "Nhập thời gian bắt đầu (yyyy-MM-dd):",
                    "Lọc theo thời gian",
                    DateTime.Now.ToString("yyyy-MM-dd"));

                if (DateTime.TryParse(inputTime, out DateTime filterTime))
                {
                    var filteredRows = table.AsEnumerable().Where(row =>
                        DateTime.TryParse(row.Field<string>("Thời Gian Bắt Đầu"), out DateTime examTime) &&
                        examTime.Date == filterTime.Date);

                    if (filteredRows.Any())
                    {
                        dgvDSLichThi.DataSource = filteredRows.CopyToDataTable();
                    }
                    else
                    {
                        dgvDSLichThi.DataSource = table.Clone(); // Show empty table if no match
                    }
                }
                else
                {
                    MessageBox.Show("Thời gian không hợp lệ. Vui lòng nhập đúng định dạng (yyyy-MM-dd).", "Thông báo");
                }
            }

            private void dtpFilterByTime_ValueChanged(object sender, EventArgs e)
            {
                var selectedTime = dtpFilterByTime.Value;

                // Filter the DataGridView based on the selected time
                var filteredRows = originaltable.AsEnumerable()
                    .Where(row => DateTime.Parse(row.Field<string>("Thời Gian Bắt Đầu") + "") >= selectedTime);

                if (filteredRows.Any())
                {
                    dgvDSLichThi.DataSource = filteredRows.CopyToDataTable();
                }
                else
                {
                    dgvDSLichThi.DataSource = originaltable.Clone(); // Show an empty table if no match
                }
            }

            private void nudHourSelector_ValueChanged(object sender, EventArgs e)
            {
                int selectedHour = (int)nudHourSelector.Value;

                var filteredRows = originaltable.AsEnumerable()
                    .Where(row => DateTime.TryParse(row.Field<string>("Thời Gian Bắt Đầu"), out DateTime examTime) &&
                                  examTime.Hour == selectedHour);

                if (filteredRows.Any())
                {
                    dgvDSLichThi.DataSource = filteredRows.CopyToDataTable();
                }
                else
                {
                    dgvDSLichThi.DataSource = originaltable.Clone(); // Show an empty table if no match
                }
            }

            private void ApplyFilters()
            {
                string searchText = txtSearch.Text.ToLower();
                string filterLocation = cmbFilter.SelectedItem?.ToString() ?? "Tất cả";

                var filteredRows = table.AsEnumerable().Where(row =>
                    (filterLocation == "Tất cả" || row.Field<string>("Địa Điểm") == filterLocation) &&
                    ((row.Field<string>("Tên Kỳ Thi")?.ToLower() ?? string.Empty).Contains(searchText) ||
                     (row.Field<string>("Mã Kỳ Thi")?.ToLower() ?? string.Empty).Contains(searchText) ||
                     (row.Field<string>("Mô Tả")?.ToLower() ?? string.Empty).Contains(searchText) ||
                     (row.Field<string>("Địa Điểm")?.ToLower() ?? string.Empty).Contains(searchText) ||
                     (row.Field<string>("Số Phòng")?.ToLower() ?? string.Empty).Contains(searchText) ||
                     (row.Field<string>("Mã Chứng Chỉ")?.ToLower() ?? string.Empty).Contains(searchText) ||
                     (row.Field<string>("Tên Chứng Chỉ")?.ToLower() ?? string.Empty).Contains(searchText) ||
                     (row.Field<string>("Thời Gian Bắt Đầu")?.ToLower() ?? string.Empty).Contains(searchText) ||
                     (row.Field<string>("Số lượng")?.ToLower() ?? string.Empty).Contains(searchText)));
                if (filteredRows.Any())
                {
                    dgvDSLichThi.DataSource = filteredRows.CopyToDataTable();
                }
                else
                {
                    dgvDSLichThi.DataSource = table.Clone(); // Show empty table if no match
                }
            }

            private void btnChonLichThi_Click(object sender, EventArgs e)
            {
                // Get the selected row from the DataGridView
                if (dgvDSLichThi.SelectedRows.Count > 0)
                {
                    var selectedRow = dgvDSLichThi.SelectedRows[0];
                    
                    SelectedExamSchedule = selectedRow.Cells["Mã Kỳ Thi"].Value.ToString() + " - " +
                                           selectedRow.Cells["Tên Kỳ Thi"].Value.ToString() + " - " +
                                           //selectedRow.Cells["Mô Tả"].Value.ToString() + " - " +
                                           selectedRow.Cells["Địa Điểm"].Value.ToString() + " - " +
                                           selectedRow.Cells["Số Phòng"].Value.ToString() + " - " +
                                           selectedRow.Cells["Mã Chứng Chỉ"].Value.ToString() + " - " +
                                           selectedRow.Cells["Thời Lượng Thi"].Value.ToString() + " - " +
                                           selectedRow.Cells["Thời Gian Bắt Đầu"].Value.ToString() + " - " +
                                           selectedRow.Cells["Số Lượng Tối Đa"].Value.ToString();
                Debug.WriteLine(SelectedExamSchedule);
                   DataSelected?.Invoke(this, SelectedExamSchedule);

                // Close the form and return OK result
                //this.DialogResult = DialogResult.OK;
                //this.Close();
            }
                else
                {
                    MessageBox.Show("Vui lòng chọn một lịch thi.", "Thông báo");
                }
            }

            private void dgvDSLichThi_CellContentClick(object sender, DataGridViewCellEventArgs e)
            {

            }
        }

}
