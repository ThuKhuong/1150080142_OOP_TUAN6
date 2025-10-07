namespace QuanAnNhanh
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.DataGridView dgvOrder;
        private System.Windows.Forms.ComboBox cboBan;
        private System.Windows.Forms.Button btnOrder;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Label lblDanhSachMon;
        private System.Windows.Forms.Panel pnlMonAn;
        private System.Windows.Forms.PictureBox pictureLogo;
        private System.Windows.Forms.Label lblTieuDe;

        /// <summary>
        ///  Dọn bộ nhớ
        /// </summary>
        /// <param name="disposing"></param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        /// <summary>
        ///  Thiết kế giao diện Form
        /// </summary>
        private void InitializeComponent()
        {
            this.dgvOrder = new System.Windows.Forms.DataGridView();
            this.cboBan = new System.Windows.Forms.ComboBox();
            this.btnOrder = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.lblDanhSachMon = new System.Windows.Forms.Label();
            this.pnlMonAn = new System.Windows.Forms.Panel();
            this.pictureLogo = new System.Windows.Forms.PictureBox();
            this.lblTieuDe = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrder)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureLogo)).BeginInit();
            this.SuspendLayout();

            // 
            // pictureLogo
            // 
            this.pictureLogo.Location = new System.Drawing.Point(10, 10);
            this.pictureLogo.Name = "pictureLogo";
            this.pictureLogo.Size = new System.Drawing.Size(100, 80);
            this.pictureLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureLogo.Image = System.Drawing.Image.FromFile("berger.jpg");
            this.pictureLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;

            // 
            // lblTieuDe
            // 
            this.lblTieuDe.Text = "Quán ăn nhanh Hưng Thịnh";
            this.lblTieuDe.Font = new System.Drawing.Font("Segoe UI", 16, System.Drawing.FontStyle.Bold);
            this.lblTieuDe.ForeColor = System.Drawing.Color.White;
            this.lblTieuDe.BackColor = System.Drawing.Color.Green;
            this.lblTieuDe.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblTieuDe.Location = new System.Drawing.Point(120, 10);
            this.lblTieuDe.Size = new System.Drawing.Size(530, 80);

            // 
            // lblDanhSachMon
            // 
            this.lblDanhSachMon.AutoSize = true;
            this.lblDanhSachMon.Text = "Danh sách món ăn:";
            this.lblDanhSachMon.Font = new System.Drawing.Font("Segoe UI", 10, System.Drawing.FontStyle.Bold);
            this.lblDanhSachMon.Location = new System.Drawing.Point(10, 100);

            // 
            // pnlMonAn
            // 
            this.pnlMonAn.Location = new System.Drawing.Point(10, 125);
            this.pnlMonAn.Size = new System.Drawing.Size(680, 200); // tăng chiều cao 20px
            this.pnlMonAn.Name = "pnlMonAn";

            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(10, 320);
            this.btnXoa.Size = new System.Drawing.Size(100, 35);
            this.btnXoa.Text = "Xóa";
            this.btnXoa.Click += new System.EventHandler(this.BtnXoa_Click);

            // 
            // cboBan
            // 
            this.cboBan.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            // cboBan
            this.cboBan.Location = new System.Drawing.Point(130, 325);
            this.cboBan.Size = new System.Drawing.Size(120, 28);
            this.cboBan.Items.AddRange(new object[] { "Bàn 1", "Bàn 2", "Bàn 3", "Bàn 4" });

            // 
            // btnOrder
            // 
            this.btnOrder.Location = new System.Drawing.Point(260, 320);
            this.btnOrder.Size = new System.Drawing.Size(100, 35);
            this.btnOrder.Text = "Order";
            this.btnOrder.Click += new System.EventHandler(this.BtnOrder_Click);

            // 
            // dgvOrder
            // 
            this.dgvOrder.Location = new System.Drawing.Point(10, 360);
            this.dgvOrder.Size = new System.Drawing.Size(660, 120);
            this.dgvOrder.ColumnCount = 2;
            this.dgvOrder.Columns[0].Name = "Tên món";
            this.dgvOrder.Columns[1].Name = "Số lượng";

            // 
            // Form1
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(680, 500);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quán ăn nhanh";
            this.Controls.Add(this.pictureLogo);
            this.Controls.Add(this.lblTieuDe);
            this.Controls.Add(this.lblDanhSachMon);
            this.Controls.Add(this.pnlMonAn);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.cboBan);
            this.Controls.Add(this.btnOrder);
            this.Controls.Add(this.dgvOrder);
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
