using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WinFormsApp1.DAO;

namespace WinFormsApp1.Business
{
    internal class PhieuGiaHanBUS
    {

        #region entity_prop

        private DateTime created_at;
        private int maPhieuGiaHan;
        private int maPhieuDuThi;
        private int maThanhToan;
        private int soLan;
        private int maKyThiCu;
        private int maKyThiMoi;
        private DateTime thoiGianGiaHan;
        private double phiGiaHan;
        private bool trangThaiThanhToan;
        private string lyDo;
        private string thoiGianThiMoi;
        private int maNhanVienGiaHan;
        public int MaPhieuGiaHan
        {
            get { return this.maPhieuGiaHan; }
            set { this.maPhieuGiaHan = value; }
        }
        public int MaPhieuDuThi
        {
            get { return this.maPhieuDuThi; }
            set { this.maPhieuDuThi = value; }
        }
        public int MaThanhToan
        {
            get { return this.maThanhToan; }
            set { this.maThanhToan = value; }
        }
        public int SoLan
        {
            get { return this.soLan; }
            set { this.soLan = value; }
        }
        public int MaKyThiCu
        {
            get { return this.maKyThiCu; }
            set { this.maKyThiCu = value; }
        }
        public int MaKyThiMoi
        {
            get { return this.maKyThiMoi; }
            set { this.maKyThiMoi = value; }
        }
        public DateTime ThoiGianGiaHan
        {
            get { return this.thoiGianGiaHan; }
            set { this.thoiGianGiaHan = value; }
        }
        public double PhiGiaHan
        {
            get { return this.phiGiaHan; }
            set { this.phiGiaHan = value; }
        }
        public bool TrangThaiThanhToan
        {
            get { return this.trangThaiThanhToan; }
            set { this.trangThaiThanhToan = value; }
        }
        public string LyDo
        {
            get { return this.lyDo; }
            set { this.lyDo = value; }
        }

        public string ThoiGianThiMoi
        {
            get { return this.thoiGianThiMoi; }
            set { this.thoiGianThiMoi = value; }
        }

        public int MaNhanVienGiaHan
        {
            get { return this.maNhanVienGiaHan; }
            set { this.maNhanVienGiaHan = value; }
        }

        public DateTime CreatedAt
        {
            get { return this.created_at; }
            set { this.created_at = value; }
        }
        #endregion

        #region DAO
        private PhieuGiaHanDAO phieuGiaHanDAO = new PhieuGiaHanDAO();
        #endregion

        public PhieuGiaHanBUS(int maPhieuGiaHan, int maPhieuDuThi, int maThanhToan, int soLan, int maKyThiCu, int maKyThiMoi, DateTime thoiGianGiaHan,
            double phiGiaHan, bool trangThaiThanhToan, string lyDo, string thoiGianThiMoi, int maNhanVienGiaHan)
        {
            this.maPhieuGiaHan = maPhieuGiaHan;
            this.maPhieuDuThi = maPhieuDuThi;
            this.maThanhToan = maThanhToan;
            this.soLan = soLan;
            this.maKyThiCu = maKyThiCu;
            this.maKyThiMoi = maKyThiMoi;
            this.thoiGianGiaHan = thoiGianGiaHan;
            this.phiGiaHan = phiGiaHan;
            this.trangThaiThanhToan = trangThaiThanhToan;
            this.lyDo = lyDo;
            this.thoiGianThiMoi = thoiGianThiMoi;
            this.maNhanVienGiaHan = maNhanVienGiaHan;
        }

        public PhieuGiaHanBUS() { }

        public DataTable getPhieuGiaHanByMaPhieuDuThi(string maPhieuDuThi)
        {
            if (maPhieuDuThi.IsNullOrEmpty())
            {
                throw new ArgumentException("maPhieuDuThi is null or empty");
            }
            return phieuGiaHanDAO.getPhieuGiaHanByMaPhieuDuThi(Convert.ToInt32(maPhieuDuThi));
        }

        public bool is2TimesAlready(string maPhieuDuThi)
        {
            DataTable table = getPhieuGiaHanByMaPhieuDuThi(maPhieuDuThi);
            int successfulExtensions = table.AsEnumerable()
                .Count(row =>
                    (bool)row["truong_hop_dac_biet"] ||
                    (!string.IsNullOrEmpty(row["ma_thanh_toan"]?.ToString()) && row["ma_thanh_toan"] != DBNull.Value));
            return successfulExtensions < 2; // Trả về true nếu chưa đạt 2 lần gia hạn
        }

        public void addPhieuGiaHan(string maPhieuDuThi, string maKyThiCu, string maKyThiMoi,
            string lyDo, string thoiGianThiMoi, string maNhanVienGiaHan, bool dacBiet, string maChungChi)
        {
            if (!is2TimesAlready(maPhieuDuThi))
            {
                throw new InvalidOperationException("Phiếu dự thi đã gia hạn thành công 2 lần.");
            }

            DataTable table = phieuGiaHanDAO.getPhieuGiaHanByMaPhieuDuThi(Convert.ToInt32(maPhieuDuThi));
            Debug.WriteLine("table.Rows.Count: " + table.Rows.Count);

            bool isSuccessful(DataRow row) => (bool)row["truong_hop_dac_biet"] ||
                (!string.IsNullOrEmpty(row["ma_thanh_toan"]?.ToString()) && row["ma_thanh_toan"] != DBNull.Value);

            DataRow targetRow = null;
            bool isUpdate = false;
            int soLan = table.Rows.Count + 1;

            if (table.Rows.Count == 0)
            {
                soLan = 1;
            }
            else if (table.Rows.Count == 1)
            {
                targetRow = table.Rows[0];
                if (!isSuccessful(targetRow))
                {
                    MessageBox.Show("3");
                    isUpdate = true;
                    soLan = (int)targetRow["so_lan"];
                }
                else
                {
                    soLan = 2;
                }
            }
            else if (table.Rows.Count == 2)
            {
                targetRow = table.Rows[1];
                if (!isSuccessful(targetRow))
                {
                    MessageBox.Show("4");
                    isUpdate = true;
                    soLan = (int)targetRow["so_lan"];
                }
                else
                {
                    throw new InvalidOperationException("Phiếu dự thi đã có 2 phiếu gia hạn thành công.");
                }
            }
            else
            {
                throw new InvalidOperationException("Số lượng phiếu gia hạn không hợp lệ.");
            }

            string maPhieu = isUpdate ? targetRow["ma_phieu_gia_han"].ToString() : phieuGiaHanDAO.getNextMaPhieuGiaHan().ToString();
            int maKyThiCuVal = isUpdate ? (int)targetRow["ma_ky_thi_cu"] : int.Parse(maKyThiCu);
            int maKyThiMoiVal = int.Parse(maKyThiMoi);
            DateTime thoiGianGiaHan = DateTime.Now;
            double phiGiaHan = dacBiet ? 0 :
                double.Parse(new DanhSachChungChiDAO().getChungChiByMaChungChi(Convert.ToInt32(maChungChi))["gia_tien"].ToString()) * 0.2;
            bool trangThai = dacBiet;
            string lyDoVal = lyDo.Length > 0 ? lyDo : (isUpdate ? targetRow["ly_do"].ToString() : lyDo);
            bool truongHopDB = dacBiet;
            DateTime thoiGianThiMoiVal = DateTime.Parse(thoiGianThiMoi);
            //maNhanVienGiaHan = "1";
            int maNV = Convert.ToInt32(maNhanVienGiaHan);

            // Thực hiện hành động
            if (isUpdate)
            {
                phieuGiaHanDAO.updatePhieuGiaHan(
                    maPhieu, "", maPhieuDuThi, soLan, maKyThiCuVal, maKyThiMoiVal, thoiGianGiaHan, phiGiaHan,
                    trangThai, lyDoVal, truongHopDB, thoiGianThiMoiVal, maNV);
            }
            else
            {
                phieuGiaHanDAO.addPhieuGiaHan(
                    maPhieu, maPhieuDuThi, soLan, maKyThiCuVal, maKyThiMoiVal, thoiGianGiaHan, phiGiaHan,
                    trangThai, lyDoVal, truongHopDB, thoiGianThiMoiVal, maNV);
            }
        }
    }
}
