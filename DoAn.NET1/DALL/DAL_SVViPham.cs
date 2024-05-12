using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DALL
{
    public class DAL_SVViPham
    {
        private QLSVDataContext db = new QLSVDataContext();
        public IQueryable layDSSVViPham()
        {
            IQueryable svVP = from s in db.sinhVienVPs
                              select new
                              {
                                  s.maVP,
                                  s.thoiGian,
                                  s.maSV
                              };
            return svVP;
        }
        public bool ThemSVViPham(DTO_SVViPham svVP)
        {
            try
            {
                sinhVienVP them = new sinhVienVP();
                {
                    them.maVP = svVP.MaVP;
                    them.thoiGian = svVP.ThoiGian;
                    them.maSV = svVP.MaSV;
                };
                if (them.maVP != string.Empty)
                {
                    db.sinhVienVPs.InsertOnSubmit(them);
                    db.SubmitChanges();
                    MessageBox.Show("Thêm thành công!", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return true;
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
            return false;
        }
        public bool SuaSVViPham(DTO_SVViPham svVP)
        {
            try
            {
                sinhVienVP sua = db.sinhVienVPs.Single(d => d.maVP == svVP.MaVP);
                if (sua.maVP != string.Empty)
                {
                    sua.maVP = svVP.MaVP;
                    sua.thoiGian = svVP.ThoiGian;
                    sua.maSV = svVP.MaSV;

                    db.SubmitChanges();
                    MessageBox.Show("Sửa Thành Công!", "Thông Báo!",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information);
                    return true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return false;
        }
        public bool XoaSVViPham(string id)
        {
            try
            {
                if (id != string.Empty)
                {
                    var xoa = from s in db.sinhVienVPs
                              where s.maVP == id
                              select s;
                    foreach (var item in xoa)
                    {
                        db.sinhVienVPs.DeleteOnSubmit(item);
                        db.SubmitChanges();
                    }
                    MessageBox.Show("Xóa Thành Công!", "Thông Báo!",
                                        MessageBoxButtons.OK,
                                        MessageBoxIcon.Information);
                    return true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
            return false;
        }
        public IQueryable TimSVViPham(string name)
        {
            IQueryable temp = from s in db.sinhVienVPs
                              where s.maVP == name
                              select new
                              {
                                  s.maVP,
                                  s.thoiGian,
                                  s.maSV
                              };
            return temp;
        }
    }
}
