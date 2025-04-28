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
            DataTable table = this.getPhieuGiaHanByMaPhieuDuThi(maPhieuDuThi);
            if (table.Rows.Count > 1)
            {
                if (int.TryParse(table.Rows[0]["ma_thanh_toan"]?.ToString(), out int value1) && value1 > 0 &&
                    int.TryParse(table.Rows[1]["ma_thanh_toan"]?.ToString(), out int value2) && value2 > 0)
                {
                    return true;
                }
            }
            return false;
        }

        public bool kiemTraDieuKienGiaHan(string maPhieuDuThi, string maKyThiHienTai, string maKyThiMoi)
        {
            if (maPhieuDuThi.IsNullOrEmpty() || maKyThiHienTai.IsNullOrEmpty() || maKyThiMoi.IsNullOrEmpty())
            {
                return false;
            }

            KyThiBUS kythiMoi = new KyThiBUS(maKyThiMoi);
            KyThiBUS kyThiHienTai = new KyThiBUS(maKyThiHienTai);

            Debug.WriteLine("kiemTraDieuKienGiaHan");

            if (is2TimesAlready(maPhieuDuThi)) return false;
            if (kythiMoi.isFull()) return false;
            if (!kythiMoi.isEarlyAtLeast24h()) return false;

            return true;
        }

        public void addPhieuGiaHan(string maPhieuDuThi, string maKyThiCu, string maKyThiMoi,
            string lyDo, string thoiGianThiMoi, string maNhanVienGiaHan, bool dacBiet, string maChungChi)
        {
            DataTable table = phieuGiaHanDAO.getPhieuGiaHanByMaPhieuDuThi(Convert.ToInt32(maPhieuDuThi));
            Debug.WriteLine("table.Rows.Count: " + table.Rows.Count);
            if (table.Rows.Count == 2 && (table.Rows[1]["ma_thanh_toan"] == null || table.Rows[1]["ma_thanh_toan"] == DBNull.Value))
            {
                string _maPhieu = table.Rows[1]["ma_phieu_gia_han"].ToString();
                string _maThanhToan = table.Rows[1]["ma_thanh_toan"].ToString();
                string _maPhieuDuThi = table.Rows[1]["ma_phieu_du_thi"].ToString();
                string _soLan = table.Rows[1]["so_lan"].ToString();
                string _maKyThiCu = table.Rows[1]["ma_ky_thi_cu"].ToString();
                string _maKyThiMoi = maKyThiMoi;
                string _thoiGianGiaHan = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
                string _lyDo = lyDo.Length > 0 ? lyDo : table.Rows[1]["ly_do"].ToString();
                string _truongHopDB = table.Rows[1]["th_dac_biet"].ToString().ToLower() == "true" ?
                    table.Rows[1]["th_dac_biet"].ToString().ToLower() : dacBiet.ToString().ToLower();
                string _thoiGianThiMoi = thoiGianThiMoi;
                string _maNV = maNhanVienGiaHan;
                string _phiGiaHan = table.Rows[1]["phi_gia_han"].ToString();

                phieuGiaHanDAO.updatePhieuGiaHan(_maPhieu, _maThanhToan, maPhieuDuThi, int.Parse(_soLan) + 1,
                int.Parse(_maKyThiCu), int.Parse(_maKyThiMoi), DateTime.Parse(_thoiGianGiaHan), double.Parse(_phiGiaHan),
                true, _lyDo, bool.Parse(_truongHopDB), DateTime.Parse(_thoiGianThiMoi), int.Parse(_maNV));
            }

            else if (table.Rows.Count < 2)
            {
                string _maPhieu = phieuGiaHanDAO.getNextMaPhieuGiaHan().ToString();
                string _maPhieuDuThi = maPhieuDuThi;
                int _soLan = table.Rows.Count + 1;
                string _maKyThiCu = maKyThiCu;
                string _maKyThiMoi = maKyThiMoi;
                DateTime _thoiGianGiaHan = DateTime.Now;
                string _lyDo = lyDo;
                string _truongHopDB = dacBiet.ToString().ToLower();
                string _thoiGianThiMoi = thoiGianThiMoi;
                string _maNV = maNhanVienGiaHan;
                double _phiGiaHan = _truongHopDB == "true"? 
                0 : double.Parse(new DanhSachChungChiDAO().getChungChiByMaChungChi(Convert.ToInt32(maChungChi))["gia_tien"].ToString()) * 0.2;

                phieuGiaHanDAO.addPhieuGiaHan(_maPhieu, maPhieuDuThi, _soLan,
                    int.Parse(_maKyThiCu), int.Parse(_maKyThiMoi), _thoiGianGiaHan, _phiGiaHan,
                    false, _lyDo, bool.Parse(_truongHopDB), DateTime.Parse(_thoiGianThiMoi), int.Parse(_maNV));

            }

            else return;
        }
    }
}
