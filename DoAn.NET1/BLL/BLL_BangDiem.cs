using DALL;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class BLL_BangDiem
    {
        public class BLL_Khoa
        {
            private DAL_BangDiem dal_bd = new DAL_BangDiem();
            public IQueryable layDSBangDiem()
            {
                return dal_bd.layDSBangDiem();
            }
            public bool ThemBangDiem(DTO_BangDiem bd)
            {
                return dal_bd.ThemBangDiem(bd);
            }
            public bool XoaBangDiem(string id)
            {
                return dal_bd.XoaBangDiem(id);
            }
            public bool SuaBangDiem(DTO_BangDiem bd)
            {
                return dal_bd.SuaBangDiem(bd);
            }
            public IQueryable TimBangDiem(string name)
            {
                return dal_bd.TimBangDiem(name);
            }
        }
    }
}
