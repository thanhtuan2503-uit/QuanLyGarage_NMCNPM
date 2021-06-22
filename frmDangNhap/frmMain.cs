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
    public partial class frmMain : Form
    {
        DateTime now = DateTime.Now;
       

        public frmMain()
        {
            InitializeComponent();
            
        }

        #region Methods

        #endregion

        #region Events
        private void đăngXuấtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void thôngTinTàiKhoảnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fAccountProfile fAP = new fAccountProfile();
            fAP.ShowDialog();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'quanLyGarageDataSet.TIENCONG' table. You can move, or remove it, as needed.
            this.tIENCONGTableAdapter.Fill(this.quanLyGarageDataSet.TIENCONG);
            // TODO: This line of code loads data into the 'quanLyGarageDataSet.PHUTUNG' table. You can move, or remove it, as needed.
            this.pHUTUNGTableAdapter.Fill(this.quanLyGarageDataSet.PHUTUNG);
            // TODO: This line of code loads data into the 'quanLyGarageDataSet.XE' table. You can move, or remove it, as needed.
            this.xETableAdapter.Fill(this.quanLyGarageDataSet.XE);
            // TODO: This line of code loads data into the 'quanLyGarageDataSet.HIEUXE' table. You can move, or remove it, as needed.
            this.hIEUXETableAdapter.Fill(this.quanLyGarageDataSet.HIEUXE);
            // Lấy dữ liệu các xe đã tiếp nhận
            dataGridViewXeDaTiepNhan.DataSource = XeBUS.Instance.CacXeDaTiepNhan();
            dataGridViewXeDaTiepNhan.Show();
            // Lấy thông tin cho progressbar số xe đã tiếp nhận 1 ngày
            textBoxNgayThuTien.Text = now.ToString("dd-MM-yyyy");
            progressBarSoXeDaThem.Maximum = QuyDinhBUS.Instance.LaySoXeSuaToiDa();
            progressBarSoXeDaThem.Value = XeBUS.Instance.SoXeTiepNhanTrongNgay(now);


        }

        //xử lý layout Tiếp nhận xe------------------------------
        private void buttonClear_Click(object sender, EventArgs e)
        {
            txtBoxTenKH.Clear();
            txtBoxDienThoai.Clear();
            txtBoxDiaChi.Clear();
            txtBoxBienSo.Clear();
        }

        private void buttonLamMoi_Click(object sender, EventArgs e)
        {
            dataGridViewXeDaTiepNhan.DataSource = XeBUS.Instance.LamMoiDanhSachXe();
            dataGridViewXeDaTiepNhan.Show();
        }

        // xử lí button Thêm xe


        private void buttonThemXe_Click(object sender, EventArgs e)
        {
            if (txtBoxTenKH.Text.Length == 0)
                MessageBox.Show("Vui lòng nhập tên khách hàng!");
            else
            {
                if (txtBoxDienThoai.Text.Length == 0)
                    MessageBox.Show("Vui lòng nhập điện thoại của khách hàng!");
                else
                {
                    if (txtBoxDiaChi.Text.Length == 0)
                        MessageBox.Show("Vui lòng nhập địa chỉ khách hàng!");
                    else
                    {
                        if (txtBoxBienSo.Text.Length == 0)
                            MessageBox.Show("Vui lòng nhập biển số xe !");
                    }
                }
            }
            int test = 0;
            test = KhachHangBUS.Instance.ThemKhachHang(txtBoxTenKH.Text, txtBoxDienThoai.Text, txtBoxDiaChi.Text);      //thuc hien them khach hang moi
            test = XeBUS.Instance.ThemXe(txtBoxBienSo.Text, comBoxHieuXe.SelectedValue.ToString(), KhachHangBUS.Instance.LayMaKH(txtBoxTenKH.Text, txtBoxDienThoai.Text), now);
            if (test != 0)
            {
                MessageBox.Show("Thêm xe thành công!");
                progressBarSoXeDaThem.Value = progressBarSoXeDaThem.Value + 1;
                this.xETableAdapter.Fill(this.quanLyGarageDataSet.XE);
            }
            if (progressBarSoXeDaThem.Value == progressBarSoXeDaThem.Maximum)
            {
                txtBoxTenKH.Clear();
                txtBoxDienThoai.Clear();
                txtBoxDiaChi.Clear();
                txtBoxBienSo.Clear();
                txtBoxTenKH.Visible = false;
                txtBoxDienThoai.Visible = false;
                txtBoxDiaChi.Visible = false;
                txtBoxBienSo.Visible = false;
                buttonThemXe.Enabled = false;
                buttonClear.Enabled = false;
            }
            else
            {
                txtBoxTenKH.Clear();
                txtBoxDienThoai.Clear();
                txtBoxDiaChi.Clear();
                txtBoxBienSo.Clear();
            }
        }



        #endregion

      

       
    }
}
