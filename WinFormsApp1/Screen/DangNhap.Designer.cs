using WinFormsApp1.Business;

namespace WinFormsApp1
{


    partial class DangNhap
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
            btnLogin = new Button();
            txtPassword = new TextBox();
            lblPassword = new Label();
            txtUsername = new TextBox();
            lblUsername = new Label();
            lblLogin = new Label();
            panel_LoginForm.SuspendLayout();
            SuspendLayout();
            // 
            // panel_LoginForm
            // 
            panel_LoginForm.AutoSize = true;
            panel_LoginForm.BackColor = SystemColors.ControlLight;
            panel_LoginForm.Controls.Add(btnLogin);
            panel_LoginForm.Controls.Add(txtPassword);
            panel_LoginForm.Controls.Add(lblPassword);
            panel_LoginForm.Controls.Add(txtUsername);
            panel_LoginForm.Controls.Add(lblUsername);
            panel_LoginForm.Controls.Add(lblLogin);
            panel_LoginForm.Dock = DockStyle.Fill;
            panel_LoginForm.Location = new Point(0, 0);
            panel_LoginForm.Name = "panel_LoginForm";
            panel_LoginForm.Size = new Size(1100, 700);
            panel_LoginForm.TabIndex = 1;
            panel_LoginForm.Paint += panel_LoginForm_Paint;
            // 
            // btnLogin
            // 
            btnLogin.BackColor = Color.FromArgb(84, 178, 145);
            btnLogin.BackgroundImageLayout = ImageLayout.None;
            btnLogin.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLogin.ForeColor = SystemColors.ButtonHighlight;
            btnLogin.Location = new Point(449, 369);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(233, 44);
            btnLogin.TabIndex = 5;
            btnLogin.Text = "Đăng nhập";
            btnLogin.UseVisualStyleBackColor = false;
            btnLogin.Click += button_Login_Click;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(369, 319);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(385, 23);
            txtPassword.TabIndex = 4;
            txtPassword.UseSystemPasswordChar = true;
            // 
            // lblPassword
            // 
            lblPassword.AutoSize = true;
            lblPassword.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblPassword.ForeColor = SystemColors.ActiveCaptionText;
            lblPassword.Location = new Point(372, 295);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(75, 21);
            lblPassword.TabIndex = 3;
            lblPassword.Text = "Mật khẩu";
            // 
            // txtUsername
            // 
            txtUsername.Location = new Point(369, 258);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(385, 23);
            txtUsername.TabIndex = 2;
            // 
            // lblUsername
            // 
            lblUsername.AutoSize = true;
            lblUsername.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblUsername.ForeColor = SystemColors.ActiveCaptionText;
            lblUsername.Location = new Point(369, 232);
            lblUsername.Name = "lblUsername";
            lblUsername.Size = new Size(101, 21);
            lblUsername.TabIndex = 1;
            lblUsername.Text = "Tên tài khoản";
            // 
            // lblLogin
            // 
            lblLogin.AutoSize = true;
            lblLogin.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblLogin.ForeColor = SystemColors.ActiveCaptionText;
            lblLogin.Location = new Point(500, 191);
            lblLogin.Name = "lblLogin";
            lblLogin.Size = new Size(121, 30);
            lblLogin.TabIndex = 0;
            lblLogin.Text = "Đăng nhập";
            // 
            // DangNhap
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panel_LoginForm);
            Name = "DangNhap";
            Size = new Size(1100, 700);
            panel_LoginForm.ResumeLayout(false);
            panel_LoginForm.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label lblLogin;
        private Panel panel_LoginForm;
        private Label lblUsername;
        private TextBox txtUsername;
        private Label lblPassword;
        private TextBox txtPassword;
        private Button btnLogin;

    }
}
