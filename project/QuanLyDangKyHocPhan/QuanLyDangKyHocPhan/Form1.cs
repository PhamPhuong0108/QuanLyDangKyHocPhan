﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyDangKyHocPhan
{
    public partial class frmHome : Form
    {
        public frmHome()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            Login dangNhap = new Login();
            dangNhap.Show();
            this.Visible = false;
        }

        private void frmHome_FormClosing(object sender, FormClosingEventArgs e)
        {

        }
    }
}
