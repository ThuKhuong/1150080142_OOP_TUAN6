using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace TH2
{
    public partial class Form5 : Form
    {
        string strCon = @"Data Source=PC-ASUS;Initial Catalog=TESTVS;Integrated Security=True;Encrypt=False;TrustServerCertificate=True;";
        SqlConnection sqlCon = null;

        public Form5()
        {
            InitializeComponent();
        }

        
        private void Form5_Load(object sender, EventArgs e)
        {
            try
            {
                if (sqlCon == null)
                    sqlCon = new SqlConnection(strCon);
                if (sqlCon.State == ConnectionState.Closed)
                    sqlCon.Open();

                SqlCommand sqlCmd = new SqlCommand("SELECT MaLop, TenLop FROM Lop", sqlCon);
                SqlDataReader reader = sqlCmd.ExecuteReader();

                while (reader.Read())
                {
                    string maLop = reader.GetString(0);
                    string tenLop = reader.GetString(1);
                    // Hiển thị tên lớp, nhưng giữ MaLop để truy vấn
                    lsbDSLop.Items.Add($"{maLop} - {tenLop}");
                }

                reader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi tải danh sách lớp: " + ex.Message);
            }
        }

        // Khi chọn lớp -> hiển thị sinh viên của lớp đó
        private void lsbDSLop_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lsbDSLop.SelectedItem == null)
                return;

            try
            {
                // Lấy mã lớp từ item (chuỗi dạng: CT101 - Lớp CNTT 1)
                string selected = lsbDSLop.SelectedItem.ToString();
                string maLop = selected.Split('-')[0].Trim();

                // Xóa dữ liệu cũ
                lsvSinhVien.Items.Clear();

                if (sqlCon.State == ConnectionState.Closed)
                    sqlCon.Open();

                SqlCommand sqlCmd = new SqlCommand();
                sqlCmd.CommandType = CommandType.Text;
                sqlCmd.CommandText = "SELECT MaSV, TenSV, GioiTinh, QueQuan FROM SinhVien WHERE MaLop = @maLop";
                sqlCmd.Parameters.AddWithValue("@maLop", maLop);
                sqlCmd.Connection = sqlCon;

                SqlDataReader reader = sqlCmd.ExecuteReader();

                while (reader.Read())
                {
                    string maSV = reader.GetString(0);
                    string tenSV = reader.GetString(1);
                    string gioiTinh = reader.GetString(2);
                    string queQuan = reader.GetString(4 - 1); // index 3

                    ListViewItem lvi = new ListViewItem(maSV);
                    lvi.SubItems.Add(tenSV);
                    lvi.SubItems.Add(gioiTinh);
                    lvi.SubItems.Add(queQuan);

                    lsvSinhVien.Items.Add(lvi);
                }

                reader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi hiển thị sinh viên: " + ex.Message);
            }
        }
    }
}
