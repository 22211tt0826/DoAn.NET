using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DALL
{
    public class DAL_BangDiem
    {
        private QLSVDataContext db = new QLSVDataContext();
        public IQueryable layDSBangDiem()
        {
            IQueryable bangDiem = from s in db.bangDiems
                              select new
                              {
                                  s.maHP,
                                  s.maSV,
                                  s.tenHK,
                                  s.diemGK,
                                  s.diemCK,
                                  s.diemTB
                              };
            return bangDiem;
        }
        public bool ThemBangDiem(DTO_BangDiem bd)
        {
            try
            {
                bangDiem them = new bangDiem();
                {
                    them.maHP = bd.MaHP;
                    them.maSV = bd.MaSV;
                    them.tenHK = bd.TenHK;
                    them.diemGK = bd.DiemGK;
                    them.diemCK = bd.DiemCK;
                    them.diemTB = bd.DiemTB;
                };
                if (them.maSV != string.Empty)
                {
                    db.bangDiems.InsertOnSubmit(them);
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
        public bool SuaBangDiem(DTO_BangDiem bd)
        {
            try
            {
                bangDiem sua = db.bangDiems.Single(d => d.maSV == bd.MaSV);
                if (sua.maSV != string.Empty)
                {
                    sua.maHP = bd.MaHP;
                    sua.maSV = bd.MaSV;
                    sua.tenHK = bd.TenHK;
                    sua.diemGK = bd.DiemGK;
                    sua.diemCK = bd.DiemCK;
                    sua.diemTB = bd.DiemTB;

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
        public bool XoaBangDiem(string id)
        {
            try
            {
                if (id != string.Empty)
                {
                    var xoa = from s in db.bangDiems
                              where s.maSV == id
                              select s;
                    foreach (var item in xoa)
                    {
                        db.bangDiems.DeleteOnSubmit(item);
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
        public IQueryable TimBangDiem(string name)
        {
            IQueryable temp = from s in db.bangDiems
                              where s.maSV == name
                              select new
                              {
                                  s.maHP,
                                  s.maSV,
                                  s.tenHK,
                                  s.diemGK,
                                  s.diemCK,
                                  s.diemTB
                              };
            return temp;
        }
    }
}
