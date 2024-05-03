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
            DevExpress.XtraTab.XtraTabPage xt = new DevExpress.XtraTab.XtraTabPage();
            xt.Controls.Add(frmGiaoVien);
            frmGiaoVien.Show();
            tabHienThi.TabPages.Add(xt);
        }
<<<<<<< HEAD

        private void btnSinhVien_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmSInhVien frmSInhVien = new frmSInhVien();
            frmSInhVien.TopLevel = false;
            frmSInhVien.AutoScroll = true;
            DevExpress.XtraTab.XtraTabPage sv = new DevExpress.XtraTab.XtraTabPage();
            sv.Controls.Add(frmSInhVien);
            frmSInhVien.Show();
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
=======
>>>>>>> origin/branch
    }
}
