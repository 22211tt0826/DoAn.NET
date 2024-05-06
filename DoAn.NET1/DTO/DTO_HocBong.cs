using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DTO_HocBong
    {
        private string maHB;
        private string loaiHB;
        private string tenHK;
        private string maSV;

        public DTO_HocBong(string maHB, string loaiHB, string tenHK, string maSV)
        {
            this.maHB = maHB;
            this.loaiHB = loaiHB;
            this.tenHK = tenHK;
            this.maSV = maSV;
        }
        public DTO_HocBong()
        {
          
        }

        public string MaHB { get => maHB; set => maHB = value; }
        public string LoaiHB { get => loaiHB; set => loaiHB = value; }
        public string TenHK { get => tenHK; set => tenHK = value; }
        public string MaSV { get => maSV; set => maSV = value; }
    }
}
