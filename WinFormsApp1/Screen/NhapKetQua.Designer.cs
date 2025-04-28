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
            returnButton = new Button();
            openFileDialog1 = new OpenFileDialog();
            textBox1 = new TextBox();
            maKyThiLabel = new Label();
            dateTimePicker1 = new DateTimePicker();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)markNumericUpDown).BeginInit();
            ((System.ComponentModel.ISupportInitialize)markDecimalNumericUpDown).BeginInit();
            SuspendLayout();
            // 
            // indivTextBox
            // 
            indivTextBox.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            indivTextBox.Location = new Point(202, 239);
            indivTextBox.Name = "indivTextBox";
            indivTextBox.Size = new Size(323, 38);
            indivTextBox.TabIndex = 0;
            // 
            // certTextBox
            // 
            certTextBox.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            certTextBox.Location = new Point(734, 239);
            certTextBox.Name = "certTextBox";
            certTextBox.Size = new Size(338, 38);
            certTextBox.TabIndex = 1;
            // 
            // certIdLalbel
            // 
            certIdLalbel.AutoSize = true;
            certIdLalbel.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            certIdLalbel.ForeColor = SystemColors.ActiveCaptionText;
            certIdLalbel.Location = new Point(574, 239);
            certIdLalbel.Name = "certIdLalbel";
            certIdLalbel.Size = new Size(154, 31);
            certIdLalbel.TabIndex = 2;
            certIdLalbel.Text = "Mã chứng chỉ";
            // 
            // indivIdLabel
            // 
            indivIdLabel.AutoSize = true;
            indivIdLabel.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            indivIdLabel.ForeColor = SystemColors.ActiveCaptionText;
            indivIdLabel.Location = new Point(52, 239);
            indivIdLabel.Name = "indivIdLabel";
            indivIdLabel.Size = new Size(128, 31);
            indivIdLabel.TabIndex = 3;
            indivIdLabel.Text = "Mã thí sinh";
            // 
            // ngayCapDateTimePicker
            // 
            ngayCapDateTimePicker.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ngayCapDateTimePicker.Location = new Point(733, 360);
            ngayCapDateTimePicker.Name = "ngayCapDateTimePicker";
            ngayCapDateTimePicker.Size = new Size(339, 38);
            ngayCapDateTimePicker.TabIndex = 4;
            ngayCapDateTimePicker.ValueChanged += dateTimePicker1_ValueChanged;
            // 
            // ngayCapLabel
            // 
            ngayCapLabel.AutoSize = true;
            ngayCapLabel.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ngayCapLabel.ForeColor = SystemColors.ActiveCaptionText;
            ngayCapLabel.Location = new Point(577, 366);
            ngayCapLabel.Name = "ngayCapLabel";
            ngayCapLabel.Size = new Size(111, 31);
            ngayCapLabel.TabIndex = 5;
            ngayCapLabel.Text = "Ngày cấp";
            // 
            // expiredDateTimePicker
            // 
            expiredDateTimePicker.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            expiredDateTimePicker.Location = new Point(734, 303);
            expiredDateTimePicker.Name = "expiredDateTimePicker";
            expiredDateTimePicker.Size = new Size(339, 38);
            expiredDateTimePicker.TabIndex = 6;
            // 
            // ngayHetHanLabel
            // 
            ngayHetHanLabel.AutoSize = true;
            ngayHetHanLabel.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ngayHetHanLabel.ForeColor = SystemColors.ActiveCaptionText;
            ngayHetHanLabel.Location = new Point(577, 303);
            ngayHetHanLabel.Name = "ngayHetHanLabel";
            ngayHetHanLabel.Size = new Size(151, 31);
            ngayHetHanLabel.TabIndex = 7;
            ngayHetHanLabel.Text = "Ngày hết hạn";
            // 
            // markNumericUpDown
            // 
            markNumericUpDown.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            markNumericUpDown.Location = new Point(295, 429);
            markNumericUpDown.Name = "markNumericUpDown";
            markNumericUpDown.Size = new Size(230, 38);
            markNumericUpDown.TabIndex = 8;
            // 
            // markLabel
            // 
            markLabel.AutoSize = true;
            markLabel.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            markLabel.ForeColor = SystemColors.ActiveCaptionText;
            markLabel.Location = new Point(52, 431);
            markLabel.Name = "markLabel";
            markLabel.Size = new Size(196, 31);
            markLabel.TabIndex = 9;
            markLabel.Text = "Điểm hàng đơn vị";
            // 
            // markDecimalLabel
            // 
            markDecimalLabel.AutoSize = true;
            markDecimalLabel.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            markDecimalLabel.ForeColor = SystemColors.ActiveCaptionText;
            markDecimalLabel.Location = new Point(577, 431);
            markDecimalLabel.Name = "markDecimalLabel";
            markDecimalLabel.Size = new Size(237, 31);
            markDecimalLabel.TabIndex = 10;
            markDecimalLabel.Text = "Điểm phần thập phân";
            // 
            // markDecimalNumericUpDown
            // 
            markDecimalNumericUpDown.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            markDecimalNumericUpDown.Location = new Point(842, 424);
            markDecimalNumericUpDown.Name = "markDecimalNumericUpDown";
            markDecimalNumericUpDown.Size = new Size(230, 38);
            markDecimalNumericUpDown.TabIndex = 11;
            // 
            // confirmButton
            // 
            confirmButton.BackColor = Color.FromArgb(84, 178, 145);
            confirmButton.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            confirmButton.ForeColor = SystemColors.ControlLight;
            confirmButton.Location = new Point(919, 567);
            confirmButton.Name = "confirmButton";
            confirmButton.Size = new Size(153, 57);
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
            label1.Location = new Point(466, 85);
            label1.Name = "label1";
            label1.Size = new Size(209, 50);
            label1.TabIndex = 13;
            label1.Text = "Nhập điểm";
            // 
            // clearDataButton
            // 
            clearDataButton.BackColor = Color.FromArgb(192, 64, 0);
            clearDataButton.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            clearDataButton.ForeColor = SystemColors.ControlLight;
            clearDataButton.Location = new Point(764, 567);
            clearDataButton.Name = "clearDataButton";
            clearDataButton.Size = new Size(136, 57);
            clearDataButton.TabIndex = 14;
            clearDataButton.Text = "Nhập lại";
            clearDataButton.UseVisualStyleBackColor = false;
            // 
            // returnButton
            // 
            returnButton.BackColor = Color.FromArgb(192, 64, 0);
            returnButton.FlatStyle = FlatStyle.Popup;
            returnButton.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            returnButton.ForeColor = Color.Transparent;
            returnButton.Image = (Image)resources.GetObject("returnButton.Image");
            returnButton.Location = new Point(38, 20);
            returnButton.Name = "returnButton";
            returnButton.Size = new Size(66, 39);
            returnButton.TabIndex = 15;
            returnButton.UseVisualStyleBackColor = false;
            returnButton.Click += button3_Click;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox1.Location = new Point(202, 296);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(323, 38);
            textBox1.TabIndex = 16;
            // 
            // maKyThiLabel
            // 
            maKyThiLabel.AutoSize = true;
            maKyThiLabel.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            maKyThiLabel.ForeColor = SystemColors.ActiveCaptionText;
            maKyThiLabel.Location = new Point(52, 296);
            maKyThiLabel.Name = "maKyThiLabel";
            maKyThiLabel.Size = new Size(108, 31);
            maKyThiLabel.TabIndex = 17;
            maKyThiLabel.Text = "Mã kỳ thi";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dateTimePicker1.Location = new Point(202, 360);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(323, 38);
            dateTimePicker1.TabIndex = 18;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.ActiveCaptionText;
            label2.Location = new Point(52, 360);
            label2.Name = "label2";
            label2.Size = new Size(135, 31);
            label2.TabIndex = 19;
            label2.Text = "Ngày dự thi";
            // 
            // NhapKetQua
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(label2);
            Controls.Add(dateTimePicker1);
            Controls.Add(maKyThiLabel);
            Controls.Add(textBox1);
            Controls.Add(returnButton);
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
            Name = "NhapKetQua";
            Size = new Size(1200, 800);
            ((System.ComponentModel.ISupportInitialize)markNumericUpDown).EndInit();
            ((System.ComponentModel.ISupportInitialize)markDecimalNumericUpDown).EndInit();
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
        private Button returnButton;
        private OpenFileDialog openFileDialog1;


        private void button1_Click(object sender, EventArgs e)
        {
            // Handle the confirm button click event
            // You can add your logic here to process the input data
            MessageBox.Show("Xác nhận thành công!");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            // Handle the return button click event
            // You can add your logic here to navigate back or close the form
            MessageBox.Show("Quay lại!");
        }

        private TextBox textBox1;
        private Label maKyThiLabel;
        private DateTimePicker dateTimePicker1;
        private Label label2;
    }
}
