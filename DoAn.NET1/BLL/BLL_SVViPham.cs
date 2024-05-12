using DALL;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class BLL_SVViPham
    {
        private DAL_SVViPham dal_svVP = new DAL_SVViPham();
        public IQueryable layDSSVViPham()
        {
            return dal_svVP.layDSSVViPham();
        }
        public bool ThemSVViPham(DTO_SVViPham svVP)
        {
            return dal_svVP.ThemSVViPham(svVP);
        }
        public bool XoaSVViPham(string id)
        {
            return dal_svVP.XoaSVViPham(id);
        }
        public bool SuaSVViPham(DTO_SVViPham sVViPham)
        {
            return dal_svVP.SuaSVViPham(sVViPham);
        }
        public IQueryable TimSVViPham(string name)
        {
            return dal_svVP.TimSVViPham(name);
        }
    }
}
