namespace TH2
{
    partial class Form5
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblDSLop = new System.Windows.Forms.Label();
            this.lblDSSV = new System.Windows.Forms.Label();
            this.lsbDSLop = new System.Windows.Forms.ListBox();
            this.lsvSinhVien = new System.Windows.Forms.ListView();
            this.colMaSV = new System.Windows.Forms.ColumnHeader();
            this.colTenSV = new System.Windows.Forms.ColumnHeader();
            this.colGioiTinh = new System.Windows.Forms.ColumnHeader();
            this.colQueQuan = new System.Windows.Forms.ColumnHeader();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.lblTitle.Location = new System.Drawing.Point(190, 10);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(180, 30);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Áp dụng";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblDSLop
            // 
            this.lblDSLop.AutoSize = true;
            this.lblDSLop.Location = new System.Drawing.Point(30, 60);
            this.lblDSLop.Name = "lblDSLop";
            this.lblDSLop.Size = new System.Drawing.Size(78, 15);
            this.lblDSLop.TabIndex = 1;
            this.lblDSLop.Text = "Danh sách lớp:";
            // 
            // lblDSSV
            // 
            this.lblDSSV.AutoSize = true;
            this.lblDSSV.Location = new System.Drawing.Point(240, 60);
            this.lblDSSV.Name = "lblDSSV";
            this.lblDSSV.Size = new System.Drawing.Size(99, 15);
            this.lblDSSV.TabIndex = 2;
            this.lblDSSV.Text = "Danh sách sinh viên:";
            // 
            // lsbDSLop
            // 
            this.lsbDSLop.FormattingEnabled = true;
            this.lsbDSLop.ItemHeight = 15;
            this.lsbDSLop.Location = new System.Drawing.Point(30, 80);
            this.lsbDSLop.Name = "lsbDSLop";
            this.lsbDSLop.Size = new System.Drawing.Size(180, 250);
            this.lsbDSLop.TabIndex = 3;
            this.lsbDSLop.SelectedIndexChanged += new System.EventHandler(this.lsbDSLop_SelectedIndexChanged);
            // 
            // lsvSinhVien
            // 
            this.lsvSinhVien.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colMaSV,
            this.colTenSV,
            this.colGioiTinh,
            this.colQueQuan});
            this.lsvSinhVien.FullRowSelect = true;
            this.lsvSinhVien.GridLines = true;
            this.lsvSinhVien.Location = new System.Drawing.Point(240, 80);
            this.lsvSinhVien.Name = "lsvSinhVien";
            this.lsvSinhVien.Size = new System.Drawing.Size(400, 250);
            this.lsvSinhVien.TabIndex = 4;
            this.lsvSinhVien.UseCompatibleStateImageBehavior = false;
            this.lsvSinhVien.View = System.Windows.Forms.View.Details;
            // 
            // colMaSV
            // 
            this.colMaSV.Text = "Mã SV";
            this.colMaSV.Width = 80;
            // 
            // colTenSV
            // 
            this.colTenSV.Text = "Tên SV";
            this.colTenSV.Width = 130;
            // 
            // colGioiTinh
            // 
            this.colGioiTinh.Text = "Giới tính";
            this.colGioiTinh.Width = 80;
            // 
            // colQueQuan
            // 
            this.colQueQuan.Text = "Quê quán";
            this.colQueQuan.Width = 110;
            // 
            // Form5
            // 
            this.ClientSize = new System.Drawing.Size(670, 360);
            this.Controls.Add(this.lsvSinhVien);
            this.Controls.Add(this.lsbDSLop);
            this.Controls.Add(this.lblDSSV);
            this.Controls.Add(this.lblDSLop);
            this.Controls.Add(this.lblTitle);
            this.Name = "Form5";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form5";
            this.Load += new System.EventHandler(this.Form5_Load);
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblDSLop;
        private System.Windows.Forms.Label lblDSSV;
        private System.Windows.Forms.ListBox lsbDSLop;
        private System.Windows.Forms.ListView lsvSinhVien;
        private System.Windows.Forms.ColumnHeader colMaSV;
        private System.Windows.Forms.ColumnHeader colTenSV;
        private System.Windows.Forms.ColumnHeader colGioiTinh;
        private System.Windows.Forms.ColumnHeader colQueQuan;
    }
}
