using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO_QuanLyGarage
{
    public class KhachHangDTO
    {
        public string sTenKH;
        public string sDienThoai;
        public string sDiaChi;
        public int iTienNo;

        public KhachHangDTO() {}
        public string TenKH
        {
            get { return sTenKH; }
            set { sTenKH = value; }
        }
        public string DienThoai
        {
            get { return sDienThoai; }
            set { sDienThoai = value; }
        }
        public string DiaChi
        {
            get { return sDiaChi; }
            set { sDiaChi = value; }
        }
        public int TienNo
        {
            get { return iTienNo; }
            set { iTienNo = value; }
        }
        public KhachHangDTO(string tenkh, string dienthoai, string diachi, int tienno)
        {
            this.sTenKH = tenkh;
            this.sDienThoai = dienthoai;
            this.sDiaChi = diachi;
            this.iTienNo = tienno;
        }
        
    }
}
