using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace TH2
{
    public partial class Form2 : Form
    {
        string strCon = @"Data Source=PC-ASUS;Initial Catalog=TESTVS;Integrated Security=True;Encrypt=False;TrustServerCertificate=True;";
        SqlConnection sqlCon = null;

        public Form2()
        {
            InitializeComponent();
        }

        private void btnCount_Click(object sender, EventArgs e)
        {
            try
            {
                if (sqlCon == null)
                    sqlCon = new SqlConnection(strCon);

                if (sqlCon.State == ConnectionState.Closed)
                    sqlCon.Open();

                SqlCommand sqlCmd = new SqlCommand();
                sqlCmd.CommandType = CommandType.Text;
                sqlCmd.CommandText = "SELECT COUNT(*) FROM SinhVien";
                sqlCmd.Connection = sqlCon;

                int soLuongSV = (int)sqlCmd.ExecuteScalar();
                MessageBox.Show("Số lượng sinh viên là: " + soLuongSV);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }

        private void InitializeComponent()
        {
            this.btnCount = new System.Windows.Forms.Button();
            this.SuspendLayout();

            // 
            // btnCount
            // 
            this.btnCount.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.btnCount.Location = new System.Drawing.Point(100, 80);
            this.btnCount.Name = "btnCount";
            this.btnCount.Size = new System.Drawing.Size(200, 60);
            this.btnCount.TabIndex = 0;
            this.btnCount.Text = "Số lượng sinh viên";
            this.btnCount.UseVisualStyleBackColor = true;
            this.btnCount.Click += new System.EventHandler(this.btnCount_Click);

            // 
            // Form2
            // 
            this.ClientSize = new System.Drawing.Size(400, 220);
            this.Controls.Add(this.btnCount);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form2";
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Button btnCount;
    }
}
