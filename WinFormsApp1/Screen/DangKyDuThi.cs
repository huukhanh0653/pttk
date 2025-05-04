using System.Data;
using System.Diagnostics;
using System.Windows.Forms;
using Microsoft.IdentityModel.Tokens;
using WinFormsApp1.Business;

namespace WinFormsApp1
{
    public partial class DangKyDuThi : UserControl
    {
        private KyThiBUS kyThiBUS = new KyThiBUS();
        private ThiSinhBUS thiSinhBUS = new ThiSinhBUS();
        private PhieuDangKyBUS phieuDangKyBUS = new PhieuDangKyBUS();
        private NguoiDangKyBUS nguoiDangKyBUS = new NguoiDangKyBUS();
        private ChiTietPhieuDangKyBUS chiTietPhieuDangKyBUS = new ChiTietPhieuDangKyBUS();
        private DanhSachChungChiBUS danhSachChungChiBUS = new DanhSachChungChiBUS();

        private string selectedMaKyThi = string.Empty;
        private string selectedGiaTien = string.Empty;
        private string selectedMaChungChi = string.Empty;



        public DangKyDuThi()
        {
            InitializeComponent();
            dgvDSThiSinh.ClearSelection();
            dgvDSKyThi.ClearSelection();
            DTPNguoiDKy.Value = DateTime.Now;
            DTPNguoiThi.Value = DateTime.Now;
            
            dgvDSThiSinh.DataSource = new DataTable();
        }

        private void label1_Click(object sender, EventArgs e) { }

        private void DSKyThi_Format()
        {

            dgvDSKyThi.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dgvDSKyThi.Columns["dia_diem"].HeaderText = "Địa điểm";
            dgvDSKyThi.Columns["thoi_gian_bat_dau"].HeaderText = "Thời gian bắt đầu";
            dgvDSKyThi.Columns["thoi_gian_bat_dau"].DefaultCellStyle.Format = "dd/MM/yyyy";
            dgvDSKyThi.Columns["thoi_luong_thi"].HeaderText = "Thời lượng thi";
            dgvDSKyThi.Columns["ma_chung_chi"].HeaderText = "Mã chứng chỉ";
            dgvDSKyThi.Columns["mo_ta"].HeaderText = "Mô tả";
            dgvDSKyThi.Columns["ten_ky_thi"].HeaderText = "Tên kỳ thi";
            dgvDSKyThi.Columns["ma_ky_thi"].HeaderText = "Mã kỳ thi";
            dgvDSKyThi.Columns["so_phong"].HeaderText = "Số Phòng";
            dgvDSKyThi.Columns["so_luong_dang_ky_hien_tai"].HeaderText = "Số lượng đăng ký hiện tại";
            dgvDSKyThi.Columns["so_luong_toi_da"].HeaderText = "Số lượng tối đa";
        }

        private void DSThiSinh_Format()
        {
            
            dgvDSThiSinh.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dgvDSThiSinh.Columns["ma_ky_thi"].HeaderText = "Mã kỳ thi";
            dgvDSThiSinh.Columns["ho_ten"].HeaderText = "Họ tên";
            dgvDSThiSinh.Columns["ngay_sinh"].HeaderText = "Ngày sinh";
            dgvDSThiSinh.Columns["so_dien_thoai"].HeaderText = "Số điện thoại";
            dgvDSThiSinh.Columns["email"].HeaderText = "Email";
            dgvDSThiSinh.Columns["ngay_dang_ky"].HeaderText = "Ngày đăng ký";
            dgvDSThiSinh.Columns["ngay_dang_ky"].DefaultCellStyle.Format = "dd/MM/yyyy";
            dgvDSThiSinh.Columns["nguoi_tiep_nhan"].HeaderText = "Người tiếp nhận";
            dgvDSThiSinh.Columns["tong_tien"].HeaderText = "Tổng tiền";
            dgvDSThiSinh.Columns["trang_thai_thanh_toan"].HeaderText = "Trạng thái thanh toán";
            dgvDSThiSinh.Columns["ma_thi_sinh"].HeaderText = "Mã thí sinh";

            // Thêm cột button "Sửa"
            DataGridViewButtonColumn btnSua = new DataGridViewButtonColumn();
            btnSua.Name = "Sua";
            btnSua.HeaderText = "Hành động";
            btnSua.Text = "Sửa";
            btnSua.UseColumnTextForButtonValue = true;
            dgvDSThiSinh.Columns.Add(btnSua);
        }


        private void MH_DKY_CA_NHAN_Load(object sender, EventArgs e)
        {
            DTPNguoiDKy.Format = DateTimePickerFormat.Custom;
            DTPNguoiDKy.CustomFormat = "dd/MM/yyyy";
            DTPNguoiThi.Format = DateTimePickerFormat.Custom;
            DTPNguoiThi.CustomFormat = "dd/MM/yyyy";


            dgvDSKyThi.DataSource = kyThiBUS.dtbGetAllKyThi();
            DSKyThi_Format();

            DataTable table = new DataTable();
            table.Columns.Add("ma_ky_thi", typeof(string));
            table.Columns.Add("ho_ten", typeof(string));
            table.Columns.Add("ngay_sinh", typeof(string));
            table.Columns.Add("so_dien_thoai", typeof(string));
            table.Columns.Add("email", typeof(string));
            table.Columns.Add("ngay_dang_ky", typeof(string));
            table.Columns.Add("nguoi_tiep_nhan", typeof(string));
            table.Columns.Add("tong_tien", typeof(string));
            table.Columns.Add("trang_thai_thanh_toan", typeof(string));
            table.Columns.Add("ma_thi_sinh", typeof(string));

            dgvDSThiSinh.DataSource = table;

            dgvDSThiSinh.Columns["ma_ky_thi"].HeaderText = "Mã kỳ thi";
            dgvDSThiSinh.Columns["ho_ten"].HeaderText = "Họ tên";
            dgvDSThiSinh.Columns["ngay_sinh"].HeaderText = "Ngày sinh";
            dgvDSThiSinh.Columns["so_dien_thoai"].HeaderText = "Số điện thoại";
            dgvDSThiSinh.Columns["email"].HeaderText = "Email";
            dgvDSThiSinh.Columns["ngay_dang_ky"].HeaderText = "Ngày đăng ký";
            dgvDSThiSinh.Columns["ngay_dang_ky"].DefaultCellStyle.Format = "dd/MM/yyyy";
            dgvDSThiSinh.Columns["nguoi_tiep_nhan"].HeaderText = "Người tiếp nhận";
            dgvDSThiSinh.Columns["tong_tien"].HeaderText = "Tổng tiền";
            dgvDSThiSinh.Columns["trang_thai_thanh_toan"].HeaderText = "Trạng thái thanh toán";
            dgvDSThiSinh.Columns["ma_thi_sinh"].HeaderText = "Mã thí sinh";



            //// Gán vào DataGridView2 (Danh sách thí sinh đăng ký)
            //dgvDSThiSinh.DataSource = phieuDangKyBUS.GetAllPhieuDangKyAndChiTiet();
            //DSThiSinh_Format();

        }

        private void dgvDSKyThi_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                // Lấy mã kỳ thi từ dòng được chọn
                var maKyThiCell = dgvDSKyThi.Rows[e.RowIndex].Cells["ma_ky_thi"].Value;
                var maChungChiCell = dgvDSKyThi.Rows[e.RowIndex].Cells["ma_chung_chi"].Value;

                selectedMaKyThi = maKyThiCell?.ToString() ?? string.Empty;
                selectedMaChungChi = maChungChiCell?.ToString() ?? string.Empty;

                if (!string.IsNullOrEmpty(selectedMaKyThi))
                {
                    var chungChiRow = danhSachChungChiBUS.getChungChiByMaChungChi(Convert.ToInt32(selectedMaChungChi));

                    selectedGiaTien = chungChiRow?["gia_tien"]?.ToString() ?? string.Empty;
                    if (string.IsNullOrEmpty(selectedGiaTien))
                    {
                        
                        Debug.WriteLine("Gia tien null");
                    }
                }
                else
                {
                    selectedGiaTien = string.Empty;
                }

            }

            Debug.WriteLine("Selected MaKyThi: " + selectedMaKyThi);
            Debug.WriteLine("Selected MaChungChi: " + selectedMaChungChi);
            Debug.WriteLine("Selected GiaTien: " + selectedGiaTien);
        }


        private void label1_Click_1(object sender, EventArgs e) { }

        private void btnSaveThiSinh_Click(object sender, EventArgs e)
        {
            // Lấy thông tin từ các TextBox
            // string maThiSinh = txtMaThiSinh.Text;
            string _emailNguoiThi = textBoxEmailNgThi.Text;
            string _SDTNgThi = textBoxSDTNgThi.Text;
            string _BirthDayNguoiThi = DTPNguoiThi.Value.ToString("yyyy-MM-dd");
            string _HoTenNgThi = textBoxHoTenNgThi.Text;
            string _MaKyThi = dgvDSKyThi.CurrentRow.Cells["ma_ky_thi"].Value.ToString();

            string _emailNguoiDKy = textBoxEmailNgDKy.Text.IsNullOrEmpty() ? textBoxEmailNgThi.Text : textBoxEmailNgDKy.Text;
            string _SDTNgDKy = textBoxSDTNgDKy.Text.IsNullOrEmpty() ? textBoxSDTNgThi.Text : textBoxSDTNgDKy.Text;
            string _BirthDayNguoiDKy = DTPNguoiDKy.Value.ToString("yyyy-MM-dd").IsNullOrEmpty() ?
            DTPNguoiThi.Value.ToString("yyyy-MM-dd") : DTPNguoiDKy.Value.ToString("yyyy-MM-dd");
            string _HoTenNgDKy = textBoxHoTenNguoiDKy.Text.IsNullOrEmpty() ? textBoxHoTenNgThi.Text : textBoxHoTenNguoiDKy.Text;

            // Kiểm tra thông tin hợp lệ
            if (string.IsNullOrEmpty(_emailNguoiThi) || string.IsNullOrEmpty(_HoTenNgThi) ||
                string.IsNullOrEmpty(_SDTNgThi) || string.IsNullOrEmpty(_BirthDayNguoiThi) || string.IsNullOrEmpty(_MaKyThi))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin.");
                return;
            }

            DataTable dsThiSinh = dgvDSThiSinh.DataSource as DataTable;
            DataRow dataRow = dsThiSinh.NewRow();
            dataRow["ma_ky_thi"] = _MaKyThi;
            dataRow["ho_ten"] = _HoTenNgThi;
            dataRow["ngay_sinh"] = _BirthDayNguoiThi;
            dataRow["so_dien_thoai"] = _SDTNgThi;
            dataRow["email"] = _emailNguoiThi;
            dataRow["ngay_dang_ky"] = DateTime.Now;
            dataRow["nguoi_tiep_nhan"] = DangNhapBUS.Instance.TenDangNhap;
            dataRow["tong_tien"] = selectedGiaTien;
            dataRow["trang_thai_thanh_toan"] = "Chưa thanh toán";
            dsThiSinh.Rows.Add(dataRow);

            DSThiSinh_Format();
        }

        private void btnXoaThiSinh_Click(object sender, EventArgs e)
        {
            textBoxEmailNgThi.Clear();
            textBoxHoTenNgThi.Clear();
            textBoxSDTNgThi.Clear();
            DTPNguoiThi.Value = DateTime.Now;
            dgvDSKyThi.ClearSelection();

        }

        private void btnXoaNguoiDangKy_Click(object sender, EventArgs e)
        {
            textBoxEmailNgDKy.Clear();
            textBoxHoTenNguoiDKy.Clear();
            textBoxSDTNgDKy.Clear();
            DTPNguoiDKy.Value = DateTime.Now;
        }

        private void txtSearchKyThi_TextChanged(object sender, EventArgs e)
        {

            if (string.IsNullOrEmpty(txtSearchKyThi.Text))
                dgvDSKyThi.DataSource = kyThiBUS.dtbGetAllKyThi();
            else
                dgvDSKyThi.DataSource = kyThiBUS.searchKyThi(txtSearchKyThi.Text);
            
            dgvDSKyThi.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            DSKyThi_Format();

        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            MainForm.Instance.SwitchUserControl(new Main());
        }

        private void txtSearchThiSinh_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnDangKy_Click(object sender, EventArgs e)
        {
            string _emailNguoiDKy = textBoxEmailNgDKy.Text.IsNullOrEmpty() ? textBoxEmailNgThi.Text : textBoxEmailNgDKy.Text;
            string _SDTNgDKy = textBoxSDTNgDKy.Text.IsNullOrEmpty() ? textBoxSDTNgThi.Text : textBoxSDTNgDKy.Text;
            string _BirthDayNguoiDKy = DTPNguoiDKy.Value.ToString("yyyy-MM-dd").IsNullOrEmpty() ?
            DTPNguoiThi.Value.ToString("yyyy-MM-dd") : DTPNguoiDKy.Value.ToString("yyyy-MM-dd");
            string _HoTenNgDKy = textBoxHoTenNguoiDKy.Text.IsNullOrEmpty() ? textBoxHoTenNgThi.Text : textBoxHoTenNguoiDKy.Text;

            int _maNguoiDangKy = nguoiDangKyBUS.AddNguoiDangKy(_HoTenNgDKy, DateOnly.Parse(_BirthDayNguoiDKy), _SDTNgDKy, _emailNguoiDKy, false);

            int _maPhieuDangKy = phieuDangKyBUS.AddPhieuDangKy(_maNguoiDangKy.ToString(), DateTime.Now, Convert.ToInt32(DangNhapBUS.Instance.TenDangNhap), 0);

            DataTable dataTable = dgvDSThiSinh.DataSource as DataTable;


            for (int i = 0; i < dgvDSThiSinh.Rows.Count - 1; i++)
            {

                // Updated code to handle potential null values in DataGridViewCell.Value
                int _maThiSinh = thiSinhBUS.addThiSinh(
                    dgvDSThiSinh.Rows[i].Cells["ho_ten"].Value?.ToString() ?? string.Empty,
                    DateOnly.TryParse(dgvDSThiSinh.Rows[i].Cells["ngay_sinh"].Value?.ToString(), out var ngaySinh) ? ngaySinh : default,
                    dgvDSThiSinh.Rows[i].Cells["so_dien_thoai"].Value?.ToString() ?? string.Empty,
                    dgvDSThiSinh.Rows[i].Cells["email"].Value?.ToString() ?? string.Empty,
                    DateTime.Now
                );

                chiTietPhieuDangKyBUS.AddChiTietPhieuDangKy(_maPhieuDangKy.ToString(), dgvDSThiSinh.Rows[i].Cells["ma_ky_thi"].Value.ToString(), _maThiSinh.ToString());

                if (_maThiSinh == 0)
                {
                    MessageBox.Show("Thêm thí sinh thất bại.");
                    return;
                }

                // Cập nhật mã thí sinh vào DataGridView
                dgvDSThiSinh.Rows[i].Cells["ma_thi_sinh"].Value = _maThiSinh;

                MessageBox.Show("Thêm thí sinh thành công");
            }

        }
    }
}
