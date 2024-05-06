using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    internal class DTO_ChucVu
    {
        private string maCV;
        private string tenCV;

        public DTO_ChucVu(string maCV, string tenCV)
        {
            this.MaCV = maCV;
            this.TenCV = tenCV;
        }
        public DTO_ChucVu()
        {
           
        }

        public string MaCV { get => maCV; set => maCV = value; }
        public string TenCV { get => tenCV; set => tenCV = value; }
    }
}
