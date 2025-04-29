namespace WinFormsApp1
{
    partial class ChiTietPhieuDangKy
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblMaPhieu = new Label();
            lblNgayDK = new Label();
            lblLoaiDK = new Label();
            lblHoTen = new Label();
            lblSDT = new Label();
            lblEmail = new Label();
            label7 = new Label();
            lblTongTien = new Label();
            txtboxSDT = new TextBox();
            txtboxNgayDK = new TextBox();
            txtboxLoaiDK = new TextBox();
            txtboxMaPhieuDk = new TextBox();
            txtboxHoTen = new TextBox();
            txtboxEmail = new TextBox();
            txtboxTongTien = new TextBox();
            dgvThiSinh = new DataGridView();
            btnTroVe = new Button();
            btnThanhToan = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvThiSinh).BeginInit();
            SuspendLayout();
            // 
            // lblMaPhieu
            // 
            lblMaPhieu.AutoSize = true;
            lblMaPhieu.Location = new Point(96, 37);
            lblMaPhieu.Name = "lblMaPhieu";
            lblMaPhieu.Size = new Size(102, 15);
            lblMaPhieu.TabIndex = 0;
            lblMaPhieu.Text = "Mã phiếu đăng ký";
            // 
            // lblNgayDK
            // 
            lblNgayDK.AutoSize = true;
            lblNgayDK.Location = new Point(433, 37);
            lblNgayDK.Name = "lblNgayDK";
            lblNgayDK.Size = new Size(80, 15);
            lblNgayDK.TabIndex = 1;
            lblNgayDK.Text = "Ngày đăng ký";
            // 
            // lblLoaiDK
            // 
            lblLoaiDK.AutoSize = true;
            lblLoaiDK.Location = new Point(738, 37);
            lblLoaiDK.Name = "lblLoaiDK";
            lblLoaiDK.Size = new Size(74, 15);
            lblLoaiDK.TabIndex = 2;
            lblLoaiDK.Text = "Loại đăng ký";
            // 
            // lblHoTen
            // 
            lblHoTen.AutoSize = true;
            lblHoTen.Location = new Point(96, 114);
            lblHoTen.Name = "lblHoTen";
            lblHoTen.Size = new Size(122, 15);
            lblHoTen.TabIndex = 3;
            lblHoTen.Text = "Họ tên người đăng ký";
            // 
            // lblSDT
            // 
            lblSDT.AutoSize = true;
            lblSDT.Location = new Point(433, 114);
            lblSDT.Name = "lblSDT";
            lblSDT.Size = new Size(107, 15);
            lblSDT.TabIndex = 4;
            lblSDT.Text = "SĐT người đăng ký";
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Location = new Point(738, 114);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(115, 15);
            lblEmail.TabIndex = 5;
            lblEmail.Text = "Email người đăng ký";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(127, 178);
            label7.Name = "label7";
            label7.Size = new Size(104, 15);
            label7.TabIndex = 6;
            label7.Text = "Danh sách thí sinh";
            // 
            // lblTongTien
            // 
            lblTongTien.AutoSize = true;
            lblTongTien.Location = new Point(96, 438);
            lblTongTien.Name = "lblTongTien";
            lblTongTien.Size = new Size(93, 15);
            lblTongTien.TabIndex = 7;
            lblTongTien.Text = "Tổng tiền (VNĐ)";
            // 
            // txtboxSDT
            // 
            txtboxSDT.Location = new Point(433, 138);
            txtboxSDT.Margin = new Padding(3, 2, 3, 2);
            txtboxSDT.Name = "txtboxSDT";
            txtboxSDT.Size = new Size(206, 23);
            txtboxSDT.TabIndex = 8;
            // 
            // txtboxNgayDK
            // 
            txtboxNgayDK.Location = new Point(433, 63);
            txtboxNgayDK.Margin = new Padding(3, 2, 3, 2);
            txtboxNgayDK.Name = "txtboxNgayDK";
            txtboxNgayDK.Size = new Size(206, 23);
            txtboxNgayDK.TabIndex = 9;
            // 
            // txtboxLoaiDK
            // 
            txtboxLoaiDK.Location = new Point(738, 63);
            txtboxLoaiDK.Margin = new Padding(3, 2, 3, 2);
            txtboxLoaiDK.Name = "txtboxLoaiDK";
            txtboxLoaiDK.Size = new Size(232, 23);
            txtboxLoaiDK.TabIndex = 10;
            // 
            // txtboxMaPhieuDk
            // 
            txtboxMaPhieuDk.Location = new Point(96, 63);
            txtboxMaPhieuDk.Margin = new Padding(3, 2, 3, 2);
            txtboxMaPhieuDk.Name = "txtboxMaPhieuDk";
            txtboxMaPhieuDk.Size = new Size(171, 23);
            txtboxMaPhieuDk.TabIndex = 11;
            // 
            // txtboxHoTen
            // 
            txtboxHoTen.Location = new Point(96, 138);
            txtboxHoTen.Margin = new Padding(3, 2, 3, 2);
            txtboxHoTen.Name = "txtboxHoTen";
            txtboxHoTen.Size = new Size(246, 23);
            txtboxHoTen.TabIndex = 12;
            // 
            // txtboxEmail
            // 
            txtboxEmail.Location = new Point(738, 138);
            txtboxEmail.Margin = new Padding(3, 2, 3, 2);
            txtboxEmail.Name = "txtboxEmail";
            txtboxEmail.Size = new Size(232, 23);
            txtboxEmail.TabIndex = 13;
            // 
            // txtboxTongTien
            // 
            txtboxTongTien.Location = new Point(96, 459);
            txtboxTongTien.Margin = new Padding(3, 2, 3, 2);
            txtboxTongTien.Name = "txtboxTongTien";
            txtboxTongTien.Size = new Size(874, 23);
            txtboxTongTien.TabIndex = 15;
            // 
            // dgvThiSinh
            // 
            dgvThiSinh.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvThiSinh.Location = new Point(96, 198);
            dgvThiSinh.Margin = new Padding(3, 2, 3, 2);
            dgvThiSinh.Name = "dgvThiSinh";
            dgvThiSinh.RowHeadersWidth = 51;
            dgvThiSinh.Size = new Size(874, 215);
            dgvThiSinh.TabIndex = 16;
            // 
            // btnTroVe
            // 
            btnTroVe.Location = new Point(343, 512);
            btnTroVe.Margin = new Padding(3, 2, 3, 2);
            btnTroVe.Name = "btnTroVe";
            btnTroVe.Size = new Size(156, 38);
            btnTroVe.TabIndex = 17;
            btnTroVe.Text = "Trở về";
            btnTroVe.UseVisualStyleBackColor = true;
            btnTroVe.Click += btnTroVe_Click;
            // 
            // btnThanhToan
            // 
            btnThanhToan.Location = new Point(568, 512);
            btnThanhToan.Margin = new Padding(3, 2, 3, 2);
            btnThanhToan.Name = "btnThanhToan";
            btnThanhToan.Size = new Size(203, 38);
            btnThanhToan.TabIndex = 18;
            btnThanhToan.Text = "Tiếp tục thanh toán";
            btnThanhToan.UseVisualStyleBackColor = true;
            btnThanhToan.Click += btnThanhToan_Click;
            // 
            // ChiTietPhieuDangKy
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(btnThanhToan);
            Controls.Add(btnTroVe);
            Controls.Add(dgvThiSinh);
            Controls.Add(txtboxTongTien);
            Controls.Add(txtboxEmail);
            Controls.Add(txtboxHoTen);
            Controls.Add(txtboxMaPhieuDk);
            Controls.Add(txtboxLoaiDK);
            Controls.Add(txtboxNgayDK);
            Controls.Add(txtboxSDT);
            Controls.Add(lblTongTien);
            Controls.Add(label7);
            Controls.Add(lblEmail);
            Controls.Add(lblSDT);
            Controls.Add(lblHoTen);
            Controls.Add(lblLoaiDK);
            Controls.Add(lblNgayDK);
            Controls.Add(lblMaPhieu);
            Margin = new Padding(3, 2, 3, 2);
            Name = "ChiTietPhieuDangKy";
            Size = new Size(1050, 600);
            ((System.ComponentModel.ISupportInitialize)dgvThiSinh).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblMaPhieu;
        private Label lblNgayDK;
        private Label lblLoaiDK;
        private Label lblHoTen;
        private Label lblSDT;
        private Label lblEmail;
        private Label label7;
        private Label lblTongTien;
        private TextBox txtboxSDT;
        private TextBox txtboxNgayDK;
        private TextBox txtboxLoaiDK;
        private TextBox txtboxMaPhieuDk;
        private TextBox txtboxHoTen;
        private TextBox txtboxEmail;
        private TextBox txtboxTongTien;
        private DataGridView dgvThiSinh;
        private Button btnTroVe;
        private Button btnThanhToan;
    }
}
