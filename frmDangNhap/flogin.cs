using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using BUS_QuanLy;

namespace frmDangNhap
{
    public partial class fLogin : Form
    {
        public fLogin()
        {
            InitializeComponent();
        }


        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (tbUserName.Text.Length == 0)
                MessageBox.Show("Vui lòng nhập tài khoản!");

            else if (tbPassword.Text.Length == 0)
                MessageBox.Show("Vui lòng nhập mật khẩu!");
            else
            {
                string TaiKhoan = tbUserName.Text;
                string MatKhau = tbPassword.Text;
                
                if (DangNhap(TaiKhoan, MatKhau))
                {
                    MessageBox.Show("Đăng nhập thành công!", "Thông báo");
                    frmMain frm = new frmMain();
                    this.Hide();
                    frm.ShowDialog();
                    this.Show();
                    tbUserName.Clear();
                    tbPassword.Clear();
                }
                else
                {
                    MessageBox.Show("Vui lòng kiểm tra lại tên hoặc mật khẩu!");
                }
            }
            

        }

        bool DangNhap(string TaiKhoan, string MatKhau)
        {
            return TaiKhoanBUS.Instance.DangNhap(TaiKhoan, MatKhau);
        }

        private void fLogin_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Bạn có thực sự muốn thoát chương trình?", "Thông báo", MessageBoxButtons.OKCancel) != System.Windows.Forms.DialogResult.OK)
            {
                e.Cancel = true;
            }
        }
    }
}
