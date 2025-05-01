using WinFormsApp1.Properties;

namespace WinFormsApp1
{
    partial class GiaHan
    {
        System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GiaHan));
        private System.ComponentModel.IContainer components = null;
        private Label lblGiaHan;
        private DataGridView dgvDSThiSinh;
        private DataGridView dgvDSPhieuDuThi;
        private Button btnKTPhieuDuThiHopLe;
        private TextBox txtLyDo;
        private CheckBox chkTruongHopDB;
        private Button btnCungCapLichThi;
        private Button btnLuuThongTin;
        private Label lblLichThiDaChon;
        private Panel scrollablePanel;
        private Button btnXoaLichThiDaChon;
        private Label lblDSLichThi;
        private Label lblDSThiSinh;
        private TextBox txtSearch;
        private Label lblSearch;
        private Button btnSearch;
        private Button btnReturn;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GiaHan));
            lblGiaHan = new Label();
            dgvDSThiSinh = new DataGridView();
            dgvDSPhieuDuThi = new DataGridView();
            btnKTPhieuDuThiHopLe = new Button();
            txtLyDo = new TextBox();
            chkTruongHopDB = new CheckBox();
            btnCungCapLichThi = new Button();
            btnLuuThongTin = new Button();
            lblLichThiDaChon = new Label();
            scrollablePanel = new Panel();
            btnReturn = new Button();
            btnSearch = new Button();
            txtSearch = new TextBox();
            lblSearch = new Label();
            lblDSThiSinh = new Label();
            lblDSLichThi = new Label();
            btnXoaLichThiDaChon = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvDSThiSinh).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvDSPhieuDuThi).BeginInit();
            scrollablePanel.SuspendLayout();
            SuspendLayout();
            // 
            // lblGiaHan
            // 
            lblGiaHan.AutoSize = true;
            lblGiaHan.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            lblGiaHan.Location = new Point(526, 9);
            lblGiaHan.Name = "lblGiaHan";
            lblGiaHan.Size = new Size(129, 41);
            lblGiaHan.TabIndex = 0;
            lblGiaHan.Text = "Gia Hạn";
            // 
            // dgvDSThiSinh
            // 
            dgvDSThiSinh.AllowUserToAddRows = false;
            dgvDSThiSinh.AllowUserToDeleteRows = false;
            dgvDSThiSinh.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvDSThiSinh.ColumnHeadersHeight = 29;
            dgvDSThiSinh.Font = new Font("Segoe UI", 10F);
            dgvDSThiSinh.Location = new Point(50, 112);
            dgvDSThiSinh.MultiSelect = false;
            dgvDSThiSinh.Name = "dgvDSThiSinh";
            dgvDSThiSinh.ReadOnly = true;
            dgvDSThiSinh.RowHeadersWidth = 51;
            dgvDSThiSinh.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvDSThiSinh.Size = new Size(1093, 248);
            dgvDSThiSinh.TabIndex = 1;
            dgvDSThiSinh.SelectionChanged += dgvDSThiSinh_SelectionChanged;
            // 
            // dgvDSPhieuDuThi
            // 
            dgvDSPhieuDuThi.AllowUserToAddRows = false;
            dgvDSPhieuDuThi.AllowUserToDeleteRows = false;
            dgvDSPhieuDuThi.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvDSPhieuDuThi.ColumnHeadersHeight = 29;
            dgvDSPhieuDuThi.Font = new Font("Segoe UI", 10F);
            dgvDSPhieuDuThi.Location = new Point(50, 449);
            dgvDSPhieuDuThi.MultiSelect = false;
            dgvDSPhieuDuThi.Name = "dgvDSPhieuDuThi";
            dgvDSPhieuDuThi.ReadOnly = true;
            dgvDSPhieuDuThi.RowHeadersWidth = 51;
            dgvDSPhieuDuThi.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvDSPhieuDuThi.Size = new Size(882, 204);
            dgvDSPhieuDuThi.TabIndex = 3;
            dgvDSPhieuDuThi.SelectionChanged += dgvDSPhieuDuThi_SelectionChanged;
            // 
            // btnKTPhieuDuThiHopLe
            // 
            btnKTPhieuDuThiHopLe.Font = new Font("Segoe UI", 10F);
            btnKTPhieuDuThiHopLe.Location = new Point(951, 385);
            btnKTPhieuDuThiHopLe.Name = "btnKTPhieuDuThiHopLe";
            btnKTPhieuDuThiHopLe.Size = new Size(191, 59);
            btnKTPhieuDuThiHopLe.TabIndex = 4;
            btnKTPhieuDuThiHopLe.Text = "Kiểm tra lịch gia hạn";
            btnKTPhieuDuThiHopLe.Click += btnKTPhieuDuThiHopLe_Click;
            // 
            // txtLyDo
            // 
            txtLyDo.Enabled = false;
            txtLyDo.Font = new Font("Segoe UI", 10F);
            txtLyDo.Location = new Point(951, 449);
            txtLyDo.Multiline = true;
            txtLyDo.Name = "txtLyDo";
            txtLyDo.Size = new Size(191, 153);
            txtLyDo.TabIndex = 5;
            txtLyDo.TextChanged += txtLyDo_TextChanged;
            // 
            // chkTruongHopDB
            // 
            chkTruongHopDB.Enabled = false;
            chkTruongHopDB.Font = new Font("Segoe UI", 10F);
            chkTruongHopDB.Location = new Point(951, 609);
            chkTruongHopDB.Name = "chkTruongHopDB";
            chkTruongHopDB.Size = new Size(191, 33);
            chkTruongHopDB.TabIndex = 7;
            chkTruongHopDB.Text = "Trường hợp đặc biệt";
            chkTruongHopDB.CheckedChanged += chkTruongHopDB_CheckedChanged;
            // 
            // btnCungCapLichThi
            // 
            btnCungCapLichThi.Enabled = false;
            btnCungCapLichThi.Font = new Font("Segoe UI", 10F);
            btnCungCapLichThi.Location = new Point(951, 648);
            btnCungCapLichThi.Name = "btnCungCapLichThi";
            btnCungCapLichThi.Size = new Size(191, 40);
            btnCungCapLichThi.TabIndex = 8;
            btnCungCapLichThi.Text = "Cung cấp lịch thi";
            btnCungCapLichThi.Click += btnCungCapLichThi_Click;
            // 
            // btnLuuThongTin
            // 
            btnLuuThongTin.Enabled = false;
            btnLuuThongTin.Font = new Font("Segoe UI", 10F);
            btnLuuThongTin.Location = new Point(485, 731);
            btnLuuThongTin.Name = "btnLuuThongTin";
            btnLuuThongTin.Size = new Size(191, 59);
            btnLuuThongTin.TabIndex = 10;
            btnLuuThongTin.Text = "Lưu thông tin";
            btnLuuThongTin.Click += btnLuuThongTin_Click;
            // 
            // lblLichThiDaChon
            // 
            lblLichThiDaChon.AutoSize = true;
            lblLichThiDaChon.Font = new Font("Segoe UI", 10F);
            lblLichThiDaChon.Location = new Point(50, 679);
            lblLichThiDaChon.Name = "lblLichThiDaChon";
            lblLichThiDaChon.Size = new Size(136, 23);
            lblLichThiDaChon.TabIndex = 6;
            lblLichThiDaChon.Text = "Lịch thi đã chọn:";
            // 
            // scrollablePanel
            // 
            scrollablePanel.AutoScroll = true;
            scrollablePanel.Controls.Add(btnReturn);
            scrollablePanel.Controls.Add(btnSearch);
            scrollablePanel.Controls.Add(txtSearch);
            scrollablePanel.Controls.Add(lblSearch);
            scrollablePanel.Controls.Add(lblDSThiSinh);
            scrollablePanel.Controls.Add(lblDSLichThi);
            scrollablePanel.Controls.Add(lblGiaHan);
            scrollablePanel.Controls.Add(dgvDSThiSinh);
            scrollablePanel.Controls.Add(dgvDSPhieuDuThi);
            scrollablePanel.Controls.Add(btnKTPhieuDuThiHopLe);
            scrollablePanel.Controls.Add(txtLyDo);
            scrollablePanel.Controls.Add(lblLichThiDaChon);
            scrollablePanel.Controls.Add(btnXoaLichThiDaChon);
            scrollablePanel.Controls.Add(chkTruongHopDB);
            scrollablePanel.Controls.Add(btnCungCapLichThi);
            scrollablePanel.Controls.Add(btnLuuThongTin);
            scrollablePanel.Location = new Point(0, 0);
            scrollablePanel.Name = "scrollablePanel";
            scrollablePanel.Size = new Size(1200, 803);
            scrollablePanel.TabIndex = 0;
            // 
            // btnReturn
            // 
            btnReturn.BackColor = Color.Transparent;
            btnReturn.BackgroundImage = (Image)resources.GetObject("btnReturn.BackgroundImage");
            btnReturn.BackgroundImageLayout = ImageLayout.Center;
            btnReturn.FlatStyle = FlatStyle.Flat;
            btnReturn.ForeColor = Color.Transparent;
            btnReturn.Location = new Point(50, 18);
            btnReturn.Margin = new Padding(3, 2, 3, 2);
            btnReturn.Name = "btnReturn";
            btnReturn.Size = new Size(40, 31);
            btnReturn.TabIndex = 19;
            btnReturn.UseVisualStyleBackColor = false;
            btnReturn.Click += btnReturn_Click;
            // 
            // btnSearch
            // 
            btnSearch.BackgroundImage = Resources.search;
            btnSearch.BackgroundImageLayout = ImageLayout.Center;
            btnSearch.Location = new Point(1104, 65);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(38, 41);
            btnSearch.TabIndex = 17;
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            // 
            // txtSearch
            // 
            txtSearch.Font = new Font("Segoe UI", 10F);
            txtSearch.Location = new Point(935, 65);
            txtSearch.Multiline = true;
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(162, 40);
            txtSearch.TabIndex = 16;
            txtSearch.KeyPress += txtSearch_KeyPress;
            // 
            // lblSearch
            // 
            lblSearch.AutoSize = true;
            lblSearch.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblSearch.Location = new Point(857, 73);
            lblSearch.Name = "lblSearch";
            lblSearch.Size = new Size(86, 23);
            lblSearch.TabIndex = 15;
            lblSearch.Text = "Tìm kiếm";
            // 
            // lblDSThiSinh
            // 
            lblDSThiSinh.AutoSize = true;
            lblDSThiSinh.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblDSThiSinh.Location = new Point(50, 73);
            lblDSThiSinh.Name = "lblDSThiSinh";
            lblDSThiSinh.Size = new Size(155, 23);
            lblDSThiSinh.TabIndex = 14;
            lblDSThiSinh.Text = "Danh sách thí sinh";
            // 
            // lblDSLichThi
            // 
            lblDSLichThi.AutoSize = true;
            lblDSLichThi.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblDSLichThi.Location = new Point(50, 404);
            lblDSLichThi.Name = "lblDSLichThi";
            lblDSLichThi.Size = new Size(151, 23);
            lblDSLichThi.TabIndex = 13;
            lblDSLichThi.Text = "Danh sách lịch thi";
            // 
            // btnXoaLichThiDaChon
            // 
            btnXoaLichThiDaChon.Enabled = false;
            btnXoaLichThiDaChon.Font = new Font("Segoe UI", 10F);
            btnXoaLichThiDaChon.Location = new Point(951, 693);
            btnXoaLichThiDaChon.Name = "btnXoaLichThiDaChon";
            btnXoaLichThiDaChon.Size = new Size(191, 32);
            btnXoaLichThiDaChon.TabIndex = 11;
            btnXoaLichThiDaChon.Text = "Xóa Lịch Thi";
            btnXoaLichThiDaChon.Click += btnXoaLichThiDaChon_Click;
            // 
            // GiaHan
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(scrollablePanel);
            Name = "GiaHan";
            Size = new Size(1200, 800);
            ((System.ComponentModel.ISupportInitialize)dgvDSThiSinh).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvDSPhieuDuThi).EndInit();
            scrollablePanel.ResumeLayout(false);
            scrollablePanel.PerformLayout();
            ResumeLayout(false);
        }
    }
}