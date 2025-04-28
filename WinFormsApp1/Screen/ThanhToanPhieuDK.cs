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
    public partial class ThanhToanPhieuDK : UserControl
    {   

        public ThanhToanPhieuDK()
        {
            MH_ThanhToanPhieuDK_Load();
        }

        private void MH_ThanhToanPhieuDK_Load()
        {
            InitializeComponent();
        }

        private void btnThanhToan_Click(object sender, EventArgs e)
        {
            string keyword = txtboxTimKiem.Text.Trim();
            if (string.IsNullOrEmpty(keyword))
            {
                MessageBox.Show("Vui lòng nhập số điện thoại hoặc mã phiếu để thanh toán.");
                return;
            }
        }

        private void btnKiemTra_Click(object sender, EventArgs e)
        {

        }

        private void txtboxTimKiem_TextChanged(object sender, EventArgs e)
        {
            
        }
    }
}
