namespace TH2
{
    partial class Form3
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
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
            this.lblMaSV = new System.Windows.Forms.Label();
            this.txtNhapMaSV = new System.Windows.Forms.TextBox();
            this.btnXemThongTin = new System.Windows.Forms.Button();
            this.txtTenSV = new System.Windows.Forms.TextBox();
            this.txtGioiTinh = new System.Windows.Forms.TextBox();
            this.txtNgaySinh = new System.Windows.Forms.TextBox();
            this.txtQueQuan = new System.Windows.Forms.TextBox();
            this.txtMaLop = new System.Windows.Forms.TextBox();
            this.lblTenSV = new System.Windows.Forms.Label();
            this.lblGioiTinh = new System.Windows.Forms.Label();
            this.lblNgaySinh = new System.Windows.Forms.Label();
            this.lblQueQuan = new System.Windows.Forms.Label();
            this.lblMaLop = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.Navy;
            this.lblTitle.Location = new System.Drawing.Point(140, 20);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(241, 25);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "TRA CỨU THÔNG TIN SINH VIÊN";
            // 
            // lblMaSV
            // 
            this.lblMaSV.AutoSize = true;
            this.lblMaSV.Location = new System.Drawing.Point(50, 70);
            this.lblMaSV.Name = "lblMaSV";
            this.lblMaSV.Size = new System.Drawing.Size(98, 15);
            this.lblMaSV.TabIndex = 1;
            this.lblMaSV.Text = "Nhập mã sinh viên:";
            // 
            // txtNhapMaSV
            // 
            this.txtNhapMaSV.Location = new System.Drawing.Point(170, 67);
            this.txtNhapMaSV.Name = "txtNhapMaSV";
            this.txtNhapMaSV.Size = new System.Drawing.Size(180, 23);
            this.txtNhapMaSV.TabIndex = 2;
            // 
            // btnXemThongTin
            // 
            this.btnXemThongTin.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnXemThongTin.Location = new System.Drawing.Point(370, 65);
            this.btnXemThongTin.Name = "btnXemThongTin";
            this.btnXemThongTin.Size = new System.Drawing.Size(120, 30);
            this.btnXemThongTin.TabIndex = 3;
            this.btnXemThongTin.Text = "Xem thông tin";
            this.btnXemThongTin.UseVisualStyleBackColor = true;
            this.btnXemThongTin.Click += new System.EventHandler(this.btnXemThongTin_Click);
            // 
            // Labels và TextBox hiển thị thông tin
            // 
            this.lblTenSV.AutoSize = true;
            this.lblTenSV.Location = new System.Drawing.Point(50, 120);
            this.lblTenSV.Text = "Tên sinh viên:";
            this.txtTenSV.Location = new System.Drawing.Point(170, 117);
            this.txtTenSV.Size = new System.Drawing.Size(320, 23);

            this.lblGioiTinh.AutoSize = true;
            this.lblGioiTinh.Location = new System.Drawing.Point(50, 160);
            this.lblGioiTinh.Text = "Giới tính:";
            this.txtGioiTinh.Location = new System.Drawing.Point(170, 157);
            this.txtGioiTinh.Size = new System.Drawing.Size(120, 23);

            this.lblNgaySinh.AutoSize = true;
            this.lblNgaySinh.Location = new System.Drawing.Point(50, 200);
            this.lblNgaySinh.Text = "Ngày sinh:";
            this.txtNgaySinh.Location = new System.Drawing.Point(170, 197);
            this.txtNgaySinh.Size = new System.Drawing.Size(150, 23);

            this.lblQueQuan.AutoSize = true;
            this.lblQueQuan.Location = new System.Drawing.Point(50, 240);
            this.lblQueQuan.Text = "Quê quán:";
            this.txtQueQuan.Location = new System.Drawing.Point(170, 237);
            this.txtQueQuan.Size = new System.Drawing.Size(320, 23);

            this.lblMaLop.AutoSize = true;
            this.lblMaLop.Location = new System.Drawing.Point(50, 280);
            this.lblMaLop.Text = "Mã lớp:";
            this.txtMaLop.Location = new System.Drawing.Point(170, 277);
            this.txtMaLop.Size = new System.Drawing.Size(120, 23);

            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(540, 340);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.lblMaSV);
            this.Controls.Add(this.txtNhapMaSV);
            this.Controls.Add(this.btnXemThongTin);
            this.Controls.Add(this.lblTenSV);
            this.Controls.Add(this.txtTenSV);
            this.Controls.Add(this.lblGioiTinh);
            this.Controls.Add(this.txtGioiTinh);
            this.Controls.Add(this.lblNgaySinh);
            this.Controls.Add(this.txtNgaySinh);
            this.Controls.Add(this.lblQueQuan);
            this.Controls.Add(this.txtQueQuan);
            this.Controls.Add(this.lblMaLop);
            this.Controls.Add(this.txtMaLop);
            this.Name = "Form3";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form3";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblMaSV;
        private System.Windows.Forms.TextBox txtNhapMaSV;
        private System.Windows.Forms.Button btnXemThongTin;
        private System.Windows.Forms.TextBox txtTenSV;
        private System.Windows.Forms.TextBox txtGioiTinh;
        private System.Windows.Forms.TextBox txtNgaySinh;
        private System.Windows.Forms.TextBox txtQueQuan;
        private System.Windows.Forms.TextBox txtMaLop;
        private System.Windows.Forms.Label lblTenSV;
        private System.Windows.Forms.Label lblGioiTinh;
        private System.Windows.Forms.Label lblNgaySinh;
        private System.Windows.Forms.Label lblQueQuan;
        private System.Windows.Forms.Label lblMaLop;
    }
}
