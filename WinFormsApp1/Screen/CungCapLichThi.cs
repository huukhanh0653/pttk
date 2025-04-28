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
        public partial class CungCapLichThi : UserControl
        {
            private DataTable table;
            //private DataTable originalExamTable;
            private string maChungChi;
            private string SelectedExamSchedule = string.Empty;
            private string SelectedMaKyThiMoi = string.Empty;

            public event EventHandler<string> DataSelected;


            public CungCapLichThi(string maChungChi)
            {
                InitializeComponent();
                this.maChungChi = maChungChi;
                table = new DataTable();
                //originalExamTable = new DataTable();
                SelectedExamSchedule = string.Empty;

                LoadExamData();
                InitializeFilterOptions();
            }

            private void LoadExamData()
            {
                // Sample data for exams
                examTable = new DataTable();
                examTable.Columns.Add("Mã Kỳ Thi");
                examTable.Columns.Add("Tên Kỳ Thi");
                examTable.Columns.Add("Mô Tả");
                examTable.Columns.Add("Địa Điểm");
                examTable.Columns.Add("Số Phòng");
                examTable.Columns.Add("Thời Gian Bắt Đầu");
                examTable.Columns.Add("Mã Chứng Chỉ");
                examTable.Columns.Add("Tên Chứng Chỉ");
                examTable.Columns.Add("Số lượng");

                examTable.Rows.Add("001", "Kỳ Thi A", "Mô tả A", "Hà Nội", "Phòng 101", "2023-10-01 09:00", "CC001", "Chứng Chỉ A", "50/100");
                examTable.Rows.Add("002", "Kỳ Thi B", "Mô tả B", "Hồ Chí Minh", "Phòng 102", "2023-10-02 10:00", "CC002", "Chứng Chỉ B", "30/50");
                examTable.Rows.Add("003", "Kỳ Thi C", "Mô tả C", "Đà Nẵng", "Phòng 103", "2023-10-03 11:00", "CC003", "Chứng Chỉ C", "20/30");
                examTable.Rows.Add("004", "Kỳ Thi D", "Mô tả D", "Hà Nội", "Phòng 104", "2023-10-04 12:00", "CC004", "Chứng Chỉ D", "10/20");
                examTable.Rows.Add("005", "Kỳ Thi E", "Mô tả E", "Hồ Chí Minh", "Phòng 105", "2023-10-05 13:00", "CC005", "Chứng Chỉ E", "5/10");
                examTable.Rows.Add("006", "Kỳ Thi F", "Mô tả F", "Đà Nẵng", "Phòng 106", "2023-10-06 14:00", "CC006", "Chứng Chỉ F", "0/5");
                examTable.Rows.Add("007", "Kỳ Thi G", "Mô tả G", "Hà Nội", "Phòng 107", "2023-10-07 15:00", "CC007", "Chứng Chỉ G", "0/10");

                originalExamTable = examTable.Copy();
                dgvDSLichThi.DataSource = examTable;
            }

            public string LuaChonLichThi()
            {
                return SelectedExamSchedule;
            }

            public string LuaChonMaKyThiMoi()
            {
                return SelectedMaKyThiMoi;
            }
            private void InitializeFilterOptions()
            {
                cmbFilter.Items.Add("Tất cả");
                var uniqueLocations = examTable.AsEnumerable()
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
                    var filteredRows = examTable.AsEnumerable().Where(row =>
                        DateTime.TryParse(row.Field<string>("Thời Gian Bắt Đầu"), out DateTime examTime) &&
                        examTime.Date == filterTime.Date);

                    if (filteredRows.Any())
                    {
                        dgvDSLichThi.DataSource = filteredRows.CopyToDataTable();
                    }
                    else
                    {
                        dgvDSLichThi.DataSource = examTable.Clone(); // Show empty table if no match
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
                var filteredRows = originalExamTable.AsEnumerable()
                    .Where(row => DateTime.Parse(row.Field<string>("Thời Gian Bắt Đầu") + "") >= selectedTime);

                if (filteredRows.Any())
                {
                    dgvDSLichThi.DataSource = filteredRows.CopyToDataTable();
                }
                else
                {
                    dgvDSLichThi.DataSource = originalExamTable.Clone(); // Show an empty table if no match
                }
            }

            private void nudHourSelector_ValueChanged(object sender, EventArgs e)
            {
                int selectedHour = (int)nudHourSelector.Value;

                var filteredRows = originalExamTable.AsEnumerable()
                    .Where(row => DateTime.TryParse(row.Field<string>("Thời Gian Bắt Đầu"), out DateTime examTime) &&
                                  examTime.Hour == selectedHour);

                if (filteredRows.Any())
                {
                    dgvDSLichThi.DataSource = filteredRows.CopyToDataTable();
                }
                else
                {
                    dgvDSLichThi.DataSource = originalExamTable.Clone(); // Show an empty table if no match
                }
            }

            private void ApplyFilters()
            {
                string searchText = txtSearch.Text.ToLower();
                string filterLocation = cmbFilter.SelectedItem?.ToString() ?? "Tất cả";

                var filteredRows = examTable.AsEnumerable().Where(row =>
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
                    dgvDSLichThi.DataSource = examTable.Clone(); // Show empty table if no match
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
                                           selectedRow.Cells["Mô Tả"].Value.ToString() + " - " +
                                           selectedRow.Cells["Địa Điểm"].Value.ToString() + " - " +
                                           selectedRow.Cells["Số Phòng"].Value.ToString() + " - " +
                                           selectedRow.Cells["Mã Chứng Chỉ"].Value.ToString() + " - " +
                                           selectedRow.Cells["Tên Chứng Chỉ"].Value.ToString() + " - " +
                                           selectedRow.Cells["Thời Gian Bắt Đầu"].Value.ToString() + " - " +
                                           selectedRow.Cells["Số lượng"].Value.ToString();

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
