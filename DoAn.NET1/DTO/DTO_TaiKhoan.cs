using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DTO_TaiKhoan
    {
        private string _IdDangNhap;
        private string __MatKhau;

        public DTO_TaiKhoan(string idDangNhap, string matKhau)
        {
            _IdDangNhap = idDangNhap;
            __MatKhau = matKhau;
        }
        public DTO_TaiKhoan()
        {

        }
        public string IdDangNhap { get => _IdDangNhap; set => _IdDangNhap = value; }
        public string MatKhau { get => __MatKhau; set => __MatKhau = value; }
    }
}
