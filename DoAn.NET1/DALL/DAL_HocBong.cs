using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DALL
{
    public class DAL_HocBong
    {
        private QLSVDataContext db = new QLSVDataContext();
        public IQueryable layDSHocBong()
        {
            IQueryable hocBong = from s in db.hocBongs
                                 select new
                                 {
                                     s.maHB,
                                     s.loaiHB,
                                     s.tenHK,
                                     s.maSV
                                 };
            return hocBong;
        }
        public bool ThemHocBong(DTO_HocBong hb)
        {
            try
            {
                hocBong them = new hocBong();
                {
                    them.maHB = hb.MaHB;
                    them.loaiHB = hb.LoaiHB;
                    them.tenHK = hb.TenHK;
                    them.maSV = hb.MaSV;
                };
                if(them.maHB != string.Empty)
                {
                    db.hocBongs.InsertOnSubmit(them);
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
        public bool SuaHocBong(DTO_HocBong hb)
        {
            try
            {
                hocBong sua = db.hocBongs.Single(d => d.maHB == hb.MaHB);
                if(sua.maHB != string.Empty)
                {
                    sua.maHB = hb.MaHB; 
                    sua.loaiHB = hb.LoaiHB;
                    sua.tenHK = hb.TenHK;
                    sua.maSV = hb.MaSV;

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
        public bool XoaHocBong(string id)
        {
            try
            {
                if(id != string.Empty)
                {
                    var xoa = from s in db.hocBongs
                              where s.maHB == id
                              select s;
                    foreach (var item in xoa)
                    {
                        db.hocBongs.DeleteOnSubmit(item);
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
        public IQueryable TimHocBong(string name)
        {
            IQueryable temp = from s in db.hocBongs
                              where s.maHB == name
                              select new
                              {
                                  s.maHB,
                                  s.loaiHB,
                                  s.tenHK,
                                  s.maSV
                              };
            return temp;
        }
    }
}
