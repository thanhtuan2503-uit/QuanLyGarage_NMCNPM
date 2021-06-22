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
                SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\TUAN\Documents\DataUser.mdf;Integrated Security=True;Connect Timeout=30");
                SqlDataAdapter sda = new SqlDataAdapter("Select Count(*) From Login where Username='" + tbUserName.Text + "' and Password='" + tbPassword.Text + "'", con);
                DataTable dt = new DataTable();
                sda.Fill(dt);

                if (dt.Rows[0][0].ToString() == "1")
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

        private void fLogin_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Bạn có thực sự muốn thoát chương trình?", "Thông báo", MessageBoxButtons.OKCancel) != System.Windows.Forms.DialogResult.OK)
            {
                e.Cancel = true;
            }
        }
    }
}
