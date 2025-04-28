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
    public partial class NhapKetQua : UserControl
    {

        private DateOnly ngay_cap;
        private DateOnly ngay_hh;
        private DateOnly ngay_du_thi;
        private string indiv_id;
        private string test_id;
        private string cert_id;
        private float mark;

        public NhapKetQua()
        {
            InitializeComponent();
        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            
        }

    }
}
