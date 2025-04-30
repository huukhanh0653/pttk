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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            textBox5 = new TextBox();
            textBox6 = new TextBox();
            textBox8 = new TextBox();
            dataGridView1 = new DataGridView();
            HoTen = new DataGridViewTextBoxColumn();
            NgaySinh = new DataGridViewTextBoxColumn();
            Email = new DataGridViewTextBoxColumn();
            Phone = new DataGridViewTextBoxColumn();
            Certi = new DataGridViewTextBoxColumn();
            NgayThi = new DataGridViewTextBoxColumn();
            button1 = new Button();
            button2 = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(89, 110);
            label1.Name = "label1";
            label1.Size = new Size(102, 15);
            label1.TabIndex = 0;
            label1.Text = "Mã phiếu đăng ký";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(407, 110);
            label2.Name = "label2";
            label2.Size = new Size(80, 15);
            label2.TabIndex = 1;
            label2.Text = "Ngày đăng ký";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(720, 110);
            label3.Name = "label3";
            label3.Size = new Size(74, 15);
            label3.TabIndex = 2;
            label3.Text = "Loại đăng ký";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(89, 174);
            label4.Name = "label4";
            label4.Size = new Size(122, 15);
            label4.TabIndex = 3;
            label4.Text = "Họ tên người đăng ký";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(407, 174);
            label5.Name = "label5";
            label5.Size = new Size(107, 15);
            label5.TabIndex = 4;
            label5.Text = "SĐT người đăng ký";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(720, 174);
            label6.Name = "label6";
            label6.Size = new Size(115, 15);
            label6.TabIndex = 5;
            label6.Text = "Email người đăng ký";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(82, 234);
            label7.Name = "label7";
            label7.Size = new Size(104, 15);
            label7.TabIndex = 6;
            label7.Text = "Danh sách thí sinh";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(89, 417);
            label8.Name = "label8";
            label8.Size = new Size(58, 15);
            label8.TabIndex = 7;
            label8.Text = "Tổng tiền";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(82, 134);
            textBox1.Margin = new Padding(3, 2, 3, 2);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(172, 23);
            textBox1.TabIndex = 8;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(407, 134);
            textBox2.Margin = new Padding(3, 2, 3, 2);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(172, 23);
            textBox2.TabIndex = 9;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(720, 134);
            textBox3.Margin = new Padding(3, 2, 3, 2);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(172, 23);
            textBox3.TabIndex = 10;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(82, 192);
            textBox4.Margin = new Padding(3, 2, 3, 2);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(172, 23);
            textBox4.TabIndex = 11;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(407, 192);
            textBox5.Margin = new Padding(3, 2, 3, 2);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(172, 23);
            textBox5.TabIndex = 12;
            // 
            // textBox6
            // 
            textBox6.Location = new Point(720, 192);
            textBox6.Margin = new Padding(3, 2, 3, 2);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(172, 23);
            textBox6.TabIndex = 13;
            // 
            // textBox8
            // 
            textBox8.Location = new Point(89, 434);
            textBox8.Margin = new Padding(3, 2, 3, 2);
            textBox8.Name = "textBox8";
            textBox8.Size = new Size(803, 23);
            textBox8.TabIndex = 15;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { HoTen, NgaySinh, Email, Phone, Certi, NgayThi });
            dataGridView1.Location = new Point(89, 254);
            dataGridView1.Margin = new Padding(3, 2, 3, 2);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(803, 154);
            dataGridView1.TabIndex = 16;
            // 
            // HoTen
            // 
            HoTen.HeaderText = "Họ Tên";
            HoTen.MinimumWidth = 6;
            HoTen.Name = "HoTen";
            HoTen.Width = 125;
            // 
            // NgaySinh
            // 
            NgaySinh.HeaderText = "Ngày Sinh";
            NgaySinh.MinimumWidth = 6;
            NgaySinh.Name = "NgaySinh";
            NgaySinh.Width = 125;
            // 
            // Email
            // 
            Email.HeaderText = "Email";
            Email.MinimumWidth = 6;
            Email.Name = "Email";
            Email.Width = 125;
            // 
            // Phone
            // 
            Phone.HeaderText = "Số điện thoại";
            Phone.MinimumWidth = 6;
            Phone.Name = "Phone";
            Phone.Width = 125;
            // 
            // Certi
            // 
            Certi.HeaderText = "Chứng chỉ";
            Certi.MinimumWidth = 6;
            Certi.Name = "Certi";
            Certi.Width = 125;
            // 
            // NgayThi
            // 
            NgayThi.HeaderText = "Ngày Thi";
            NgayThi.MinimumWidth = 6;
            NgayThi.Name = "NgayThi";
            NgayThi.Width = 125;
            // 
            // button1
            // 
            button1.Location = new Point(252, 520);
            button1.Margin = new Padding(3, 2, 3, 2);
            button1.Name = "button1";
            button1.Size = new Size(156, 38);
            button1.TabIndex = 17;
            button1.Text = "Trở về";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(556, 520);
            button2.Margin = new Padding(3, 2, 3, 2);
            button2.Name = "button2";
            button2.Size = new Size(203, 38);
            button2.TabIndex = 18;
            button2.Text = "Tiếp tục thanh toán";
            button2.UseVisualStyleBackColor = true;
            // 
            // ChiTietPhieuDangKy
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(dataGridView1);
            Controls.Add(textBox8);
            Controls.Add(textBox6);
            Controls.Add(textBox5);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "ChiTietPhieuDangKy";
            Size = new Size(1050, 600);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox textBox4;
        private TextBox textBox5;
        private TextBox textBox6;
        private TextBox textBox8;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn HoTen;
        private DataGridViewTextBoxColumn NgaySinh;
        private DataGridViewTextBoxColumn Email;
        private DataGridViewTextBoxColumn Phone;
        private DataGridViewTextBoxColumn Certi;
        private DataGridViewTextBoxColumn NgayThi;
        private Button button1;
        private Button button2;
    }
}
