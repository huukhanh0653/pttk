namespace WinFormsApp1
{
    partial class GiaHan
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Label lblGiaHan;
        private System.Windows.Forms.DataGridView dgvDSThiSinh;
        private System.Windows.Forms.DataGridView dgvDSPhieuDuThi;
        private System.Windows.Forms.Button btnKTPhieuDuThiHopLe;
        private System.Windows.Forms.TextBox txtLyDo;
        private System.Windows.Forms.CheckBox chkTruongHopDB;
        private System.Windows.Forms.Button btnCungCapLichThi;
        private System.Windows.Forms.Button btnThanhToan;
        private System.Windows.Forms.Button btnLuuThongTin;
        private System.Windows.Forms.Label lblLichThiDaChon;
        private System.Windows.Forms.Panel scrollablePanel;
        private System.Windows.Forms.Button btnXoaLichThiDaChon;

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
            lblGiaHan = new Label();
            dgvDSThiSinh = new DataGridView();
            dgvDSPhieuDuThi = new DataGridView();
            btnKTPhieuDuThiHopLe = new Button();
            txtLyDo = new TextBox();
            chkTruongHopDB = new CheckBox();
            btnCungCapLichThi = new Button();
            btnThanhToan = new Button();
            btnLuuThongTin = new Button();
            lblLichThiDaChon = new Label();
            scrollablePanel = new Panel();
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
            dgvDSThiSinh.Location = new Point(50, 70);
            dgvDSThiSinh.MultiSelect = false;
            dgvDSThiSinh.Name = "dgvDSThiSinh";
            dgvDSThiSinh.ReadOnly = true;
            dgvDSThiSinh.RowHeadersWidth = 51;
            dgvDSThiSinh.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvDSThiSinh.Size = new Size(1092, 250);
            dgvDSThiSinh.TabIndex = 1;
            dgvDSThiSinh.SelectionChanged += dgvDSThiSinh_SelectionChanged;
            // 
            // dgvDSPhieuDuThi
            // 
            dgvDSPhieuDuThi.AllowUserToAddRows = false;
            dgvDSPhieuDuThi.AllowUserToDeleteRows = false;
            dgvDSPhieuDuThi.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvDSPhieuDuThi.ColumnHeadersHeight = 29;
            dgvDSPhieuDuThi.Font = new System.Drawing.Font("Segoe UI", 10F);
            dgvDSPhieuDuThi.Location = new Point(50, 350);
            dgvDSPhieuDuThi.MultiSelect = false;
            dgvDSPhieuDuThi.Name = "dgvDSPhieuDuThi";
            dgvDSPhieuDuThi.ReadOnly = true;
            dgvDSPhieuDuThi.RowHeadersWidth = 51;
            dgvDSPhieuDuThi.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvDSPhieuDuThi.Size = new Size(882, 304);
            dgvDSPhieuDuThi.TabIndex = 3;
            dgvDSPhieuDuThi.Visible = false;
            dgvDSPhieuDuThi.SelectionChanged += dgvDSPhieuDuThi_SelectionChanged;
            // 
            // btnKTPhieuDuThiHopLe
            // 
            btnKTPhieuDuThiHopLe.Font = new Font("Segoe UI", 10F);
            btnKTPhieuDuThiHopLe.Location = new Point(951, 350);
            btnKTPhieuDuThiHopLe.Name = "btnKTPhieuDuThiHopLe";
            btnKTPhieuDuThiHopLe.Size = new Size(191, 59);
            btnKTPhieuDuThiHopLe.TabIndex = 4;
            btnKTPhieuDuThiHopLe.Text = "Kiểm tra lịch gia hạn";
            btnKTPhieuDuThiHopLe.Visible = false;
            btnKTPhieuDuThiHopLe.Click += btnKTPhieuDuThiHopLe_Click;
            // 
            // txtLyDo
            // 
            txtLyDo.Font = new Font("Segoe UI", 10F);
            txtLyDo.Location = new Point(951, 415);
            txtLyDo.Multiline = true;
            txtLyDo.Name = "txtLyDo";
            txtLyDo.Size = new Size(191, 154);
            txtLyDo.TabIndex = 5;
            txtLyDo.Visible = false;
            txtLyDo.TextChanged += txtLyDo_TextChanged;
            // 
            // chkTruongHopDB
            // 
            chkTruongHopDB.Font = new Font("Segoe UI", 10F);
            chkTruongHopDB.Location = new Point(951, 575);
            chkTruongHopDB.Name = "chkTruongHopDB";
            chkTruongHopDB.Size = new Size(191, 33);
            chkTruongHopDB.TabIndex = 7;
            chkTruongHopDB.Text = "Trường hợp đặc biệt";
            chkTruongHopDB.Visible = false;
            chkTruongHopDB.CheckedChanged += chkTruongHopDB_CheckedChanged;
            // 
            // btnCungCapLichThi
            // 
            btnCungCapLichThi.Font = new Font("Segoe UI", 10F);
            btnCungCapLichThi.Location = new Point(951, 614);
            btnCungCapLichThi.Name = "btnCungCapLichThi";
            btnCungCapLichThi.Size = new Size(191, 40);
            btnCungCapLichThi.TabIndex = 8;
            btnCungCapLichThi.Text = "Cung cấp lịch thi";
            btnCungCapLichThi.Visible = false;
            btnCungCapLichThi.Click += btnCungCapLichThi_Click;
            // =
            // btnThanhToan
            // 
            btnThanhToan.Font = new Font("Segoe UI", 10F);
            btnThanhToan.Location = new Point(951, 730);
            btnThanhToan.Name = "btnThanhToan";
            btnThanhToan.Size = new Size(191, 58);
            btnThanhToan.TabIndex = 9;
            btnThanhToan.Text = "Thanh Toán";
            btnThanhToan.Visible = false;
            btnThanhToan.Click += btnThanhToan_Click;
            // 
            // btnLuuThongTin
            // 
            btnLuuThongTin.Font = new Font("Segoe UI", 10F);
            btnLuuThongTin.Location = new Point(484, 730);
            btnLuuThongTin.Name = "btnLuuThongTin";
            btnLuuThongTin.Size = new Size(191, 58);
            btnLuuThongTin.TabIndex = 10;
            btnLuuThongTin.Text = "Luu Thông Tin";
            btnLuuThongTin.Visible = false;
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
            lblLichThiDaChon.Visible = false;
            // 
            // scrollablePanel
            // 
            scrollablePanel.AutoScroll = true;
            scrollablePanel.Controls.Add(lblGiaHan);
            scrollablePanel.Controls.Add(dgvDSThiSinh);
            scrollablePanel.Controls.Add(dgvDSPhieuDuThi);
            scrollablePanel.Controls.Add(btnKTPhieuDuThiHopLe);
            scrollablePanel.Controls.Add(txtLyDo);
            scrollablePanel.Controls.Add(lblLichThiDaChon);
            scrollablePanel.Controls.Add(btnXoaLichThiDaChon);
            scrollablePanel.Controls.Add(chkTruongHopDB);
            scrollablePanel.Controls.Add(btnCungCapLichThi);
            scrollablePanel.Controls.Add(btnThanhToan);
            scrollablePanel.Controls.Add(btnLuuThongTin);
            scrollablePanel.Location = new Point(0, 0);
            scrollablePanel.Name = "scrollablePanel";
            scrollablePanel.Size = new Size(1159, 803);
            scrollablePanel.TabIndex = 0;
            // 
            // btnXoaLichThiDaChon
            // 
            btnXoaLichThiDaChon.Font = new Font("Segoe UI", 10F);
            btnXoaLichThiDaChon.Location = new Point(951, 670);
            btnXoaLichThiDaChon.Name = "btnXoaLichThiDaChon";
            btnXoaLichThiDaChon.Size = new Size(191, 32);
            btnXoaLichThiDaChon.TabIndex = 11;
            btnXoaLichThiDaChon.Text = "Xóa Lịch Thi";
            btnXoaLichThiDaChon.Visible = false;
            btnXoaLichThiDaChon.Click += btnXoaLichThiDaChon_Click;
            // 
            // MHGiaHan
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1200, 800);
            Controls.Add(scrollablePanel);
            Name = "MHGiaHan";
            //StartPosition = FormStartPosition.CenterScreen;
            Text = "Chức Năng Gia Hạn";
            ((System.ComponentModel.ISupportInitialize)dgvDSThiSinh).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvDSPhieuDuThi).EndInit();
            scrollablePanel.ResumeLayout(false);
            scrollablePanel.PerformLayout();
            ResumeLayout(false);
        }
    }
}
