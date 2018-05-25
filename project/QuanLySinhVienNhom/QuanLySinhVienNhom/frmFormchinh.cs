using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace QuanLySinhVienNhom
{
    
    public partial class frmHome : Form
    {
        private string quyenhan;
        frmlogin dangnhap;

        public string Ten
        {
            get { return quyenhan; }
            set { quyenhan = value; }
        }

        public frmHome()
        {
            InitializeComponent();
        }

        private void frmHome_Load(object sender, EventArgs e)
        {
            view_Menu.Enabled = false;
            input_Menu.Enabled = false;

            if (Ten == "Admin")
            {
                view_Menu.Enabled = true;
                input_Menu.Enabled = true;
            }
            else if (Ten == "GV01")
            {
                view_Menu.Enabled = true;
                sinhVien_Menu_Item.Enabled = false;
                giangVien_Menu_item.Enabled = true;
                input_Menu.Enabled = false;
            }
            else if(Ten == "SV01")
            {
                view_Menu.Enabled = true;
                sinhVien_Menu_Item.Enabled = true;
                giangVien_Menu_item.Enabled = false;
                input_Menu.Enabled = false;
            }
        }
        private void LoadBasic()
        {
            view_Menu.Enabled = true;
            input_Menu.Enabled = true;
        }

        private void đăngNhậpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //if (!kiemtratontai("frmlogin"))
            //{
            //    frmlogin dangnhap = new frmlogin();
            //    dangnhap.MdiParent = this;
            //    dangnhap.Show();
            //    LoadBasic();
            //}
            //else
            //{
            //    MessageBox.Show("File hiện đã tồn tại trên hệ thống!");
            //    hanhdong("frmlogin");
            //}

            if (dangnhap == null || dangnhap.IsDisposed)
            {
                dangnhap = new frmlogin();
                dangnhap.MdiParent = this;
                dangnhap.Show();
            }
        }

        private void thoátToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult dl = MessageBox.Show("Bạn có muốn thoát chương trình không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if(dl == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void sinhViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmThongtinSV ttsinhvien = new frmThongtinSV();
            ttsinhvien.MdiParent = this;
            ttsinhvien.Show();
            ttsinhvien.Visible = true;
        }

        private void giảngViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmThongtinGV ttgiangvien = new frmThongtinGV();
            ttgiangvien.MdiParent = this;
            ttgiangvien.Show();
            ttgiangvien.Visible = true;
        }

        private void accountToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmNhapGVvaSV input = new frmNhapGVvaSV();
            input.MdiParent = this;
            input.Show();
            input.Visible = true;
        }

        private void nhậpKhoaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmNhapKhoaNganhMon knm = new frmNhapKhoaNganhMon();
            knm.MdiParent = this;
            knm.Show();
            knm.Visible = true;
        }



        private void nhậpLớpHọcToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmLophoc lophoc = new frmLophoc();
            lophoc.MdiParent = this;
            lophoc.Show();
            lophoc.Visible = true;
        }

        private void nhậpĐiểmToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmNhapdiem diem = new frmNhapdiem();
            diem.MdiParent = this;
            diem.Show();
            diem.Visible = true;
        }

        private void phânCôngGiảngDạyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmPhancong phancong = new frmPhancong();
            phancong.MdiParent = this;
            phancong.Show();
            phancong.Visible = true;
        }

        private void đăngKýMônHọcToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmDangkymonhoc dangky = new frmDangkymonhoc();
            dangky.MdiParent = this;
            dangky.Show();
            dangky.Visible = true;
        }

        private void thôngTinCáNhânToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            frmThongtinGV giangvien = new frmThongtinGV();
            giangvien.MdiParent = this;
            giangvien.Show();
            giangvien.Visible = true;
        }



        /// code xử lý chan qua trình bam 2 lần 1 ô con 

        private bool kiemtratontai(string name)
        {
            bool check = false;
            foreach (Form frm in this.MdiChildren)
            {
                if (frm.Name == name)
                {
                    check = true;
                    break;
                }
            }
            return check;
        }

        private void hanhdong(string name)
        {
            foreach (Form frm in this.MdiChildren)
            {
                if (frm.Name == name)
                {
                    frm.Activate();
                    break;
                }
            }
        }

        private void xemĐiểmToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmViewdiem xemdiem = new frmViewdiem();
            xemdiem.MdiParent = this;
            xemdiem.Show();
            xemdiem.Visible = true;
        }

        private void xemMônHọcToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmViewmonhocsv xemnh = new frmViewmonhocsv();
            xemnh.MdiParent = this;
            xemnh.Show();
            xemnh.Visible = true;
        }


    }
}
