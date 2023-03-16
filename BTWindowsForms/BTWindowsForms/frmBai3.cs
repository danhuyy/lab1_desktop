using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BTWindowsForms
{
    public partial class frmBai3 : Form
    {
        public frmBai3()
        {
            InitializeComponent();
        }

        private void btnXemkq_Click(object sender, EventArgs e)
        {
            int a = int.Parse(txta.Text);
            int b = int.Parse(txtb.Text);
            int n = int.Parse(txtn.Text);
            int kq = 0;
            if (rdTongAB.Checked)
                TinhToan.CongHaiSo(a, b,ref kq);
            else
                kq = TinhToan.TongDaySo(n);
            lblKetQua.Text = kq.ToString();
        }

        private void txta_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
