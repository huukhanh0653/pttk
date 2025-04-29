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
            btnKiemTra = new Button();
            txtboxTimKiem = new TextBox();
            btnThanhToan = new Button();
            txtKyTu = new Label();
            btnCapNhatThanhToan = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvDSPhieuDK).BeginInit();
            SuspendLayout();
            // 
            // dgvDSPhieuDK
            // 
            dgvDSPhieuDK.AllowUserToOrderColumns = true;
            dgvDSPhieuDK.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDSPhieuDK.Location = new Point(51, 143);
            dgvDSPhieuDK.Margin = new Padding(3, 2, 3, 2);
            dgvDSPhieuDK.Name = "dgvDSPhieuDK";
            dgvDSPhieuDK.RowHeadersWidth = 51;
            dgvDSPhieuDK.Size = new Size(944, 413);
            dgvDSPhieuDK.TabIndex = 6;
            dgvDSPhieuDK.CellContentClick += dgvDSPhieuDK_CellContentClick;
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
            txtboxTimKiem.Location = new Point(51, 56);
            txtboxTimKiem.Margin = new Padding(3, 2, 3, 2);
            txtboxTimKiem.Name = "txtboxTimKiem";
            txtboxTimKiem.Size = new Size(828, 23);
            txtboxTimKiem.TabIndex = 4;
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
            txtKyTu.Location = new Point(51, 33);
            txtKyTu.Name = "txtKyTu";
            txtKyTu.Size = new Size(240, 15);
            txtKyTu.TabIndex = 8;
            txtKyTu.Text = "Tìm kiếm bằng số điện thoại hoặc mã phiếu";
            // 
            // btnCapNhatThanhToan
            // 
            btnCapNhatThanhToan.Location = new Point(770, 94);
            btnCapNhatThanhToan.Margin = new Padding(3, 2, 3, 2);
            btnCapNhatThanhToan.Name = "btnCapNhatThanhToan";
            btnCapNhatThanhToan.Size = new Size(125, 36);
            btnCapNhatThanhToan.TabIndex = 7;
            btnCapNhatThanhToan.Text = "Cập nhật thanh toán";
            btnCapNhatThanhToan.UseVisualStyleBackColor = true;
            btnCapNhatThanhToan.Click += btnThanhToan_Click;
            // 
            // ThanhToanPhieuDK
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(txtKyTu);
            Controls.Add(dgvDSPhieuDK);
            Controls.Add(btnKiemTra);
            Controls.Add(txtboxTimKiem);
            Controls.Add(btnCapNhatThanhToan);
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
        private Label txtKyTu;
        private Button btnCapNhatThanhToan;
    }
}
