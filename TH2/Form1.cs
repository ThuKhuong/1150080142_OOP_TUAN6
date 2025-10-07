using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace TH2
{
    public partial class Form1 : Form
    {
        // 🔹 Khai báo kết nối toàn cục
        SqlConnection sqlCon = null;
        string strCon = @"Data Source=PC-ASUS;Initial Catalog=TESTVS;Integrated Security=True;Encrypt=False;TrustServerCertificate=True;";

        public Form1()
        {
            InitializeComponent();
        }

        // 🔹 Nút mở kết nối
        private void btnMoKetNoi_Click(object sender, EventArgs e)
        {
            try
            {
                if (sqlCon == null)
                    sqlCon = new SqlConnection(strCon);

                if (sqlCon.State == ConnectionState.Closed)
                {
                    sqlCon.Open();
                    MessageBox.Show("Kết nối thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Kết nối đã mở rồi!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi mở kết nối: " + ex.Message);
            }
        }

        // 🔹 Nút đóng kết nối
        private void btnDongKetNoi_Click(object sender, EventArgs e)
        {
            try
            {
                if (sqlCon != null && sqlCon.State == ConnectionState.Open)
                {
                    sqlCon.Close();
                    MessageBox.Show("Đóng kết nối thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Chưa mở kết nối để đóng!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi đóng kết nối: " + ex.Message);
            }
        }

        // 🔹 Sự kiện khi Form load
        private void Form1_Load(object sender, EventArgs e)
        {
            // Có thể để trống hoặc thêm mã khởi tạo
        }
    }
}
