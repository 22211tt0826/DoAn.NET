using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DTO_GiaoVien
    {
        private string maGV;
        private string hoTenGV;
        private string gioitinh;
        private DateTime  ngaySinh;
        private string noiSinh;
         private int sDT;
        private string eMail;
        private string maCV;
        private string maSV;
        private string maLop;

        public DTO_GiaoVien(string maGV, string hoTenGV, string gioitinh, DateTime ngaySinh, string noiSinh, int sDT, string eMail, string maCV, string maSV, string maLop)
        {
            this.maGV = maGV;
            this.hoTenGV = hoTenGV;
            this.gioitinh = gioitinh;
            this.ngaySinh = ngaySinh;
            this.noiSinh = noiSinh;
            this.sDT = sDT;
            this.eMail = eMail;
            this.maCV = maCV;
            this.maSV = maSV;
            this.maLop = maLop;
        }
        public DTO_GiaoVien()
        {
           
        }

        public string MaGV { get => maGV; set => maGV = value; }
        public string HoTenGV { get => hoTenGV; set => hoTenGV = value; }
        public string Gioitinh { get => gioitinh; set => gioitinh = value; }
        public DateTime NgaySinh { get => ngaySinh; set => ngaySinh = value; }
        public string NoiSinh { get => noiSinh; set => noiSinh = value; }
        public int SDT { get => sDT; set => sDT = value; }
        public string EMail { get => eMail; set => eMail = value; }
        public string MaCV { get => maCV; set => maCV = value; }
        public string MaSV { get => maSV; set => maSV = value; }
        public string MaLop { get => maLop; set => maLop = value; }
    }
}
