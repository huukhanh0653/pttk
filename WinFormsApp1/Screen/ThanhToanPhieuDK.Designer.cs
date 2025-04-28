namespace WinFormsApp1
{
    partial class ThanhToanPhieuDK
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
            dgvDSPhieuDK = new DataGridView();
            MaPhieu = new DataGridViewTextBoxColumn();
            SoLanGiaHan = new DataGridViewTextBoxColumn();
            LichThiCu = new DataGridViewTextBoxColumn();
            LichThiMoi = new DataGridViewTextBoxColumn();
            LyDo = new DataGridViewTextBoxColumn();
            ThoiGianGH = new DataGridViewTextBoxColumn();
            PhiGH = new DataGridViewTextBoxColumn();
            btnKiemTra = new Button();
            txtboxTimKiem = new TextBox();
            btnThanhToan = new Button();
            txtKyTu = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvDSPhieuDK).BeginInit();
            SuspendLayout();
            // 
            // dgvDSPhieuDK
            // 
            dgvDSPhieuDK.AllowUserToOrderColumns = true;
            dgvDSPhieuDK.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDSPhieuDK.Columns.AddRange(new DataGridViewColumn[] { MaPhieu, SoLanGiaHan, LichThiCu, LichThiMoi, LyDo, ThoiGianGH, PhiGH });
            dgvDSPhieuDK.Location = new Point(67, 142);
            dgvDSPhieuDK.Margin = new Padding(3, 2, 3, 2);
            dgvDSPhieuDK.Name = "dgvDSPhieuDK";
            dgvDSPhieuDK.RowHeadersWidth = 51;
            dgvDSPhieuDK.Size = new Size(928, 413);
            dgvDSPhieuDK.TabIndex = 6;
            // 
            // MaPhieu
            // 
            MaPhieu.HeaderText = "Mã phiếu";
            MaPhieu.MinimumWidth = 6;
            MaPhieu.Name = "MaPhieu";
            MaPhieu.Width = 125;
            // 
            // SoLanGiaHan
            // 
            SoLanGiaHan.HeaderText = "Ngày đăng ký";
            SoLanGiaHan.MinimumWidth = 6;
            SoLanGiaHan.Name = "SoLanGiaHan";
            SoLanGiaHan.Width = 125;
            // 
            // LichThiCu
            // 
            LichThiCu.HeaderText = "Tổng tiền";
            LichThiCu.MinimumWidth = 6;
            LichThiCu.Name = "LichThiCu";
            LichThiCu.Width = 125;
            // 
            // LichThiMoi
            // 
            LichThiMoi.HeaderText = "Họ tên người đăng ký";
            LichThiMoi.MinimumWidth = 6;
            LichThiMoi.Name = "LichThiMoi";
            LichThiMoi.Width = 125;
            // 
            // LyDo
            // 
            LyDo.HeaderText = "Số điện thoại";
            LyDo.MinimumWidth = 6;
            LyDo.Name = "LyDo";
            LyDo.Width = 125;
            // 
            // ThoiGianGH
            // 
            ThoiGianGH.HeaderText = "Loại đăng ký";
            ThoiGianGH.MinimumWidth = 6;
            ThoiGianGH.Name = "ThoiGianGH";
            ThoiGianGH.Width = 125;
            // 
            // PhiGH
            // 
            PhiGH.HeaderText = "Mã thanh toán";
            PhiGH.MinimumWidth = 6;
            PhiGH.Name = "PhiGH";
            PhiGH.Width = 125;
            // 
            // btnKiemTra
            // 
            btnKiemTra.Location = new Point(901, 50);
            btnKiemTra.Margin = new Padding(3, 2, 3, 2);
            btnKiemTra.Name = "btnKiemTra";
            btnKiemTra.Size = new Size(94, 36);
            btnKiemTra.TabIndex = 5;
            btnKiemTra.Text = "Kiểm tra";
            btnKiemTra.UseVisualStyleBackColor = true;
            btnKiemTra.Click += btnKiemTra_Click;
            // 
            // txtboxTimKiem
            // 
            txtboxTimKiem.Location = new Point(67, 58);
            txtboxTimKiem.Margin = new Padding(3, 2, 3, 2);
            txtboxTimKiem.Name = "txtboxTimKiem";
            txtboxTimKiem.Size = new Size(812, 23);
            txtboxTimKiem.TabIndex = 4;
            txtboxTimKiem.TextChanged += txtboxTimKiem_TextChanged;
            // 
            // btnThanhToan
            // 
            btnThanhToan.Location = new Point(901, 94);
            btnThanhToan.Margin = new Padding(3, 2, 3, 2);
            btnThanhToan.Name = "btnThanhToan";
            btnThanhToan.Size = new Size(94, 36);
            btnThanhToan.TabIndex = 7;
            btnThanhToan.Text = "Thanh toán";
            btnThanhToan.UseVisualStyleBackColor = true;
            btnThanhToan.Click += btnThanhToan_Click;
            // 
            // txtKyTu
            // 
            txtKyTu.AutoSize = true;
            txtKyTu.Location = new Point(67, 34);
            txtKyTu.Name = "txtKyTu";
            txtKyTu.Size = new Size(240, 15);
            txtKyTu.TabIndex = 8;
            txtKyTu.Text = "Tìm kiếm bằng số điện thoại hoặc mã phiếu";
            // 
            // ThanhToanPhieuDK
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(txtKyTu);
            Controls.Add(dgvDSPhieuDK);
            Controls.Add(btnKiemTra);
            Controls.Add(txtboxTimKiem);
            Controls.Add(btnThanhToan);
            Margin = new Padding(3, 2, 3, 2);
            Name = "ThanhToanPhieuDK";
            Size = new Size(1050, 600);
            ((System.ComponentModel.ISupportInitialize)dgvDSPhieuDK).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvDSPhieuDK;
        private Button btnKiemTra;
        private TextBox txtboxTimKiem;
        private Button btnThanhToan;
        private DataGridViewTextBoxColumn MaPhieu;
        private DataGridViewTextBoxColumn SoLanGiaHan;
        private DataGridViewTextBoxColumn LichThiCu;
        private DataGridViewTextBoxColumn LichThiMoi;
        private DataGridViewTextBoxColumn LyDo;
        private DataGridViewTextBoxColumn ThoiGianGH;
        private DataGridViewTextBoxColumn PhiGH;
        private Label txtKyTu;
    }
}
