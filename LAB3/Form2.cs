using System;
using System.Windows.Forms;

namespace ThucHanh2
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        // Nút Thêm
        private void btnThem_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtHoTen.Text))
            {
                MessageBox.Show("Họ tên không được để trống!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtHoTen.Focus();
                return;
            }

            int stt = lvSinhVien.Items.Count + 1;
            ListViewItem item = new ListViewItem(stt.ToString());
            item.SubItems.Add(txtHoTen.Text);
            item.SubItems.Add(dtpNgaySinh.Text);
            item.SubItems.Add(txtLop.Text);
            item.SubItems.Add(txtDiaChi.Text);
            lvSinhVien.Items.Add(item);

            ClearInput();
        }

        // Nút Xóa 
        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (lvSinhVien.SelectedItems.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn 1 dòng để xóa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            lvSinhVien.Items.Remove(lvSinhVien.SelectedItems[0]);
            CapNhatSTT();
            ClearInput();
        }

        // Nút Sửa
        private void btnSua_Click(object sender, EventArgs e)
        {
            if (lvSinhVien.SelectedItems.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn 1 dòng để sửa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            ListViewItem item = lvSinhVien.SelectedItems[0];
            item.SubItems[1].Text = txtHoTen.Text;
            item.SubItems[2].Text = dtpNgaySinh.Text;
            item.SubItems[3].Text = txtLop.Text;
            item.SubItems[4].Text = txtDiaChi.Text;
        }

        // Nút Thoát
        private void btnThoat_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc muốn thoát không?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                this.Close();
        }

        // Khi chọn dòng trong ListView
        private void lvSinhVien_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvSinhVien.SelectedItems.Count > 0)
            {
                ListViewItem item = lvSinhVien.SelectedItems[0];
                txtHoTen.Text = item.SubItems[1].Text;
                dtpNgaySinh.Text = item.SubItems[2].Text;
                txtLop.Text = item.SubItems[3].Text;
                txtDiaChi.Text = item.SubItems[4].Text;
            }
        }

        // Hàm làm trống ô nhập
        private void ClearInput()
        {
            txtHoTen.Clear();
            txtLop.Clear();
            txtDiaChi.Clear();
            dtpNgaySinh.Value = DateTime.Now;
        }

        // Cập nhật lại STT sau khi xóa
        private void CapNhatSTT()
        {
            for (int i = 0; i < lvSinhVien.Items.Count; i++)
            {
                lvSinhVien.Items[i].SubItems[0].Text = (i + 1).ToString();
            }
        }
    }
}
