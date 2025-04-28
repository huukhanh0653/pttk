namespace WinFormsApp1
{
    partial class Signup
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
            textBox_email = new TextBox();
            label_login = new Label();
            label_email = new Label();
            textBox_confirm_password = new TextBox();
            label_retype_password = new Label();
            button_singup = new Button();
            textBox_password = new TextBox();
            label_password = new Label();
            textBox_username = new TextBox();
            label_username = new Label();
            panel_LoginForm.SuspendLayout();
            SuspendLayout();
            // 
            // panel_LoginForm
            // 
            panel_LoginForm.BackColor = Color.FromArgb(36, 46, 72);
            panel_LoginForm.Controls.Add(textBox_email);
            panel_LoginForm.Controls.Add(label_login);
            panel_LoginForm.Controls.Add(label_email);
            panel_LoginForm.Controls.Add(textBox_confirm_password);
            panel_LoginForm.Controls.Add(label_retype_password);
            panel_LoginForm.Controls.Add(button_singup);
            panel_LoginForm.Controls.Add(textBox_password);
            panel_LoginForm.Controls.Add(label_password);
            panel_LoginForm.Controls.Add(textBox_username);
            panel_LoginForm.Controls.Add(label_username);
            panel_LoginForm.Dock = DockStyle.Fill;
            panel_LoginForm.Location = new Point(0, 0);
            panel_LoginForm.Margin = new Padding(3, 4, 3, 4);
            panel_LoginForm.Name = "panel_LoginForm";
            panel_LoginForm.Size = new Size(1257, 933);
            panel_LoginForm.TabIndex = 2;
            // 
            // textBox_email
            // 
            textBox_email.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox_email.Location = new Point(400, 227);
            textBox_email.Margin = new Padding(3, 4, 3, 4);
            textBox_email.Name = "textBox_email";
            textBox_email.Size = new Size(439, 29);
            textBox_email.TabIndex = 9;
            textBox_email.TextChanged += textBox_email_TextChanged;
            // 
            // label_login
            // 
            label_login.Anchor = AnchorStyles.Left;
            label_login.AutoSize = true;
            label_login.BackColor = Color.Transparent;
            label_login.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label_login.ForeColor = SystemColors.ActiveCaptionText;
            label_login.Location = new Point(554, 135);
            label_login.Name = "label_login";
            label_login.Size = new Size(122, 37);
            label_login.TabIndex = 0;
            label_login.Text = "Đăng ký";
            label_login.Click += label_Login_Click;
            // 
            // label_email
            // 
            label_email.AutoSize = true;
            label_email.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label_email.ForeColor = SystemColors.ControlLight;
            label_email.Location = new Point(400, 279);
            label_email.Name = "label_email";
            label_email.Size = new Size(59, 28);
            label_email.TabIndex = 8;
            label_email.Text = "Email";
            label_email.Click += label1_Click_1;
            // 
            // textBox_confirm_password
            // 
            textBox_confirm_password.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox_confirm_password.Location = new Point(400, 497);
            textBox_confirm_password.Margin = new Padding(3, 4, 3, 4);
            textBox_confirm_password.Name = "textBox_confirm_password";
            textBox_confirm_password.Size = new Size(439, 29);
            textBox_confirm_password.TabIndex = 7;
            textBox_confirm_password.UseSystemPasswordChar = true;
            // 
            // label_retype_password
            // 
            label_retype_password.AutoSize = true;
            label_retype_password.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label_retype_password.ForeColor = SystemColors.ControlLight;
            label_retype_password.Location = new Point(400, 465);
            label_retype_password.Name = "label_retype_password";
            label_retype_password.Size = new Size(171, 28);
            label_retype_password.TabIndex = 6;
            label_retype_password.Text = "Nhập lại mật khẩu";
            label_retype_password.Click += label1_Click;
            // 
            // button_singup
            // 
            button_singup.BackColor = Color.FromArgb(84, 178, 145);
            button_singup.BackgroundImageLayout = ImageLayout.None;
            button_singup.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button_singup.ForeColor = SystemColors.ButtonHighlight;
            button_singup.Location = new Point(482, 559);
            button_singup.Margin = new Padding(3, 4, 3, 4);
            button_singup.Name = "button_singup";
            button_singup.Size = new Size(266, 59);
            button_singup.TabIndex = 5;
            button_singup.Text = "Đăng ký";
            button_singup.UseVisualStyleBackColor = false;
            button_singup.Click += button_singup_Click;
            // 
            // textBox_password
            // 
            textBox_password.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox_password.Location = new Point(400, 401);
            textBox_password.Margin = new Padding(3, 4, 3, 4);
            textBox_password.Name = "textBox_password";
            textBox_password.PasswordChar = '*';
            textBox_password.Size = new Size(439, 29);
            textBox_password.TabIndex = 4;
            textBox_password.UseSystemPasswordChar = true;
            // 
            // label_password
            // 
            label_password.AutoSize = true;
            label_password.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label_password.ForeColor = SystemColors.ControlLight;
            label_password.Location = new Point(400, 369);
            label_password.Name = "label_password";
            label_password.Size = new Size(94, 28);
            label_password.TabIndex = 3;
            label_password.Text = "Mật khẩu";
            label_password.Click += label_password_Click;
            // 
            // textBox_username
            // 
            textBox_username.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox_username.Location = new Point(400, 311);
            textBox_username.Margin = new Padding(3, 4, 3, 4);
            textBox_username.Name = "textBox_username";
            textBox_username.Size = new Size(439, 29);
            textBox_username.TabIndex = 2;
            // 
            // label_username
            // 
            label_username.AutoSize = true;
            label_username.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label_username.ForeColor = SystemColors.ActiveCaptionText;
            label_username.Location = new Point(400, 195);
            label_username.Name = "label_username";
            label_username.Size = new Size(127, 28);
            label_username.TabIndex = 1;
            label_username.Text = "Tên tài khoản";
            label_username.Click += label_username_Click;
            // 
            // Signup
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            Controls.Add(panel_LoginForm);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Signup";
            Size = new Size(1257, 933);
            panel_LoginForm.ResumeLayout(false);
            panel_LoginForm.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel_LoginForm;
        private Button button_singup;
        private TextBox textBox_password;
        private Label label_password;
        private TextBox textBox_username;
        private Label label_username;
        private Label label_login;
        private TextBox textBox_confirm_password;
        private Label label_retype_password;
        private Label label_email;
        private TextBox textBox_email;
    }
}
