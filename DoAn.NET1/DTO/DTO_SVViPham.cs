using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DTO_SVViPham
    {
        private string noiDungVP;
        private string thoiGianSV;
        private string maSV;
        private string maHP;

        public DTO_SVViPham(string noiDungVP, string thoiGianSV, string maSV, string maHP)
        {
            this.noiDungVP = noiDungVP;
            this.thoiGianSV = thoiGianSV;
            this.maSV = maSV;
            this.maHP = maHP;
        }
        public DTO_SVViPham()
        {

        }
        public string NoiDungVP { get => noiDungVP; set => noiDungVP = value; }
        public string ThoiGianSV { get => thoiGianSV; set => thoiGianSV = value; }
        public string MaSV { get => maSV; set => maSV = value; }
        public string MaHP { get => maHP; set => maHP = value; }
    }
}
