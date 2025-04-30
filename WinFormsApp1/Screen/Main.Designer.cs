namespace WinFormsApp1
{
    partial class Main
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
            panel1 = new Panel();
            btnNhapDiem = new Button();
            btnGiaHan = new Button();
            btnCapPhatCC = new Button();
            btnDangKyThi = new Button();
            button1 = new Button();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(btnNhapDiem);
            panel1.Controls.Add(btnGiaHan);
            panel1.Controls.Add(btnCapPhatCC);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(btnDangKyThi);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1050, 600);
            panel1.TabIndex = 0;
            panel1.Paint += panel1_Paint;
            // 
            // btnNhapDiem
            // 
            btnNhapDiem.Location = new Point(665, 166);
            btnNhapDiem.Margin = new Padding(3, 2, 3, 2);
            btnNhapDiem.Name = "btnNhapDiem";
            btnNhapDiem.Size = new Size(217, 54);
            btnNhapDiem.TabIndex = 9;
            btnNhapDiem.Text = "Nhập điểm";
            btnNhapDiem.UseVisualStyleBackColor = true;
            // 
            // btnGiaHan
            // 
            btnGiaHan.Location = new Point(665, 282);
            btnGiaHan.Margin = new Padding(3, 2, 3, 2);
            btnGiaHan.Name = "btnGiaHan";
            btnGiaHan.Size = new Size(217, 54);
            btnGiaHan.TabIndex = 8;
            btnGiaHan.Text = "Gia hạn thời gian thi";
            btnGiaHan.UseVisualStyleBackColor = true;
            btnGiaHan.Click += btnGiaHan_Click;
            // 
            // btnCapPhatCC
            // 
            btnCapPhatCC.Location = new Point(169, 282);
            btnCapPhatCC.Margin = new Padding(3, 2, 3, 2);
            btnCapPhatCC.Name = "btnCapPhatCC";
            btnCapPhatCC.Size = new Size(217, 54);
            btnCapPhatCC.TabIndex = 7;
            btnCapPhatCC.Text = "Cấp phát chứng chỉ";
            btnCapPhatCC.UseVisualStyleBackColor = true;
            // 
            // btnDangKyThi
            // 
            btnDangKyThi.Location = new Point(169, 166);
            btnDangKyThi.Margin = new Padding(3, 2, 3, 2);
            btnDangKyThi.Name = "btnDangKyThi";
            btnDangKyThi.Size = new Size(217, 54);
            btnDangKyThi.TabIndex = 5;
            btnDangKyThi.Text = "Đăng ký dự thi";
            btnDangKyThi.UseVisualStyleBackColor = true;
            btnDangKyThi.Click += btnDangKyThi_Click;
            // 
            // button1
            // 
            button1.Location = new Point(421, 225);
            button1.Margin = new Padding(3, 2, 3, 2);
            button1.Name = "button1";
            button1.Size = new Size(217, 54);
            button1.TabIndex = 6;
            button1.Text = "Thanh toán phiếu đăng ký";
            button1.UseVisualStyleBackColor = true;
            button1.Click += btnThanhToanPhieuDK_Click;
            // 
            // Main
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panel1);
            Name = "Main";
            Size = new Size(1050, 600);
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button btnNhapDiem;
        private Button btnGiaHan;
        private Button btnCapPhatCC;
        private Button btnDangKyThi;
        private Button button1;
    }
}
