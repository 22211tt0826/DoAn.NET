using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DTO_Lop
    {
        private string tenLop;
        private string maKhoa;
        private string maSV;
        private string maGV;

        public DTO_Lop(string tenLop, string maKhoa, string maSV, string maGV)
        {
            this.TenLop = tenLop;
            this.MaKhoa = maKhoa;
            this.MaSV = maSV;
            this.MaGV = maGV;
        }
        public DTO_Lop()
        {
           
        }

        public string TenLop { get => tenLop; set => tenLop = value; }
        public string MaKhoa { get => maKhoa; set => maKhoa = value; }
        public string MaSV { get => maSV; set => maSV = value; }
        public string MaGV { get => maGV; set => maGV = value; }
    }
}
