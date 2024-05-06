using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DTO_DiemDanh
    {
        private string maSV;
        private string hoTenSV;
        private string tenLop;

        
        public DTO_DiemDanh()
        {
            
        }

        public DTO_DiemDanh(string maSV, string hoTenSV, string tenLop)
        {
            this.MaSV = maSV;
            this.HoTenSV = hoTenSV;
            this.TenLop = tenLop;
        }

        public string MaSV { get => maSV; set => maSV = value; }
        public string HoTenSV { get => hoTenSV; set => hoTenSV = value; }
        public string TenLop { get => tenLop; set => tenLop = value; }
    }
}
