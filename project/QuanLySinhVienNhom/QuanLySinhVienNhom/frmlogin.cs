using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;

namespace QuanLySinhVienNhom
{
    public partial class frmlogin : Form
    {
        public String Ten;

        public frmlogin()
        {
            InitializeComponent();
        }

        
        SqlConnection con;

        private void frmlogin_Load(object sender, EventArgs e)
        {
            string connect = ConfigurationManager.ConnectionStrings["QLSV"].ConnectionString.ToString();
            con = new SqlConnection(connect);
            
        }
       
        /// <summary>
        /// Kiểm tra câu lệnh sql
        /// </summary>
        /// <param name="sql">câu lệnh sql</param>
        /// <returns>Trả về true nếu đúng, false nếu sai</returns>
        private bool kiemtra(string sql)
        {
            SqlCommand cmdCheck = new SqlCommand(sql, con);
            SqlDataReader dt = cmdCheck.ExecuteReader();
            if (dt.Read() == true)
            {
                dt.Close();
                return true;
            }
            else
            {
                dt.Close();
                return false;
            }
        }


        private void btnDangnhap_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();

                SqlCommand cmd = new SqlCommand("SELECT TenDangNhap, MatKhau FROM nguoidung WHERE TenDangNhap=@userName and MatKhau=@passWord", con);
                cmd.Parameters.Add(new SqlParameter("@userName", txtUser.Text));
                cmd.Parameters.Add(new SqlParameter("@passWord", txtPassword.Text));
                SqlDataReader dr = cmd.ExecuteReader();

                if (dr.Read())
                {
                    con.Close();
                    dr.Close();

                    frmHome f = new frmHome();
                    f.Ten = txtUser.Text;
                    this.Hide();
                    if (txtUser.Text == "Admin")
                    {
                        MessageBox.Show("Dang nhap thanh cong quyen Admin");
                        f.Show();
                    }

                    if (txtUser.Text == "GV01")
                    {
                        MessageBox.Show("Dang nhap thanh cong voi GV: 01");
                        f.Show();
                    }
                    if (txtUser.Text == "SV01")
                    {
                        MessageBox.Show("Dang nhap thanh cong voi MaSV: 01");
                        f.Show();
                    }
                }
                else
                {
                    MessageBox.Show("Invalid User! Try again with VALID username and password");
                }
                if (!dr.IsClosed)
                    dr.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                if (con.State == System.Data.ConnectionState.Open)
                    con.Close();
                con.Dispose();
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Close();
        }

    }
}
