using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DevExpress.Utils.Extensions;
using DevExpress.Utils.Filtering;
using DevExpress.XtraEditors;

namespace DoAn.NET1
{
    public partial class frmMain : DevExpress.XtraBars.Ribbon.RibbonForm
    {
          private  SqlConnection conn { get; set; }
        public frmMain(SqlConnection conn)
        {
            InitializeComponent();
            //this.conn = conn;
        }
        public void skins()
        {
            DevExpress.LookAndFeel.DefaultLookAndFeel thems = new DevExpress.LookAndFeel.DefaultLookAndFeel();
            thems.LookAndFeel.SkinName = "Valentine"; /*ten giao dien muon load len*/
          
        }
        private void ribbonControl2_Click(object sender, EventArgs e)
        {
            
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            skins();
        }

        private void frmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult dr;
            dr = XtraMessageBox.Show("Bạn có muốn thoát ?", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.No)
            {
                e.Cancel = true;
            }
        }

        private void btnLogin_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmLogin frmLogin = new frmLogin();
            frmLogin.Dock = DockStyle.Fill;
            frmLogin.ShowDialog();
        }

        private void btnChagePass_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmChangePass frmChangePass = new frmChangePass();
            frmChangePass.TopLevel = false;
            frmChangePass.AutoScroll = true;
            frmChangePass.Dock = DockStyle.Top;
            DevExpress.XtraTab.XtraTabPage xt = new DevExpress.XtraTab.XtraTabPage();
            xt.Controls.Add(frmChangePass);
            frmChangePass.Show();
            tabHienThi.TabPages.Add(xt);
            
        }

        private void btnLoginOut_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (XtraMessageBox.Show("Bạn có muốn đăng xuất không  ?", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)== DialogResult.Yes)
            {
                this.Close();
            }
        }


        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmGiaoVien frmGiaoVien = new frmGiaoVien();
            frmGiaoVien.TopLevel = false;
            frmGiaoVien.AutoScroll = true;
            frmGiaoVien.Dock = DockStyle.Left;
            frmGiaoVien.Show();
            frmChuacNangGV frmChuacNang = new frmChuacNangGV();
            frmChuacNang.TopLevel = false;
            frmChuacNang.AutoScroll = true;
            frmChuacNang.Dock = DockStyle.Fill;
            frmChuacNang.Show();
            DevExpress.XtraTab.XtraTabPage cn = new DevExpress.XtraTab.XtraTabPage();
            Panel p = new Panel();
            p.Dock = DockStyle.Fill;
            p.Controls.Add(frmChuacNang);
            p.Controls.Add(frmGiaoVien);
            cn.Controls.Add(p);
            tabHienThi.TabPages.Add(cn);
        }

        private void btnSinhVien_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmThongTinSV frmThongTinSV = new frmThongTinSV();
            frmThongTinSV.TopLevel = false;
            frmThongTinSV.AutoScroll = true;
            frmThongTinSV.Dock = DockStyle.Fill;
            frmThongTinSV.Show();
            frmSinhVien frmSInhVien = new frmSinhVien();
            frmSInhVien.TopLevel = false;
            frmSInhVien.AutoScroll = true;
            frmSInhVien.Dock = DockStyle.Top;
            frmSInhVien.Show();
            DevExpress.XtraTab.XtraTabPage sv = new DevExpress.XtraTab.XtraTabPage();
            Panel panel = new Panel();
            panel.Dock = DockStyle.Fill;
            panel.Controls.Add(frmThongTinSV);
            panel.Controls.Add(frmSInhVien);
            sv.Controls.Add(panel);
            tabHienThi.TabPages.Add(sv);
        }

        private void btnDangKiHP_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmDangKiHocPhan frmDangKiHocPhan = new frmDangKiHocPhan();
            frmDangKiHocPhan.TopLevel = false;
            frmDangKiHocPhan.AutoScroll = true;
            frmDangKiHocPhan.Dock = DockStyle.Left;
            frmDangKiHocPhan.Show();
            frmChucNangDKHP frmChucNangDKHP = new frmChucNangDKHP();
            frmChucNangDKHP.TopLevel = false;
            frmChucNangDKHP.AutoScroll = true;
            frmChucNangDKHP.Dock = DockStyle.Fill;
            frmChucNangDKHP.Show();
            DevExpress.XtraTab.XtraTabPage cn = new DevExpress.XtraTab.XtraTabPage();
            Panel p = new Panel();
            p.Dock = DockStyle.Fill;
            p.Controls.Add(frmChucNangDKHP);
            p.Controls.Add(frmDangKiHocPhan);
            cn.Controls.Add(p);
            tabHienThi.TabPages.Add(cn);
        }

        private void btnBangDiem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmBangDiem frmBangDiem= new frmBangDiem();
            frmBangDiem.TopLevel = false;
            frmBangDiem.AutoScroll = true;
            frmBangDiem.Dock = DockStyle.Left;
            frmBangDiem.Show();
            frmChucNangBangDiem frmChucNangBangDiem = new frmChucNangBangDiem();
            frmChucNangBangDiem.TopLevel = false;
            frmChucNangBangDiem.AutoScroll = true;
            frmChucNangBangDiem.Dock = DockStyle.Fill;
            frmChucNangBangDiem.Show();
            DevExpress.XtraTab.XtraTabPage cn = new DevExpress.XtraTab.XtraTabPage();
            Panel p = new Panel();
            p.Dock = DockStyle.Fill;
            p.Controls.Add(frmChucNangBangDiem);
            p.Controls.Add(frmBangDiem);
            cn.Controls.Add(p);
            tabHienThi.TabPages.Add(cn);
        }

        private void btnKhoa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmKhoa frmKhoa = new frmKhoa();
            frmKhoa.TopLevel = false;
            frmKhoa.AutoScroll = true;
            frmKhoa.Dock = DockStyle.Left;
            frmKhoa.Show();
            frmChucNangKhoa frmChucNangKhoa = new frmChucNangKhoa();
            frmChucNangKhoa.TopLevel = false;
            frmChucNangKhoa.AutoScroll = true;
            frmChucNangKhoa.Dock = DockStyle.Fill;
            frmChucNangKhoa.Show();
            DevExpress.XtraTab.XtraTabPage cn = new DevExpress.XtraTab.XtraTabPage();
            Panel p = new Panel();
            p.Dock = DockStyle.Fill;
            p.Controls.Add(frmChucNangKhoa);
            p.Controls.Add(frmKhoa);
            cn.Controls.Add(p);
            tabHienThi.TabPages.Add(cn);
        }

        private void btnLop_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmLop frmLop = new frmLop();
            frmLop.TopLevel = false;
            frmLop.AutoScroll = true;
            frmLop.Dock = DockStyle.Top;
            DevExpress.XtraTab.XtraTabPage xt = new DevExpress.XtraTab.XtraTabPage();
            xt.Controls.Add(frmLop);
            frmLop.Show();
            tabHienThi.TabPages.Add(xt);
        }

        private void btnSVViPham_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmSInhVienViPham frmSInhVienViPham = new frmSInhVienViPham();
            frmSInhVienViPham.TopLevel = false;
            frmSInhVienViPham.AutoScroll = true;
            frmSInhVienViPham.Dock = DockStyle.Top;
            DevExpress.XtraTab.XtraTabPage xt = new DevExpress.XtraTab.XtraTabPage();
            xt.Controls.Add(frmSInhVienViPham);
            frmSInhVienViPham.Show();
            tabHienThi.TabPages.Add(xt);
        }

        private void btnDiemDanh_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmDiemDanh frmDiemDanh = new frmDiemDanh();
            frmDiemDanh.TopLevel = false;
            frmDiemDanh.AutoScroll = true;
            
            DevExpress.XtraTab.XtraTabPage xt = new DevExpress.XtraTab.XtraTabPage();
            xt.Controls.Add(frmDiemDanh);
            frmDiemDanh.Show();
            tabHienThi.TabPages.Add(xt);
        }
    }
}
