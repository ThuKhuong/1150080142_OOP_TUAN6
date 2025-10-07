namespace TH2
{
    partial class Form4
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
            lblTenKhoa = new Label();
            txtNhapTenKhoa = new TextBox();
            btnXemDS = new Button();
            lsvDanhSach = new ListView();
            colTenLop = new ColumnHeader();
            colMaLop = new ColumnHeader();
            SuspendLayout();
            // 
            // lblTenKhoa
            // 
            lblTenKhoa.AutoSize = true;
            lblTenKhoa.Location = new Point(74, 85);
            lblTenKhoa.Margin = new Padding(6, 0, 6, 0);
            lblTenKhoa.Name = "lblTenKhoa";
            lblTenKhoa.Size = new Size(178, 32);
            lblTenKhoa.TabIndex = 0;
            lblTenKhoa.Text = "Nhập tên khoa:";
            // 
            // txtNhapTenKhoa
            // 
            txtNhapTenKhoa.Location = new Point(279, 79);
            txtNhapTenKhoa.Margin = new Padding(6, 6, 6, 6);
            txtNhapTenKhoa.Name = "txtNhapTenKhoa";
            txtNhapTenKhoa.Size = new Size(424, 39);
            txtNhapTenKhoa.TabIndex = 1;
            // 
            // btnXemDS
            // 
            btnXemDS.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnXemDS.Location = new Point(279, 160);
            btnXemDS.Margin = new Padding(6, 6, 6, 6);
            btnXemDS.Name = "btnXemDS";
            btnXemDS.Size = new Size(427, 85);
            btnXemDS.TabIndex = 2;
            btnXemDS.Text = "Xem danh sách";
            btnXemDS.UseVisualStyleBackColor = true;
            btnXemDS.Click += btnXemDS_Click;
            // 
            // lsvDanhSach
            // 
            lsvDanhSach.Columns.AddRange(new ColumnHeader[] { colTenLop, colMaLop });
            lsvDanhSach.FullRowSelect = true;
            lsvDanhSach.GridLines = true;
            lsvDanhSach.Location = new Point(74, 299);
            lsvDanhSach.Margin = new Padding(6, 6, 6, 6);
            lsvDanhSach.Name = "lsvDanhSach";
            lsvDanhSach.Size = new Size(739, 422);
            lsvDanhSach.TabIndex = 3;
            lsvDanhSach.UseCompatibleStateImageBehavior = false;
            lsvDanhSach.View = View.Details;
            // 
            // colTenLop
            // 
            colTenLop.Text = "Tên lớp";
            colTenLop.Width = 200;
            // 
            // colMaLop
            // 
            colMaLop.Text = "Mã lớp";
            colMaLop.Width = 100;
            // 
            // Form4
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(929, 811);
            Controls.Add(lsvDanhSach);
            Controls.Add(btnXemDS);
            Controls.Add(txtNhapTenKhoa);
            Controls.Add(lblTenKhoa);
            Margin = new Padding(6, 6, 6, 6);
            Name = "Form4";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form4";
            Load += Form4_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label lblTenKhoa;
        private System.Windows.Forms.TextBox txtNhapTenKhoa;
        private System.Windows.Forms.Button btnXemDS;
        private System.Windows.Forms.ListView lsvDanhSach;
        private System.Windows.Forms.ColumnHeader colTenLop;
        private System.Windows.Forms.ColumnHeader colMaLop;
    }
}
