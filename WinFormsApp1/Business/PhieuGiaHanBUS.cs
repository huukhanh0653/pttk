using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.Data;
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
            return phieuGiaHanDAO.getPhieuGiaHanByMaPhieuDuThi(Convert.ToInt32(maPhieuDuThi));
        }

        public bool is2TimesAlready(string maPhieuDuThi)
        {
            DataTable table = this.getPhieuGiaHanByMaPhieuDuThi(maPhieuDuThi);
            if (table.Rows.Count > 1 && int.Parse(table.Rows[0]["ma_thanh_toan"].ToString()) > 0 
                && int.Parse(table.Rows[1]["ma_thanh_toan"].ToString()) > 0)
                return true;
            return false;
        }

        public bool kiemTraDieuKienGiaHan(string maPhieuDuThi, string maKyThiHienTai, string maKyThiMoi)
        {
            if (maPhieuDuThi.IsNullOrEmpty() || maKyThiHienTai.IsNullOrEmpty() || maKyThiMoi.IsNullOrEmpty())
            {
                throw new ArgumentException("One or more required parameters are null or empty.");
            }

            KyThiBUS kythiMoi = new KyThiBUS(maKyThiMoi);
            KyThiBUS kyThiHienTai = new KyThiBUS(maKyThiHienTai);

            if (is2TimesAlready(maPhieuDuThi)) return false;
            if (kythiMoi.isFull()) return false;
            if (!kythiMoi.isEarlyAtLeast24h()) return false;

            return true;
        }

        public void addPhieuGiaHan(string maPhieuDuThi, string maKyThiCu, string maKyThiMoi,
            string lyDo, string thoiGianThiMoi, int maNhanVienGiaHan)
        {
            
        }
    }
}
