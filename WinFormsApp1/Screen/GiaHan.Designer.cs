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
            button2 = new Button();
            txtSearch = new TextBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            btnClear = new Button();
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
            lblGiaHan.Location = new Point(466, 13);
            lblGiaHan.Name = "lblGiaHan";
            lblGiaHan.Size = new Size(104, 32);
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
            dgvDSThiSinh.Location = new Point(44, 84);
            dgvDSThiSinh.Margin = new Padding(3, 2, 3, 2);
            dgvDSThiSinh.MultiSelect = false;
            dgvDSThiSinh.Name = "dgvDSThiSinh";
            dgvDSThiSinh.ReadOnly = true;
            dgvDSThiSinh.RowHeadersWidth = 51;
            dgvDSThiSinh.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvDSThiSinh.Size = new Size(956, 186);
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
            dgvDSPhieuDuThi.Location = new Point(43, 306);
            dgvDSPhieuDuThi.Margin = new Padding(3, 2, 3, 2);
            dgvDSPhieuDuThi.MultiSelect = false;
            dgvDSPhieuDuThi.Name = "dgvDSPhieuDuThi";
            dgvDSPhieuDuThi.ReadOnly = true;
            dgvDSPhieuDuThi.RowHeadersWidth = 51;
            dgvDSPhieuDuThi.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvDSPhieuDuThi.Size = new Size(772, 153);
            dgvDSPhieuDuThi.TabIndex = 3;
            dgvDSPhieuDuThi.SelectionChanged += dgvDSPhieuDuThi_SelectionChanged;
            // 
            // btnKTPhieuDuThiHopLe
            // 
            btnKTPhieuDuThiHopLe.Font = new Font("Segoe UI", 10F);
            btnKTPhieuDuThiHopLe.Location = new Point(833, 281);
            btnKTPhieuDuThiHopLe.Margin = new Padding(3, 2, 3, 2);
            btnKTPhieuDuThiHopLe.Name = "btnKTPhieuDuThiHopLe";
            btnKTPhieuDuThiHopLe.Size = new Size(167, 44);
            btnKTPhieuDuThiHopLe.TabIndex = 4;
            btnKTPhieuDuThiHopLe.Text = "Kiểm tra lịch gia hạn";
            btnKTPhieuDuThiHopLe.Click += btnKTPhieuDuThiHopLe_Click;
            // 
            // txtLyDo
            // 
            txtLyDo.Font = new Font("Segoe UI", 10F);
            txtLyDo.Location = new Point(833, 329);
            txtLyDo.Margin = new Padding(3, 2, 3, 2);
            txtLyDo.Multiline = true;
            txtLyDo.Name = "txtLyDo";
            txtLyDo.Size = new Size(168, 116);
            txtLyDo.TabIndex = 5;
            txtLyDo.TextChanged += txtLyDo_TextChanged;
            // 
            // chkTruongHopDB
            // 
            chkTruongHopDB.Font = new Font("Segoe UI", 10F);
            chkTruongHopDB.Location = new Point(833, 449);
            chkTruongHopDB.Margin = new Padding(3, 2, 3, 2);
            chkTruongHopDB.Name = "chkTruongHopDB";
            chkTruongHopDB.Size = new Size(167, 25);
            chkTruongHopDB.TabIndex = 7;
            chkTruongHopDB.Text = "Trường hợp đặc biệt";
            chkTruongHopDB.CheckedChanged += chkTruongHopDB_CheckedChanged;
            // 
            // btnCungCapLichThi
            // 
            btnCungCapLichThi.Font = new Font("Segoe UI", 10F);
            btnCungCapLichThi.Location = new Point(833, 478);
            btnCungCapLichThi.Margin = new Padding(3, 2, 3, 2);
            btnCungCapLichThi.Name = "btnCungCapLichThi";
            btnCungCapLichThi.Size = new Size(167, 30);
            btnCungCapLichThi.TabIndex = 8;
            btnCungCapLichThi.Text = "Cung cấp lịch thi";
            btnCungCapLichThi.Click += btnCungCapLichThi_Click;
            // 
            // btnThanhToan
            // 
            btnThanhToan.Enabled = false;
            btnThanhToan.Font = new Font("Segoe UI", 10F);
            btnThanhToan.Location = new Point(833, 540);
            btnThanhToan.Margin = new Padding(3, 2, 3, 2);
            btnThanhToan.Name = "btnThanhToan";
            btnThanhToan.Size = new Size(167, 44);
            btnThanhToan.TabIndex = 9;
            btnThanhToan.Text = "Thanh Toán";
            btnThanhToan.Visible = false;
            btnThanhToan.Click += btnThanhToan_Click;
            // 
            // btnLuuThongTin
            // 
            btnLuuThongTin.Font = new Font("Segoe UI", 10F);
            btnLuuThongTin.Location = new Point(423, 528);
            btnLuuThongTin.Margin = new Padding(3, 2, 3, 2);
            btnLuuThongTin.Name = "btnLuuThongTin";
            btnLuuThongTin.Size = new Size(167, 44);
            btnLuuThongTin.TabIndex = 10;
            btnLuuThongTin.Text = "Lưu thông tin";
            btnLuuThongTin.Click += btnLuuThongTin_Click;
            // 
            // lblLichThiDaChon
            // 
            lblLichThiDaChon.AutoSize = true;
            lblLichThiDaChon.Font = new Font("Segoe UI", 10F);
            lblLichThiDaChon.Location = new Point(43, 489);
            lblLichThiDaChon.Name = "lblLichThiDaChon";
            lblLichThiDaChon.Size = new Size(109, 19);
            lblLichThiDaChon.TabIndex = 6;
            lblLichThiDaChon.Text = "Lịch thi đã chọn:";
            // 
            // scrollablePanel
            // 
            scrollablePanel.AutoScroll = true;
            scrollablePanel.Controls.Add(button2);
            scrollablePanel.Controls.Add(txtSearch);
            scrollablePanel.Controls.Add(label3);
            scrollablePanel.Controls.Add(label2);
            scrollablePanel.Controls.Add(label1);
            scrollablePanel.Controls.Add(btnClear);
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
            scrollablePanel.Margin = new Padding(3, 2, 3, 2);
            scrollablePanel.Name = "scrollablePanel";
            scrollablePanel.Size = new Size(1050, 602);
            scrollablePanel.TabIndex = 0;
            // 
            // button2
            // 
            button2.BackgroundImage = Properties.Resources.search;
            button2.BackgroundImageLayout = ImageLayout.Center;
            button2.Location = new Point(967, 44);
            button2.Margin = new Padding(3, 2, 3, 2);
            button2.Name = "button2";
            button2.Size = new Size(33, 31);
            button2.TabIndex = 17;
            button2.UseVisualStyleBackColor = true;
            // 
            // txtSearch
            // 
            txtSearch.Font = new Font("Segoe UI", 10F);
            txtSearch.Location = new Point(819, 44);
            txtSearch.Margin = new Padding(3, 2, 3, 2);
            txtSearch.Multiline = true;
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(142, 31);
            txtSearch.TabIndex = 16;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(751, 50);
            label3.Name = "label3";
            label3.Size = new Size(66, 17);
            label3.TabIndex = 15;
            label3.Text = "Tìm kiếm";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(44, 55);
            label2.Name = "label2";
            label2.Size = new Size(123, 17);
            label2.TabIndex = 14;
            label2.Text = "Danh sách thí sinh";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(41, 286);
            label1.Name = "label1";
            label1.Size = new Size(119, 17);
            label1.TabIndex = 13;
            label1.Text = "Danh sách lịch thi";
            label1.Click += label1_Click;
            // 
            // btnClear
            // 
            btnClear.Font = new Font("Segoe UI", 10F);
            btnClear.Location = new Point(43, 528);
            btnClear.Margin = new Padding(3, 2, 3, 2);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(119, 44);
            btnClear.TabIndex = 12;
            btnClear.Text = "Xóa";
            // 
            // btnXoaLichThiDaChon
            // 
            btnXoaLichThiDaChon.Font = new Font("Segoe UI", 10F);
            btnXoaLichThiDaChon.Location = new Point(833, 512);
            btnXoaLichThiDaChon.Margin = new Padding(3, 2, 3, 2);
            btnXoaLichThiDaChon.Name = "btnXoaLichThiDaChon";
            btnXoaLichThiDaChon.Size = new Size(167, 24);
            btnXoaLichThiDaChon.TabIndex = 11;
            btnXoaLichThiDaChon.Text = "Xóa Lịch Thi";
            btnXoaLichThiDaChon.Click += btnXoaLichThiDaChon_Click;
            // 
            // GiaHan
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(scrollablePanel);
            Margin = new Padding(3, 2, 3, 2);
            Name = "GiaHan";
            Size = new Size(1050, 600);
            ((System.ComponentModel.ISupportInitialize)dgvDSThiSinh).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvDSPhieuDuThi).EndInit();
            scrollablePanel.ResumeLayout(false);
            scrollablePanel.PerformLayout();
            ResumeLayout(false);
        }

        private Button btnClear;
        private Label label1;
        private Label label2;
        private TextBox txtSearch;
        private Label label3;
        private Button button2;
    }
}
