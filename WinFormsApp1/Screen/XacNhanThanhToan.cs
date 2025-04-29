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
    public partial class XacNhanThanhToan : UserControl
    {
        float tongTien = 0;
        float giamGia = 0f;
        int soThiSinh = 0;
        string maPhieuDK = "";
        public UserControl PreviousControl { get; set; }
        private HoaDonThanhToanBUS hoaDonThanhToanBUS = new HoaDonThanhToanBUS();
        private PhieuDangKyBUS phieuDangKyBUS = new PhieuDangKyBUS();
        public XacNhanThanhToan(string maPhieuDK, string loaiThanhToan, string tongTien, string loai_dk, string so_thi_sinh)
        {
            InitializeComponent();
            MH_XacNhanThanhToan_Load(loaiThanhToan, tongTien, loai_dk, so_thi_sinh);
            this.maPhieuDK = maPhieuDK;
        }

        private float ApDungGiamGiaDonVi()
        {   
            return this.tongTien * (1 - this.giamGia);
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            if (PreviousControl != null)
            {
                PreviousControl.Show();
                this.Parent.Controls.Remove(this);
            }
        }

        private void btnThanhToan_Click(object sender, EventArgs e)
        {
            string loaiThanhToan = txtboxLoaiThanhToan.Text;
            if(loaiThanhToan == "Thanh toán phiếu đăng ký") {
                loaiThanhToan = "dang_ky";
            }
            else {
                loaiThanhToan = "gia_han";
            }
            float soTien = this.tongTien;
            float giamGia = this.giamGia;
            DateTime ngayThanhToan = DateTime.Now;
            string hinhThuc = cbboxHinhThuc.SelectedItem.ToString();
            if(hinhThuc == "Tiền mặt") {
                hinhThuc = "tien_mat";
            }
            else {
                hinhThuc = "chuyen_khoan";
            }
            string maGiaoDich = txtboxMaGiaoDich.Text;

            int maHoaDonThanhToan = hoaDonThanhToanBUS.taoHoaDonThanhToan(loaiThanhToan, soTien, giamGia, ngayThanhToan, hinhThuc, maGiaoDich);

            if(hinhThuc == "tien_mat") {
                phieuDangKyBUS.CapNhatTrangThaiPhieuDangKy(maPhieuDK, maHoaDonThanhToan, 1);
            }
            else {
                if(maGiaoDich == "") {
                    phieuDangKyBUS.CapNhatTrangThaiPhieuDangKy(maPhieuDK, maHoaDonThanhToan, 0);
                }
                else {
                    phieuDangKyBUS.CapNhatTrangThaiPhieuDangKy(maPhieuDK, maHoaDonThanhToan, 1);
                }
            }
            MessageBox.Show("Thanh toán thành công");
            if (PreviousControl != null)
            {
                ThanhToanPhieuDK thanhToanPhieuDK = new ThanhToanPhieuDK();
                this.Parent.Controls.Add(thanhToanPhieuDK);
                this.Hide();
                this.Parent.Controls.Remove(this);
                thanhToanPhieuDK.Dock = DockStyle.Fill;
            }
        }

        private void cbboxHinhThuc_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbboxHinhThuc.SelectedIndex == 1)
            {
                txtboxMaGiaoDich.Enabled = false;
            }
            else
            {
                txtboxMaGiaoDich.Enabled = true;
            }
        }

        private void MH_XacNhanThanhToan_Load(string loaiThanhToan, string tongTien, string loai_dk, string so_thi_sinh)
        {
            this.tongTien = float.Parse(tongTien);
            txtboxLoaiThanhToan.Text = loaiThanhToan;
            txtBoxNgayThanhToan.Text = DateTime.Now.ToString("dd/MM/yyyy");
            txtboxTongTien.Text = tongTien.ToString();
            txtboxSoTienThanhToan.Text = ApDungGiamGiaDonVi().ToString();
            txtboxMaGiaoDich.Text = "";
            soThiSinh = int.Parse(so_thi_sinh);
            if (loai_dk != "Cá nhân")
            {
                giamGia = 0.2f;
                txtboxGiamGia.Text = "20%";
                if (soThiSinh > 20)
                {
                    giamGia = 0.25f;
                    txtboxGiamGia.Text = "25%";
                }
            }
            else
            {
                cbboxHinhThuc.SelectedIndex = 1;
                cbboxHinhThuc.Enabled = false;
                txtboxMaGiaoDich.Enabled = false;
            }
        }
    }
}
