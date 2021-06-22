using BUS_QuanLy;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace frmDangNhap
{
    public partial class fDoiMatKhau : Form
    {
        public fDoiMatKhau()
        {
            InitializeComponent();
        }

        bool XacNhanChuTaiKhoan()
        {
            return txtBoxNhapLaiMatKhauCu.Text == TaiKhoanBUS.Instance.LayMatKhau();
        }

        bool XacNhanMatKhauMoi()
        {
            return txtBoxNhapMatKhauMoi.Text == txtBoxXacNhanMatKhauMoi.Text;
        }
        private void BtnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void fDoiMatKhau_Load(object sender, EventArgs e)
        {
            txtBoxTaiKhoan.Text = TaiKhoanBUS.Instance.LayTenTaiKhoan();
            
        }


        private void btnHienMatKhauCu_Click_1(object sender, EventArgs e)
        {
            if (btnHienMatKhauCu.Text == "Hiện mật khẩu")
            {
                btnHienMatKhauCu.Text = "Ẩn mật khẩu";
                txtBoxNhapLaiMatKhauCu.UseSystemPasswordChar = !txtBoxNhapLaiMatKhauCu.UseSystemPasswordChar;
            }
            else
            {
                btnHienMatKhauCu.Text = "Hiện mật khẩu";
                txtBoxNhapLaiMatKhauCu.UseSystemPasswordChar = !txtBoxNhapLaiMatKhauCu.UseSystemPasswordChar;
            }
        }

        private void btnHienMatKhauMoi_Click_1(object sender, EventArgs e)
        {
            if (btnHienMatKhauMoi.Text == "Hiện mật khẩu")
            {
                btnHienMatKhauMoi.Text = "Ẩn mật khẩu";
                txtBoxNhapMatKhauMoi.UseSystemPasswordChar = !txtBoxNhapMatKhauMoi.UseSystemPasswordChar;
            }
            else
            {
                btnHienMatKhauMoi.Text = "Hiện mật khẩu";
                txtBoxNhapMatKhauMoi.UseSystemPasswordChar = !txtBoxNhapMatKhauMoi.UseSystemPasswordChar;
            }
        }

        private void btnHienMatKhauMoiXacNhan_Click_1(object sender, EventArgs e)
        {
            if (btnHienMatKhauMoiXacNhan.Text == "Hiện mật khẩu")
            {
                btnHienMatKhauMoiXacNhan.Text = "Ẩn mật khẩu";
                txtBoxXacNhanMatKhauMoi.UseSystemPasswordChar = !txtBoxXacNhanMatKhauMoi.UseSystemPasswordChar;
            }
            else
            {
                btnHienMatKhauMoiXacNhan.Text = "Hiện mật khẩu";
                txtBoxXacNhanMatKhauMoi.UseSystemPasswordChar = !txtBoxXacNhanMatKhauMoi.UseSystemPasswordChar;
            }
        }

        private void btnLuuThayDoi_Click_1(object sender, EventArgs e)
        {
            if (XacNhanChuTaiKhoan())
            {
                if (XacNhanMatKhauMoi())
                {
                    TaiKhoanBUS.Instance.CapNhatMatKhau(txtBoxNhapMatKhauMoi.Text, TaiKhoanBUS.Instance.LayMaTaiKhoan());
                    MessageBox.Show("Cập nhật mật khẩu thành công!", "Thành công!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Mật khẩu mới không trùng khớp. Xin vui lòng nhập lại!", "Thất bại!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtBoxNhapLaiMatKhauCu.Clear();
                    txtBoxNhapMatKhauMoi.Clear();
                    txtBoxXacNhanMatKhauMoi.Clear();
                    if (btnHienMatKhauCu.Text == "Ẩn mật khẩu")
                    {
                        btnHienMatKhauCu.Text = "Hiện mật khẩu";
                        txtBoxNhapLaiMatKhauCu.UseSystemPasswordChar = !txtBoxNhapLaiMatKhauCu.UseSystemPasswordChar;
                    }
                    if (btnHienMatKhauMoi.Text == "Ẩn mật khẩu")
                    {
                        btnHienMatKhauMoi.Text = "Hiện mật khẩu";
                        txtBoxNhapMatKhauMoi.UseSystemPasswordChar = !txtBoxNhapMatKhauMoi.UseSystemPasswordChar;
                    }
                    if (btnHienMatKhauMoiXacNhan.Text == "Ẩn mật khẩu")
                    {
                        btnHienMatKhauMoiXacNhan.Text = "Hiện mật khẩu";
                        txtBoxXacNhanMatKhauMoi.UseSystemPasswordChar = !txtBoxXacNhanMatKhauMoi.UseSystemPasswordChar;
                    }
                }
            }
            else
            {
                MessageBox.Show("Mật khẩu cũ không đúng. Xin vui lòng thử lại!", "Thất bại!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtBoxNhapLaiMatKhauCu.Clear();
                txtBoxNhapMatKhauMoi.Clear();
                txtBoxXacNhanMatKhauMoi.Clear();
                if (btnHienMatKhauCu.Text == "Ẩn mật khẩu")
                {
                    btnHienMatKhauCu.Text = "Hiện mật khẩu";
                    txtBoxNhapLaiMatKhauCu.UseSystemPasswordChar = !txtBoxNhapLaiMatKhauCu.UseSystemPasswordChar;
                }
                if (btnHienMatKhauMoi.Text == "Ẩn mật khẩu")
                {
                    btnHienMatKhauMoi.Text = "Hiện mật khẩu";
                    txtBoxNhapMatKhauMoi.UseSystemPasswordChar = !txtBoxNhapMatKhauMoi.UseSystemPasswordChar;
                }
                if (btnHienMatKhauMoiXacNhan.Text == "Ẩn mật khẩu")
                {
                    btnHienMatKhauMoiXacNhan.Text = "Hiện mật khẩu";
                    txtBoxXacNhanMatKhauMoi.UseSystemPasswordChar = !txtBoxXacNhanMatKhauMoi.UseSystemPasswordChar;
                }
            }
        }
    }
}
