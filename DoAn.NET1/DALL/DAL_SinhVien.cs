using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Threading.Tasks;
using DTO;
using System.Windows.Forms;


namespace DALL
{
    public  class DAL_SinhVien
    {
        private QLSVDataContext db = new QLSVDataContext();
        public IQueryable laydssv()
        {
            IQueryable sv = from s in db.SinhViens
                            select new 
                            {
                                s.maSV,
                                s.hoTenSV,
                                s.gioitinh,
                                s.ngaySinh.Value,
                                s.noiSinh,
                                s.sDT,
                                s.eMail,
                                s.maGV,
                                s.tenCV,
                                s.tenLop
                            };
            
            return sv;
        }
        public bool themSV(DTO_SinhVien sv)
        {
            try
            {
                SinhVien them = new SinhVien();
                {
                     them.maSV=sv.MaSV;
                     them.hoTenSV=sv.HoTenSV;
                     them.gioitinh=sv.Gioitinh;
                     them.ngaySinh=sv.NgaySinh;
                     them.noiSinh=sv.NoiSinh;
                     them.sDT=sv.SDT;
                     them.eMail=sv.EMail;
                     them.maGV=sv.MaGV;
                    them.tenCV = sv.TenCV;
                     them.tenLop=sv.TenLop;
                };
                if (them.maSV != string.Empty )
                {
                    db.SinhViens.InsertOnSubmit(them);
                    db.SubmitChanges();
                    MessageBox.Show("Thêm Thành Công!", "Thông Báo!",
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
        public bool XoaSV(string id)
        {
            try
            {
                if (id != string.Empty)
                {
                    var xoa = from s in db.SinhViens
                              where s.maSV == id
                              select s;

                    foreach (var item in xoa)
                    {
                        db.SinhViens.DeleteOnSubmit(item);
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
        public bool SuaSV(DTO_SinhVien sv)
        {
            try
            {
                SinhVien sua = db.SinhViens.Single(d => d.maSV == sv.MaSV);

                if (sua.maSV != string.Empty)
                {
                    sua.hoTenSV = sv.HoTenSV;
                    sua.gioitinh = sv.Gioitinh;
                    sua.ngaySinh = sv.NgaySinh;
                    sua.noiSinh = sv.NoiSinh;
                    sua.sDT = sv.SDT;
                    sua.eMail = sv.EMail;
                    sua.maGV = sv.MaGV;
                    sua.tenCV=sv.TenCV;
                    sua.tenLop = sv.TenLop;

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
        public IQueryable TimMSSV(string name)
        {
            IQueryable temp = from s in db.SinhViens
                              where s.maSV == name
                              select new
                              {
                                  s.maSV,
                                  s.hoTenSV,
                                  s.gioitinh,
                                  s.ngaySinh.Value,
                                  s.noiSinh,
                                  s.sDT,
                                  s.eMail,
                                  s.maGV,
                                  s.tenCV,
                                  s.tenLop
                              };
            return temp;
        }
    }
}
