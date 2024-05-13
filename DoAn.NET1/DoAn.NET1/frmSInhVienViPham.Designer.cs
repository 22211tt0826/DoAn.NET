namespace DoAn.NET1
{
    partial class frmSInhVienViPham
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
            this.dgvSVViPham = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSVViPham)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvSVViPham
            // 
            this.dgvSVViPham.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvSVViPham.Location = new System.Drawing.Point(0, 0);
            this.dgvSVViPham.MainView = this.gridView1;
            this.dgvSVViPham.Name = "dgvSVViPham";
            this.dgvSVViPham.Size = new System.Drawing.Size(1621, 812);
            this.dgvSVViPham.TabIndex = 0;
            this.dgvSVViPham.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            this.dgvSVViPham.Click += new System.EventHandler(this.dgvSVViPham_Click);
            // 
            // gridView1
            // 
            this.gridView1.GridControl = this.dgvSVViPham;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsFind.AlwaysVisible = true;
            this.gridView1.OptionsFind.Behavior = DevExpress.XtraEditors.FindPanelBehavior.Search;
            this.gridView1.OptionsFind.Condition = DevExpress.Data.Filtering.FilterCondition.Contains;
            this.gridView1.OptionsFind.FindDelay = 500;
            this.gridView1.OptionsFind.FindMode = DevExpress.XtraEditors.FindMode.Always;
            this.gridView1.OptionsFind.FindNullPrompt = "Nội Dung TÌm Kiếm";
            this.gridView1.OptionsFind.ShowClearButton = false;
            // 
            // frmSInhVienViPham
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1621, 812);
            this.Controls.Add(this.dgvSVViPham);
            this.Name = "frmSInhVienViPham";
            this.Text = "SInhVienViPham";
            this.Load += new System.EventHandler(this.frmSInhVienViPham_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSVViPham)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl dgvSVViPham;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
    }
}