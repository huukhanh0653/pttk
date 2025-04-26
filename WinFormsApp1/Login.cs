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

namespace WinFormsApp1
{
    public partial class Login : UserControl
    {
        public Login()
        {
            InitializeComponent();
        }

        //public void panel1_Paint(object sender, PaintEventArgs e)
        //{
        //    // Draw a custom border.
        //    ControlPaint.DrawBorder(e.Graphics, panel1.ClientRectangle, Color.FromArgb(36, 46, 72), ButtonBorderStyle.Solid);
        //}

        private void button_Login_Click(object sender, EventArgs e)
        {
            string username = textBox1.Text;
            string password = textBox2.Text;

            if (DataAccess.AuthenticateUser(username, password))
            {
                // If the username and password are correct, show the main form
                MainForm mainForm = new MainForm();
                mainForm.Show();
            }
            else
            {
                // If the username or password are incorrect, show an error message
                MessageBox.Show("Invalid username or password. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void linkLabel_signup_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            // Switch to the Signup user control
            Signup signupControl = new Signup();
            this.Parent.Controls.Add(signupControl);
            this.Parent.Controls.Remove(this);
        }

        private void panel_LoginForm_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
