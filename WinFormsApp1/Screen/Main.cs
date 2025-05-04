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
using WinFormsApp1.Screen;

namespace WinFormsApp1
{
    public partial class Main : UserControl
    {
        public Main()
        {
            InitializeComponent();
        }

        private void propertyGrid1_Click(object sender, EventArgs e)
        {

        }

        private void bindingSource1_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnGiaHan_Click(object sender, EventArgs e)
        {
            MainForm.Instance.SwitchUserControl(new GiaHan());
        }

        private void btnCapPhatCC_Click(object sender, EventArgs e)
        {
            //MainForm.Instance.SwitchUserControl(new CapPhatCC());
        }

        private void btnPhatHanh_Click(object sender, EventArgs e)
        {
            MainForm.Instance.SwitchUserControl(new PhatHanhPhieuDuThi());
        }

        private void btnThanhToanPhieuDK_Click(object sender, EventArgs e)
        {
            MainForm.Instance.SwitchUserControl(new ThanhToanPhieuDK());
        }

        private void btnDangKyThi_Click(object sender, EventArgs e)
        {
            MainForm.Instance.SwitchUserControl(new DangKyDuThi());
        }

        private void btnDangXuat_Click(object sender, EventArgs e)
        {
            DangNhapBUS.Instance.dangXuat();
            MainForm.Instance.SwitchUserControl(new DangNhap());
        }

        private void btnCapPhatCC_Click_1(object sender, EventArgs e)
        {
            MainForm.Instance.SwitchUserControl(new CapPhatChungChi());
        }
    }
}
