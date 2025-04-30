namespace WinFormsApp1
{
    partial class NhapKetQua
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NhapKetQua));
            indivTextBox = new TextBox();
            certTextBox = new TextBox();
            certIdLalbel = new Label();
            indivIdLabel = new Label();
            ngayCapDateTimePicker = new DateTimePicker();
            ngayCapLabel = new Label();
            expiredDateTimePicker = new DateTimePicker();
            ngayHetHanLabel = new Label();
            markNumericUpDown = new NumericUpDown();
            markLabel = new Label();
            markDecimalLabel = new Label();
            markDecimalNumericUpDown = new NumericUpDown();
            confirmButton = new Button();
            label1 = new Label();
            clearDataButton = new Button();
            btnReturn = new Button();
            openFileDialog1 = new OpenFileDialog();
            textBox1 = new TextBox();
            maKyThiLabel = new Label();
            dateTimePicker1 = new DateTimePicker();
            label2 = new Label();
            dataGridView1 = new DataGridView();
            label3 = new Label();
            ((System.ComponentModel.ISupportInitialize)markNumericUpDown).BeginInit();
            ((System.ComponentModel.ISupportInitialize)markDecimalNumericUpDown).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // indivTextBox
            // 
            indivTextBox.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            indivTextBox.Location = new Point(177, 111);
            indivTextBox.Margin = new Padding(3, 2, 3, 2);
            indivTextBox.Name = "indivTextBox";
            indivTextBox.Size = new Size(416, 32);
            indivTextBox.TabIndex = 0;
            // 
            // certTextBox
            // 
            certTextBox.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            certTextBox.Location = new Point(789, 118);
            certTextBox.Margin = new Padding(3, 2, 3, 2);
            certTextBox.Name = "certTextBox";
            certTextBox.Size = new Size(359, 32);
            certTextBox.TabIndex = 1;
            // 
            // certIdLalbel
            // 
            certIdLalbel.AutoSize = true;
            certIdLalbel.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            certIdLalbel.ForeColor = SystemColors.ActiveCaptionText;
            certIdLalbel.Location = new Point(636, 114);
            certIdLalbel.Name = "certIdLalbel";
            certIdLalbel.Size = new Size(127, 25);
            certIdLalbel.TabIndex = 2;
            certIdLalbel.Text = "Mã chứng chỉ";
            // 
            // indivIdLabel
            // 
            indivIdLabel.AutoSize = true;
            indivIdLabel.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            indivIdLabel.ForeColor = SystemColors.ActiveCaptionText;
            indivIdLabel.Location = new Point(46, 111);
            indivIdLabel.Name = "indivIdLabel";
            indivIdLabel.Size = new Size(106, 25);
            indivIdLabel.TabIndex = 3;
            indivIdLabel.Text = "Mã thí sinh";
            // 
            // ngayCapDateTimePicker
            // 
            ngayCapDateTimePicker.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ngayCapDateTimePicker.Location = new Point(789, 200);
            ngayCapDateTimePicker.Margin = new Padding(3, 2, 3, 2);
            ngayCapDateTimePicker.Name = "ngayCapDateTimePicker";
            ngayCapDateTimePicker.Size = new Size(359, 32);
            ngayCapDateTimePicker.TabIndex = 4;
            ngayCapDateTimePicker.ValueChanged += dateTimePicker1_ValueChanged;
            // 
            // ngayCapLabel
            // 
            ngayCapLabel.AutoSize = true;
            ngayCapLabel.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ngayCapLabel.ForeColor = SystemColors.ActiveCaptionText;
            ngayCapLabel.Location = new Point(638, 206);
            ngayCapLabel.Name = "ngayCapLabel";
            ngayCapLabel.Size = new Size(91, 25);
            ngayCapLabel.TabIndex = 5;
            ngayCapLabel.Text = "Ngày cấp";
            // 
            // expiredDateTimePicker
            // 
            expiredDateTimePicker.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            expiredDateTimePicker.Location = new Point(789, 160);
            expiredDateTimePicker.Margin = new Padding(3, 2, 3, 2);
            expiredDateTimePicker.Name = "expiredDateTimePicker";
            expiredDateTimePicker.Size = new Size(359, 32);
            expiredDateTimePicker.TabIndex = 6;
            // 
            // ngayHetHanLabel
            // 
            ngayHetHanLabel.AutoSize = true;
            ngayHetHanLabel.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ngayHetHanLabel.ForeColor = SystemColors.ActiveCaptionText;
            ngayHetHanLabel.Location = new Point(638, 166);
            ngayHetHanLabel.Name = "ngayHetHanLabel";
            ngayHetHanLabel.Size = new Size(125, 25);
            ngayHetHanLabel.TabIndex = 7;
            ngayHetHanLabel.Text = "Ngày hết hạn";
            // 
            // markNumericUpDown
            // 
            markNumericUpDown.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            markNumericUpDown.Location = new Point(213, 254);
            markNumericUpDown.Margin = new Padding(3, 2, 3, 2);
            markNumericUpDown.Name = "markNumericUpDown";
            markNumericUpDown.Size = new Size(380, 32);
            markNumericUpDown.TabIndex = 8;
            // 
            // markLabel
            // 
            markLabel.AutoSize = true;
            markLabel.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            markLabel.ForeColor = SystemColors.ActiveCaptionText;
            markLabel.Location = new Point(46, 255);
            markLabel.Name = "markLabel";
            markLabel.Size = new Size(161, 25);
            markLabel.TabIndex = 9;
            markLabel.Text = "Điểm hàng đơn vị";
            // 
            // markDecimalLabel
            // 
            markDecimalLabel.AutoSize = true;
            markDecimalLabel.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            markDecimalLabel.ForeColor = SystemColors.ActiveCaptionText;
            markDecimalLabel.Location = new Point(636, 250);
            markDecimalLabel.Name = "markDecimalLabel";
            markDecimalLabel.Size = new Size(195, 25);
            markDecimalLabel.TabIndex = 10;
            markDecimalLabel.Text = "Điểm phần thập phân";
            // 
            // markDecimalNumericUpDown
            // 
            markDecimalNumericUpDown.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            markDecimalNumericUpDown.Location = new Point(837, 248);
            markDecimalNumericUpDown.Margin = new Padding(3, 2, 3, 2);
            markDecimalNumericUpDown.Name = "markDecimalNumericUpDown";
            markDecimalNumericUpDown.Size = new Size(311, 32);
            markDecimalNumericUpDown.TabIndex = 11;
            // 
            // confirmButton
            // 
            confirmButton.BackColor = Color.FromArgb(84, 178, 145);
            confirmButton.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            confirmButton.ForeColor = SystemColors.ControlLight;
            confirmButton.Location = new Point(1014, 296);
            confirmButton.Margin = new Padding(3, 2, 3, 2);
            confirmButton.Name = "confirmButton";
            confirmButton.Size = new Size(134, 43);
            confirmButton.TabIndex = 12;
            confirmButton.Text = "Xác nhận";
            confirmButton.UseVisualStyleBackColor = false;
            confirmButton.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 22.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ActiveCaptionText;
            label1.Location = new Point(530, 19);
            label1.Name = "label1";
            label1.Size = new Size(169, 41);
            label1.TabIndex = 13;
            label1.Text = "Nhập điểm";
            // 
            // clearDataButton
            // 
            clearDataButton.BackColor = Color.FromArgb(192, 64, 0);
            clearDataButton.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            clearDataButton.ForeColor = SystemColors.ControlLight;
            clearDataButton.Location = new Point(889, 296);
            clearDataButton.Margin = new Padding(3, 2, 3, 2);
            clearDataButton.Name = "clearDataButton";
            clearDataButton.Size = new Size(119, 43);
            clearDataButton.TabIndex = 14;
            clearDataButton.Text = "Nhập lại";
            clearDataButton.UseVisualStyleBackColor = false;
            // 
            // btnReturn
            // 
            btnReturn.BackColor = Color.Transparent;
            btnReturn.FlatStyle = FlatStyle.Flat;
            btnReturn.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnReturn.ForeColor = Color.Transparent;
            btnReturn.Image = (Image)resources.GetObject("btnReturn.Image");
            btnReturn.Location = new Point(33, 19);
            btnReturn.Margin = new Padding(3, 2, 3, 2);
            btnReturn.Name = "btnReturn";
            btnReturn.Size = new Size(35, 27);
            btnReturn.TabIndex = 15;
            btnReturn.UseVisualStyleBackColor = false;
            btnReturn.Click += button3_Click;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox1.Location = new Point(177, 154);
            textBox1.Margin = new Padding(3, 2, 3, 2);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(416, 32);
            textBox1.TabIndex = 16;
            // 
            // maKyThiLabel
            // 
            maKyThiLabel.AutoSize = true;
            maKyThiLabel.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            maKyThiLabel.ForeColor = SystemColors.ActiveCaptionText;
            maKyThiLabel.Location = new Point(46, 154);
            maKyThiLabel.Name = "maKyThiLabel";
            maKyThiLabel.Size = new Size(89, 25);
            maKyThiLabel.TabIndex = 17;
            maKyThiLabel.Text = "Mã kỳ thi";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dateTimePicker1.Location = new Point(177, 202);
            dateTimePicker1.Margin = new Padding(3, 2, 3, 2);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(416, 32);
            dateTimePicker1.TabIndex = 18;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.ActiveCaptionText;
            label2.Location = new Point(46, 202);
            label2.Name = "label2";
            label2.Size = new Size(110, 25);
            label2.TabIndex = 19;
            label2.Text = "Ngày dự thi";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(46, 407);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(1102, 372);
            dataGridView1.TabIndex = 20;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = SystemColors.ActiveCaptionText;
            label3.Location = new Point(46, 370);
            label3.Name = "label3";
            label3.Size = new Size(151, 25);
            label3.TabIndex = 21;
            label3.Text = "Danh sách điểm";
            // 
            // NhapKetQua
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(label3);
            Controls.Add(dataGridView1);
            Controls.Add(label2);
            Controls.Add(dateTimePicker1);
            Controls.Add(maKyThiLabel);
            Controls.Add(textBox1);
            Controls.Add(btnReturn);
            Controls.Add(clearDataButton);
            Controls.Add(label1);
            Controls.Add(confirmButton);
            Controls.Add(markDecimalNumericUpDown);
            Controls.Add(markDecimalLabel);
            Controls.Add(markLabel);
            Controls.Add(markNumericUpDown);
            Controls.Add(ngayHetHanLabel);
            Controls.Add(expiredDateTimePicker);
            Controls.Add(ngayCapLabel);
            Controls.Add(ngayCapDateTimePicker);
            Controls.Add(indivIdLabel);
            Controls.Add(certIdLalbel);
            Controls.Add(certTextBox);
            Controls.Add(indivTextBox);
            Margin = new Padding(3, 2, 3, 2);
            Name = "NhapKetQua";
            Size = new Size(1200, 800);
            ((System.ComponentModel.ISupportInitialize)markNumericUpDown).EndInit();
            ((System.ComponentModel.ISupportInitialize)markDecimalNumericUpDown).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox indivTextBox;
        private TextBox certTextBox;
        private Label certIdLalbel;
        private Label indivIdLabel;
        private DateTimePicker ngayCapDateTimePicker;
        private Label ngayCapLabel;
        private DateTimePicker expiredDateTimePicker;
        private Label ngayHetHanLabel;
        private NumericUpDown markNumericUpDown;
        private Label markLabel;
        private Label markDecimalLabel;
        private NumericUpDown markDecimalNumericUpDown;
        private Button confirmButton;
        private Label label1;
        private Button clearDataButton;
        private Button btnReturn;
        private OpenFileDialog openFileDialog1;


        private void button1_Click(object sender, EventArgs e)
        {
            // Handle the confirm button click event
            // You can add your logic here to process the input data
            MessageBox.Show("Xác nhận thành công!");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MainForm.Instance.SwitchUserControl(new Main());
        }

        private TextBox textBox1;
        private Label maKyThiLabel;
        private DateTimePicker dateTimePicker1;
        private Label label2;
        private DataGridView dataGridView1;
        private Label label3;
    }
}
