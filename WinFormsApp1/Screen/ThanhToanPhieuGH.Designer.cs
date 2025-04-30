namespace WinFormsApp1
{
    partial class ThanhToanPhieuGH
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
            textBox1 = new TextBox();
            button1 = new Button();
            dataGridView1 = new DataGridView();
            MaPhieu = new DataGridViewTextBoxColumn();
            SoLanGiaHan = new DataGridViewTextBoxColumn();
            LichThiCu = new DataGridViewTextBoxColumn();
            LichThiMoi = new DataGridViewTextBoxColumn();
            ThoiGianGH = new DataGridViewTextBoxColumn();
            PhiGH = new DataGridViewTextBoxColumn();
            LyDo = new DataGridViewTextBoxColumn();
            button2 = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Location = new Point(69, 61);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(927, 27);
            textBox1.TabIndex = 0;
            // 
            // button1
            // 
            button1.Location = new Point(1038, 50);
            button1.Name = "button1";
            button1.Size = new Size(108, 48);
            button1.TabIndex = 1;
            button1.Text = "Kiểm tra";
            button1.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToOrderColumns = true;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { MaPhieu, SoLanGiaHan, LichThiCu, LichThiMoi, ThoiGianGH, PhiGH, LyDo });
            dataGridView1.Location = new Point(69, 118);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(927, 551);
            dataGridView1.TabIndex = 2;
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
            SoLanGiaHan.HeaderText = "Số lần gia hạn";
            SoLanGiaHan.MinimumWidth = 6;
            SoLanGiaHan.Name = "SoLanGiaHan";
            SoLanGiaHan.Width = 125;
            // 
            // LichThiCu
            // 
            LichThiCu.HeaderText = "Lịch Thi Cũ";
            LichThiCu.MinimumWidth = 6;
            LichThiCu.Name = "LichThiCu";
            LichThiCu.Width = 125;
            // 
            // LichThiMoi
            // 
            LichThiMoi.HeaderText = "Lịch Thi Mới";
            LichThiMoi.MinimumWidth = 6;
            LichThiMoi.Name = "LichThiMoi";
            LichThiMoi.Width = 125;
            // 
            // ThoiGianGH
            // 
            ThoiGianGH.HeaderText = "Thời Gian Gia Hạn";
            ThoiGianGH.MinimumWidth = 6;
            ThoiGianGH.Name = "ThoiGianGH";
            ThoiGianGH.Width = 125;
            // 
            // PhiGH
            // 
            PhiGH.HeaderText = "Phí Gia Hạn";
            PhiGH.MinimumWidth = 6;
            PhiGH.Name = "PhiGH";
            PhiGH.Width = 125;
            // 
            // LyDo
            // 
            LyDo.HeaderText = "Lý Do";
            LyDo.MinimumWidth = 6;
            LyDo.Name = "LyDo";
            LyDo.Width = 125;
            // 
            // button2
            // 
            button2.Location = new Point(1038, 118);
            button2.Name = "button2";
            button2.Size = new Size(108, 48);
            button2.TabIndex = 3;
            button2.Text = "Thanh toán";
            button2.UseVisualStyleBackColor = true;
            // 
            // UserControl1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(button2);
            Controls.Add(dataGridView1);
            Controls.Add(button1);
            Controls.Add(textBox1);
            Name = "UserControl1";
            Size = new Size(1200, 800);
            Load += UserControl1_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private Button button1;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn MaPhieu;
        private DataGridViewTextBoxColumn SoLanGiaHan;
        private DataGridViewTextBoxColumn LichThiCu;
        private DataGridViewTextBoxColumn LichThiMoi;
        private DataGridViewTextBoxColumn ThoiGianGH;
        private DataGridViewTextBoxColumn PhiGH;
        private DataGridViewTextBoxColumn LyDo;
        private Button button2;
    }
}
