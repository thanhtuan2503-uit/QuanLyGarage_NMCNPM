using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO_QuanLyGarage
{
    public class XeDTO
    {
        public int iMaKH;
        public string sBienSo;
        public string sHieuXe;
        public DateTime dtNgaySuaChua;
        public XeDTO() { }
        
        public int MaKH
        {
            get { return iMaKH; }
            set { iMaKH = value; }
        }

        public string BienSo
        {
            get { return sBienSo; }
            set { sBienSo = value; }
        }

        public string HieuXe
        {
            get { return sHieuXe; }
            set { sHieuXe = value; }
        }

        public DateTime NgaySuaChua
        {
            get { return dtNgaySuaChua; }
            set { dtNgaySuaChua = value; }
        }

        public XeDTO(int makh, string bienso, string hieuxe, DateTime ngaysuachua)
        {
            this.iMaKH = makh;
            this.sBienSo = bienso;
            this.sHieuXe = hieuxe;
            this.dtNgaySuaChua = ngaysuachua;
        }
        
    }
}
