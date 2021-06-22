using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAO_QuanLy;
using System.Data;

namespace BUS_QuanLy
{
    public class KhachHangBUS
    {
        private static KhachHangBUS instance;
        public static KhachHangBUS Instance
        {
            get
            {
                if (instance == null)
                    instance = new KhachHangBUS();
                return instance;
            }
            private set
            {
                instance = value;
            }
        }

        private KhachHangBUS() { }

        public int ThemKhachHang(string ten, string sdt, string diachi)
        {
            return KhachHangDAO.Instance.ThemKhachHang(ten, sdt, diachi);
        }
        public int LayMaKH(string ten, string sdt)
        {
            DataTable dt = KhachHangDAO.Instance.LayMaKH(ten, sdt);
            return int.Parse(dt.Rows[0][0].ToString());
        }
    }
}
