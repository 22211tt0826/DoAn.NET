using BLL;
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
    public partial class frmDiemDanh : DevExpress.XtraEditors.XtraForm
    {
        public frmDiemDanh()
        {
            InitializeComponent();
        }
        BLL_DiemDanh diemDanh;
        public void Load_L()
        {
            diemDanh = new BLL_DiemDanh();
           gridControl1 .DataSource = diemDanh.layDSDiemDanh();
        }
        private void gridControl1_Click(object sender, EventArgs e)
        {
            Load_L();
        }

        private void frmDiemDanh_Load(object sender, EventArgs e)
        {
            Load_L();
        }
    }
}