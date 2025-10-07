using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace TH2
{
    public partial class Form4 : Form
    {
        string strCon = @"Data Source=PC-ASUS;Initial Catalog=TESTVS;Integrated Security=True;Encrypt=False;TrustServerCertificate=True;";
        SqlConnection sqlCon = null;

        public Form4()
        {
            InitializeComponent();
        }

        private void btnXemDS_Click(object sender, EventArgs e)
        {
            try
            {
                // Mở kết nối
                if (sqlCon == null)
                    sqlCon = new SqlConnection(strCon);
                if (sqlCon.State == ConnectionState.Closed)
                    sqlCon.Open();

                // Lấy thông tin khoa từ textbox
                string tenKhoa = txtNhapTenKhoa.Text.Trim();
                string maKhoa = "";

                if (tenKhoa == "Công nghệ thông tin")
                    maKhoa = "CTT";
                else if (tenKhoa == "Cơ khí")
                    maKhoa = "CK";
                else if (tenKhoa == "Điện tử")
                    maKhoa = "DT";
                else if (tenKhoa == "Kinh tế")
                    maKhoa = "KT";
                else
                {
                    MessageBox.Show("Tên khoa không hợp lệ!");
                    return;
                }

                // Xóa dữ liệu cũ trên ListView
                lsvDanhSach.Items.Clear();

                // Tạo đối tượng truy vấn có tham số
                SqlCommand sqlCmd = new SqlCommand();
                sqlCmd.CommandType = CommandType.Text;
                sqlCmd.CommandText = "SELECT * FROM Lop WHERE MaKhoa = @maKhoa";
                sqlCmd.Parameters.Add(new SqlParameter("@maKhoa", SqlDbType.Char)).Value = maKhoa;
                sqlCmd.Connection = sqlCon;

                // Thực thi truy vấn
                SqlDataReader reader = sqlCmd.ExecuteReader();

                while (reader.Read())
                {
                    string maLop = reader.GetString(0);
                    string tenLop = reader.GetString(1);

                    ListViewItem lvi = new ListViewItem(tenLop);
                    lvi.SubItems.Add(maLop);
                    lsvDanhSach.Items.Add(lvi);
                }

                reader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }

        private void Form4_Load(object sender, EventArgs e)
        {

        }
    }
}
