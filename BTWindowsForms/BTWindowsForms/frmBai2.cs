﻿using System;
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
    public partial class frmBai2 : Form
    {
        public frmBai2()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int donGia = int.Parse(txtDonGia.Text);
            int soLuong = int.Parse(txtSoLuong.Text);
            double thanhTien = donGia * soLuong;
            if (rdChuyenKhoan.Checked)
            {
                thanhTien = 0.95 * donGia * soLuong;
            }

            lblSoTien.Text = thanhTien.ToString();   
        }

        private void cbTenHang_SelectedIndexChanged(object sender, EventArgs e)
        {
            var stt = cbTenHang.SelectedIndex;
            switch(stt)
            {
                case 0:
                    txtDonGia.Text = "100000";
                    break;
                case 1:
                    txtDonGia.Text = "200000";
                    break;
                case 2:
                    txtDonGia.Text = "150000";
                    break;
                
            }    
        }
    }
}
