namespace WinFormsApp1
{
    partial class Login
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
            panel_LoginForm = new Panel();
            button_Login = new Button();
            textBox2 = new TextBox();
            label_password = new Label();
            textBox1 = new TextBox();
            label_Username = new Label();
            label_Login = new Label();
            panel_LoginForm.SuspendLayout();
            SuspendLayout();
            // 
            // panel_LoginForm
            // 
            panel_LoginForm.AutoSize = true;
            panel_LoginForm.BackColor = SystemColors.ControlLight;
            panel_LoginForm.Controls.Add(button_Login);
            panel_LoginForm.Controls.Add(textBox2);
            panel_LoginForm.Controls.Add(label_password);
            panel_LoginForm.Controls.Add(textBox1);
            panel_LoginForm.Controls.Add(label_Username);
            panel_LoginForm.Controls.Add(label_Login);
            panel_LoginForm.Dock = DockStyle.Fill;
            panel_LoginForm.Location = new Point(0, 0);
            panel_LoginForm.Margin = new Padding(3, 4, 3, 4);
            panel_LoginForm.Name = "panel_LoginForm";
            panel_LoginForm.Size = new Size(1200, 800);
            panel_LoginForm.TabIndex = 1;
            panel_LoginForm.Paint += panel_LoginForm_Paint;
            // 
            // button_Login
            // 
            button_Login.BackColor = Color.FromArgb(84, 178, 145);
            button_Login.BackgroundImageLayout = ImageLayout.None;
            button_Login.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button_Login.ForeColor = SystemColors.ButtonHighlight;
            button_Login.Location = new Point(513, 371);
            button_Login.Margin = new Padding(3, 4, 3, 4);
            button_Login.Name = "button_Login";
            button_Login.Size = new Size(266, 59);
            button_Login.TabIndex = 5;
            button_Login.Text = "Đăng nhập";
            button_Login.UseVisualStyleBackColor = false;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(422, 304);
            textBox2.Margin = new Padding(3, 4, 3, 4);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(439, 27);
            textBox2.TabIndex = 4;
            textBox2.UseSystemPasswordChar = true;
            // 
            // label_password
            // 
            label_password.AutoSize = true;
            label_password.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label_password.ForeColor = SystemColors.ActiveCaptionText;
            label_password.Location = new Point(425, 272);
            label_password.Name = "label_password";
            label_password.Size = new Size(94, 28);
            label_password.TabIndex = 3;
            label_password.Text = "Mật khẩu";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(422, 223);
            textBox1.Margin = new Padding(3, 4, 3, 4);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(439, 27);
            textBox1.TabIndex = 2;
            // 
            // label_Username
            // 
            label_Username.AutoSize = true;
            label_Username.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label_Username.ForeColor = SystemColors.ActiveCaptionText;
            label_Username.Location = new Point(422, 188);
            label_Username.Name = "label_Username";
            label_Username.Size = new Size(127, 28);
            label_Username.TabIndex = 1;
            label_Username.Text = "Tên tài khoản";
            // 
            // label_Login
            // 
            label_Login.AutoSize = true;
            label_Login.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label_Login.ForeColor = SystemColors.ActiveCaptionText;
            label_Login.Location = new Point(571, 133);
            label_Login.Name = "label_Login";
            label_Login.Size = new Size(156, 37);
            label_Login.TabIndex = 0;
            label_Login.Text = "Đăng nhập";
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panel_LoginForm);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Login";
            Size = new Size(1257, 933);
            panel_LoginForm.ResumeLayout(false);
            panel_LoginForm.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label_Login;
        private Panel panel_LoginForm;
        private Label label_Username;
        private TextBox textBox1;
        private Label label_password;
        private TextBox textBox2;
        private Button button_Login;
    }
}
