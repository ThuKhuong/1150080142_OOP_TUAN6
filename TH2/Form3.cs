using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace TH2
{
    public partial class Form3 : Form
    {
        string strCon = @"Data Source=PC-ASUS;Initial Catalog=TESTVS;Integrated Security=True;Encrypt=False;TrustServerCertificate=True;";
        SqlConnection sqlCon = null;

        public Form3()
        {
            InitializeComponent();
        }

        private void btnXemThongTin_Click(object sender, EventArgs e)
        {
            try
            {
                if (sqlCon == null)
                    sqlCon = new SqlConnection(strCon);

                if (sqlCon.State == ConnectionState.Closed)
                    sqlCon.Open();

                string maSV = txtNhapMaSV.Text.Trim();

                SqlCommand sqlCmd = new SqlCommand();
                sqlCmd.CommandType = CommandType.Text;
                sqlCmd.CommandText = "SELECT * FROM SinhVien WHERE MaSV = @maSV";
                sqlCmd.Parameters.AddWithValue("@maSV", maSV);
                sqlCmd.Connection = sqlCon;

                SqlDataReader reader = sqlCmd.ExecuteReader();

                if (reader.Read())
                {
                    txtTenSV.Text = reader.GetString(1);
                    txtGioiTinh.Text = reader.GetString(2);
                    txtNgaySinh.Text = reader.GetDateTime(3).ToString("dd/MM/yyyy");
                    txtQueQuan.Text = reader.GetString(4);
                    txtMaLop.Text = reader.GetString(5);
                }
                else
                {
                    MessageBox.Show("Không tìm thấy sinh viên có mã: " + maSV);
                    txtTenSV.Clear();
                    txtGioiTinh.Clear();
                    txtNgaySinh.Clear();
                    txtQueQuan.Clear();
                    txtMaLop.Clear();
                }

                reader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }
    }
}
