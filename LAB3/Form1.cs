using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

namespace QuanAnNhanh
{
    public partial class Form1 : Form
    {
        private List<Button> listButtonMon;
        private Dictionary<string, int> orderList;

        public Form1()
        {
            InitializeComponent();
            orderList = new Dictionary<string, int>();
            TaoButtonMonAn();
        }

        private void TaoButtonMonAn()
        {
            string[] monAn = {
        "Cơm chiên trứng", "Bánh mì ốp la", "Coca", "Lipton",
        "Ốc rang muối", "Khoai tây chiên", "7 up", "Cam",
        "Mỳ xào hải sản", "Cá viên chiên", "Pepsi", "Cafe",
        "Buger bò nướng", "Đùi gà rán", "Bún bò Huế"
    };

            listButtonMon = new List<Button>();
            int x = 0, y = 0;

            for (int i = 0; i < monAn.Length; i++)
            {
                Button btn = new Button();
                btn.Text = monAn[i];
                btn.Size = new System.Drawing.Size(150, 40); 
                btn.Location = new System.Drawing.Point(x, y);
                btn.Margin = new Padding(10);
                btn.Click += BtnMonAn_Click;
                listButtonMon.Add(btn);
                pnlMonAn.Controls.Add(btn);

              
                x += 165;
                if ((i + 1) % 4 == 0)
                {
                    x = 0;
                    y += 45; 
                }
            }
        }


        //Khi nhấn button món ăn 
        private void BtnMonAn_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            string tenMon = btn.Text;

            if (orderList.ContainsKey(tenMon))
                orderList[tenMon]++;
            else
                orderList[tenMon] = 1;

            CapNhatBang();
        }

        private void CapNhatBang()
        {
            dgvOrder.Rows.Clear();
            foreach (var item in orderList)
            {
                dgvOrder.Rows.Add(item.Key, item.Value);
            }
        }

        private void BtnXoa_Click(object sender, EventArgs e)
        {
            orderList.Clear();
            dgvOrder.Rows.Clear();
        }

        private void BtnOrder_Click(object sender, EventArgs e)
        {
            if (cboBan.SelectedIndex == -1)
            {
                MessageBox.Show("Vui lòng chọn bàn!");
                return;
            }

            string tenBan = cboBan.SelectedItem.ToString();
            string fileName = $"Order_{tenBan.Replace(" ", "_")}.txt";

            using (StreamWriter sw = new StreamWriter(fileName))
            {
                sw.WriteLine($"=== Đơn hàng {tenBan} ===");
                foreach (var item in orderList)
                {
                    sw.WriteLine($"{item.Key}: {item.Value}");
                }
                sw.WriteLine("========================");
                sw.WriteLine($"Thời gian: {DateTime.Now}");
            }

            MessageBox.Show($"Đơn hàng đã được ghi vào tệp {fileName}");
        }
    }
}
