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
    public partial class frmThongTinSV : DevExpress.XtraEditors.XtraForm
    {
        public frmThongTinSV()
        {
            InitializeComponent();
        }

        private void frmThongTinSV_Load(object sender, EventArgs e)
        {
            this.Size = new System.Drawing.Size(770,343);
        }

        private void gridControl1_Click(object sender, EventArgs e)
        {

        }
    }
}