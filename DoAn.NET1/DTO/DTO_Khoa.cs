﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DTO_Khoa
    {
        private string maKhoa;
        private string tenKhoa;
        private string maSV;
        private string maGV;

        public DTO_Khoa(string maKhoa, string tenKhoa, string maSV, string maGV)
        {
            this.MaKhoa = maKhoa;
            this.TenKhoa = tenKhoa;
            this.MaSV = maSV;
            this.MaGV = maGV;
        }
        public DTO_Khoa(){

            }
        public string MaKhoa { get => maKhoa; set => maKhoa = value; }
        public string TenKhoa { get => tenKhoa; set => tenKhoa = value; }
        public string MaSV { get => maSV; set => maSV = value; }
        public string MaGV { get => maGV; set => maGV = value; }
    }
}
