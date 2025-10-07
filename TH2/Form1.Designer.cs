
namespace TH2
{
    partial class Form1
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

        private void InitializeComponent()
        {
            this.btnMoKetNoi = new System.Windows.Forms.Button();
            this.btnDongKetNoi = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnMoKetNoi
            // 
            this.btnMoKetNoi.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnMoKetNoi.Location = new System.Drawing.Point(250, 120);
            this.btnMoKetNoi.Name = "btnMoKetNoi";
            this.btnMoKetNoi.Size = new System.Drawing.Size(300, 60);
            this.btnMoKetNoi.TabIndex = 0;
            this.btnMoKetNoi.Text = "Mở kết nối";
            this.btnMoKetNoi.UseVisualStyleBackColor = true;
            this.btnMoKetNoi.Click += new System.EventHandler(this.btnMoKetNoi_Click);
            // 
            // btnDongKetNoi
            // 
            this.btnDongKetNoi.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnDongKetNoi.Location = new System.Drawing.Point(250, 220);
            this.btnDongKetNoi.Name = "btnDongKetNoi";
            this.btnDongKetNoi.Size = new System.Drawing.Size(300, 60);
            this.btnDongKetNoi.TabIndex = 1;
            this.btnDongKetNoi.Text = "Đóng kết nối";
            this.btnDongKetNoi.UseVisualStyleBackColor = true;
            this.btnDongKetNoi.Click += new System.EventHandler(this.btnDongKetNoi_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnDongKetNoi);
            this.Controls.Add(this.btnMoKetNoi);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Thực hành 1 - Kết nối CSDL";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
        }

        

        #endregion

        private System.Windows.Forms.Button btnMoKetNoi;
        private System.Windows.Forms.Button btnDongKetNoi;
    }
}
