using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DTO_SinhVien
    {
        private string maSV;
        private string hoTenSV;
        private string gioitinh;
        private DateTime ngaySinh;
        private string noiSinh;
        private int sDT;
        private string eMail;
        private string maCV;
    private string maLop;
        public DTO_SinhVien()
        {

        }
        public string MaSV { get => maSV; set => maSV = value; }
        public string HoTenSV { get => hoTenSV; set => hoTenSV = value; }
        public string Gioitinh { get => gioitinh; set => gioitinh = value; }
        public DateTime NgaySinh { get => ngaySinh; set => ngaySinh = value; }
        public string NoiSinh { get => noiSinh; set => noiSinh = value; }
        public int SDT { get => sDT; set => sDT = value; }
        public string EMail { get => eMail; set => eMail = value; }
        public string MaCV { get => maCV; set => maCV = value; }
        public string MaLop { get => maLop; set => maLop = value; }
        public DTO_SinhVien(string maSV, string hoTenSV, string gioitinh, DateTime ngaySinh, string noiSinh, int sDT, string eMail, string maCV, string maLop)
        {
            this.maSV = maSV;
            this.hoTenSV = hoTenSV;
            this.gioitinh = gioitinh;
            this.ngaySinh = ngaySinh;
            this.noiSinh = noiSinh;
            this.sDT = sDT;
            this.eMail = eMail;
            this.maCV = maCV;
            this.maLop = maLop;
        }

    }
}
