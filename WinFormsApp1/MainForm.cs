using System;
using System.Drawing;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            SwitchUserControl(new Login());
        }

        public void SwitchUserControl(UserControl newControl)
        {
            this.Controls.Clear();
            newControl.Anchor = AnchorStyles.None;
            newControl.Location = new Point(
                (this.ClientSize.Width - newControl.Width) / 2,
                (this.ClientSize.Height - newControl.Height) / 2
            );
            this.Controls.Add(newControl);
            newControl.BringToFront();
        }

        protected override void OnResize(EventArgs e)
        {
            base.OnResize(e);
            if (this.Controls.Count > 0)
            {
                UserControl currentControl = (UserControl)this.Controls[0];
                currentControl.Location = new Point(
                    (this.ClientSize.Width - currentControl.Width) / 2,
                    (this.ClientSize.Height - currentControl.Height) / 2
                );
            }
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}