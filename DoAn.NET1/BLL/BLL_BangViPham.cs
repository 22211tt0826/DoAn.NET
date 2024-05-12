using DALL;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class BLL_BangViPham
    {
        private DAL_BangViPham dal_bvp = new DAL_BangViPham();
        public IQueryable layDSBangViPham()
        {
            return dal_bvp.layDSBangViPham();
        }
        public bool ThemBangViPham(DTO_BangViPham vp)
        {
            return dal_bvp.ThemViPham(vp);
        }
        public bool XoaBangViPham(string id)
        {
            return dal_bvp.XoaViPham(id);
        }
        public bool SuaBangViPham(DTO_BangViPham vp)
        {
            return dal_bvp.SuaViPham(vp);
        }
        public IQueryable TimBangViPham(string name)
        {
            return dal_bvp.TimViPham(name);
        }
    }
}
