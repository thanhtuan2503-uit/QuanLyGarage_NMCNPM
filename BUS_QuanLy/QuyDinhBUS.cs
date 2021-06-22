using DAO_QuanLy;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS_QuanLy
{
    public class QuyDinhBUS
    {
        private static QuyDinhBUS instance;
        public static QuyDinhBUS Instance
        {
            get
            {
                if (instance == null)
                    instance = new QuyDinhBUS();
                return instance;
            }
            private set
            {
                instance = value;
            }
        }
        private QuyDinhBUS() { }
        public DataTable LayTatCaQuyDinh()
        {
            return DAO_QuanLy.QuyDinhDAO.Instance.LayTatCaQuyDinh();
        }
        public int LaySoHieuXe()
        {
            DataTable dt = QuyDinhDAO.Instance.LaySoHieuXe();
            return int.Parse(dt.Rows[0][0].ToString());
        }
        public int CapNhatSoHieuXe(string GiaTriMoi)
        {
            int gtm = int.Parse(GiaTriMoi);
            return DAO_QuanLy.QuyDinhDAO.Instance.CapNhatSoHieuXe(gtm);
        }
        public int LaySoXeSuaToiDa()
        {
            DataTable dt = QuyDinhDAO.Instance.LaySoXeSuaToiDa();
            return int.Parse(dt.Rows[0][0].ToString());
        }
        public int CapNhatSoXeSuaToiDa(string GiaTriMoi)
        {
            int gtm = int.Parse(GiaTriMoi);
            return DAO_QuanLy.QuyDinhDAO.Instance.CapNhatSoXeSuaToiDa(gtm);
        }
        public int LaySoLoaiVatTu()
        {
            DataTable dt = QuyDinhDAO.Instance.LaySoLoaiVatTu();
            return int.Parse(dt.Rows[0][0].ToString());
        }
        public int CapNhatSoLoaiVatTu(string GiaTriMoi)
        {
            int gtm = int.Parse(GiaTriMoi);
            return DAO_QuanLy.QuyDinhDAO.Instance.CapNhatSoLoaiVatTu(gtm);
        }
        public int LaySoSoLoaiTienCong()
        {
            DataTable dt = QuyDinhDAO.Instance.LaySoLoaiTienCong();
            return int.Parse(dt.Rows[0][0].ToString());
        }
        public int CapNhatSoLoaiTienCong(string GiaTriMoi)
        {
            int gtm = int.Parse(GiaTriMoi);
            return DAO_QuanLy.QuyDinhDAO.Instance.CapNhatSoLoaiTienCong(gtm);
        }
    }
}
