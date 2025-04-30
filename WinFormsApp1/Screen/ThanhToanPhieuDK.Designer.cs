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
            dataGridView1 = new DataGridView();
            button1 = new Button();
            textBox1 = new TextBox();
            button2 = new Button();
            MaPhieu = new DataGridViewTextBoxColumn();
            SoLanGiaHan = new DataGridViewTextBoxColumn();
            LichThiCu = new DataGridViewTextBoxColumn();
            LichThiMoi = new DataGridViewTextBoxColumn();
            LyDo = new DataGridViewTextBoxColumn();
            ThoiGianGH = new DataGridViewTextBoxColumn();
            PhiGH = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToOrderColumns = true;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { MaPhieu, SoLanGiaHan, LichThiCu, LichThiMoi, LyDo, ThoiGianGH, PhiGH });
            dataGridView1.Location = new Point(62, 159);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(927, 551);
            dataGridView1.TabIndex = 6;
            //dataGridView1.CellContentClick += this.dataGridView1_CellContentClick;
            // 
            // button1
            // 
            button1.Location = new Point(1031, 91);
            button1.Name = "button1";
            button1.Size = new Size(108, 48);
            button1.TabIndex = 5;
            button1.Text = "Kiểm tra";
            button1.UseVisualStyleBackColor = true;
            //button1.Click += this.button1_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(62, 102);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(927, 27);
            textBox1.TabIndex = 4;
            //textBox1.TextChanged += this.textBox1_TextChanged;
            // 
            // button2
            // 
            button2.Location = new Point(1031, 159);
            button2.Name = "button2";
            button2.Size = new Size(108, 48);
            button2.TabIndex = 7;
            button2.Text = "Thanh toán";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
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
            // ThanhToanPhieuDK
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(dataGridView1);
            Controls.Add(button1);
            Controls.Add(textBox1);
            Controls.Add(button2);
            Name = "ThanhToanPhieuDK";
            Size = new Size(1200, 800);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private Button button1;
        private TextBox textBox1;
        private Button button2;
        private DataGridViewTextBoxColumn MaPhieu;
        private DataGridViewTextBoxColumn SoLanGiaHan;
        private DataGridViewTextBoxColumn LichThiCu;
        private DataGridViewTextBoxColumn LichThiMoi;
        private DataGridViewTextBoxColumn LyDo;
        private DataGridViewTextBoxColumn ThoiGianGH;
        private DataGridViewTextBoxColumn PhiGH;
    }
}
