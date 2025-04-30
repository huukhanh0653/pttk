namespace WinFormsApp1
{
    partial class PhatHanhPhieuDuThi
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
            dataGridView1 = new DataGridView();
            MaPhieu = new DataGridViewTextBoxColumn();
            MaThiSinh = new DataGridViewTextBoxColumn();
            HoTen = new DataGridViewTextBoxColumn();
            Phone = new DataGridViewTextBoxColumn();
            Email = new DataGridViewTextBoxColumn();
            MaKyThi = new DataGridViewTextBoxColumn();
            MaChungChi = new DataGridViewTextBoxColumn();
            TenKyThi = new DataGridViewTextBoxColumn();
            NgayBD = new DataGridViewTextBoxColumn();
            button1 = new Button();
            textBox1 = new TextBox();
            button2 = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { MaPhieu, MaThiSinh, HoTen, Phone, Email, MaKyThi, MaChungChi, TenKyThi, NgayBD });
            dataGridView1.Location = new Point(18, 132);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(1179, 665);
            dataGridView1.TabIndex = 0;
            // 
            // MaPhieu
            // 
            MaPhieu.HeaderText = "Mã phiếu";
            MaPhieu.MinimumWidth = 6;
            MaPhieu.Name = "MaPhieu";
            MaPhieu.Width = 125;
            // 
            // MaThiSinh
            // 
            MaThiSinh.HeaderText = "Mã thí sinh";
            MaThiSinh.MinimumWidth = 6;
            MaThiSinh.Name = "MaThiSinh";
            MaThiSinh.Width = 125;
            // 
            // HoTen
            // 
            HoTen.HeaderText = "Họ tên";
            HoTen.MinimumWidth = 6;
            HoTen.Name = "HoTen";
            HoTen.Width = 125;
            // 
            // Phone
            // 
            Phone.HeaderText = "Số điện thoại";
            Phone.MinimumWidth = 6;
            Phone.Name = "Phone";
            Phone.Width = 125;
            // 
            // Email
            // 
            Email.HeaderText = "Email";
            Email.MinimumWidth = 6;
            Email.Name = "Email";
            Email.Width = 125;
            // 
            // MaKyThi
            // 
            MaKyThi.HeaderText = "Mã kỳ thi";
            MaKyThi.MinimumWidth = 6;
            MaKyThi.Name = "MaKyThi";
            MaKyThi.Width = 125;
            // 
            // MaChungChi
            // 
            MaChungChi.HeaderText = "Mã Chứng Chỉ";
            MaChungChi.MinimumWidth = 6;
            MaChungChi.Name = "MaChungChi";
            MaChungChi.Width = 125;
            // 
            // TenKyThi
            // 
            TenKyThi.HeaderText = "Tên Kỳ Thi";
            TenKyThi.MinimumWidth = 6;
            TenKyThi.Name = "TenKyThi";
            TenKyThi.Width = 125;
            // 
            // NgayBD
            // 
            NgayBD.HeaderText = "Ngày Bắt Đầu";
            NgayBD.MinimumWidth = 6;
            NgayBD.Name = "NgayBD";
            NgayBD.Width = 125;
            // 
            // button1
            // 
            button1.Location = new Point(934, 58);
            button1.Name = "button1";
            button1.Size = new Size(263, 55);
            button1.TabIndex = 1;
            button1.Text = "Phát hành";
            button1.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(18, 72);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(754, 27);
            textBox1.TabIndex = 2;
            // 
            // button2
            // 
            button2.BackgroundImage = Properties.Resources.search;
            button2.BackgroundImageLayout = ImageLayout.Center;
            button2.Location = new Point(778, 65);
            button2.Name = "button2";
            button2.Size = new Size(38, 41);
            button2.TabIndex = 3;
            button2.UseVisualStyleBackColor = true;
            // 
            // PhatHanhPhieuDuThi
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(button2);
            Controls.Add(textBox1);
            Controls.Add(button1);
            Controls.Add(dataGridView1);
            Name = "PhatHanhPhieuDuThi";
            Size = new Size(1200, 800);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn MaPhieu;
        private DataGridViewTextBoxColumn MaThiSinh;
        private DataGridViewTextBoxColumn HoTen;
        private DataGridViewTextBoxColumn Phone;
        private DataGridViewTextBoxColumn Email;
        private DataGridViewTextBoxColumn MaKyThi;
        private DataGridViewTextBoxColumn MaChungChi;
        private DataGridViewTextBoxColumn TenKyThi;
        private DataGridViewTextBoxColumn NgayBD;
        private Button button1;
        private TextBox textBox1;
        private Button button2;
    }
}
