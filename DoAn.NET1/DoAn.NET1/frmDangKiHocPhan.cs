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
    public partial class frmDangKiHocPhan : DevExpress.XtraEditors.XtraForm
    {
        BLL_DKHP hp;
        public void Load_HP()
        {
            hp = new BLL_DKHP();
            gridControl1.DataSource = hp.layDSHocPhan();
        }
        public frmDangKiHocPhan()
        {
            InitializeComponent();
        }

        private void gridControl1_Click(object sender, EventArgs e)
        {

        }

        private void frmDangKiHocPhan_Load(object sender, EventArgs e)
        {
            Load_HP();
        }
    }
}