namespace DoAn.NET1
{
    partial class frmGiaoVien
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.sbtnThem = new DevExpress.XtraEditors.SimpleButton();
            this.stbnCapNhap = new DevExpress.XtraEditors.SimpleButton();
            this.sbtnXoa = new DevExpress.XtraEditors.SimpleButton();
            this.stbnThoat = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // gridControl1
            // 
            this.gridControl1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.gridControl1.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridControl1.Location = new System.Drawing.Point(0, 300);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(938, 200);
            this.gridControl1.TabIndex = 0;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            // 
            // sbtnThem
            // 
            this.sbtnThem.Location = new System.Drawing.Point(91, 158);
            this.sbtnThem.Name = "sbtnThem";
            this.sbtnThem.Size = new System.Drawing.Size(112, 34);
            this.sbtnThem.TabIndex = 1;
            this.sbtnThem.Text = "Thêm";
            this.sbtnThem.Click += new System.EventHandler(this.sbtnThem_Click);
            // 
            // stbnCapNhap
            // 
            this.stbnCapNhap.Location = new System.Drawing.Point(296, 158);
            this.stbnCapNhap.Name = "stbnCapNhap";
            this.stbnCapNhap.Size = new System.Drawing.Size(112, 34);
            this.stbnCapNhap.TabIndex = 1;
            this.stbnCapNhap.Text = "Cập Nhập";
            // 
            // sbtnXoa
            // 
            this.sbtnXoa.Location = new System.Drawing.Point(499, 158);
            this.sbtnXoa.Name = "sbtnXoa";
            this.sbtnXoa.Size = new System.Drawing.Size(112, 34);
            this.sbtnXoa.TabIndex = 1;
            this.sbtnXoa.Text = "Xóa ";
            // 
            // stbnThoat
            // 
            this.stbnThoat.Location = new System.Drawing.Point(696, 158);
            this.stbnThoat.Name = "stbnThoat";
            this.stbnThoat.Size = new System.Drawing.Size(112, 34);
            this.stbnThoat.TabIndex = 1;
            this.stbnThoat.Text = "Thoát";
            // 
            // frmGiaoVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(938, 500);
            this.Controls.Add(this.stbnThoat);
            this.Controls.Add(this.sbtnXoa);
            this.Controls.Add(this.stbnCapNhap);
            this.Controls.Add(this.sbtnThem);
            this.Controls.Add(this.gridControl1);
            this.Name = "frmGiaoVien";
            this.Text = "Danh Sách Sinh Viên";
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.SimpleButton sbtnThem;
        private DevExpress.XtraEditors.SimpleButton stbnCapNhap;
        private DevExpress.XtraEditors.SimpleButton sbtnXoa;
        private DevExpress.XtraEditors.SimpleButton stbnThoat;
    }
}