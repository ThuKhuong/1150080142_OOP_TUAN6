namespace ThucHanh2
{
    partial class Form2
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblHoTen;
        private System.Windows.Forms.Label lblLop;
        private System.Windows.Forms.Label lblNgaySinh;
        private System.Windows.Forms.Label lblDiaChi;
        private System.Windows.Forms.TextBox txtHoTen;
        private System.Windows.Forms.TextBox txtLop;
        private System.Windows.Forms.TextBox txtDiaChi;
        private System.Windows.Forms.DateTimePicker dtpNgaySinh;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.ListView lvSinhVien;
        private System.Windows.Forms.ColumnHeader colSTT;
        private System.Windows.Forms.ColumnHeader colHoTen;
        private System.Windows.Forms.ColumnHeader colNgaySinh;
        private System.Windows.Forms.ColumnHeader colLop;
        private System.Windows.Forms.ColumnHeader colDiaChi;
        private System.Windows.Forms.GroupBox grpThongTin;
        private System.Windows.Forms.GroupBox grpChucNang;
        private System.Windows.Forms.GroupBox grpDanhSach;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            lblTitle = new Label();
            grpThongTin = new GroupBox();
            lblHoTen = new Label();
            txtHoTen = new TextBox();
            lblLop = new Label();
            txtLop = new TextBox();
            lblNgaySinh = new Label();
            dtpNgaySinh = new DateTimePicker();
            lblDiaChi = new Label();
            txtDiaChi = new TextBox();
            grpChucNang = new GroupBox();
            btnThem = new Button();
            btnSua = new Button();
            btnXoa = new Button();
            btnThoat = new Button();
            grpDanhSach = new GroupBox();
            lvSinhVien = new ListView();
            colSTT = new ColumnHeader();
            colHoTen = new ColumnHeader();
            colNgaySinh = new ColumnHeader();
            colLop = new ColumnHeader();
            colDiaChi = new ColumnHeader();
            grpThongTin.SuspendLayout();
            grpChucNang.SuspendLayout();
            grpDanhSach.SuspendLayout();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.Dock = DockStyle.Top;
            lblTitle.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            lblTitle.ForeColor = Color.RoyalBlue;
            lblTitle.Location = new Point(0, 0);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(740, 60);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "DANH MỤC SINH VIÊN";
            lblTitle.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // grpThongTin
            // 
            grpThongTin.Controls.Add(lblHoTen);
            grpThongTin.Controls.Add(txtHoTen);
            grpThongTin.Controls.Add(lblLop);
            grpThongTin.Controls.Add(txtLop);
            grpThongTin.Controls.Add(lblNgaySinh);
            grpThongTin.Controls.Add(dtpNgaySinh);
            grpThongTin.Controls.Add(lblDiaChi);
            grpThongTin.Controls.Add(txtDiaChi);
            grpThongTin.Font = new Font("Segoe UI", 9F);
            grpThongTin.Location = new Point(30, 70);
            grpThongTin.Name = "grpThongTin";
            grpThongTin.Padding = new Padding(10, 15, 10, 15);
            grpThongTin.Size = new Size(680, 170);
            grpThongTin.TabIndex = 1;
            grpThongTin.TabStop = false;
            grpThongTin.Text = "Thông tin sinh viên";
            // 
            // lblHoTen
            // 
            lblHoTen.Location = new Point(25, 40);
            lblHoTen.Name = "lblHoTen";
            lblHoTen.Size = new Size(100, 35);
            lblHoTen.TabIndex = 0;
            lblHoTen.Text = "Họ tên:";
            // 
            // txtHoTen
            // 
            txtHoTen.Location = new Point(131, 36);
            txtHoTen.Name = "txtHoTen";
            txtHoTen.Size = new Size(201, 39);
            txtHoTen.TabIndex = 1;
            // 
            // lblLop
            // 
            lblLop.Location = new Point(360, 40);
            lblLop.Name = "lblLop";
            lblLop.Size = new Size(65, 35);
            lblLop.TabIndex = 2;
            lblLop.Text = "Lớp:";
            // 
            // txtLop
            // 
            txtLop.Location = new Point(431, 36);
            txtLop.Name = "txtLop";
            txtLop.Size = new Size(209, 39);
            txtLop.TabIndex = 3;
            // 
            // lblNgaySinh
            // 
            lblNgaySinh.Location = new Point(25, 95);
            lblNgaySinh.Name = "lblNgaySinh";
            lblNgaySinh.Size = new Size(100, 35);
            lblNgaySinh.TabIndex = 4;
            lblNgaySinh.Text = "Ngày sinh:";
            // 
            // dtpNgaySinh
            // 
            dtpNgaySinh.Format = DateTimePickerFormat.Short;
            dtpNgaySinh.Location = new Point(131, 91);
            dtpNgaySinh.Name = "dtpNgaySinh";
            dtpNgaySinh.Size = new Size(201, 39);
            dtpNgaySinh.TabIndex = 5;
            // 
            // lblDiaChi
            // 
            lblDiaChi.Location = new Point(360, 95);
            lblDiaChi.Name = "lblDiaChi";
            lblDiaChi.Size = new Size(100, 39);
            lblDiaChi.TabIndex = 6;
            lblDiaChi.Text = "Địa chỉ:";
            // 
            // txtDiaChi
            // 
            txtDiaChi.Location = new Point(466, 91);
            txtDiaChi.Name = "txtDiaChi";
            txtDiaChi.Size = new Size(174, 39);
            txtDiaChi.TabIndex = 7;
            // 
            // grpChucNang
            // 
            grpChucNang.Controls.Add(btnThem);
            grpChucNang.Controls.Add(btnSua);
            grpChucNang.Controls.Add(btnXoa);
            grpChucNang.Controls.Add(btnThoat);
            grpChucNang.Font = new Font("Segoe UI", 9F);
            grpChucNang.Location = new Point(30, 260);
            grpChucNang.Name = "grpChucNang";
            grpChucNang.Padding = new Padding(10, 15, 10, 15);
            grpChucNang.Size = new Size(680, 80);
            grpChucNang.TabIndex = 2;
            grpChucNang.TabStop = false;
            grpChucNang.Text = "Chức năng";
            // 
            // btnThem
            // 
            btnThem.Location = new Point(60, 30);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(110, 35);
            btnThem.TabIndex = 0;
            btnThem.Text = "Thêm";
            btnThem.Click += btnThem_Click;
            // 
            // btnSua
            // 
            btnSua.Location = new Point(210, 30);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(110, 35);
            btnSua.TabIndex = 1;
            btnSua.Text = "Sửa";
            btnSua.Click += btnSua_Click;
            // 
            // btnXoa
            // 
            btnXoa.Location = new Point(360, 30);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(110, 35);
            btnXoa.TabIndex = 2;
            btnXoa.Text = "Xóa";
            btnXoa.Click += btnXoa_Click;
            // 
            // btnThoat
            // 
            btnThoat.Location = new Point(510, 30);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(110, 35);
            btnThoat.TabIndex = 3;
            btnThoat.Text = "Thoát";
            btnThoat.Click += btnThoat_Click;
            // 
            // grpDanhSach
            // 
            grpDanhSach.Controls.Add(lvSinhVien);
            grpDanhSach.Font = new Font("Segoe UI", 9F);
            grpDanhSach.Location = new Point(30, 355);
            grpDanhSach.Name = "grpDanhSach";
            grpDanhSach.Padding = new Padding(10, 15, 10, 15);
            grpDanhSach.Size = new Size(680, 160);
            grpDanhSach.TabIndex = 3;
            grpDanhSach.TabStop = false;
            grpDanhSach.Text = "Thông tin chung sinh viên";
            // 
            // lvSinhVien
            // 
            lvSinhVien.Columns.AddRange(new ColumnHeader[] { colSTT, colHoTen, colNgaySinh, colLop, colDiaChi });
            lvSinhVien.FullRowSelect = true;
            lvSinhVien.GridLines = true;
            lvSinhVien.Location = new Point(15, 30);
            lvSinhVien.Name = "lvSinhVien";
            lvSinhVien.Size = new Size(650, 120);
            lvSinhVien.TabIndex = 0;
            lvSinhVien.UseCompatibleStateImageBehavior = false;
            lvSinhVien.View = View.Details;
            lvSinhVien.SelectedIndexChanged += lvSinhVien_SelectedIndexChanged;
            // 
            // colSTT
            // 
            colSTT.Text = "STT";
            colSTT.Width = 50;
            // 
            // colHoTen
            // 
            colHoTen.Text = "Họ tên";
            colHoTen.Width = 160;
            // 
            // colNgaySinh
            // 
            colNgaySinh.Text = "Ngày sinh";
            colNgaySinh.Width = 110;
            // 
            // colLop
            // 
            colLop.Text = "Lớp";
            colLop.Width = 100;
            // 
            // colDiaChi
            // 
            colDiaChi.Text = "Địa chỉ";
            colDiaChi.Width = 210;
            // 
            // Form2
            // 
            BackColor = Color.White;
            ClientSize = new Size(740, 540);
            Controls.Add(lblTitle);
            Controls.Add(grpThongTin);
            Controls.Add(grpChucNang);
            Controls.Add(grpDanhSach);
            Font = new Font("Segoe UI", 9F);
            Name = "Form2";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Danh sách sinh viên";
            grpThongTin.ResumeLayout(false);
            grpThongTin.PerformLayout();
            grpChucNang.ResumeLayout(false);
            grpDanhSach.ResumeLayout(false);
            ResumeLayout(false);
        }
    }
}
