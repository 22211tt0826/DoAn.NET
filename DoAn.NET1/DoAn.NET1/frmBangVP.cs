using BLL;
using DevExpress.XtraBars.ViewInfo;
using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoAn.NET1
{
    public partial class frmBangVP : DevExpress.XtraEditors.XtraForm
    {
        public frmBangVP()
        {
            InitializeComponent();
        }
        BLL_BangViPham viPham;

        public void Load_BVP()
        {
            viPham=new BLL_BangViPham();
            gridControl1.DataSource = viPham.layDSBangViPham();
        }
        private void gridControl1_Click(object sender, EventArgs e)
        {
            Load_BVP();
        }

        private void frmBangVP_Load(object sender, EventArgs e)
        {
            Load_BVP();
        }
    }
}