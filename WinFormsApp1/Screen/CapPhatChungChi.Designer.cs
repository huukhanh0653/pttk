namespace WinFormsApp1.Screen
{
    partial class CapPhatChungChi
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CapPhatChungChi));
            label1 = new Label();
            btnReturn = new Button();
            dgvDSChungChi = new DataGridView();
            btnSearchChungChi = new Button();
            txtSearchChungChi = new TextBox();
            btnCapPhatChungChi = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvDSChungChi).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(459, 40);
            label1.Name = "label1";
            label1.Size = new Size(263, 37);
            label1.TabIndex = 0;
            label1.Text = "Cấp phát chứng chỉ";
            // 
            // btnReturn
            // 
            btnReturn.BackColor = Color.Transparent;
            btnReturn.BackgroundImage = (Image)resources.GetObject("btnReturn.BackgroundImage");
            btnReturn.BackgroundImageLayout = ImageLayout.Center;
            btnReturn.FlatStyle = FlatStyle.Flat;
            btnReturn.ForeColor = Color.Transparent;
            btnReturn.Location = new Point(44, 46);
            btnReturn.Margin = new Padding(3, 2, 3, 2);
            btnReturn.Name = "btnReturn";
            btnReturn.Size = new Size(40, 31);
            btnReturn.TabIndex = 20;
            btnReturn.UseVisualStyleBackColor = false;
            // 
            // dgvDSChungChi
            // 
            dgvDSChungChi.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDSChungChi.Location = new Point(44, 130);
            dgvDSChungChi.Name = "dgvDSChungChi";
            dgvDSChungChi.Size = new Size(1094, 562);
            dgvDSChungChi.TabIndex = 21;
            dgvDSChungChi.CellContentClick += dgvDSChungChi_CellContentClick;
            dgvDSChungChi.CellMouseClick += dgvDSChungChi_CellClick;
            // 
            // btnSearchChungChi
            // 
            btnSearchChungChi.BackgroundImage = Properties.Resources.search;
            btnSearchChungChi.BackgroundImageLayout = ImageLayout.Center;
            btnSearchChungChi.Location = new Point(1104, 93);
            btnSearchChungChi.Margin = new Padding(3, 2, 3, 2);
            btnSearchChungChi.Name = "btnSearchChungChi";
            btnSearchChungChi.Size = new Size(33, 31);
            btnSearchChungChi.TabIndex = 23;
            btnSearchChungChi.UseVisualStyleBackColor = true;
            // 
            // txtSearchChungChi
            // 
            txtSearchChungChi.ForeColor = Color.Black;
            txtSearchChungChi.Location = new Point(815, 98);
            txtSearchChungChi.Name = "txtSearchChungChi";
            txtSearchChungChi.Size = new Size(283, 23);
            txtSearchChungChi.TabIndex = 22;
            // 
            // btnCapPhatChungChi
            // 
            btnCapPhatChungChi.Location = new Point(921, 697);
            btnCapPhatChungChi.Margin = new Padding(3, 2, 3, 2);
            btnCapPhatChungChi.Name = "btnCapPhatChungChi";
            btnCapPhatChungChi.Size = new Size(217, 54);
            btnCapPhatChungChi.TabIndex = 24;
            btnCapPhatChungChi.Text = "Cấp phát chứng chỉ";
            btnCapPhatChungChi.UseVisualStyleBackColor = true;
            btnCapPhatChungChi.Click += btnCapPhatChungChi_Click;
            // 
            // CapPhatChungChi
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(btnCapPhatChungChi);
            Controls.Add(btnSearchChungChi);
            Controls.Add(txtSearchChungChi);
            Controls.Add(dgvDSChungChi);
            Controls.Add(btnReturn);
            Controls.Add(label1);
            Name = "CapPhatChungChi";
            Size = new Size(1200, 800);
            ((System.ComponentModel.ISupportInitialize)dgvDSChungChi).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button btnReturn;
        private DataGridView dgvDSChungChi;
        private Button btnSearchChungChi;
        private TextBox txtSearchChungChi;
        private Button btnCapPhatChungChi;
    }
}
