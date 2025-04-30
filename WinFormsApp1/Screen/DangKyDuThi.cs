using System.Data;
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

        private string selectedMaKyThi = string.Empty;
        private string selectedGiaTien = string.Empty;



        public DangKyDuThi()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e) { }

        private void MH_DKY_CA_NHAN_Load(object sender, EventArgs e)
        {
            DTPNguoiDKy.Format = DateTimePickerFormat.Custom;
            DTPNguoiDKy.CustomFormat = "dd/MM/yyyy";
            DTPNguoiThi.Format = DateTimePickerFormat.Custom;
            DTPNguoiThi.CustomFormat = "dd/MM/yyyy";

            dataGridView1.DataSource = kyThiBUS.dtbGetAllKyThi();
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridView1.Columns["dia_diem"].HeaderText = "Địa điểm";
            dataGridView1.Columns["thoi_gian_bat_dau"].HeaderText = "Thời gian bắt đầu";
            dataGridView1.Columns["thoi_gian_bat_dau"].DefaultCellStyle.Format = "dd/MM/yyyy";
            dataGridView1.Columns["thoi_luong_thi"].HeaderText = "Thời lượng thi";
            dataGridView1.Columns["ma_chung_chi"].HeaderText = "Mã chứng chỉ";
            dataGridView1.Columns["mo_ta"].HeaderText = "Mô tả";
            dataGridView1.Columns["ten_ky_thi"].HeaderText = "Tên kỳ thi";
            dataGridView1.Columns["ma_ky_thi"].HeaderText = "Mã kỳ thi";
            dataGridView1.Columns["so_phong"].HeaderText = "Số Phòng";
            dataGridView1.Columns["so_luong_dang_ky_hien_tai"].HeaderText = "Số lượng đăng ký hiện tại";
            dataGridView1.Columns["so_luong_toi_da"].HeaderText = "Số lượng tối đa";

            // Gán vào DataGridView2 (Danh sách thí sinh đăng ký)
            dataGridView2.DataSource = phieuDangKyBUS.GetAllPhieuDangKyAndChiTiet();
            dataGridView2.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridView2.Columns["ma_ky_thi"].HeaderText = "Mã kỳ thi";
            dataGridView2.Columns["ma_phieu_dang_ky"].HeaderText = "Mã phiếu đăng ký";
            //dataGridView2.Columns["ma_thanh_toan"].HeaderText = "Mã thanh toán";
            dataGridView2.Columns["ma_thi_sinh"].HeaderText = "Mã thí sinh";
            //dataGridView2.Columns["mo_ta"].HeaderText = "Mô tả";
            dataGridView2.Columns["ngay_dang_ky"].HeaderText = "Ngày đăng ký";
            dataGridView2.Columns["ngay_dang_ky"].DefaultCellStyle.Format = "dd/MM/yyyy";
            dataGridView2.Columns["nguoi_tiep_nhan"].HeaderText = "Người tiếp nhận";
            dataGridView2.Columns["tong_tien"].HeaderText = "Tổng tiền";
            dataGridView2.Columns["trang_thai_thanh_toan"].HeaderText = "Trạng thái thanh toán";

            // Thêm cột button "Sửa"
            DataGridViewButtonColumn btnSua = new DataGridViewButtonColumn();
            btnSua.Name = "Sua";
            btnSua.HeaderText = "Hành động";
            btnSua.Text = "Sửa";
            btnSua.UseColumnTextForButtonValue = true;
            dataGridView2.Columns.Add(btnSua);
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex == 0)
            {
                // Lấy mã kỳ thi từ dòng được chọn
                selectedMaKyThi = dataGridView1.Rows[e.RowIndex].Cells["ma_ky_thi"].Value.ToString();
            }
        }


        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void btnSaveThiSinh_Click(object sender, EventArgs e)
        {
            // Lấy thông tin từ các TextBox
            // string maThiSinh = txtMaThiSinh.Text;
            string _emailNguoiThi = textBoxEmailNgThi.Text;
            string _SDTNgThi = textBoxSDTNgThi.Text;
            string _BirthDayNguoiThi = DTPNguoiThi.Value.ToString("yyyy-MM-dd");
            string _HoTenNgThi = textBoxHoTenNgThi.Text;
            string _MaKyThi = dataGridView1.CurrentRow.Cells["ma_ky_thi"].Value.ToString();

            string _emailNguoiDKy = textBoxEmailNgDKy.Text.IsNullOrEmpty() ? textBoxEmailNgThi.Text : textBoxEmailNgDKy.Text;
            string _SDTNgDKy = textBoxSDTNgDKy.Text.IsNullOrEmpty() ? textBoxSDTNgThi.Text : textBoxSDTNgDKy.Text;
            string _BirthDayNguoiDKy = DTPNguoiDKy.Value.ToString("yyyy-MM-dd").IsNullOrEmpty() ? DTPNguoiThi.Value.ToString("yyyy-MM-dd") : DTPNguoiDKy.Value.ToString("yyyy-MM-dd");
            string _HoTenNgDKy = textBoxHoTenNguoiDKy.Text.IsNullOrEmpty() ? textBoxHoTenNgThi.Text : textBoxHoTenNguoiDKy.Text;

            // Kiểm tra thông tin hợp lệ
            if (string.IsNullOrEmpty(_emailNguoiThi) || string.IsNullOrEmpty(_HoTenNgThi) ||
                string.IsNullOrEmpty(_SDTNgThi) || string.IsNullOrEmpty(_BirthDayNguoiThi) || string.IsNullOrEmpty(_MaKyThi))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin.");
                return;
            }

            // Thêm thí sinh vào cơ sở dữ liệu
            thiSinhBUS.addThiSinh(_HoTenNgThi, DateOnly.Parse(_BirthDayNguoiThi), _SDTNgThi, _emailNguoiThi, DateTime.Now);
            // Lấy mã thí sinh vừa thêm
            DataTable temp = thiSinhBUS.dtbGetAllThiSinh();
            int maThiSinh = temp.Rows[temp.Rows.Count - 1].Field<int>("ma_thi_sinh");
            // Thêm người đăng ký vào cơ sở dữ liệu
            nguoiDangKyBUS.AddNguoiDangKy(_HoTenNgDKy, DateOnly.Parse(_BirthDayNguoiDKy), _SDTNgDKy, _emailNguoiDKy, false);
            // Lấy mã người đăng ký vừa thêm
            int maNguoiDangKy = nguoiDangKyBUS.GetAllNguoiDangKy().Rows[nguoiDangKyBUS.GetAllNguoiDangKy().Rows.Count - 1].Field<int>("ma_nguoi_dang_ky");

            // Thêm phiếu đăng ký vào cơ sở dữ liệu
            phieuDangKyBUS.AddPhieuDangKy(maNguoiDangKy.ToString(), DangNhapBUS.Instance.TenDangNhap, selectedGiaTien);

            // Lấy mã phiếu đăng ký vừa thêm
            int maPhieuDangKy = phieuDangKyBUS.GetAllPhieuDangKy().Rows[phieuDangKyBUS.GetAllPhieuDangKy().Rows.Count - 1].Field<int>("ma_phieu_dang_ky");

            // Thêm chi tiết phiếu đăng ký vào cơ sở dữ liệu
            chiTietPhieuDangKyBUS.AddChiTietPhieuDangKy(maPhieuDangKy.ToString(), maThiSinh.ToString(), _MaKyThi);

            // Cập nhật lại DataGridView2
            dataGridView2.DataSource = phieuDangKyBUS.GetAllPhieuDangKy();
        }

        private void btnXoaThiSinh_Click(object sender, EventArgs e)
        {
            textBoxEmailNgThi.Clear();
            textBoxHoTenNgThi.Clear();
            textBoxSDTNgThi.Clear();
            DTPNguoiThi.Value = DateTime.Now;
            dataGridView1.ClearSelection();

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
            dataGridView1.DataSource = kyThiBUS.searchKyThi(txtSearchKyThi.Text);
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            MainForm.Instance.SwitchUserControl(new Main());
        }
    }
}
