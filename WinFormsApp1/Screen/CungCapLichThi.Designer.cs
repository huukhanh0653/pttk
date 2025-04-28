namespace WinFormsApp1
{
    partial class MHCungCapLichThi
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.DataGridView dgvDSLichThi;
        private System.Windows.Forms.Button btnChonLichThi;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.ComboBox cmbFilter;
        private System.Windows.Forms.Label lblSearch;
        private System.Windows.Forms.Label lblFilter;
        private System.Windows.Forms.DateTimePicker dtpFilterByTime;
        private System.Windows.Forms.NumericUpDown nudHourSelector;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            dgvDSLichThi = new DataGridView();
            btnChonLichThi = new Button();
            txtSearch = new TextBox();
            cmbFilter = new ComboBox();
            lblSearch = new Label();
            lblFilter = new Label();
            dtpFilterByTime = new DateTimePicker();
            nudHourSelector = new NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)dgvDSLichThi).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudHourSelector).BeginInit();
            SuspendLayout();
            // 
            // dgvDSLichThi
            // 
            dgvDSLichThi.AllowUserToAddRows = false;
            dgvDSLichThi.AllowUserToDeleteRows = false;
            dgvDSLichThi.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dgvDSLichThi.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgvDSLichThi.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDSLichThi.Font = new Font("Segoe UI", 10F);
            dgvDSLichThi.Location = new Point(20, 78);
            dgvDSLichThi.Name = "dgvDSLichThi";
            dgvDSLichThi.ReadOnly = true;
            dgvDSLichThi.RowHeadersWidth = 51;
            dgvDSLichThi.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvDSLichThi.Size = new Size(760, 325);
            dgvDSLichThi.TabIndex = 4;
            dgvDSLichThi.CellContentClick += dgvDSLichThi_CellContentClick;
            // 
            // btnChonLichThi
            // 
            btnChonLichThi.Font = new Font("Segoe UI", 10F);
            btnChonLichThi.Location = new Point(650, 425);
            btnChonLichThi.Margin = new Padding(3, 4, 3, 4);
            btnChonLichThi.Name = "btnChonLichThi";
            btnChonLichThi.Size = new Size(130, 50);
            btnChonLichThi.TabIndex = 5;
            btnChonLichThi.Text = "Chọn Lịch Thi";
            btnChonLichThi.Click += btnChonLichThi_Click;
            // 
            // txtSearch
            // 
            txtSearch.Font = new Font("Segoe UI", 10F);
            txtSearch.Location = new Point(67, 25);
            txtSearch.Margin = new Padding(3, 4, 3, 4);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(191, 30);
            txtSearch.TabIndex = 0;
            txtSearch.TextChanged += txtSearch_TextChanged;
            // 
            // cmbFilter
            // 
            cmbFilter.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbFilter.Font = new Font("Segoe UI", 10F);
            cmbFilter.Location = new Point(346, 22);
            cmbFilter.Margin = new Padding(3, 4, 3, 4);
            cmbFilter.Name = "cmbFilter";
            cmbFilter.Size = new Size(135, 31);
            cmbFilter.TabIndex = 1;
            cmbFilter.SelectedIndexChanged += cmbFilter_SelectedIndexChanged;
            // 
            // lblSearch
            // 
            lblSearch.Font = new Font("Segoe UI", 10F);
            lblSearch.Location = new Point(20, 25);
            lblSearch.Name = "lblSearch";
            lblSearch.Size = new Size(41, 31);
            lblSearch.TabIndex = 2;
            lblSearch.Text = "Tìm kiếm:";
            // 
            // lblFilter
            // 
            lblFilter.Font = new Font("Segoe UI", 10F);
            lblFilter.Location = new Point(264, 25);
            lblFilter.Name = "lblFilter";
            lblFilter.Size = new Size(85, 31);
            lblFilter.TabIndex = 3;
            lblFilter.Text = "Địa điểm:";
            // 
            // dtpFilterByTime
            // 
            dtpFilterByTime.CustomFormat = "yyyy-MM-dd HH:mm";
            dtpFilterByTime.Font = new Font("Segoe UI", 10F);
            dtpFilterByTime.Format = DateTimePickerFormat.Custom;
            dtpFilterByTime.Location = new Point(487, 25);
            dtpFilterByTime.Margin = new Padding(3, 4, 3, 4);
            dtpFilterByTime.Name = "dtpFilterByTime";
            dtpFilterByTime.Size = new Size(177, 30);
            dtpFilterByTime.TabIndex = 6;
            dtpFilterByTime.ValueChanged += dtpFilterByTime_ValueChanged;
            // 
            // nudHourSelector
            // 
            nudHourSelector.Font = new Font("Segoe UI", 10F);
            nudHourSelector.Location = new Point(688, 25);
            nudHourSelector.Margin = new Padding(3, 4, 3, 4);
            nudHourSelector.Maximum = new decimal(new int[] { 24, 0, 0, 0 });
            nudHourSelector.Name = "nudHourSelector";
            nudHourSelector.Size = new Size(80, 30);
            nudHourSelector.TabIndex = 7;
            nudHourSelector.ValueChanged += nudHourSelector_ValueChanged;
            // 
            // MHCungCapLichThi
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(txtSearch);
            Controls.Add(cmbFilter);
            Controls.Add(lblSearch);
            Controls.Add(lblFilter);
            Controls.Add(dgvDSLichThi);
            Controls.Add(btnChonLichThi);
            Controls.Add(dtpFilterByTime);
            Controls.Add(nudHourSelector);
            Margin = new Padding(3, 4, 3, 4);
            Name = "MHCungCapLichThi";
            Size = new Size(1200, 800);
            ((System.ComponentModel.ISupportInitialize)dgvDSLichThi).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudHourSelector).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }
    }
}
