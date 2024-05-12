using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DTO_SVViPham
    {
        private string maVP;
        private DateTime thoiGian;
        private string maSV;

     
        public DTO_SVViPham()
        {

        }

        public DTO_SVViPham(string maVP, DateTime thoiGian, string maSV)
        {
            this.maVP = maVP;
            this.thoiGian = thoiGian;
            this.maSV = maSV;
        }

        public string MaVP { get => maVP; set => maVP = value; }
        public DateTime ThoiGian { get => thoiGian; set => thoiGian = value; }
        public string MaSV { get => maSV; set => maSV = value; }
    }
}
