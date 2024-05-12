﻿using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DALL;

namespace BLL
{
    public class BLL_SinhVien
    {
        //Properties
        private DAL_SinhVien dal_sv = new DALL.DAL_SinhVien();

        //Methods
        //LayDSSV
        public IQueryable LayDSSV()
        {
            return dal_sv.laydssv();
        }

        //ThemSV
        public bool ThemSV(DTO_SinhVien sv)
        {
            return dal_sv.themSV(sv);
        }

        //XoaSV
        public bool XoaSV(string id)
        {
            return dal_sv.XoaSV(id);
        }

        //SuaSV
        public bool SuaSV(DTO_SinhVien sv)
        {
            return dal_sv.SuaSV(sv);
        }

        //TimMSSV
        public IQueryable TimMSSV(string name)
        {
            return dal_sv.TimMSSV(name);
        }
    }
}