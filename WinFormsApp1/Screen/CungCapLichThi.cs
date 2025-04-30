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
using System.Globalization;

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
            try
            {
                table = kyThiBUS.getKyThiByMaChungChiLater(maChungChi);
                // Rename columns for display
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

                // Format Thời Gian Bắt Đầu column in DataGridView
                if (dgvDSLichThi.Columns["Thời Gian Bắt Đầu"] != null)
                {
                    dgvDSLichThi.Columns["Thời Gian Bắt Đầu"].DefaultCellStyle.Format = "yyyy-MM-dd HH:mm";
                }

                // Debug column types and sample data
                foreach (DataColumn col in table.Columns)
                {
                    Debug.WriteLine($"Column {col.ColumnName}: {col.DataType}");
                }
                if (table.Rows.Count > 0)
                {
                    Debug.WriteLine($"Sample Thời Gian Bắt Đầu: {table.Rows[0]["Thời Gian Bắt Đầu"]}");
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine($"Error in LoadExamData: {ex.Message}\n{ex.StackTrace}");
            }
        }

        private void InitializeFilterOptions()
        {
            try
            {
                cmbFilter.Items.Add("Tất cả");
                var uniqueLocations = table.AsEnumerable()
                    .Select(row => row.Field<string>("Địa Điểm"))
                    .Where(location => !string.IsNullOrEmpty(location))
                    .Distinct()
                    .ToList();
                cmbFilter.Items.AddRange(uniqueLocations.ToArray());
                cmbFilter.SelectedIndex = 0;
            }
            catch (Exception ex)
            {
                Debug.WriteLine($"Error in InitializeFilterOptions: {ex.Message}\n{ex.StackTrace}");
            }
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
            try
            {
                string inputTime = Microsoft.VisualBasic.Interaction.InputBox(
                    "Nhập thời gian bắt đầu (yyyy-MM-dd):",
                    "Lọc theo thời gian",
                    DateTime.Now.ToString("yyyy-MM-dd"));

                if (DateTime.TryParse(inputTime, CultureInfo.InvariantCulture, DateTimeStyles.None, out DateTime filterTime))
                {
                    var filteredRows = originaltable.AsEnumerable().Where(row =>
                        row.Field<DateTime>("Thời Gian Bắt Đầu").Date == filterTime.Date);

                    if (filteredRows.Any())
                    {
                        table = filteredRows.CopyToDataTable();
                        dgvDSLichThi.DataSource = table;
                    }
                    else
                    {
                        table = originaltable.Clone();
                        dgvDSLichThi.DataSource = table;
                    }
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine($"Error in btnFilterByTime_Click: {ex.Message}\n{ex.StackTrace}");
            }
        }

        private void ApplyFilters()
        {
            try
            {
                string searchText = txtSearch.Text.ToLower();
                string filterLocation = cmbFilter.SelectedItem?.ToString() ?? "Tất cả";

                var filteredRows = originaltable.AsEnumerable().Where(row =>
                {
                    // Kiểm tra location
                    bool locationMatch = filterLocation == "Tất cả" ||
                                       (row["Địa Điểm"] != DBNull.Value &&
                                        row["Địa Điểm"].ToString() == filterLocation);

                    // Kiểm tra search text
                    bool textMatch = string.IsNullOrEmpty(searchText);

                    if (!textMatch)
                    {
                        textMatch =
                            (row["Tên Kỳ Thi"] != DBNull.Value && row["Tên Kỳ Thi"].ToString().ToLower().Contains(searchText)) ||
                            (row["Mã Kỳ Thi"] != DBNull.Value && row["Mã Kỳ Thi"].ToString().ToLower().Contains(searchText)) ||
                            (row["Mô Tả"] != DBNull.Value && row["Mô Tả"].ToString().ToLower().Contains(searchText)) ||
                            (row["Địa Điểm"] != DBNull.Value && row["Địa Điểm"].ToString().ToLower().Contains(searchText)) ||
                            (row["Số Phòng"] != DBNull.Value && row["Số Phòng"].ToString().Contains(searchText)) ||
                            (row["Mã Chứng Chỉ"] != DBNull.Value && row["Mã Chứng Chỉ"].ToString().ToLower().Contains(searchText)) ||
                            (row["Thời Gian Bắt Đầu"] != DBNull.Value &&
                             DateTime.TryParse(row["Thời Gian Bắt Đầu"].ToString(), out DateTime dateValue) &&
                             dateValue.ToString("yyyy-MM-dd HH:mm").ToLower().Contains(searchText)) ||
                            (row["Thời Lượng Thi"] != DBNull.Value && row["Thời Lượng Thi"].ToString().Contains(searchText)) ||
                            (row["Số Lượng Đăng Ký Hiện Tại"] != DBNull.Value && row["Số Lượng Đăng Ký Hiện Tại"].ToString().Contains(searchText)) ||
                            (row["Số Lượng Tối Đa"] != DBNull.Value && row["Số Lượng Tối Đa"].ToString().Contains(searchText));
                    }

                    return locationMatch && textMatch;
                });

                table = filteredRows.Any() ? filteredRows.CopyToDataTable() : originaltable.Clone();
                dgvDSLichThi.DataSource = table;
            }
            catch (Exception ex)
            {
                Debug.WriteLine($"Error in ApplyFilters: {ex.Message}\n{ex.StackTrace}");
            }
        }

        private void dtpFilterByTime_ValueChanged(object sender, EventArgs e)
        {
            try
            {
                var selectedTime = dtpFilterByTime.Value.Date;

                var filteredRows = originaltable.AsEnumerable()
                    .Where(row => row["Thời Gian Bắt Đầu"] != DBNull.Value &&
                                 DateTime.TryParse(row["Thời Gian Bắt Đầu"].ToString(), out DateTime dateValue) &&
                                 dateValue.Date == selectedTime);

                table = filteredRows.Any() ? filteredRows.CopyToDataTable() : originaltable.Clone();
                dgvDSLichThi.DataSource = table;
            }
            catch (Exception ex)
            {
                Debug.WriteLine($"Error in dtpFilterByTime_ValueChanged: {ex.Message}\n{ex.StackTrace}");
            }
        }

        private void nudHourSelector_ValueChanged(object sender, EventArgs e)
        {
            try
            {
                int selectedHour = (int)nudHourSelector.Value;

                var filteredRows = originaltable.AsEnumerable()
                    .Where(row => row["Thời Gian Bắt Đầu"] != DBNull.Value &&
                                 DateTime.TryParse(row["Thời Gian Bắt Đầu"].ToString(), out DateTime dateValue) &&
                                 dateValue.Hour == selectedHour);

                table = filteredRows.Any() ? filteredRows.CopyToDataTable() : originaltable.Clone();
                dgvDSLichThi.DataSource = table;
            }
            catch (Exception ex)
            {
                Debug.WriteLine($"Error in nudHourSelector_ValueChanged: {ex.Message}\n{ex.StackTrace}");
            }
        }

        private void btnChonLichThi_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvDSLichThi.SelectedRows.Count > 0)
                {
                    var selectedRow = dgvDSLichThi.SelectedRows[0];

                    SelectedExamSchedule = $"{selectedRow.Cells["Mã Kỳ Thi"].Value} - " +
                                          $"{selectedRow.Cells["Tên Kỳ Thi"].Value} - " +
                                          $"{selectedRow.Cells["Địa Điểm"].Value} - " +
                                          $"{selectedRow.Cells["Số Phòng"].Value} - " +
                                          $"{selectedRow.Cells["Mã Chứng Chỉ"].Value} - " +
                                          $"{selectedRow.Cells["Thời Lượng Thi"].Value} - " +
                                          $"{selectedRow.Cells["Thời Gian Bắt Đầu"].Value} - " +
                                          $"{selectedRow.Cells["Số Lượng Tối Đa"].Value}";
                    Debug.WriteLine(SelectedExamSchedule);
                    DataSelected?.Invoke(this, SelectedExamSchedule);
                }
                else
                {
                    MessageBox.Show("Vui lòng chọn một lịch thi.", "Thông báo");
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine($"Error in btnChonLichThi_Click: {ex.Message}\n{ex.StackTrace}");
            }
        }

        private void dgvDSLichThi_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Handle cell click if needed
        }
    }
}