using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinFormsApp1.Business;
using WinFormsApp1.DAO;

namespace WinFormsApp1
{
    public partial class DangNhap : UserControl
    {

        public DangNhap()
        {
            InitializeComponent();
        }

        private void button_Login_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text;
            string password = txtPassword.Text;

            int maChucVu = DangNhapBUS.Instance.dangNhap(username, password);

            if (maChucVu == -1)
            {
                MessageBox.Show("Đăng nhập không thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.txtPassword.Clear();
                return;
            }

            // Handle successful login based on maChucVu
            switch (maChucVu)
            {
                case -1:
                    MessageBox.Show("Mã chức vụ: " + maChucVu, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.txtPassword.Clear();
                    break;
                case 1:
                    // Manager
                    MainForm.Instance.SwitchUserControl(new Main());
                    break;
                case 2:
                    // Nhan Vien Tiep Nhan
                    MainForm.Instance.SwitchUserControl(new Main());
                    break;
                case 3:
                    // Nhan Vien Ke Toan
                    MainForm.Instance.SwitchUserControl(new Main());
                    break;
                case 4:
                    // Nhan Vien Nhap Lieu
                    MainForm.Instance.SwitchUserControl(new Main());
                    break;
                default:
                    MessageBox.Show("Đăng nhập thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    break;
            }

        }

        //private void linkLabel_signup_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        //{
        //    // Switch to the Signup user control
        //    Signup signupControl = new Signup();
        //    this.Parent.Controls.Add(signupControl);
        //    this.Parent.Controls.Remove(this);
        //}

        private void panel_LoginForm_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
