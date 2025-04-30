namespace WinFormsApp1
{
    partial class XacNhanThanhToan
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
            btnHuy = new Button();
            lblLoaiThanhToan = new Label();
            btnThanhToan = new Button();
            lblHinhThuc = new Label();
            lblTongTien = new Label();
            lblSoTienCanThanhToan = new Label();
            lblGiamGia = new Label();
            lblMaGiaoDich = new Label();
            lblNgayThanhToan = new Label();
            txtboxLoaiThanhToan = new TextBox();
            txtBoxNgayThanhToan = new TextBox();
            txtboxTongTien = new TextBox();
            txtboxGiamGia = new TextBox();
            txtboxMaGiaoDich = new TextBox();
            txtboxSoTienThanhToan = new TextBox();
            cbboxHinhThuc = new ComboBox();
            SuspendLayout();
            // 
            // btnHuy
            // 
            btnHuy.Location = new Point(326, 431);
            btnHuy.Margin = new Padding(3, 2, 3, 2);
            btnHuy.Name = "btnHuy";
            btnHuy.Size = new Size(191, 36);
            btnHuy.TabIndex = 0;
            btnHuy.Text = "Hủy";
            btnHuy.UseVisualStyleBackColor = true;
            btnHuy.Click += btnHuy_Click;
            // 
            // lblLoaiThanhToan
            // 
            lblLoaiThanhToan.AutoSize = true;
            lblLoaiThanhToan.Location = new Point(72, 74);
            lblLoaiThanhToan.Name = "lblLoaiThanhToan";
            lblLoaiThanhToan.Size = new Size(90, 15);
            lblLoaiThanhToan.TabIndex = 1;
            lblLoaiThanhToan.Text = "Loại thanh toán";
            // 
            // btnThanhToan
            // 
            btnThanhToan.Location = new Point(575, 431);
            btnThanhToan.Margin = new Padding(3, 2, 3, 2);
            btnThanhToan.Name = "btnThanhToan";
            btnThanhToan.Size = new Size(191, 36);
            btnThanhToan.TabIndex = 2;
            btnThanhToan.Text = "Thanh toán";
            btnThanhToan.UseVisualStyleBackColor = true;
            btnThanhToan.Click += btnThanhToan_Click;
            // 
            // lblHinhThuc
            // 
            lblHinhThuc.AutoSize = true;
            lblHinhThuc.Location = new Point(72, 144);
            lblHinhThuc.Name = "lblHinhThuc";
            lblHinhThuc.Size = new Size(60, 15);
            lblHinhThuc.TabIndex = 3;
            lblHinhThuc.Text = "Hình thức";
            // 
            // lblTongTien
            // 
            lblTongTien.AutoSize = true;
            lblTongTien.Location = new Point(72, 216);
            lblTongTien.Name = "lblTongTien";
            lblTongTien.Size = new Size(93, 15);
            lblTongTien.TabIndex = 4;
            lblTongTien.Text = "Tổng tiền (VNĐ)";
            // 
            // lblSoTienCanThanhToan
            // 
            lblSoTienCanThanhToan.AutoSize = true;
            lblSoTienCanThanhToan.Location = new Point(72, 303);
            lblSoTienCanThanhToan.Name = "lblSoTienCanThanhToan";
            lblSoTienCanThanhToan.Size = new Size(161, 15);
            lblSoTienCanThanhToan.TabIndex = 5;
            lblSoTienCanThanhToan.Text = "Số tiền cần thanh toán (VNĐ)";
            // 
            // lblGiamGia
            // 
            lblGiamGia.AutoSize = true;
            lblGiamGia.Location = new Point(575, 215);
            lblGiamGia.Name = "lblGiamGia";
            lblGiamGia.Size = new Size(54, 15);
            lblGiamGia.TabIndex = 6;
            lblGiamGia.Text = "Giảm giá";
            // 
            // lblMaGiaoDich
            // 
            lblMaGiaoDich.AutoSize = true;
            lblMaGiaoDich.Location = new Point(575, 145);
            lblMaGiaoDich.Name = "lblMaGiaoDich";
            lblMaGiaoDich.Size = new Size(76, 15);
            lblMaGiaoDich.TabIndex = 7;
            lblMaGiaoDich.Text = "Mã giao dịch";
            // 
            // lblNgayThanhToan
            // 
            lblNgayThanhToan.AutoSize = true;
            lblNgayThanhToan.Location = new Point(575, 74);
            lblNgayThanhToan.Name = "lblNgayThanhToan";
            lblNgayThanhToan.Size = new Size(96, 15);
            lblNgayThanhToan.TabIndex = 8;
            lblNgayThanhToan.Text = "Ngày thanh toán";
            // 
            // txtboxLoaiThanhToan
            // 
            txtboxLoaiThanhToan.Location = new Point(72, 100);
            txtboxLoaiThanhToan.Margin = new Padding(3, 2, 3, 2);
            txtboxLoaiThanhToan.Name = "txtboxLoaiThanhToan";
            txtboxLoaiThanhToan.Size = new Size(378, 23);
            txtboxLoaiThanhToan.TabIndex = 9;
            // 
            // txtBoxNgayThanhToan
            // 
            txtBoxNgayThanhToan.Location = new Point(575, 100);
            txtBoxNgayThanhToan.Margin = new Padding(3, 2, 3, 2);
            txtBoxNgayThanhToan.Name = "txtBoxNgayThanhToan";
            txtBoxNgayThanhToan.Size = new Size(378, 23);
            txtBoxNgayThanhToan.TabIndex = 12;
            // 
            // txtboxTongTien
            // 
            txtboxTongTien.Location = new Point(72, 238);
            txtboxTongTien.Margin = new Padding(3, 2, 3, 2);
            txtboxTongTien.Name = "txtboxTongTien";
            txtboxTongTien.Size = new Size(378, 23);
            txtboxTongTien.TabIndex = 11;
            // 
            // txtboxGiamGia
            // 
            txtboxGiamGia.Location = new Point(575, 238);
            txtboxGiamGia.Margin = new Padding(3, 2, 3, 2);
            txtboxGiamGia.Name = "txtboxGiamGia";
            txtboxGiamGia.Size = new Size(378, 23);
            txtboxGiamGia.TabIndex = 13;
            // 
            // txtboxMaGiaoDich
            // 
            txtboxMaGiaoDich.Location = new Point(575, 164);
            txtboxMaGiaoDich.Margin = new Padding(3, 2, 3, 2);
            txtboxMaGiaoDich.Name = "txtboxMaGiaoDich";
            txtboxMaGiaoDich.Size = new Size(378, 23);
            txtboxMaGiaoDich.TabIndex = 14;
            // 
            // txtboxSoTienThanhToan
            // 
            txtboxSoTienThanhToan.Location = new Point(72, 326);
            txtboxSoTienThanhToan.Margin = new Padding(3, 2, 3, 2);
            txtboxSoTienThanhToan.Name = "txtboxSoTienThanhToan";
            txtboxSoTienThanhToan.Size = new Size(881, 23);
            txtboxSoTienThanhToan.TabIndex = 15;
            // 
            // cbboxHinhThuc
            // 
            cbboxHinhThuc.FormattingEnabled = true;
            cbboxHinhThuc.Items.AddRange(new object[] { "Chuyển khoản", "Tiền mặt" });
            cbboxHinhThuc.Location = new Point(74, 167);
            cbboxHinhThuc.Name = "cbboxHinhThuc";
            cbboxHinhThuc.Size = new Size(376, 23);
            cbboxHinhThuc.TabIndex = 16;
            cbboxHinhThuc.SelectedIndexChanged += cbboxHinhThuc_SelectedIndexChanged;
            // 
            // XacNhanThanhToan
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(cbboxHinhThuc);
            Controls.Add(txtboxSoTienThanhToan);
            Controls.Add(txtboxMaGiaoDich);
            Controls.Add(txtboxGiamGia);
            Controls.Add(txtBoxNgayThanhToan);
            Controls.Add(txtboxTongTien);
            Controls.Add(txtboxLoaiThanhToan);
            Controls.Add(lblNgayThanhToan);
            Controls.Add(lblMaGiaoDich);
            Controls.Add(lblGiamGia);
            Controls.Add(lblSoTienCanThanhToan);
            Controls.Add(lblTongTien);
            Controls.Add(lblHinhThuc);
            Controls.Add(btnThanhToan);
            Controls.Add(lblLoaiThanhToan);
            Controls.Add(btnHuy);
            Margin = new Padding(3, 2, 3, 2);
            Name = "XacNhanThanhToan";
            Size = new Size(1050, 600);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnHuy;
        private Label lblLoaiThanhToan;
        private Button btnThanhToan;
        private Label lblHinhThuc;
        private Label lblTongTien;
        private Label lblSoTienCanThanhToan;
        private Label lblGiamGia;
        private Label lblMaGiaoDich;
        private Label lblNgayThanhToan;
        private TextBox txtboxLoaiThanhToan;
        private TextBox txtBoxNgayThanhToan;
        private TextBox txtboxTongTien;
        private TextBox txtboxGiamGia;
        private TextBox txtboxMaGiaoDich;
        private TextBox txtboxSoTienThanhToan;
        private ComboBox cbboxHinhThuc;
    }
}
