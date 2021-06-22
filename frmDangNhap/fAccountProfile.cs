using BUS_QuanLy;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace frmDangNhap
{
    public partial class fAccountProfile : Form
    {
        public fAccountProfile()
        {
            InitializeComponent();
  
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnDoiMatKhau_Click(object sender, EventArgs e)
        {
            fDoiMatKhau fDMK = new fDoiMatKhau();
            fDMK.ShowDialog();
        }

        private void FrmThongTinTaiKhoan_Load(object sender, EventArgs e)
        {
           
             txtBoxHoTen.Text= TaiKhoanBUS.Instance.LayHoTen();
            txtBoxTaiKhoan.Text = TaiKhoanBUS.Instance.LayTenTaiKhoan();
            txtBoxQuyenHan.Text = TaiKhoanBUS.Instance.LayQuyenHan();
        }

    }
}
