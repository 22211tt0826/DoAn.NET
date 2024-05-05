using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DevExpress.Utils.Extensions;
using DevExpress.XtraEditors;

namespace DoAn.NET1
{
    public partial class frmMain : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public frmMain()
        {
            InitializeComponent();
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
            frmLogin.ShowDialog();
        }

        private void btnChagePass_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmChangePass frmChangePass = new frmChangePass();
            frmChangePass.TopLevel = false;
            frmChangePass.AutoScroll = true;
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

        private void tabHienThi_Click(object sender, EventArgs e)
        {

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
            frmThongTinSV.Dock = DockStyle.Top;
            frmThongTinSV.Show();
            frmSInhVien frmSInhVien = new frmSInhVien();
            frmSInhVien.TopLevel = false;
            frmSInhVien.AutoScroll = true;
            frmSInhVien.Dock = DockStyle.Bottom;
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
            frmDangKiHocPhan frmDangKiHP = new frmDangKiHocPhan();
            frmDangKiHP.TopLevel = false;
            frmDangKiHP.AutoScroll = true;
            DevExpress.XtraTab.XtraTabPage hp = new DevExpress.XtraTab.XtraTabPage();
            hp.Controls.Add(frmDangKiHP);
            frmDangKiHP.Show();
            tabHienThi.TabPages.Add(hp);
        }

        private void btnBangDiem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmBangDiem frmBangDiem= new frmBangDiem();
            frmBangDiem.TopLevel = false;
            frmBangDiem.AutoScroll = true;
            DevExpress.XtraTab.XtraTabPage bd = new DevExpress.XtraTab.XtraTabPage();
            bd.Controls.Add(frmBangDiem);
            frmBangDiem.Show();
            tabHienThi.TabPages.Add(bd);
        }

    }
}
