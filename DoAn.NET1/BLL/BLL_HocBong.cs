using DALL;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class BLL_HocBong
    {
        private DAL_HocBong dal_hb = new DAL_HocBong();
        public IQueryable layDSHocBong()
        {
            return dal_hb.layDSHocBong();
        }
        public bool themHocBong(DTO_HocBong hb)
        {
            return dal_hb.ThemHocBong(hb);
        }
        public bool XoaHocBong(string id)
        {
            return dal_hb.XoaHocBong(id);
        }
        public bool SuaHocBong(DTO_HocBong hb)
        {
            return dal_hb.SuaHocBong(hb);
        }
        public IQueryable TimHocBong(string name)
        {
            return dal_hb.TimHocBong(name);
        }
    }
}
