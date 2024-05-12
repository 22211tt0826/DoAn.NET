 using DALL;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class BLL_GiaoVien
    {
        private DAL_GiaoVien dal_sv = new DAL_GiaoVien();

        //Methods
        //LayDSSV
        public IQueryable LayGV()
        {
            return dal_sv.laydsgv();
        }

        //ThemSV
        public bool ThemGV(DTO_GiaoVien sv)
        {
            return dal_sv.themGV(sv);
        }

        //XoaSV
        public bool XoaGV(string id)
        {
            return dal_sv.XoaGV(id);
        }

        //SuaSV
        public bool SuaGV(DTO_GiaoVien sv)
        {
            return dal_sv.SuaGV(sv);
        }

        //TimMSSV
        public IQueryable TimGV(string name)
        {
            return dal_sv.TimGV(name);
        }
    }
}
