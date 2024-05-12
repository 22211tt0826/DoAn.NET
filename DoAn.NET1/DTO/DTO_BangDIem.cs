using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DTO_BangDiem
    {
        private string maHP;
        private string maSV;
        private string tenHK;
        private float diemGK;
        private float diemCK;
        private float diemTB;

        public DTO_BangDiem(string maHP, string maSV, string tenHK, float diemGK, float diemCK, float diemTB)
        {
            this.MaHP = maHP;
            this.MaSV = maSV;
            this.TenHK = tenHK;
            this.DiemGK = diemGK;
            this.DiemCK = diemCK;
            this.DiemTB = diemTB;
        }
        public DTO_BangDiem()
        {
           
        }

        public string MaHP { get => maHP; set => maHP = value; }
        public string MaSV { get => maSV; set => maSV = value; }
        public string TenHK { get => tenHK; set => tenHK = value; }
        public float DiemGK { get => diemGK; set => diemGK = value; }
        public float DiemCK { get => diemCK; set => diemCK = value; }
        public float DiemTB { get => diemTB; set => diemTB = value; }
    }
}
