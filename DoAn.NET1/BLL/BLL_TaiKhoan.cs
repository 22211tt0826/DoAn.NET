using DALL;
using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class BLL_TaiKhoan
    {
        
        private  DAL_TaiKhoan dAL_TaiKhoan=new DAL_TaiKhoan();
            public IQueryable layDSTK()
            {
                return dAL_TaiKhoan.layDSTK();
            }
        public DAL_TaiKhoan Login(string tenTK, string passTK)
        {
             dAL_TaiKhoan.GetUserByUsernameAndPassword(tenTK, passTK);
        }

    }
    }

