using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DALL
{
    public class DAL_BangViPham
    {
        private QLSVDataContext db = new QLSVDataContext();
        public IQueryable layDSBangViPham()
        {
            IQueryable bangViPham = from s in db.BangViPhams
                              select new
                              {
                                  s.maVP,
                                  s.noidungVP,
                                  s.maSV,
                                  s.maHP
                              };
            return bangViPham;
        }
        public bool ThemViPham(DTO_BangViPham vp)
        {
            try
            {
                BangViPham them = new BangViPham();
                {
                    them.maVP = vp.MaVP;
                    them.noidungVP = vp.NoidungVP;
                    them.maSV = vp.MaSV;
                    them.maHP = vp.MaHP;
                };
                if (them.maVP != string.Empty)
                {
                    db.BangViPhams.InsertOnSubmit(them);
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
        public bool SuaViPham(DTO_BangViPham vp)
        {
            try
            {
                BangViPham sua = db.BangViPhams.Single(d => d.maVP == vp.MaVP);
                if (sua.maVP != string.Empty)
                {
                    sua.maVP = vp.MaVP;
                    sua.noidungVP = vp.NoidungVP;
                    sua.maSV = vp.MaSV;
                    sua.maHP = vp.MaHP;

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
        public bool XoaViPham(string id)
        {
            try
            {
                if (id != string.Empty)
                {
                    var xoa = from s in db.BangViPhams
                              where s.maVP == id
                              select s;
                    foreach (var item in xoa)
                    {
                        db.BangViPhams.DeleteOnSubmit(item);
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
        public IQueryable TimViPham(string name)
        {
            IQueryable temp = from s in db.BangViPhams
                              where s.maVP == name
                              select new
                              {
                                  s.maVP,
                                  s.noidungVP,
                                  s.maSV,
                                  s.maHP
                              };
            return temp;
        }
    }
}
