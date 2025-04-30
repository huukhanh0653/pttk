using System;
using System.Drawing;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class MainForm : Form
    {
        private MainForm()
        {
            InitializeComponent();
        }

        private static MainForm instance;

        public static MainForm Instance
        {
            get
            {
                if (instance == null || instance.IsDisposed)
                {
                    instance = new MainForm();
                }
                return instance;
            }
        }

        public void SwitchUserControl(UserControl newControl)
        {
            this.Controls.Clear();
            newControl.Anchor = AnchorStyles.None;
            this.ClientSize = new Size(1200, 800);
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
            SwitchUserControl(new DangNhap());
        }

    }
}